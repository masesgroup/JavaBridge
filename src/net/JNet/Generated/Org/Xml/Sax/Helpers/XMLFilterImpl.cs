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

namespace Org.Xml.Sax.Helpers
{
    #region XMLFilterImpl
    public partial class XMLFilterImpl
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#%3Cinit%3E(org.xml.sax.XMLReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.XMLReader"/></param>
        public XMLFilterImpl(Org.Xml.Sax.XMLReader arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Xml.Sax.Helpers.XMLFilterImpl"/> to <see cref="Org.Xml.Sax.XMLFilter"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.XMLFilter(Org.Xml.Sax.Helpers.XMLFilterImpl t) => t.Cast<Org.Xml.Sax.XMLFilter>();
        /// <summary>
        /// Converter from <see cref="Org.Xml.Sax.Helpers.XMLFilterImpl"/> to <see cref="Org.Xml.Sax.EntityResolver"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.EntityResolver(Org.Xml.Sax.Helpers.XMLFilterImpl t) => t.Cast<Org.Xml.Sax.EntityResolver>();
        /// <summary>
        /// Converter from <see cref="Org.Xml.Sax.Helpers.XMLFilterImpl"/> to <see cref="Org.Xml.Sax.DTDHandler"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.DTDHandler(Org.Xml.Sax.Helpers.XMLFilterImpl t) => t.Cast<Org.Xml.Sax.DTDHandler>();
        /// <summary>
        /// Converter from <see cref="Org.Xml.Sax.Helpers.XMLFilterImpl"/> to <see cref="Org.Xml.Sax.ContentHandler"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.ContentHandler(Org.Xml.Sax.Helpers.XMLFilterImpl t) => t.Cast<Org.Xml.Sax.ContentHandler>();
        /// <summary>
        /// Converter from <see cref="Org.Xml.Sax.Helpers.XMLFilterImpl"/> to <see cref="Org.Xml.Sax.ErrorHandler"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.ErrorHandler(Org.Xml.Sax.Helpers.XMLFilterImpl t) => t.Cast<Org.Xml.Sax.ErrorHandler>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#getContentHandler()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#setContentHandler(org.xml.sax.ContentHandler)"/>
        /// </summary>
        public Org.Xml.Sax.ContentHandler ContentHandler
        {
            get { return IExecuteWithSignature<Org.Xml.Sax.ContentHandler>("getContentHandler", "()Lorg/xml/sax/ContentHandler;"); } set { IExecuteWithSignature("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#getDTDHandler()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#setDTDHandler(org.xml.sax.DTDHandler)"/>
        /// </summary>
        public Org.Xml.Sax.DTDHandler DTDHandler
        {
            get { return IExecuteWithSignature<Org.Xml.Sax.DTDHandler>("getDTDHandler", "()Lorg/xml/sax/DTDHandler;"); } set { IExecuteWithSignature("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#getEntityResolver()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#setEntityResolver(org.xml.sax.EntityResolver)"/>
        /// </summary>
        public Org.Xml.Sax.EntityResolver EntityResolver
        {
            get { return IExecuteWithSignature<Org.Xml.Sax.EntityResolver>("getEntityResolver", "()Lorg/xml/sax/EntityResolver;"); } set { IExecuteWithSignature("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#getErrorHandler()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        public Org.Xml.Sax.ErrorHandler ErrorHandler
        {
            get { return IExecuteWithSignature<Org.Xml.Sax.ErrorHandler>("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;"); } set { IExecuteWithSignature("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#getParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#setParent(org.xml.sax.XMLReader)"/>
        /// </summary>
        public Org.Xml.Sax.XMLReader Parent
        {
            get { return IExecuteWithSignature<Org.Xml.Sax.XMLReader>("getParent", "()Lorg/xml/sax/XMLReader;"); } set { IExecuteWithSignature("setParent", "(Lorg/xml/sax/XMLReader;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public bool GetFeature(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("getFeature", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#resolveEntity(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Xml.Sax.InputSource"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Org.Xml.Sax.InputSource ResolveEntity(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Org.Xml.Sax.InputSource>("resolveEntity", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#characters(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void Characters(char[] arg0, int arg1, int arg2)
        {
            IExecute("characters", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#endDocument()"/>
        /// </summary>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void EndDocument()
        {
            IExecuteWithSignature("endDocument", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#endElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void EndElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("endElement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#endPrefixMapping(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void EndPrefixMapping(Java.Lang.String arg0)
        {
            IExecuteWithSignature("endPrefixMapping", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#error(org.xml.sax.SAXParseException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.SAXParseException"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void Error(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("error", "(Lorg/xml/sax/SAXParseException;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#fatalError(org.xml.sax.SAXParseException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.SAXParseException"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void FatalError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("fatalError", "(Lorg/xml/sax/SAXParseException;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#ignorableWhitespace(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void IgnorableWhitespace(char[] arg0, int arg1, int arg2)
        {
            IExecute("ignorableWhitespace", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#notationDecl(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void NotationDecl(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("notationDecl", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void Parse(Java.Lang.String arg0)
        {
            IExecuteWithSignature("parse", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#parse(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void Parse(Org.Xml.Sax.InputSource arg0)
        {
            IExecuteWithSignature("parse", "(Lorg/xml/sax/InputSource;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#processingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void ProcessingInstruction(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("processingInstruction", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#setDocumentLocator(org.xml.sax.Locator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.Locator"/></param>
        public void SetDocumentLocator(Org.Xml.Sax.Locator arg0)
        {
            IExecuteWithSignature("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetFeature(Java.Lang.String arg0, bool arg1)
        {
            IExecute("setFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetProperty(Java.Lang.String arg0, object arg1)
        {
            IExecute("setProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#skippedEntity(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void SkippedEntity(Java.Lang.String arg0)
        {
            IExecuteWithSignature("skippedEntity", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#startDocument()"/>
        /// </summary>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void StartDocument()
        {
            IExecuteWithSignature("startDocument", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#startElement(java.lang.String,java.lang.String,java.lang.String,org.xml.sax.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Org.Xml.Sax.Attributes"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void StartElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Org.Xml.Sax.Attributes arg3)
        {
            IExecute("startElement", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#startPrefixMapping(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void StartPrefixMapping(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("startPrefixMapping", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#unparsedEntityDecl(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void UnparsedEntityDecl(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3)
        {
            IExecute("unparsedEntityDecl", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLFilterImpl.html#warning(org.xml.sax.SAXParseException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.SAXParseException"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void Warning(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("warning", "(Lorg/xml/sax/SAXParseException;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}