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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Text
{
    #region DateFormat
    public partial class DateFormat
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#AM_PM_FIELD"/>
        /// </summary>
        public static int AM_PM_FIELD { get { return SGetField<int>(LocalBridgeClazz, "AM_PM_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#DATE_FIELD"/>
        /// </summary>
        public static int DATE_FIELD { get { return SGetField<int>(LocalBridgeClazz, "DATE_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#DAY_OF_WEEK_FIELD"/>
        /// </summary>
        public static int DAY_OF_WEEK_FIELD { get { return SGetField<int>(LocalBridgeClazz, "DAY_OF_WEEK_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#DAY_OF_WEEK_IN_MONTH_FIELD"/>
        /// </summary>
        public static int DAY_OF_WEEK_IN_MONTH_FIELD { get { return SGetField<int>(LocalBridgeClazz, "DAY_OF_WEEK_IN_MONTH_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#DAY_OF_YEAR_FIELD"/>
        /// </summary>
        public static int DAY_OF_YEAR_FIELD { get { return SGetField<int>(LocalBridgeClazz, "DAY_OF_YEAR_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#DEFAULT"/>
        /// </summary>
        public static int DEFAULT { get { return SGetField<int>(LocalBridgeClazz, "DEFAULT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#ERA_FIELD"/>
        /// </summary>
        public static int ERA_FIELD { get { return SGetField<int>(LocalBridgeClazz, "ERA_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#FULL"/>
        /// </summary>
        public static int FULL { get { return SGetField<int>(LocalBridgeClazz, "FULL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#HOUR_OF_DAY0_FIELD"/>
        /// </summary>
        public static int HOUR_OF_DAY0_FIELD { get { return SGetField<int>(LocalBridgeClazz, "HOUR_OF_DAY0_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#HOUR_OF_DAY1_FIELD"/>
        /// </summary>
        public static int HOUR_OF_DAY1_FIELD { get { return SGetField<int>(LocalBridgeClazz, "HOUR_OF_DAY1_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#HOUR0_FIELD"/>
        /// </summary>
        public static int HOUR0_FIELD { get { return SGetField<int>(LocalBridgeClazz, "HOUR0_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#HOUR1_FIELD"/>
        /// </summary>
        public static int HOUR1_FIELD { get { return SGetField<int>(LocalBridgeClazz, "HOUR1_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#LONG"/>
        /// </summary>
        public static int LONG { get { return SGetField<int>(LocalBridgeClazz, "LONG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#MEDIUM"/>
        /// </summary>
        public static int MEDIUM { get { return SGetField<int>(LocalBridgeClazz, "MEDIUM"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#MILLISECOND_FIELD"/>
        /// </summary>
        public static int MILLISECOND_FIELD { get { return SGetField<int>(LocalBridgeClazz, "MILLISECOND_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#MINUTE_FIELD"/>
        /// </summary>
        public static int MINUTE_FIELD { get { return SGetField<int>(LocalBridgeClazz, "MINUTE_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#MONTH_FIELD"/>
        /// </summary>
        public static int MONTH_FIELD { get { return SGetField<int>(LocalBridgeClazz, "MONTH_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#SECOND_FIELD"/>
        /// </summary>
        public static int SECOND_FIELD { get { return SGetField<int>(LocalBridgeClazz, "SECOND_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#SHORT"/>
        /// </summary>
        public static int SHORT { get { return SGetField<int>(LocalBridgeClazz, "SHORT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#TIMEZONE_FIELD"/>
        /// </summary>
        public static int TIMEZONE_FIELD { get { return SGetField<int>(LocalBridgeClazz, "TIMEZONE_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#WEEK_OF_MONTH_FIELD"/>
        /// </summary>
        public static int WEEK_OF_MONTH_FIELD { get { return SGetField<int>(LocalBridgeClazz, "WEEK_OF_MONTH_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#WEEK_OF_YEAR_FIELD"/>
        /// </summary>
        public static int WEEK_OF_YEAR_FIELD { get { return SGetField<int>(LocalBridgeClazz, "WEEK_OF_YEAR_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#YEAR_FIELD"/>
        /// </summary>
        public static int YEAR_FIELD { get { return SGetField<int>(LocalBridgeClazz, "YEAR_FIELD"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getAvailableLocales()"/> 
        /// </summary>
        public static Java.Util.Locale[] AvailableLocales
        {
            get { return SExecuteArray<Java.Util.Locale>(LocalBridgeClazz, "getAvailableLocales"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getDateInstance()"/> 
        /// </summary>
        public static Java.Text.DateFormat DateInstance
        {
            get { return SExecute<Java.Text.DateFormat>(LocalBridgeClazz, "getDateInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getDateTimeInstance()"/> 
        /// </summary>
        public static Java.Text.DateFormat DateTimeInstance
        {
            get { return SExecute<Java.Text.DateFormat>(LocalBridgeClazz, "getDateTimeInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getInstance()"/> 
        /// </summary>
        public static Java.Text.DateFormat Instance
        {
            get { return SExecute<Java.Text.DateFormat>(LocalBridgeClazz, "getInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getTimeInstance()"/> 
        /// </summary>
        public static Java.Text.DateFormat TimeInstance
        {
            get { return SExecute<Java.Text.DateFormat>(LocalBridgeClazz, "getTimeInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getDateInstance(int,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.DateFormat"/></returns>
        public static Java.Text.DateFormat GetDateInstance(int arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Text.DateFormat>(LocalBridgeClazz, "getDateInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getDateInstance(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Text.DateFormat"/></returns>
        public static Java.Text.DateFormat GetDateInstance(int arg0)
        {
            return SExecute<Java.Text.DateFormat>(LocalBridgeClazz, "getDateInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getDateTimeInstance(int,int,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.DateFormat"/></returns>
        public static Java.Text.DateFormat GetDateTimeInstance(int arg0, int arg1, Java.Util.Locale arg2)
        {
            return SExecute<Java.Text.DateFormat>(LocalBridgeClazz, "getDateTimeInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getDateTimeInstance(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Text.DateFormat"/></returns>
        public static Java.Text.DateFormat GetDateTimeInstance(int arg0, int arg1)
        {
            return SExecute<Java.Text.DateFormat>(LocalBridgeClazz, "getDateTimeInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getTimeInstance(int,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.DateFormat"/></returns>
        public static Java.Text.DateFormat GetTimeInstance(int arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Text.DateFormat>(LocalBridgeClazz, "getTimeInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getTimeInstance(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Text.DateFormat"/></returns>
        public static Java.Text.DateFormat GetTimeInstance(int arg0)
        {
            return SExecute<Java.Text.DateFormat>(LocalBridgeClazz, "getTimeInstance", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getCalendar()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#setCalendar(java.util.Calendar)"/>
        /// </summary>
        public Java.Util.Calendar Calendar
        {
            get { return IExecute<Java.Util.Calendar>("getCalendar"); } set { IExecute("setCalendar", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getNumberFormat()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#setNumberFormat(java.text.NumberFormat)"/>
        /// </summary>
        public Java.Text.NumberFormat NumberFormat
        {
            get { return IExecute<Java.Text.NumberFormat>("getNumberFormat"); } set { IExecute("setNumberFormat", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getTimeZone()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#setTimeZone(java.util.TimeZone)"/>
        /// </summary>
        public Java.Util.TimeZone TimeZone
        {
            get { return IExecute<Java.Util.TimeZone>("getTimeZone"); } set { IExecute("setTimeZone", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#format(java.util.Date,java.lang.StringBuffer,java.text.FieldPosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <param name="arg1"><see cref="Java.Lang.StringBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Text.FieldPosition"/></param>
        /// <returns><see cref="Java.Lang.StringBuffer"/></returns>
        public Java.Lang.StringBuffer Format(Java.Util.Date arg0, Java.Lang.StringBuffer arg1, Java.Text.FieldPosition arg2)
        {
            return IExecute<Java.Lang.StringBuffer>("format", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#parse(java.lang.String,java.text.ParsePosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Text.ParsePosition"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date Parse(string arg0, Java.Text.ParsePosition arg1)
        {
            return IExecute<Java.Util.Date>("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#isLenient()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLenient()
        {
            return IExecute<bool>("isLenient");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#format(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="string"/></returns>
        public string Format(Java.Util.Date arg0)
        {
            return IExecute<string>("format", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        /// <exception cref="Java.Text.ParseException"/>
        public Java.Util.Date Parse(string arg0)
        {
            return IExecute<Java.Util.Date>("parse", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#setLenient(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetLenient(bool arg0)
        {
            IExecute("setLenient", arg0);
        }

        #endregion

        #region Nested classes
        #region Field
        public partial class Field
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#AM_PM"/>
            /// </summary>
            public static Java.Text.DateFormat.Field AM_PM { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "AM_PM"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#DAY_OF_MONTH"/>
            /// </summary>
            public static Java.Text.DateFormat.Field DAY_OF_MONTH { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "DAY_OF_MONTH"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#DAY_OF_WEEK"/>
            /// </summary>
            public static Java.Text.DateFormat.Field DAY_OF_WEEK { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "DAY_OF_WEEK"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#DAY_OF_WEEK_IN_MONTH"/>
            /// </summary>
            public static Java.Text.DateFormat.Field DAY_OF_WEEK_IN_MONTH { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "DAY_OF_WEEK_IN_MONTH"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#DAY_OF_YEAR"/>
            /// </summary>
            public static Java.Text.DateFormat.Field DAY_OF_YEAR { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "DAY_OF_YEAR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#ERA"/>
            /// </summary>
            public static Java.Text.DateFormat.Field ERA { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "ERA"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#HOUR_OF_DAY0"/>
            /// </summary>
            public static Java.Text.DateFormat.Field HOUR_OF_DAY0 { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "HOUR_OF_DAY0"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#HOUR_OF_DAY1"/>
            /// </summary>
            public static Java.Text.DateFormat.Field HOUR_OF_DAY1 { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "HOUR_OF_DAY1"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#HOUR0"/>
            /// </summary>
            public static Java.Text.DateFormat.Field HOUR0 { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "HOUR0"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#HOUR1"/>
            /// </summary>
            public static Java.Text.DateFormat.Field HOUR1 { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "HOUR1"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#MILLISECOND"/>
            /// </summary>
            public static Java.Text.DateFormat.Field MILLISECOND { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "MILLISECOND"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#MINUTE"/>
            /// </summary>
            public static Java.Text.DateFormat.Field MINUTE { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "MINUTE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#MONTH"/>
            /// </summary>
            public static Java.Text.DateFormat.Field MONTH { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "MONTH"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#SECOND"/>
            /// </summary>
            public static Java.Text.DateFormat.Field SECOND { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "SECOND"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#TIME_ZONE"/>
            /// </summary>
            public static Java.Text.DateFormat.Field TIME_ZONE { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "TIME_ZONE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#WEEK_OF_MONTH"/>
            /// </summary>
            public static Java.Text.DateFormat.Field WEEK_OF_MONTH { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "WEEK_OF_MONTH"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#WEEK_OF_YEAR"/>
            /// </summary>
            public static Java.Text.DateFormat.Field WEEK_OF_YEAR { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "WEEK_OF_YEAR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#YEAR"/>
            /// </summary>
            public static Java.Text.DateFormat.Field YEAR { get { return SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "YEAR"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#ofCalendarField(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Java.Text.DateFormat.Field"/></returns>
            public static Java.Text.DateFormat.Field OfCalendarField(int arg0)
            {
                return SExecute<Java.Text.DateFormat.Field>(LocalBridgeClazz, "ofCalendarField", arg0);
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#getCalendarField()"/> 
            /// </summary>
            public int CalendarField
            {
                get { return IExecute<int>("getCalendarField"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}