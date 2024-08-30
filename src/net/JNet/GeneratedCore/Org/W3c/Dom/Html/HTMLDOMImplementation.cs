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
    #region IHTMLDOMImplementation
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHTMLDOMImplementation : Org.W3c.Dom.IDOMImplementation
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDOMImplementation.html#createHTMLDocument(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Html.HTMLDocument"/></returns>
        Org.W3c.Dom.Html.HTMLDocument CreateHTMLDocument(Java.Lang.String arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HTMLDOMImplementation
    public partial class HTMLDOMImplementation : Org.W3c.Dom.Html.IHTMLDOMImplementation
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDOMImplementation.html#createHTMLDocument(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Html.HTMLDocument"/></returns>
        public Org.W3c.Dom.Html.HTMLDocument CreateHTMLDocument(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLDocument>("createHTMLDocument", "(Ljava/lang/String;)Lorg/w3c/dom/html/HTMLDocument;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}