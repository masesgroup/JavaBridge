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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.Channels
{
    #region AsynchronousSocketChannel
    public partial class AsynchronousSocketChannel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.AsynchronousSocketChannel"/> to <see cref="Java.Nio.Channels.AsynchronousByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.AsynchronousByteChannel(Java.Nio.Channels.AsynchronousSocketChannel t) => t.Cast<Java.Nio.Channels.AsynchronousByteChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.AsynchronousSocketChannel"/> to <see cref="Java.Nio.Channels.NetworkChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.NetworkChannel(Java.Nio.Channels.AsynchronousSocketChannel t) => t.Cast<Java.Nio.Channels.NetworkChannel>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#open()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.Channels.AsynchronousSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.AsynchronousSocketChannel Open()
        {
            return SExecute<Java.Nio.Channels.AsynchronousSocketChannel>(LocalClazz, "open");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#open(java.nio.channels.AsynchronousChannelGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.AsynchronousChannelGroup"/></param>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.AsynchronousSocketChannel Open(Java.Nio.Channels.AsynchronousChannelGroup arg0)
        {
            return SExecute<Java.Nio.Channels.AsynchronousSocketChannel>(LocalClazz, "open", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#getLocalAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress LocalAddress
        {
            get { return IExecute<Java.Net.SocketAddress>("getLocalAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#provider()"/> 
        /// </summary>
        public Java.Nio.Channels.Spi.AsynchronousChannelProvider Provider
        {
            get { return IExecute<Java.Nio.Channels.Spi.AsynchronousChannelProvider>("provider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#getRemoteAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress RemoteAddress
        {
            get { return IExecute<Java.Net.SocketAddress>("getRemoteAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#shutdownInput()"/> 
        /// </summary>
        public Java.Nio.Channels.AsynchronousSocketChannel ShutdownInput
        {
            get { return IExecute<Java.Nio.Channels.AsynchronousSocketChannel>("shutdownInput"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#shutdownOutput()"/> 
        /// </summary>
        public Java.Nio.Channels.AsynchronousSocketChannel ShutdownOutput
        {
            get { return IExecute<Java.Nio.Channels.AsynchronousSocketChannel>("shutdownOutput"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#connect(java.net.SocketAddress,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg1"><see cref="A"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        public void Connect<A, Arg2objectSuperA>(Java.Net.SocketAddress arg0, A arg1, Java.Nio.Channels.CompletionHandler<Java.Lang.Void, Arg2objectSuperA> arg2) where Arg2objectSuperA: A
        {
            IExecute("connect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#read(java.nio.ByteBuffer,long,java.util.concurrent.TimeUnit,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg3"><see cref="A"/></param>
        /// <param name="arg4"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        public void Read<A, Arg4objectSuperA>(Java.Nio.ByteBuffer arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2, A arg3, Java.Nio.Channels.CompletionHandler<int?, Arg4objectSuperA> arg4) where Arg4objectSuperA: A
        {
            IExecute("read", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#read(java.nio.ByteBuffer[],int,int,long,java.util.concurrent.TimeUnit,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg5"><see cref="A"/></param>
        /// <param name="arg6"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        public void Read<A, Arg6objectSuperA>(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2, long arg3, Java.Util.Concurrent.TimeUnit arg4, A arg5, Java.Nio.Channels.CompletionHandler<long?, Arg6objectSuperA> arg6) where Arg6objectSuperA: A
        {
            IExecute("read", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#write(java.nio.ByteBuffer,long,java.util.concurrent.TimeUnit,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg3"><see cref="A"/></param>
        /// <param name="arg4"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        public void Write<A, Arg4objectSuperA>(Java.Nio.ByteBuffer arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2, A arg3, Java.Nio.Channels.CompletionHandler<int?, Arg4objectSuperA> arg4) where Arg4objectSuperA: A
        {
            IExecute("write", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#write(java.nio.ByteBuffer[],int,int,long,java.util.concurrent.TimeUnit,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg5"><see cref="A"/></param>
        /// <param name="arg6"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        public void Write<A, Arg6objectSuperA>(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2, long arg3, Java.Util.Concurrent.TimeUnit arg4, A arg5, Java.Nio.Channels.CompletionHandler<long?, Arg6objectSuperA> arg6) where Arg6objectSuperA: A
        {
            IExecute("write", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#read(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<int?> Read(Java.Nio.ByteBuffer arg0)
        {
            return IExecute<Java.Util.Concurrent.Future<int?>>("read", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#write(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<int?> Write(Java.Nio.ByteBuffer arg0)
        {
            return IExecute<Java.Util.Concurrent.Future<int?>>("write", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#connect(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Java.Lang.Void> Connect(Java.Net.SocketAddress arg0)
        {
            return IExecute<Java.Util.Concurrent.Future<Java.Lang.Void>>("connect", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#read(java.nio.ByteBuffer,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="A"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        public void Read<A, Arg2objectSuperA>(Java.Nio.ByteBuffer arg0, A arg1, Java.Nio.Channels.CompletionHandler<int?, Arg2objectSuperA> arg2) where Arg2objectSuperA: A
        {
            IExecute("read", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#write(java.nio.ByteBuffer,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="A"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        public void Write<A, Arg2objectSuperA>(Java.Nio.ByteBuffer arg0, A arg1, Java.Nio.Channels.CompletionHandler<int?, Arg2objectSuperA> arg2) where Arg2objectSuperA: A
        {
            IExecute("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#bind(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.NetworkChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.NetworkChannel Bind(Java.Net.SocketAddress arg0)
        {
            return IExecute<Java.Nio.Channels.NetworkChannel>("bind", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousSocketChannel.html#setOption(java.net.SocketOption,java.lang.Object)"/>
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