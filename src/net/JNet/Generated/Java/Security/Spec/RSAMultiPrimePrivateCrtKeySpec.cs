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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Spec
{
    #region RSAMultiPrimePrivateCrtKeySpec declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html"/>
    /// </summary>
    public partial class RSAMultiPrimePrivateCrtKeySpec : Java.Security.Spec.RSAPrivateKeySpec
    {
        const string _bridgeClassName = "java.security.spec.RSAMultiPrimePrivateCrtKeySpec";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RSAMultiPrimePrivateCrtKeySpec() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RSAMultiPrimePrivateCrtKeySpec(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region RSAMultiPrimePrivateCrtKeySpec implementation
    public partial class RSAMultiPrimePrivateCrtKeySpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#%3Cinit%3E(java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.security.spec.RSAOtherPrimeInfo[],java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg3"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg4"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg5"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg6"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg7"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg8"><see cref="Java.Security.Spec.RSAOtherPrimeInfo"/></param>
        /// <param name="arg9"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        public RSAMultiPrimePrivateCrtKeySpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2, Java.Math.BigInteger arg3, Java.Math.BigInteger arg4, Java.Math.BigInteger arg5, Java.Math.BigInteger arg6, Java.Math.BigInteger arg7, Java.Security.Spec.RSAOtherPrimeInfo[] arg8, Java.Security.Spec.AlgorithmParameterSpec arg9)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#%3Cinit%3E(java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.security.spec.RSAOtherPrimeInfo[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg3"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg4"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg5"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg6"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg7"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg8"><see cref="Java.Security.Spec.RSAOtherPrimeInfo"/></param>
        public RSAMultiPrimePrivateCrtKeySpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2, Java.Math.BigInteger arg3, Java.Math.BigInteger arg4, Java.Math.BigInteger arg5, Java.Math.BigInteger arg6, Java.Math.BigInteger arg7, Java.Security.Spec.RSAOtherPrimeInfo[] arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
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
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#getCrtCoefficient()"/> 
        /// </summary>
        public Java.Math.BigInteger CrtCoefficient
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getCrtCoefficient", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#getOtherPrimeInfo()"/> 
        /// </summary>
        public Java.Security.Spec.RSAOtherPrimeInfo[] OtherPrimeInfo
        {
            get { return IExecuteWithSignatureArray<Java.Security.Spec.RSAOtherPrimeInfo>("getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#getPrimeExponentP()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeExponentP
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeExponentP", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#getPrimeExponentQ()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeExponentQ
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeExponentQ", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#getPrimeP()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeP
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeP", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#getPrimeQ()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeQ
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeQ", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#getPublicExponent()"/> 
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