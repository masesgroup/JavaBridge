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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net.Http
{
    #region IWebSocket
    public partial interface IWebSocket
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#isInputClosed()"/> 
        /// </summary>
        bool IsInputClosed { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#isOutputClosed()"/> 
        /// </summary>
        bool IsOutputClosed { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#getSubprotocol()"/> 
        /// </summary>
        string Subprotocol { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendBinary(java.nio.ByteBuffer,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket> SendBinary(Java.Nio.ByteBuffer arg0, bool arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendClose(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket> SendClose(int arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendPing(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket> SendPing(Java.Nio.ByteBuffer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendPong(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket> SendPong(Java.Nio.ByteBuffer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendText(java.lang.CharSequence,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket> SendText(Java.Lang.CharSequence arg0, bool arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#abort()"/>
        /// </summary>
        void Abort();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#request(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        void Request(long arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WebSocket
    public partial class WebSocket : Java.Net.Http.IWebSocket
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#NORMAL_CLOSURE"/>
        /// </summary>
        public static int NORMAL_CLOSURE { get { return SGetField<int>(LocalBridgeClazz, "NORMAL_CLOSURE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#isInputClosed()"/> 
        /// </summary>
        public bool IsInputClosed
        {
            get { return IExecute<bool>("isInputClosed"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#isOutputClosed()"/> 
        /// </summary>
        public bool IsOutputClosed
        {
            get { return IExecute<bool>("isOutputClosed"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#getSubprotocol()"/> 
        /// </summary>
        public string Subprotocol
        {
            get { return IExecute<string>("getSubprotocol"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendBinary(java.nio.ByteBuffer,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket> SendBinary(Java.Nio.ByteBuffer arg0, bool arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket>>("sendBinary", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendClose(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket> SendClose(int arg0, string arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket>>("sendClose", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendPing(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket> SendPing(Java.Nio.ByteBuffer arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket>>("sendPing", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendPong(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket> SendPong(Java.Nio.ByteBuffer arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket>>("sendPong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendText(java.lang.CharSequence,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket> SendText(Java.Lang.CharSequence arg0, bool arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket>>("sendText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#abort()"/>
        /// </summary>
        public void Abort()
        {
            IExecute("abort");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#request(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Request(long arg0)
        {
            IExecute("request", arg0);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Builder.html#connectTimeout(java.time.Duration)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
            /// <returns><see cref="Java.Net.Http.WebSocket.Builder"/></returns>
            public Java.Net.Http.WebSocket.Builder ConnectTimeout(Java.Time.Duration arg0)
            {
                return IExecute<Java.Net.Http.WebSocket.Builder>("connectTimeout", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Builder.html#header(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <returns><see cref="Java.Net.Http.WebSocket.Builder"/></returns>
            public Java.Net.Http.WebSocket.Builder Header(string arg0, string arg1)
            {
                return IExecute<Java.Net.Http.WebSocket.Builder>("header", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Builder.html#subprotocols(java.lang.String,java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <returns><see cref="Java.Net.Http.WebSocket.Builder"/></returns>
            public Java.Net.Http.WebSocket.Builder Subprotocols(string arg0, params string[] arg1)
            {
                if (arg1.Length == 0) return IExecute<Java.Net.Http.WebSocket.Builder>("subprotocols", arg0); else return IExecute<Java.Net.Http.WebSocket.Builder>("subprotocols", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Builder.html#buildAsync(java.net.URI,java.net.http.WebSocket.Listener)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.URI"/></param>
            /// <param name="arg1"><see cref="Java.Net.Http.WebSocket.Listener"/></param>
            /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
            public Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket> BuildAsync(Java.Net.URI arg0, Java.Net.Http.WebSocket.Listener arg1)
            {
                return IExecute<Java.Util.Concurrent.CompletableFuture<Java.Net.Http.WebSocket>>("buildAsync", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Listener
        public partial class Listener
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Listener.html#onBinary(java.net.http.WebSocket,java.nio.ByteBuffer,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Http.WebSocket"/></param>
            /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
            public virtual Java.Util.Concurrent.CompletionStage<object> OnBinary(Java.Net.Http.WebSocket arg0, Java.Nio.ByteBuffer arg1, bool arg2)
            {
                return default;
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Listener.html#onClose(java.net.http.WebSocket,int,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Http.WebSocket"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="string"/></param>
            /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
            public virtual Java.Util.Concurrent.CompletionStage<object> OnClose(Java.Net.Http.WebSocket arg0, int arg1, string arg2)
            {
                return default;
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Listener.html#onPing(java.net.http.WebSocket,java.nio.ByteBuffer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Http.WebSocket"/></param>
            /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
            /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
            public virtual Java.Util.Concurrent.CompletionStage<object> OnPing(Java.Net.Http.WebSocket arg0, Java.Nio.ByteBuffer arg1)
            {
                return default;
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Listener.html#onPong(java.net.http.WebSocket,java.nio.ByteBuffer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Http.WebSocket"/></param>
            /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
            /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
            public virtual Java.Util.Concurrent.CompletionStage<object> OnPong(Java.Net.Http.WebSocket arg0, Java.Nio.ByteBuffer arg1)
            {
                return default;
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Listener.html#onText(java.net.http.WebSocket,java.lang.CharSequence,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Http.WebSocket"/></param>
            /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
            public virtual Java.Util.Concurrent.CompletionStage<object> OnText(Java.Net.Http.WebSocket arg0, Java.Lang.CharSequence arg1, bool arg2)
            {
                return default;
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Listener.html#onError(java.net.http.WebSocket,java.lang.Throwable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Http.WebSocket"/></param>
            /// <param name="arg1"><see cref="Java.Lang.Throwable"/></param>
            public virtual void OnError(Java.Net.Http.WebSocket arg0, Java.Lang.Throwable arg1)
            {
                
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Listener.html#onOpen(java.net.http.WebSocket)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Http.WebSocket"/></param>
            public virtual void OnOpen(Java.Net.Http.WebSocket arg0)
            {
                
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