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

namespace Java.Time.Temporal
{
    #region ChronoUnit
    public partial class ChronoUnit
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Temporal.ChronoUnit"/> to <see cref="Java.Time.Temporal.TemporalUnit"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalUnit(Java.Time.Temporal.ChronoUnit t) => t.Cast<Java.Time.Temporal.TemporalUnit>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#CENTURIES"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit CENTURIES => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("CENTURIES");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#DAYS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit DAYS => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("DAYS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#DECADES"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit DECADES => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("DECADES");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#ERAS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit ERAS => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("ERAS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#FOREVER"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit FOREVER => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("FOREVER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#HALF_DAYS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit HALF_DAYS => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("HALF_DAYS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#HOURS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit HOURS => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("HOURS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#MICROS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit MICROS => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("MICROS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#MILLENNIA"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit MILLENNIA => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("MILLENNIA");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#MILLIS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit MILLIS => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("MILLIS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#MINUTES"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit MINUTES => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("MINUTES");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#MONTHS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit MONTHS => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("MONTHS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#NANOS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit NANOS => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("NANOS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#SECONDS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit SECONDS => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("SECONDS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#WEEKS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit WEEKS => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("WEEKS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#YEARS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit YEARS => Clazz.GetField<Java.Time.Temporal.ChronoUnit>("YEARS");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#values()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Time.Temporal.ChronoUnit"/></returns>
        public static Java.Time.Temporal.ChronoUnit[] Values()
        {
            return SExecuteArray<Java.Time.Temporal.ChronoUnit>("values");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#getDuration()"/> 
        /// </summary>
        public Java.Time.Duration Duration
        {
            get { return IExecute<Java.Time.Duration>("getDuration"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#addTo(R,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <param name="arg1"><see langword="long"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AddTo(Java.Time.Temporal.Temporal arg0, long arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("addTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#isDateBased()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsDateBased()
        {
            return IExecute<bool>("isDateBased");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#isDurationEstimated()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsDurationEstimated()
        {
            return IExecute<bool>("isDurationEstimated");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#isSupportedBy(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsSupportedBy(Java.Time.Temporal.Temporal arg0)
        {
            return IExecute<bool>("isSupportedBy", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#isTimeBased()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsTimeBased()
        {
            return IExecute<bool>("isTimeBased");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#between(java.time.temporal.Temporal,java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see langword="long"/></returns>
        public long Between(Java.Time.Temporal.Temporal arg0, Java.Time.Temporal.Temporal arg1)
        {
            return IExecute<long>("between", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}