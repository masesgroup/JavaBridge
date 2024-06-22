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

namespace Java.Nio.Channels
{
    #region Channels
    public partial class Channels
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Channels.html#newInputStream(java.nio.channels.AsynchronousByteChannel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.AsynchronousByteChannel"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        public static Java.Io.InputStream NewInputStream(Java.Nio.Channels.AsynchronousByteChannel arg0)
        {
            return SExecuteWithSignature<Java.Io.InputStream>(LocalBridgeClazz, "newInputStream", "(Ljava/nio/channels/AsynchronousByteChannel;)Ljava/io/InputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Channels.html#newInputStream(java.nio.channels.ReadableByteChannel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.ReadableByteChannel"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        public static Java.Io.InputStream NewInputStream(Java.Nio.Channels.ReadableByteChannel arg0)
        {
            return SExecuteWithSignature<Java.Io.InputStream>(LocalBridgeClazz, "newInputStream", "(Ljava/nio/channels/ReadableByteChannel;)Ljava/io/InputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Channels.html#newOutputStream(java.nio.channels.AsynchronousByteChannel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.AsynchronousByteChannel"/></param>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        public static Java.Io.OutputStream NewOutputStream(Java.Nio.Channels.AsynchronousByteChannel arg0)
        {
            return SExecuteWithSignature<Java.Io.OutputStream>(LocalBridgeClazz, "newOutputStream", "(Ljava/nio/channels/AsynchronousByteChannel;)Ljava/io/OutputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Channels.html#newOutputStream(java.nio.channels.WritableByteChannel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.WritableByteChannel"/></param>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        public static Java.Io.OutputStream NewOutputStream(Java.Nio.Channels.WritableByteChannel arg0)
        {
            return SExecuteWithSignature<Java.Io.OutputStream>(LocalBridgeClazz, "newOutputStream", "(Ljava/nio/channels/WritableByteChannel;)Ljava/io/OutputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Channels.html#newReader(java.nio.channels.ReadableByteChannel,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.ReadableByteChannel"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        public static Java.Io.Reader NewReader(Java.Nio.Channels.ReadableByteChannel arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Io.Reader>(LocalBridgeClazz, "newReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Channels.html#newReader(java.nio.channels.ReadableByteChannel,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.ReadableByteChannel"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        public static Java.Io.Reader NewReader(Java.Nio.Channels.ReadableByteChannel arg0, Java.Nio.Charset.Charset arg1)
        {
            return SExecute<Java.Io.Reader>(LocalBridgeClazz, "newReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Channels.html#newReader(java.nio.channels.ReadableByteChannel,java.nio.charset.CharsetDecoder,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.ReadableByteChannel"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.CharsetDecoder"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        public static Java.Io.Reader NewReader(Java.Nio.Channels.ReadableByteChannel arg0, Java.Nio.Charset.CharsetDecoder arg1, int arg2)
        {
            return SExecute<Java.Io.Reader>(LocalBridgeClazz, "newReader", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Channels.html#newWriter(java.nio.channels.WritableByteChannel,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.WritableByteChannel"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Io.Writer"/></returns>
        public static Java.Io.Writer NewWriter(Java.Nio.Channels.WritableByteChannel arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Io.Writer>(LocalBridgeClazz, "newWriter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Channels.html#newWriter(java.nio.channels.WritableByteChannel,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.WritableByteChannel"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <returns><see cref="Java.Io.Writer"/></returns>
        public static Java.Io.Writer NewWriter(Java.Nio.Channels.WritableByteChannel arg0, Java.Nio.Charset.Charset arg1)
        {
            return SExecute<Java.Io.Writer>(LocalBridgeClazz, "newWriter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Channels.html#newWriter(java.nio.channels.WritableByteChannel,java.nio.charset.CharsetEncoder,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.WritableByteChannel"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.CharsetEncoder"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Io.Writer"/></returns>
        public static Java.Io.Writer NewWriter(Java.Nio.Channels.WritableByteChannel arg0, Java.Nio.Charset.CharsetEncoder arg1, int arg2)
        {
            return SExecute<Java.Io.Writer>(LocalBridgeClazz, "newWriter", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Channels.html#newChannel(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Nio.Channels.ReadableByteChannel"/></returns>
        public static Java.Nio.Channels.ReadableByteChannel NewChannel(Java.Io.InputStream arg0)
        {
            return SExecuteWithSignature<Java.Nio.Channels.ReadableByteChannel>(LocalBridgeClazz, "newChannel", "(Ljava/io/InputStream;)Ljava/nio/channels/ReadableByteChannel;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Channels.html#newChannel(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <returns><see cref="Java.Nio.Channels.WritableByteChannel"/></returns>
        public static Java.Nio.Channels.WritableByteChannel NewChannel(Java.Io.OutputStream arg0)
        {
            return SExecuteWithSignature<Java.Nio.Channels.WritableByteChannel>(LocalBridgeClazz, "newChannel", "(Ljava/io/OutputStream;)Ljava/nio/channels/WritableByteChannel;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}