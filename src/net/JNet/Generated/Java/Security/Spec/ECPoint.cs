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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Spec
{
    #region ECPoint
    public partial class ECPoint
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECPoint.html#%3Cinit%3E(java.math.BigInteger,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        public ECPoint(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECPoint.html#POINT_INFINITY"/>
        /// </summary>
        public static Java.Security.Spec.ECPoint POINT_INFINITY { get { if (!_POINT_INFINITYReady) { _POINT_INFINITYContent = SGetField<Java.Security.Spec.ECPoint>(LocalBridgeClazz, "POINT_INFINITY"); _POINT_INFINITYReady = true; } return _POINT_INFINITYContent; } }
        private static Java.Security.Spec.ECPoint _POINT_INFINITYContent = default;
        private static bool _POINT_INFINITYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECPoint.html#getAffineX()"/> 
        /// </summary>
        public Java.Math.BigInteger AffineX
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getAffineX", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECPoint.html#getAffineY()"/> 
        /// </summary>
        public Java.Math.BigInteger AffineY
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getAffineY", "()Ljava/math/BigInteger;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}