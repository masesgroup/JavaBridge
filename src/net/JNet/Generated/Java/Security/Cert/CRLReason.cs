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

namespace Java.Security.Cert
{
    #region CRLReason
    public partial class CRLReason
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CRLReason.html#AA_COMPROMISE"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason AA_COMPROMISE { get { return SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "AA_COMPROMISE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CRLReason.html#AFFILIATION_CHANGED"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason AFFILIATION_CHANGED { get { return SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "AFFILIATION_CHANGED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CRLReason.html#CA_COMPROMISE"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason CA_COMPROMISE { get { return SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "CA_COMPROMISE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CRLReason.html#CERTIFICATE_HOLD"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason CERTIFICATE_HOLD { get { return SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "CERTIFICATE_HOLD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CRLReason.html#CESSATION_OF_OPERATION"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason CESSATION_OF_OPERATION { get { return SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "CESSATION_OF_OPERATION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CRLReason.html#KEY_COMPROMISE"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason KEY_COMPROMISE { get { return SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "KEY_COMPROMISE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CRLReason.html#PRIVILEGE_WITHDRAWN"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason PRIVILEGE_WITHDRAWN { get { return SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "PRIVILEGE_WITHDRAWN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CRLReason.html#REMOVE_FROM_CRL"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason REMOVE_FROM_CRL { get { return SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "REMOVE_FROM_CRL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CRLReason.html#SUPERSEDED"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason SUPERSEDED { get { return SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "SUPERSEDED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CRLReason.html#UNSPECIFIED"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason UNSPECIFIED { get { return SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "UNSPECIFIED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CRLReason.html#UNUSED"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason UNUSED { get { return SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "UNUSED"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CRLReason.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.Cert.CRLReason"/></returns>
        public static Java.Security.Cert.CRLReason ValueOf(string arg0)
        {
            return SExecute<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CRLReason.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Security.Cert.CRLReason"/></returns>
        public static Java.Security.Cert.CRLReason[] Values()
        {
            return SExecuteArray<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}