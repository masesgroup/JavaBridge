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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security
{
    #region Policy
    public partial class Policy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Policy.html#UNSUPPORTED_EMPTY_COLLECTION"/>
        /// </summary>
        public static Java.Security.PermissionCollection UNSUPPORTED_EMPTY_COLLECTION => Clazz.GetField<Java.Security.PermissionCollection>("UNSUPPORTED_EMPTY_COLLECTION");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Policy.html#getInstance(java.lang.String,java.security.Policy$Parameters,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.Policy.Parameters"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.Policy"/></returns>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.Policy GetInstance(string arg0, Java.Security.Policy.Parameters arg1, string arg2)
        {
            return SExecute<Java.Security.Policy>("getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Policy.html#getInstance(java.lang.String,java.security.Policy$Parameters,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.Policy.Parameters"/></param>
        /// <param name="arg2"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Java.Security.Policy"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.Policy GetInstance(string arg0, Java.Security.Policy.Parameters arg1, Java.Security.Provider arg2)
        {
            return SExecute<Java.Security.Policy>("getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Policy.html#getInstance(java.lang.String,java.security.Policy$Parameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.Policy.Parameters"/></param>
        /// <returns><see cref="Java.Security.Policy"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.Policy GetInstance(string arg0, Java.Security.Policy.Parameters arg1)
        {
            return SExecute<Java.Security.Policy>("getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Policy.html#getPolicy()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Security.Policy"/></returns>
        public static Java.Security.Policy GetPolicy()
        {
            return SExecute<Java.Security.Policy>("getPolicy");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Policy.html#setPolicy(java.security.Policy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Policy"/></param>
        public static void SetPolicy(Java.Security.Policy arg0)
        {
            SExecute("setPolicy", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Policy.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecute<Java.Security.Provider>("getProvider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Policy.html#getType()"/> 
        /// </summary>
        public string Type
        {
            get { return IExecute<string>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Policy.html#implies(java.security.ProtectionDomain,java.security.Permission)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.ProtectionDomain"/></param>
        /// <param name="arg1"><see cref="Java.Security.Permission"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Implies(Java.Security.ProtectionDomain arg0, Java.Security.Permission arg1)
        {
            return IExecute<bool>("implies", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Policy.html#getPermissions(java.security.CodeSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.CodeSource"/></param>
        /// <returns><see cref="Java.Security.PermissionCollection"/></returns>
        public Java.Security.PermissionCollection GetPermissions(Java.Security.CodeSource arg0)
        {
            return IExecute<Java.Security.PermissionCollection>("getPermissions", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Policy.html#getPermissions(java.security.ProtectionDomain)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.ProtectionDomain"/></param>
        /// <returns><see cref="Java.Security.PermissionCollection"/></returns>
        public Java.Security.PermissionCollection GetPermissions(Java.Security.ProtectionDomain arg0)
        {
            return IExecute<Java.Security.PermissionCollection>("getPermissions", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Policy.html#getParameters()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Security.Policy.Parameters"/></returns>
        public Java.Security.Policy.Parameters GetParameters()
        {
            return IExecute<Java.Security.Policy.Parameters>("getParameters");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Policy.html#refresh()"/>
        /// </summary>
        public void Refresh()
        {
            IExecute("refresh");
        }
        
        #endregion

        #region Nested classes
        #region Parameters
        public partial class Parameters
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

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}