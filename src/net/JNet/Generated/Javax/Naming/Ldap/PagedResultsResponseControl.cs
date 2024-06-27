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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Ldap
{
    #region PagedResultsResponseControl
    public partial class PagedResultsResponseControl
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/PagedResultsResponseControl.html#%3Cinit%3E(java.lang.String,boolean,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public PagedResultsResponseControl(Java.Lang.String arg0, bool arg1, byte[] arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/PagedResultsResponseControl.html#OID"/>
        /// </summary>
        public static Java.Lang.String OID { get { if (!_OIDReady) { _OIDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OID"); _OIDReady = true; } return _OIDContent; } }
        private static Java.Lang.String _OIDContent = default;
        private static bool _OIDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/PagedResultsResponseControl.html#getCookie()"/> 
        /// </summary>
        public byte[] Cookie
        {
            get { return IExecuteWithSignatureArray<byte>("getCookie", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/PagedResultsResponseControl.html#getResultSize()"/> 
        /// </summary>
        public int ResultSize
        {
            get { return IExecuteWithSignature<int>("getResultSize", "()I"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}