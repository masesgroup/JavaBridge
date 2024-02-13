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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Net
{
    #region SocketFactory
    public partial class SocketFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/SocketFactory.html#getDefault()"/> 
        /// </summary>
        public static Javax.Net.SocketFactory Default
        {
            get { return SExecute<Javax.Net.SocketFactory>(LocalBridgeClazz, "getDefault"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/SocketFactory.html#createSocket(java.lang.String,int,java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Net.Socket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Net.UnknownHostException"/>
        public Java.Net.Socket CreateSocket(Java.Lang.String arg0, int arg1, Java.Net.InetAddress arg2, int arg3)
        {
            return IExecute<Java.Net.Socket>("createSocket", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/SocketFactory.html#createSocket(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Net.Socket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Net.UnknownHostException"/>
        public Java.Net.Socket CreateSocket(Java.Lang.String arg0, int arg1)
        {
            return IExecute<Java.Net.Socket>("createSocket", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/SocketFactory.html#createSocket(java.net.InetAddress,int,java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Net.Socket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.Socket CreateSocket(Java.Net.InetAddress arg0, int arg1, Java.Net.InetAddress arg2, int arg3)
        {
            return IExecute<Java.Net.Socket>("createSocket", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/SocketFactory.html#createSocket(java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Net.Socket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.Socket CreateSocket(Java.Net.InetAddress arg0, int arg1)
        {
            return IExecute<Java.Net.Socket>("createSocket", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/SocketFactory.html#createSocket()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.Socket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.Socket CreateSocket()
        {
            return IExecute<Java.Net.Socket>("createSocket");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}