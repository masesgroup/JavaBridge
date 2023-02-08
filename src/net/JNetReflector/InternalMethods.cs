﻿/*
*  Copyright 2023 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

using System.IO;
using System;
using System.IO.Compression;
using System.Collections.Generic;
using Java.Lang;
using Java.Lang.Reflect;
using System.Text;
using MASES.JNetReflector.Templates;
using System.Linq;

namespace MASES.JNetReflector
{
    static class ReflectionUtils
    {
        public enum ReflectionTraceLevel
        {
            Critical,
            Error,
            Info,
            Debug,
            Trace,
            Verbose,
        }

        static int Level { get; set; }
        static EventHandler<string> TraceReportHandler { get; set; }

        public static void SetHandlerAndLevel(EventHandler<string> traceReport, int level)
        {
            TraceReportHandler = traceReport;
            Level = level;
        }

        static void ReportTrace(ReflectionTraceLevel level, string format, params object[] args)
        {
            if ((int)level > Level) return;
            try
            {
                TraceReportHandler(null, level.ToString() + ": " + string.Format(format, args));
            }
            catch (System.Exception e)
            {
                TraceReportHandler(null, e.ToString());
            }
        }

        public static void AnalyzeJar(string pathToJar, string rootDesinationFolder, bool dryRun = false)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Jar {0} *******************", pathToJar, rootDesinationFolder, dryRun);
            using (ZipArchive archive = ZipFile.OpenRead(pathToJar))
            {
                Dictionary<string, IDictionary<string, IList<ZipArchiveEntry>>> resultingArguments = new Dictionary<string, IDictionary<string, IList<ZipArchiveEntry>>>();

                foreach (var entry in archive.Entries)
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Entry {0}", entry.ToString());
                    if (entry.IsSpecialFolder()) continue; // do not reflect this folders
                    if (entry.IsSpecialClass()) continue; // do not reflect this classes
                    if (entry.IsFolder())
                    {
                        var path = Path.Combine(rootDesinationFolder, entry.Namespace().Replace(SpecialNames.NamespaceSeparator, Path.DirectorySeparatorChar));
                        ReportTrace(ReflectionTraceLevel.Info, "Create path {0}", path);
                        if (!dryRun && !Directory.Exists(path)) Directory.CreateDirectory(path);
                    }
                    if (entry.IsJVMClass() || entry.IsJVMNestedClass())
                    {
                        ReportTrace(ReflectionTraceLevel.Info, "Adding entry {0}", entry.ToString());
                        var package = entry.Namespace();
                        IDictionary<string, IList<ZipArchiveEntry>> entries;
                        if (!resultingArguments.TryGetValue(package, out entries))
                        {
                            entries = new Dictionary<string, IList<ZipArchiveEntry>>();
                            resultingArguments.Add(package, entries);
                        }
                        IList<ZipArchiveEntry> subEntries;
                        if (!entries.TryGetValue(entry.JVMClassName(), out subEntries))
                        {
                            subEntries = new List<ZipArchiveEntry>();
                            entries.Add(entry.JVMClassName(), subEntries);
                        }
                        subEntries.Add(entry);
                    }
                }

                var allPackageClasses = Template.GetTemplate(Template.AllPackageClassesTemplate);
                var jarName = Path.GetFileName(pathToJar);

                foreach (var item in resultingArguments)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var entry in item.Value)
                    {
                        var classContent = AnalyzeClass(jarName, entry.Value, rootDesinationFolder, dryRun);
                        if (!string.IsNullOrEmpty(classContent))
                        {
                            sb.AppendLine(classContent);
                            sb.AppendLine();
                        }
                    }

                    var itemPackage = allPackageClasses.Replace(AllPackageClasses.VERSION, SpecialNames.VersionPlaceHolder())
                                                       .Replace(AllPackageClasses.JAR, jarName)
                                                       .Replace(AllPackageClasses.NAMESPACE, item.Key)
                                                       .Replace(AllPackageClasses.CLASSES, sb.ToString());

                    var path = Path.Combine(rootDesinationFolder, item.Key.Replace(SpecialNames.NamespaceSeparator, Path.DirectorySeparatorChar), "AllPackageClasses.cs");
                    if (!dryRun)
                    {
                        if (File.Exists(path)) File.Delete(path);
                        File.WriteAllText(path, itemPackage);
                    }
                }
            }
        }

        static string AnalyzeClass(string jarName, IList<ZipArchiveEntry> classDefinitions, string rootDesinationFolder, bool dryRun)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* AnalyzeClass {0} *******************", jarName);

            bool mainClassDone = false;
            var allPackageStubNestedClass = Template.GetTemplate(Template.AllPackageClassesStubNestedClassTemplate);
            var allPackageStubNestedException = Template.GetTemplate(Template.AllPackageClassesStubNestedExceptionTemplate);
            var allPackageStubClass = Template.GetTemplate(Template.AllPackageClassesStubClassTemplate);
            var allPackageStubException = Template.GetTemplate(Template.AllPackageClassesStubExceptionTemplate);
            var singleClassTemplate = Template.GetTemplate(Template.SingleClassTemplate);
            var singleNestedClassTemplate = Template.GetTemplate(Template.SingleNestedClassTemplate);

            StringBuilder subClassBlock = new StringBuilder();
            StringBuilder subClassAutonoumous = new StringBuilder();
            ZipArchiveEntry mainClass = null;

            foreach (var entry in classDefinitions)
            {
                if (entry.IsJVMNestedClass())
                {
                    string nestedConstructorBlock = string.Empty;
                    string nestedFieldBlock = string.Empty;
                    string nestedStaticMethodBlock = string.Empty;
                    string nestedMethodBlock = string.Empty;
                    var jSubClass = entry.JVMClass();
                    bool jSubClassIsDepracated = jSubClass.IsDeprecated();
                    if (!JNetReflectorCore.ReflectDeprecated && jSubClassIsDepracated) continue;

                    bool jSubClassIsOrFromGeneric = jSubClass.IsOrInheritFromJVMGenericClass();

                    string nestedClassBlock;

                    ReportTrace(ReflectionTraceLevel.Info, "Preparing nested class {0}", jSubClass.GenericString);

                    if (jSubClass.IsJVMException())
                    {
                        nestedClassBlock = allPackageStubNestedException.Replace(AllPackageClasses.ClassStub.NestedClassStub.JAVACLASS, entry.JVMFullClassName())
                                                                        .Replace(AllPackageClasses.ClassStub.NestedClassStub.CLASS, entry.JVMNestedClassName())
                                                                        .Replace(AllPackageClasses.ClassStub.NestedClassStub.HELP, entry.JavadocUrl())
                                                                        .Replace(AllPackageClasses.ClassStub.NestedClassStub.BASECLASS, entry.JVMBaseClassName());
                    }
                    else
                    {
                        bool isSubClassCloseable = false; // to be defined
                        bool isSubClassAbstract = jSubClass.IsAbstract();
                        bool isSubClassInterface = jSubClass.IsInterface();
                        bool isSubClassStatic = jSubClass.IsStatic();

                        nestedClassBlock = allPackageStubNestedClass.Replace(AllPackageClasses.ClassStub.NestedClassStub.JAVACLASS, entry.JVMFullClassName())
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.CLASS, entry.JVMNestedClassName())
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.HELP, entry.JavadocUrl())
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.BASECLASS, entry.JVMBaseClassName())
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.ISABSTRACT, isSubClassAbstract ? "true" : "false")
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.ISCLOSEABLE, isSubClassCloseable ? "true" : "false")
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.ISINTERFACE, isSubClassInterface ? "true" : "false")
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.ISSTATIC, isSubClassStatic ? "true" : "false");

                        nestedConstructorBlock = jSubClass.AnalyzeConstructors(classDefinitions).AddTabLevel(2);
                        nestedFieldBlock = jSubClass.AnalyzeFields(classDefinitions).AddTabLevel(2);
                        nestedStaticMethodBlock = jSubClass.AnalyzeMethods(classDefinitions, true).AddTabLevel(2);
                        nestedMethodBlock = jSubClass.AnalyzeMethods(classDefinitions, false).AddTabLevel(2);
                    }

                    subClassBlock.AppendLine(nestedClassBlock);
                    subClassBlock.AppendLine();

                    StringBuilder jSubClassDecoration = new StringBuilder(AllPackageClasses.ClassStub.NestedClassStub.DEFAULT_DECORATION);
                    if (jSubClassIsDepracated)
                    {
                        jSubClassDecoration.AppendLine();
                        jSubClassDecoration.Append(AllPackageClasses.ClassStub.NestedClassStub.OBSOLETE_DECORATION);
                    }

                    var singleNestedClassStr = singleNestedClassTemplate.Replace(AllPackageClasses.ClassStub.NestedClassStub.DECORATION, jSubClassDecoration.ToString())
                                                                        .Replace(AllPackageClasses.ClassStub.NestedClassStub.CLASS, entry.JVMNestedClassName())
                                                                        .Replace(AllPackageClasses.ClassStub.NestedClassStub.CONSTRUCTORS, nestedConstructorBlock)
                                                                        .Replace(AllPackageClasses.ClassStub.NestedClassStub.FIELDS, nestedFieldBlock)
                                                                        .Replace(AllPackageClasses.ClassStub.NestedClassStub.STATICMETHODS, nestedStaticMethodBlock)
                                                                        .Replace(AllPackageClasses.ClassStub.NestedClassStub.METHODS, nestedMethodBlock);

                    subClassAutonoumous.AppendLine(singleNestedClassStr);
                    subClassAutonoumous.AppendLine();
                }

                if (entry.IsJVMClass())
                {
                    if (mainClassDone) throw new InvalidOperationException("Too many main class");
                    mainClassDone = true;
                    mainClass = entry;
                    ReportTrace(ReflectionTraceLevel.Info, "Identified main class {0}", mainClass.ToString());
                }
            }

            if (!mainClassDone) return string.Empty;

            var jClass = mainClass.JVMClass();
            bool jClassIsDepracated = jClass.IsDeprecated();
            if (!JNetReflectorCore.ReflectDeprecated && jClassIsDepracated)
            {
                ReportTrace(ReflectionTraceLevel.Info, "Discarded deprecated main class {0}", jClass.GenericString);
                return string.Empty;
            }
            bool jClassIsOrFromGeneric = jClass.IsOrInheritFromJVMGenericClass();

            ReportTrace(ReflectionTraceLevel.Info, "Preparing main class {0}", jClass.GenericString);

            string classBlock;
            string constructorBlock = string.Empty;
            string fieldBlock = string.Empty;
            string staticMethodBlock = string.Empty;
            string methodBlock = string.Empty;
            if (jClass.IsJVMException())
            {
                classBlock = allPackageStubException.Replace(AllPackageClasses.ClassStub.JAVACLASS, mainClass.JVMFullClassName())
                                                    .Replace(AllPackageClasses.ClassStub.CLASS, mainClass.JVMClassName())
                                                    .Replace(AllPackageClasses.ClassStub.HELP, mainClass.JavadocUrl())
                                                    .Replace(AllPackageClasses.ClassStub.BASECLASS, mainClass.JVMBaseClassName());
            }
            else
            {
                bool isClassCloseable = false; // to be defined
                bool isClassAbstract = jClass.IsAbstract();
                bool isClassInterface = jClass.IsInterface();
                bool isClassStatic = jClass.IsStatic();
                classBlock = allPackageStubClass.Replace(AllPackageClasses.ClassStub.JAVACLASS, mainClass.JVMFullClassName())
                                                .Replace(AllPackageClasses.ClassStub.CLASS, mainClass.JVMClassName())
                                                .Replace(AllPackageClasses.ClassStub.HELP, mainClass.JavadocUrl())
                                                .Replace(AllPackageClasses.ClassStub.BASECLASS, mainClass.JVMBaseClassName())
                                                .Replace(AllPackageClasses.ClassStub.ISABSTRACT, isClassAbstract ? "true" : "false")
                                                .Replace(AllPackageClasses.ClassStub.ISCLOSEABLE, isClassCloseable ? "true" : "false")
                                                .Replace(AllPackageClasses.ClassStub.ISINTERFACE, isClassInterface ? "true" : "false")
                                                .Replace(AllPackageClasses.ClassStub.ISSTATIC, isClassStatic ? "true" : "false");

                constructorBlock = jClass.AnalyzeConstructors(classDefinitions).AddTabLevel(1);
                fieldBlock = jClass.AnalyzeFields(classDefinitions).AddTabLevel(1);
                staticMethodBlock = jClass.AnalyzeMethods(classDefinitions, true).AddTabLevel(1);
                methodBlock = jClass.AnalyzeMethods(classDefinitions, false).AddTabLevel(1);
            }

            StringBuilder jClassDecoration = new StringBuilder(AllPackageClasses.ClassStub.DEFAULT_DECORATION);
            if (jClassIsDepracated)
            {
                jClassDecoration.AppendLine();
                jClassDecoration.Append(AllPackageClasses.ClassStub.OBSOLETE_DECORATION);
            }

            var singleClassStr = singleClassTemplate.Replace(AllPackageClasses.VERSION, SpecialNames.VersionPlaceHolder())
                                                    .Replace(AllPackageClasses.JAR, jarName)
                                                    .Replace(AllPackageClasses.NAMESPACE, mainClass.Namespace())
                                                    .Replace(AllPackageClasses.ClassStub.DECORATION, jClassDecoration.ToString())
                                                    .Replace(AllPackageClasses.ClassStub.CLASS, mainClass.JVMClassName())
                                                    .Replace(AllPackageClasses.ClassStub.CONSTRUCTORS, constructorBlock)
                                                    .Replace(AllPackageClasses.ClassStub.FIELDS, fieldBlock)
                                                    .Replace(AllPackageClasses.ClassStub.STATICMETHODS, staticMethodBlock)
                                                    .Replace(AllPackageClasses.ClassStub.METHODS, methodBlock)
                                                    .Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, subClassAutonoumous.ToString());

            var classPath = Path.Combine(rootDesinationFolder, mainClass.Namespace().Replace(SpecialNames.NamespaceSeparator, Path.DirectorySeparatorChar), $"{mainClass.JVMClassName()}.cs");

            if (!dryRun)
            {
                if (File.Exists(classPath)) File.Delete(classPath);
                File.WriteAllText(classPath, singleClassStr);
            }

            var subClassStr = subClassBlock.ToString();
            classBlock = classBlock.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, subClassStr.Length != 0 ? subClassStr : string.Empty);

            return classBlock;
        }

        static string AnalyzeConstructors(this Class classDefinition, IList<ZipArchiveEntry> classDefinitions)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Constructors of {0} *******************", classDefinition.GenericString);

            var singleConstructorTemplate = Template.GetTemplate(Template.SingleConstructorTemplate);

            StringBuilder subClassBlock = new StringBuilder();
            foreach (var constructor in classDefinition.DeclaredConstructors)
            {
                var paramCount = constructor.ParameterCount;
                var methodNameOrigin = constructor.Name;

                if (paramCount == 0) continue; // default constructor managed from AllClasses template as default for any JCOBridge reflected class
                bool isDeprecated = constructor.IsDeprecated();
                if (!JNetReflectorCore.ReflectDeprecated && isDeprecated)
                {
                    ReportTrace(ReflectionTraceLevel.Info, "Discarded deprecated constructor {0}", constructor.GenericString);
                    continue;
                }
                if (constructor.IsStatic())
                {
                    ReportTrace(ReflectionTraceLevel.Info, "Discarded static constructor {0}", constructor.GenericString);
                    continue;
                }
                if (!constructor.IsPublic()) continue; // avoid not public methods
                string modifier = constructor.IsStatic() ? " static" : string.Empty;
                string constructorName = constructor.Name();
                bool hasGeneric = false;
                bool hasVarArg = false;
                Parameter varArg = null;
                StringBuilder methodParamsBuilder = new StringBuilder();
                StringBuilder methodExecutionParamsBuilder = new StringBuilder();
                foreach (var parameter in constructor.Parameters)
                {
                    if (parameter.Type.IsOrInheritFromJVMGenericClass()) { hasGeneric = true; break; }
                    if (!parameter.IsVarArgs)
                    {
                        methodParamsBuilder.AppendFormat($"{parameter.Type()} {parameter.Name}, ");
                        methodExecutionParamsBuilder.AppendFormat($"{parameter.Name}, ");
                    }
                    else // store var arg becuase it is not clear that results are ordered
                    {
                        hasVarArg = true;
                        varArg = parameter;
                    }
                }

                if (hasGeneric)
                {
                    ReportTrace(ReflectionTraceLevel.Info, "Discarded constructor {0}", constructor.GenericString);
                    continue;
                }
                if (hasVarArg && paramCount == 1 && varArg.IsObjectType()) continue; // this kinf of constructor is managed from AllClasses template as default for any JCOBridge reflected class
                if (hasVarArg)
                {
                    methodParamsBuilder.AppendFormat($"params {varArg.Type()} {varArg.Name}, ");
                }

                ReportTrace(ReflectionTraceLevel.Info, "Preparing constructor {0}", constructor.GenericString);

                string paramsString = methodParamsBuilder.ToString();
                string executionParamsString = methodExecutionParamsBuilder.ToString();
                if (paramCount != 0)
                {
                    if (paramsString.EndsWith(", ")) paramsString = paramsString.Substring(0, paramsString.Length - 2); // remove last occurrence of ", "
                    if (executionParamsString.EndsWith(", ")) executionParamsString = executionParamsString.Substring(0, executionParamsString.Length - 2); // remove last occurrence of ", "
                }

                StringBuilder jDecoration = new StringBuilder(AllPackageClasses.ClassStub.ConstructorStub.DEFAULT_DECORATION);
                if (isDeprecated)
                {
                    jDecoration.AppendLine();
                    jDecoration.Append(AllPackageClasses.ClassStub.ConstructorStub.OBSOLETE_DECORATION);
                }

                var singleConstructor = singleConstructorTemplate.Replace(AllPackageClasses.ClassStub.ConstructorStub.DECORATION, jDecoration.ToString())
                                                                 .Replace(AllPackageClasses.ClassStub.ConstructorStub.MODIFIER, modifier)
                                                                 .Replace(AllPackageClasses.ClassStub.ConstructorStub.NAME, constructorName)
                                                                 .Replace(AllPackageClasses.ClassStub.ConstructorStub.PARAMETERS, paramsString)
                                                                 .Replace(AllPackageClasses.ClassStub.ConstructorStub.EXECUTION, executionParamsString)
                                                                 .Replace(AllPackageClasses.ClassStub.ConstructorStub.HELP, constructor.JavadocUrl());

                subClassBlock.AppendLine(singleConstructor);
            }

            return subClassBlock.ToString();
        }

        static string AnalyzeMethods(this Class classDefinition, IList<ZipArchiveEntry> classDefinitions, bool staticMethods)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Methods of {0} with static {1} *******************", classDefinition.GenericString, staticMethods);

            var singleMethodTemplate = Template.GetTemplate(Template.SingleMethodTemplate);
            var singlePropertyTemplate = Template.GetTemplate(Template.SinglePropertyTemplate);

            StringBuilder subClassBlock = new StringBuilder();
            SortedDictionary<string, Method> methods = new SortedDictionary<string, Method>();
            SortedDictionary<string, IList<Method>> properties = new SortedDictionary<string, IList<Method>>();

            foreach (var method in classDefinition.DeclaredMethods)
            {
                var paramCount = method.ParameterCount;
                var methodNameOrigin = method.Name;

                if (paramCount == 0 &&
                    (methodNameOrigin == "toString" || methodNameOrigin == "hashCode")
                   ) continue; // special methods managed from JCOBridge

                if (paramCount == 1 &&
                    methodNameOrigin == "equals"
                   ) continue; // special methods managed from JCOBridge

                if (!JNetReflectorCore.ReflectDeprecated && method.IsDeprecated())
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded deprecated method {0}", method.GenericString);
                    continue; // this is very time consuming, anyway seems the only way to identify if a method was defined in the super abstract class
                }

                if (method.IsOverrideOrConcrete())
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded OverrideOrConcrete method {0}", method.GenericString);
                    continue; // this is very time consuming, anyway seems the only way to identify if a method was defined in the super abstract class
                }

                if (staticMethods ^ method.IsStatic()) continue;
                if (!method.IsPublic()) continue; // avoid not public methods
                if (method.ReturnType.IsOrInheritFromJVMGenericClass())
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded IsOrInheritFromJVMGenericClass method {0}", method.GenericString);
                    continue; // avoid generics till now
                }
                if (method.IsProperty())
                {
                    var propertyName = method.PropertyName(classDefinitions);
                    IList<Method> propertyMethods;
                    if (!properties.TryGetValue(propertyName, out propertyMethods))
                    {
                        propertyMethods = new List<Method>();
                        properties.Add(propertyName, propertyMethods);
                    }

                    propertyMethods.Add(method);
                }
                else
                {
                    methods.Add(method.GenericString, method);
                }
            }

            foreach (var prop in properties.ToArray())
            {
                string methodName = prop.Key;
                string modifier = string.Empty;
                string returnType = string.Empty;
                Method getMethod = null;
                Method setMethod = null;
                if (prop.Value.Count > 2) throw new InvalidOperationException("Too many properties");
                foreach (var item in prop.Value)
                {
                    if (item.IsGetProperty()) { getMethod = item; modifier = item.IsStatic() ? " static" : string.Empty; returnType = item.ReturnType(); }
                    if (item.IsSetProperty()) { setMethod = item; modifier = item.IsStatic() ? " static" : string.Empty; returnType = item.ReturnType(); }
                }

                if (getMethod == null && setMethod != null)
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Property moved to methods {0}", prop.Key);
                    methods.Add(setMethod.GenericString, setMethod);
                    continue;
                } // avoid to create property which have only a set method

                bool isGetDeprecated = false;
                bool isSetDeprecated = false;

                StringBuilder executionStub = new StringBuilder();
                if (getMethod != null)
                {
                    if (JNetReflectorCore.ReflectDeprecated) isGetDeprecated = getMethod.IsDeprecated();
                    executionStub.AppendFormat(AllPackageClasses.ClassStub.PropertyStub.GET_EXECUTION_FORMAT, getMethod.IsStatic() ? "SExecute" : "IExecute",
                                                                                                              getMethod.IsVoid() || getMethod.IsObjectReturnType() ? string.Empty : $"<{returnType}>",
                                                                                                              getMethod.Name);
                }

                if (setMethod != null)
                {
                    if (JNetReflectorCore.ReflectDeprecated) isSetDeprecated = setMethod.IsDeprecated();
                    executionStub.AppendFormat(AllPackageClasses.ClassStub.PropertyStub.SET_EXECUTION_FORMAT, setMethod.IsStatic() ? "SExecute" : "IExecute",
                                                                                                              setMethod.Name);
                }

                ReportTrace(ReflectionTraceLevel.Info, "Preparing properties of {0}", prop.Key);

                StringBuilder jPropDecoration = new StringBuilder(AllPackageClasses.ClassStub.PropertyStub.DEFAULT_DECORATION);
                if (isGetDeprecated || isSetDeprecated)
                {
                    jPropDecoration.AppendLine();
                    jPropDecoration.Append(AllPackageClasses.ClassStub.MethodStub.OBSOLETE_DECORATION);
                }

                var singleProperty = singlePropertyTemplate.Replace(AllPackageClasses.ClassStub.PropertyStub.DECORATION, jPropDecoration.ToString())
                                                           .Replace(AllPackageClasses.ClassStub.PropertyStub.MODIFIER, modifier)
                                                           .Replace(AllPackageClasses.ClassStub.PropertyStub.TYPE, returnType)
                                                           .Replace(AllPackageClasses.ClassStub.PropertyStub.NAME, methodName)
                                                           .Replace(AllPackageClasses.ClassStub.PropertyStub.EXECUTION, executionStub.ToString())
                                                           .Replace(AllPackageClasses.ClassStub.PropertyStub.GET_HELP, getMethod != null ? getMethod.JavadocUrl() : string.Empty)
                                                           .Replace(AllPackageClasses.ClassStub.PropertyStub.SET_HELP, setMethod != null ? setMethod.JavadocUrl() : string.Empty);

                subClassBlock.AppendLine(singleProperty);
            }

            foreach (var item in methods)
            {
                var method = item.Value;

                var paramCount = method.ParameterCount;
                var methodNameOrigin = method.Name;

                string modifier = method.IsStatic() ? " static" : string.Empty;
                string returnType = method.ReturnType();
                string methodName = method.Name(classDefinitions);
                bool hasGeneric = false;
                bool hasVarArg = false;
                Parameter varArg = null;
                StringBuilder methodParamsBuilder = new StringBuilder();
                StringBuilder methodExecutionParamsBuilder = new StringBuilder();
                foreach (var parameter in method.Parameters)
                {
                    if (parameter.Type.IsOrInheritFromJVMGenericClass()) { hasGeneric = true; break; }
                    if (!parameter.IsVarArgs)
                    {
                        methodParamsBuilder.AppendFormat($"{parameter.Type()} {parameter.Name}, ");
                        methodExecutionParamsBuilder.AppendFormat($"{parameter.Name}, ");
                    }
                    else // store var arg becuase it is not clear that results are ordered
                    {
                        hasVarArg = true;
                        varArg = parameter;
                    }
                }

                if (hasGeneric)
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded method {0}", method.GenericString);
                    continue;
                }
                if (hasVarArg)
                {
                    methodParamsBuilder.AppendFormat($"params {varArg.Type()} {varArg.Name}, ");
                }

                string paramsString = methodParamsBuilder.ToString();
                string executionParamsString = methodExecutionParamsBuilder.ToString();
                if (paramCount != 0)
                {
                    if (paramsString.EndsWith(", ")) paramsString = paramsString.Substring(0, paramsString.Length - 2); // remove last occurrence of ", "
                    if (executionParamsString.EndsWith(", ")) executionParamsString = executionParamsString.Substring(0, executionParamsString.Length - 2); // remove last occurrence of ", "
                }

                string executionStub = string.Format(AllPackageClasses.ClassStub.MethodStub.EXECUTION_FORMAT, method.IsVoid() ? string.Empty : "return ",
                                                                                                              method.IsStatic() ? "SExecute" : "IExecute",
                                                                                                              method.IsVoid() || method.IsObjectReturnType() ? string.Empty : $"<{returnType}>",
                                                                                                              methodNameOrigin,
                                                                                                              executionParamsString.Length == 0 ? string.Empty : ", " + executionParamsString); ; ;

                if (hasVarArg)
                {
                    string executionStubWithVarArg = string.Format(AllPackageClasses.ClassStub.MethodStub.EXECUTION_FORMAT, method.IsVoid() ? string.Empty : "return ",
                                                                                                                            method.IsStatic() ? "SExecute" : "IExecute",
                                                                                                                            method.IsVoid() || method.IsObjectReturnType() ? string.Empty : $"<{returnType}>",
                                                                                                                            methodNameOrigin,
                                                                                                                            (executionParamsString.Length == 0 ? string.Empty : ", ")
                                                                                                                            + executionParamsString + ", " + varArg.Name);

                    executionStub = $"if ({varArg.Name}.Length == 0) {executionStub} else {executionStubWithVarArg}";
                }

                ReportTrace(ReflectionTraceLevel.Info, "Preparing method {0}", method.GenericString);

                StringBuilder jDecoration = new StringBuilder(AllPackageClasses.ClassStub.MethodStub.DEFAULT_DECORATION);
                if (JNetReflectorCore.ReflectDeprecated && method.IsDeprecated())
                {
                    jDecoration.AppendLine();
                    jDecoration.Append(AllPackageClasses.ClassStub.MethodStub.OBSOLETE_DECORATION);
                }

                var singleMethod = singleMethodTemplate.Replace(AllPackageClasses.ClassStub.MethodStub.DECORATION, jDecoration.ToString())
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.MODIFIER, modifier)
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.RETURNTYPE, returnType)
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.NAME, methodName)
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.PARAMETERS, paramsString)
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.EXECUTION, executionStub)
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.HELP, method.JavadocUrl());

                subClassBlock.AppendLine(singleMethod);
            }

            return subClassBlock.ToString();
        }

        static string AnalyzeFields(this Class classDefinition, IList<ZipArchiveEntry> classDefinitions)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Fields of {0} *******************", classDefinition.GenericString);

            var singleFieldTemplate = Template.GetTemplate(Template.SingleFieldTemplate);

            StringBuilder subClassBlock = new StringBuilder();
            foreach (var field in classDefinition.Fields)
            {
                if (!field.DeclaringClass.Equals(classDefinition)) continue;
                if (!field.IsPublic()) continue; // avoid not public methods
                bool isDeprecated = field.IsDeprecated();
                if (!JNetReflectorCore.ReflectDeprecated && isDeprecated)
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded deprecated field {0}", field.GenericString);
                    continue; // avoid generics till now
                }

                bool isFieldGeneric = field.Type.IsOrInheritFromJVMGenericClass();

                string modifier = field.IsStatic() ? " static" : string.Empty;
                if (field.IsTypeNative())
                {
                    //  modifier += field.IsFinal() ? " readonly" : string.Empty; // avoid till now because seems not compile the test project
                }
                string fieldType = field.Type();
                string fieldName = field.Name();

                ReportTrace(ReflectionTraceLevel.Info, "Preparing field {0}", field.GenericString);

                string executionStub = string.Format(AllPackageClasses.ClassStub.FieldStub.EXECUTION_FORMAT, field.IsStatic() ? "Clazz" : "Instance",
                                                                                                             field.IsObjectReturnType() ? string.Empty : $"<{fieldType}>",
                                                                                                             field.Name);

                StringBuilder jDecoration = new StringBuilder(AllPackageClasses.ClassStub.FieldStub.DEFAULT_DECORATION);
                if (isDeprecated)
                {
                    jDecoration.AppendLine();
                    jDecoration.Append(AllPackageClasses.ClassStub.FieldStub.OBSOLETE_DECORATION);
                }

                var singleField = singleFieldTemplate.Replace(AllPackageClasses.ClassStub.FieldStub.DECORATION, jDecoration.ToString())
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.MODIFIER, modifier)
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.TYPE, fieldType)
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.NAME, fieldName)
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.EXECUTION, executionStub)
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.HELP, field.JavadocUrl());

                subClassBlock.AppendLine(singleField);
            }

            return subClassBlock.ToString();
        }
    }
}
