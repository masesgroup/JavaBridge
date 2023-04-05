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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Crypto.Dsig.Dom
{
    #region DOMValidateContext
    public partial class DOMValidateContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/dom/DOMValidateContext.html#%3Cinit%3E(java.security.Key,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        public DOMValidateContext(Java.Security.Key arg0, Org.W3c.Dom.Node arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/dom/DOMValidateContext.html#%3Cinit%3E(javax.xml.crypto.KeySelector,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.KeySelector"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        public DOMValidateContext(Javax.Xml.Crypto.KeySelector arg0, Org.W3c.Dom.Node arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.Dom.DOMValidateContext"/> to <see cref="Javax.Xml.Crypto.Dsig.XMLValidateContext"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.Dsig.XMLValidateContext(Javax.Xml.Crypto.Dsig.Dom.DOMValidateContext t) => t.Cast<Javax.Xml.Crypto.Dsig.XMLValidateContext>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/dom/DOMValidateContext.html#getNode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/dom/DOMValidateContext.html#setNode(org.w3c.dom.Node)"/>
        /// </summary>
        public Org.W3c.Dom.Node Node
        {
            get { return IExecute<Org.W3c.Dom.Node>("getNode"); } set { IExecute("setNode", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}