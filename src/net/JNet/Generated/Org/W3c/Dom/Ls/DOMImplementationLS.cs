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

namespace Org.W3c.Dom.Ls
{
    #region DOMImplementationLS declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/DOMImplementationLS.html"/>
    /// </summary>
    public partial class DOMImplementationLS : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DOMImplementationLS>
    {
        const string _bridgeClassName = "org.w3c.dom.ls.DOMImplementationLS";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("DOMImplementationLS class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DOMImplementationLS() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("DOMImplementationLS class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DOMImplementationLS(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IDOMImplementationLS
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDOMImplementationLS
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/DOMImplementationLS.html#createLSInput()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Ls.LSInput"/></returns>
        Org.W3c.Dom.Ls.LSInput CreateLSInput();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/DOMImplementationLS.html#createLSOutput()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Ls.LSOutput"/></returns>
        Org.W3c.Dom.Ls.LSOutput CreateLSOutput();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/DOMImplementationLS.html#createLSParser(short,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Ls.LSParser"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Ls.LSParser CreateLSParser(short arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/DOMImplementationLS.html#createLSSerializer()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Ls.LSSerializer"/></returns>
        Org.W3c.Dom.Ls.LSSerializer CreateLSSerializer();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DOMImplementationLS implementation
    public partial class DOMImplementationLS : Org.W3c.Dom.Ls.IDOMImplementationLS
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/DOMImplementationLS.html#MODE_ASYNCHRONOUS"/>
        /// </summary>
        public static short MODE_ASYNCHRONOUS { get { if (!_MODE_ASYNCHRONOUSReady) { _MODE_ASYNCHRONOUSContent = SGetField<short>(LocalBridgeClazz, "MODE_ASYNCHRONOUS"); _MODE_ASYNCHRONOUSReady = true; } return _MODE_ASYNCHRONOUSContent; } }
        private static short _MODE_ASYNCHRONOUSContent = default;
        private static bool _MODE_ASYNCHRONOUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/DOMImplementationLS.html#MODE_SYNCHRONOUS"/>
        /// </summary>
        public static short MODE_SYNCHRONOUS { get { if (!_MODE_SYNCHRONOUSReady) { _MODE_SYNCHRONOUSContent = SGetField<short>(LocalBridgeClazz, "MODE_SYNCHRONOUS"); _MODE_SYNCHRONOUSReady = true; } return _MODE_SYNCHRONOUSContent; } }
        private static short _MODE_SYNCHRONOUSContent = default;
        private static bool _MODE_SYNCHRONOUSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/DOMImplementationLS.html#createLSInput()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Ls.LSInput"/></returns>
        public Org.W3c.Dom.Ls.LSInput CreateLSInput()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Ls.LSInput>("createLSInput", "()Lorg/w3c/dom/ls/LSInput;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/DOMImplementationLS.html#createLSOutput()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Ls.LSOutput"/></returns>
        public Org.W3c.Dom.Ls.LSOutput CreateLSOutput()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Ls.LSOutput>("createLSOutput", "()Lorg/w3c/dom/ls/LSOutput;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/DOMImplementationLS.html#createLSParser(short,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Ls.LSParser"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Ls.LSParser CreateLSParser(short arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Ls.LSParser>("createLSParser", "(SLjava/lang/String;)Lorg/w3c/dom/ls/LSParser;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/DOMImplementationLS.html#createLSSerializer()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Ls.LSSerializer"/></returns>
        public Org.W3c.Dom.Ls.LSSerializer CreateLSSerializer()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Ls.LSSerializer>("createLSSerializer", "()Lorg/w3c/dom/ls/LSSerializer;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}