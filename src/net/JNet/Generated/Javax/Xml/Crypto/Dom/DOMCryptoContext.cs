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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Crypto.Dom
{
    #region DOMCryptoContext
    public partial class DOMCryptoContext
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#getBaseURI()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#setBaseURI(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String BaseURI
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getBaseURI", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setBaseURI", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#getDefaultNamespacePrefix()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#setDefaultNamespacePrefix(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String DefaultNamespacePrefix
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDefaultNamespacePrefix", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setDefaultNamespacePrefix", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#getKeySelector()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#setKeySelector(javax.xml.crypto.KeySelector)"/>
        /// </summary>
        public Javax.Xml.Crypto.KeySelector KeySelector
        {
            get { return IExecuteWithSignature<Javax.Xml.Crypto.KeySelector>("getKeySelector", "()Ljavax/xml/crypto/KeySelector;"); } set { IExecuteWithSignature("setKeySelector", "(Ljavax/xml/crypto/KeySelector;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#getURIDereferencer()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#setURIDereferencer(javax.xml.crypto.URIDereferencer)"/>
        /// </summary>
        public Javax.Xml.Crypto.URIDereferencer URIDereferencer
        {
            get { return IExecuteWithSignature<Javax.Xml.Crypto.URIDereferencer>("getURIDereferencer", "()Ljavax/xml/crypto/URIDereferencer;"); } set { IExecuteWithSignature("setURIDereferencer", "(Ljavax/xml/crypto/URIDereferencer;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(object arg0)
        {
            return IExecuteWithSignature("get", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#put(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Put(object arg0, object arg1)
        {
            return IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object SetProperty(Java.Lang.String arg0, object arg1)
        {
            return IExecute("setProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#getNamespacePrefix(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNamespacePrefix(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("getNamespacePrefix", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#putNamespacePrefix(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String PutNamespacePrefix(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("putNamespacePrefix", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<Java.Util.Map.Entry<Java.Lang.String, Org.W3c.Dom.Element>> Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<Java.Util.Map.Entry<Java.Lang.String, Org.W3c.Dom.Element>>>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#getElementById(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Element"/></returns>
        public Org.W3c.Dom.Element GetElementById(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Element>("getElementById", "(Ljava/lang/String;)Lorg/w3c/dom/Element;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dom/DOMCryptoContext.html#setIdAttributeNS(org.w3c.dom.Element,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Element"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public void SetIdAttributeNS(Org.W3c.Dom.Element arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("setIdAttributeNS", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}