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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent.Atomic
{
    #region DoubleAccumulator
    public partial class DoubleAccumulator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/DoubleAccumulator.html#%3Cinit%3E(java.util.function.DoubleBinaryOperator,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleBinaryOperator"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public DoubleAccumulator(Java.Util.Function.DoubleBinaryOperator arg0, double arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/DoubleAccumulator.html#getThenReset()"/> 
        /// </summary>
        public double ThenReset
        {
            get { return IExecuteWithSignature<double>("getThenReset", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/DoubleAccumulator.html#get()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double Get()
        {
            return IExecuteWithSignature<double>("get", "()D");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/DoubleAccumulator.html#accumulate(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void Accumulate(double arg0)
        {
            IExecuteWithSignature("accumulate", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/DoubleAccumulator.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}