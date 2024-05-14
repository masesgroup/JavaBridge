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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.Channels
{
    #region IByteChannel
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IByteChannel
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ByteChannel
    public partial class ByteChannel : Java.Nio.Channels.IByteChannel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.ByteChannel"/> to <see cref="Java.Nio.Channels.ReadableByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.ReadableByteChannel(Java.Nio.Channels.ByteChannel t) => t.Cast<Java.Nio.Channels.ReadableByteChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.ByteChannel"/> to <see cref="Java.Nio.Channels.WritableByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.WritableByteChannel(Java.Nio.Channels.ByteChannel t) => t.Cast<Java.Nio.Channels.WritableByteChannel>();

        #endregion

        #region Fields

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