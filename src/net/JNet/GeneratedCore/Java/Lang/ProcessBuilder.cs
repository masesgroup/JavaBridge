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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region ProcessBuilder definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html"/>
    /// </summary>
    public partial class ProcessBuilder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ProcessBuilder>
    {
        const string _bridgeClassName = "java.lang.ProcessBuilder";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ProcessBuilder() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ProcessBuilder(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region Redirect definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.Redirect.html"/>
        /// </summary>
        public partial class Redirect : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Redirect>
        {
            const string _bridgeClassName = "java.lang.ProcessBuilder$Redirect";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("Redirect class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Redirect() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("Redirect class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Redirect(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class
            #region Type definition
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.Redirect.Type.html"/>
            /// </summary>
            public partial class Type : Java.Lang.Enum<Java.Lang.ProcessBuilder.Redirect.Type>
            {
                const string _bridgeClassName = "java.lang.ProcessBuilder$Redirect$Type";
                /// <summary>
                /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
                /// </summary>
                public Type() { }
                /// <summary>
                /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
                /// </summary>
                public Type(params object[] args) : base(args) { }

                private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
                private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

                /// <summary>
                /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
                /// </summary>
                public override string BridgeClassName => _bridgeClassName;
                /// <summary>
                /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
                /// </summary>
                public override bool IsBridgeAbstract => false;
                /// <summary>
                /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
                /// </summary>
                public override bool IsBridgeCloseable => false;
                /// <summary>
                /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
                /// </summary>
                public override bool IsBridgeInterface => false;
                /// <summary>
                /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
                /// </summary>
                public override bool IsBridgeStatic => true;

                // TODO: complete the class

            }
            #endregion

        
        }
        #endregion

    
    }
    #endregion

    #region ProcessBuilder
    public partial class ProcessBuilder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#%3Cinit%3E(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public ProcessBuilder(params Java.Lang.String[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#%3Cinit%3E(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public ProcessBuilder(Java.Util.List<Java.Lang.String> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#startPipeline(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Util.List<Java.Lang.Process> StartPipeline(Java.Util.List<Java.Lang.ProcessBuilder> arg0)
        {
            return SExecuteWithSignature<Java.Util.List<Java.Lang.Process>>(LocalBridgeClazz, "startPipeline", "(Ljava/util/List;)Ljava/util/List;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#redirectErrorStream()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool RedirectErrorStream()
        {
            return IExecuteWithSignature<bool>("redirectErrorStream", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#directory()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File Directory()
        {
            return IExecuteWithSignature<Java.Io.File>("directory", "()Ljava/io/File;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#start()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Process Start()
        {
            return IExecuteWithSignature<Java.Lang.Process>("start", "()Ljava/lang/Process;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#command(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.ProcessBuilder"/></returns>
        public Java.Lang.ProcessBuilder Command(params Java.Lang.String[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Java.Lang.ProcessBuilder>("command", "([Ljava/lang/String;)Ljava/lang/ProcessBuilder;"); else return IExecuteWithSignature<Java.Lang.ProcessBuilder>("command", "([Ljava/lang/String;)Ljava/lang/ProcessBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#command(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Lang.ProcessBuilder"/></returns>
        public Java.Lang.ProcessBuilder Command(Java.Util.List<Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<Java.Lang.ProcessBuilder>("command", "(Ljava/util/List;)Ljava/lang/ProcessBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#directory(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.ProcessBuilder"/></returns>
        public Java.Lang.ProcessBuilder Directory(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Java.Lang.ProcessBuilder>("directory", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#inheritIO()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.ProcessBuilder"/></returns>
        public Java.Lang.ProcessBuilder InheritIO()
        {
            return IExecuteWithSignature<Java.Lang.ProcessBuilder>("inheritIO", "()Ljava/lang/ProcessBuilder;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#redirectError(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.ProcessBuilder"/></returns>
        public Java.Lang.ProcessBuilder RedirectError(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Java.Lang.ProcessBuilder>("redirectError", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#redirectError(java.lang.ProcessBuilder.Redirect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ProcessBuilder.Redirect"/></param>
        /// <returns><see cref="Java.Lang.ProcessBuilder"/></returns>
        public Java.Lang.ProcessBuilder RedirectError(Java.Lang.ProcessBuilder.Redirect arg0)
        {
            return IExecuteWithSignature<Java.Lang.ProcessBuilder>("redirectError", "(Ljava/lang/ProcessBuilder$Redirect;)Ljava/lang/ProcessBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#redirectErrorStream(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.ProcessBuilder"/></returns>
        public Java.Lang.ProcessBuilder RedirectErrorStream(bool arg0)
        {
            return IExecuteWithSignature<Java.Lang.ProcessBuilder>("redirectErrorStream", "(Z)Ljava/lang/ProcessBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#redirectInput(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.ProcessBuilder"/></returns>
        public Java.Lang.ProcessBuilder RedirectInput(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Java.Lang.ProcessBuilder>("redirectInput", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#redirectInput(java.lang.ProcessBuilder.Redirect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ProcessBuilder.Redirect"/></param>
        /// <returns><see cref="Java.Lang.ProcessBuilder"/></returns>
        public Java.Lang.ProcessBuilder RedirectInput(Java.Lang.ProcessBuilder.Redirect arg0)
        {
            return IExecuteWithSignature<Java.Lang.ProcessBuilder>("redirectInput", "(Ljava/lang/ProcessBuilder$Redirect;)Ljava/lang/ProcessBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#redirectOutput(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.ProcessBuilder"/></returns>
        public Java.Lang.ProcessBuilder RedirectOutput(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Java.Lang.ProcessBuilder>("redirectOutput", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#redirectOutput(java.lang.ProcessBuilder.Redirect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ProcessBuilder.Redirect"/></param>
        /// <returns><see cref="Java.Lang.ProcessBuilder"/></returns>
        public Java.Lang.ProcessBuilder RedirectOutput(Java.Lang.ProcessBuilder.Redirect arg0)
        {
            return IExecuteWithSignature<Java.Lang.ProcessBuilder>("redirectOutput", "(Ljava/lang/ProcessBuilder$Redirect;)Ljava/lang/ProcessBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#redirectError()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.ProcessBuilder.Redirect"/></returns>
        public Java.Lang.ProcessBuilder.Redirect RedirectError()
        {
            return IExecuteWithSignature<Java.Lang.ProcessBuilder.Redirect>("redirectError", "()Ljava/lang/ProcessBuilder$Redirect;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#redirectInput()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.ProcessBuilder.Redirect"/></returns>
        public Java.Lang.ProcessBuilder.Redirect RedirectInput()
        {
            return IExecuteWithSignature<Java.Lang.ProcessBuilder.Redirect>("redirectInput", "()Ljava/lang/ProcessBuilder$Redirect;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#redirectOutput()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.ProcessBuilder.Redirect"/></returns>
        public Java.Lang.ProcessBuilder.Redirect RedirectOutput()
        {
            return IExecuteWithSignature<Java.Lang.ProcessBuilder.Redirect>("redirectOutput", "()Ljava/lang/ProcessBuilder$Redirect;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#command()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> Command()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("command", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.html#environment()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> Environment()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("environment", "()Ljava/util/Map;");
        }

        #endregion

        #region Nested classes
        #region Redirect
        public partial class Redirect
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.Redirect.html#DISCARD"/>
            /// </summary>
            public static Java.Lang.ProcessBuilder.Redirect DISCARD { get { if (!_DISCARDReady) { _DISCARDContent = SGetField<Java.Lang.ProcessBuilder.Redirect>(LocalBridgeClazz, "DISCARD"); _DISCARDReady = true; } return _DISCARDContent; } }
            private static Java.Lang.ProcessBuilder.Redirect _DISCARDContent = default;
            private static bool _DISCARDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.Redirect.html#INHERIT"/>
            /// </summary>
            public static Java.Lang.ProcessBuilder.Redirect INHERIT { get { if (!_INHERITReady) { _INHERITContent = SGetField<Java.Lang.ProcessBuilder.Redirect>(LocalBridgeClazz, "INHERIT"); _INHERITReady = true; } return _INHERITContent; } }
            private static Java.Lang.ProcessBuilder.Redirect _INHERITContent = default;
            private static bool _INHERITReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.Redirect.html#PIPE"/>
            /// </summary>
            public static Java.Lang.ProcessBuilder.Redirect PIPE { get { if (!_PIPEReady) { _PIPEContent = SGetField<Java.Lang.ProcessBuilder.Redirect>(LocalBridgeClazz, "PIPE"); _PIPEReady = true; } return _PIPEContent; } }
            private static Java.Lang.ProcessBuilder.Redirect _PIPEContent = default;
            private static bool _PIPEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.Redirect.html#appendTo(java.io.File)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.File"/></param>
            /// <returns><see cref="Java.Lang.ProcessBuilder.Redirect"/></returns>
            public static Java.Lang.ProcessBuilder.Redirect AppendTo(Java.Io.File arg0)
            {
                return SExecuteWithSignature<Java.Lang.ProcessBuilder.Redirect>(LocalBridgeClazz, "appendTo", "(Ljava/io/File;)Ljava/lang/ProcessBuilder$Redirect;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.Redirect.html#from(java.io.File)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.File"/></param>
            /// <returns><see cref="Java.Lang.ProcessBuilder.Redirect"/></returns>
            public static Java.Lang.ProcessBuilder.Redirect From(Java.Io.File arg0)
            {
                return SExecuteWithSignature<Java.Lang.ProcessBuilder.Redirect>(LocalBridgeClazz, "from", "(Ljava/io/File;)Ljava/lang/ProcessBuilder$Redirect;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.Redirect.html#to(java.io.File)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.File"/></param>
            /// <returns><see cref="Java.Lang.ProcessBuilder.Redirect"/></returns>
            public static Java.Lang.ProcessBuilder.Redirect To(Java.Io.File arg0)
            {
                return SExecuteWithSignature<Java.Lang.ProcessBuilder.Redirect>(LocalBridgeClazz, "to", "(Ljava/io/File;)Ljava/lang/ProcessBuilder$Redirect;", arg0);
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessBuilder.Redirect.html#file()"/>
            /// </summary>
            /// <returns><see cref="Java.Io.File"/></returns>
            public Java.Io.File File()
            {
                return IExecuteWithSignature<Java.Io.File>("file", "()Ljava/io/File;");
            }

            #endregion

            #region Nested classes
            #region Type
            public partial class Type
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}