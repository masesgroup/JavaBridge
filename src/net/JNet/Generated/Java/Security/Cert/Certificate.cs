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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Cert
{
    #region Certificate
    public partial class Certificate
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/Certificate.html#getEncoded()"/> 
        /// </summary>
        public byte[] Encoded
        {
            get { return IExecuteWithSignatureArray<byte>("getEncoded", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/Certificate.html#getPublicKey()"/> 
        /// </summary>
        public Java.Security.PublicKey PublicKey
        {
            get { return IExecuteWithSignature<Java.Security.PublicKey>("getPublicKey", "()Ljava/security/PublicKey;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/Certificate.html#getType()"/> 
        /// </summary>
        public Java.Lang.String Type
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/Certificate.html#verify(java.security.PublicKey,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        /// <exception cref="Java.Security.SignatureException"/>
        public void Verify(Java.Security.PublicKey arg0, Java.Lang.String arg1)
        {
            IExecute("verify", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/Certificate.html#verify(java.security.PublicKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        /// <exception cref="Java.Security.SignatureException"/>
        public void Verify(Java.Security.PublicKey arg0)
        {
            IExecuteWithSignature("verify", "(Ljava/security/PublicKey;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/Certificate.html#verify(java.security.PublicKey,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.SignatureException"/>
        public void Verify(Java.Security.PublicKey arg0, Java.Security.Provider arg1)
        {
            IExecute("verify", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}