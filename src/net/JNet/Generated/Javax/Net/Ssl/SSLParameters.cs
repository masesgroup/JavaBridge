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
    #region SSLParameters
    public partial class SSLParameters
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#%3Cinit%3E(java.lang.String[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public SSLParameters(string[] arg0, string[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#%3Cinit%3E(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public SSLParameters(string[] arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getAlgorithmConstraints()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setAlgorithmConstraints(java.security.AlgorithmConstraints)"/>
        /// </summary>
        public Java.Security.AlgorithmConstraints AlgorithmConstraints
        {
            get { return IExecute<Java.Security.AlgorithmConstraints>("getAlgorithmConstraints"); } set { IExecute("setAlgorithmConstraints", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getApplicationProtocols()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setApplicationProtocols(java.lang.String[])"/>
        /// </summary>
        public string[] ApplicationProtocols
        {
            get { return IExecuteArray<string>("getApplicationProtocols"); } set { IExecute("setApplicationProtocols", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getCipherSuites()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setCipherSuites(java.lang.String[])"/>
        /// </summary>
        public string[] CipherSuites
        {
            get { return IExecuteArray<string>("getCipherSuites"); } set { IExecute("setCipherSuites", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getEnableRetransmissions()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setEnableRetransmissions(boolean)"/>
        /// </summary>
        public bool EnableRetransmissions
        {
            get { return IExecute<bool>("getEnableRetransmissions"); } set { IExecute("setEnableRetransmissions", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getEndpointIdentificationAlgorithm()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setEndpointIdentificationAlgorithm(java.lang.String)"/>
        /// </summary>
        public string EndpointIdentificationAlgorithm
        {
            get { return IExecute<string>("getEndpointIdentificationAlgorithm"); } set { IExecute("setEndpointIdentificationAlgorithm", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getMaximumPacketSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setMaximumPacketSize(int)"/>
        /// </summary>
        public int MaximumPacketSize
        {
            get { return IExecute<int>("getMaximumPacketSize"); } set { IExecute("setMaximumPacketSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getNeedClientAuth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setNeedClientAuth(boolean)"/>
        /// </summary>
        public bool NeedClientAuth
        {
            get { return IExecute<bool>("getNeedClientAuth"); } set { IExecute("setNeedClientAuth", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getProtocols()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setProtocols(java.lang.String[])"/>
        /// </summary>
        public string[] Protocols
        {
            get { return IExecuteArray<string>("getProtocols"); } set { IExecute("setProtocols", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getServerNames()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setServerNames(java.util.List)"/>
        /// </summary>
        public Java.Util.List<Javax.Net.Ssl.SNIServerName> ServerNames
        {
            get { return IExecute<Java.Util.List<Javax.Net.Ssl.SNIServerName>>("getServerNames"); } set { IExecute("setServerNames", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getSNIMatchers()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setSNIMatchers(java.util.Collection)"/>
        /// </summary>
        public Java.Util.Collection<Javax.Net.Ssl.SNIMatcher> SNIMatchers
        {
            get { return IExecute<Java.Util.Collection<Javax.Net.Ssl.SNIMatcher>>("getSNIMatchers"); } set { IExecute("setSNIMatchers", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getUseCipherSuitesOrder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setUseCipherSuitesOrder(boolean)"/>
        /// </summary>
        public bool UseCipherSuitesOrder
        {
            get { return IExecute<bool>("getUseCipherSuitesOrder"); } set { IExecute("setUseCipherSuitesOrder", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getWantClientAuth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setWantClientAuth(boolean)"/>
        /// </summary>
        public bool WantClientAuth
        {
            get { return IExecute<bool>("getWantClientAuth"); } set { IExecute("setWantClientAuth", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}