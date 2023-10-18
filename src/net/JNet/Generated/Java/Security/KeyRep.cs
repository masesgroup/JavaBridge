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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security
{
    #region KeyRep
    public partial class KeyRep
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyRep.html#%3Cinit%3E(java.security.KeyRep.Type,java.lang.String,java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyRep.Type"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        public KeyRep(Java.Security.KeyRep.Type arg0, string arg1, string arg2, byte[] arg3)
            : base(arg0, arg1, arg2, arg3)
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

        #endregion

        #region Nested classes
        #region Type
        public partial class Type
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyRep.Type.html#PRIVATE"/>
            /// </summary>
            public static Java.Security.KeyRep.Type PRIVATE { get { return SGetField<Java.Security.KeyRep.Type>(LocalBridgeClazz, "PRIVATE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyRep.Type.html#PUBLIC"/>
            /// </summary>
            public static Java.Security.KeyRep.Type PUBLIC { get { return SGetField<Java.Security.KeyRep.Type>(LocalBridgeClazz, "PUBLIC"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyRep.Type.html#SECRET"/>
            /// </summary>
            public static Java.Security.KeyRep.Type SECRET { get { return SGetField<Java.Security.KeyRep.Type>(LocalBridgeClazz, "SECRET"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyRep.Type.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Security.KeyRep.Type"/></returns>
            public static Java.Security.KeyRep.Type ValueOf(string arg0)
            {
                return SExecute<Java.Security.KeyRep.Type>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyRep.Type.html#values()"/>
            /// </summary>

            /// <returns><see cref="Java.Security.KeyRep.Type"/></returns>
            public static Java.Security.KeyRep.Type[] Values()
            {
                return SExecuteArray<Java.Security.KeyRep.Type>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}