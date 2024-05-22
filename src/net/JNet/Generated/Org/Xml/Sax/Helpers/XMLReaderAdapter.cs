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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Xml.Sax.Helpers
{
    #region XMLReaderAdapter
    public partial class XMLReaderAdapter
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
        /// Handlers initializer for <see cref="XMLReaderAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("characters", new System.EventHandler<CLRListenerEventArgs<CLREventData<char[]>>>(CharactersEventHandler));
            AddEventHandler("endDocument", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(EndDocumentEventHandler));
            AddEventHandler("endElement", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(EndElementEventHandler));
            AddEventHandler("endPrefixMapping", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(EndPrefixMappingEventHandler));
            AddEventHandler("ignorableWhitespace", new System.EventHandler<CLRListenerEventArgs<CLREventData<char[]>>>(IgnorableWhitespaceEventHandler));
            AddEventHandler("parse", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(ParseEventHandler));
            AddEventHandler("parse1", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.InputSource>>>(Parse1EventHandler));
            AddEventHandler("processingInstruction", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(ProcessingInstructionEventHandler));
            AddEventHandler("setDocumentLocator", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.Locator>>>(SetDocumentLocatorEventHandler));
            AddEventHandler("setDTDHandler", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.DTDHandler>>>(SetDTDHandlerEventHandler));
            AddEventHandler("setEntityResolver", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.EntityResolver>>>(SetEntityResolverEventHandler));
            AddEventHandler("setErrorHandler", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.ErrorHandler>>>(SetErrorHandlerEventHandler));
            AddEventHandler("setLocale", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Locale>>>(SetLocaleEventHandler));
            AddEventHandler("skippedEntity", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(SkippedEntityEventHandler));
            AddEventHandler("startDocument", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(StartDocumentEventHandler));
            AddEventHandler("startElement", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(StartElementEventHandler));
            AddEventHandler("startPrefixMapping", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(StartPrefixMappingEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#characters(char[],int,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnCharacters"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<char[], int, int> OnCharacters { get; set; } = null;

        void CharactersEventHandler(object sender, CLRListenerEventArgs<CLREventData<char[]>> data)
        {
            var methodToExecute = (OnCharacters != null) ? OnCharacters : Characters;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#characters(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void Characters(char[] arg0, int arg1, int arg2)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#endDocument()"/>
        /// </summary>
        /// <remarks>If <see cref="OnEndDocument"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnEndDocument { get; set; } = null;

        void EndDocumentEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnEndDocument != null) ? OnEndDocument : EndDocument;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#endDocument()"/>
        /// </summary>

        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void EndDocument()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#endElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnEndElement"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Lang.String, Java.Lang.String, Java.Lang.String> OnEndElement { get; set; } = null;

        void EndElementEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnEndElement != null) ? OnEndElement : EndElement;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<Java.Lang.String>(1));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#endElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void EndElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#endPrefixMapping(java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnEndPrefixMapping"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Lang.String> OnEndPrefixMapping { get; set; } = null;

        void EndPrefixMappingEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnEndPrefixMapping != null) ? OnEndPrefixMapping : EndPrefixMapping;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#endPrefixMapping(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public virtual void EndPrefixMapping(Java.Lang.String arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#ignorableWhitespace(char[],int,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnIgnorableWhitespace"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<char[], int, int> OnIgnorableWhitespace { get; set; } = null;

        void IgnorableWhitespaceEventHandler(object sender, CLRListenerEventArgs<CLREventData<char[]>> data)
        {
            var methodToExecute = (OnIgnorableWhitespace != null) ? OnIgnorableWhitespace : IgnorableWhitespace;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#ignorableWhitespace(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void IgnorableWhitespace(char[] arg0, int arg1, int arg2)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#parse(java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnParse"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Lang.String> OnParse { get; set; } = null;

        void ParseEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnParse != null) ? OnParse : Parse;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void Parse(Java.Lang.String arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#parse(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <remarks>If <see cref="OnParse1"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Xml.Sax.InputSource> OnParse1 { get; set; } = null;

        void Parse1EventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.InputSource>> data)
        {
            var methodToExecute = (OnParse1 != null) ? OnParse1 : Parse;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#parse(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void Parse(Org.Xml.Sax.InputSource arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#processingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnProcessingInstruction"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Lang.String, Java.Lang.String> OnProcessingInstruction { get; set; } = null;

        void ProcessingInstructionEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnProcessingInstruction != null) ? OnProcessingInstruction : ProcessingInstruction;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#processingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void ProcessingInstruction(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setDocumentLocator(org.xml.sax.Locator)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetDocumentLocator"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Xml.Sax.Locator> OnSetDocumentLocator { get; set; } = null;

        void SetDocumentLocatorEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.Locator>> data)
        {
            var methodToExecute = (OnSetDocumentLocator != null) ? OnSetDocumentLocator : SetDocumentLocator;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setDocumentLocator(org.xml.sax.Locator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.Locator"/></param>
        public virtual void SetDocumentLocator(Org.Xml.Sax.Locator arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setDTDHandler(org.xml.sax.DTDHandler)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetDTDHandler"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Xml.Sax.DTDHandler> OnSetDTDHandler { get; set; } = null;

        void SetDTDHandlerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.DTDHandler>> data)
        {
            var methodToExecute = (OnSetDTDHandler != null) ? OnSetDTDHandler : SetDTDHandler;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setDTDHandler(org.xml.sax.DTDHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.DTDHandler"/></param>
        public virtual void SetDTDHandler(Org.Xml.Sax.DTDHandler arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setEntityResolver(org.xml.sax.EntityResolver)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetEntityResolver"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Xml.Sax.EntityResolver> OnSetEntityResolver { get; set; } = null;

        void SetEntityResolverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.EntityResolver>> data)
        {
            var methodToExecute = (OnSetEntityResolver != null) ? OnSetEntityResolver : SetEntityResolver;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setEntityResolver(org.xml.sax.EntityResolver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.EntityResolver"/></param>
        public virtual void SetEntityResolver(Org.Xml.Sax.EntityResolver arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetErrorHandler"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Xml.Sax.ErrorHandler> OnSetErrorHandler { get; set; } = null;

        void SetErrorHandlerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.ErrorHandler>> data)
        {
            var methodToExecute = (OnSetErrorHandler != null) ? OnSetErrorHandler : SetErrorHandler;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.ErrorHandler"/></param>
        public virtual void SetErrorHandler(Org.Xml.Sax.ErrorHandler arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setLocale(java.util.Locale)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetLocale"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Util.Locale> OnSetLocale { get; set; } = null;

        void SetLocaleEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Locale>> data)
        {
            var methodToExecute = (OnSetLocale != null) ? OnSetLocale : SetLocale;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void SetLocale(Java.Util.Locale arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#skippedEntity(java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSkippedEntity"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Lang.String> OnSkippedEntity { get; set; } = null;

        void SkippedEntityEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnSkippedEntity != null) ? OnSkippedEntity : SkippedEntity;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#skippedEntity(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void SkippedEntity(Java.Lang.String arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#startDocument()"/>
        /// </summary>
        /// <remarks>If <see cref="OnStartDocument"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnStartDocument { get; set; } = null;

        void StartDocumentEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnStartDocument != null) ? OnStartDocument : StartDocument;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#startDocument()"/>
        /// </summary>

        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void StartDocument()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#startElement(java.lang.String,java.lang.String,java.lang.String,org.xml.sax.Attributes)"/>
        /// </summary>
        /// <remarks>If <see cref="OnStartElement"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Lang.String, Java.Lang.String, Java.Lang.String, Org.Xml.Sax.Attributes> OnStartElement { get; set; } = null;

        void StartElementEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnStartElement != null) ? OnStartElement : StartElement;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<Java.Lang.String>(1), data.EventData.GetAt<Org.Xml.Sax.Attributes>(2));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#startElement(java.lang.String,java.lang.String,java.lang.String,org.xml.sax.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Org.Xml.Sax.Attributes"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void StartElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Org.Xml.Sax.Attributes arg3)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#startPrefixMapping(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnStartPrefixMapping"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Lang.String, Java.Lang.String> OnStartPrefixMapping { get; set; } = null;

        void StartPrefixMappingEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnStartPrefixMapping != null) ? OnStartPrefixMapping : StartPrefixMapping;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#startPrefixMapping(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public virtual void StartPrefixMapping(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XMLReaderAdapterDirect
    public partial class XMLReaderAdapterDirect
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#characters(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void Characters(char[] arg0, int arg1, int arg2)
        {
            IExecute("characters", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#endDocument()"/>
        /// </summary>

        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void EndDocument()
        {
            IExecuteWithSignature("endDocument", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#endElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void EndElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("endElement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#endPrefixMapping(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public override void EndPrefixMapping(Java.Lang.String arg0)
        {
            IExecuteWithSignature("endPrefixMapping", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#ignorableWhitespace(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void IgnorableWhitespace(char[] arg0, int arg1, int arg2)
        {
            IExecute("ignorableWhitespace", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void Parse(Java.Lang.String arg0)
        {
            IExecuteWithSignature("parse", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#parse(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void Parse(Org.Xml.Sax.InputSource arg0)
        {
            IExecuteWithSignature("parse", "(Lorg/xml/sax/InputSource;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#processingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void ProcessingInstruction(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("processingInstruction", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setDocumentLocator(org.xml.sax.Locator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.Locator"/></param>
        public override void SetDocumentLocator(Org.Xml.Sax.Locator arg0)
        {
            IExecuteWithSignature("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setDTDHandler(org.xml.sax.DTDHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.DTDHandler"/></param>
        public override void SetDTDHandler(Org.Xml.Sax.DTDHandler arg0)
        {
            IExecuteWithSignature("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setEntityResolver(org.xml.sax.EntityResolver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.EntityResolver"/></param>
        public override void SetEntityResolver(Org.Xml.Sax.EntityResolver arg0)
        {
            IExecuteWithSignature("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.ErrorHandler"/></param>
        public override void SetErrorHandler(Org.Xml.Sax.ErrorHandler arg0)
        {
            IExecuteWithSignature("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#setLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void SetLocale(Java.Util.Locale arg0)
        {
            IExecuteWithSignature("setLocale", "(Ljava/util/Locale;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#skippedEntity(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void SkippedEntity(Java.Lang.String arg0)
        {
            IExecuteWithSignature("skippedEntity", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#startDocument()"/>
        /// </summary>

        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void StartDocument()
        {
            IExecuteWithSignature("startDocument", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#startElement(java.lang.String,java.lang.String,java.lang.String,org.xml.sax.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Org.Xml.Sax.Attributes"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void StartElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Org.Xml.Sax.Attributes arg3)
        {
            IExecute("startElement", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/XMLReaderAdapter.html#startPrefixMapping(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public override void StartPrefixMapping(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("startPrefixMapping", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}