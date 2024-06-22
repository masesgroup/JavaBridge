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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream
{
    #region IXMLStreamConstants
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXMLStreamConstants
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XMLStreamConstants
    public partial class XMLStreamConstants : Javax.Xml.Stream.IXMLStreamConstants
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#ATTRIBUTE"/>
        /// </summary>
        public static int ATTRIBUTE { get { if (!_ATTRIBUTEReady) { _ATTRIBUTEContent = SGetField<int>(LocalBridgeClazz, "ATTRIBUTE"); _ATTRIBUTEReady = true; } return _ATTRIBUTEContent; } }
        private static int _ATTRIBUTEContent = default;
        private static bool _ATTRIBUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#CDATA"/>
        /// </summary>
        public static int CDATA { get { if (!_CDATAReady) { _CDATAContent = SGetField<int>(LocalBridgeClazz, "CDATA"); _CDATAReady = true; } return _CDATAContent; } }
        private static int _CDATAContent = default;
        private static bool _CDATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#CHARACTERS"/>
        /// </summary>
        public static int CHARACTERS { get { if (!_CHARACTERSReady) { _CHARACTERSContent = SGetField<int>(LocalBridgeClazz, "CHARACTERS"); _CHARACTERSReady = true; } return _CHARACTERSContent; } }
        private static int _CHARACTERSContent = default;
        private static bool _CHARACTERSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#COMMENT"/>
        /// </summary>
        public static int COMMENT { get { if (!_COMMENTReady) { _COMMENTContent = SGetField<int>(LocalBridgeClazz, "COMMENT"); _COMMENTReady = true; } return _COMMENTContent; } }
        private static int _COMMENTContent = default;
        private static bool _COMMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#DTD"/>
        /// </summary>
        public static int DTD { get { if (!_DTDReady) { _DTDContent = SGetField<int>(LocalBridgeClazz, "DTD"); _DTDReady = true; } return _DTDContent; } }
        private static int _DTDContent = default;
        private static bool _DTDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#END_DOCUMENT"/>
        /// </summary>
        public static int END_DOCUMENT { get { if (!_END_DOCUMENTReady) { _END_DOCUMENTContent = SGetField<int>(LocalBridgeClazz, "END_DOCUMENT"); _END_DOCUMENTReady = true; } return _END_DOCUMENTContent; } }
        private static int _END_DOCUMENTContent = default;
        private static bool _END_DOCUMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#END_ELEMENT"/>
        /// </summary>
        public static int END_ELEMENT { get { if (!_END_ELEMENTReady) { _END_ELEMENTContent = SGetField<int>(LocalBridgeClazz, "END_ELEMENT"); _END_ELEMENTReady = true; } return _END_ELEMENTContent; } }
        private static int _END_ELEMENTContent = default;
        private static bool _END_ELEMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#ENTITY_DECLARATION"/>
        /// </summary>
        public static int ENTITY_DECLARATION { get { if (!_ENTITY_DECLARATIONReady) { _ENTITY_DECLARATIONContent = SGetField<int>(LocalBridgeClazz, "ENTITY_DECLARATION"); _ENTITY_DECLARATIONReady = true; } return _ENTITY_DECLARATIONContent; } }
        private static int _ENTITY_DECLARATIONContent = default;
        private static bool _ENTITY_DECLARATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#ENTITY_REFERENCE"/>
        /// </summary>
        public static int ENTITY_REFERENCE { get { if (!_ENTITY_REFERENCEReady) { _ENTITY_REFERENCEContent = SGetField<int>(LocalBridgeClazz, "ENTITY_REFERENCE"); _ENTITY_REFERENCEReady = true; } return _ENTITY_REFERENCEContent; } }
        private static int _ENTITY_REFERENCEContent = default;
        private static bool _ENTITY_REFERENCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#NAMESPACE"/>
        /// </summary>
        public static int NAMESPACE { get { if (!_NAMESPACEReady) { _NAMESPACEContent = SGetField<int>(LocalBridgeClazz, "NAMESPACE"); _NAMESPACEReady = true; } return _NAMESPACEContent; } }
        private static int _NAMESPACEContent = default;
        private static bool _NAMESPACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#NOTATION_DECLARATION"/>
        /// </summary>
        public static int NOTATION_DECLARATION { get { if (!_NOTATION_DECLARATIONReady) { _NOTATION_DECLARATIONContent = SGetField<int>(LocalBridgeClazz, "NOTATION_DECLARATION"); _NOTATION_DECLARATIONReady = true; } return _NOTATION_DECLARATIONContent; } }
        private static int _NOTATION_DECLARATIONContent = default;
        private static bool _NOTATION_DECLARATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#PROCESSING_INSTRUCTION"/>
        /// </summary>
        public static int PROCESSING_INSTRUCTION { get { if (!_PROCESSING_INSTRUCTIONReady) { _PROCESSING_INSTRUCTIONContent = SGetField<int>(LocalBridgeClazz, "PROCESSING_INSTRUCTION"); _PROCESSING_INSTRUCTIONReady = true; } return _PROCESSING_INSTRUCTIONContent; } }
        private static int _PROCESSING_INSTRUCTIONContent = default;
        private static bool _PROCESSING_INSTRUCTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#SPACE"/>
        /// </summary>
        public static int SPACE { get { if (!_SPACEReady) { _SPACEContent = SGetField<int>(LocalBridgeClazz, "SPACE"); _SPACEReady = true; } return _SPACEContent; } }
        private static int _SPACEContent = default;
        private static bool _SPACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#START_DOCUMENT"/>
        /// </summary>
        public static int START_DOCUMENT { get { if (!_START_DOCUMENTReady) { _START_DOCUMENTContent = SGetField<int>(LocalBridgeClazz, "START_DOCUMENT"); _START_DOCUMENTReady = true; } return _START_DOCUMENTContent; } }
        private static int _START_DOCUMENTContent = default;
        private static bool _START_DOCUMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamConstants.html#START_ELEMENT"/>
        /// </summary>
        public static int START_ELEMENT { get { if (!_START_ELEMENTReady) { _START_ELEMENTContent = SGetField<int>(LocalBridgeClazz, "START_ELEMENT"); _START_ELEMENTReady = true; } return _START_ELEMENTContent; } }
        private static int _START_ELEMENTContent = default;
        private static bool _START_ELEMENTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}