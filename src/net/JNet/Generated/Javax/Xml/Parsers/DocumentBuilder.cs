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

namespace Javax.Xml.Parsers
{
    #region DocumentBuilder
    public partial class DocumentBuilder
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilder.html#getDOMImplementation()"/> 
        /// </summary>
        public Org.W3c.Dom.DOMImplementation DOMImplementation
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.DOMImplementation>("getDOMImplementation", "()Lorg/w3c/dom/DOMImplementation;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilder.html#getSchema()"/> 
        /// </summary>
        public Javax.Xml.Validation.Schema Schema
        {
            get { return IExecuteWithSignature<Javax.Xml.Validation.Schema>("getSchema", "()Ljavax/xml/validation/Schema;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilder.html#isNamespaceAware()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNamespaceAware()
        {
            return IExecuteWithSignature<bool>("isNamespaceAware", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilder.html#isValidating()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsValidating()
        {
            return IExecuteWithSignature<bool>("isValidating", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilder.html#newDocument()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        public Org.W3c.Dom.Document NewDocument()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Document>("newDocument", "()Lorg/w3c/dom/Document;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilder.html#parse(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Org.W3c.Dom.Document Parse(Org.Xml.Sax.InputSource arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Document>("parse", "(Lorg/xml/sax/InputSource;)Lorg/w3c/dom/Document;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilder.html#setEntityResolver(org.xml.sax.EntityResolver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.EntityResolver"/></param>
        public void SetEntityResolver(Org.Xml.Sax.EntityResolver arg0)
        {
            IExecuteWithSignature("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilder.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.ErrorHandler"/></param>
        public void SetErrorHandler(Org.Xml.Sax.ErrorHandler arg0)
        {
            IExecuteWithSignature("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilder.html#isXIncludeAware()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsXIncludeAware()
        {
            return IExecuteWithSignature<bool>("isXIncludeAware", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilder.html#parse(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Org.W3c.Dom.Document Parse(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Document>("parse", "(Ljava/io/File;)Lorg/w3c/dom/Document;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilder.html#parse(java.io.InputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Org.W3c.Dom.Document Parse(Java.Io.InputStream arg0, Java.Lang.String arg1)
        {
            return IExecute<Org.W3c.Dom.Document>("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilder.html#parse(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Org.W3c.Dom.Document Parse(Java.Io.InputStream arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Document>("parse", "(Ljava/io/InputStream;)Lorg/w3c/dom/Document;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilder.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Org.W3c.Dom.Document Parse(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Document>("parse", "(Ljava/lang/String;)Lorg/w3c/dom/Document;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilder.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}