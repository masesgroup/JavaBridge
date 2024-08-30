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

namespace Javax.Net.Ssl
{
    #region X509KeyManager definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509KeyManager.html"/>
    /// </summary>
    public partial class X509KeyManager : Javax.Net.Ssl.KeyManager
    {
        const string _bridgeClassName = "javax.net.ssl.X509KeyManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("X509KeyManager class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public X509KeyManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("X509KeyManager class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public X509KeyManager(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IX509KeyManager
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IX509KeyManager : Javax.Net.Ssl.IKeyManager
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509KeyManager.html#chooseClientAlias(java.lang.String[],java.security.Principal[],java.net.Socket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Principal"/></param>
        /// <param name="arg2"><see cref="Java.Net.Socket"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String ChooseClientAlias(Java.Lang.String[] arg0, Java.Security.Principal[] arg1, Java.Net.Socket arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509KeyManager.html#chooseServerAlias(java.lang.String,java.security.Principal[],java.net.Socket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Principal"/></param>
        /// <param name="arg2"><see cref="Java.Net.Socket"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String ChooseServerAlias(Java.Lang.String arg0, Java.Security.Principal[] arg1, Java.Net.Socket arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509KeyManager.html#getClientAliases(java.lang.String,java.security.Principal[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Principal"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String[] GetClientAliases(Java.Lang.String arg0, Java.Security.Principal[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509KeyManager.html#getServerAliases(java.lang.String,java.security.Principal[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Principal"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String[] GetServerAliases(Java.Lang.String arg0, Java.Security.Principal[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509KeyManager.html#getCertificateChain(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Cert.X509Certificate"/></returns>
        Java.Security.Cert.X509Certificate[] GetCertificateChain(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509KeyManager.html#getPrivateKey(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.PrivateKey"/></returns>
        Java.Security.PrivateKey GetPrivateKey(Java.Lang.String arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region X509KeyManager
    public partial class X509KeyManager : Javax.Net.Ssl.IX509KeyManager
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509KeyManager.html#chooseClientAlias(java.lang.String[],java.security.Principal[],java.net.Socket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Principal"/></param>
        /// <param name="arg2"><see cref="Java.Net.Socket"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ChooseClientAlias(Java.Lang.String[] arg0, Java.Security.Principal[] arg1, Java.Net.Socket arg2)
        {
            return IExecute<Java.Lang.String>("chooseClientAlias", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509KeyManager.html#chooseServerAlias(java.lang.String,java.security.Principal[],java.net.Socket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Principal"/></param>
        /// <param name="arg2"><see cref="Java.Net.Socket"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ChooseServerAlias(Java.Lang.String arg0, Java.Security.Principal[] arg1, Java.Net.Socket arg2)
        {
            return IExecute<Java.Lang.String>("chooseServerAlias", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509KeyManager.html#getClientAliases(java.lang.String,java.security.Principal[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Principal"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetClientAliases(Java.Lang.String arg0, Java.Security.Principal[] arg1)
        {
            return IExecuteArray<Java.Lang.String>("getClientAliases", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509KeyManager.html#getServerAliases(java.lang.String,java.security.Principal[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Principal"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetServerAliases(Java.Lang.String arg0, Java.Security.Principal[] arg1)
        {
            return IExecuteArray<Java.Lang.String>("getServerAliases", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509KeyManager.html#getCertificateChain(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Cert.X509Certificate"/></returns>
        public Java.Security.Cert.X509Certificate[] GetCertificateChain(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Java.Security.Cert.X509Certificate>("getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509KeyManager.html#getPrivateKey(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.PrivateKey"/></returns>
        public Java.Security.PrivateKey GetPrivateKey(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Security.PrivateKey>("getPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}