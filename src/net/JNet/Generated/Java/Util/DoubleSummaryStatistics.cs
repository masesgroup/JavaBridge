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

namespace Java.Util
{
    #region DoubleSummaryStatistics
    public partial class DoubleSummaryStatistics
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/DoubleSummaryStatistics.html#%3Cinit%3E(long,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public DoubleSummaryStatistics(long arg0, double arg1, double arg2, double arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.DoubleSummaryStatistics"/> to <see cref="Java.Util.Function.DoubleConsumer"/>
        /// </summary>
        public static implicit operator Java.Util.Function.DoubleConsumer(Java.Util.DoubleSummaryStatistics t) => t.Cast<Java.Util.Function.DoubleConsumer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/DoubleSummaryStatistics.html#getAverage()"/> 
        /// </summary>
        public double Average
        {
            get { return IExecuteWithSignature<double>("getAverage", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/DoubleSummaryStatistics.html#getCount()"/> 
        /// </summary>
        public long Count
        {
            get { return IExecuteWithSignature<long>("getCount", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/DoubleSummaryStatistics.html#getMax()"/> 
        /// </summary>
        public double Max
        {
            get { return IExecuteWithSignature<double>("getMax", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/DoubleSummaryStatistics.html#getMin()"/> 
        /// </summary>
        public double Min
        {
            get { return IExecuteWithSignature<double>("getMin", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/DoubleSummaryStatistics.html#getSum()"/> 
        /// </summary>
        public double Sum
        {
            get { return IExecuteWithSignature<double>("getSum", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/DoubleSummaryStatistics.html#accept(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void Accept(double arg0)
        {
            IExecuteWithSignature("accept", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/DoubleSummaryStatistics.html#combine(java.util.DoubleSummaryStatistics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.DoubleSummaryStatistics"/></param>
        public void Combine(Java.Util.DoubleSummaryStatistics arg0)
        {
            IExecuteWithSignature("combine", "(Ljava/util/DoubleSummaryStatistics;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}