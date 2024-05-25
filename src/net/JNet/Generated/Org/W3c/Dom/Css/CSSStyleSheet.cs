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
    #region ICSSStyleSheet
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICSSStyleSheet : Org.W3c.Dom.Stylesheets.IStyleSheet
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSStyleSheet.html#getCssRules()"/> 
        /// </summary>
        Org.W3c.Dom.Css.CSSRuleList CssRules { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSStyleSheet.html#getOwnerRule()"/> 
        /// </summary>
        Org.W3c.Dom.Css.CSSRule OwnerRule { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSStyleSheet.html#insertRule(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        int InsertRule(Java.Lang.String arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSStyleSheet.html#deleteRule(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void DeleteRule(int arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CSSStyleSheet
    public partial class CSSStyleSheet : Org.W3c.Dom.Css.ICSSStyleSheet
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSStyleSheet.html#getCssRules()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.CSSRuleList CssRules
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Css.CSSRuleList>("getCssRules", "()Lorg/w3c/dom/css/CSSRuleList;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSStyleSheet.html#getOwnerRule()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.CSSRule OwnerRule
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Css.CSSRule>("getOwnerRule", "()Lorg/w3c/dom/css/CSSRule;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSStyleSheet.html#insertRule(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public int InsertRule(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("insertRule", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSStyleSheet.html#deleteRule(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void DeleteRule(int arg0)
        {
            IExecuteWithSignature("deleteRule", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}