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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Html
{
    #region IHTMLLinkElement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHTMLLinkElement : Org.W3c.Dom.Html.IHTMLElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getCharset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setCharset(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Charset { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getDisabled()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setDisabled(boolean)"/>
        /// </summary>
        bool Disabled { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getHref()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setHref(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Href { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getHreflang()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setHreflang(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Hreflang { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getMedia()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setMedia(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Media { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getRel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setRel(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Rel { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getRev()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setRev(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Rev { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getTarget()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setTarget(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Target { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setType(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Type { get; set; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HTMLLinkElement
    public partial class HTMLLinkElement : Org.W3c.Dom.Html.IHTMLLinkElement
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getCharset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setCharset(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Charset
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCharset", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setCharset", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getDisabled()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setDisabled(boolean)"/>
        /// </summary>
        public bool Disabled
        {
            get { return IExecuteWithSignature<bool>("getDisabled", "()Z"); } set { IExecuteWithSignature("setDisabled", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getHref()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setHref(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Href
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHref", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setHref", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getHreflang()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setHreflang(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Hreflang
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHreflang", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setHreflang", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getMedia()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setMedia(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Media
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMedia", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setMedia", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getRel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setRel(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Rel
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRel", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setRel", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getRev()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setRev(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Rev
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRev", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setRev", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getTarget()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setTarget(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Target
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTarget", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setTarget", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#getType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLLinkElement.html#setType(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Type
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getType", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setType", "(Ljava/lang/String;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}