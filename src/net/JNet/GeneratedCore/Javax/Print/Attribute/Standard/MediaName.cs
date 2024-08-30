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

namespace Javax.Print.Attribute.Standard
{
    #region MediaName definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MediaName.html"/>
    /// </summary>
    public partial class MediaName : Javax.Print.Attribute.Standard.Media
    {
        const string _bridgeClassName = "javax.print.attribute.standard.MediaName";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MediaName() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MediaName(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region MediaName
    public partial class MediaName
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.MediaName"/> to <see cref="Javax.Print.Attribute.Attribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.Attribute(Javax.Print.Attribute.Standard.MediaName t) => t.Cast<Javax.Print.Attribute.Attribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MediaName.html#ISO_A4_TRANSPARENT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MediaName ISO_A4_TRANSPARENT { get { if (!_ISO_A4_TRANSPARENTReady) { _ISO_A4_TRANSPARENTContent = SGetField<Javax.Print.Attribute.Standard.MediaName>(LocalBridgeClazz, "ISO_A4_TRANSPARENT"); _ISO_A4_TRANSPARENTReady = true; } return _ISO_A4_TRANSPARENTContent; } }
        private static Javax.Print.Attribute.Standard.MediaName _ISO_A4_TRANSPARENTContent = default;
        private static bool _ISO_A4_TRANSPARENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MediaName.html#ISO_A4_WHITE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MediaName ISO_A4_WHITE { get { if (!_ISO_A4_WHITEReady) { _ISO_A4_WHITEContent = SGetField<Javax.Print.Attribute.Standard.MediaName>(LocalBridgeClazz, "ISO_A4_WHITE"); _ISO_A4_WHITEReady = true; } return _ISO_A4_WHITEContent; } }
        private static Javax.Print.Attribute.Standard.MediaName _ISO_A4_WHITEContent = default;
        private static bool _ISO_A4_WHITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MediaName.html#NA_LETTER_TRANSPARENT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MediaName NA_LETTER_TRANSPARENT { get { if (!_NA_LETTER_TRANSPARENTReady) { _NA_LETTER_TRANSPARENTContent = SGetField<Javax.Print.Attribute.Standard.MediaName>(LocalBridgeClazz, "NA_LETTER_TRANSPARENT"); _NA_LETTER_TRANSPARENTReady = true; } return _NA_LETTER_TRANSPARENTContent; } }
        private static Javax.Print.Attribute.Standard.MediaName _NA_LETTER_TRANSPARENTContent = default;
        private static bool _NA_LETTER_TRANSPARENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MediaName.html#NA_LETTER_WHITE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MediaName NA_LETTER_WHITE { get { if (!_NA_LETTER_WHITEReady) { _NA_LETTER_WHITEContent = SGetField<Javax.Print.Attribute.Standard.MediaName>(LocalBridgeClazz, "NA_LETTER_WHITE"); _NA_LETTER_WHITEReady = true; } return _NA_LETTER_WHITEContent; } }
        private static Javax.Print.Attribute.Standard.MediaName _NA_LETTER_WHITEContent = default;
        private static bool _NA_LETTER_WHITEReady = false; // this is used because in case of generics 

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