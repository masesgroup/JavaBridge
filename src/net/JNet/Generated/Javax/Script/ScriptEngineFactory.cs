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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Script
{
    #region IScriptEngineFactory
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html"/>
    /// </summary>
    public partial interface IScriptEngineFactory
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getEngineName()"/> 
        /// </summary>
        string EngineName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getEngineVersion()"/> 
        /// </summary>
        string EngineVersion { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getExtensions()"/> 
        /// </summary>
        Java.Util.List<string> Extensions { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getLanguageName()"/> 
        /// </summary>
        string LanguageName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getLanguageVersion()"/> 
        /// </summary>
        string LanguageVersion { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getMimeTypes()"/> 
        /// </summary>
        Java.Util.List<string> MimeTypes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getNames()"/> 
        /// </summary>
        Java.Util.List<string> Names { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getScriptEngine()"/> 
        /// </summary>
        Javax.Script.ScriptEngine ScriptEngine { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getParameter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        object GetParameter(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getMethodCallSyntax(java.lang.String,java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        string GetMethodCallSyntax(string arg0, string arg1, params string[] arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getOutputStatement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        string GetOutputStatement(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getProgram(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        string GetProgram(params string[] arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ScriptEngineFactory
    public partial class ScriptEngineFactory : Javax.Script.IScriptEngineFactory
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getEngineName()"/> 
        /// </summary>
        public string EngineName
        {
            get { return IExecute<string>("getEngineName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getEngineVersion()"/> 
        /// </summary>
        public string EngineVersion
        {
            get { return IExecute<string>("getEngineVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getExtensions()"/> 
        /// </summary>
        public Java.Util.List<string> Extensions
        {
            get { return IExecute<Java.Util.List<string>>("getExtensions"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getLanguageName()"/> 
        /// </summary>
        public string LanguageName
        {
            get { return IExecute<string>("getLanguageName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getLanguageVersion()"/> 
        /// </summary>
        public string LanguageVersion
        {
            get { return IExecute<string>("getLanguageVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getMimeTypes()"/> 
        /// </summary>
        public Java.Util.List<string> MimeTypes
        {
            get { return IExecute<Java.Util.List<string>>("getMimeTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getNames()"/> 
        /// </summary>
        public Java.Util.List<string> Names
        {
            get { return IExecute<Java.Util.List<string>>("getNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getScriptEngine()"/> 
        /// </summary>
        public Javax.Script.ScriptEngine ScriptEngine
        {
            get { return IExecute<Javax.Script.ScriptEngine>("getScriptEngine"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getParameter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetParameter(string arg0)
        {
            return IExecute("getParameter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getMethodCallSyntax(java.lang.String,java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetMethodCallSyntax(string arg0, string arg1, params string[] arg2)
        {
            if (arg2.Length == 0) return IExecute<string>("getMethodCallSyntax", arg0, arg1); else return IExecute<string>("getMethodCallSyntax", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getOutputStatement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetOutputStatement(string arg0)
        {
            return IExecute<string>("getOutputStatement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getProgram(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetProgram(params string[] arg0)
        {
            if (arg0.Length == 0) return IExecute<string>("getProgram"); else return IExecute<string>("getProgram", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}