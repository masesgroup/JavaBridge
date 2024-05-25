/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Tools
{
    #region IJavaCompiler
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IJavaCompiler
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region JavaCompiler
    public partial class JavaCompiler : Javax.Tools.IJavaCompiler
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Tools.JavaCompiler"/> to <see cref="Javax.Tools.Tool"/>
        /// </summary>
        public static implicit operator Javax.Tools.Tool(Javax.Tools.JavaCompiler t) => t.Cast<Javax.Tools.Tool>();
        /// <summary>
        /// Converter from <see cref="Javax.Tools.JavaCompiler"/> to <see cref="Javax.Tools.OptionChecker"/>
        /// </summary>
        public static implicit operator Javax.Tools.OptionChecker(Javax.Tools.JavaCompiler t) => t.Cast<Javax.Tools.OptionChecker>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region CompilationTask
        public partial class CompilationTask
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaCompiler.CompilationTask.html#addModules(java.lang.Iterable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
            public void AddModules(Java.Lang.Iterable<Java.Lang.String> arg0)
            {
                IExecuteWithSignature("addModules", "(Ljava/lang/Iterable;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaCompiler.CompilationTask.html#setLocale(java.util.Locale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
            public void SetLocale(Java.Util.Locale arg0)
            {
                IExecuteWithSignature("setLocale", "(Ljava/util/Locale;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaCompiler.CompilationTask.html#setProcessors(java.lang.Iterable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
            /// <typeparam name="Arg0ExtendsJavax_Annotation_Processing_Processor"><see cref="Javax.Annotation.Processing.Processor"/></typeparam>
            public void SetProcessors<Arg0ExtendsJavax_Annotation_Processing_Processor>(Java.Lang.Iterable<Arg0ExtendsJavax_Annotation_Processing_Processor> arg0) where Arg0ExtendsJavax_Annotation_Processing_Processor: Javax.Annotation.Processing.Processor
            {
                IExecuteWithSignature("setProcessors", "(Ljava/lang/Iterable;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaCompiler.CompilationTask.html#call()"/>
            /// </summary>
            /// <returns><see cref="object"/></returns>
            /// <exception cref="Java.Lang.Exception"/>
            public object Call()
            {
                return IExecuteWithSignature("call", "()Ljava/lang/Object;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}