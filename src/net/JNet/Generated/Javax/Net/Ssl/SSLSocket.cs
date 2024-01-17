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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Net.Ssl
{
    #region SSLSocket
    public partial class SSLSocket
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getApplicationProtocol()"/> 
        /// </summary>
        public string ApplicationProtocol
        {
            get { return IExecute<string>("getApplicationProtocol"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getEnabledCipherSuites()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setEnabledCipherSuites(java.lang.String[])"/>
        /// </summary>
        public string[] EnabledCipherSuites
        {
            get { return IExecuteArray<string>("getEnabledCipherSuites"); } set { IExecute("setEnabledCipherSuites", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getEnabledProtocols()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setEnabledProtocols(java.lang.String[])"/>
        /// </summary>
        public string[] EnabledProtocols
        {
            get { return IExecuteArray<string>("getEnabledProtocols"); } set { IExecute("setEnabledProtocols", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getEnableSessionCreation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setEnableSessionCreation(boolean)"/>
        /// </summary>
        public bool EnableSessionCreation
        {
            get { return IExecute<bool>("getEnableSessionCreation"); } set { IExecute("setEnableSessionCreation", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getHandshakeApplicationProtocol()"/> 
        /// </summary>
        public string HandshakeApplicationProtocol
        {
            get { return IExecute<string>("getHandshakeApplicationProtocol"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getHandshakeApplicationProtocolSelector()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setHandshakeApplicationProtocolSelector(java.util.function.BiFunction)"/>
        /// </summary>
        public Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLSocket, Java.Util.List<string>, string> HandshakeApplicationProtocolSelector
        {
            get { return IExecute<Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLSocket, Java.Util.List<string>, string>>("getHandshakeApplicationProtocolSelector"); } set { IExecute("setHandshakeApplicationProtocolSelector", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getHandshakeSession()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLSession HandshakeSession
        {
            get { return IExecute<Javax.Net.Ssl.SSLSession>("getHandshakeSession"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getNeedClientAuth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setNeedClientAuth(boolean)"/>
        /// </summary>
        public bool NeedClientAuth
        {
            get { return IExecute<bool>("getNeedClientAuth"); } set { IExecute("setNeedClientAuth", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getSession()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLSession Session
        {
            get { return IExecute<Javax.Net.Ssl.SSLSession>("getSession"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getSSLParameters()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setSSLParameters(javax.net.ssl.SSLParameters)"/>
        /// </summary>
        public Javax.Net.Ssl.SSLParameters SSLParameters
        {
            get { return IExecute<Javax.Net.Ssl.SSLParameters>("getSSLParameters"); } set { IExecute("setSSLParameters", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getSupportedCipherSuites()"/> 
        /// </summary>
        public string[] SupportedCipherSuites
        {
            get { return IExecuteArray<string>("getSupportedCipherSuites"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getSupportedProtocols()"/> 
        /// </summary>
        public string[] SupportedProtocols
        {
            get { return IExecuteArray<string>("getSupportedProtocols"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getUseClientMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setUseClientMode(boolean)"/>
        /// </summary>
        public bool UseClientMode
        {
            get { return IExecute<bool>("getUseClientMode"); } set { IExecute("setUseClientMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getWantClientAuth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setWantClientAuth(boolean)"/>
        /// </summary>
        public bool WantClientAuth
        {
            get { return IExecute<bool>("getWantClientAuth"); } set { IExecute("setWantClientAuth", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#addHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HandshakeCompletedListener"/></param>
        public void AddHandshakeCompletedListener(Javax.Net.Ssl.HandshakeCompletedListener arg0)
        {
            IExecute("addHandshakeCompletedListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#removeHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HandshakeCompletedListener"/></param>
        public void RemoveHandshakeCompletedListener(Javax.Net.Ssl.HandshakeCompletedListener arg0)
        {
            IExecute("removeHandshakeCompletedListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#startHandshake()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void StartHandshake()
        {
            IExecute("startHandshake");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}