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

namespace Java.Security.Cert
{
    #region PKIXParameters definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html"/>
    /// </summary>
    public partial class PKIXParameters : Java.Security.Cert.CertPathParameters
    {
        const string _bridgeClassName = "java.security.cert.PKIXParameters";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PKIXParameters() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PKIXParameters(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region PKIXParameters
    public partial class PKIXParameters
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#%3Cinit%3E(java.security.KeyStore)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyStore"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public PKIXParameters(Java.Security.KeyStore arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#%3Cinit%3E(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public PKIXParameters(Java.Util.Set<Java.Security.Cert.TrustAnchor> arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getCertPathCheckers()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setCertPathCheckers(java.util.List)"/>
        /// </summary>
        public Java.Util.List<Java.Security.Cert.PKIXCertPathChecker> CertPathCheckers
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Security.Cert.PKIXCertPathChecker>>("getCertPathCheckers", "()Ljava/util/List;"); } set { IExecuteWithSignature("setCertPathCheckers", "(Ljava/util/List;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getCertStores()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setCertStores(java.util.List)"/>
        /// </summary>
        public Java.Util.List<Java.Security.Cert.CertStore> CertStores
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Security.Cert.CertStore>>("getCertStores", "()Ljava/util/List;"); } set { IExecuteWithSignature("setCertStores", "(Ljava/util/List;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getDate()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setDate(java.util.Date)"/>
        /// </summary>
        public Java.Util.Date Date
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getDate", "()Ljava/util/Date;"); } set { IExecuteWithSignature("setDate", "(Ljava/util/Date;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getInitialPolicies()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setInitialPolicies(java.util.Set)"/>
        /// </summary>
        public Java.Util.Set<Java.Lang.String> InitialPolicies
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getInitialPolicies", "()Ljava/util/Set;"); } set { IExecuteWithSignature("setInitialPolicies", "(Ljava/util/Set;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getPolicyQualifiersRejected()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setPolicyQualifiersRejected(boolean)"/>
        /// </summary>
        public bool PolicyQualifiersRejected
        {
            get { return IExecuteWithSignature<bool>("getPolicyQualifiersRejected", "()Z"); } set { IExecuteWithSignature("setPolicyQualifiersRejected", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getSigProvider()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setSigProvider(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String SigProvider
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSigProvider", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setSigProvider", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getTargetCertConstraints()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setTargetCertConstraints(java.security.cert.CertSelector)"/>
        /// </summary>
        public Java.Security.Cert.CertSelector TargetCertConstraints
        {
            get { return IExecuteWithSignature<Java.Security.Cert.CertSelector>("getTargetCertConstraints", "()Ljava/security/cert/CertSelector;"); } set { IExecuteWithSignature("setTargetCertConstraints", "(Ljava/security/cert/CertSelector;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getTrustAnchors()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setTrustAnchors(java.util.Set)"/>
        /// </summary>
        public Java.Util.Set<Java.Security.Cert.TrustAnchor> TrustAnchors
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Security.Cert.TrustAnchor>>("getTrustAnchors", "()Ljava/util/Set;"); } set { IExecuteWithSignature("setTrustAnchors", "(Ljava/util/Set;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#isAnyPolicyInhibited()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAnyPolicyInhibited()
        {
            return IExecuteWithSignature<bool>("isAnyPolicyInhibited", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#isExplicitPolicyRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsExplicitPolicyRequired()
        {
            return IExecuteWithSignature<bool>("isExplicitPolicyRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#isPolicyMappingInhibited()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPolicyMappingInhibited()
        {
            return IExecuteWithSignature<bool>("isPolicyMappingInhibited", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#isRevocationEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRevocationEnabled()
        {
            return IExecuteWithSignature<bool>("isRevocationEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#addCertPathChecker(java.security.cert.PKIXCertPathChecker)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.PKIXCertPathChecker"/></param>
        public void AddCertPathChecker(Java.Security.Cert.PKIXCertPathChecker arg0)
        {
            IExecuteWithSignature("addCertPathChecker", "(Ljava/security/cert/PKIXCertPathChecker;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#addCertStore(java.security.cert.CertStore)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CertStore"/></param>
        public void AddCertStore(Java.Security.Cert.CertStore arg0)
        {
            IExecuteWithSignature("addCertStore", "(Ljava/security/cert/CertStore;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setAnyPolicyInhibited(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAnyPolicyInhibited(bool arg0)
        {
            IExecuteWithSignature("setAnyPolicyInhibited", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setExplicitPolicyRequired(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetExplicitPolicyRequired(bool arg0)
        {
            IExecuteWithSignature("setExplicitPolicyRequired", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setPolicyMappingInhibited(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPolicyMappingInhibited(bool arg0)
        {
            IExecuteWithSignature("setPolicyMappingInhibited", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setRevocationEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRevocationEnabled(bool arg0)
        {
            IExecuteWithSignature("setRevocationEnabled", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}