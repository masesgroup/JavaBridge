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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Script
{
    #region ScriptEngine
    public partial class ScriptEngine
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#ARGV"/>
        /// </summary>
        public static string ARGV => Clazz.GetField<string>("ARGV");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#ENGINE"/>
        /// </summary>
        public static string ENGINE => Clazz.GetField<string>("ENGINE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#ENGINE_VERSION"/>
        /// </summary>
        public static string ENGINE_VERSION => Clazz.GetField<string>("ENGINE_VERSION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#FILENAME"/>
        /// </summary>
        public static string FILENAME => Clazz.GetField<string>("FILENAME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#LANGUAGE"/>
        /// </summary>
        public static string LANGUAGE => Clazz.GetField<string>("LANGUAGE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#LANGUAGE_VERSION"/>
        /// </summary>
        public static string LANGUAGE_VERSION => Clazz.GetField<string>("LANGUAGE_VERSION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#NAME"/>
        /// </summary>
        public static string NAME => Clazz.GetField<string>("NAME");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#getContext()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#setContext(javax.script.ScriptContext)"/>
        /// </summary>
        public Javax.Script.ScriptContext Context
        {
            get { return IExecute<Javax.Script.ScriptContext>("getContext"); } set { IExecute("setContext", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#getFactory()"/> 
        /// </summary>
        public Javax.Script.ScriptEngineFactory Factory
        {
            get { return IExecute<Javax.Script.ScriptEngineFactory>("getFactory"); }
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
            return IExecute("eval", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.lang.String,javax.script.Bindings)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Script.Bindings"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        public object Eval(string arg0, Javax.Script.Bindings arg1)
        {
            return IExecute("eval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.lang.String,javax.script.ScriptContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Script.ScriptContext"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        public object Eval(string arg0, Javax.Script.ScriptContext arg1)
        {
            return IExecute("eval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#eval(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        public object Eval(string arg0)
        {
            return IExecute("eval", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(string arg0)
        {
            return IExecute("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#createBindings()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Script.Bindings"/></returns>
        public Javax.Script.Bindings CreateBindings()
        {
            return IExecute<Javax.Script.Bindings>("createBindings");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#getBindings(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Script.Bindings"/></returns>
        public Javax.Script.Bindings GetBindings(int arg0)
        {
            return IExecute<Javax.Script.Bindings>("getBindings", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html#put(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Put(string arg0, object arg1)
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