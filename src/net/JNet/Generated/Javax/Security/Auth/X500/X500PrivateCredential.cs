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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Security.Auth.X500
{
    #region X500PrivateCredential
    public partial class X500PrivateCredential
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/x500/X500PrivateCredential.html#%3Cinit%3E(java.security.cert.X509Certificate,java.security.PrivateKey,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <param name="arg1"><see cref="Java.Security.PrivateKey"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public X500PrivateCredential(Java.Security.Cert.X509Certificate arg0, Java.Security.PrivateKey arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/x500/X500PrivateCredential.html#%3Cinit%3E(java.security.cert.X509Certificate,java.security.PrivateKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <param name="arg1"><see cref="Java.Security.PrivateKey"/></param>
        public X500PrivateCredential(Java.Security.Cert.X509Certificate arg0, Java.Security.PrivateKey arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/x500/X500PrivateCredential.html#getAlias()"/> 
        /// </summary>
        public Java.Lang.String Alias
        {
            get { return IExecute<Java.Lang.String>("getAlias"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/x500/X500PrivateCredential.html#getCertificate()"/> 
        /// </summary>
        public Java.Security.Cert.X509Certificate Certificate
        {
            get { return IExecute<Java.Security.Cert.X509Certificate>("getCertificate"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/x500/X500PrivateCredential.html#getPrivateKey()"/> 
        /// </summary>
        public Java.Security.PrivateKey PrivateKey
        {
            get { return IExecute<Java.Security.PrivateKey>("getPrivateKey"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/x500/X500PrivateCredential.html#isDestroyed()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDestroyed()
        {
            return IExecute<bool>("isDestroyed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/x500/X500PrivateCredential.html#destroy()"/>
        /// </summary>
        public void Destroy()
        {
            IExecute("destroy");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}