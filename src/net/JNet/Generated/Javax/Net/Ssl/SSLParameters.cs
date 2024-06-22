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
    #region SSLParameters
    public partial class SSLParameters
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#%3Cinit%3E(java.lang.String[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public SSLParameters(Java.Lang.String[] arg0, Java.Lang.String[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#%3Cinit%3E(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public SSLParameters(Java.Lang.String[] arg0)
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
            get { return IExecuteWithSignature<Java.Security.AlgorithmConstraints>("getAlgorithmConstraints", "()Ljava/security/AlgorithmConstraints;"); } set { IExecuteWithSignature("setAlgorithmConstraints", "(Ljava/security/AlgorithmConstraints;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getApplicationProtocols()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setApplicationProtocols(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] ApplicationProtocols
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getApplicationProtocols", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setApplicationProtocols", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getCipherSuites()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setCipherSuites(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] CipherSuites
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getCipherSuites", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setCipherSuites", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getEnableRetransmissions()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setEnableRetransmissions(boolean)"/>
        /// </summary>
        public bool EnableRetransmissions
        {
            get { return IExecuteWithSignature<bool>("getEnableRetransmissions", "()Z"); } set { IExecuteWithSignature("setEnableRetransmissions", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getEndpointIdentificationAlgorithm()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setEndpointIdentificationAlgorithm(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String EndpointIdentificationAlgorithm
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getEndpointIdentificationAlgorithm", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setEndpointIdentificationAlgorithm", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getMaximumPacketSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setMaximumPacketSize(int)"/>
        /// </summary>
        public int MaximumPacketSize
        {
            get { return IExecuteWithSignature<int>("getMaximumPacketSize", "()I"); } set { IExecuteWithSignature("setMaximumPacketSize", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getNeedClientAuth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setNeedClientAuth(boolean)"/>
        /// </summary>
        public bool NeedClientAuth
        {
            get { return IExecuteWithSignature<bool>("getNeedClientAuth", "()Z"); } set { IExecuteWithSignature("setNeedClientAuth", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getProtocols()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setProtocols(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] Protocols
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getProtocols", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setProtocols", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getServerNames()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setServerNames(java.util.List)"/>
        /// </summary>
        public Java.Util.List<Javax.Net.Ssl.SNIServerName> ServerNames
        {
            get { return IExecuteWithSignature<Java.Util.List<Javax.Net.Ssl.SNIServerName>>("getServerNames", "()Ljava/util/List;"); } set { IExecuteWithSignature("setServerNames", "(Ljava/util/List;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getSNIMatchers()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setSNIMatchers(java.util.Collection)"/>
        /// </summary>
        public Java.Util.Collection<Javax.Net.Ssl.SNIMatcher> SNIMatchers
        {
            get { return IExecuteWithSignature<Java.Util.Collection<Javax.Net.Ssl.SNIMatcher>>("getSNIMatchers", "()Ljava/util/Collection;"); } set { IExecuteWithSignature("setSNIMatchers", "(Ljava/util/Collection;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getUseCipherSuitesOrder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setUseCipherSuitesOrder(boolean)"/>
        /// </summary>
        public bool UseCipherSuitesOrder
        {
            get { return IExecuteWithSignature<bool>("getUseCipherSuitesOrder", "()Z"); } set { IExecuteWithSignature("setUseCipherSuitesOrder", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#getWantClientAuth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLParameters.html#setWantClientAuth(boolean)"/>
        /// </summary>
        public bool WantClientAuth
        {
            get { return IExecuteWithSignature<bool>("getWantClientAuth", "()Z"); } set { IExecuteWithSignature("setWantClientAuth", "(Z)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}