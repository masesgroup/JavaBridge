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

namespace Javax.Net.Ssl
{
    #region X509ExtendedTrustManager
    public partial class X509ExtendedTrustManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Net.Ssl.X509ExtendedTrustManager"/> to <see cref="Javax.Net.Ssl.X509TrustManager"/>
        /// </summary>
        public static implicit operator Javax.Net.Ssl.X509TrustManager(Javax.Net.Ssl.X509ExtendedTrustManager t) => t.Cast<Javax.Net.Ssl.X509TrustManager>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509ExtendedTrustManager.html#checkClientTrusted(java.security.cert.X509Certificate[],java.lang.String,java.net.Socket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Net.Socket"/></param>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public void CheckClientTrusted(Java.Security.Cert.X509Certificate[] arg0, string arg1, Java.Net.Socket arg2)
        {
            IExecute("checkClientTrusted", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509ExtendedTrustManager.html#checkClientTrusted(java.security.cert.X509Certificate[],java.lang.String,javax.net.ssl.SSLEngine)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Net.Ssl.SSLEngine"/></param>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public void CheckClientTrusted(Java.Security.Cert.X509Certificate[] arg0, string arg1, Javax.Net.Ssl.SSLEngine arg2)
        {
            IExecute("checkClientTrusted", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509ExtendedTrustManager.html#checkServerTrusted(java.security.cert.X509Certificate[],java.lang.String,java.net.Socket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Net.Socket"/></param>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public void CheckServerTrusted(Java.Security.Cert.X509Certificate[] arg0, string arg1, Java.Net.Socket arg2)
        {
            IExecute("checkServerTrusted", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/X509ExtendedTrustManager.html#checkServerTrusted(java.security.cert.X509Certificate[],java.lang.String,javax.net.ssl.SSLEngine)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Net.Ssl.SSLEngine"/></param>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public void CheckServerTrusted(Java.Security.Cert.X509Certificate[] arg0, string arg1, Javax.Net.Ssl.SSLEngine arg2)
        {
            IExecute("checkServerTrusted", arg0, arg1, arg2);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}