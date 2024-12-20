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

namespace Java.Security.Cert
{
    #region CertStoreSpi declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStoreSpi.html"/>
    /// </summary>
    public partial class CertStoreSpi : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CertStoreSpi>
    {
        const string _bridgeClassName = "java.security.cert.CertStoreSpi";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CertStoreSpi class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CertStoreSpi() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CertStoreSpi class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CertStoreSpi(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region CertStoreSpi implementation
    public partial class CertStoreSpi
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStoreSpi.html#%3Cinit%3E(java.security.cert.CertStoreParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CertStoreParameters"/></param>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public CertStoreSpi(Java.Security.Cert.CertStoreParameters arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStoreSpi.html#engineGetCertificates(java.security.cert.CertSelector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CertSelector"/></param>
        /// <typeparam name="ReturnExtendsJava_Security_Cert_Certificate"><see cref="Java.Security.Cert.Certificate"/></typeparam>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Security.Cert.CertStoreException"/>
        public Java.Util.Collection<ReturnExtendsJava_Security_Cert_Certificate> EngineGetCertificates<ReturnExtendsJava_Security_Cert_Certificate>(Java.Security.Cert.CertSelector arg0) where ReturnExtendsJava_Security_Cert_Certificate : Java.Security.Cert.Certificate
        {
            return IExecuteWithSignature<Java.Util.Collection<ReturnExtendsJava_Security_Cert_Certificate>>("engineGetCertificates", "(Ljava/security/cert/CertSelector;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStoreSpi.html#engineGetCRLs(java.security.cert.CRLSelector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CRLSelector"/></param>
        /// <typeparam name="ReturnExtendsJava_Security_Cert_CRL"><see cref="Java.Security.Cert.CRL"/></typeparam>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Security.Cert.CertStoreException"/>
        public Java.Util.Collection<ReturnExtendsJava_Security_Cert_CRL> EngineGetCRLs<ReturnExtendsJava_Security_Cert_CRL>(Java.Security.Cert.CRLSelector arg0) where ReturnExtendsJava_Security_Cert_CRL : Java.Security.Cert.CRL
        {
            return IExecuteWithSignature<Java.Util.Collection<ReturnExtendsJava_Security_Cert_CRL>>("engineGetCRLs", "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}