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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
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
        public static int AM_PM_FIELD { get { if (!_AM_PM_FIELDReady) { _AM_PM_FIELDContent = SGetField<int>(LocalBridgeClazz, "AM_PM_FIELD"); _AM_PM_FIELDReady = true; } return _AM_PM_FIELDContent; } }
        private static int _AM_PM_FIELDContent = default;
        private static bool _AM_PM_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#DATE_FIELD"/>
        /// </summary>
        public static int DATE_FIELD { get { if (!_DATE_FIELDReady) { _DATE_FIELDContent = SGetField<int>(LocalBridgeClazz, "DATE_FIELD"); _DATE_FIELDReady = true; } return _DATE_FIELDContent; } }
        private static int _DATE_FIELDContent = default;
        private static bool _DATE_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#DAY_OF_WEEK_FIELD"/>
        /// </summary>
        public static int DAY_OF_WEEK_FIELD { get { if (!_DAY_OF_WEEK_FIELDReady) { _DAY_OF_WEEK_FIELDContent = SGetField<int>(LocalBridgeClazz, "DAY_OF_WEEK_FIELD"); _DAY_OF_WEEK_FIELDReady = true; } return _DAY_OF_WEEK_FIELDContent; } }
        private static int _DAY_OF_WEEK_FIELDContent = default;
        private static bool _DAY_OF_WEEK_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#DAY_OF_WEEK_IN_MONTH_FIELD"/>
        /// </summary>
        public static int DAY_OF_WEEK_IN_MONTH_FIELD { get { if (!_DAY_OF_WEEK_IN_MONTH_FIELDReady) { _DAY_OF_WEEK_IN_MONTH_FIELDContent = SGetField<int>(LocalBridgeClazz, "DAY_OF_WEEK_IN_MONTH_FIELD"); _DAY_OF_WEEK_IN_MONTH_FIELDReady = true; } return _DAY_OF_WEEK_IN_MONTH_FIELDContent; } }
        private static int _DAY_OF_WEEK_IN_MONTH_FIELDContent = default;
        private static bool _DAY_OF_WEEK_IN_MONTH_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#DAY_OF_YEAR_FIELD"/>
        /// </summary>
        public static int DAY_OF_YEAR_FIELD { get { if (!_DAY_OF_YEAR_FIELDReady) { _DAY_OF_YEAR_FIELDContent = SGetField<int>(LocalBridgeClazz, "DAY_OF_YEAR_FIELD"); _DAY_OF_YEAR_FIELDReady = true; } return _DAY_OF_YEAR_FIELDContent; } }
        private static int _DAY_OF_YEAR_FIELDContent = default;
        private static bool _DAY_OF_YEAR_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#DEFAULT"/>
        /// </summary>
        public static int DEFAULT { get { if (!_DEFAULTReady) { _DEFAULTContent = SGetField<int>(LocalBridgeClazz, "DEFAULT"); _DEFAULTReady = true; } return _DEFAULTContent; } }
        private static int _DEFAULTContent = default;
        private static bool _DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#ERA_FIELD"/>
        /// </summary>
        public static int ERA_FIELD { get { if (!_ERA_FIELDReady) { _ERA_FIELDContent = SGetField<int>(LocalBridgeClazz, "ERA_FIELD"); _ERA_FIELDReady = true; } return _ERA_FIELDContent; } }
        private static int _ERA_FIELDContent = default;
        private static bool _ERA_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#FULL"/>
        /// </summary>
        public static int FULL { get { if (!_FULLReady) { _FULLContent = SGetField<int>(LocalBridgeClazz, "FULL"); _FULLReady = true; } return _FULLContent; } }
        private static int _FULLContent = default;
        private static bool _FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#HOUR_OF_DAY0_FIELD"/>
        /// </summary>
        public static int HOUR_OF_DAY0_FIELD { get { if (!_HOUR_OF_DAY0_FIELDReady) { _HOUR_OF_DAY0_FIELDContent = SGetField<int>(LocalBridgeClazz, "HOUR_OF_DAY0_FIELD"); _HOUR_OF_DAY0_FIELDReady = true; } return _HOUR_OF_DAY0_FIELDContent; } }
        private static int _HOUR_OF_DAY0_FIELDContent = default;
        private static bool _HOUR_OF_DAY0_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#HOUR_OF_DAY1_FIELD"/>
        /// </summary>
        public static int HOUR_OF_DAY1_FIELD { get { if (!_HOUR_OF_DAY1_FIELDReady) { _HOUR_OF_DAY1_FIELDContent = SGetField<int>(LocalBridgeClazz, "HOUR_OF_DAY1_FIELD"); _HOUR_OF_DAY1_FIELDReady = true; } return _HOUR_OF_DAY1_FIELDContent; } }
        private static int _HOUR_OF_DAY1_FIELDContent = default;
        private static bool _HOUR_OF_DAY1_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#HOUR0_FIELD"/>
        /// </summary>
        public static int HOUR0_FIELD { get { if (!_HOUR0_FIELDReady) { _HOUR0_FIELDContent = SGetField<int>(LocalBridgeClazz, "HOUR0_FIELD"); _HOUR0_FIELDReady = true; } return _HOUR0_FIELDContent; } }
        private static int _HOUR0_FIELDContent = default;
        private static bool _HOUR0_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#HOUR1_FIELD"/>
        /// </summary>
        public static int HOUR1_FIELD { get { if (!_HOUR1_FIELDReady) { _HOUR1_FIELDContent = SGetField<int>(LocalBridgeClazz, "HOUR1_FIELD"); _HOUR1_FIELDReady = true; } return _HOUR1_FIELDContent; } }
        private static int _HOUR1_FIELDContent = default;
        private static bool _HOUR1_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#LONG"/>
        /// </summary>
        public static int LONG { get { if (!_LONGReady) { _LONGContent = SGetField<int>(LocalBridgeClazz, "LONG"); _LONGReady = true; } return _LONGContent; } }
        private static int _LONGContent = default;
        private static bool _LONGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#MEDIUM"/>
        /// </summary>
        public static int MEDIUM { get { if (!_MEDIUMReady) { _MEDIUMContent = SGetField<int>(LocalBridgeClazz, "MEDIUM"); _MEDIUMReady = true; } return _MEDIUMContent; } }
        private static int _MEDIUMContent = default;
        private static bool _MEDIUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#MILLISECOND_FIELD"/>
        /// </summary>
        public static int MILLISECOND_FIELD { get { if (!_MILLISECOND_FIELDReady) { _MILLISECOND_FIELDContent = SGetField<int>(LocalBridgeClazz, "MILLISECOND_FIELD"); _MILLISECOND_FIELDReady = true; } return _MILLISECOND_FIELDContent; } }
        private static int _MILLISECOND_FIELDContent = default;
        private static bool _MILLISECOND_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#MINUTE_FIELD"/>
        /// </summary>
        public static int MINUTE_FIELD { get { if (!_MINUTE_FIELDReady) { _MINUTE_FIELDContent = SGetField<int>(LocalBridgeClazz, "MINUTE_FIELD"); _MINUTE_FIELDReady = true; } return _MINUTE_FIELDContent; } }
        private static int _MINUTE_FIELDContent = default;
        private static bool _MINUTE_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#MONTH_FIELD"/>
        /// </summary>
        public static int MONTH_FIELD { get { if (!_MONTH_FIELDReady) { _MONTH_FIELDContent = SGetField<int>(LocalBridgeClazz, "MONTH_FIELD"); _MONTH_FIELDReady = true; } return _MONTH_FIELDContent; } }
        private static int _MONTH_FIELDContent = default;
        private static bool _MONTH_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#SECOND_FIELD"/>
        /// </summary>
        public static int SECOND_FIELD { get { if (!_SECOND_FIELDReady) { _SECOND_FIELDContent = SGetField<int>(LocalBridgeClazz, "SECOND_FIELD"); _SECOND_FIELDReady = true; } return _SECOND_FIELDContent; } }
        private static int _SECOND_FIELDContent = default;
        private static bool _SECOND_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#SHORT"/>
        /// </summary>
        public static int SHORT { get { if (!_SHORTReady) { _SHORTContent = SGetField<int>(LocalBridgeClazz, "SHORT"); _SHORTReady = true; } return _SHORTContent; } }
        private static int _SHORTContent = default;
        private static bool _SHORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#TIMEZONE_FIELD"/>
        /// </summary>
        public static int TIMEZONE_FIELD { get { if (!_TIMEZONE_FIELDReady) { _TIMEZONE_FIELDContent = SGetField<int>(LocalBridgeClazz, "TIMEZONE_FIELD"); _TIMEZONE_FIELDReady = true; } return _TIMEZONE_FIELDContent; } }
        private static int _TIMEZONE_FIELDContent = default;
        private static bool _TIMEZONE_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#WEEK_OF_MONTH_FIELD"/>
        /// </summary>
        public static int WEEK_OF_MONTH_FIELD { get { if (!_WEEK_OF_MONTH_FIELDReady) { _WEEK_OF_MONTH_FIELDContent = SGetField<int>(LocalBridgeClazz, "WEEK_OF_MONTH_FIELD"); _WEEK_OF_MONTH_FIELDReady = true; } return _WEEK_OF_MONTH_FIELDContent; } }
        private static int _WEEK_OF_MONTH_FIELDContent = default;
        private static bool _WEEK_OF_MONTH_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#WEEK_OF_YEAR_FIELD"/>
        /// </summary>
        public static int WEEK_OF_YEAR_FIELD { get { if (!_WEEK_OF_YEAR_FIELDReady) { _WEEK_OF_YEAR_FIELDContent = SGetField<int>(LocalBridgeClazz, "WEEK_OF_YEAR_FIELD"); _WEEK_OF_YEAR_FIELDReady = true; } return _WEEK_OF_YEAR_FIELDContent; } }
        private static int _WEEK_OF_YEAR_FIELDContent = default;
        private static bool _WEEK_OF_YEAR_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#YEAR_FIELD"/>
        /// </summary>
        public static int YEAR_FIELD { get { if (!_YEAR_FIELDReady) { _YEAR_FIELDContent = SGetField<int>(LocalBridgeClazz, "YEAR_FIELD"); _YEAR_FIELDReady = true; } return _YEAR_FIELDContent; } }
        private static int _YEAR_FIELDContent = default;
        private static bool _YEAR_FIELDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getAvailableLocales()"/> 
        /// </summary>
        public static Java.Util.Locale[] AvailableLocales
        {
            get { return SExecuteWithSignatureArray<Java.Util.Locale>(LocalBridgeClazz, "getAvailableLocales", "()[Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getDateInstance()"/> 
        /// </summary>
        public static Java.Text.DateFormat DateInstance
        {
            get { return SExecuteWithSignature<Java.Text.DateFormat>(LocalBridgeClazz, "getDateInstance", "()Ljava/text/DateFormat;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getDateTimeInstance()"/> 
        /// </summary>
        public static Java.Text.DateFormat DateTimeInstance
        {
            get { return SExecuteWithSignature<Java.Text.DateFormat>(LocalBridgeClazz, "getDateTimeInstance", "()Ljava/text/DateFormat;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getInstance()"/> 
        /// </summary>
        public static Java.Text.DateFormat Instance
        {
            get { return SExecuteWithSignature<Java.Text.DateFormat>(LocalBridgeClazz, "getInstance", "()Ljava/text/DateFormat;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getTimeInstance()"/> 
        /// </summary>
        public static Java.Text.DateFormat TimeInstance
        {
            get { return SExecuteWithSignature<Java.Text.DateFormat>(LocalBridgeClazz, "getTimeInstance", "()Ljava/text/DateFormat;"); }
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
            return SExecuteWithSignature<Java.Text.DateFormat>(LocalBridgeClazz, "getDateInstance", "(I)Ljava/text/DateFormat;", arg0);
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
            return SExecuteWithSignature<Java.Text.DateFormat>(LocalBridgeClazz, "getTimeInstance", "(I)Ljava/text/DateFormat;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getCalendar()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#setCalendar(java.util.Calendar)"/>
        /// </summary>
        public Java.Util.Calendar Calendar
        {
            get { return IExecuteWithSignature<Java.Util.Calendar>("getCalendar", "()Ljava/util/Calendar;"); } set { IExecuteWithSignature("setCalendar", "(Ljava/util/Calendar;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getNumberFormat()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#setNumberFormat(java.text.NumberFormat)"/>
        /// </summary>
        public Java.Text.NumberFormat NumberFormat
        {
            get { return IExecuteWithSignature<Java.Text.NumberFormat>("getNumberFormat", "()Ljava/text/NumberFormat;"); } set { IExecuteWithSignature("setNumberFormat", "(Ljava/text/NumberFormat;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#getTimeZone()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#setTimeZone(java.util.TimeZone)"/>
        /// </summary>
        public Java.Util.TimeZone TimeZone
        {
            get { return IExecuteWithSignature<Java.Util.TimeZone>("getTimeZone", "()Ljava/util/TimeZone;"); } set { IExecuteWithSignature("setTimeZone", "(Ljava/util/TimeZone;)V", value); }
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
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Text.ParsePosition"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date Parse(Java.Lang.String arg0, Java.Text.ParsePosition arg1)
        {
            return IExecute<Java.Util.Date>("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#isLenient()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLenient()
        {
            return IExecuteWithSignature<bool>("isLenient", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#format(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(Java.Util.Date arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(Ljava/util/Date;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        /// <exception cref="Java.Text.ParseException"/>
        public Java.Util.Date Parse(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Date>("parse", "(Ljava/lang/String;)Ljava/util/Date;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.html#setLenient(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetLenient(bool arg0)
        {
            IExecuteWithSignature("setLenient", "(Z)V", arg0);
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
            public static Java.Text.DateFormat.Field AM_PM { get { if (!_AM_PMReady) { _AM_PMContent = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "AM_PM"); _AM_PMReady = true; } return _AM_PMContent; } }
            private static Java.Text.DateFormat.Field _AM_PMContent = default;
            private static bool _AM_PMReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#DAY_OF_MONTH"/>
            /// </summary>
            public static Java.Text.DateFormat.Field DAY_OF_MONTH { get { if (!_DAY_OF_MONTHReady) { _DAY_OF_MONTHContent = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "DAY_OF_MONTH"); _DAY_OF_MONTHReady = true; } return _DAY_OF_MONTHContent; } }
            private static Java.Text.DateFormat.Field _DAY_OF_MONTHContent = default;
            private static bool _DAY_OF_MONTHReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#DAY_OF_WEEK"/>
            /// </summary>
            public static Java.Text.DateFormat.Field DAY_OF_WEEK { get { if (!_DAY_OF_WEEKReady) { _DAY_OF_WEEKContent = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "DAY_OF_WEEK"); _DAY_OF_WEEKReady = true; } return _DAY_OF_WEEKContent; } }
            private static Java.Text.DateFormat.Field _DAY_OF_WEEKContent = default;
            private static bool _DAY_OF_WEEKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#DAY_OF_WEEK_IN_MONTH"/>
            /// </summary>
            public static Java.Text.DateFormat.Field DAY_OF_WEEK_IN_MONTH { get { if (!_DAY_OF_WEEK_IN_MONTHReady) { _DAY_OF_WEEK_IN_MONTHContent = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "DAY_OF_WEEK_IN_MONTH"); _DAY_OF_WEEK_IN_MONTHReady = true; } return _DAY_OF_WEEK_IN_MONTHContent; } }
            private static Java.Text.DateFormat.Field _DAY_OF_WEEK_IN_MONTHContent = default;
            private static bool _DAY_OF_WEEK_IN_MONTHReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#DAY_OF_YEAR"/>
            /// </summary>
            public static Java.Text.DateFormat.Field DAY_OF_YEAR { get { if (!_DAY_OF_YEARReady) { _DAY_OF_YEARContent = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "DAY_OF_YEAR"); _DAY_OF_YEARReady = true; } return _DAY_OF_YEARContent; } }
            private static Java.Text.DateFormat.Field _DAY_OF_YEARContent = default;
            private static bool _DAY_OF_YEARReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#ERA"/>
            /// </summary>
            public static Java.Text.DateFormat.Field ERA { get { if (!_ERAReady) { _ERAContent = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "ERA"); _ERAReady = true; } return _ERAContent; } }
            private static Java.Text.DateFormat.Field _ERAContent = default;
            private static bool _ERAReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#HOUR_OF_DAY0"/>
            /// </summary>
            public static Java.Text.DateFormat.Field HOUR_OF_DAY0 { get { if (!_HOUR_OF_DAY0Ready) { _HOUR_OF_DAY0Content = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "HOUR_OF_DAY0"); _HOUR_OF_DAY0Ready = true; } return _HOUR_OF_DAY0Content; } }
            private static Java.Text.DateFormat.Field _HOUR_OF_DAY0Content = default;
            private static bool _HOUR_OF_DAY0Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#HOUR_OF_DAY1"/>
            /// </summary>
            public static Java.Text.DateFormat.Field HOUR_OF_DAY1 { get { if (!_HOUR_OF_DAY1Ready) { _HOUR_OF_DAY1Content = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "HOUR_OF_DAY1"); _HOUR_OF_DAY1Ready = true; } return _HOUR_OF_DAY1Content; } }
            private static Java.Text.DateFormat.Field _HOUR_OF_DAY1Content = default;
            private static bool _HOUR_OF_DAY1Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#HOUR0"/>
            /// </summary>
            public static Java.Text.DateFormat.Field HOUR0 { get { if (!_HOUR0Ready) { _HOUR0Content = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "HOUR0"); _HOUR0Ready = true; } return _HOUR0Content; } }
            private static Java.Text.DateFormat.Field _HOUR0Content = default;
            private static bool _HOUR0Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#HOUR1"/>
            /// </summary>
            public static Java.Text.DateFormat.Field HOUR1 { get { if (!_HOUR1Ready) { _HOUR1Content = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "HOUR1"); _HOUR1Ready = true; } return _HOUR1Content; } }
            private static Java.Text.DateFormat.Field _HOUR1Content = default;
            private static bool _HOUR1Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#MILLISECOND"/>
            /// </summary>
            public static Java.Text.DateFormat.Field MILLISECOND { get { if (!_MILLISECONDReady) { _MILLISECONDContent = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "MILLISECOND"); _MILLISECONDReady = true; } return _MILLISECONDContent; } }
            private static Java.Text.DateFormat.Field _MILLISECONDContent = default;
            private static bool _MILLISECONDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#MINUTE"/>
            /// </summary>
            public static Java.Text.DateFormat.Field MINUTE { get { if (!_MINUTEReady) { _MINUTEContent = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "MINUTE"); _MINUTEReady = true; } return _MINUTEContent; } }
            private static Java.Text.DateFormat.Field _MINUTEContent = default;
            private static bool _MINUTEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#MONTH"/>
            /// </summary>
            public static Java.Text.DateFormat.Field MONTH { get { if (!_MONTHReady) { _MONTHContent = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "MONTH"); _MONTHReady = true; } return _MONTHContent; } }
            private static Java.Text.DateFormat.Field _MONTHContent = default;
            private static bool _MONTHReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#SECOND"/>
            /// </summary>
            public static Java.Text.DateFormat.Field SECOND { get { if (!_SECONDReady) { _SECONDContent = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "SECOND"); _SECONDReady = true; } return _SECONDContent; } }
            private static Java.Text.DateFormat.Field _SECONDContent = default;
            private static bool _SECONDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#TIME_ZONE"/>
            /// </summary>
            public static Java.Text.DateFormat.Field TIME_ZONE { get { if (!_TIME_ZONEReady) { _TIME_ZONEContent = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "TIME_ZONE"); _TIME_ZONEReady = true; } return _TIME_ZONEContent; } }
            private static Java.Text.DateFormat.Field _TIME_ZONEContent = default;
            private static bool _TIME_ZONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#WEEK_OF_MONTH"/>
            /// </summary>
            public static Java.Text.DateFormat.Field WEEK_OF_MONTH { get { if (!_WEEK_OF_MONTHReady) { _WEEK_OF_MONTHContent = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "WEEK_OF_MONTH"); _WEEK_OF_MONTHReady = true; } return _WEEK_OF_MONTHContent; } }
            private static Java.Text.DateFormat.Field _WEEK_OF_MONTHContent = default;
            private static bool _WEEK_OF_MONTHReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#WEEK_OF_YEAR"/>
            /// </summary>
            public static Java.Text.DateFormat.Field WEEK_OF_YEAR { get { if (!_WEEK_OF_YEARReady) { _WEEK_OF_YEARContent = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "WEEK_OF_YEAR"); _WEEK_OF_YEARReady = true; } return _WEEK_OF_YEARContent; } }
            private static Java.Text.DateFormat.Field _WEEK_OF_YEARContent = default;
            private static bool _WEEK_OF_YEARReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#YEAR"/>
            /// </summary>
            public static Java.Text.DateFormat.Field YEAR { get { if (!_YEARReady) { _YEARContent = SGetField<Java.Text.DateFormat.Field>(LocalBridgeClazz, "YEAR"); _YEARReady = true; } return _YEARContent; } }
            private static Java.Text.DateFormat.Field _YEARContent = default;
            private static bool _YEARReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#ofCalendarField(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Java.Text.DateFormat.Field"/></returns>
            public static Java.Text.DateFormat.Field OfCalendarField(int arg0)
            {
                return SExecuteWithSignature<Java.Text.DateFormat.Field>(LocalBridgeClazz, "ofCalendarField", "(I)Ljava/text/DateFormat$Field;", arg0);
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormat.Field.html#getCalendarField()"/> 
            /// </summary>
            public int CalendarField
            {
                get { return IExecuteWithSignature<int>("getCalendarField", "()I"); }
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