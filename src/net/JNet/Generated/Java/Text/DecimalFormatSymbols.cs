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

namespace Java.Text
{
    #region DecimalFormatSymbols
    public partial class DecimalFormatSymbols
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public DecimalFormatSymbols(Java.Util.Locale arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Text.DecimalFormatSymbols"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Text.DecimalFormatSymbols t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Text.DecimalFormatSymbols"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Text.DecimalFormatSymbols t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getAvailableLocales()"/> 
        /// </summary>
        public static Java.Util.Locale[] AvailableLocales
        {
            get { return SExecuteArray<Java.Util.Locale>("getAvailableLocales"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getInstance()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Text.DecimalFormatSymbols"/></returns>
        public static Java.Text.DecimalFormatSymbols GetInstance()
        {
            return SExecute<Java.Text.DecimalFormatSymbols>("getInstance");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.DecimalFormatSymbols"/></returns>
        public static Java.Text.DecimalFormatSymbols GetInstance(Java.Util.Locale arg0)
        {
            return SExecute<Java.Text.DecimalFormatSymbols>("getInstance", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getCurrency()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setCurrency(java.util.Currency)"/>
        /// </summary>
        public Java.Util.Currency Currency
        {
            get { return IExecute<Java.Util.Currency>("getCurrency"); } set { IExecute("setCurrency", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getCurrencySymbol()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setCurrencySymbol(java.lang.String)"/>
        /// </summary>
        public string CurrencySymbol
        {
            get { return IExecute<string>("getCurrencySymbol"); } set { IExecute("setCurrencySymbol", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getDecimalSeparator()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setDecimalSeparator(char)"/>
        /// </summary>
        public char DecimalSeparator
        {
            get { return IExecute<char>("getDecimalSeparator"); } set { IExecute("setDecimalSeparator", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getDigit()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setDigit(char)"/>
        /// </summary>
        public char Digit
        {
            get { return IExecute<char>("getDigit"); } set { IExecute("setDigit", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getExponentSeparator()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setExponentSeparator(java.lang.String)"/>
        /// </summary>
        public string ExponentSeparator
        {
            get { return IExecute<string>("getExponentSeparator"); } set { IExecute("setExponentSeparator", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getGroupingSeparator()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setGroupingSeparator(char)"/>
        /// </summary>
        public char GroupingSeparator
        {
            get { return IExecute<char>("getGroupingSeparator"); } set { IExecute("setGroupingSeparator", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getInfinity()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setInfinity(java.lang.String)"/>
        /// </summary>
        public string Infinity
        {
            get { return IExecute<string>("getInfinity"); } set { IExecute("setInfinity", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getInternationalCurrencySymbol()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setInternationalCurrencySymbol(java.lang.String)"/>
        /// </summary>
        public string InternationalCurrencySymbol
        {
            get { return IExecute<string>("getInternationalCurrencySymbol"); } set { IExecute("setInternationalCurrencySymbol", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getMinusSign()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setMinusSign(char)"/>
        /// </summary>
        public char MinusSign
        {
            get { return IExecute<char>("getMinusSign"); } set { IExecute("setMinusSign", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getMonetaryDecimalSeparator()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setMonetaryDecimalSeparator(char)"/>
        /// </summary>
        public char MonetaryDecimalSeparator
        {
            get { return IExecute<char>("getMonetaryDecimalSeparator"); } set { IExecute("setMonetaryDecimalSeparator", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getNaN()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setNaN(java.lang.String)"/>
        /// </summary>
        public string NaN
        {
            get { return IExecute<string>("getNaN"); } set { IExecute("setNaN", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getPatternSeparator()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setPatternSeparator(char)"/>
        /// </summary>
        public char PatternSeparator
        {
            get { return IExecute<char>("getPatternSeparator"); } set { IExecute("setPatternSeparator", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getPercent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setPercent(char)"/>
        /// </summary>
        public char Percent
        {
            get { return IExecute<char>("getPercent"); } set { IExecute("setPercent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getPerMill()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setPerMill(char)"/>
        /// </summary>
        public char PerMill
        {
            get { return IExecute<char>("getPerMill"); } set { IExecute("setPerMill", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getZeroDigit()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setZeroDigit(char)"/>
        /// </summary>
        public char ZeroDigit
        {
            get { return IExecute<char>("getZeroDigit"); } set { IExecute("setZeroDigit", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}