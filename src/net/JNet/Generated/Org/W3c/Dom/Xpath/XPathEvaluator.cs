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

namespace Org.W3c.Dom.Xpath
{
    #region XPathEvaluator
    public partial class XPathEvaluator
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathEvaluator.html#evaluate(java.lang.String,org.w3c.dom.Node,org.w3c.dom.xpath.XPathNSResolver,short,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg2"><see cref="Org.W3c.Dom.Xpath.XPathNSResolver"/></param>
        /// <param name="arg3"><see langword="short"/></param>
        /// <param name="arg4"><see langword="object"/></param>
        /// <returns><see langword="object"/></returns>
        /// <exception cref="Org.W3c.Dom.Xpath.XPathException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public object Evaluate(string arg0, Org.W3c.Dom.Node arg1, Org.W3c.Dom.Xpath.XPathNSResolver arg2, short arg3, object arg4)
        {
            return IExecute("evaluate", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathEvaluator.html#createExpression(java.lang.String,org.w3c.dom.xpath.XPathNSResolver)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Xpath.XPathNSResolver"/></param>
        /// <returns><see cref="Org.W3c.Dom.Xpath.XPathExpression"/></returns>
        /// <exception cref="Org.W3c.Dom.Xpath.XPathException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Xpath.XPathExpression CreateExpression(string arg0, Org.W3c.Dom.Xpath.XPathNSResolver arg1)
        {
            return IExecute<Org.W3c.Dom.Xpath.XPathExpression>("createExpression", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathEvaluator.html#createNSResolver(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Xpath.XPathNSResolver"/></returns>
        public Org.W3c.Dom.Xpath.XPathNSResolver CreateNSResolver(Org.W3c.Dom.Node arg0)
        {
            return IExecute<Org.W3c.Dom.Xpath.XPathNSResolver>("createNSResolver", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}