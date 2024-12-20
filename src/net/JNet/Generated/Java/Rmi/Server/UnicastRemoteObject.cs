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

namespace Java.Rmi.Server
{
    #region UnicastRemoteObject declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/UnicastRemoteObject.html"/>
    /// </summary>
    public partial class UnicastRemoteObject : Java.Rmi.Server.RemoteServer
    {
        const string _bridgeClassName = "java.rmi.server.UnicastRemoteObject";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UnicastRemoteObject() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public UnicastRemoteObject(params object[] args) : base(args) { }

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

    #region UnicastRemoteObject implementation
    public partial class UnicastRemoteObject
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/UnicastRemoteObject.html#unexportObject(java.rmi.Remote,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Remote"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Rmi.NoSuchObjectException"/>
        public static bool UnexportObject(Java.Rmi.Remote arg0, bool arg1)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "unexportObject", "(Ljava/rmi/Remote;Z)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/UnicastRemoteObject.html#exportObject(java.rmi.Remote,int,java.io.ObjectInputFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Remote"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Io.ObjectInputFilter"/></param>
        /// <returns><see cref="Java.Rmi.Remote"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Remote ExportObject(Java.Rmi.Remote arg0, int arg1, Java.Io.ObjectInputFilter arg2)
        {
            return SExecuteWithSignature<Java.Rmi.Remote>(LocalBridgeClazz, "exportObject", "(Ljava/rmi/Remote;ILjava/io/ObjectInputFilter;)Ljava/rmi/Remote;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/UnicastRemoteObject.html#exportObject(java.rmi.Remote,int,java.rmi.server.RMIClientSocketFactory,java.rmi.server.RMIServerSocketFactory,java.io.ObjectInputFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Remote"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.Server.RMIClientSocketFactory"/></param>
        /// <param name="arg3"><see cref="Java.Rmi.Server.RMIServerSocketFactory"/></param>
        /// <param name="arg4"><see cref="Java.Io.ObjectInputFilter"/></param>
        /// <returns><see cref="Java.Rmi.Remote"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Remote ExportObject(Java.Rmi.Remote arg0, int arg1, Java.Rmi.Server.RMIClientSocketFactory arg2, Java.Rmi.Server.RMIServerSocketFactory arg3, Java.Io.ObjectInputFilter arg4)
        {
            return SExecuteWithSignature<Java.Rmi.Remote>(LocalBridgeClazz, "exportObject", "(Ljava/rmi/Remote;ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;Ljava/io/ObjectInputFilter;)Ljava/rmi/Remote;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/UnicastRemoteObject.html#exportObject(java.rmi.Remote,int,java.rmi.server.RMIClientSocketFactory,java.rmi.server.RMIServerSocketFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Remote"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.Server.RMIClientSocketFactory"/></param>
        /// <param name="arg3"><see cref="Java.Rmi.Server.RMIServerSocketFactory"/></param>
        /// <returns><see cref="Java.Rmi.Remote"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Remote ExportObject(Java.Rmi.Remote arg0, int arg1, Java.Rmi.Server.RMIClientSocketFactory arg2, Java.Rmi.Server.RMIServerSocketFactory arg3)
        {
            return SExecuteWithSignature<Java.Rmi.Remote>(LocalBridgeClazz, "exportObject", "(Ljava/rmi/Remote;ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;)Ljava/rmi/Remote;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/UnicastRemoteObject.html#exportObject(java.rmi.Remote,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Remote"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Rmi.Remote"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Remote ExportObject(Java.Rmi.Remote arg0, int arg1)
        {
            return SExecuteWithSignature<Java.Rmi.Remote>(LocalBridgeClazz, "exportObject", "(Ljava/rmi/Remote;I)Ljava/rmi/Remote;", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}