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

namespace Java.Security.Cert
{
    #region CertificateFactory
    public partial class CertificateFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactory.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Cert.CertificateFactory"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Java.Security.Cert.CertificateFactory GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Security.Cert.CertificateFactory>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactory.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Java.Security.Cert.CertificateFactory"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public static Java.Security.Cert.CertificateFactory GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecute<Java.Security.Cert.CertificateFactory>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactory.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Cert.CertificateFactory"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public static Java.Security.Cert.CertificateFactory GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Security.Cert.CertificateFactory>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertificateFactory;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactory.html#getCertPathEncodings()"/> 
        /// </summary>
        public Java.Util.Iterator<Java.Lang.String> CertPathEncodings
        {
            get { return IExecuteWithSignature<Java.Util.Iterator<Java.Lang.String>>("getCertPathEncodings", "()Ljava/util/Iterator;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactory.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactory.html#getType()"/> 
        /// </summary>
        public Java.Lang.String Type
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactory.html#generateCertificate(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Security.Cert.Certificate"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public Java.Security.Cert.Certificate GenerateCertificate(Java.Io.InputStream arg0)
        {
            return IExecuteWithSignature<Java.Security.Cert.Certificate>("generateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactory.html#generateCertPath(java.io.InputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Cert.CertPath"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public Java.Security.Cert.CertPath GenerateCertPath(Java.Io.InputStream arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Security.Cert.CertPath>("generateCertPath", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactory.html#generateCertPath(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Security.Cert.CertPath"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public Java.Security.Cert.CertPath GenerateCertPath(Java.Io.InputStream arg0)
        {
            return IExecuteWithSignature<Java.Security.Cert.CertPath>("generateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactory.html#generateCertPath(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <typeparam name="Arg0ExtendsJava_Security_Cert_Certificate"><see cref="Java.Security.Cert.Certificate"/></typeparam>
        /// <returns><see cref="Java.Security.Cert.CertPath"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public Java.Security.Cert.CertPath GenerateCertPath<Arg0ExtendsJava_Security_Cert_Certificate>(Java.Util.List<Arg0ExtendsJava_Security_Cert_Certificate> arg0) where Arg0ExtendsJava_Security_Cert_Certificate : Java.Security.Cert.Certificate
        {
            return IExecuteWithSignature<Java.Security.Cert.CertPath>("generateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactory.html#generateCRL(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Security.Cert.CRL"/></returns>
        /// <exception cref="Java.Security.Cert.CRLException"/>
        public Java.Security.Cert.CRL GenerateCRL(Java.Io.InputStream arg0)
        {
            return IExecuteWithSignature<Java.Security.Cert.CRL>("generateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactory.html#generateCertificates(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <typeparam name="ReturnExtendsJava_Security_Cert_Certificate"><see cref="Java.Security.Cert.Certificate"/></typeparam>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public Java.Util.Collection<ReturnExtendsJava_Security_Cert_Certificate> GenerateCertificates<ReturnExtendsJava_Security_Cert_Certificate>(Java.Io.InputStream arg0) where ReturnExtendsJava_Security_Cert_Certificate : Java.Security.Cert.Certificate
        {
            return IExecuteWithSignature<Java.Util.Collection<ReturnExtendsJava_Security_Cert_Certificate>>("generateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertificateFactory.html#generateCRLs(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <typeparam name="ReturnExtendsJava_Security_Cert_CRL"><see cref="Java.Security.Cert.CRL"/></typeparam>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Security.Cert.CRLException"/>
        public Java.Util.Collection<ReturnExtendsJava_Security_Cert_CRL> GenerateCRLs<ReturnExtendsJava_Security_Cert_CRL>(Java.Io.InputStream arg0) where ReturnExtendsJava_Security_Cert_CRL : Java.Security.Cert.CRL
        {
            return IExecuteWithSignature<Java.Util.Collection<ReturnExtendsJava_Security_Cert_CRL>>("generateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}