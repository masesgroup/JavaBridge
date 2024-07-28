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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region LongSummaryStatistics
    public partial class LongSummaryStatistics
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LongSummaryStatistics.html#%3Cinit%3E(long,long,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public LongSummaryStatistics(long arg0, long arg1, long arg2, long arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.LongSummaryStatistics"/> to <see cref="Java.Util.Function.LongConsumer"/>
        /// </summary>
        public static implicit operator Java.Util.Function.LongConsumer(Java.Util.LongSummaryStatistics t) => t.Cast<Java.Util.Function.LongConsumer>();
        /// <summary>
        /// Converter from <see cref="Java.Util.LongSummaryStatistics"/> to <see cref="Java.Util.Function.IntConsumer"/>
        /// </summary>
        public static implicit operator Java.Util.Function.IntConsumer(Java.Util.LongSummaryStatistics t) => t.Cast<Java.Util.Function.IntConsumer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LongSummaryStatistics.html#getAverage()"/> 
        /// </summary>
        public double Average
        {
            get { return IExecuteWithSignature<double>("getAverage", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LongSummaryStatistics.html#getCount()"/> 
        /// </summary>
        public long Count
        {
            get { return IExecuteWithSignature<long>("getCount", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LongSummaryStatistics.html#getMax()"/> 
        /// </summary>
        public long Max
        {
            get { return IExecuteWithSignature<long>("getMax", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LongSummaryStatistics.html#getMin()"/> 
        /// </summary>
        public long Min
        {
            get { return IExecuteWithSignature<long>("getMin", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LongSummaryStatistics.html#getSum()"/> 
        /// </summary>
        public long Sum
        {
            get { return IExecuteWithSignature<long>("getSum", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LongSummaryStatistics.html#accept(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Accept(int arg0)
        {
            IExecuteWithSignature("accept", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LongSummaryStatistics.html#accept(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Accept(long arg0)
        {
            IExecuteWithSignature("accept", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LongSummaryStatistics.html#combine(java.util.LongSummaryStatistics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.LongSummaryStatistics"/></param>
        public void Combine(Java.Util.LongSummaryStatistics arg0)
        {
            IExecuteWithSignature("combine", "(Ljava/util/LongSummaryStatistics;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}