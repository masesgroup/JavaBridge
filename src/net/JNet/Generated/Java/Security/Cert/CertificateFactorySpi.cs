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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Cert
{
    #region CertificateFactorySpi
    public partial class CertificateFactorySpi
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactorySpi.html#engineGenerateCertificate(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Security.Cert.Certificate"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public Java.Security.Cert.Certificate EngineGenerateCertificate(Java.Io.InputStream arg0)
        {
            return IExecuteWithSignature<Java.Security.Cert.Certificate>("engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactorySpi.html#engineGenerateCRL(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Security.Cert.CRL"/></returns>
        /// <exception cref="Java.Security.Cert.CRLException"/>
        public Java.Security.Cert.CRL EngineGenerateCRL(Java.Io.InputStream arg0)
        {
            return IExecuteWithSignature<Java.Security.Cert.CRL>("engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactorySpi.html#engineGenerateCertificates(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <typeparam name="ReturnExtendsJava_Security_Cert_Certificate"><see cref="Java.Security.Cert.Certificate"/></typeparam>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public Java.Util.Collection<ReturnExtendsJava_Security_Cert_Certificate> EngineGenerateCertificates<ReturnExtendsJava_Security_Cert_Certificate>(Java.Io.InputStream arg0) where ReturnExtendsJava_Security_Cert_Certificate: Java.Security.Cert.Certificate
        {
            return IExecuteWithSignature<Java.Util.Collection<ReturnExtendsJava_Security_Cert_Certificate>>("engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactorySpi.html#engineGenerateCRLs(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <typeparam name="ReturnExtendsJava_Security_Cert_CRL"><see cref="Java.Security.Cert.CRL"/></typeparam>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Security.Cert.CRLException"/>
        public Java.Util.Collection<ReturnExtendsJava_Security_Cert_CRL> EngineGenerateCRLs<ReturnExtendsJava_Security_Cert_CRL>(Java.Io.InputStream arg0) where ReturnExtendsJava_Security_Cert_CRL: Java.Security.Cert.CRL
        {
            return IExecuteWithSignature<Java.Util.Collection<ReturnExtendsJava_Security_Cert_CRL>>("engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactorySpi.html#engineGenerateCertPath(java.io.InputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Cert.CertPath"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public Java.Security.Cert.CertPath EngineGenerateCertPath(Java.Io.InputStream arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Security.Cert.CertPath>("engineGenerateCertPath", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactorySpi.html#engineGenerateCertPath(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Security.Cert.CertPath"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public Java.Security.Cert.CertPath EngineGenerateCertPath(Java.Io.InputStream arg0)
        {
            return IExecuteWithSignature<Java.Security.Cert.CertPath>("engineGenerateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactorySpi.html#engineGenerateCertPath(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <typeparam name="Arg0ExtendsJava_Security_Cert_Certificate"><see cref="Java.Security.Cert.Certificate"/></typeparam>
        /// <returns><see cref="Java.Security.Cert.CertPath"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public Java.Security.Cert.CertPath EngineGenerateCertPath<Arg0ExtendsJava_Security_Cert_Certificate>(Java.Util.List<Arg0ExtendsJava_Security_Cert_Certificate> arg0) where Arg0ExtendsJava_Security_Cert_Certificate: Java.Security.Cert.Certificate
        {
            return IExecuteWithSignature<Java.Security.Cert.CertPath>("engineGenerateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactorySpi.html#engineGetCertPathEncodings()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<Java.Lang.String> EngineGetCertPathEncodings()
        {
            return IExecuteWithSignature<Java.Util.Iterator<Java.Lang.String>>("engineGetCertPathEncodings", "()Ljava/util/Iterator;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}