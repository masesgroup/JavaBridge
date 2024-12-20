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

namespace Java.Nio.Charset
{
    #region CodingErrorAction declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CodingErrorAction.html"/>
    /// </summary>
    public partial class CodingErrorAction : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CodingErrorAction>
    {
        const string _bridgeClassName = "java.nio.charset.CodingErrorAction";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CodingErrorAction() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CodingErrorAction(params object[] args) : base(args) { }

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

    }
    #endregion

    #region CodingErrorAction implementation
    public partial class CodingErrorAction
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CodingErrorAction.html#IGNORE"/>
        /// </summary>
        public static Java.Nio.Charset.CodingErrorAction IGNORE { get { if (!_IGNOREReady) { _IGNOREContent = SGetField<Java.Nio.Charset.CodingErrorAction>(LocalBridgeClazz, "IGNORE"); _IGNOREReady = true; } return _IGNOREContent; } }
        private static Java.Nio.Charset.CodingErrorAction _IGNOREContent = default;
        private static bool _IGNOREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CodingErrorAction.html#REPLACE"/>
        /// </summary>
        public static Java.Nio.Charset.CodingErrorAction REPLACE { get { if (!_REPLACEReady) { _REPLACEContent = SGetField<Java.Nio.Charset.CodingErrorAction>(LocalBridgeClazz, "REPLACE"); _REPLACEReady = true; } return _REPLACEContent; } }
        private static Java.Nio.Charset.CodingErrorAction _REPLACEContent = default;
        private static bool _REPLACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CodingErrorAction.html#REPORT"/>
        /// </summary>
        public static Java.Nio.Charset.CodingErrorAction REPORT { get { if (!_REPORTReady) { _REPORTContent = SGetField<Java.Nio.Charset.CodingErrorAction>(LocalBridgeClazz, "REPORT"); _REPORTReady = true; } return _REPORTContent; } }
        private static Java.Nio.Charset.CodingErrorAction _REPORTContent = default;
        private static bool _REPORTReady = false; // this is used because in case of generics 

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
}