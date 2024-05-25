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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Css
{
    #region ICSSRule
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICSSRule
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#getCssText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#setCssText(java.lang.String)"/>
        /// </summary>
        Java.Lang.String CssText { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#getParentRule()"/> 
        /// </summary>
        Org.W3c.Dom.Css.CSSRule ParentRule { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#getParentStyleSheet()"/> 
        /// </summary>
        Org.W3c.Dom.Css.CSSStyleSheet ParentStyleSheet { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#getType()"/> 
        /// </summary>
        short Type { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CSSRule
    public partial class CSSRule : Org.W3c.Dom.Css.ICSSRule
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#CHARSET_RULE"/>
        /// </summary>
        public static short CHARSET_RULE { get { if (!_CHARSET_RULEReady) { _CHARSET_RULEContent = SGetField<short>(LocalBridgeClazz, "CHARSET_RULE"); _CHARSET_RULEReady = true; } return _CHARSET_RULEContent; } }
        private static short _CHARSET_RULEContent = default;
        private static bool _CHARSET_RULEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#FONT_FACE_RULE"/>
        /// </summary>
        public static short FONT_FACE_RULE { get { if (!_FONT_FACE_RULEReady) { _FONT_FACE_RULEContent = SGetField<short>(LocalBridgeClazz, "FONT_FACE_RULE"); _FONT_FACE_RULEReady = true; } return _FONT_FACE_RULEContent; } }
        private static short _FONT_FACE_RULEContent = default;
        private static bool _FONT_FACE_RULEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#IMPORT_RULE"/>
        /// </summary>
        public static short IMPORT_RULE { get { if (!_IMPORT_RULEReady) { _IMPORT_RULEContent = SGetField<short>(LocalBridgeClazz, "IMPORT_RULE"); _IMPORT_RULEReady = true; } return _IMPORT_RULEContent; } }
        private static short _IMPORT_RULEContent = default;
        private static bool _IMPORT_RULEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#MEDIA_RULE"/>
        /// </summary>
        public static short MEDIA_RULE { get { if (!_MEDIA_RULEReady) { _MEDIA_RULEContent = SGetField<short>(LocalBridgeClazz, "MEDIA_RULE"); _MEDIA_RULEReady = true; } return _MEDIA_RULEContent; } }
        private static short _MEDIA_RULEContent = default;
        private static bool _MEDIA_RULEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#PAGE_RULE"/>
        /// </summary>
        public static short PAGE_RULE { get { if (!_PAGE_RULEReady) { _PAGE_RULEContent = SGetField<short>(LocalBridgeClazz, "PAGE_RULE"); _PAGE_RULEReady = true; } return _PAGE_RULEContent; } }
        private static short _PAGE_RULEContent = default;
        private static bool _PAGE_RULEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#STYLE_RULE"/>
        /// </summary>
        public static short STYLE_RULE { get { if (!_STYLE_RULEReady) { _STYLE_RULEContent = SGetField<short>(LocalBridgeClazz, "STYLE_RULE"); _STYLE_RULEReady = true; } return _STYLE_RULEContent; } }
        private static short _STYLE_RULEContent = default;
        private static bool _STYLE_RULEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#UNKNOWN_RULE"/>
        /// </summary>
        public static short UNKNOWN_RULE { get { if (!_UNKNOWN_RULEReady) { _UNKNOWN_RULEContent = SGetField<short>(LocalBridgeClazz, "UNKNOWN_RULE"); _UNKNOWN_RULEReady = true; } return _UNKNOWN_RULEContent; } }
        private static short _UNKNOWN_RULEContent = default;
        private static bool _UNKNOWN_RULEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#getCssText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#setCssText(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String CssText
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCssText", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setCssText", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#getParentRule()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.CSSRule ParentRule
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Css.CSSRule>("getParentRule", "()Lorg/w3c/dom/css/CSSRule;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#getParentStyleSheet()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.CSSStyleSheet ParentStyleSheet
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Css.CSSStyleSheet>("getParentStyleSheet", "()Lorg/w3c/dom/css/CSSStyleSheet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#getType()"/> 
        /// </summary>
        public short Type
        {
            get { return IExecuteWithSignature<short>("getType", "()S"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}