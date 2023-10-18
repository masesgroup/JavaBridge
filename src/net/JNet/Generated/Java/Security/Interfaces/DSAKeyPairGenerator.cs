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

namespace Java.Security.Interfaces
{
    #region IDSAKeyPairGenerator
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDSAKeyPairGenerator
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAKeyPairGenerator.html#initialize(int,boolean,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidParameterException"/>
        void Initialize(int arg0, bool arg1, Java.Security.SecureRandom arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAKeyPairGenerator.html#initialize(java.security.interfaces.DSAParams,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Interfaces.DSAParams"/></param>
        /// <param name="arg1"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidParameterException"/>
        void Initialize(Java.Security.Interfaces.DSAParams arg0, Java.Security.SecureRandom arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DSAKeyPairGenerator
    public partial class DSAKeyPairGenerator : Java.Security.Interfaces.IDSAKeyPairGenerator
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAKeyPairGenerator.html#initialize(int,boolean,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidParameterException"/>
        public void Initialize(int arg0, bool arg1, Java.Security.SecureRandom arg2)
        {
            IExecute("initialize", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAKeyPairGenerator.html#initialize(java.security.interfaces.DSAParams,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Interfaces.DSAParams"/></param>
        /// <param name="arg1"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidParameterException"/>
        public void Initialize(Java.Security.Interfaces.DSAParams arg0, Java.Security.SecureRandom arg1)
        {
            IExecute("initialize", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}