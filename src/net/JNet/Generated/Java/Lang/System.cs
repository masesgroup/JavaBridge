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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region System
    public partial class System
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#in"/>
        /// </summary>
        public static Java.Io.InputStream inField { get { if (!_inFieldReady) { _inFieldContent = SGetField<Java.Io.InputStream>(LocalBridgeClazz, "in"); _inFieldReady = true; } return _inFieldContent; } }
        private static Java.Io.InputStream _inFieldContent = default;
        private static bool _inFieldReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#err"/>
        /// </summary>
        public static Java.Io.PrintStream err { get { if (!_errReady) { _errContent = SGetField<Java.Io.PrintStream>(LocalBridgeClazz, "err"); _errReady = true; } return _errContent; } }
        private static Java.Io.PrintStream _errContent = default;
        private static bool _errReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#out"/>
        /// </summary>
        public static Java.Io.PrintStream outField { get { if (!_outFieldReady) { _outFieldContent = SGetField<Java.Io.PrintStream>(LocalBridgeClazz, "out"); _outFieldReady = true; } return _outFieldContent; } }
        private static Java.Io.PrintStream _outFieldContent = default;
        private static bool _outFieldReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#getenv()"/> 
        /// </summary>
        public static Java.Util.Map<Java.Lang.String, Java.Lang.String> Env
        {
            get { return SExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>(LocalBridgeClazz, "getenv", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#getProperties()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#setProperties(java.util.Properties)"/>
        /// </summary>
        public static Java.Util.Properties Properties
        {
            get { return SExecuteWithSignature<Java.Util.Properties>(LocalBridgeClazz, "getProperties", "()Ljava/util/Properties;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setProperties", "(Ljava/util/Properties;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#getSecurityManager()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#setSecurityManager(java.lang.SecurityManager)"/>
        /// </summary>
        public static Java.Lang.SecurityManager SecurityManager
        {
            get { return SExecuteWithSignature<Java.Lang.SecurityManager>(LocalBridgeClazz, "getSecurityManager", "()Ljava/lang/SecurityManager;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setSecurityManager", "(Ljava/lang/SecurityManager;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#console()"/>
        /// </summary>

        /// <returns><see cref="Java.Io.Console"/></returns>
        public static Java.Io.Console Console()
        {
            return SExecuteWithSignature<Java.Io.Console>(LocalBridgeClazz, "console", "()Ljava/io/Console;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#clearProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ClearProperty(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "clearProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#getenv(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Getenv(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getenv", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#getProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetProperty(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "getProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetProperty(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#lineSeparator()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String LineSeparator()
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "lineSeparator", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#setProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String SetProperty(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "setProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#getLogger(java.lang.String,java.util.ResourceBundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.ResourceBundle"/></param>
        /// <returns><see cref="Java.Lang.System.Logger"/></returns>
        public static Java.Lang.System.Logger GetLogger(Java.Lang.String arg0, Java.Util.ResourceBundle arg1)
        {
            return SExecute<Java.Lang.System.Logger>(LocalBridgeClazz, "getLogger", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#getLogger(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.System.Logger"/></returns>
        public static Java.Lang.System.Logger GetLogger(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.System.Logger>(LocalBridgeClazz, "getLogger", "(Ljava/lang/String;)Ljava/lang/System$Logger;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#inheritedChannel()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Channels.Channel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.Channel InheritedChannel()
        {
            return SExecuteWithSignature<Java.Nio.Channels.Channel>(LocalBridgeClazz, "inheritedChannel", "()Ljava/nio/channels/Channel;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#identityHashCode(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public static int IdentityHashCode(object arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "identityHashCode", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#mapLibraryName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String MapLibraryName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "mapLibraryName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#currentTimeMillis()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public static long CurrentTimeMillis()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "currentTimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#nanoTime()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public static long NanoTime()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "nanoTime", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#arraycopy(java.lang.Object,int,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public static void Arraycopy(object arg0, int arg1, object arg2, int arg3, int arg4)
        {
            SExecute(LocalBridgeClazz, "arraycopy", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#exit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public static void Exit(int arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "exit", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#gc()"/>
        /// </summary>
        public static void Gc()
        {
            SExecuteWithSignature(LocalBridgeClazz, "gc", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#load(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void Load(Java.Lang.String arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "load", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#loadLibrary(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void LoadLibrary(Java.Lang.String arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "loadLibrary", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#runFinalization()"/>
        /// </summary>
        public static void RunFinalization()
        {
            SExecuteWithSignature(LocalBridgeClazz, "runFinalization", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#setErr(java.io.PrintStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintStream"/></param>
        public static void SetErr(Java.Io.PrintStream arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setErr", "(Ljava/io/PrintStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#setIn(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        public static void SetIn(Java.Io.InputStream arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setIn", "(Ljava/io/InputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.html#setOut(java.io.PrintStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintStream"/></param>
        public static void SetOut(Java.Io.PrintStream arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setOut", "(Ljava/io/PrintStream;)V", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Logger
        public partial class Logger
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.html#getName()"/> 
            /// </summary>
            public Java.Lang.String Name
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.html#isLoggable(java.lang.System.Logger.Level)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.System.Logger.Level"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsLoggable(Java.Lang.System.Logger.Level arg0)
            {
                return IExecuteWithSignature<bool>("isLoggable", "(Ljava/lang/System$Logger$Level;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.html#log(java.lang.System.Logger.Level,java.util.ResourceBundle,java.lang.String,java.lang.Object[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.System.Logger.Level"/></param>
            /// <param name="arg1"><see cref="Java.Util.ResourceBundle"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <param name="arg3"><see cref="object"/></param>
            public void Log(Java.Lang.System.Logger.Level arg0, Java.Util.ResourceBundle arg1, Java.Lang.String arg2, params object[] arg3)
            {
                if (arg3.Length == 0) IExecute("log", arg0, arg1, arg2); else IExecute("log", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.html#log(java.lang.System.Logger.Level,java.util.ResourceBundle,java.lang.String,java.lang.Throwable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.System.Logger.Level"/></param>
            /// <param name="arg1"><see cref="Java.Util.ResourceBundle"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <param name="arg3"><see cref="Java.Lang.Throwable"/></param>
            public void Log(Java.Lang.System.Logger.Level arg0, Java.Util.ResourceBundle arg1, Java.Lang.String arg2, MASES.JCOBridge.C2JBridge.JVMBridgeException arg3)
            {
                IExecute("log", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.html#log(java.lang.System.Logger.Level,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.System.Logger.Level"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            public void Log(Java.Lang.System.Logger.Level arg0, object arg1)
            {
                IExecute("log", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.html#log(java.lang.System.Logger.Level,java.lang.String,java.lang.Object[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.System.Logger.Level"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="object"/></param>
            public void Log(Java.Lang.System.Logger.Level arg0, Java.Lang.String arg1, params object[] arg2)
            {
                if (arg2.Length == 0) IExecute("log", arg0, arg1); else IExecute("log", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.html#log(java.lang.System.Logger.Level,java.lang.String,java.lang.Throwable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.System.Logger.Level"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Java.Lang.Throwable"/></param>
            public void Log(Java.Lang.System.Logger.Level arg0, Java.Lang.String arg1, MASES.JCOBridge.C2JBridge.JVMBridgeException arg2)
            {
                IExecute("log", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.html#log(java.lang.System.Logger.Level,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.System.Logger.Level"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public void Log(Java.Lang.System.Logger.Level arg0, Java.Lang.String arg1)
            {
                IExecute("log", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.html#log(java.lang.System.Logger.Level,java.util.function.Supplier,java.lang.Throwable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.System.Logger.Level"/></param>
            /// <param name="arg1"><see cref="Java.Util.Function.Supplier"/></param>
            /// <param name="arg2"><see cref="Java.Lang.Throwable"/></param>
            public void Log(Java.Lang.System.Logger.Level arg0, Java.Util.Function.Supplier<Java.Lang.String> arg1, MASES.JCOBridge.C2JBridge.JVMBridgeException arg2)
            {
                IExecute("log", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.html#log(java.lang.System.Logger.Level,java.util.function.Supplier)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.System.Logger.Level"/></param>
            /// <param name="arg1"><see cref="Java.Util.Function.Supplier"/></param>
            public void Log(Java.Lang.System.Logger.Level arg0, Java.Util.Function.Supplier<Java.Lang.String> arg1)
            {
                IExecute("log", arg0, arg1);
            }

            #endregion

            #region Nested classes
            #region Level
            public partial class Level
            {
                #region Constructors

                #endregion

                #region Class/Interface conversion operators

                #endregion

                #region Fields
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.Level.html#ALL"/>
                /// </summary>
                public static Java.Lang.System.Logger.Level ALL { get { if (!_ALLReady) { _ALLContent = SGetField<Java.Lang.System.Logger.Level>(LocalBridgeClazz, "ALL"); _ALLReady = true; } return _ALLContent; } }
                private static Java.Lang.System.Logger.Level _ALLContent = default;
                private static bool _ALLReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.Level.html#DEBUG"/>
                /// </summary>
                public static Java.Lang.System.Logger.Level DEBUG { get { if (!_DEBUGReady) { _DEBUGContent = SGetField<Java.Lang.System.Logger.Level>(LocalBridgeClazz, "DEBUG"); _DEBUGReady = true; } return _DEBUGContent; } }
                private static Java.Lang.System.Logger.Level _DEBUGContent = default;
                private static bool _DEBUGReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.Level.html#ERROR"/>
                /// </summary>
                public static Java.Lang.System.Logger.Level ERROR { get { if (!_ERRORReady) { _ERRORContent = SGetField<Java.Lang.System.Logger.Level>(LocalBridgeClazz, "ERROR"); _ERRORReady = true; } return _ERRORContent; } }
                private static Java.Lang.System.Logger.Level _ERRORContent = default;
                private static bool _ERRORReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.Level.html#INFO"/>
                /// </summary>
                public static Java.Lang.System.Logger.Level INFO { get { if (!_INFOReady) { _INFOContent = SGetField<Java.Lang.System.Logger.Level>(LocalBridgeClazz, "INFO"); _INFOReady = true; } return _INFOContent; } }
                private static Java.Lang.System.Logger.Level _INFOContent = default;
                private static bool _INFOReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.Level.html#OFF"/>
                /// </summary>
                public static Java.Lang.System.Logger.Level OFF { get { if (!_OFFReady) { _OFFContent = SGetField<Java.Lang.System.Logger.Level>(LocalBridgeClazz, "OFF"); _OFFReady = true; } return _OFFContent; } }
                private static Java.Lang.System.Logger.Level _OFFContent = default;
                private static bool _OFFReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.Level.html#TRACE"/>
                /// </summary>
                public static Java.Lang.System.Logger.Level TRACE { get { if (!_TRACEReady) { _TRACEContent = SGetField<Java.Lang.System.Logger.Level>(LocalBridgeClazz, "TRACE"); _TRACEReady = true; } return _TRACEContent; } }
                private static Java.Lang.System.Logger.Level _TRACEContent = default;
                private static bool _TRACEReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.Level.html#WARNING"/>
                /// </summary>
                public static Java.Lang.System.Logger.Level WARNING { get { if (!_WARNINGReady) { _WARNINGContent = SGetField<Java.Lang.System.Logger.Level>(LocalBridgeClazz, "WARNING"); _WARNINGReady = true; } return _WARNINGContent; } }
                private static Java.Lang.System.Logger.Level _WARNINGContent = default;
                private static bool _WARNINGReady = false; // this is used because in case of generics 

                #endregion

                #region Static methods
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.Level.html#valueOf(java.lang.String)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.String"/></param>
                /// <returns><see cref="Java.Lang.System.Logger.Level"/></returns>
                public static Java.Lang.System.Logger.Level ValueOf(Java.Lang.String arg0)
                {
                    return SExecuteWithSignature<Java.Lang.System.Logger.Level>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/lang/System$Logger$Level;", arg0);
                }
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.Level.html#values()"/>
                /// </summary>

                /// <returns><see cref="Java.Lang.System.Logger.Level"/></returns>
                public static Java.Lang.System.Logger.Level[] Values()
                {
                    return SExecuteWithSignatureArray<Java.Lang.System.Logger.Level>(LocalBridgeClazz, "values", "()[Ljava/lang/System$Logger$Level;");
                }

                #endregion

                #region Instance methods
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.Level.html#getName()"/> 
                /// </summary>
                public Java.Lang.String Name
                {
                    get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
                }
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.Level.html#getSeverity()"/> 
                /// </summary>
                public int Severity
                {
                    get { return IExecuteWithSignature<int>("getSeverity", "()I"); }
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

        #region LoggerFinder
        public partial class LoggerFinder
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.LoggerFinder.html#getLoggerFinder()"/> 
            /// </summary>
            public static Java.Lang.System.LoggerFinder GetLoggerFinder
            {
                get { return SExecuteWithSignature<Java.Lang.System.LoggerFinder>(LocalBridgeClazz, "getLoggerFinder", "()Ljava/lang/System$LoggerFinder;"); }
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.LoggerFinder.html#getLogger(java.lang.String,java.lang.Module)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.Module"/></param>
            /// <returns><see cref="Java.Lang.System.Logger"/></returns>
            public Java.Lang.System.Logger GetLogger(Java.Lang.String arg0, Java.Lang.Module arg1)
            {
                return IExecute<Java.Lang.System.Logger>("getLogger", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.LoggerFinder.html#getLocalizedLogger(java.lang.String,java.util.ResourceBundle,java.lang.Module)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Util.ResourceBundle"/></param>
            /// <param name="arg2"><see cref="Java.Lang.Module"/></param>
            /// <returns><see cref="Java.Lang.System.Logger"/></returns>
            public Java.Lang.System.Logger GetLocalizedLogger(Java.Lang.String arg0, Java.Util.ResourceBundle arg1, Java.Lang.Module arg2)
            {
                return IExecute<Java.Lang.System.Logger>("getLocalizedLogger", arg0, arg1, arg2);
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