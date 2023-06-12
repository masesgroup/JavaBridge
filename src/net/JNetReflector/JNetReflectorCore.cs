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

using MASES.CLIParser;
using MASES.JNet;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace MASES.JNetReflector
{
    /// <summary>
    /// Public entry point of <see cref="JNetReflectorCore{T}"/>
    /// </summary>
    public abstract class JNetReflectorCore<T> : JNetCoreBase<T> where T : JNetReflectorCore<T>
    {


        /// <summary>
        /// Class used to define configuration information
        /// </summary>
        public class ConfigurationType
        {
            public struct VersionUrl
            {
                public VersionUrl(int version, string url)
                {
                    Version = version;
                    Url = url;
                }
                public int Version { get; set; }
                public string Url { get; set; }
            }

            public string OriginRootPath { get; set; }

            public string OriginJavadocUrl { get; set; }

            public IEnumerable<VersionUrl> OriginJavadocJARVersionAndUrls { get; set; }

            public int JavadocVersion { get; set; }

            public string DestinationRootPath { get; set; }

            public IEnumerable<string> ClassesToAnalyze { get; set; }

            public IEnumerable<string> JarList { get; set; }

            public IEnumerable<string> ModulesToParse { get; set; }

            public IEnumerable<string> ClassesToBeListener { get; set; }

            public IEnumerable<string> NamespacesInConflict { get; set; }

            public IEnumerable<string> ClassesInConflict { get; set; }

            public IEnumerable<string> NamespacesToAvoid { get; set; }

            public IEnumerable<string> ClassesToAvoid { get; set; }

            public IEnumerable<string> ClassesToAvoidInGenerics { get; set; }

            public bool OnlyPropertiesForGetterSetter { get; set; }

            public bool ReflectDeprecated { get; set; }

            public bool AvoidCSharpGenericDefinition { get; set; }

            public bool AvoidCSharpGenericClauseDefinition { get; set; }

            public bool DisableGenericsInNonGenericClasses { get; set; }

            public bool DisableGenerics { get; set; }

            public bool CreateInterfaceInheritance { get; set; }

            public bool DisableInterfaceMethodGeneration { get; set; }

            public bool AvoidParallelBuild { get; set; }

            public bool DryRun { get; set; }

            public bool DoNotCamel { get; set; }

            public int TraceLevel { get; set; }

            public string TraceTo { get; set; }
        }

        #region Initialization
        /// <inheritdoc cref="JNetCoreBase{T}.CommandLineArguments"/>
        public override IEnumerable<IArgumentMetadata> CommandLineArguments
        {
            get
            {
                var lst = new List<IArgumentMetadata>(base.CommandLineArguments);
                lst.AddRange(new IArgumentMetadata[]
                {
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ConfigurationFile,
                        Type = ArgumentType.Double,
                        Help = "The path where is stored a JSON file containing the tool configuration properties",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.OriginRootPath,
                        Type = ArgumentType.Double,
                        Help = "The origin path where Jars to be analyzed, and dependencies, are stored",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.OriginJavadocUrl,
                        Type = ArgumentType.Double,
                        Default = null,
                        Help = "The base URL of the Javadoc to be associated to the classes",
                    },
                    new ArgumentMetadata<int>()
                    {
                        Name = CLIParam.JavadocVersion,
                        Type = ArgumentType.Double,
                        Default = 11,
                        Help = "The version of the Javadoc to be associated to the classes, it means the Javadoc tool version used",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.OriginJavadocJARVersionAndUrls,
                        Type = ArgumentType.Double,
                        Default = null,
                        Help = "A CSV list of keypair of JavadocVersion and OriginJavadocUrl, separated by |, associated to the JARs to be analyzed",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.DestinationRootPath,
                        Type = ArgumentType.Double,
                        Default = SpecialNames.JNetReflectorGeneratedFolder,
                        Help = "The destination root path where reflected classes will be stored",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ClassesToAnalyze,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of full qualified class names to be analyzed",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.JarList,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of JAR to be analyzed or folders containing the JARs",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ModulesToParse,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of module patterns to be parsed during analysis, it avoids the usage of OriginRootPath",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ClassesToBeListener,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of class names to be treated as Listener",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.NamespacesInConflict,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of namespaces in conflict with class name: to this one will be added an \"Ns\" at the end",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ClassesInConflict,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of classes in conflict with namespace name: to this one will be added an \"Class\" at the end",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.NamespacesToAvoid,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of namespaces to be removed during analysis",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ClassesToAvoid,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of classes to be removed during analysis",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ClassesToAvoidInGenerics,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of classes to be removed during analysis from the classes which have generics types",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.OnlyPropertiesForGetterSetter,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to convert into properties only getter/setter",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.ReflectDeprecated,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to write any constructor, method or field marked as deprecated, default is to avoid deprecated",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.AvoidCSharpGenericDefinition,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to reflect generics without create the C# generic definition",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.AvoidCSharpGenericClauseDefinition,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to reflect generics without create the clauses of C# generic definition",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.DisableGenericsInNonGenericClasses,
                        Type = ArgumentType.Single,
                        Help = "The option disables generation of generic methods in non generic classes",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.DisableGenerics,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to disable any generic type",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.CreateInterfaceInheritance,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to create the C# interface inheritance",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.DisableInterfaceMethodGeneration,
                        Type = ArgumentType.Single,
                        Help = "The option disables the generation of the methods in the C# interface",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.AvoidParallelBuild,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to disable parallel execution",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.DryRun,
                        Type = ArgumentType.Single,
                        Help = "Execute everything, but do not write anything to disk",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.DoNotCamel,
                        Type = ArgumentType.Single,
                        Help = "Does not use camelized names in methods, class and so on",
                    },
                    new ArgumentMetadata<int>()
                    {
                        Name = CLIParam.TraceLevel,
                        Type = ArgumentType.Double,
                        Default = (int)ReflectionUtils.ReflectionTraceLevel.Verbose,
                        Help = "The level of traces to be reported: 0 - Critical ... 5 - Verbose",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.TraceTo,
                        Type = ArgumentType.Double,
                        Default = null,
                        Help = "The file name where traces will be write, default write to console",
                    },
                });
                return lst;
            }
        }

        /// <summary>
        /// Public ctor
        /// </summary>
        public JNetReflectorCore()
        {
            JCOBridge.C2JBridge.JCOBridge.RegisterExceptions(typeof(JNetReflectorCore<>).Assembly);
        }

        static ConfigurationType _ConfigurationFromFile;

        static string _OriginRootPath;
        public static string OriginRootPath => _OriginRootPath ?? _ConfigurationFromFile.OriginRootPath;

        static string _OriginJavadocUrl;
        public static string OriginJavadocUrl => _OriginJavadocUrl ?? _ConfigurationFromFile.OriginJavadocUrl;

        static IEnumerable<ConfigurationType.VersionUrl> _OriginJavadocJARVersionAndUrls;
        public static IEnumerable<ConfigurationType.VersionUrl> OriginJavadocJARVersionAndUrls => _OriginJavadocJARVersionAndUrls ?? _ConfigurationFromFile.OriginJavadocJARVersionAndUrls;

        static int? _JavadocVersion = null;
        public static int JavadocVersion => _JavadocVersion ?? _ConfigurationFromFile.JavadocVersion;

        static string _DestinationRootPath;
        public static string DestinationRootPath => _DestinationRootPath ?? _ConfigurationFromFile.DestinationRootPath;

        static IEnumerable<string> _ClassesToAnalyze;
        public static IEnumerable<string> ClassesToAnalyze => _ClassesToAnalyze ?? _ConfigurationFromFile.ClassesToAnalyze;

        static IEnumerable<string> _JarsToAddInClassPath;
        static IEnumerable<string> _JarsToAnalyze;
        public static IEnumerable<string> JarsToAnalyze => _JarsToAnalyze ?? _ConfigurationFromFile.JarList;

        static IEnumerable<string> _ModulesToParse;
        public static IEnumerable<string> ModulesToParse => _ModulesToParse ?? _ConfigurationFromFile.ModulesToParse;

        static IEnumerable<string> _ClassesToBeListener;
        public static IEnumerable<string> ClassesToBeListener => _ClassesToBeListener ?? _ConfigurationFromFile.ClassesToBeListener;

        static IEnumerable<string> _NamespacesInConflict;
        public static IEnumerable<string> NamespacesInConflict => _NamespacesInConflict ?? _ConfigurationFromFile.NamespacesInConflict;

        static IEnumerable<string> _ClassesInConflict;
        public static IEnumerable<string> ClassesInConflict => _ClassesInConflict ?? _ConfigurationFromFile.ClassesInConflict;

        static IEnumerable<string> _NamespacesToAvoid;
        public static IEnumerable<string> NamespacesToAvoid => _NamespacesToAvoid ?? _ConfigurationFromFile.NamespacesToAvoid;

        static IEnumerable<string> _ClassesToAvoid;
        public static IEnumerable<string> ClassesToAvoid => _ClassesToAvoid ?? _ConfigurationFromFile.ClassesToAvoid;

        static IEnumerable<string> _ClassesToAvoidInGenerics;
        public static IEnumerable<string> ClassesToAvoidInGenerics => _ClassesToAvoidInGenerics ?? _ConfigurationFromFile.ClassesToAvoidInGenerics;

        static bool? _OnlyPropertiesForGetterSetter;
        public static bool OnlyPropertiesForGetterSetter => _OnlyPropertiesForGetterSetter ?? _ConfigurationFromFile.OnlyPropertiesForGetterSetter;

        static bool? _ReflectDeprecated;
        public static bool ReflectDeprecated => _ReflectDeprecated ?? _ConfigurationFromFile.ReflectDeprecated;

        static bool? _AvoidCSharpGenericDefinition;
        public static bool AvoidCSharpGenericDefinition => _AvoidCSharpGenericDefinition ?? _ConfigurationFromFile.AvoidCSharpGenericDefinition;

        static bool? _AvoidCSharpGenericClauseDefinition;
        public static bool AvoidCSharpGenericClauseDefinition => _AvoidCSharpGenericClauseDefinition ?? _ConfigurationFromFile.AvoidCSharpGenericClauseDefinition;

        static bool? _DisableGenericsInNonGenericClasses;
        public static bool DisableGenericsInNonGenericClasses => _DisableGenericsInNonGenericClasses ?? _ConfigurationFromFile.DisableGenericsInNonGenericClasses;

        static bool? _DisableGenerics;
        public static bool DisableGenerics => _DisableGenerics ?? _ConfigurationFromFile.DisableGenerics;

        static bool? _CreateInterfaceInheritance;
        public static bool CreateInterfaceInheritance => _CreateInterfaceInheritance ?? _ConfigurationFromFile.CreateInterfaceInheritance;

        static bool? _DisableInterfaceMethodGeneration;
        public static bool DisableInterfaceMethodGeneration => _DisableInterfaceMethodGeneration ?? _ConfigurationFromFile.DisableInterfaceMethodGeneration;

        static bool? _AvoidParallelBuild;
        public static bool AvoidParallelBuild => _AvoidParallelBuild ?? _ConfigurationFromFile.AvoidParallelBuild;

        static bool? _DryRun;
        public static bool DryRun => _DryRun ?? _ConfigurationFromFile.DryRun;

        static bool? _UseCamel;
        public static bool UseCamel => _UseCamel ?? !_ConfigurationFromFile.DoNotCamel;

        static int? _TraceLevel;
        public static int TraceLevel => _TraceLevel ?? _ConfigurationFromFile.TraceLevel;

        static string _TraceTo;
        public static string TraceTo => _TraceTo ?? _ConfigurationFromFile.TraceTo;

        /// <inheritdoc cref="JNetCoreBase{T}.ProcessCommandLine"/>
        protected override string[] ProcessCommandLine()
        {
            var result = base.ProcessCommandLine();

            if (ParsedArgs.Exist(CLIParam.ConfigurationFile))
            {
                var filePath = ParsedArgs.Get<string>(CLIParam.ConfigurationFile);
                filePath = Path.GetFullPath(filePath);
                var conf = File.ReadAllText(filePath);
                _ConfigurationFromFile = JsonSerializer.Deserialize<ConfigurationType>(conf);
            }

            List<string> classesToAnalyze = new List<string>();
            if (ParsedArgs.Exist(CLIParam.ClassesToAnalyze))
            {
                var classes = ParsedArgs.Get<string>(CLIParam.ClassesToAnalyze).Split(',', ';');
                foreach (var item in classes.Select((o) => o.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator)))
                {
                    if (!classesToAnalyze.Contains(item)) classesToAnalyze.Add(item);
                }
                _ClassesToAnalyze = classesToAnalyze;
            }

            List<string> jarsToAnaylyze = new List<string>();
            if (ParsedArgs.Exist(CLIParam.OriginRootPath))
            {
                var originalRootPath = ParsedArgs.Get<string>(CLIParam.OriginRootPath);
                _OriginRootPath = Path.GetFullPath(originalRootPath);
                if (!Directory.Exists(_OriginRootPath)) throw new DirectoryNotFoundException($"{_OriginRootPath} not exist.");
                _JarsToAddInClassPath = new List<string>(Directory.EnumerateFiles(originalRootPath, "*.jar"));
            }

            if (ParsedArgs.Exist(CLIParam.JarList))
            {
                var jars = ParsedArgs.Get<string>(CLIParam.JarList).Split(',', ';');
                foreach (var item in jars)
                {
                    if (!jarsToAnaylyze.Contains(item)) jarsToAnaylyze.Add(item);
                }
                _JarsToAnalyze = jarsToAnaylyze;
            }

            List<string> modulesToParse = new List<string>();
            if (ParsedArgs.Exist(CLIParam.ModulesToParse))
            {
                var namespaces = ParsedArgs.Get<string>(CLIParam.ModulesToParse).Split(',', ';');
                foreach (var item in namespaces.Select((o) => o.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator)))
                {
                    if (!modulesToParse.Contains(item)) modulesToParse.Add(item);
                }
                _ModulesToParse = modulesToParse;
            }

            List<ConfigurationType.VersionUrl> jarURLsToAnaylyze = new List<ConfigurationType.VersionUrl>();
            if (ParsedArgs.Exist(CLIParam.OriginJavadocJARVersionAndUrls))
            {
                var jarURLs = ParsedArgs.Get<string>(CLIParam.OriginJavadocJARVersionAndUrls).Split(',', ';');
                foreach (var item in jarURLs)
                {
                    var items = item.Split('|');
                    if (items.Length < 2) throw new System.InvalidOperationException($"{item} does not conform to expected pattern.");
                    var version = int.Parse(items[0]);
                    var url = string.Join(string.Empty, items.Skip(1));
                    jarURLsToAnaylyze.Add(new ConfigurationType.VersionUrl(version, url));
                }
                _OriginJavadocJARVersionAndUrls = jarURLsToAnaylyze;
                if (_JarsToAnalyze?.Count() != _OriginJavadocJARVersionAndUrls.Count())
                    throw new System.InvalidOperationException("Number of entries in OriginJavadocJARVersionAndUrls shall be equal to the number of JarList");
            }

            List<string> classesToBeListener = new List<string>();
            if (ParsedArgs.Exist(CLIParam.ClassesToBeListener))
            {
                var classes = ParsedArgs.Get<string>(CLIParam.ClassesToBeListener).Split(',', ';');
                foreach (var item in classes)
                {
                    if (!classesToBeListener.Contains(item)) classesToBeListener.Add(item);
                }
                _ClassesToBeListener = classesToBeListener;
            }

            List<string> namespacesInConflict = new List<string>();
            if (ParsedArgs.Exist(CLIParam.NamespacesInConflict))
            {
                var namespaces = ParsedArgs.Get<string>(CLIParam.NamespacesInConflict).Split(',', ';');
                foreach (var item in namespaces.Select((o) => o.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator)))
                {
                    if (!namespacesInConflict.Contains(item)) namespacesInConflict.Add(item);
                }
                _NamespacesInConflict = namespacesInConflict;
            }


            List<string> classesInConflict = new List<string>();
            if (ParsedArgs.Exist(CLIParam.ClassesInConflict))
            {
                var namespaces = ParsedArgs.Get<string>(CLIParam.ClassesInConflict).Split(',', ';');
                foreach (var item in namespaces.Select((o) => o.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator)))
                {
                    if (!classesInConflict.Contains(item)) classesInConflict.Add(item);
                }
                _ClassesInConflict = classesInConflict;
            }

            List<string> namespacesToAvoid = new List<string>();
            if (ParsedArgs.Exist(CLIParam.NamespacesToAvoid))
            {
                var namespaces = ParsedArgs.Get<string>(CLIParam.NamespacesToAvoid).Split(',', ';');
                foreach (var item in namespaces.Select((o) => o.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator)))
                {
                    if (!namespacesToAvoid.Contains(item)) namespacesToAvoid.Add(item);
                }
                _NamespacesToAvoid = namespacesToAvoid;
            }

            List<string> classesToAvoid = new List<string>();
            if (ParsedArgs.Exist(CLIParam.ClassesToAvoid))
            {
                var classes = ParsedArgs.Get<string>(CLIParam.ClassesToAvoid).Split(',', ';');
                foreach (var item in classes.Select((o) => o.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator)))
                {
                    if (!classesToAvoid.Contains(item)) classesToAvoid.Add(item);
                }
                _ClassesToAvoid = classesToAvoid;
            }

            List<string> classesToAvoidInGenerics = new List<string>();
            if (ParsedArgs.Exist(CLIParam.ClassesToAvoidInGenerics))
            {
                var classes = ParsedArgs.Get<string>(CLIParam.ClassesToAvoidInGenerics).Split(',', ';');
                foreach (var item in classes.Select((o) => o.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator)))
                {
                    if (!classesToAvoidInGenerics.Contains(item)) classesToAvoidInGenerics.Add(item);
                }
                _ClassesToAvoidInGenerics = classesToAvoidInGenerics;
            }

            var destinationFolder = Path.GetFullPath(ParsedArgs.Get<string>(CLIParam.DestinationRootPath));
            _DestinationRootPath = Path.GetFullPath(destinationFolder);

            _OriginJavadocUrl = ParsedArgs.Get<string>(CLIParam.OriginJavadocUrl);
            _JavadocVersion = ParsedArgs.Get<int>(CLIParam.JavadocVersion);

            if (ParsedArgs.Exist(CLIParam.OnlyPropertiesForGetterSetter)) _OnlyPropertiesForGetterSetter = true;
            if (ParsedArgs.Exist(CLIParam.ReflectDeprecated)) _ReflectDeprecated = true;
            if (ParsedArgs.Exist(CLIParam.AvoidCSharpGenericDefinition)) _AvoidCSharpGenericDefinition = true;
            if (ParsedArgs.Exist(CLIParam.AvoidCSharpGenericClauseDefinition)) _AvoidCSharpGenericClauseDefinition = true;
            if (ParsedArgs.Exist(CLIParam.DisableGenericsInNonGenericClasses)) _DisableGenericsInNonGenericClasses = true;
            if (ParsedArgs.Exist(CLIParam.DisableGenerics)) _DisableGenerics = true;
            if (ParsedArgs.Exist(CLIParam.CreateInterfaceInheritance)) _CreateInterfaceInheritance = true;
            if (ParsedArgs.Exist(CLIParam.DisableInterfaceMethodGeneration)) _DisableInterfaceMethodGeneration = true;
            if (ParsedArgs.Exist(CLIParam.AvoidParallelBuild)) _AvoidParallelBuild = true;
            if (ParsedArgs.Exist(CLIParam.DryRun)) _DryRun = true;
            if (ParsedArgs.Exist(CLIParam.DoNotCamel)) _UseCamel = false;
            _TraceLevel = ParsedArgs.Get<int>(CLIParam.TraceLevel);
            _TraceTo = ParsedArgs.Get<string>(CLIParam.TraceTo);

            return result;
        }

        protected override IDictionary<string, string> Options => new Dictionary<string, string>();

        /// <inheritdoc cref="JNetCoreBase{T}.PathToParse"/>
        protected override IList<string> PathToParse
        {
            get
            {
                var lst = base.PathToParse;
                var assembly = typeof(JNetReflectorCore<>).Assembly;
                var path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(assembly.Location), JARsSubFolder, $"*.jar");
                lst.Add(path);
                if (_JarsToAddInClassPath != null)
                {
                    foreach (var item in _JarsToAddInClassPath)
                    {
                        lst.Add(Path.GetFullPath(item));
                    }
                }
                return lst;
            }
        }
        #endregion

#if DEBUG
        public override bool EnableDebug => true;
#endif
    }
    /// <summary>
    /// Concrete implementation of <see cref="JNetReflectorCore{T}"/>
    /// </summary>
    public class JNetReflectorCore : JNetReflectorCore<JNetReflectorCore>
    {
    }
}