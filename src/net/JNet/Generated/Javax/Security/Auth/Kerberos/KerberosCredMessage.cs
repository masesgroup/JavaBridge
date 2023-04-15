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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Security.Auth.Kerberos
{
    #region KerberosCredMessage
    public partial class KerberosCredMessage
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosCredMessage.html#%3Cinit%3E(javax.security.auth.kerberos.KerberosPrincipal,javax.security.auth.kerberos.KerberosPrincipal,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Kerberos.KerberosPrincipal"/></param>
        /// <param name="arg1"><see cref="Javax.Security.Auth.Kerberos.KerberosPrincipal"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        public KerberosCredMessage(Javax.Security.Auth.Kerberos.KerberosPrincipal arg0, Javax.Security.Auth.Kerberos.KerberosPrincipal arg1, byte[] arg2)
            : base(arg0, arg1, arg2)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Kerberos.KerberosCredMessage"/> to <see cref="Javax.Security.Auth.Destroyable"/>
        /// </summary>
        public static implicit operator Javax.Security.Auth.Destroyable(Javax.Security.Auth.Kerberos.KerberosCredMessage t) => t.Cast<Javax.Security.Auth.Destroyable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosCredMessage.html#getEncoded()"/> 
        /// </summary>
        public byte[] Encoded
        {
            get { return IExecuteArray<byte>("getEncoded"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosCredMessage.html#isDestroyed()"/> 
        /// </summary>
        public bool IsDestroyed
        {
            get { return IExecute<bool>("isDestroyed"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosCredMessage.html#getRecipient()"/> 
        /// </summary>
        public Javax.Security.Auth.Kerberos.KerberosPrincipal Recipient
        {
            get { return IExecute<Javax.Security.Auth.Kerberos.KerberosPrincipal>("getRecipient"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosCredMessage.html#getSender()"/> 
        /// </summary>
        public Javax.Security.Auth.Kerberos.KerberosPrincipal Sender
        {
            get { return IExecute<Javax.Security.Auth.Kerberos.KerberosPrincipal>("getSender"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosCredMessage.html#destroy()"/>
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