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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Crypto.Spec
{
    #region DESedeKeySpec
    public partial class DESedeKeySpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/DESedeKeySpec.html#%3Cinit%3E(byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public DESedeKeySpec(byte[] arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/DESedeKeySpec.html#%3Cinit%3E(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public DESedeKeySpec(byte[] arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Crypto.Spec.DESedeKeySpec"/> to <see cref="Java.Security.Spec.KeySpec"/>
        /// </summary>
        public static implicit operator Java.Security.Spec.KeySpec(Javax.Crypto.Spec.DESedeKeySpec t) => t.Cast<Java.Security.Spec.KeySpec>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/DESedeKeySpec.html#DES_EDE_KEY_LEN"/>
        /// </summary>
        public static int DES_EDE_KEY_LEN => Clazz.GetField<int>("DES_EDE_KEY_LEN");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/DESedeKeySpec.html#isParityAdjusted(byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public static bool IsParityAdjusted(byte[] arg0, int arg1)
        {
            return SExecute<bool>("isParityAdjusted", arg0, arg1);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/DESedeKeySpec.html#getKey()"/> 
        /// </summary>
        public byte[] Key
        {
            get { return IExecuteArray<byte>("getKey"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}