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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time
{
    #region Period
    public partial class Period
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Period"/> to <see cref="Java.Time.Chrono.ChronoPeriod"/>
        /// </summary>
        public static implicit operator Java.Time.Chrono.ChronoPeriod(Java.Time.Period t) => t.Cast<Java.Time.Chrono.ChronoPeriod>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Period"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.Period t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#ZERO"/>
        /// </summary>
        public static Java.Time.Period ZERO => Clazz.GetField<Java.Time.Period>("ZERO");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#between(java.time.LocalDate,java.time.LocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <param name="arg1"><see cref="Java.Time.LocalDate"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period Between(Java.Time.LocalDate arg0, Java.Time.LocalDate arg1)
        {
            return SExecute<Java.Time.Period>("between", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#from(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period From(Java.Time.Temporal.TemporalAmount arg0)
        {
            return SExecute<Java.Time.Period>("from", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#of(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period Of(int arg0, int arg1, int arg2)
        {
            return SExecute<Java.Time.Period>("of", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#ofDays(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period OfDays(int arg0)
        {
            return SExecute<Java.Time.Period>("ofDays", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#ofMonths(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period OfMonths(int arg0)
        {
            return SExecute<Java.Time.Period>("ofMonths", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#ofWeeks(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period OfWeeks(int arg0)
        {
            return SExecute<Java.Time.Period>("ofWeeks", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#ofYears(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period OfYears(int arg0)
        {
            return SExecute<Java.Time.Period>("ofYears", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period Parse(Java.Lang.CharSequence arg0)
        {
            return SExecute<Java.Time.Period>("parse", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#getChronology()"/> 
        /// </summary>
        public Java.Time.Chrono.Chronology Chronology
        {
            get { return IExecute<Java.Time.Chrono.Chronology>("getChronology"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#getDays()"/> 
        /// </summary>
        public int Days
        {
            get { return IExecute<int>("getDays"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#isNegative()"/> 
        /// </summary>
        public bool IsNegative
        {
            get { return IExecute<bool>("isNegative"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#isZero()"/> 
        /// </summary>
        public bool IsZero
        {
            get { return IExecute<bool>("isZero"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#getMonths()"/> 
        /// </summary>
        public int Months
        {
            get { return IExecute<int>("getMonths"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#negated()"/> 
        /// </summary>
        public Java.Time.Chrono.ChronoPeriod Negated
        {
            get { return IExecute<Java.Time.Chrono.ChronoPeriod>("negated"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#normalized()"/> 
        /// </summary>
        public Java.Time.Chrono.ChronoPeriod Normalized
        {
            get { return IExecute<Java.Time.Chrono.ChronoPeriod>("normalized"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#toTotalMonths()"/> 
        /// </summary>
        public long ToTotalMonths
        {
            get { return IExecute<long>("toTotalMonths"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#getUnits()"/> 
        /// </summary>
        public Java.Util.List Units
        {
            get { return IExecute<Java.Util.List>("getUnits"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#getYears()"/> 
        /// </summary>
        public int Years
        {
            get { return IExecute<int>("getYears"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#minus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoPeriod"/></returns>
        public Java.Time.Chrono.ChronoPeriod Minus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecute<Java.Time.Chrono.ChronoPeriod>("minus", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#multipliedBy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoPeriod"/></returns>
        public Java.Time.Chrono.ChronoPeriod MultipliedBy(int arg0)
        {
            return IExecute<Java.Time.Chrono.ChronoPeriod>("multipliedBy", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#plus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoPeriod"/></returns>
        public Java.Time.Chrono.ChronoPeriod Plus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecute<Java.Time.Chrono.ChronoPeriod>("plus", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#minusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period MinusDays(long arg0)
        {
            return IExecute<Java.Time.Period>("minusDays", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#minusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period MinusMonths(long arg0)
        {
            return IExecute<Java.Time.Period>("minusMonths", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#minusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period MinusYears(long arg0)
        {
            return IExecute<Java.Time.Period>("minusYears", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#plusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period PlusDays(long arg0)
        {
            return IExecute<Java.Time.Period>("plusDays", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#plusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period PlusMonths(long arg0)
        {
            return IExecute<Java.Time.Period>("plusMonths", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#plusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period PlusYears(long arg0)
        {
            return IExecute<Java.Time.Period>("plusYears", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#withDays(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period WithDays(int arg0)
        {
            return IExecute<Java.Time.Period>("withDays", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#withMonths(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period WithMonths(int arg0)
        {
            return IExecute<Java.Time.Period>("withMonths", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#withYears(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period WithYears(int arg0)
        {
            return IExecute<Java.Time.Period>("withYears", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#addTo(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AddTo(Java.Time.Temporal.Temporal arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("addTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#subtractFrom(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal SubtractFrom(Java.Time.Temporal.Temporal arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("subtractFrom", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Period.html#get(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="long"/></returns>
        public long Get(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecute<long>("get", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}