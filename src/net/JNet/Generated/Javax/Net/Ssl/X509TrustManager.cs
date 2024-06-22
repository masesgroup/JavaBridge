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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Net.Ssl
{
    #region IX509TrustManager
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IX509TrustManager : Javax.Net.Ssl.ITrustManager
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509TrustManager.html#getAcceptedIssuers()"/> 
        /// </summary>
        Java.Security.Cert.X509Certificate[] AcceptedIssuers { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509TrustManager.html#checkClientTrusted(java.security.cert.X509Certificate[],java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        void CheckClientTrusted(Java.Security.Cert.X509Certificate[] arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509TrustManager.html#checkServerTrusted(java.security.cert.X509Certificate[],java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        void CheckServerTrusted(Java.Security.Cert.X509Certificate[] arg0, Java.Lang.String arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region X509TrustManager
    public partial class X509TrustManager : Javax.Net.Ssl.IX509TrustManager
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509TrustManager.html#getAcceptedIssuers()"/> 
        /// </summary>
        public Java.Security.Cert.X509Certificate[] AcceptedIssuers
        {
            get { return IExecuteWithSignatureArray<Java.Security.Cert.X509Certificate>("getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509TrustManager.html#checkClientTrusted(java.security.cert.X509Certificate[],java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public void CheckClientTrusted(Java.Security.Cert.X509Certificate[] arg0, Java.Lang.String arg1)
        {
            IExecute("checkClientTrusted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509TrustManager.html#checkServerTrusted(java.security.cert.X509Certificate[],java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public void CheckServerTrusted(Java.Security.Cert.X509Certificate[] arg0, Java.Lang.String arg1)
        {
            IExecute("checkServerTrusted", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}