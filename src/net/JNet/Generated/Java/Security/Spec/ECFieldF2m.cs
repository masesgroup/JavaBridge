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

namespace Java.Security.Spec
{
    #region ECFieldF2m
    public partial class ECFieldF2m
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECFieldF2m.html#%3Cinit%3E(int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public ECFieldF2m(int arg0, int[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECFieldF2m.html#%3Cinit%3E(int,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        public ECFieldF2m(int arg0, Java.Math.BigInteger arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECFieldF2m.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        public ECFieldF2m(int arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Spec.ECFieldF2m"/> to <see cref="Java.Security.Spec.ECField"/>
        /// </summary>
        public static implicit operator Java.Security.Spec.ECField(Java.Security.Spec.ECFieldF2m t) => t.Cast<Java.Security.Spec.ECField>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECFieldF2m.html#getFieldSize()"/> 
        /// </summary>
        public int FieldSize
        {
            get { return IExecute<int>("getFieldSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECFieldF2m.html#getM()"/> 
        /// </summary>
        public int M
        {
            get { return IExecute<int>("getM"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECFieldF2m.html#getMidTermsOfReductionPolynomial()"/> 
        /// </summary>
        public int[] MidTermsOfReductionPolynomial
        {
            get { return IExecuteArray<int>("getMidTermsOfReductionPolynomial"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECFieldF2m.html#getReductionPolynomial()"/> 
        /// </summary>
        public Java.Math.BigInteger ReductionPolynomial
        {
            get { return IExecute<Java.Math.BigInteger>("getReductionPolynomial"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}