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

namespace Java.Nio.Channels
{
    #region Pipe
    public partial class Pipe
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Pipe.html#open()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Channels.Pipe"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.Pipe Open()
        {
            return SExecute<Java.Nio.Channels.Pipe>(LocalBridgeClazz, "open");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Pipe.html#sink()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Channels.Pipe.SinkChannel"/></returns>
        public Java.Nio.Channels.Pipe.SinkChannel Sink()
        {
            return IExecute<Java.Nio.Channels.Pipe.SinkChannel>("sink");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Pipe.html#source()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Channels.Pipe.SourceChannel"/></returns>
        public Java.Nio.Channels.Pipe.SourceChannel Source()
        {
            return IExecute<Java.Nio.Channels.Pipe.SourceChannel>("source");
        }

        #endregion

        #region Nested classes
        #region SinkChannel
        public partial class SinkChannel
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Nio.Channels.Pipe.SinkChannel"/> to <see cref="Java.Nio.Channels.WritableByteChannel"/>
            /// </summary>
            public static implicit operator Java.Nio.Channels.WritableByteChannel(Java.Nio.Channels.Pipe.SinkChannel t) => t.Cast<Java.Nio.Channels.WritableByteChannel>();
            /// <summary>
            /// Converter from <see cref="Java.Nio.Channels.Pipe.SinkChannel"/> to <see cref="Java.Nio.Channels.GatheringByteChannel"/>
            /// </summary>
            public static implicit operator Java.Nio.Channels.GatheringByteChannel(Java.Nio.Channels.Pipe.SinkChannel t) => t.Cast<Java.Nio.Channels.GatheringByteChannel>();

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

        #region SourceChannel
        public partial class SourceChannel
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Nio.Channels.Pipe.SourceChannel"/> to <see cref="Java.Nio.Channels.ReadableByteChannel"/>
            /// </summary>
            public static implicit operator Java.Nio.Channels.ReadableByteChannel(Java.Nio.Channels.Pipe.SourceChannel t) => t.Cast<Java.Nio.Channels.ReadableByteChannel>();
            /// <summary>
            /// Converter from <see cref="Java.Nio.Channels.Pipe.SourceChannel"/> to <see cref="Java.Nio.Channels.ScatteringByteChannel"/>
            /// </summary>
            public static implicit operator Java.Nio.Channels.ScatteringByteChannel(Java.Nio.Channels.Pipe.SourceChannel t) => t.Cast<Java.Nio.Channels.ScatteringByteChannel>();

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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}