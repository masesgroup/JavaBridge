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

namespace Java.Text
{
    #region NumberFormat
    public partial class NumberFormat
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#FRACTION_FIELD"/>
        /// </summary>
        public static int FRACTION_FIELD { get { if (!_FRACTION_FIELDReady) { _FRACTION_FIELDContent = SGetField<int>(LocalBridgeClazz, "FRACTION_FIELD"); _FRACTION_FIELDReady = true; } return _FRACTION_FIELDContent; } }
        private static int _FRACTION_FIELDContent = default;
        private static bool _FRACTION_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#INTEGER_FIELD"/>
        /// </summary>
        public static int INTEGER_FIELD { get { if (!_INTEGER_FIELDReady) { _INTEGER_FIELDContent = SGetField<int>(LocalBridgeClazz, "INTEGER_FIELD"); _INTEGER_FIELDReady = true; } return _INTEGER_FIELDContent; } }
        private static int _INTEGER_FIELDContent = default;
        private static bool _INTEGER_FIELDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getAvailableLocales()"/> 
        /// </summary>
        public static Java.Util.Locale[] AvailableLocales
        {
            get { return SExecuteWithSignatureArray<Java.Util.Locale>(LocalBridgeClazz, "getAvailableLocales", "()[Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getCurrencyInstance()"/> 
        /// </summary>
        public static Java.Text.NumberFormat CurrencyInstance
        {
            get { return SExecuteWithSignature<Java.Text.NumberFormat>(LocalBridgeClazz, "getCurrencyInstance", "()Ljava/text/NumberFormat;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getInstance()"/> 
        /// </summary>
        public static Java.Text.NumberFormat Instance
        {
            get { return SExecuteWithSignature<Java.Text.NumberFormat>(LocalBridgeClazz, "getInstance", "()Ljava/text/NumberFormat;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getIntegerInstance()"/> 
        /// </summary>
        public static Java.Text.NumberFormat IntegerInstance
        {
            get { return SExecuteWithSignature<Java.Text.NumberFormat>(LocalBridgeClazz, "getIntegerInstance", "()Ljava/text/NumberFormat;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getNumberInstance()"/> 
        /// </summary>
        public static Java.Text.NumberFormat NumberInstance
        {
            get { return SExecuteWithSignature<Java.Text.NumberFormat>(LocalBridgeClazz, "getNumberInstance", "()Ljava/text/NumberFormat;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getPercentInstance()"/> 
        /// </summary>
        public static Java.Text.NumberFormat PercentInstance
        {
            get { return SExecuteWithSignature<Java.Text.NumberFormat>(LocalBridgeClazz, "getPercentInstance", "()Ljava/text/NumberFormat;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getCurrencyInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.NumberFormat"/></returns>
        public static Java.Text.NumberFormat GetCurrencyInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Text.NumberFormat>(LocalBridgeClazz, "getCurrencyInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.NumberFormat"/></returns>
        public static Java.Text.NumberFormat GetInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Text.NumberFormat>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getIntegerInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.NumberFormat"/></returns>
        public static Java.Text.NumberFormat GetIntegerInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Text.NumberFormat>(LocalBridgeClazz, "getIntegerInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getNumberInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.NumberFormat"/></returns>
        public static Java.Text.NumberFormat GetNumberInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Text.NumberFormat>(LocalBridgeClazz, "getNumberInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getPercentInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.NumberFormat"/></returns>
        public static Java.Text.NumberFormat GetPercentInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Text.NumberFormat>(LocalBridgeClazz, "getPercentInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getCurrency()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setCurrency(java.util.Currency)"/>
        /// </summary>
        public Java.Util.Currency Currency
        {
            get { return IExecuteWithSignature<Java.Util.Currency>("getCurrency", "()Ljava/util/Currency;"); } set { IExecuteWithSignature("setCurrency", "(Ljava/util/Currency;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getMaximumFractionDigits()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setMaximumFractionDigits(int)"/>
        /// </summary>
        public int MaximumFractionDigits
        {
            get { return IExecuteWithSignature<int>("getMaximumFractionDigits", "()I"); } set { IExecuteWithSignature("setMaximumFractionDigits", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getMaximumIntegerDigits()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setMaximumIntegerDigits(int)"/>
        /// </summary>
        public int MaximumIntegerDigits
        {
            get { return IExecuteWithSignature<int>("getMaximumIntegerDigits", "()I"); } set { IExecuteWithSignature("setMaximumIntegerDigits", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getMinimumFractionDigits()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setMinimumFractionDigits(int)"/>
        /// </summary>
        public int MinimumFractionDigits
        {
            get { return IExecuteWithSignature<int>("getMinimumFractionDigits", "()I"); } set { IExecuteWithSignature("setMinimumFractionDigits", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getMinimumIntegerDigits()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setMinimumIntegerDigits(int)"/>
        /// </summary>
        public int MinimumIntegerDigits
        {
            get { return IExecuteWithSignature<int>("getMinimumIntegerDigits", "()I"); } set { IExecuteWithSignature("setMinimumIntegerDigits", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#getRoundingMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setRoundingMode(java.math.RoundingMode)"/>
        /// </summary>
        public Java.Math.RoundingMode RoundingMode
        {
            get { return IExecuteWithSignature<Java.Math.RoundingMode>("getRoundingMode", "()Ljava/math/RoundingMode;"); } set { IExecuteWithSignature("setRoundingMode", "(Ljava/math/RoundingMode;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#parse(java.lang.String,java.text.ParsePosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Text.ParsePosition"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        public Java.Lang.Number Parse(Java.Lang.String arg0, Java.Text.ParsePosition arg1)
        {
            return IExecute<Java.Lang.Number>("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#format(double,java.lang.StringBuffer,java.text.FieldPosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="Java.Lang.StringBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Text.FieldPosition"/></param>
        /// <returns><see cref="Java.Lang.StringBuffer"/></returns>
        public Java.Lang.StringBuffer Format(double arg0, Java.Lang.StringBuffer arg1, Java.Text.FieldPosition arg2)
        {
            return IExecute<Java.Lang.StringBuffer>("format", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#format(long,java.lang.StringBuffer,java.text.FieldPosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.StringBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Text.FieldPosition"/></param>
        /// <returns><see cref="Java.Lang.StringBuffer"/></returns>
        public Java.Lang.StringBuffer Format(long arg0, Java.Lang.StringBuffer arg1, Java.Text.FieldPosition arg2)
        {
            return IExecute<Java.Lang.StringBuffer>("format", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#isGroupingUsed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsGroupingUsed()
        {
            return IExecuteWithSignature<bool>("isGroupingUsed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#isParseIntegerOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsParseIntegerOnly()
        {
            return IExecuteWithSignature<bool>("isParseIntegerOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#format(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(double arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(D)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#format(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(long arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(J)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        /// <exception cref="Java.Text.ParseException"/>
        public Java.Lang.Number Parse(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Number>("parse", "(Ljava/lang/String;)Ljava/lang/Number;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setGroupingUsed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetGroupingUsed(bool arg0)
        {
            IExecuteWithSignature("setGroupingUsed", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.html#setParseIntegerOnly(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetParseIntegerOnly(bool arg0)
        {
            IExecuteWithSignature("setParseIntegerOnly", "(Z)V", arg0);
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#CURRENCY"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field CURRENCY { get { if (!_CURRENCYReady) { _CURRENCYContent = SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "CURRENCY"); _CURRENCYReady = true; } return _CURRENCYContent; } }
            private static Java.Text.NumberFormat.Field _CURRENCYContent = default;
            private static bool _CURRENCYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#DECIMAL_SEPARATOR"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field DECIMAL_SEPARATOR { get { if (!_DECIMAL_SEPARATORReady) { _DECIMAL_SEPARATORContent = SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "DECIMAL_SEPARATOR"); _DECIMAL_SEPARATORReady = true; } return _DECIMAL_SEPARATORContent; } }
            private static Java.Text.NumberFormat.Field _DECIMAL_SEPARATORContent = default;
            private static bool _DECIMAL_SEPARATORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#EXPONENT"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field EXPONENT { get { if (!_EXPONENTReady) { _EXPONENTContent = SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "EXPONENT"); _EXPONENTReady = true; } return _EXPONENTContent; } }
            private static Java.Text.NumberFormat.Field _EXPONENTContent = default;
            private static bool _EXPONENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#EXPONENT_SIGN"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field EXPONENT_SIGN { get { if (!_EXPONENT_SIGNReady) { _EXPONENT_SIGNContent = SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "EXPONENT_SIGN"); _EXPONENT_SIGNReady = true; } return _EXPONENT_SIGNContent; } }
            private static Java.Text.NumberFormat.Field _EXPONENT_SIGNContent = default;
            private static bool _EXPONENT_SIGNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#EXPONENT_SYMBOL"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field EXPONENT_SYMBOL { get { if (!_EXPONENT_SYMBOLReady) { _EXPONENT_SYMBOLContent = SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "EXPONENT_SYMBOL"); _EXPONENT_SYMBOLReady = true; } return _EXPONENT_SYMBOLContent; } }
            private static Java.Text.NumberFormat.Field _EXPONENT_SYMBOLContent = default;
            private static bool _EXPONENT_SYMBOLReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#FRACTION"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field FRACTION { get { if (!_FRACTIONReady) { _FRACTIONContent = SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "FRACTION"); _FRACTIONReady = true; } return _FRACTIONContent; } }
            private static Java.Text.NumberFormat.Field _FRACTIONContent = default;
            private static bool _FRACTIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#GROUPING_SEPARATOR"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field GROUPING_SEPARATOR { get { if (!_GROUPING_SEPARATORReady) { _GROUPING_SEPARATORContent = SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "GROUPING_SEPARATOR"); _GROUPING_SEPARATORReady = true; } return _GROUPING_SEPARATORContent; } }
            private static Java.Text.NumberFormat.Field _GROUPING_SEPARATORContent = default;
            private static bool _GROUPING_SEPARATORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#INTEGER"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field INTEGER { get { if (!_INTEGERReady) { _INTEGERContent = SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "INTEGER"); _INTEGERReady = true; } return _INTEGERContent; } }
            private static Java.Text.NumberFormat.Field _INTEGERContent = default;
            private static bool _INTEGERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#PERCENT"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field PERCENT { get { if (!_PERCENTReady) { _PERCENTContent = SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "PERCENT"); _PERCENTReady = true; } return _PERCENTContent; } }
            private static Java.Text.NumberFormat.Field _PERCENTContent = default;
            private static bool _PERCENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#PERMILLE"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field PERMILLE { get { if (!_PERMILLEReady) { _PERMILLEContent = SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "PERMILLE"); _PERMILLEReady = true; } return _PERMILLEContent; } }
            private static Java.Text.NumberFormat.Field _PERMILLEContent = default;
            private static bool _PERMILLEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/NumberFormat.Field.html#SIGN"/>
            /// </summary>
            public static Java.Text.NumberFormat.Field SIGN { get { if (!_SIGNReady) { _SIGNContent = SGetField<Java.Text.NumberFormat.Field>(LocalBridgeClazz, "SIGN"); _SIGNReady = true; } return _SIGNContent; } }
            private static Java.Text.NumberFormat.Field _SIGNContent = default;
            private static bool _SIGNReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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