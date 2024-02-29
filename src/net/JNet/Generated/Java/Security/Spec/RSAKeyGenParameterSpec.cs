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

namespace Java.Security.Spec
{
    #region RSAKeyGenParameterSpec
    public partial class RSAKeyGenParameterSpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAKeyGenParameterSpec.html#%3Cinit%3E(int,java.math.BigInteger,java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        public RSAKeyGenParameterSpec(int arg0, Java.Math.BigInteger arg1, Java.Security.Spec.AlgorithmParameterSpec arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAKeyGenParameterSpec.html#%3Cinit%3E(int,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        public RSAKeyGenParameterSpec(int arg0, Java.Math.BigInteger arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAKeyGenParameterSpec.html#F0"/>
        /// </summary>
        public static Java.Math.BigInteger F0 { get { if (!_F0Ready) { _F0Content = SGetField<Java.Math.BigInteger>(LocalBridgeClazz, "F0"); _F0Ready = true; } return _F0Content; } }
        private static Java.Math.BigInteger _F0Content = default;
        private static bool _F0Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAKeyGenParameterSpec.html#F4"/>
        /// </summary>
        public static Java.Math.BigInteger F4 { get { if (!_F4Ready) { _F4Content = SGetField<Java.Math.BigInteger>(LocalBridgeClazz, "F4"); _F4Ready = true; } return _F4Content; } }
        private static Java.Math.BigInteger _F4Content = default;
        private static bool _F4Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAKeyGenParameterSpec.html#getKeyParams()"/> 
        /// </summary>
        public Java.Security.Spec.AlgorithmParameterSpec KeyParams
        {
            get { return IExecuteWithSignature<Java.Security.Spec.AlgorithmParameterSpec>("getKeyParams", "()Ljava/security/spec/AlgorithmParameterSpec;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAKeyGenParameterSpec.html#getKeysize()"/> 
        /// </summary>
        public int Keysize
        {
            get { return IExecuteWithSignature<int>("getKeysize", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAKeyGenParameterSpec.html#getPublicExponent()"/> 
        /// </summary>
        public Java.Math.BigInteger PublicExponent
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPublicExponent", "()Ljava/math/BigInteger;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}