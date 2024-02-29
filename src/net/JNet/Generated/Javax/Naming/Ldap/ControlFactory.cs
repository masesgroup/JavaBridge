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

namespace Javax.Naming.Ldap
{
    #region ControlFactory
    public partial class ControlFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/ControlFactory.html#getControlInstance(javax.naming.ldap.Control,javax.naming.Context,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.Control"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Context"/></param>
        /// <param name="arg2"><see cref="Java.Util.Hashtable"/></param>
        /// <returns><see cref="Javax.Naming.Ldap.Control"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public static Javax.Naming.Ldap.Control GetControlInstance(Javax.Naming.Ldap.Control arg0, Javax.Naming.Context arg1, Java.Util.Hashtable<object, object> arg2)
        {
            return SExecute<Javax.Naming.Ldap.Control>(LocalBridgeClazz, "getControlInstance", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/ControlFactory.html#getControlInstance(javax.naming.ldap.Control)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.Control"/></param>
        /// <returns><see cref="Javax.Naming.Ldap.Control"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Ldap.Control GetControlInstance(Javax.Naming.Ldap.Control arg0)
        {
            return IExecuteWithSignature<Javax.Naming.Ldap.Control>("getControlInstance", "(Ljavax/naming/ldap/Control;)Ljavax/naming/ldap/Control;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}