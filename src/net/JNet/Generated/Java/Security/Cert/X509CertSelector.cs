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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Cert
{
    #region X509CertSelector
    public partial class X509CertSelector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Cert.X509CertSelector"/> to <see cref="Java.Security.Cert.CertSelector"/>
        /// </summary>
        public static implicit operator Java.Security.Cert.CertSelector(Java.Security.Cert.X509CertSelector t) => t.Cast<Java.Security.Cert.CertSelector>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getAuthorityKeyIdentifier()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setAuthorityKeyIdentifier(byte[])"/>
        /// </summary>
        public byte[] AuthorityKeyIdentifier
        {
            get { return IExecuteArray<byte>("getAuthorityKeyIdentifier"); } set { IExecute("setAuthorityKeyIdentifier", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getBasicConstraints()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setBasicConstraints(int)"/>
        /// </summary>
        public int BasicConstraints
        {
            get { return IExecute<int>("getBasicConstraints"); } set { IExecute("setBasicConstraints", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getCertificate()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setCertificate(java.security.cert.X509Certificate)"/>
        /// </summary>
        public Java.Security.Cert.X509Certificate Certificate
        {
            get { return IExecute<Java.Security.Cert.X509Certificate>("getCertificate"); } set { IExecute("setCertificate", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getCertificateValid()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setCertificateValid(java.util.Date)"/>
        /// </summary>
        public Java.Util.Date CertificateValid
        {
            get { return IExecute<Java.Util.Date>("getCertificateValid"); } set { IExecute("setCertificateValid", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getExtendedKeyUsage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setExtendedKeyUsage(java.util.Set)"/>
        /// </summary>
        public Java.Util.Set<string> ExtendedKeyUsage
        {
            get { return IExecute<Java.Util.Set<string>>("getExtendedKeyUsage"); } set { IExecute("setExtendedKeyUsage", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getIssuer()"/> 
        /// </summary>
        public Javax.Security.Auth.X500.X500Principal Issuer
        {
            get { return IExecute<Javax.Security.Auth.X500.X500Principal>("getIssuer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getIssuerAsBytes()"/> 
        /// </summary>
        public byte[] IssuerAsBytes
        {
            get { return IExecuteArray<byte>("getIssuerAsBytes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getIssuerAsString()"/> 
        /// </summary>
        public string IssuerAsString
        {
            get { return IExecute<string>("getIssuerAsString"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getKeyUsage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setKeyUsage(boolean[])"/>
        /// </summary>
        public bool[] KeyUsage
        {
            get { return IExecuteArray<bool>("getKeyUsage"); } set { IExecute("setKeyUsage", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getMatchAllSubjectAltNames()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setMatchAllSubjectAltNames(boolean)"/>
        /// </summary>
        public bool MatchAllSubjectAltNames
        {
            get { return IExecute<bool>("getMatchAllSubjectAltNames"); } set { IExecute("setMatchAllSubjectAltNames", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getNameConstraints()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setNameConstraints(byte[])"/>
        /// </summary>
        public byte[] NameConstraints
        {
            get { return IExecuteArray<byte>("getNameConstraints"); } set { IExecute("setNameConstraints", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getPathToNames()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setPathToNames(java.util.Collection)"/>
        /// </summary>
        public Java.Util.Collection PathToNames
        {
            get { return IExecute<Java.Util.Collection>("getPathToNames"); } set { IExecute("setPathToNames", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getPolicy()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setPolicy(java.util.Set)"/>
        /// </summary>
        public Java.Util.Set<string> Policy
        {
            get { return IExecute<Java.Util.Set<string>>("getPolicy"); } set { IExecute("setPolicy", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getPrivateKeyValid()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setPrivateKeyValid(java.util.Date)"/>
        /// </summary>
        public Java.Util.Date PrivateKeyValid
        {
            get { return IExecute<Java.Util.Date>("getPrivateKeyValid"); } set { IExecute("setPrivateKeyValid", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSerialNumber()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSerialNumber(java.math.BigInteger)"/>
        /// </summary>
        public Java.Math.BigInteger SerialNumber
        {
            get { return IExecute<Java.Math.BigInteger>("getSerialNumber"); } set { IExecute("setSerialNumber", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubject()"/> 
        /// </summary>
        public Javax.Security.Auth.X500.X500Principal Subject
        {
            get { return IExecute<Javax.Security.Auth.X500.X500Principal>("getSubject"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectAlternativeNames()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubjectAlternativeNames(java.util.Collection)"/>
        /// </summary>
        public Java.Util.Collection SubjectAlternativeNames
        {
            get { return IExecute<Java.Util.Collection>("getSubjectAlternativeNames"); } set { IExecute("setSubjectAlternativeNames", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectAsBytes()"/> 
        /// </summary>
        public byte[] SubjectAsBytes
        {
            get { return IExecuteArray<byte>("getSubjectAsBytes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectAsString()"/> 
        /// </summary>
        public string SubjectAsString
        {
            get { return IExecute<string>("getSubjectAsString"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectKeyIdentifier()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubjectKeyIdentifier(byte[])"/>
        /// </summary>
        public byte[] SubjectKeyIdentifier
        {
            get { return IExecuteArray<byte>("getSubjectKeyIdentifier"); } set { IExecute("setSubjectKeyIdentifier", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectPublicKey()"/> 
        /// </summary>
        public Java.Security.PublicKey SubjectPublicKey
        {
            get { return IExecute<Java.Security.PublicKey>("getSubjectPublicKey"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectPublicKeyAlgID()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubjectPublicKeyAlgID(java.lang.String)"/>
        /// </summary>
        public string SubjectPublicKeyAlgID
        {
            get { return IExecute<string>("getSubjectPublicKeyAlgID"); } set { IExecute("setSubjectPublicKeyAlgID", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#match(java.security.cert.Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Match(Java.Security.Cert.Certificate arg0)
        {
            return IExecute<bool>("match", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#addPathToName(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddPathToName(int arg0, byte[] arg1)
        {
            IExecute("addPathToName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#addPathToName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddPathToName(int arg0, string arg1)
        {
            IExecute("addPathToName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#addSubjectAlternativeName(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddSubjectAlternativeName(int arg0, byte[] arg1)
        {
            IExecute("addSubjectAlternativeName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#addSubjectAlternativeName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddSubjectAlternativeName(int arg0, string arg1)
        {
            IExecute("addSubjectAlternativeName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setIssuer(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetIssuer(byte[] arg0)
        {
            IExecute("setIssuer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setIssuer(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetIssuer(string arg0)
        {
            IExecute("setIssuer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setIssuer(javax.security.auth.x500.X500Principal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.X500.X500Principal"/></param>
        public void SetIssuer(Javax.Security.Auth.X500.X500Principal arg0)
        {
            IExecute("setIssuer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubject(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetSubject(byte[] arg0)
        {
            IExecute("setSubject", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubject(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetSubject(string arg0)
        {
            IExecute("setSubject", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubject(javax.security.auth.x500.X500Principal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.X500.X500Principal"/></param>
        public void SetSubject(Javax.Security.Auth.X500.X500Principal arg0)
        {
            IExecute("setSubject", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubjectPublicKey(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetSubjectPublicKey(byte[] arg0)
        {
            IExecute("setSubjectPublicKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubjectPublicKey(java.security.PublicKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        public void SetSubjectPublicKey(Java.Security.PublicKey arg0)
        {
            IExecute("setSubjectPublicKey", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}