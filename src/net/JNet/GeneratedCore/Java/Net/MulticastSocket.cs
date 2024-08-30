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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region MulticastSocket
    public partial class MulticastSocket
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/MulticastSocket.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public MulticastSocket(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/MulticastSocket.html#%3Cinit%3E(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public MulticastSocket(Java.Net.SocketAddress arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/MulticastSocket.html#getInterface()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/MulticastSocket.html#setInterface(java.net.InetAddress)"/>
        /// </summary>
        public Java.Net.InetAddress Interface
        {
            get { return IExecuteWithSignature<Java.Net.InetAddress>("getInterface", "()Ljava/net/InetAddress;"); } set { IExecuteWithSignature("setInterface", "(Ljava/net/InetAddress;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/MulticastSocket.html#getLoopbackMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/MulticastSocket.html#setLoopbackMode(boolean)"/>
        /// </summary>
        public bool LoopbackMode
        {
            get { return IExecuteWithSignature<bool>("getLoopbackMode", "()Z"); } set { IExecuteWithSignature("setLoopbackMode", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/MulticastSocket.html#getNetworkInterface()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/MulticastSocket.html#setNetworkInterface(java.net.NetworkInterface)"/>
        /// </summary>
        public Java.Net.NetworkInterface NetworkInterface
        {
            get { return IExecuteWithSignature<Java.Net.NetworkInterface>("getNetworkInterface", "()Ljava/net/NetworkInterface;"); } set { IExecuteWithSignature("setNetworkInterface", "(Ljava/net/NetworkInterface;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/MulticastSocket.html#getTimeToLive()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/MulticastSocket.html#setTimeToLive(int)"/>
        /// </summary>
        public int TimeToLive
        {
            get { return IExecuteWithSignature<int>("getTimeToLive", "()I"); } set { IExecuteWithSignature("setTimeToLive", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/MulticastSocket.html#joinGroup(java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void JoinGroup(Java.Net.InetAddress arg0)
        {
            IExecuteWithSignature("joinGroup", "(Ljava/net/InetAddress;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/MulticastSocket.html#joinGroup(java.net.SocketAddress,java.net.NetworkInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg1"><see cref="Java.Net.NetworkInterface"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void JoinGroup(Java.Net.SocketAddress arg0, Java.Net.NetworkInterface arg1)
        {
            IExecute("joinGroup", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/MulticastSocket.html#leaveGroup(java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void LeaveGroup(Java.Net.InetAddress arg0)
        {
            IExecuteWithSignature("leaveGroup", "(Ljava/net/InetAddress;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/MulticastSocket.html#leaveGroup(java.net.SocketAddress,java.net.NetworkInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg1"><see cref="Java.Net.NetworkInterface"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void LeaveGroup(Java.Net.SocketAddress arg0, Java.Net.NetworkInterface arg1)
        {
            IExecute("leaveGroup", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}