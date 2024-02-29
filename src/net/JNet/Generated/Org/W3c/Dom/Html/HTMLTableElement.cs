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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Html
{
    #region IHTMLTableElement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHTMLTableElement : Org.W3c.Dom.Html.IHTMLElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getAlign()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setAlign(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Align { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getBgColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setBgColor(java.lang.String)"/>
        /// </summary>
        Java.Lang.String BgColor { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setBorder(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Border { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getCaption()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setCaption(org.w3c.dom.html.HTMLTableCaptionElement)"/>
        /// </summary>
        Org.W3c.Dom.Html.HTMLTableCaptionElement Caption { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getCellPadding()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setCellPadding(java.lang.String)"/>
        /// </summary>
        Java.Lang.String CellPadding { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getCellSpacing()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setCellSpacing(java.lang.String)"/>
        /// </summary>
        Java.Lang.String CellSpacing { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getFrame()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setFrame(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Frame { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getRows()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection Rows { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getRules()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setRules(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Rules { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getSummary()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setSummary(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Summary { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getTBodies()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection TBodies { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getTFoot()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setTFoot(org.w3c.dom.html.HTMLTableSectionElement)"/>
        /// </summary>
        Org.W3c.Dom.Html.HTMLTableSectionElement TFoot { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getTHead()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setTHead(org.w3c.dom.html.HTMLTableSectionElement)"/>
        /// </summary>
        Org.W3c.Dom.Html.HTMLTableSectionElement THead { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setWidth(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Width { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#createCaption()"/>
        /// </summary>

        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        Org.W3c.Dom.Html.HTMLElement CreateCaption();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#createTFoot()"/>
        /// </summary>

        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        Org.W3c.Dom.Html.HTMLElement CreateTFoot();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#createTHead()"/>
        /// </summary>

        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        Org.W3c.Dom.Html.HTMLElement CreateTHead();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#insertRow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Html.HTMLElement InsertRow(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteCaption()"/>
        /// </summary>
        void DeleteCaption();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteRow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void DeleteRow(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteTFoot()"/>
        /// </summary>
        void DeleteTFoot();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteTHead()"/>
        /// </summary>
        void DeleteTHead();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HTMLTableElement
    public partial class HTMLTableElement : Org.W3c.Dom.Html.IHTMLTableElement
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getAlign()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setAlign(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Align
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAlign", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setAlign", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getBgColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setBgColor(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String BgColor
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getBgColor", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setBgColor", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setBorder(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Border
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getBorder", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setBorder", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getCaption()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setCaption(org.w3c.dom.html.HTMLTableCaptionElement)"/>
        /// </summary>
        public Org.W3c.Dom.Html.HTMLTableCaptionElement Caption
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLTableCaptionElement>("getCaption", "()Lorg/w3c/dom/html/HTMLTableCaptionElement;"); } set { IExecuteWithSignature("setCaption", "(Lorg/w3c/dom/html/HTMLTableCaptionElement;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getCellPadding()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setCellPadding(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String CellPadding
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCellPadding", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setCellPadding", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getCellSpacing()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setCellSpacing(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String CellSpacing
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCellSpacing", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setCellSpacing", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getFrame()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setFrame(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Frame
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFrame", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setFrame", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getRows()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection Rows
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLCollection>("getRows", "()Lorg/w3c/dom/html/HTMLCollection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getRules()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setRules(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Rules
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRules", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setRules", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getSummary()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setSummary(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Summary
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSummary", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setSummary", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getTBodies()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection TBodies
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLCollection>("getTBodies", "()Lorg/w3c/dom/html/HTMLCollection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getTFoot()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setTFoot(org.w3c.dom.html.HTMLTableSectionElement)"/>
        /// </summary>
        public Org.W3c.Dom.Html.HTMLTableSectionElement TFoot
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLTableSectionElement>("getTFoot", "()Lorg/w3c/dom/html/HTMLTableSectionElement;"); } set { IExecuteWithSignature("setTFoot", "(Lorg/w3c/dom/html/HTMLTableSectionElement;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getTHead()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setTHead(org.w3c.dom.html.HTMLTableSectionElement)"/>
        /// </summary>
        public Org.W3c.Dom.Html.HTMLTableSectionElement THead
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLTableSectionElement>("getTHead", "()Lorg/w3c/dom/html/HTMLTableSectionElement;"); } set { IExecuteWithSignature("setTHead", "(Lorg/w3c/dom/html/HTMLTableSectionElement;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#getWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#setWidth(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Width
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getWidth", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setWidth", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#createCaption()"/>
        /// </summary>

        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        public Org.W3c.Dom.Html.HTMLElement CreateCaption()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLElement>("createCaption", "()Lorg/w3c/dom/html/HTMLElement;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#createTFoot()"/>
        /// </summary>

        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        public Org.W3c.Dom.Html.HTMLElement CreateTFoot()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLElement>("createTFoot", "()Lorg/w3c/dom/html/HTMLElement;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#createTHead()"/>
        /// </summary>

        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        public Org.W3c.Dom.Html.HTMLElement CreateTHead()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLElement>("createTHead", "()Lorg/w3c/dom/html/HTMLElement;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#insertRow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.W3c.Dom.Html.HTMLElement"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Html.HTMLElement InsertRow(int arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLElement>("insertRow", "(I)Lorg/w3c/dom/html/HTMLElement;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteCaption()"/>
        /// </summary>
        public void DeleteCaption()
        {
            IExecuteWithSignature("deleteCaption", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteRow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void DeleteRow(int arg0)
        {
            IExecuteWithSignature("deleteRow", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteTFoot()"/>
        /// </summary>
        public void DeleteTFoot()
        {
            IExecuteWithSignature("deleteTFoot", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLTableElement.html#deleteTHead()"/>
        /// </summary>
        public void DeleteTHead()
        {
            IExecuteWithSignature("deleteTHead", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}