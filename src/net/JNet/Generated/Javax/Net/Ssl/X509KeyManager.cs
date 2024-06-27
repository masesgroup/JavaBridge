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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Net.Ssl
{
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