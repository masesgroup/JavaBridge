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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.Channels
{
    #region IAsynchronousByteChannel
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAsynchronousByteChannel : Java.Nio.Channels.IAsynchronousChannel
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousByteChannel.html#read(java.nio.ByteBuffer,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><typeparamref name="A"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg2objectSuperA"><typeparamref name="A"/></typeparam>
        void Read<A, Arg2objectSuperA>(Java.Nio.ByteBuffer arg0, A arg1, Java.Nio.Channels.CompletionHandler<Java.Lang.Integer, Arg2objectSuperA> arg2) where Arg2objectSuperA : A;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousByteChannel.html#write(java.nio.ByteBuffer,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><typeparamref name="A"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg2objectSuperA"><typeparamref name="A"/></typeparam>
        void Write<A, Arg2objectSuperA>(Java.Nio.ByteBuffer arg0, A arg1, Java.Nio.Channels.CompletionHandler<Java.Lang.Integer, Arg2objectSuperA> arg2) where Arg2objectSuperA : A;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousByteChannel.html#read(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        Java.Util.Concurrent.Future<Java.Lang.Integer> Read(Java.Nio.ByteBuffer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousByteChannel.html#write(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        Java.Util.Concurrent.Future<Java.Lang.Integer> Write(Java.Nio.ByteBuffer arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AsynchronousByteChannel
    public partial class AsynchronousByteChannel : Java.Nio.Channels.IAsynchronousByteChannel
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousByteChannel.html#read(java.nio.ByteBuffer,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><typeparamref name="A"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg2objectSuperA"><typeparamref name="A"/></typeparam>
        public void Read<A, Arg2objectSuperA>(Java.Nio.ByteBuffer arg0, A arg1, Java.Nio.Channels.CompletionHandler<Java.Lang.Integer, Arg2objectSuperA> arg2) where Arg2objectSuperA : A
        {
            IExecute("read", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousByteChannel.html#write(java.nio.ByteBuffer,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><typeparamref name="A"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg2objectSuperA"><typeparamref name="A"/></typeparam>
        public void Write<A, Arg2objectSuperA>(Java.Nio.ByteBuffer arg0, A arg1, Java.Nio.Channels.CompletionHandler<Java.Lang.Integer, Arg2objectSuperA> arg2) where Arg2objectSuperA : A
        {
            IExecute("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousByteChannel.html#read(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Java.Lang.Integer> Read(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<Java.Lang.Integer>>("read", "(Ljava/nio/ByteBuffer;)Ljava/util/concurrent/Future;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousByteChannel.html#write(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Java.Lang.Integer> Write(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<Java.Lang.Integer>>("write", "(Ljava/nio/ByteBuffer;)Ljava/util/concurrent/Future;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}