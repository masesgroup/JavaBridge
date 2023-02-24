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

namespace Java.Security.Cert
{
    #region X509CRLSelector
    public partial class X509CRLSelector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Cert.X509CRLSelector"/> to <see cref="Java.Security.Cert.CRLSelector"/>
        /// </summary>
        public static implicit operator Java.Security.Cert.CRLSelector(Java.Security.Cert.X509CRLSelector t) => t.Cast<Java.Security.Cert.CRLSelector>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#getCertificateChecking()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#setCertificateChecking(java.security.cert.X509Certificate)"/>
        /// </summary>
        public Java.Security.Cert.X509Certificate CertificateChecking
        {
            get { return IExecute<Java.Security.Cert.X509Certificate>("getCertificateChecking"); } set { IExecute("setCertificateChecking", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#getDateAndTime()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#setDateAndTime(java.util.Date)"/>
        /// </summary>
        public Java.Util.Date DateAndTime
        {
            get { return IExecute<Java.Util.Date>("getDateAndTime"); } set { IExecute("setDateAndTime", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#getMaxCRL()"/> 
        /// </summary>
        public Java.Math.BigInteger MaxCRL
        {
            get { return IExecute<Java.Math.BigInteger>("getMaxCRL"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#getMinCRL()"/> 
        /// </summary>
        public Java.Math.BigInteger MinCRL
        {
            get { return IExecute<Java.Math.BigInteger>("getMinCRL"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#match(java.security.cert.CRL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CRL"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Match(Java.Security.Cert.CRL arg0)
        {
            return IExecute<bool>("match", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#addIssuer(javax.security.auth.x500.X500Principal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.X500.X500Principal"/></param>
        public void AddIssuer(Javax.Security.Auth.X500.X500Principal arg0)
        {
            IExecute("addIssuer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#addIssuerName(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddIssuerName(byte[] arg0)
        {
            IExecute("addIssuerName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#addIssuerName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddIssuerName(string arg0)
        {
            IExecute("addIssuerName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#setMaxCRLNumber(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        public void SetMaxCRLNumber(Java.Math.BigInteger arg0)
        {
            IExecute("setMaxCRLNumber", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#setMinCRLNumber(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        public void SetMinCRLNumber(Java.Math.BigInteger arg0)
        {
            IExecute("setMinCRLNumber", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}