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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Security.Auth.Kerberos
{
    #region KerberosKey
    public partial class KerberosKey
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosKey.html#%3Cinit%3E(javax.security.auth.kerberos.KerberosPrincipal,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Kerberos.KerberosPrincipal"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public KerberosKey(Javax.Security.Auth.Kerberos.KerberosPrincipal arg0, byte[] arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosKey.html#%3Cinit%3E(javax.security.auth.kerberos.KerberosPrincipal,char[],java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Kerberos.KerberosPrincipal"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public KerberosKey(Javax.Security.Auth.Kerberos.KerberosPrincipal arg0, char[] arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosKey.html#getAlgorithm()"/> 
        /// </summary>
        public Java.Lang.String Algorithm
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosKey.html#getEncoded()"/> 
        /// </summary>
        public byte[] Encoded
        {
            get { return IExecuteWithSignatureArray<byte>("getEncoded", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosKey.html#getFormat()"/> 
        /// </summary>
        public Java.Lang.String Format
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFormat", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosKey.html#getKeyType()"/> 
        /// </summary>
        public int KeyType
        {
            get { return IExecuteWithSignature<int>("getKeyType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosKey.html#getPrincipal()"/> 
        /// </summary>
        public Javax.Security.Auth.Kerberos.KerberosPrincipal Principal
        {
            get { return IExecuteWithSignature<Javax.Security.Auth.Kerberos.KerberosPrincipal>("getPrincipal", "()Ljavax/security/auth/kerberos/KerberosPrincipal;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosKey.html#getVersionNumber()"/> 
        /// </summary>
        public int VersionNumber
        {
            get { return IExecuteWithSignature<int>("getVersionNumber", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosKey.html#isDestroyed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDestroyed()
        {
            return IExecuteWithSignature<bool>("isDestroyed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosKey.html#destroy()"/>
        /// </summary>
        /// <exception cref="Javax.Security.Auth.DestroyFailedException"/>
        public void Destroy()
        {
            IExecuteWithSignature("destroy", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}