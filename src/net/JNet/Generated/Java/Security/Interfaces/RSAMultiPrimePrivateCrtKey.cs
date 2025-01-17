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

namespace Java.Security.Interfaces
{
    #region RSAMultiPrimePrivateCrtKey declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html"/>
    /// </summary>
    public partial class RSAMultiPrimePrivateCrtKey : Java.Security.Interfaces.RSAPrivateKey
    {
        const string _bridgeClassName = "java.security.interfaces.RSAMultiPrimePrivateCrtKey";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("RSAMultiPrimePrivateCrtKey class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RSAMultiPrimePrivateCrtKey() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("RSAMultiPrimePrivateCrtKey class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RSAMultiPrimePrivateCrtKey(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IRSAMultiPrimePrivateCrtKey
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRSAMultiPrimePrivateCrtKey : Java.Security.Interfaces.IRSAPrivateKey
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getCrtCoefficient()"/> 
        /// </summary>
        Java.Math.BigInteger CrtCoefficient { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getOtherPrimeInfo()"/> 
        /// </summary>
        Java.Security.Spec.RSAOtherPrimeInfo[] OtherPrimeInfo { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeExponentP()"/> 
        /// </summary>
        Java.Math.BigInteger PrimeExponentP { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeExponentQ()"/> 
        /// </summary>
        Java.Math.BigInteger PrimeExponentQ { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeP()"/> 
        /// </summary>
        Java.Math.BigInteger PrimeP { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeQ()"/> 
        /// </summary>
        Java.Math.BigInteger PrimeQ { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPublicExponent()"/> 
        /// </summary>
        Java.Math.BigInteger PublicExponent { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RSAMultiPrimePrivateCrtKey implementation
    public partial class RSAMultiPrimePrivateCrtKey : Java.Security.Interfaces.IRSAMultiPrimePrivateCrtKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#serialVersionUID"/>
        /// </summary>
        public static long serialVersionUID { get { if (!_serialVersionUIDReady) { _serialVersionUIDContent = SGetField<long>(LocalBridgeClazz, "serialVersionUID"); _serialVersionUIDReady = true; } return _serialVersionUIDContent; } }
        private static long _serialVersionUIDContent = default;
        private static bool _serialVersionUIDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getCrtCoefficient()"/> 
        /// </summary>
        public Java.Math.BigInteger CrtCoefficient
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getCrtCoefficient", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getOtherPrimeInfo()"/> 
        /// </summary>
        public Java.Security.Spec.RSAOtherPrimeInfo[] OtherPrimeInfo
        {
            get { return IExecuteWithSignatureArray<Java.Security.Spec.RSAOtherPrimeInfo>("getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeExponentP()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeExponentP
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeExponentP", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeExponentQ()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeExponentQ
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeExponentQ", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeP()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeP
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeP", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPrimeQ()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeQ
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPrimeQ", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAMultiPrimePrivateCrtKey.html#getPublicExponent()"/> 
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