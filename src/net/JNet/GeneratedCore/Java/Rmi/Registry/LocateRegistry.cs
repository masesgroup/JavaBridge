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

namespace Java.Rmi.Registry
{
    #region LocateRegistry definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/LocateRegistry.html"/>
    /// </summary>
    public partial class LocateRegistry : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LocateRegistry>
    {
        const string _bridgeClassName = "java.rmi.registry.LocateRegistry";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LocateRegistry() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LocateRegistry(params object[] args) : base(args) { }

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

    #region LocateRegistry
    public partial class LocateRegistry
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/LocateRegistry.html#getRegistry()"/> 
        /// </summary>
        public static Java.Rmi.Registry.Registry Registry
        {
            get { return SExecuteWithSignature<Java.Rmi.Registry.Registry>(LocalBridgeClazz, "getRegistry", "()Ljava/rmi/registry/Registry;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/LocateRegistry.html#createRegistry(int,java.rmi.server.RMIClientSocketFactory,java.rmi.server.RMIServerSocketFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Server.RMIClientSocketFactory"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.Server.RMIServerSocketFactory"/></param>
        /// <returns><see cref="Java.Rmi.Registry.Registry"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Registry.Registry CreateRegistry(int arg0, Java.Rmi.Server.RMIClientSocketFactory arg1, Java.Rmi.Server.RMIServerSocketFactory arg2)
        {
            return SExecute<Java.Rmi.Registry.Registry>(LocalBridgeClazz, "createRegistry", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/LocateRegistry.html#createRegistry(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Rmi.Registry.Registry"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Registry.Registry CreateRegistry(int arg0)
        {
            return SExecuteWithSignature<Java.Rmi.Registry.Registry>(LocalBridgeClazz, "createRegistry", "(I)Ljava/rmi/registry/Registry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/LocateRegistry.html#getRegistry(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Rmi.Registry.Registry"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Registry.Registry GetRegistry(int arg0)
        {
            return SExecuteWithSignature<Java.Rmi.Registry.Registry>(LocalBridgeClazz, "getRegistry", "(I)Ljava/rmi/registry/Registry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/LocateRegistry.html#getRegistry(java.lang.String,int,java.rmi.server.RMIClientSocketFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.Server.RMIClientSocketFactory"/></param>
        /// <returns><see cref="Java.Rmi.Registry.Registry"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Registry.Registry GetRegistry(Java.Lang.String arg0, int arg1, Java.Rmi.Server.RMIClientSocketFactory arg2)
        {
            return SExecute<Java.Rmi.Registry.Registry>(LocalBridgeClazz, "getRegistry", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/LocateRegistry.html#getRegistry(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Rmi.Registry.Registry"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Registry.Registry GetRegistry(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Java.Rmi.Registry.Registry>(LocalBridgeClazz, "getRegistry", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/LocateRegistry.html#getRegistry(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Rmi.Registry.Registry"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Registry.Registry GetRegistry(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Rmi.Registry.Registry>(LocalBridgeClazz, "getRegistry", "(Ljava/lang/String;)Ljava/rmi/registry/Registry;", arg0);
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