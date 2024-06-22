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
    #region IScatteringByteChannel
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IScatteringByteChannel : Java.Nio.Channels.IReadableByteChannel
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/ScatteringByteChannel.html#read(java.nio.ByteBuffer[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        long Read(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/ScatteringByteChannel.html#read(java.nio.ByteBuffer[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        long Read(Java.Nio.ByteBuffer[] arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ScatteringByteChannel
    public partial class ScatteringByteChannel : Java.Nio.Channels.IScatteringByteChannel
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/ScatteringByteChannel.html#read(java.nio.ByteBuffer[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Read(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2)
        {
            return IExecute<long>("read", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/ScatteringByteChannel.html#read(java.nio.ByteBuffer[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Read(Java.Nio.ByteBuffer[] arg0)
        {
            return IExecuteWithSignature<long>("read", "([Ljava/nio/ByteBuffer;)J", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}