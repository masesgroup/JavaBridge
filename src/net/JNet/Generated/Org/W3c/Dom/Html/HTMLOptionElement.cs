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

namespace Org.W3c.Dom.Html
{
    #region IHTMLOptionElement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHTMLOptionElement : Org.W3c.Dom.Html.IHTMLElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getDefaultSelected()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#setDefaultSelected(boolean)"/>
        /// </summary>
        bool DefaultSelected { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getDisabled()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#setDisabled(boolean)"/>
        /// </summary>
        bool Disabled { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getForm()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLFormElement Form { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getIndex()"/> 
        /// </summary>
        int Index { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getLabel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#setLabel(java.lang.String)"/>
        /// </summary>
        string Label { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getSelected()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#setSelected(boolean)"/>
        /// </summary>
        bool Selected { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getText()"/> 
        /// </summary>
        string Text { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#setValue(java.lang.String)"/>
        /// </summary>
        string Value { get; set; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HTMLOptionElement
    public partial class HTMLOptionElement : Org.W3c.Dom.Html.IHTMLOptionElement
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getDefaultSelected()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#setDefaultSelected(boolean)"/>
        /// </summary>
        public bool DefaultSelected
        {
            get { return IExecute<bool>("getDefaultSelected"); } set { IExecute("setDefaultSelected", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getDisabled()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#setDisabled(boolean)"/>
        /// </summary>
        public bool Disabled
        {
            get { return IExecute<bool>("getDisabled"); } set { IExecute("setDisabled", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getForm()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLFormElement Form
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLFormElement>("getForm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getIndex()"/> 
        /// </summary>
        public int Index
        {
            get { return IExecute<int>("getIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getLabel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#setLabel(java.lang.String)"/>
        /// </summary>
        public string Label
        {
            get { return IExecute<string>("getLabel"); } set { IExecute("setLabel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getSelected()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#setSelected(boolean)"/>
        /// </summary>
        public bool Selected
        {
            get { return IExecute<bool>("getSelected"); } set { IExecute("setSelected", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getText()"/> 
        /// </summary>
        public string Text
        {
            get { return IExecute<string>("getText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLOptionElement.html#setValue(java.lang.String)"/>
        /// </summary>
        public string Value
        {
            get { return IExecute<string>("getValue"); } set { IExecute("setValue", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}