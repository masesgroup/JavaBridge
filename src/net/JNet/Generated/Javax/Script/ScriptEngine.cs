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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Script
{
    #region IScriptEngine
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IScriptEngine
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#getContext()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#setContext(javax.script.ScriptContext)"/>
        /// </summary>
        Javax.Script.ScriptContext Context { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#getFactory()"/> 
        /// </summary>
        Javax.Script.ScriptEngineFactory Factory { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.io.Reader,javax.script.Bindings)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <param name="arg1"><see cref="Javax.Script.Bindings"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        object Eval(Java.Io.Reader arg0, Javax.Script.Bindings arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.io.Reader,javax.script.ScriptContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <param name="arg1"><see cref="Javax.Script.ScriptContext"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        object Eval(Java.Io.Reader arg0, Javax.Script.ScriptContext arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        object Eval(Java.Io.Reader arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.lang.String,javax.script.Bindings)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Script.Bindings"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        object Eval(Java.Lang.String arg0, Javax.Script.Bindings arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.lang.String,javax.script.ScriptContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Script.ScriptContext"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        object Eval(Java.Lang.String arg0, Javax.Script.ScriptContext arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        object Eval(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        object Get(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#createBindings()"/>
        /// </summary>

        /// <returns><see cref="Javax.Script.Bindings"/></returns>
        Javax.Script.Bindings CreateBindings();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#getBindings(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Script.Bindings"/></returns>
        Javax.Script.Bindings GetBindings(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#put(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        void Put(Java.Lang.String arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#setBindings(javax.script.Bindings,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Script.Bindings"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void SetBindings(Javax.Script.Bindings arg0, int arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ScriptEngine
    public partial class ScriptEngine : Javax.Script.IScriptEngine
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#ARGV"/>
        /// </summary>
        public static Java.Lang.String ARGV { get { if (!_ARGVReady) { _ARGVContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ARGV"); _ARGVReady = true; } return _ARGVContent; } }
        private static Java.Lang.String _ARGVContent = default;
        private static bool _ARGVReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#ENGINE"/>
        /// </summary>
        public static Java.Lang.String ENGINE { get { if (!_ENGINEReady) { _ENGINEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ENGINE"); _ENGINEReady = true; } return _ENGINEContent; } }
        private static Java.Lang.String _ENGINEContent = default;
        private static bool _ENGINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#ENGINE_VERSION"/>
        /// </summary>
        public static Java.Lang.String ENGINE_VERSION { get { if (!_ENGINE_VERSIONReady) { _ENGINE_VERSIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ENGINE_VERSION"); _ENGINE_VERSIONReady = true; } return _ENGINE_VERSIONContent; } }
        private static Java.Lang.String _ENGINE_VERSIONContent = default;
        private static bool _ENGINE_VERSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#FILENAME"/>
        /// </summary>
        public static Java.Lang.String FILENAME { get { if (!_FILENAMEReady) { _FILENAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FILENAME"); _FILENAMEReady = true; } return _FILENAMEContent; } }
        private static Java.Lang.String _FILENAMEContent = default;
        private static bool _FILENAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#LANGUAGE"/>
        /// </summary>
        public static Java.Lang.String LANGUAGE { get { if (!_LANGUAGEReady) { _LANGUAGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LANGUAGE"); _LANGUAGEReady = true; } return _LANGUAGEContent; } }
        private static Java.Lang.String _LANGUAGEContent = default;
        private static bool _LANGUAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#LANGUAGE_VERSION"/>
        /// </summary>
        public static Java.Lang.String LANGUAGE_VERSION { get { if (!_LANGUAGE_VERSIONReady) { _LANGUAGE_VERSIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LANGUAGE_VERSION"); _LANGUAGE_VERSIONReady = true; } return _LANGUAGE_VERSIONContent; } }
        private static Java.Lang.String _LANGUAGE_VERSIONContent = default;
        private static bool _LANGUAGE_VERSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#NAME"/>
        /// </summary>
        public static Java.Lang.String NAME { get { if (!_NAMEReady) { _NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "NAME"); _NAMEReady = true; } return _NAMEContent; } }
        private static Java.Lang.String _NAMEContent = default;
        private static bool _NAMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#getContext()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#setContext(javax.script.ScriptContext)"/>
        /// </summary>
        public Javax.Script.ScriptContext Context
        {
            get { return IExecuteWithSignature<Javax.Script.ScriptContext>("getContext", "()Ljavax/script/ScriptContext;"); } set { IExecuteWithSignature("setContext", "(Ljavax/script/ScriptContext;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#getFactory()"/> 
        /// </summary>
        public Javax.Script.ScriptEngineFactory Factory
        {
            get { return IExecuteWithSignature<Javax.Script.ScriptEngineFactory>("getFactory", "()Ljavax/script/ScriptEngineFactory;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.io.Reader,javax.script.Bindings)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <param name="arg1"><see cref="Javax.Script.Bindings"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        public object Eval(Java.Io.Reader arg0, Javax.Script.Bindings arg1)
        {
            return IExecute("eval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.io.Reader,javax.script.ScriptContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <param name="arg1"><see cref="Javax.Script.ScriptContext"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        public object Eval(Java.Io.Reader arg0, Javax.Script.ScriptContext arg1)
        {
            return IExecute("eval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        public object Eval(Java.Io.Reader arg0)
        {
            return IExecuteWithSignature("eval", "(Ljava/io/Reader;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.lang.String,javax.script.Bindings)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Script.Bindings"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        public object Eval(Java.Lang.String arg0, Javax.Script.Bindings arg1)
        {
            return IExecute("eval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.lang.String,javax.script.ScriptContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Script.ScriptContext"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        public object Eval(Java.Lang.String arg0, Javax.Script.ScriptContext arg1)
        {
            return IExecute("eval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        public object Eval(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("eval", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("get", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#createBindings()"/>
        /// </summary>

        /// <returns><see cref="Javax.Script.Bindings"/></returns>
        public Javax.Script.Bindings CreateBindings()
        {
            return IExecuteWithSignature<Javax.Script.Bindings>("createBindings", "()Ljavax/script/Bindings;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#getBindings(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Script.Bindings"/></returns>
        public Javax.Script.Bindings GetBindings(int arg0)
        {
            return IExecuteWithSignature<Javax.Script.Bindings>("getBindings", "(I)Ljavax/script/Bindings;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#put(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Put(Java.Lang.String arg0, object arg1)
        {
            IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#setBindings(javax.script.Bindings,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Script.Bindings"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetBindings(Javax.Script.Bindings arg0, int arg1)
        {
            IExecute("setBindings", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}