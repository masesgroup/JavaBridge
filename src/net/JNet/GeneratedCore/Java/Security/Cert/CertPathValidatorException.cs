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
    #region CertPathValidatorException definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.html"/>
    /// </summary>
    public partial class CertPathValidatorException : Java.Security.GeneralSecurityException
    {
        const string _bridgeClassName = "java.security.cert.CertPathValidatorException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class
        #region BasicReason definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html"/>
        /// </summary>
        public partial class BasicReason : Java.Lang.Enum<Java.Security.Cert.CertPathValidatorException.BasicReason>
        {
            const string _bridgeClassName = "java.security.cert.CertPathValidatorException$BasicReason";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public BasicReason() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public BasicReason(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region Reason definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.Reason.html"/>
        /// </summary>
        public partial class Reason : Java.Io.Serializable
        {
            const string _bridgeClassName = "java.security.cert.CertPathValidatorException$Reason";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("Reason class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Reason() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("Reason class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Reason(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region CertPathValidatorException
    public partial class CertPathValidatorException
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

        #endregion

        #region Nested classes
        #region BasicReason
        public partial class BasicReason
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#ALGORITHM_CONSTRAINED"/>
            /// </summary>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason ALGORITHM_CONSTRAINED { get { if (!_ALGORITHM_CONSTRAINEDReady) { _ALGORITHM_CONSTRAINEDContent = SGetField<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "ALGORITHM_CONSTRAINED"); _ALGORITHM_CONSTRAINEDReady = true; } return _ALGORITHM_CONSTRAINEDContent; } }
            private static Java.Security.Cert.CertPathValidatorException.BasicReason _ALGORITHM_CONSTRAINEDContent = default;
            private static bool _ALGORITHM_CONSTRAINEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#EXPIRED"/>
            /// </summary>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason EXPIRED { get { if (!_EXPIREDReady) { _EXPIREDContent = SGetField<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "EXPIRED"); _EXPIREDReady = true; } return _EXPIREDContent; } }
            private static Java.Security.Cert.CertPathValidatorException.BasicReason _EXPIREDContent = default;
            private static bool _EXPIREDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#INVALID_SIGNATURE"/>
            /// </summary>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason INVALID_SIGNATURE { get { if (!_INVALID_SIGNATUREReady) { _INVALID_SIGNATUREContent = SGetField<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "INVALID_SIGNATURE"); _INVALID_SIGNATUREReady = true; } return _INVALID_SIGNATUREContent; } }
            private static Java.Security.Cert.CertPathValidatorException.BasicReason _INVALID_SIGNATUREContent = default;
            private static bool _INVALID_SIGNATUREReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#NOT_YET_VALID"/>
            /// </summary>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason NOT_YET_VALID { get { if (!_NOT_YET_VALIDReady) { _NOT_YET_VALIDContent = SGetField<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "NOT_YET_VALID"); _NOT_YET_VALIDReady = true; } return _NOT_YET_VALIDContent; } }
            private static Java.Security.Cert.CertPathValidatorException.BasicReason _NOT_YET_VALIDContent = default;
            private static bool _NOT_YET_VALIDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#REVOKED"/>
            /// </summary>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason REVOKED { get { if (!_REVOKEDReady) { _REVOKEDContent = SGetField<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "REVOKED"); _REVOKEDReady = true; } return _REVOKEDContent; } }
            private static Java.Security.Cert.CertPathValidatorException.BasicReason _REVOKEDContent = default;
            private static bool _REVOKEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#UNDETERMINED_REVOCATION_STATUS"/>
            /// </summary>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason UNDETERMINED_REVOCATION_STATUS { get { if (!_UNDETERMINED_REVOCATION_STATUSReady) { _UNDETERMINED_REVOCATION_STATUSContent = SGetField<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "UNDETERMINED_REVOCATION_STATUS"); _UNDETERMINED_REVOCATION_STATUSReady = true; } return _UNDETERMINED_REVOCATION_STATUSContent; } }
            private static Java.Security.Cert.CertPathValidatorException.BasicReason _UNDETERMINED_REVOCATION_STATUSContent = default;
            private static bool _UNDETERMINED_REVOCATION_STATUSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#UNSPECIFIED"/>
            /// </summary>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason UNSPECIFIED { get { if (!_UNSPECIFIEDReady) { _UNSPECIFIEDContent = SGetField<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "UNSPECIFIED"); _UNSPECIFIEDReady = true; } return _UNSPECIFIEDContent; } }
            private static Java.Security.Cert.CertPathValidatorException.BasicReason _UNSPECIFIEDContent = default;
            private static bool _UNSPECIFIEDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Security.Cert.CertPathValidatorException.BasicReason"/></returns>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/security/cert/CertPathValidatorException$BasicReason;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Security.Cert.CertPathValidatorException.BasicReason"/></returns>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason[] Values()
            {
                return SExecuteWithSignatureArray<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "values", "()[Ljava/security/cert/CertPathValidatorException$BasicReason;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Reason
        public partial class Reason
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}