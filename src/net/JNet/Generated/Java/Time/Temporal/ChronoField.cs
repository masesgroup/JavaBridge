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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time.Temporal
{
    #region ChronoField
    public partial class ChronoField
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Temporal.ChronoField"/> to <see cref="Java.Time.Temporal.TemporalField"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalField(Java.Time.Temporal.ChronoField t) => t.Cast<Java.Time.Temporal.TemporalField>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#ALIGNED_DAY_OF_WEEK_IN_MONTH"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField ALIGNED_DAY_OF_WEEK_IN_MONTH { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "ALIGNED_DAY_OF_WEEK_IN_MONTH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#ALIGNED_DAY_OF_WEEK_IN_YEAR"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField ALIGNED_DAY_OF_WEEK_IN_YEAR { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "ALIGNED_DAY_OF_WEEK_IN_YEAR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#ALIGNED_WEEK_OF_MONTH"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField ALIGNED_WEEK_OF_MONTH { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "ALIGNED_WEEK_OF_MONTH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#ALIGNED_WEEK_OF_YEAR"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField ALIGNED_WEEK_OF_YEAR { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "ALIGNED_WEEK_OF_YEAR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#AMPM_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField AMPM_OF_DAY { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "AMPM_OF_DAY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#CLOCK_HOUR_OF_AMPM"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField CLOCK_HOUR_OF_AMPM { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "CLOCK_HOUR_OF_AMPM"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#CLOCK_HOUR_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField CLOCK_HOUR_OF_DAY { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "CLOCK_HOUR_OF_DAY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#DAY_OF_MONTH"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField DAY_OF_MONTH { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "DAY_OF_MONTH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#DAY_OF_WEEK"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField DAY_OF_WEEK { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "DAY_OF_WEEK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#DAY_OF_YEAR"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField DAY_OF_YEAR { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "DAY_OF_YEAR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#EPOCH_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField EPOCH_DAY { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "EPOCH_DAY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#ERA"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField ERA { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "ERA"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#HOUR_OF_AMPM"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField HOUR_OF_AMPM { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "HOUR_OF_AMPM"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#HOUR_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField HOUR_OF_DAY { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "HOUR_OF_DAY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#INSTANT_SECONDS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField INSTANT_SECONDS { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "INSTANT_SECONDS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#MICRO_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField MICRO_OF_DAY { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "MICRO_OF_DAY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#MICRO_OF_SECOND"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField MICRO_OF_SECOND { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "MICRO_OF_SECOND"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#MILLI_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField MILLI_OF_DAY { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "MILLI_OF_DAY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#MILLI_OF_SECOND"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField MILLI_OF_SECOND { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "MILLI_OF_SECOND"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#MINUTE_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField MINUTE_OF_DAY { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "MINUTE_OF_DAY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#MINUTE_OF_HOUR"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField MINUTE_OF_HOUR { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "MINUTE_OF_HOUR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#MONTH_OF_YEAR"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField MONTH_OF_YEAR { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "MONTH_OF_YEAR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#NANO_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField NANO_OF_DAY { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "NANO_OF_DAY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#NANO_OF_SECOND"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField NANO_OF_SECOND { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "NANO_OF_SECOND"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#OFFSET_SECONDS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField OFFSET_SECONDS { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "OFFSET_SECONDS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#PROLEPTIC_MONTH"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField PROLEPTIC_MONTH { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "PROLEPTIC_MONTH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#SECOND_OF_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField SECOND_OF_DAY { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "SECOND_OF_DAY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#SECOND_OF_MINUTE"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField SECOND_OF_MINUTE { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "SECOND_OF_MINUTE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#YEAR"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField YEAR { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "YEAR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#YEAR_OF_ERA"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoField YEAR_OF_ERA { get { return SGetField<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "YEAR_OF_ERA"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Time.Temporal.ChronoField"/></returns>
        public static Java.Time.Temporal.ChronoField ValueOf(string arg0)
        {
            return SExecute<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Temporal.ChronoField"/></returns>
        public static Java.Time.Temporal.ChronoField[] Values()
        {
            return SExecuteArray<Java.Time.Temporal.ChronoField>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#getBaseUnit()"/> 
        /// </summary>
        public Java.Time.Temporal.TemporalUnit BaseUnit
        {
            get { return IExecute<Java.Time.Temporal.TemporalUnit>("getBaseUnit"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#getRangeUnit()"/> 
        /// </summary>
        public Java.Time.Temporal.TemporalUnit RangeUnit
        {
            get { return IExecute<Java.Time.Temporal.TemporalUnit>("getRangeUnit"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#adjustInto(java.time.temporal.Temporal,long)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <typeparam name="R"><see cref="Java.Time.Temporal.ITemporal"/></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R AdjustInto<R>(R arg0, long arg1) where R: Java.Time.Temporal.ITemporal, new()
        {
            return IExecute<R>("adjustInto", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#isDateBased()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDateBased()
        {
            return IExecute<bool>("isDateBased");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#isSupportedBy(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupportedBy(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecute<bool>("isSupportedBy", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#isTimeBased()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsTimeBased()
        {
            return IExecute<bool>("isTimeBased");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#checkValidIntValue(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public int CheckValidIntValue(long arg0)
        {
            return IExecute<int>("checkValidIntValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#getDisplayName(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDisplayName(Java.Util.Locale arg0)
        {
            return IExecute<string>("getDisplayName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#range()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range()
        {
            return IExecute<Java.Time.Temporal.ValueRange>("range");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#rangeRefinedBy(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange RangeRefinedBy(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecute<Java.Time.Temporal.ValueRange>("rangeRefinedBy", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#checkValidValue(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long CheckValidValue(long arg0)
        {
            return IExecute<long>("checkValidValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoField.html#getFrom(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetFrom(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecute<long>("getFrom", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}