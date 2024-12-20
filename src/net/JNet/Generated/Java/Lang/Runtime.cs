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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Runtime declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html"/>
    /// </summary>
    public partial class Runtime : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Runtime>
    {
        const string _bridgeClassName = "java.lang.Runtime";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Runtime() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Runtime(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        #region Version declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html"/>
        /// </summary>
        public partial class Version : Java.Lang.Comparable<Java.Lang.Runtime.Version>
        {
            const string _bridgeClassName = "java.lang.Runtime$Version";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Version() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Version(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region Runtime implementation
    public partial class Runtime
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#getRuntime()"/> 
        /// </summary>
        public static Java.Lang.Runtime GetRuntime
        {
            get { return SExecuteWithSignature<Java.Lang.Runtime>(LocalBridgeClazz, "getRuntime", "()Ljava/lang/Runtime;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#version()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Runtime.Version"/></returns>
        public static Java.Lang.Runtime.Version VersionMethod()
        {
            return SExecuteWithSignature<Java.Lang.Runtime.Version>(LocalBridgeClazz, "version", "()Ljava/lang/Runtime$Version;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#removeShutdownHook(java.lang.Thread)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveShutdownHook(Java.Lang.Thread arg0)
        {
            return IExecuteWithSignature<bool>("removeShutdownHook", "(Ljava/lang/Thread;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#exec(java.lang.String,java.lang.String[],java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Process Exec(Java.Lang.String arg0, Java.Lang.String[] arg1, Java.Io.File arg2)
        {
            return IExecuteWithSignature<Java.Lang.Process>("exec", "(Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#exec(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Process Exec(Java.Lang.String arg0, Java.Lang.String[] arg1)
        {
            return IExecuteWithSignature<Java.Lang.Process>("exec", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#exec(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Process Exec(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Process>("exec", "(Ljava/lang/String;)Ljava/lang/Process;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#exec(java.lang.String[],java.lang.String[],java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Process Exec(Java.Lang.String[] arg0, Java.Lang.String[] arg1, Java.Io.File arg2)
        {
            return IExecuteWithSignature<Java.Lang.Process>("exec", "([Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#exec(java.lang.String[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Process Exec(Java.Lang.String[] arg0, Java.Lang.String[] arg1)
        {
            return IExecuteWithSignature<Java.Lang.Process>("exec", "([Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#exec(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Process Exec(Java.Lang.String[] arg0)
        {
            return IExecuteWithSignature<Java.Lang.Process>("exec", "([Ljava/lang/String;)Ljava/lang/Process;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#availableProcessors()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int AvailableProcessors()
        {
            return IExecuteWithSignature<int>("availableProcessors", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#freeMemory()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long FreeMemory()
        {
            return IExecuteWithSignature<long>("freeMemory", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#maxMemory()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long MaxMemory()
        {
            return IExecuteWithSignature<long>("maxMemory", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#totalMemory()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long TotalMemory()
        {
            return IExecuteWithSignature<long>("totalMemory", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#gc()"/>
        /// </summary>
        public void Gc()
        {
            IExecuteWithSignature("gc", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#addShutdownHook(java.lang.Thread)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        public void AddShutdownHook(Java.Lang.Thread arg0)
        {
            IExecuteWithSignature("addShutdownHook", "(Ljava/lang/Thread;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#exit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Exit(int arg0)
        {
            IExecuteWithSignature("exit", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#halt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Halt(int arg0)
        {
            IExecuteWithSignature("halt", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#load(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Load(Java.Lang.String arg0)
        {
            IExecuteWithSignature("load", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#loadLibrary(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void LoadLibrary(Java.Lang.String arg0)
        {
            IExecuteWithSignature("loadLibrary", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#runFinalization()"/>
        /// </summary>
        public void RunFinalization()
        {
            IExecuteWithSignature("runFinalization", "()V");
        }

        #endregion

        #region Nested classes
        #region Version implementation
        public partial class Version
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#parse(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Lang.Runtime.Version"/></returns>
            public static Java.Lang.Runtime.Version Parse(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Lang.Runtime.Version>(LocalBridgeClazz, "parse", "(Ljava/lang/String;)Ljava/lang/Runtime$Version;", arg0);
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#equalsIgnoreOptional(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool EqualsIgnoreOptional(object arg0)
            {
                return IExecuteWithSignature<bool>("equalsIgnoreOptional", "(Ljava/lang/Object;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#compareTo(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="int"/></returns>
            public int CompareTo(object arg0)
            {
                return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#compareTo(java.lang.Runtime.Version)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Runtime.Version"/></param>
            /// <returns><see cref="int"/></returns>
            public int CompareTo(Java.Lang.Runtime.Version arg0)
            {
                return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Runtime$Version;)I", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#compareToIgnoreOptional(java.lang.Runtime.Version)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Runtime.Version"/></param>
            /// <returns><see cref="int"/></returns>
            public int CompareToIgnoreOptional(Java.Lang.Runtime.Version arg0)
            {
                return IExecuteWithSignature<int>("compareToIgnoreOptional", "(Ljava/lang/Runtime$Version;)I", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#feature()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Feature()
            {
                return IExecuteWithSignature<int>("feature", "()I");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#interim()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Interim()
            {
                return IExecuteWithSignature<int>("interim", "()I");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#patch()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Patch()
            {
                return IExecuteWithSignature<int>("patch", "()I");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#update()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Update()
            {
                return IExecuteWithSignature<int>("update", "()I");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#version()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Java.Lang.Integer> VersionMethod()
            {
                return IExecuteWithSignature<Java.Util.List<Java.Lang.Integer>>("version", "()Ljava/util/List;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#build()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Lang.Integer> Build()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Lang.Integer>>("build", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#optional()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Lang.String> Optional()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Lang.String>>("optional", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#pre()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Lang.String> Pre()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Lang.String>>("pre", "()Ljava/util/Optional;");
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