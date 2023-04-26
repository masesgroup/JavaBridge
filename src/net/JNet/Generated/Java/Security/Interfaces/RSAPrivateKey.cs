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

namespace Java.Security.Interfaces
{
    #region RSAPrivateKey
    public partial class RSAPrivateKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Interfaces.RSAPrivateKey"/> to <see cref="Java.Security.PrivateKey"/>
        /// </summary>
        public static implicit operator Java.Security.PrivateKey(Java.Security.Interfaces.RSAPrivateKey t) => t.Cast<Java.Security.PrivateKey>();
        /// <summary>
        /// Converter from <see cref="Java.Security.Interfaces.RSAPrivateKey"/> to <see cref="Java.Security.Interfaces.RSAKey"/>
        /// </summary>
        public static implicit operator Java.Security.Interfaces.RSAKey(Java.Security.Interfaces.RSAPrivateKey t) => t.Cast<Java.Security.Interfaces.RSAKey>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAPrivateKey.html#serialVersionUID"/>
        /// </summary>
        public static long serialVersionUID { get { return LocalClazz.GetField<long>("serialVersionUID"); } }
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAPrivateKey.html#getPrivateExponent()"/> 
        /// </summary>
        public Java.Math.BigInteger PrivateExponent
        {
            get { return IExecute<Java.Math.BigInteger>("getPrivateExponent"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}