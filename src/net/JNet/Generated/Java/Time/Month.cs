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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time
{
    #region Month
    public partial class Month
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Month"/> to <see cref="Java.Time.Temporal.TemporalAccessor"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAccessor(Java.Time.Month t) => t.Cast<Java.Time.Temporal.TemporalAccessor>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Month"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.Month t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#APRIL"/>
        /// </summary>
        public static Java.Time.Month APRIL => Clazz.GetField<Java.Time.Month>("APRIL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#AUGUST"/>
        /// </summary>
        public static Java.Time.Month AUGUST => Clazz.GetField<Java.Time.Month>("AUGUST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#DECEMBER"/>
        /// </summary>
        public static Java.Time.Month DECEMBER => Clazz.GetField<Java.Time.Month>("DECEMBER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#FEBRUARY"/>
        /// </summary>
        public static Java.Time.Month FEBRUARY => Clazz.GetField<Java.Time.Month>("FEBRUARY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#JANUARY"/>
        /// </summary>
        public static Java.Time.Month JANUARY => Clazz.GetField<Java.Time.Month>("JANUARY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#JULY"/>
        /// </summary>
        public static Java.Time.Month JULY => Clazz.GetField<Java.Time.Month>("JULY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#JUNE"/>
        /// </summary>
        public static Java.Time.Month JUNE => Clazz.GetField<Java.Time.Month>("JUNE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#MARCH"/>
        /// </summary>
        public static Java.Time.Month MARCH => Clazz.GetField<Java.Time.Month>("MARCH");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#MAY"/>
        /// </summary>
        public static Java.Time.Month MAY => Clazz.GetField<Java.Time.Month>("MAY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#NOVEMBER"/>
        /// </summary>
        public static Java.Time.Month NOVEMBER => Clazz.GetField<Java.Time.Month>("NOVEMBER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#OCTOBER"/>
        /// </summary>
        public static Java.Time.Month OCTOBER => Clazz.GetField<Java.Time.Month>("OCTOBER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#SEPTEMBER"/>
        /// </summary>
        public static Java.Time.Month SEPTEMBER => Clazz.GetField<Java.Time.Month>("SEPTEMBER");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#values()"/> 
        /// </summary>
        public static Java.Time.Month[] Values
        {
            get { return SExecuteArray<Java.Time.Month>(LocalClazz, "values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public static Java.Time.Month From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecute<Java.Time.Month>(LocalClazz, "from", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#of(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public static Java.Time.Month Of(int arg0)
        {
            return SExecute<Java.Time.Month>(LocalClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public static Java.Time.Month ValueOf(string arg0)
        {
            return SExecute<Java.Time.Month>(LocalClazz, "valueOf", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#firstMonthOfQuarter()"/> 
        /// </summary>
        public Java.Time.Month FirstMonthOfQuarter
        {
            get { return IExecute<Java.Time.Month>("firstMonthOfQuarter"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#maxLength()"/> 
        /// </summary>
        public int MaxLength
        {
            get { return IExecute<int>("maxLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#minLength()"/> 
        /// </summary>
        public int MinLength
        {
            get { return IExecute<int>("minLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#getValue()"/> 
        /// </summary>
        public int Value
        {
            get { return IExecute<int>("getValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <returns><see cref="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecute<R>("query", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#firstDayOfYear(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public int FirstDayOfYear(bool arg0)
        {
            return IExecute<int>("firstDayOfYear", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<int>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#length(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public int Length(bool arg0)
        {
            return IExecute<int>("length", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#getDisplayName(java.time.format.TextStyle,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDisplayName(Java.Time.Format.TextStyle arg0, Java.Util.Locale arg1)
        {
            return IExecute<string>("getDisplayName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#minus(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public Java.Time.Month Minus(long arg0)
        {
            return IExecute<Java.Time.Month>("minus", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#plus(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public Java.Time.Month Plus(long arg0)
        {
            return IExecute<Java.Time.Month>("plus", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecute<Java.Time.Temporal.Temporal>("adjustInto", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<Java.Time.Temporal.ValueRange>("range", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/Month.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<long>("getLong", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}