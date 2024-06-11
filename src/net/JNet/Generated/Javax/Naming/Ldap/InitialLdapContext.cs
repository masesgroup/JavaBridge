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

namespace Javax.Naming.Ldap
{
    #region InitialLdapContext
    public partial class InitialLdapContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/InitialLdapContext.html#%3Cinit%3E(java.util.Hashtable,javax.naming.ldap.Control[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Hashtable"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Ldap.Control"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public InitialLdapContext(Java.Util.Hashtable<object, object> arg0, Javax.Naming.Ldap.Control[] arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Naming.Ldap.InitialLdapContext"/> to <see cref="Javax.Naming.Ldap.LdapContext"/>
        /// </summary>
        public static implicit operator Javax.Naming.Ldap.LdapContext(Javax.Naming.Ldap.InitialLdapContext t) => t.Cast<Javax.Naming.Ldap.LdapContext>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/InitialLdapContext.html#getConnectControls()"/> 
        /// </summary>
        public Javax.Naming.Ldap.Control[] ConnectControls
        {
            get { return IExecuteWithSignatureArray<Javax.Naming.Ldap.Control>("getConnectControls", "()[Ljavax/naming/ldap/Control;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/InitialLdapContext.html#getRequestControls()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/InitialLdapContext.html#setRequestControls(javax.naming.ldap.Control[])"/>
        /// </summary>
        public Javax.Naming.Ldap.Control[] RequestControls
        {
            get { return IExecuteWithSignatureArray<Javax.Naming.Ldap.Control>("getRequestControls", "()[Ljavax/naming/ldap/Control;"); } set { IExecuteWithSignature("setRequestControls", "([Ljavax/naming/ldap/Control;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/InitialLdapContext.html#getResponseControls()"/> 
        /// </summary>
        public Javax.Naming.Ldap.Control[] ResponseControls
        {
            get { return IExecuteWithSignatureArray<Javax.Naming.Ldap.Control>("getResponseControls", "()[Ljavax/naming/ldap/Control;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/InitialLdapContext.html#extendedOperation(javax.naming.ldap.ExtendedRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.ExtendedRequest"/></param>
        /// <returns><see cref="Javax.Naming.Ldap.ExtendedResponse"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Ldap.ExtendedResponse ExtendedOperation(Javax.Naming.Ldap.ExtendedRequest arg0)
        {
            return IExecuteWithSignature<Javax.Naming.Ldap.ExtendedResponse>("extendedOperation", "(Ljavax/naming/ldap/ExtendedRequest;)Ljavax/naming/ldap/ExtendedResponse;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/InitialLdapContext.html#newInstance(javax.naming.ldap.Control[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.Control"/></param>
        /// <returns><see cref="Javax.Naming.Ldap.LdapContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Ldap.LdapContext NewInstance(Javax.Naming.Ldap.Control[] arg0)
        {
            return IExecuteWithSignature<Javax.Naming.Ldap.LdapContext>("newInstance", "([Ljavax/naming/ldap/Control;)Ljavax/naming/ldap/LdapContext;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/InitialLdapContext.html#reconnect(javax.naming.ldap.Control[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.Control"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Reconnect(Javax.Naming.Ldap.Control[] arg0)
        {
            IExecuteWithSignature("reconnect", "([Ljavax/naming/ldap/Control;)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}