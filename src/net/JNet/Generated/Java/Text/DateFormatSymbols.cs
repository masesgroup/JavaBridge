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
    #region DateFormatSymbols
    public partial class DateFormatSymbols
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public DateFormatSymbols(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Text.DateFormatSymbols"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Text.DateFormatSymbols t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Text.DateFormatSymbols"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Text.DateFormatSymbols t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getAvailableLocales()"/> 
        /// </summary>
        public static Java.Util.Locale[] AvailableLocales
        {
            get { return SExecuteWithSignatureArray<Java.Util.Locale>(LocalBridgeClazz, "getAvailableLocales", "()[Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getInstance()"/> 
        /// </summary>
        public static Java.Text.DateFormatSymbols Instance
        {
            get { return SExecuteWithSignature<Java.Text.DateFormatSymbols>(LocalBridgeClazz, "getInstance", "()Ljava/text/DateFormatSymbols;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.DateFormatSymbols"/></returns>
        public static Java.Text.DateFormatSymbols GetInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Text.DateFormatSymbols>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;)Ljava/text/DateFormatSymbols;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getAmPmStrings()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setAmPmStrings(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] AmPmStrings
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getAmPmStrings", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setAmPmStrings", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getEras()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setEras(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] Eras
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getEras", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setEras", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getLocalPatternChars()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setLocalPatternChars(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String LocalPatternChars
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLocalPatternChars", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setLocalPatternChars", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getMonths()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setMonths(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] Months
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getMonths", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setMonths", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getShortMonths()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setShortMonths(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] ShortMonths
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getShortMonths", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setShortMonths", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getShortWeekdays()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setShortWeekdays(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] ShortWeekdays
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getShortWeekdays", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setShortWeekdays", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getWeekdays()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setWeekdays(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] Weekdays
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getWeekdays", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setWeekdays", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#getZoneStrings()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DateFormatSymbols.html#setZoneStrings(java.lang.String[][])"/>
        /// </summary>
        public Java.Lang.String[] ZoneStrings
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getZoneStrings", "()[[Ljava/lang/String;"); } set { IExecuteWithSignature("setZoneStrings", "([[Ljava/lang/String;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}