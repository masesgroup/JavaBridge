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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print
{
    #region DocFlavor
    public partial class DocFlavor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public DocFlavor(string arg0, string arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.DocFlavor"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Print.DocFlavor t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.DocFlavor"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Print.DocFlavor t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.html#hostEncoding"/>
        /// </summary>
        public static string hostEncoding { get { return SGetField<string>(LocalBridgeClazz, "hostEncoding"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.html#getMediaSubtype()"/> 
        /// </summary>
        public string MediaSubtype
        {
            get { return IExecute<string>("getMediaSubtype"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.html#getMediaType()"/> 
        /// </summary>
        public string MediaType
        {
            get { return IExecute<string>("getMediaType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.html#getMimeType()"/> 
        /// </summary>
        public string MimeType
        {
            get { return IExecute<string>("getMimeType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.html#getRepresentationClassName()"/> 
        /// </summary>
        public string RepresentationClassName
        {
            get { return IExecute<string>("getRepresentationClassName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.html#getParameter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetParameter(string arg0)
        {
            return IExecute<string>("getParameter", arg0);
        }

        #endregion

        #region Nested classes
        #region BYTE_ARRAY
        public partial class BYTE_ARRAY
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            public BYTE_ARRAY(string arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#AUTOSENSE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY AUTOSENSE { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "AUTOSENSE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#GIF"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY GIF { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "GIF"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#JPEG"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY JPEG { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "JPEG"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#PCL"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY PCL { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "PCL"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#PDF"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY PDF { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "PDF"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#PNG"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY PNG { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "PNG"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#POSTSCRIPT"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY POSTSCRIPT { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "POSTSCRIPT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#TEXT_HTML_HOST"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY TEXT_HTML_HOST { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "TEXT_HTML_HOST"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#TEXT_HTML_US_ASCII"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY TEXT_HTML_US_ASCII { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "TEXT_HTML_US_ASCII"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#TEXT_HTML_UTF_16"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY TEXT_HTML_UTF_16 { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "TEXT_HTML_UTF_16"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#TEXT_HTML_UTF_16BE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY TEXT_HTML_UTF_16BE { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "TEXT_HTML_UTF_16BE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#TEXT_HTML_UTF_16LE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY TEXT_HTML_UTF_16LE { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "TEXT_HTML_UTF_16LE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#TEXT_HTML_UTF_8"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY TEXT_HTML_UTF_8 { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "TEXT_HTML_UTF_8"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#TEXT_PLAIN_HOST"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY TEXT_PLAIN_HOST { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "TEXT_PLAIN_HOST"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#TEXT_PLAIN_US_ASCII"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY TEXT_PLAIN_US_ASCII { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "TEXT_PLAIN_US_ASCII"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#TEXT_PLAIN_UTF_16"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY TEXT_PLAIN_UTF_16 { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "TEXT_PLAIN_UTF_16"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#TEXT_PLAIN_UTF_16BE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY TEXT_PLAIN_UTF_16BE { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "TEXT_PLAIN_UTF_16BE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#TEXT_PLAIN_UTF_16LE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY TEXT_PLAIN_UTF_16LE { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "TEXT_PLAIN_UTF_16LE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.BYTE_ARRAY.html#TEXT_PLAIN_UTF_8"/>
            /// </summary>
            public static Javax.Print.DocFlavor.BYTE_ARRAY TEXT_PLAIN_UTF_8 { get { return SGetField<Javax.Print.DocFlavor.BYTE_ARRAY>(LocalBridgeClazz, "TEXT_PLAIN_UTF_8"); } }

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

        #region CHAR_ARRAY
        public partial class CHAR_ARRAY
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.CHAR_ARRAY.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            public CHAR_ARRAY(string arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.CHAR_ARRAY.html#TEXT_HTML"/>
            /// </summary>
            public static Javax.Print.DocFlavor.CHAR_ARRAY TEXT_HTML { get { return SGetField<Javax.Print.DocFlavor.CHAR_ARRAY>(LocalBridgeClazz, "TEXT_HTML"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.CHAR_ARRAY.html#TEXT_PLAIN"/>
            /// </summary>
            public static Javax.Print.DocFlavor.CHAR_ARRAY TEXT_PLAIN { get { return SGetField<Javax.Print.DocFlavor.CHAR_ARRAY>(LocalBridgeClazz, "TEXT_PLAIN"); } }

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

        #region INPUT_STREAM
        public partial class INPUT_STREAM
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            public INPUT_STREAM(string arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#AUTOSENSE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM AUTOSENSE { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "AUTOSENSE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#GIF"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM GIF { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "GIF"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#JPEG"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM JPEG { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "JPEG"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#PCL"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM PCL { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "PCL"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#PDF"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM PDF { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "PDF"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#PNG"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM PNG { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "PNG"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#POSTSCRIPT"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM POSTSCRIPT { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "POSTSCRIPT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#TEXT_HTML_HOST"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM TEXT_HTML_HOST { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "TEXT_HTML_HOST"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#TEXT_HTML_US_ASCII"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM TEXT_HTML_US_ASCII { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "TEXT_HTML_US_ASCII"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#TEXT_HTML_UTF_16"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM TEXT_HTML_UTF_16 { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "TEXT_HTML_UTF_16"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#TEXT_HTML_UTF_16BE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM TEXT_HTML_UTF_16BE { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "TEXT_HTML_UTF_16BE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#TEXT_HTML_UTF_16LE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM TEXT_HTML_UTF_16LE { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "TEXT_HTML_UTF_16LE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#TEXT_HTML_UTF_8"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM TEXT_HTML_UTF_8 { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "TEXT_HTML_UTF_8"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#TEXT_PLAIN_HOST"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM TEXT_PLAIN_HOST { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "TEXT_PLAIN_HOST"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#TEXT_PLAIN_US_ASCII"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM TEXT_PLAIN_US_ASCII { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "TEXT_PLAIN_US_ASCII"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#TEXT_PLAIN_UTF_16"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM TEXT_PLAIN_UTF_16 { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "TEXT_PLAIN_UTF_16"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#TEXT_PLAIN_UTF_16BE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM TEXT_PLAIN_UTF_16BE { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "TEXT_PLAIN_UTF_16BE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#TEXT_PLAIN_UTF_16LE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM TEXT_PLAIN_UTF_16LE { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "TEXT_PLAIN_UTF_16LE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.INPUT_STREAM.html#TEXT_PLAIN_UTF_8"/>
            /// </summary>
            public static Javax.Print.DocFlavor.INPUT_STREAM TEXT_PLAIN_UTF_8 { get { return SGetField<Javax.Print.DocFlavor.INPUT_STREAM>(LocalBridgeClazz, "TEXT_PLAIN_UTF_8"); } }

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

        #region READER
        public partial class READER
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.READER.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            public READER(string arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.READER.html#TEXT_HTML"/>
            /// </summary>
            public static Javax.Print.DocFlavor.READER TEXT_HTML { get { return SGetField<Javax.Print.DocFlavor.READER>(LocalBridgeClazz, "TEXT_HTML"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.READER.html#TEXT_PLAIN"/>
            /// </summary>
            public static Javax.Print.DocFlavor.READER TEXT_PLAIN { get { return SGetField<Javax.Print.DocFlavor.READER>(LocalBridgeClazz, "TEXT_PLAIN"); } }

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

        #region SERVICE_FORMATTED
        public partial class SERVICE_FORMATTED
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.SERVICE_FORMATTED.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            public SERVICE_FORMATTED(string arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.SERVICE_FORMATTED.html#PAGEABLE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.SERVICE_FORMATTED PAGEABLE { get { return SGetField<Javax.Print.DocFlavor.SERVICE_FORMATTED>(LocalBridgeClazz, "PAGEABLE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.SERVICE_FORMATTED.html#PRINTABLE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.SERVICE_FORMATTED PRINTABLE { get { return SGetField<Javax.Print.DocFlavor.SERVICE_FORMATTED>(LocalBridgeClazz, "PRINTABLE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.SERVICE_FORMATTED.html#RENDERABLE_IMAGE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.SERVICE_FORMATTED RENDERABLE_IMAGE { get { return SGetField<Javax.Print.DocFlavor.SERVICE_FORMATTED>(LocalBridgeClazz, "RENDERABLE_IMAGE"); } }

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

        #region STRING
        public partial class STRING
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.STRING.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            public STRING(string arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.STRING.html#TEXT_HTML"/>
            /// </summary>
            public static Javax.Print.DocFlavor.STRING TEXT_HTML { get { return SGetField<Javax.Print.DocFlavor.STRING>(LocalBridgeClazz, "TEXT_HTML"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.STRING.html#TEXT_PLAIN"/>
            /// </summary>
            public static Javax.Print.DocFlavor.STRING TEXT_PLAIN { get { return SGetField<Javax.Print.DocFlavor.STRING>(LocalBridgeClazz, "TEXT_PLAIN"); } }

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

        #region URL
        public partial class URL
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            public URL(string arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#AUTOSENSE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL AUTOSENSE { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "AUTOSENSE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#GIF"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL GIF { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "GIF"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#JPEG"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL JPEG { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "JPEG"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#PCL"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL PCL { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "PCL"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#PDF"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL PDF { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "PDF"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#PNG"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL PNG { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "PNG"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#POSTSCRIPT"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL POSTSCRIPT { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "POSTSCRIPT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#TEXT_HTML_HOST"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL TEXT_HTML_HOST { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "TEXT_HTML_HOST"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#TEXT_HTML_US_ASCII"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL TEXT_HTML_US_ASCII { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "TEXT_HTML_US_ASCII"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#TEXT_HTML_UTF_16"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL TEXT_HTML_UTF_16 { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "TEXT_HTML_UTF_16"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#TEXT_HTML_UTF_16BE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL TEXT_HTML_UTF_16BE { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "TEXT_HTML_UTF_16BE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#TEXT_HTML_UTF_16LE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL TEXT_HTML_UTF_16LE { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "TEXT_HTML_UTF_16LE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#TEXT_HTML_UTF_8"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL TEXT_HTML_UTF_8 { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "TEXT_HTML_UTF_8"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#TEXT_PLAIN_HOST"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL TEXT_PLAIN_HOST { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "TEXT_PLAIN_HOST"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#TEXT_PLAIN_US_ASCII"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL TEXT_PLAIN_US_ASCII { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "TEXT_PLAIN_US_ASCII"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#TEXT_PLAIN_UTF_16"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL TEXT_PLAIN_UTF_16 { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "TEXT_PLAIN_UTF_16"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#TEXT_PLAIN_UTF_16BE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL TEXT_PLAIN_UTF_16BE { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "TEXT_PLAIN_UTF_16BE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#TEXT_PLAIN_UTF_16LE"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL TEXT_PLAIN_UTF_16LE { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "TEXT_PLAIN_UTF_16LE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocFlavor.URL.html#TEXT_PLAIN_UTF_8"/>
            /// </summary>
            public static Javax.Print.DocFlavor.URL TEXT_PLAIN_UTF_8 { get { return SGetField<Javax.Print.DocFlavor.URL>(LocalBridgeClazz, "TEXT_PLAIN_UTF_8"); } }

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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}