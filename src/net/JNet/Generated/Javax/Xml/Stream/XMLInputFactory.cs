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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream
{
    #region XMLInputFactory
    public partial class XMLInputFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#ALLOCATOR"/>
        /// </summary>
        public static Java.Lang.String ALLOCATOR { get { if (!_ALLOCATORReady) { _ALLOCATORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ALLOCATOR"); _ALLOCATORReady = true; } return _ALLOCATORContent; } }
        private static Java.Lang.String _ALLOCATORContent = default;
        private static bool _ALLOCATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_COALESCING"/>
        /// </summary>
        public static Java.Lang.String IS_COALESCING { get { if (!_IS_COALESCINGReady) { _IS_COALESCINGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "IS_COALESCING"); _IS_COALESCINGReady = true; } return _IS_COALESCINGContent; } }
        private static Java.Lang.String _IS_COALESCINGContent = default;
        private static bool _IS_COALESCINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_NAMESPACE_AWARE"/>
        /// </summary>
        public static Java.Lang.String IS_NAMESPACE_AWARE { get { if (!_IS_NAMESPACE_AWAREReady) { _IS_NAMESPACE_AWAREContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "IS_NAMESPACE_AWARE"); _IS_NAMESPACE_AWAREReady = true; } return _IS_NAMESPACE_AWAREContent; } }
        private static Java.Lang.String _IS_NAMESPACE_AWAREContent = default;
        private static bool _IS_NAMESPACE_AWAREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_REPLACING_ENTITY_REFERENCES"/>
        /// </summary>
        public static Java.Lang.String IS_REPLACING_ENTITY_REFERENCES { get { if (!_IS_REPLACING_ENTITY_REFERENCESReady) { _IS_REPLACING_ENTITY_REFERENCESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "IS_REPLACING_ENTITY_REFERENCES"); _IS_REPLACING_ENTITY_REFERENCESReady = true; } return _IS_REPLACING_ENTITY_REFERENCESContent; } }
        private static Java.Lang.String _IS_REPLACING_ENTITY_REFERENCESContent = default;
        private static bool _IS_REPLACING_ENTITY_REFERENCESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_SUPPORTING_EXTERNAL_ENTITIES"/>
        /// </summary>
        public static Java.Lang.String IS_SUPPORTING_EXTERNAL_ENTITIES { get { if (!_IS_SUPPORTING_EXTERNAL_ENTITIESReady) { _IS_SUPPORTING_EXTERNAL_ENTITIESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "IS_SUPPORTING_EXTERNAL_ENTITIES"); _IS_SUPPORTING_EXTERNAL_ENTITIESReady = true; } return _IS_SUPPORTING_EXTERNAL_ENTITIESContent; } }
        private static Java.Lang.String _IS_SUPPORTING_EXTERNAL_ENTITIESContent = default;
        private static bool _IS_SUPPORTING_EXTERNAL_ENTITIESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_VALIDATING"/>
        /// </summary>
        public static Java.Lang.String IS_VALIDATING { get { if (!_IS_VALIDATINGReady) { _IS_VALIDATINGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "IS_VALIDATING"); _IS_VALIDATINGReady = true; } return _IS_VALIDATINGContent; } }
        private static Java.Lang.String _IS_VALIDATINGContent = default;
        private static bool _IS_VALIDATINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#REPORTER"/>
        /// </summary>
        public static Java.Lang.String REPORTER { get { if (!_REPORTERReady) { _REPORTERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REPORTER"); _REPORTERReady = true; } return _REPORTERContent; } }
        private static Java.Lang.String _REPORTERContent = default;
        private static bool _REPORTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#RESOLVER"/>
        /// </summary>
        public static Java.Lang.String RESOLVER { get { if (!_RESOLVERReady) { _RESOLVERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RESOLVER"); _RESOLVERReady = true; } return _RESOLVERContent; } }
        private static Java.Lang.String _RESOLVERContent = default;
        private static bool _RESOLVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#SUPPORT_DTD"/>
        /// </summary>
        public static Java.Lang.String SUPPORT_DTD { get { if (!_SUPPORT_DTDReady) { _SUPPORT_DTDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUPPORT_DTD"); _SUPPORT_DTDReady = true; } return _SUPPORT_DTDContent; } }
        private static Java.Lang.String _SUPPORT_DTDContent = default;
        private static bool _SUPPORT_DTDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#newDefaultFactory()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.XMLInputFactory"/></returns>
        public static Javax.Xml.Stream.XMLInputFactory NewDefaultFactory()
        {
            return SExecute<Javax.Xml.Stream.XMLInputFactory>(LocalBridgeClazz, "newDefaultFactory");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#newFactory()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.XMLInputFactory"/></returns>
        /// <exception cref="Javax.Xml.Stream.FactoryConfigurationError"/>
        public static Javax.Xml.Stream.XMLInputFactory NewFactory()
        {
            return SExecute<Javax.Xml.Stream.XMLInputFactory>(LocalBridgeClazz, "newFactory");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#newFactory(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLInputFactory"/></returns>
        /// <exception cref="Javax.Xml.Stream.FactoryConfigurationError"/>
        public static Javax.Xml.Stream.XMLInputFactory NewFactory(Java.Lang.String arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Javax.Xml.Stream.XMLInputFactory>(LocalBridgeClazz, "newFactory", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#newInstance()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.XMLInputFactory"/></returns>
        /// <exception cref="Javax.Xml.Stream.FactoryConfigurationError"/>
        public static Javax.Xml.Stream.XMLInputFactory NewInstance()
        {
            return SExecute<Javax.Xml.Stream.XMLInputFactory>(LocalBridgeClazz, "newInstance");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#getEventAllocator()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#setEventAllocator(javax.xml.stream.util.XMLEventAllocator)"/>
        /// </summary>
        public Javax.Xml.Stream.Util.XMLEventAllocator EventAllocator
        {
            get { return IExecute<Javax.Xml.Stream.Util.XMLEventAllocator>("getEventAllocator"); } set { IExecute("setEventAllocator", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#getXMLReporter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#setXMLReporter(javax.xml.stream.XMLReporter)"/>
        /// </summary>
        public Javax.Xml.Stream.XMLReporter XMLReporter
        {
            get { return IExecute<Javax.Xml.Stream.XMLReporter>("getXMLReporter"); } set { IExecute("setXMLReporter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#getXMLResolver()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#setXMLResolver(javax.xml.stream.XMLResolver)"/>
        /// </summary>
        public Javax.Xml.Stream.XMLResolver XMLResolver
        {
            get { return IExecute<Javax.Xml.Stream.XMLResolver>("getXMLResolver"); } set { IExecute("setXMLResolver", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#isPropertySupported(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPropertySupported(Java.Lang.String arg0)
        {
            return IExecute<bool>("isPropertySupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecute("getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createFilteredReader(javax.xml.stream.XMLEventReader,javax.xml.stream.EventFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLEventReader"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Stream.EventFilter"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateFilteredReader(Javax.Xml.Stream.XMLEventReader arg0, Javax.Xml.Stream.EventFilter arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createFilteredReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.io.InputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Java.Io.InputStream arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Java.Io.InputStream arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Java.Io.Reader arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.lang.String,java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Java.Lang.String arg0, Java.Io.InputStream arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.lang.String,java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Io.Reader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Java.Lang.String arg0, Java.Io.Reader arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(javax.xml.stream.XMLStreamReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLStreamReader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Javax.Xml.Stream.XMLStreamReader arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Javax.Xml.Transform.Source arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createFilteredReader(javax.xml.stream.XMLStreamReader,javax.xml.stream.StreamFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLStreamReader"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Stream.StreamFilter"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamReader CreateFilteredReader(Javax.Xml.Stream.XMLStreamReader arg0, Javax.Xml.Stream.StreamFilter arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createFilteredReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.io.InputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(Java.Io.InputStream arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(Java.Io.InputStream arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(Java.Io.Reader arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.lang.String,java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(Java.Lang.String arg0, Java.Io.InputStream arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.lang.String,java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Io.Reader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(Java.Lang.String arg0, Java.Io.Reader arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(Javax.Xml.Transform.Source arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetProperty(Java.Lang.String arg0, object arg1)
        {
            IExecute("setProperty", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}