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

namespace Java.Security
{
    #region KeyStoreSpi definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html"/>
    /// </summary>
    public partial class KeyStoreSpi : MASES.JCOBridge.C2JBridge.JVMBridgeBase<KeyStoreSpi>
    {
        const string _bridgeClassName = "java.security.KeyStoreSpi";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("KeyStoreSpi class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public KeyStoreSpi() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("KeyStoreSpi class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public KeyStoreSpi(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region KeyStoreSpi
    public partial class KeyStoreSpi
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineContainsAlias(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool EngineContainsAlias(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("engineContainsAlias", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineIsCertificateEntry(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool EngineIsCertificateEntry(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("engineIsCertificateEntry", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineIsKeyEntry(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool EngineIsKeyEntry(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("engineIsKeyEntry", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int EngineSize()
        {
            return IExecuteWithSignature<int>("engineSize", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineGetCertificateAlias(java.security.cert.Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String EngineGetCertificateAlias(Java.Security.Cert.Certificate arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("engineGetCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineGetCertificate(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Cert.Certificate"/></returns>
        public Java.Security.Cert.Certificate EngineGetCertificate(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Security.Cert.Certificate>("engineGetCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineGetCertificateChain(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Cert.Certificate"/></returns>
        public Java.Security.Cert.Certificate[] EngineGetCertificateChain(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Java.Security.Cert.Certificate>("engineGetCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineGetKey(java.lang.String,char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <returns><see cref="Java.Security.Key"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.UnrecoverableKeyException"/>
        public Java.Security.Key EngineGetKey(Java.Lang.String arg0, char[] arg1)
        {
            return IExecute<Java.Security.Key>("engineGetKey", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineGetCreationDate(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date EngineGetCreationDate(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Date>("engineGetCreationDate", "(Ljava/lang/String;)Ljava/util/Date;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineAliases()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Java.Lang.String> EngineAliases()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Java.Lang.String>>("engineAliases", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineDeleteEntry(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        public void EngineDeleteEntry(Java.Lang.String arg0)
        {
            IExecuteWithSignature("engineDeleteEntry", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineLoad(java.io.InputStream,char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public void EngineLoad(Java.Io.InputStream arg0, char[] arg1)
        {
            IExecute("engineLoad", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineSetCertificateEntry(java.lang.String,java.security.cert.Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        public void EngineSetCertificateEntry(Java.Lang.String arg0, Java.Security.Cert.Certificate arg1)
        {
            IExecute("engineSetCertificateEntry", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineSetKeyEntry(java.lang.String,byte[],java.security.cert.Certificate[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        public void EngineSetKeyEntry(Java.Lang.String arg0, byte[] arg1, Java.Security.Cert.Certificate[] arg2)
        {
            IExecute("engineSetKeyEntry", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineSetKeyEntry(java.lang.String,java.security.Key,char[],java.security.cert.Certificate[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <param name="arg2"><see cref="char"/></param>
        /// <param name="arg3"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        public void EngineSetKeyEntry(Java.Lang.String arg0, Java.Security.Key arg1, char[] arg2, Java.Security.Cert.Certificate[] arg3)
        {
            IExecute("engineSetKeyEntry", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineStore(java.io.OutputStream,char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public void EngineStore(Java.Io.OutputStream arg0, char[] arg1)
        {
            IExecute("engineStore", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineEntryInstanceOf(java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool EngineEntryInstanceOf(Java.Lang.String arg0, Java.Lang.Class arg1)
        {
            return IExecute<bool>("engineEntryInstanceOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineProbe(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool EngineProbe(Java.Io.InputStream arg0)
        {
            return IExecuteWithSignature<bool>("engineProbe", "(Ljava/io/InputStream;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineGetEntry(java.lang.String,java.security.KeyStore.ProtectionParameter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.KeyStore.ProtectionParameter"/></param>
        /// <returns><see cref="Java.Security.KeyStore.Entry"/></returns>
        /// <exception cref="Java.Security.KeyStoreException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.UnrecoverableEntryException"/>
        public Java.Security.KeyStore.Entry EngineGetEntry(Java.Lang.String arg0, Java.Security.KeyStore.ProtectionParameter arg1)
        {
            return IExecute<Java.Security.KeyStore.Entry>("engineGetEntry", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineLoad(java.security.KeyStore.LoadStoreParameter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyStore.LoadStoreParameter"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public void EngineLoad(Java.Security.KeyStore.LoadStoreParameter arg0)
        {
            IExecuteWithSignature("engineLoad", "(Ljava/security/KeyStore$LoadStoreParameter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineSetEntry(java.lang.String,java.security.KeyStore.Entry,java.security.KeyStore.ProtectionParameter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.KeyStore.Entry"/></param>
        /// <param name="arg2"><see cref="Java.Security.KeyStore.ProtectionParameter"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        public void EngineSetEntry(Java.Lang.String arg0, Java.Security.KeyStore.Entry arg1, Java.Security.KeyStore.ProtectionParameter arg2)
        {
            IExecute("engineSetEntry", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineStore(java.security.KeyStore.LoadStoreParameter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyStore.LoadStoreParameter"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public void EngineStore(Java.Security.KeyStore.LoadStoreParameter arg0)
        {
            IExecuteWithSignature("engineStore", "(Ljava/security/KeyStore$LoadStoreParameter;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}