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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Transform
{
    #region OutputKeys declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/OutputKeys.html"/>
    /// </summary>
    public partial class OutputKeys : MASES.JCOBridge.C2JBridge.JVMBridgeBase<OutputKeys>
    {
        const string _bridgeClassName = "javax.xml.transform.OutputKeys";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public OutputKeys() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public OutputKeys(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region OutputKeys implementation
    public partial class OutputKeys
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/OutputKeys.html#CDATA_SECTION_ELEMENTS"/>
        /// </summary>
        public static Java.Lang.String CDATA_SECTION_ELEMENTS { get { if (!_CDATA_SECTION_ELEMENTSReady) { _CDATA_SECTION_ELEMENTSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CDATA_SECTION_ELEMENTS"); _CDATA_SECTION_ELEMENTSReady = true; } return _CDATA_SECTION_ELEMENTSContent; } }
        private static Java.Lang.String _CDATA_SECTION_ELEMENTSContent = default;
        private static bool _CDATA_SECTION_ELEMENTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/OutputKeys.html#DOCTYPE_PUBLIC"/>
        /// </summary>
        public static Java.Lang.String DOCTYPE_PUBLIC { get { if (!_DOCTYPE_PUBLICReady) { _DOCTYPE_PUBLICContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DOCTYPE_PUBLIC"); _DOCTYPE_PUBLICReady = true; } return _DOCTYPE_PUBLICContent; } }
        private static Java.Lang.String _DOCTYPE_PUBLICContent = default;
        private static bool _DOCTYPE_PUBLICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/OutputKeys.html#DOCTYPE_SYSTEM"/>
        /// </summary>
        public static Java.Lang.String DOCTYPE_SYSTEM { get { if (!_DOCTYPE_SYSTEMReady) { _DOCTYPE_SYSTEMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DOCTYPE_SYSTEM"); _DOCTYPE_SYSTEMReady = true; } return _DOCTYPE_SYSTEMContent; } }
        private static Java.Lang.String _DOCTYPE_SYSTEMContent = default;
        private static bool _DOCTYPE_SYSTEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/OutputKeys.html#ENCODING"/>
        /// </summary>
        public static Java.Lang.String ENCODING { get { if (!_ENCODINGReady) { _ENCODINGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ENCODING"); _ENCODINGReady = true; } return _ENCODINGContent; } }
        private static Java.Lang.String _ENCODINGContent = default;
        private static bool _ENCODINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/OutputKeys.html#INDENT"/>
        /// </summary>
        public static Java.Lang.String INDENT { get { if (!_INDENTReady) { _INDENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INDENT"); _INDENTReady = true; } return _INDENTContent; } }
        private static Java.Lang.String _INDENTContent = default;
        private static bool _INDENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/OutputKeys.html#MEDIA_TYPE"/>
        /// </summary>
        public static Java.Lang.String MEDIA_TYPE { get { if (!_MEDIA_TYPEReady) { _MEDIA_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_TYPE"); _MEDIA_TYPEReady = true; } return _MEDIA_TYPEContent; } }
        private static Java.Lang.String _MEDIA_TYPEContent = default;
        private static bool _MEDIA_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/OutputKeys.html#METHOD"/>
        /// </summary>
        public static Java.Lang.String METHOD { get { if (!_METHODReady) { _METHODContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METHOD"); _METHODReady = true; } return _METHODContent; } }
        private static Java.Lang.String _METHODContent = default;
        private static bool _METHODReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/OutputKeys.html#OMIT_XML_DECLARATION"/>
        /// </summary>
        public static Java.Lang.String OMIT_XML_DECLARATION { get { if (!_OMIT_XML_DECLARATIONReady) { _OMIT_XML_DECLARATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OMIT_XML_DECLARATION"); _OMIT_XML_DECLARATIONReady = true; } return _OMIT_XML_DECLARATIONContent; } }
        private static Java.Lang.String _OMIT_XML_DECLARATIONContent = default;
        private static bool _OMIT_XML_DECLARATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/OutputKeys.html#STANDALONE"/>
        /// </summary>
        public static Java.Lang.String STANDALONE { get { if (!_STANDALONEReady) { _STANDALONEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "STANDALONE"); _STANDALONEReady = true; } return _STANDALONEContent; } }
        private static Java.Lang.String _STANDALONEContent = default;
        private static bool _STANDALONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/OutputKeys.html#VERSION"/>
        /// </summary>
        public static Java.Lang.String VERSION { get { if (!_VERSIONReady) { _VERSIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "VERSION"); _VERSIONReady = true; } return _VERSIONContent; } }
        private static Java.Lang.String _VERSIONContent = default;
        private static bool _VERSIONReady = false; // this is used because in case of generics 

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