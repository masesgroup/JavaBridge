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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region CookiePolicy declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookiePolicy.html"/>
    /// </summary>
    public partial class CookiePolicy : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CookiePolicy>
    {
        const string _bridgeClassName = "java.net.CookiePolicy";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CookiePolicy class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CookiePolicy() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CookiePolicy class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CookiePolicy(params object[] args) : base(args) { }

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

    #region ICookiePolicy
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICookiePolicy
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookiePolicy.html#shouldAccept(java.net.URI,java.net.HttpCookie)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Net.HttpCookie"/></param>
        /// <returns><see cref="bool"/></returns>
        bool ShouldAccept(Java.Net.URI arg0, Java.Net.HttpCookie arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CookiePolicy implementation
    public partial class CookiePolicy : Java.Net.ICookiePolicy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookiePolicy.html#ACCEPT_ALL"/>
        /// </summary>
        public static Java.Net.CookiePolicy ACCEPT_ALL { get { if (!_ACCEPT_ALLReady) { _ACCEPT_ALLContent = SGetField<Java.Net.CookiePolicy>(LocalBridgeClazz, "ACCEPT_ALL"); _ACCEPT_ALLReady = true; } return _ACCEPT_ALLContent; } }
        private static Java.Net.CookiePolicy _ACCEPT_ALLContent = default;
        private static bool _ACCEPT_ALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookiePolicy.html#ACCEPT_NONE"/>
        /// </summary>
        public static Java.Net.CookiePolicy ACCEPT_NONE { get { if (!_ACCEPT_NONEReady) { _ACCEPT_NONEContent = SGetField<Java.Net.CookiePolicy>(LocalBridgeClazz, "ACCEPT_NONE"); _ACCEPT_NONEReady = true; } return _ACCEPT_NONEContent; } }
        private static Java.Net.CookiePolicy _ACCEPT_NONEContent = default;
        private static bool _ACCEPT_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookiePolicy.html#ACCEPT_ORIGINAL_SERVER"/>
        /// </summary>
        public static Java.Net.CookiePolicy ACCEPT_ORIGINAL_SERVER { get { if (!_ACCEPT_ORIGINAL_SERVERReady) { _ACCEPT_ORIGINAL_SERVERContent = SGetField<Java.Net.CookiePolicy>(LocalBridgeClazz, "ACCEPT_ORIGINAL_SERVER"); _ACCEPT_ORIGINAL_SERVERReady = true; } return _ACCEPT_ORIGINAL_SERVERContent; } }
        private static Java.Net.CookiePolicy _ACCEPT_ORIGINAL_SERVERContent = default;
        private static bool _ACCEPT_ORIGINAL_SERVERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookiePolicy.html#shouldAccept(java.net.URI,java.net.HttpCookie)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Net.HttpCookie"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldAccept(Java.Net.URI arg0, Java.Net.HttpCookie arg1)
        {
            return IExecute<bool>("shouldAccept", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}