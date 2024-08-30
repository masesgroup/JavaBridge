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
    #region StandardSocketOptions definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/StandardSocketOptions.html"/>
    /// </summary>
    public partial class StandardSocketOptions : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StandardSocketOptions>
    {
        const string _bridgeClassName = "java.net.StandardSocketOptions";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StandardSocketOptions() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StandardSocketOptions(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region StandardSocketOptions
    public partial class StandardSocketOptions
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/StandardSocketOptions.html#IP_MULTICAST_LOOP"/>
        /// </summary>
        public static Java.Net.SocketOption IP_MULTICAST_LOOP { get { if (!_IP_MULTICAST_LOOPReady) { _IP_MULTICAST_LOOPContent = SGetField<Java.Net.SocketOption>(LocalBridgeClazz, "IP_MULTICAST_LOOP"); _IP_MULTICAST_LOOPReady = true; } return _IP_MULTICAST_LOOPContent; } }
        private static Java.Net.SocketOption _IP_MULTICAST_LOOPContent = default;
        private static bool _IP_MULTICAST_LOOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/StandardSocketOptions.html#SO_BROADCAST"/>
        /// </summary>
        public static Java.Net.SocketOption SO_BROADCAST { get { if (!_SO_BROADCASTReady) { _SO_BROADCASTContent = SGetField<Java.Net.SocketOption>(LocalBridgeClazz, "SO_BROADCAST"); _SO_BROADCASTReady = true; } return _SO_BROADCASTContent; } }
        private static Java.Net.SocketOption _SO_BROADCASTContent = default;
        private static bool _SO_BROADCASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/StandardSocketOptions.html#SO_KEEPALIVE"/>
        /// </summary>
        public static Java.Net.SocketOption SO_KEEPALIVE { get { if (!_SO_KEEPALIVEReady) { _SO_KEEPALIVEContent = SGetField<Java.Net.SocketOption>(LocalBridgeClazz, "SO_KEEPALIVE"); _SO_KEEPALIVEReady = true; } return _SO_KEEPALIVEContent; } }
        private static Java.Net.SocketOption _SO_KEEPALIVEContent = default;
        private static bool _SO_KEEPALIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/StandardSocketOptions.html#SO_REUSEADDR"/>
        /// </summary>
        public static Java.Net.SocketOption SO_REUSEADDR { get { if (!_SO_REUSEADDRReady) { _SO_REUSEADDRContent = SGetField<Java.Net.SocketOption>(LocalBridgeClazz, "SO_REUSEADDR"); _SO_REUSEADDRReady = true; } return _SO_REUSEADDRContent; } }
        private static Java.Net.SocketOption _SO_REUSEADDRContent = default;
        private static bool _SO_REUSEADDRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/StandardSocketOptions.html#SO_REUSEPORT"/>
        /// </summary>
        public static Java.Net.SocketOption SO_REUSEPORT { get { if (!_SO_REUSEPORTReady) { _SO_REUSEPORTContent = SGetField<Java.Net.SocketOption>(LocalBridgeClazz, "SO_REUSEPORT"); _SO_REUSEPORTReady = true; } return _SO_REUSEPORTContent; } }
        private static Java.Net.SocketOption _SO_REUSEPORTContent = default;
        private static bool _SO_REUSEPORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/StandardSocketOptions.html#TCP_NODELAY"/>
        /// </summary>
        public static Java.Net.SocketOption TCP_NODELAY { get { if (!_TCP_NODELAYReady) { _TCP_NODELAYContent = SGetField<Java.Net.SocketOption>(LocalBridgeClazz, "TCP_NODELAY"); _TCP_NODELAYReady = true; } return _TCP_NODELAYContent; } }
        private static Java.Net.SocketOption _TCP_NODELAYContent = default;
        private static bool _TCP_NODELAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/StandardSocketOptions.html#IP_MULTICAST_TTL"/>
        /// </summary>
        public static Java.Net.SocketOption IP_MULTICAST_TTL { get { if (!_IP_MULTICAST_TTLReady) { _IP_MULTICAST_TTLContent = SGetField<Java.Net.SocketOption>(LocalBridgeClazz, "IP_MULTICAST_TTL"); _IP_MULTICAST_TTLReady = true; } return _IP_MULTICAST_TTLContent; } }
        private static Java.Net.SocketOption _IP_MULTICAST_TTLContent = default;
        private static bool _IP_MULTICAST_TTLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/StandardSocketOptions.html#IP_TOS"/>
        /// </summary>
        public static Java.Net.SocketOption IP_TOS { get { if (!_IP_TOSReady) { _IP_TOSContent = SGetField<Java.Net.SocketOption>(LocalBridgeClazz, "IP_TOS"); _IP_TOSReady = true; } return _IP_TOSContent; } }
        private static Java.Net.SocketOption _IP_TOSContent = default;
        private static bool _IP_TOSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/StandardSocketOptions.html#SO_LINGER"/>
        /// </summary>
        public static Java.Net.SocketOption SO_LINGER { get { if (!_SO_LINGERReady) { _SO_LINGERContent = SGetField<Java.Net.SocketOption>(LocalBridgeClazz, "SO_LINGER"); _SO_LINGERReady = true; } return _SO_LINGERContent; } }
        private static Java.Net.SocketOption _SO_LINGERContent = default;
        private static bool _SO_LINGERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/StandardSocketOptions.html#SO_RCVBUF"/>
        /// </summary>
        public static Java.Net.SocketOption SO_RCVBUF { get { if (!_SO_RCVBUFReady) { _SO_RCVBUFContent = SGetField<Java.Net.SocketOption>(LocalBridgeClazz, "SO_RCVBUF"); _SO_RCVBUFReady = true; } return _SO_RCVBUFContent; } }
        private static Java.Net.SocketOption _SO_RCVBUFContent = default;
        private static bool _SO_RCVBUFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/StandardSocketOptions.html#SO_SNDBUF"/>
        /// </summary>
        public static Java.Net.SocketOption SO_SNDBUF { get { if (!_SO_SNDBUFReady) { _SO_SNDBUFContent = SGetField<Java.Net.SocketOption>(LocalBridgeClazz, "SO_SNDBUF"); _SO_SNDBUFReady = true; } return _SO_SNDBUFContent; } }
        private static Java.Net.SocketOption _SO_SNDBUFContent = default;
        private static bool _SO_SNDBUFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/StandardSocketOptions.html#IP_MULTICAST_IF"/>
        /// </summary>
        public static Java.Net.SocketOption IP_MULTICAST_IF { get { if (!_IP_MULTICAST_IFReady) { _IP_MULTICAST_IFContent = SGetField<Java.Net.SocketOption>(LocalBridgeClazz, "IP_MULTICAST_IF"); _IP_MULTICAST_IFReady = true; } return _IP_MULTICAST_IFContent; } }
        private static Java.Net.SocketOption _IP_MULTICAST_IFContent = default;
        private static bool _IP_MULTICAST_IFReady = false; // this is used because in case of generics 

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