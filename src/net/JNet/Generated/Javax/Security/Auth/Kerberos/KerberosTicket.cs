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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Security.Auth.Kerberos
{
    #region KerberosTicket
    public partial class KerberosTicket
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#%3Cinit%3E(byte[],javax.security.auth.kerberos.KerberosPrincipal,javax.security.auth.kerberos.KerberosPrincipal,byte[],int,boolean[],java.util.Date,java.util.Date,java.util.Date,java.util.Date,java.net.InetAddress[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Javax.Security.Auth.Kerberos.KerberosPrincipal"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Kerberos.KerberosPrincipal"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        /// <param name="arg6"><see cref="Java.Util.Date"/></param>
        /// <param name="arg7"><see cref="Java.Util.Date"/></param>
        /// <param name="arg8"><see cref="Java.Util.Date"/></param>
        /// <param name="arg9"><see cref="Java.Util.Date"/></param>
        /// <param name="arg10"><see cref="Java.Net.InetAddress"/></param>
        public KerberosTicket(byte[] arg0, Javax.Security.Auth.Kerberos.KerberosPrincipal arg1, Javax.Security.Auth.Kerberos.KerberosPrincipal arg2, byte[] arg3, int arg4, bool[] arg5, Java.Util.Date arg6, Java.Util.Date arg7, Java.Util.Date arg8, Java.Util.Date arg9, Java.Net.InetAddress[] arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Kerberos.KerberosTicket"/> to <see cref="Javax.Security.Auth.Destroyable"/>
        /// </summary>
        public static implicit operator Javax.Security.Auth.Destroyable(Javax.Security.Auth.Kerberos.KerberosTicket t) => t.Cast<Javax.Security.Auth.Destroyable>();
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Kerberos.KerberosTicket"/> to <see cref="Javax.Security.Auth.Refreshable"/>
        /// </summary>
        public static implicit operator Javax.Security.Auth.Refreshable(Javax.Security.Auth.Kerberos.KerberosTicket t) => t.Cast<Javax.Security.Auth.Refreshable>();
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Kerberos.KerberosTicket"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Security.Auth.Kerberos.KerberosTicket t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#getAuthTime()"/> 
        /// </summary>
        public Java.Util.Date AuthTime
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getAuthTime", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#getClient()"/> 
        /// </summary>
        public Javax.Security.Auth.Kerberos.KerberosPrincipal Client
        {
            get { return IExecuteWithSignature<Javax.Security.Auth.Kerberos.KerberosPrincipal>("getClient", "()Ljavax/security/auth/kerberos/KerberosPrincipal;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#getClientAddresses()"/> 
        /// </summary>
        public Java.Net.InetAddress[] ClientAddresses
        {
            get { return IExecuteWithSignatureArray<Java.Net.InetAddress>("getClientAddresses", "()[Ljava/net/InetAddress;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#getEncoded()"/> 
        /// </summary>
        public byte[] Encoded
        {
            get { return IExecuteWithSignatureArray<byte>("getEncoded", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#getEndTime()"/> 
        /// </summary>
        public Java.Util.Date EndTime
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getEndTime", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#getFlags()"/> 
        /// </summary>
        public bool[] Flags
        {
            get { return IExecuteWithSignatureArray<bool>("getFlags", "()[Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#getRenewTill()"/> 
        /// </summary>
        public Java.Util.Date RenewTill
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getRenewTill", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#getServer()"/> 
        /// </summary>
        public Javax.Security.Auth.Kerberos.KerberosPrincipal Server
        {
            get { return IExecuteWithSignature<Javax.Security.Auth.Kerberos.KerberosPrincipal>("getServer", "()Ljavax/security/auth/kerberos/KerberosPrincipal;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#getSessionKey()"/> 
        /// </summary>
        public Javax.Crypto.SecretKey SessionKey
        {
            get { return IExecuteWithSignature<Javax.Crypto.SecretKey>("getSessionKey", "()Ljavax/crypto/SecretKey;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#getSessionKeyType()"/> 
        /// </summary>
        public int SessionKeyType
        {
            get { return IExecuteWithSignature<int>("getSessionKeyType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#getStartTime()"/> 
        /// </summary>
        public Java.Util.Date StartTime
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getStartTime", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#isCurrent()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCurrent()
        {
            return IExecuteWithSignature<bool>("isCurrent", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#isDestroyed()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDestroyed()
        {
            return IExecuteWithSignature<bool>("isDestroyed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#isForwardable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsForwardable()
        {
            return IExecuteWithSignature<bool>("isForwardable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#isForwarded()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsForwarded()
        {
            return IExecuteWithSignature<bool>("isForwarded", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#isInitial()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsInitial()
        {
            return IExecuteWithSignature<bool>("isInitial", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#isPostdated()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPostdated()
        {
            return IExecuteWithSignature<bool>("isPostdated", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#isProxiable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsProxiable()
        {
            return IExecuteWithSignature<bool>("isProxiable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#isProxy()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsProxy()
        {
            return IExecuteWithSignature<bool>("isProxy", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#isRenewable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsRenewable()
        {
            return IExecuteWithSignature<bool>("isRenewable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#destroy()"/>
        /// </summary>

        /// <exception cref="Javax.Security.Auth.DestroyFailedException"/>
        public void Destroy()
        {
            IExecuteWithSignature("destroy", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosTicket.html#refresh()"/>
        /// </summary>

        /// <exception cref="Javax.Security.Auth.RefreshFailedException"/>
        public void Refresh()
        {
            IExecuteWithSignature("refresh", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}