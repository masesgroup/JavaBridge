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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Html
{
    #region IHTMLInputElement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHTMLInputElement : Org.W3c.Dom.Html.IHTMLElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getAccept()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setAccept(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Accept { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getAccessKey()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setAccessKey(java.lang.String)"/>
        /// </summary>
        Java.Lang.String AccessKey { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getAlign()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setAlign(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Align { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getAlt()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setAlt(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Alt { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getChecked()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setChecked(boolean)"/>
        /// </summary>
        bool Checked { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getDefaultChecked()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setDefaultChecked(boolean)"/>
        /// </summary>
        bool DefaultChecked { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getDefaultValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setDefaultValue(java.lang.String)"/>
        /// </summary>
        Java.Lang.String DefaultValue { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getDisabled()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setDisabled(boolean)"/>
        /// </summary>
        bool Disabled { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getForm()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLFormElement Form { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getMaxLength()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setMaxLength(int)"/>
        /// </summary>
        int MaxLength { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setName(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Name { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getReadOnly()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setReadOnly(boolean)"/>
        /// </summary>
        bool ReadOnly { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setSize(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Size { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getSrc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setSrc(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Src { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getTabIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setTabIndex(int)"/>
        /// </summary>
        int TabIndex { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getType()"/> 
        /// </summary>
        Java.Lang.String Type { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getUseMap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setUseMap(java.lang.String)"/>
        /// </summary>
        Java.Lang.String UseMap { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setValue(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Value { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#blur()"/>
        /// </summary>
        void Blur();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#click()"/>
        /// </summary>
        void Click();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#focus()"/>
        /// </summary>
        void Focus();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#select()"/>
        /// </summary>
        void Select();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HTMLInputElement
    public partial class HTMLInputElement : Org.W3c.Dom.Html.IHTMLInputElement
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getAccept()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setAccept(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Accept
        {
            get { return IExecute<Java.Lang.String>("getAccept"); } set { IExecute("setAccept", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getAccessKey()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setAccessKey(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String AccessKey
        {
            get { return IExecute<Java.Lang.String>("getAccessKey"); } set { IExecute("setAccessKey", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getAlign()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setAlign(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Align
        {
            get { return IExecute<Java.Lang.String>("getAlign"); } set { IExecute("setAlign", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getAlt()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setAlt(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Alt
        {
            get { return IExecute<Java.Lang.String>("getAlt"); } set { IExecute("setAlt", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getChecked()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setChecked(boolean)"/>
        /// </summary>
        public bool Checked
        {
            get { return IExecute<bool>("getChecked"); } set { IExecute("setChecked", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getDefaultChecked()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setDefaultChecked(boolean)"/>
        /// </summary>
        public bool DefaultChecked
        {
            get { return IExecute<bool>("getDefaultChecked"); } set { IExecute("setDefaultChecked", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getDefaultValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setDefaultValue(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String DefaultValue
        {
            get { return IExecute<Java.Lang.String>("getDefaultValue"); } set { IExecute("setDefaultValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getDisabled()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setDisabled(boolean)"/>
        /// </summary>
        public bool Disabled
        {
            get { return IExecute<bool>("getDisabled"); } set { IExecute("setDisabled", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getForm()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLFormElement Form
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLFormElement>("getForm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getMaxLength()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setMaxLength(int)"/>
        /// </summary>
        public int MaxLength
        {
            get { return IExecute<int>("getMaxLength"); } set { IExecute("setMaxLength", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecute<Java.Lang.String>("getName"); } set { IExecute("setName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getReadOnly()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setReadOnly(boolean)"/>
        /// </summary>
        public bool ReadOnly
        {
            get { return IExecute<bool>("getReadOnly"); } set { IExecute("setReadOnly", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setSize(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Size
        {
            get { return IExecute<Java.Lang.String>("getSize"); } set { IExecute("setSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getSrc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setSrc(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Src
        {
            get { return IExecute<Java.Lang.String>("getSrc"); } set { IExecute("setSrc", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getTabIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setTabIndex(int)"/>
        /// </summary>
        public int TabIndex
        {
            get { return IExecute<int>("getTabIndex"); } set { IExecute("setTabIndex", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getType()"/> 
        /// </summary>
        public Java.Lang.String Type
        {
            get { return IExecute<Java.Lang.String>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getUseMap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setUseMap(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String UseMap
        {
            get { return IExecute<Java.Lang.String>("getUseMap"); } set { IExecute("setUseMap", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setValue(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Value
        {
            get { return IExecute<Java.Lang.String>("getValue"); } set { IExecute("setValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#blur()"/>
        /// </summary>
        public void Blur()
        {
            IExecute("blur");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#click()"/>
        /// </summary>
        public void Click()
        {
            IExecute("click");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#focus()"/>
        /// </summary>
        public void Focus()
        {
            IExecute("focus");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#select()"/>
        /// </summary>
        public void Select()
        {
            IExecute("select");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}