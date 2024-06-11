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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Crypto.Dsig.Dom
{
    #region DOMSignContext
    public partial class DOMSignContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/dom/DOMSignContext.html#%3Cinit%3E(java.security.Key,org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg2"><see cref="Org.W3c.Dom.Node"/></param>
        public DOMSignContext(Java.Security.Key arg0, Org.W3c.Dom.Node arg1, Org.W3c.Dom.Node arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/dom/DOMSignContext.html#%3Cinit%3E(java.security.Key,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        public DOMSignContext(Java.Security.Key arg0, Org.W3c.Dom.Node arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/dom/DOMSignContext.html#%3Cinit%3E(javax.xml.crypto.KeySelector,org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.KeySelector"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg2"><see cref="Org.W3c.Dom.Node"/></param>
        public DOMSignContext(Javax.Xml.Crypto.KeySelector arg0, Org.W3c.Dom.Node arg1, Org.W3c.Dom.Node arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/dom/DOMSignContext.html#%3Cinit%3E(javax.xml.crypto.KeySelector,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.KeySelector"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        public DOMSignContext(Javax.Xml.Crypto.KeySelector arg0, Org.W3c.Dom.Node arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.Dom.DOMSignContext"/> to <see cref="Javax.Xml.Crypto.Dsig.XMLSignContext"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.Dsig.XMLSignContext(Javax.Xml.Crypto.Dsig.Dom.DOMSignContext t) => t.Cast<Javax.Xml.Crypto.Dsig.XMLSignContext>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/dom/DOMSignContext.html#getNextSibling()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/dom/DOMSignContext.html#setNextSibling(org.w3c.dom.Node)"/>
        /// </summary>
        public Org.W3c.Dom.Node NextSibling
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getNextSibling", "()Lorg/w3c/dom/Node;"); } set { IExecuteWithSignature("setNextSibling", "(Lorg/w3c/dom/Node;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/dom/DOMSignContext.html#getParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/dom/DOMSignContext.html#setParent(org.w3c.dom.Node)"/>
        /// </summary>
        public Org.W3c.Dom.Node Parent
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getParent", "()Lorg/w3c/dom/Node;"); } set { IExecuteWithSignature("setParent", "(Lorg/w3c/dom/Node;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}