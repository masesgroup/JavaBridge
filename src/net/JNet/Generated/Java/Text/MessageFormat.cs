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

namespace Java.Text
{
    #region MessageFormat
    public partial class MessageFormat
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#%3Cinit%3E(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        public MessageFormat(string arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public MessageFormat(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#format(java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="string"/></returns>
        public static string Format(string arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return SExecute<string>(LocalBridgeClazz, "format", arg0); else return SExecute<string>(LocalBridgeClazz, "format", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#getFormats()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#setFormats(java.text.Format[])"/>
        /// </summary>
        public Java.Text.Format[] Formats
        {
            get { return IExecuteArray<Java.Text.Format>("getFormats"); } set { IExecute("setFormats", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#getFormatsByArgumentIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#setFormatsByArgumentIndex(java.text.Format[])"/>
        /// </summary>
        public Java.Text.Format[] FormatsByArgumentIndex
        {
            get { return IExecuteArray<Java.Text.Format>("getFormatsByArgumentIndex"); } set { IExecute("setFormatsByArgumentIndex", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#getLocale()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#setLocale(java.util.Locale)"/>
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecute<Java.Util.Locale>("getLocale"); } set { IExecute("setLocale", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#format(java.lang.Object[],java.lang.StringBuffer,java.text.FieldPosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.StringBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Text.FieldPosition"/></param>
        /// <returns><see cref="Java.Lang.StringBuffer"/></returns>
        public Java.Lang.StringBuffer Format(object[] arg0, Java.Lang.StringBuffer arg1, Java.Text.FieldPosition arg2)
        {
            return IExecute<Java.Lang.StringBuffer>("format", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#parse(java.lang.String,java.text.ParsePosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Text.ParsePosition"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] Parse(string arg0, Java.Text.ParsePosition arg1)
        {
            return IExecuteArray<object>("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Text.ParseException"/>
        public object[] Parse(string arg0)
        {
            return IExecuteArray<object>("parse", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#toPattern()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ToPattern()
        {
            return IExecute<string>("toPattern");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#applyPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void ApplyPattern(string arg0)
        {
            IExecute("applyPattern", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#setFormat(int,java.text.Format)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Text.Format"/></param>
        public void SetFormat(int arg0, Java.Text.Format arg1)
        {
            IExecute("setFormat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#setFormatByArgumentIndex(int,java.text.Format)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Text.Format"/></param>
        public void SetFormatByArgumentIndex(int arg0, Java.Text.Format arg1)
        {
            IExecute("setFormatByArgumentIndex", arg0, arg1);
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.Field.html#ARGUMENT"/>
            /// </summary>
            public static Java.Text.MessageFormat.Field ARGUMENT { get { return SGetField<Java.Text.MessageFormat.Field>(LocalBridgeClazz, "ARGUMENT"); } }

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