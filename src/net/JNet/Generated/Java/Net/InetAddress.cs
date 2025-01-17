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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region InetAddress declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html"/>
    /// </summary>
    public partial class InetAddress : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.net.InetAddress";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public InetAddress() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public InetAddress(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region InetAddress implementation
    public partial class InetAddress
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getLocalHost()"/> 
        /// </summary>
        public static Java.Net.InetAddress LocalHost
        {
            get { return SExecuteWithSignature<Java.Net.InetAddress>(LocalBridgeClazz, "getLocalHost", "()Ljava/net/InetAddress;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getLoopbackAddress()"/> 
        /// </summary>
        public static Java.Net.InetAddress LoopbackAddress
        {
            get { return SExecuteWithSignature<Java.Net.InetAddress>(LocalBridgeClazz, "getLoopbackAddress", "()Ljava/net/InetAddress;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getByAddress(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        /// <exception cref="Java.Net.UnknownHostException"/>
        public static Java.Net.InetAddress GetByAddress(byte[] arg0)
        {
            return SExecuteWithSignature<Java.Net.InetAddress>(LocalBridgeClazz, "getByAddress", "([B)Ljava/net/InetAddress;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getByAddress(java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        /// <exception cref="Java.Net.UnknownHostException"/>
        public static Java.Net.InetAddress GetByAddress(Java.Lang.String arg0, byte[] arg1)
        {
            return SExecuteWithSignature<Java.Net.InetAddress>(LocalBridgeClazz, "getByAddress", "(Ljava/lang/String;[B)Ljava/net/InetAddress;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        /// <exception cref="Java.Net.UnknownHostException"/>
        public static Java.Net.InetAddress GetByName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Net.InetAddress>(LocalBridgeClazz, "getByName", "(Ljava/lang/String;)Ljava/net/InetAddress;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getAllByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        /// <exception cref="Java.Net.UnknownHostException"/>
        public static Java.Net.InetAddress[] GetAllByName(Java.Lang.String arg0)
        {
            return SExecuteWithSignatureArray<Java.Net.InetAddress>(LocalBridgeClazz, "getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getAddress()"/> 
        /// </summary>
        public byte[] Address
        {
            get { return IExecuteWithSignatureArray<byte>("getAddress", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getCanonicalHostName()"/> 
        /// </summary>
        public Java.Lang.String CanonicalHostName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCanonicalHostName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getHostAddress()"/> 
        /// </summary>
        public Java.Lang.String HostAddress
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHostAddress", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getHostName()"/> 
        /// </summary>
        public Java.Lang.String HostName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHostName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isAnyLocalAddress()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAnyLocalAddress()
        {
            return IExecuteWithSignature<bool>("isAnyLocalAddress", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isLinkLocalAddress()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLinkLocalAddress()
        {
            return IExecuteWithSignature<bool>("isLinkLocalAddress", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isLoopbackAddress()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLoopbackAddress()
        {
            return IExecuteWithSignature<bool>("isLoopbackAddress", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isMCGlobal()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMCGlobal()
        {
            return IExecuteWithSignature<bool>("isMCGlobal", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isMCLinkLocal()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMCLinkLocal()
        {
            return IExecuteWithSignature<bool>("isMCLinkLocal", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isMCNodeLocal()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMCNodeLocal()
        {
            return IExecuteWithSignature<bool>("isMCNodeLocal", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isMCOrgLocal()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMCOrgLocal()
        {
            return IExecuteWithSignature<bool>("isMCOrgLocal", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isMCSiteLocal()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMCSiteLocal()
        {
            return IExecuteWithSignature<bool>("isMCSiteLocal", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isMulticastAddress()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMulticastAddress()
        {
            return IExecuteWithSignature<bool>("isMulticastAddress", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isReachable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool IsReachable(int arg0)
        {
            return IExecuteWithSignature<bool>("isReachable", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isReachable(java.net.NetworkInterface,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.NetworkInterface"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool IsReachable(Java.Net.NetworkInterface arg0, int arg1, int arg2)
        {
            return IExecuteWithSignature<bool>("isReachable", "(Ljava/net/NetworkInterface;II)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isSiteLocalAddress()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSiteLocalAddress()
        {
            return IExecuteWithSignature<bool>("isSiteLocalAddress", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}