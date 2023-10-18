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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Xml.Sax.Helpers
{
    #region ParserAdapter
    public partial class ParserAdapter
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
        /// Handlers initializer for <see cref="ParserAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("getFeature", new System.EventHandler<CLRListenerEventArgs<CLREventData<string>>>(GetFeatureEventHandler)); OnGetFeature = GetFeature;
            AddEventHandler("getProperty", new System.EventHandler<CLRListenerEventArgs<CLREventData<string>>>(GetPropertyEventHandler)); OnGetProperty = GetProperty;
            AddEventHandler("getContentHandler", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetContentHandlerEventHandler)); OnGetContentHandler = GetContentHandler;
            AddEventHandler("getDTDHandler", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetDTDHandlerEventHandler)); OnGetDTDHandler = GetDTDHandler;
            AddEventHandler("getEntityResolver", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetEntityResolverEventHandler)); OnGetEntityResolver = GetEntityResolver;
            AddEventHandler("getErrorHandler", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetErrorHandlerEventHandler)); OnGetErrorHandler = GetErrorHandler;
            AddEventHandler("characters", new System.EventHandler<CLRListenerEventArgs<CLREventData<char[]>>>(CharactersEventHandler)); OnCharacters = Characters;
            AddEventHandler("endDocument", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(EndDocumentEventHandler)); OnEndDocument = EndDocument;
            AddEventHandler("endElement", new System.EventHandler<CLRListenerEventArgs<CLREventData<string>>>(EndElementEventHandler)); OnEndElement = EndElement;
            AddEventHandler("ignorableWhitespace", new System.EventHandler<CLRListenerEventArgs<CLREventData<char[]>>>(IgnorableWhitespaceEventHandler)); OnIgnorableWhitespace = IgnorableWhitespace;
            AddEventHandler("parse", new System.EventHandler<CLRListenerEventArgs<CLREventData<string>>>(ParseEventHandler)); OnParse = Parse;
            AddEventHandler("parse1", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.InputSource>>>(Parse1EventHandler)); OnParse = Parse;
            AddEventHandler("processingInstruction", new System.EventHandler<CLRListenerEventArgs<CLREventData<string>>>(ProcessingInstructionEventHandler)); OnProcessingInstruction = ProcessingInstruction;
            AddEventHandler("setContentHandler", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.ContentHandler>>>(SetContentHandlerEventHandler)); OnSetContentHandler = SetContentHandler;
            AddEventHandler("setDocumentLocator", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.Locator>>>(SetDocumentLocatorEventHandler)); OnSetDocumentLocator = SetDocumentLocator;
            AddEventHandler("setDTDHandler", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.DTDHandler>>>(SetDTDHandlerEventHandler)); OnSetDTDHandler = SetDTDHandler;
            AddEventHandler("setEntityResolver", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.EntityResolver>>>(SetEntityResolverEventHandler)); OnSetEntityResolver = SetEntityResolver;
            AddEventHandler("setErrorHandler", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.ErrorHandler>>>(SetErrorHandlerEventHandler)); OnSetErrorHandler = SetErrorHandler;
            AddEventHandler("setFeature", new System.EventHandler<CLRListenerEventArgs<CLREventData<string>>>(SetFeatureEventHandler)); OnSetFeature = SetFeature;
            AddEventHandler("setProperty", new System.EventHandler<CLRListenerEventArgs<CLREventData<string>>>(SetPropertyEventHandler)); OnSetProperty = SetProperty;
            AddEventHandler("startDocument", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(StartDocumentEventHandler)); OnStartDocument = StartDocument;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#getFeature(java.lang.String)"/>
        /// </summary>
        public System.Func<string, bool> OnGetFeature { get; set; }

        void GetFeatureEventHandler(object sender, CLRListenerEventArgs<CLREventData<string>> data)
        {
            if (OnGetFeature != null)
            {
                var executionResult = OnGetFeature.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public virtual bool GetFeature(string arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#getProperty(java.lang.String)"/>
        /// </summary>
        public System.Func<string, object> OnGetProperty { get; set; }

        void GetPropertyEventHandler(object sender, CLRListenerEventArgs<CLREventData<string>> data)
        {
            if (OnGetProperty != null)
            {
                var executionResult = OnGetProperty.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public virtual object GetProperty(string arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#getContentHandler()"/>
        /// </summary>
        public System.Func<Org.Xml.Sax.ContentHandler> OnGetContentHandler { get; set; }

        void GetContentHandlerEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            if (OnGetContentHandler != null)
            {
                var executionResult = OnGetContentHandler.Invoke();
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#getContentHandler()"/>
        /// </summary>

        /// <returns><see cref="Org.Xml.Sax.ContentHandler"/></returns>
        public virtual Org.Xml.Sax.ContentHandler GetContentHandler()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#getDTDHandler()"/>
        /// </summary>
        public System.Func<Org.Xml.Sax.DTDHandler> OnGetDTDHandler { get; set; }

        void GetDTDHandlerEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            if (OnGetDTDHandler != null)
            {
                var executionResult = OnGetDTDHandler.Invoke();
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#getDTDHandler()"/>
        /// </summary>

        /// <returns><see cref="Org.Xml.Sax.DTDHandler"/></returns>
        public virtual Org.Xml.Sax.DTDHandler GetDTDHandler()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#getEntityResolver()"/>
        /// </summary>
        public System.Func<Org.Xml.Sax.EntityResolver> OnGetEntityResolver { get; set; }

        void GetEntityResolverEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            if (OnGetEntityResolver != null)
            {
                var executionResult = OnGetEntityResolver.Invoke();
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#getEntityResolver()"/>
        /// </summary>

        /// <returns><see cref="Org.Xml.Sax.EntityResolver"/></returns>
        public virtual Org.Xml.Sax.EntityResolver GetEntityResolver()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#getErrorHandler()"/>
        /// </summary>
        public System.Func<Org.Xml.Sax.ErrorHandler> OnGetErrorHandler { get; set; }

        void GetErrorHandlerEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            if (OnGetErrorHandler != null)
            {
                var executionResult = OnGetErrorHandler.Invoke();
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#getErrorHandler()"/>
        /// </summary>

        /// <returns><see cref="Org.Xml.Sax.ErrorHandler"/></returns>
        public virtual Org.Xml.Sax.ErrorHandler GetErrorHandler()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#characters(char[],int,int)"/>
        /// </summary>
        public System.Action<char[], int, int> OnCharacters { get; set; }

        void CharactersEventHandler(object sender, CLRListenerEventArgs<CLREventData<char[]>> data)
        {
            if (OnCharacters != null) OnCharacters.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#characters(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void Characters(char[] arg0, int arg1, int arg2)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#endDocument()"/>
        /// </summary>
        public System.Action OnEndDocument { get; set; }

        void EndDocumentEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            if (OnEndDocument != null) OnEndDocument.Invoke();
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#endDocument()"/>
        /// </summary>

        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void EndDocument()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#endElement(java.lang.String)"/>
        /// </summary>
        public System.Action<string> OnEndElement { get; set; }

        void EndElementEventHandler(object sender, CLRListenerEventArgs<CLREventData<string>> data)
        {
            if (OnEndElement != null) OnEndElement.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#endElement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void EndElement(string arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#ignorableWhitespace(char[],int,int)"/>
        /// </summary>
        public System.Action<char[], int, int> OnIgnorableWhitespace { get; set; }

        void IgnorableWhitespaceEventHandler(object sender, CLRListenerEventArgs<CLREventData<char[]>> data)
        {
            if (OnIgnorableWhitespace != null) OnIgnorableWhitespace.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#ignorableWhitespace(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void IgnorableWhitespace(char[] arg0, int arg1, int arg2)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#parse(java.lang.String)"/>
        /// </summary>
        public System.Action<string> OnParse { get; set; }

        void ParseEventHandler(object sender, CLRListenerEventArgs<CLREventData<string>> data)
        {
            if (OnParse != null) OnParse.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void Parse(string arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#parse(org.xml.sax.InputSource)"/>
        /// </summary>
        public System.Action<Org.Xml.Sax.InputSource> OnParse1 { get; set; }

        void Parse1EventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.InputSource>> data)
        {
            if (OnParse1 != null) OnParse1.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#parse(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void Parse(Org.Xml.Sax.InputSource arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#processingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        public System.Action<string, string> OnProcessingInstruction { get; set; }

        void ProcessingInstructionEventHandler(object sender, CLRListenerEventArgs<CLREventData<string>> data)
        {
            if (OnProcessingInstruction != null) OnProcessingInstruction.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<string>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#processingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void ProcessingInstruction(string arg0, string arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#setContentHandler(org.xml.sax.ContentHandler)"/>
        /// </summary>
        public System.Action<Org.Xml.Sax.ContentHandler> OnSetContentHandler { get; set; }

        void SetContentHandlerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.ContentHandler>> data)
        {
            if (OnSetContentHandler != null) OnSetContentHandler.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#setContentHandler(org.xml.sax.ContentHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.ContentHandler"/></param>
        public virtual void SetContentHandler(Org.Xml.Sax.ContentHandler arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#setDocumentLocator(org.xml.sax.Locator)"/>
        /// </summary>
        public System.Action<Org.Xml.Sax.Locator> OnSetDocumentLocator { get; set; }

        void SetDocumentLocatorEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.Locator>> data)
        {
            if (OnSetDocumentLocator != null) OnSetDocumentLocator.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#setDocumentLocator(org.xml.sax.Locator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.Locator"/></param>
        public virtual void SetDocumentLocator(Org.Xml.Sax.Locator arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#setDTDHandler(org.xml.sax.DTDHandler)"/>
        /// </summary>
        public System.Action<Org.Xml.Sax.DTDHandler> OnSetDTDHandler { get; set; }

        void SetDTDHandlerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.DTDHandler>> data)
        {
            if (OnSetDTDHandler != null) OnSetDTDHandler.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#setDTDHandler(org.xml.sax.DTDHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.DTDHandler"/></param>
        public virtual void SetDTDHandler(Org.Xml.Sax.DTDHandler arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#setEntityResolver(org.xml.sax.EntityResolver)"/>
        /// </summary>
        public System.Action<Org.Xml.Sax.EntityResolver> OnSetEntityResolver { get; set; }

        void SetEntityResolverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.EntityResolver>> data)
        {
            if (OnSetEntityResolver != null) OnSetEntityResolver.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#setEntityResolver(org.xml.sax.EntityResolver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.EntityResolver"/></param>
        public virtual void SetEntityResolver(Org.Xml.Sax.EntityResolver arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        public System.Action<Org.Xml.Sax.ErrorHandler> OnSetErrorHandler { get; set; }

        void SetErrorHandlerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.ErrorHandler>> data)
        {
            if (OnSetErrorHandler != null) OnSetErrorHandler.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.ErrorHandler"/></param>
        public virtual void SetErrorHandler(Org.Xml.Sax.ErrorHandler arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        public System.Action<string, bool> OnSetFeature { get; set; }

        void SetFeatureEventHandler(object sender, CLRListenerEventArgs<CLREventData<string>> data)
        {
            if (OnSetFeature != null) OnSetFeature.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<bool>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public virtual void SetFeature(string arg0, bool arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        public System.Action<string, object> OnSetProperty { get; set; }

        void SetPropertyEventHandler(object sender, CLRListenerEventArgs<CLREventData<string>> data)
        {
            if (OnSetProperty != null) OnSetProperty.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public virtual void SetProperty(string arg0, object arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#startDocument()"/>
        /// </summary>
        public System.Action OnStartDocument { get; set; }

        void StartDocumentEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            if (OnStartDocument != null) OnStartDocument.Invoke();
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/ParserAdapter.html#startDocument()"/>
        /// </summary>

        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void StartDocument()
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}