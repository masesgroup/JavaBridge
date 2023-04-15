/*
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

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Tools
{
    #region DocumentationTool
    public partial class DocumentationTool
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Tools.DocumentationTool"/> to <see cref="Javax.Tools.Tool"/>
        /// </summary>
        public static implicit operator Javax.Tools.Tool(Javax.Tools.DocumentationTool t) => t.Cast<Javax.Tools.Tool>();
        /// <summary>
        /// Converter from <see cref="Javax.Tools.DocumentationTool"/> to <see cref="Javax.Tools.OptionChecker"/>
        /// </summary>
        public static implicit operator Javax.Tools.OptionChecker(Javax.Tools.DocumentationTool t) => t.Cast<Javax.Tools.OptionChecker>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.html#getTask(java.io.Writer,javax.tools.JavaFileManager,javax.tools.DiagnosticListener,java.lang.Class,java.lang.Iterable,java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileManager"/></param>
        /// <param name="arg2"><see cref="Javax.Tools.DiagnosticListener"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Iterable"/></param>
        /// <param name="arg5"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Javax.Tools.DocumentationTool.DocumentationTask"/></returns>
        public Javax.Tools.DocumentationTool.DocumentationTask GetTask<Arg2objectSuperJavax_Tools_JavaFileObject, Arg5ExtendsJavax_Tools_JavaFileObject>(Java.Io.Writer arg0, Javax.Tools.JavaFileManager arg1, Javax.Tools.DiagnosticListener<Arg2objectSuperJavax_Tools_JavaFileObject> arg2, Java.Lang.Class arg3, Java.Lang.Iterable<string> arg4, Java.Lang.Iterable<Arg5ExtendsJavax_Tools_JavaFileObject> arg5) where Arg2objectSuperJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject where Arg5ExtendsJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject
        {
            return IExecute<Javax.Tools.DocumentationTool.DocumentationTask>("getTask", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.html#getStandardFileManager(javax.tools.DiagnosticListener,java.util.Locale,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.DiagnosticListener"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <returns><see cref="Javax.Tools.StandardJavaFileManager"/></returns>
        public Javax.Tools.StandardJavaFileManager GetStandardFileManager<Arg0objectSuperJavax_Tools_JavaFileObject>(Javax.Tools.DiagnosticListener<Arg0objectSuperJavax_Tools_JavaFileObject> arg0, Java.Util.Locale arg1, Java.Nio.Charset.Charset arg2) where Arg0objectSuperJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject
        {
            return IExecute<Javax.Tools.StandardJavaFileManager>("getStandardFileManager", arg0, arg1, arg2);
        }
        
        #endregion

        #region Nested classes
        #region DocumentationTask
        public partial class DocumentationTask
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.DocumentationTask.html#call()"/> 
            /// </summary>
            public object Call
            {
                get { return IExecute("call"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.DocumentationTask.html#addModules(java.lang.Iterable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
            public void AddModules(Java.Lang.Iterable<string> arg0)
            {
                IExecute("addModules", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.DocumentationTask.html#setLocale(java.util.Locale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
            public void SetLocale(Java.Util.Locale arg0)
            {
                IExecute("setLocale", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Location
        public partial class Location
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html#DOCLET_PATH"/>
            /// </summary>
            public static Javax.Tools.DocumentationTool.Location DOCLET_PATH => Clazz.GetField<Javax.Tools.DocumentationTool.Location>("DOCLET_PATH");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html#DOCUMENTATION_OUTPUT"/>
            /// </summary>
            public static Javax.Tools.DocumentationTool.Location DOCUMENTATION_OUTPUT => Clazz.GetField<Javax.Tools.DocumentationTool.Location>("DOCUMENTATION_OUTPUT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html#TAGLET_PATH"/>
            /// </summary>
            public static Javax.Tools.DocumentationTool.Location TAGLET_PATH => Clazz.GetField<Javax.Tools.DocumentationTool.Location>("TAGLET_PATH");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html#values()"/> 
            /// </summary>
            public static Javax.Tools.DocumentationTool.Location[] Values
            {
                get { return SExecuteArray<Javax.Tools.DocumentationTool.Location>(LocalClazz, "values"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Tools.DocumentationTool.Location"/></returns>
            public static Javax.Tools.DocumentationTool.Location ValueOf(string arg0)
            {
                return SExecute<Javax.Tools.DocumentationTool.Location>(LocalClazz, "valueOf", arg0);
            }
            
            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html#isOutputLocation()"/> 
            /// </summary>
            public bool IsOutputLocation
            {
                get { return IExecute<bool>("isOutputLocation"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html#getName()"/> 
            /// </summary>
            public string Name
            {
                get { return IExecute<string>("getName"); }
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}