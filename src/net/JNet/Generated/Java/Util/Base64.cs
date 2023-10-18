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

namespace Java.Util
{
    #region Base64
    public partial class Base64
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html#getDecoder()"/> 
        /// </summary>
        public static Java.Util.Base64.Decoder GetDecoder
        {
            get { return SExecute<Java.Util.Base64.Decoder>(LocalBridgeClazz, "getDecoder"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html#getEncoder()"/> 
        /// </summary>
        public static Java.Util.Base64.Encoder GetEncoder
        {
            get { return SExecute<Java.Util.Base64.Encoder>(LocalBridgeClazz, "getEncoder"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html#getMimeDecoder()"/> 
        /// </summary>
        public static Java.Util.Base64.Decoder MimeDecoder
        {
            get { return SExecute<Java.Util.Base64.Decoder>(LocalBridgeClazz, "getMimeDecoder"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html#getMimeEncoder()"/> 
        /// </summary>
        public static Java.Util.Base64.Encoder MimeEncoder
        {
            get { return SExecute<Java.Util.Base64.Encoder>(LocalBridgeClazz, "getMimeEncoder"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html#getUrlDecoder()"/> 
        /// </summary>
        public static Java.Util.Base64.Decoder UrlDecoder
        {
            get { return SExecute<Java.Util.Base64.Decoder>(LocalBridgeClazz, "getUrlDecoder"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html#getUrlEncoder()"/> 
        /// </summary>
        public static Java.Util.Base64.Encoder UrlEncoder
        {
            get { return SExecute<Java.Util.Base64.Encoder>(LocalBridgeClazz, "getUrlEncoder"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html#getMimeEncoder(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Java.Util.Base64.Encoder"/></returns>
        public static Java.Util.Base64.Encoder GetMimeEncoder(int arg0, byte[] arg1)
        {
            return SExecute<Java.Util.Base64.Encoder>(LocalBridgeClazz, "getMimeEncoder", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Decoder
        public partial class Decoder
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Decoder.html#decode(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="byte"/></returns>
            public byte[] Decode(byte[] arg0)
            {
                return IExecuteArray<byte>("decode", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Decoder.html#decode(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="byte"/></returns>
            public byte[] Decode(string arg0)
            {
                return IExecuteArray<byte>("decode", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Decoder.html#decode(byte[],byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <returns><see cref="int"/></returns>
            public int Decode(byte[] arg0, byte[] arg1)
            {
                return IExecute<int>("decode", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Decoder.html#wrap(java.io.InputStream)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
            /// <returns><see cref="Java.Io.InputStream"/></returns>
            public Java.Io.InputStream Wrap(Java.Io.InputStream arg0)
            {
                return IExecute<Java.Io.InputStream>("wrap", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Decoder.html#decode(java.nio.ByteBuffer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
            /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
            public Java.Nio.ByteBuffer Decode(Java.Nio.ByteBuffer arg0)
            {
                return IExecute<Java.Nio.ByteBuffer>("decode", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Encoder
        public partial class Encoder
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Encoder.html#encode(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="byte"/></returns>
            public byte[] Encode(byte[] arg0)
            {
                return IExecuteArray<byte>("encode", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Encoder.html#encode(byte[],byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <returns><see cref="int"/></returns>
            public int Encode(byte[] arg0, byte[] arg1)
            {
                return IExecute<int>("encode", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Encoder.html#wrap(java.io.OutputStream)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
            /// <returns><see cref="Java.Io.OutputStream"/></returns>
            public Java.Io.OutputStream Wrap(Java.Io.OutputStream arg0)
            {
                return IExecute<Java.Io.OutputStream>("wrap", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Encoder.html#encodeToString(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="string"/></returns>
            public string EncodeToString(byte[] arg0)
            {
                return IExecute<string>("encodeToString", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Encoder.html#encode(java.nio.ByteBuffer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
            /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
            public Java.Nio.ByteBuffer Encode(Java.Nio.ByteBuffer arg0)
            {
                return IExecute<Java.Nio.ByteBuffer>("encode", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Encoder.html#withoutPadding()"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Base64.Encoder"/></returns>
            public Java.Util.Base64.Encoder WithoutPadding()
            {
                return IExecute<Java.Util.Base64.Encoder>("withoutPadding");
            }

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