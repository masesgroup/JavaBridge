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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Spec
{
    #region EllipticCurve declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/EllipticCurve.html"/>
    /// </summary>
    public partial class EllipticCurve : MASES.JCOBridge.C2JBridge.JVMBridgeBase<EllipticCurve>
    {
        const string _bridgeClassName = "java.security.spec.EllipticCurve";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EllipticCurve() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public EllipticCurve(params object[] args) : base(args) { }

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

    #region EllipticCurve implementation
    public partial class EllipticCurve
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/EllipticCurve.html#%3Cinit%3E(java.security.spec.ECField,java.math.BigInteger,java.math.BigInteger,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.ECField"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        public EllipticCurve(Java.Security.Spec.ECField arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2, byte[] arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/EllipticCurve.html#%3Cinit%3E(java.security.spec.ECField,java.math.BigInteger,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.ECField"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        public EllipticCurve(Java.Security.Spec.ECField arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/EllipticCurve.html#getA()"/> 
        /// </summary>
        public Java.Math.BigInteger A
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getA", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/EllipticCurve.html#getB()"/> 
        /// </summary>
        public Java.Math.BigInteger B
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getB", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/EllipticCurve.html#getField()"/> 
        /// </summary>
        public Java.Security.Spec.ECField Field
        {
            get { return IExecuteWithSignature<Java.Security.Spec.ECField>("getField", "()Ljava/security/spec/ECField;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/EllipticCurve.html#getSeed()"/> 
        /// </summary>
        public byte[] Seed
        {
            get { return IExecuteWithSignatureArray<byte>("getSeed", "()[B"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}