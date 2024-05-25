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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.Channels
{
    #region AsynchronousServerSocketChannel
    public partial class AsynchronousServerSocketChannel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.AsynchronousServerSocketChannel"/> to <see cref="Java.Nio.Channels.AsynchronousChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.AsynchronousChannel(Java.Nio.Channels.AsynchronousServerSocketChannel t) => t.Cast<Java.Nio.Channels.AsynchronousChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.AsynchronousServerSocketChannel"/> to <see cref="Java.Nio.Channels.NetworkChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.NetworkChannel(Java.Nio.Channels.AsynchronousServerSocketChannel t) => t.Cast<Java.Nio.Channels.NetworkChannel>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousServerSocketChannel.html#open()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousServerSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.AsynchronousServerSocketChannel Open()
        {
            return SExecuteWithSignature<Java.Nio.Channels.AsynchronousServerSocketChannel>(LocalBridgeClazz, "open", "()Ljava/nio/channels/AsynchronousServerSocketChannel;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousServerSocketChannel.html#open(java.nio.channels.AsynchronousChannelGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.AsynchronousChannelGroup"/></param>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousServerSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.AsynchronousServerSocketChannel Open(Java.Nio.Channels.AsynchronousChannelGroup arg0)
        {
            return SExecuteWithSignature<Java.Nio.Channels.AsynchronousServerSocketChannel>(LocalBridgeClazz, "open", "(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousServerSocketChannel;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousServerSocketChannel.html#getLocalAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress LocalAddress
        {
            get { return IExecuteWithSignature<Java.Net.SocketAddress>("getLocalAddress", "()Ljava/net/SocketAddress;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousServerSocketChannel.html#accept(java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="A"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg1objectSuperA"><typeparamref name="A"/></typeparam>
        public void Accept<A, Arg1objectSuperA>(A arg0, Java.Nio.Channels.CompletionHandler<Java.Nio.Channels.AsynchronousSocketChannel, Arg1objectSuperA> arg1) where Arg1objectSuperA: A
        {
            IExecute("accept", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousServerSocketChannel.html#bind(java.net.SocketAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousServerSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.AsynchronousServerSocketChannel Bind(Java.Net.SocketAddress arg0, int arg1)
        {
            return IExecute<Java.Nio.Channels.AsynchronousServerSocketChannel>("bind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousServerSocketChannel.html#accept()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Java.Nio.Channels.AsynchronousSocketChannel> Accept()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<Java.Nio.Channels.AsynchronousSocketChannel>>("accept", "()Ljava/util/concurrent/Future;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousServerSocketChannel.html#provider()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.Spi.AsynchronousChannelProvider"/></returns>
        public Java.Nio.Channels.Spi.AsynchronousChannelProvider Provider()
        {
            return IExecuteWithSignature<Java.Nio.Channels.Spi.AsynchronousChannelProvider>("provider", "()Ljava/nio/channels/spi/AsynchronousChannelProvider;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousServerSocketChannel.html#bind(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.NetworkChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.NetworkChannel Bind(Java.Net.SocketAddress arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.NetworkChannel>("bind", "(Ljava/net/SocketAddress;)Ljava/nio/channels/NetworkChannel;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousServerSocketChannel.html#setOption(java.net.SocketOption,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketOption"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Nio.Channels.NetworkChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.NetworkChannel SetOption(Java.Net.SocketOption arg0, object arg1)
        {
            return IExecute<Java.Nio.Channels.NetworkChannel>("setOption", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}