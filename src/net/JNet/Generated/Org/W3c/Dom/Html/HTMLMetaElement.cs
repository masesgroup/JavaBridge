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

namespace Org.W3c.Dom.Html
{
    #region HTMLMetaElement
    public partial class HTMLMetaElement
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.W3c.Dom.Html.HTMLMetaElement"/> to <see cref="Org.W3c.Dom.Html.HTMLElement"/>
        /// </summary>
        public static implicit operator Org.W3c.Dom.Html.HTMLElement(Org.W3c.Dom.Html.HTMLMetaElement t) => t.Cast<Org.W3c.Dom.Html.HTMLElement>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLMetaElement.html#getContent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLMetaElement.html#setContent(java.lang.String)"/>
        /// </summary>
        public string Content
        {
            get { return IExecute<string>("getContent"); } set { IExecute("setContent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLMetaElement.html#getHttpEquiv()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLMetaElement.html#setHttpEquiv(java.lang.String)"/>
        /// </summary>
        public string HttpEquiv
        {
            get { return IExecute<string>("getHttpEquiv"); } set { IExecute("setHttpEquiv", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLMetaElement.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLMetaElement.html#setName(java.lang.String)"/>
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); } set { IExecute("setName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLMetaElement.html#getScheme()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLMetaElement.html#setScheme(java.lang.String)"/>
        /// </summary>
        public string Scheme
        {
            get { return IExecute<string>("getScheme"); } set { IExecute("setScheme", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}