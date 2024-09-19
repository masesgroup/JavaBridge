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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region MBeanServerFactory declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html"/>
    /// </summary>
    public partial class MBeanServerFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MBeanServerFactory>
    {
        const string _bridgeClassName = "javax.management.MBeanServerFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MBeanServerFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MBeanServerFactory(params object[] args) : base(args) { }

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

    #region MBeanServerFactory implementation
    public partial class MBeanServerFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html#getClassLoaderRepository(javax.management.MBeanServer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        /// <returns><see cref="Javax.Management.Loading.ClassLoaderRepository"/></returns>
        public static Javax.Management.Loading.ClassLoaderRepository GetClassLoaderRepository(Javax.Management.MBeanServer arg0)
        {
            return SExecuteWithSignature<Javax.Management.Loading.ClassLoaderRepository>(LocalBridgeClazz, "getClassLoaderRepository", "(Ljavax/management/MBeanServer;)Ljavax/management/loading/ClassLoaderRepository;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html#createMBeanServer()"/>
        /// </summary>
        /// <returns><see cref="Javax.Management.MBeanServer"/></returns>
        public static Javax.Management.MBeanServer CreateMBeanServer()
        {
            return SExecuteWithSignature<Javax.Management.MBeanServer>(LocalBridgeClazz, "createMBeanServer", "()Ljavax/management/MBeanServer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html#createMBeanServer(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.MBeanServer"/></returns>
        public static Javax.Management.MBeanServer CreateMBeanServer(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Management.MBeanServer>(LocalBridgeClazz, "createMBeanServer", "(Ljava/lang/String;)Ljavax/management/MBeanServer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html#newMBeanServer()"/>
        /// </summary>
        /// <returns><see cref="Javax.Management.MBeanServer"/></returns>
        public static Javax.Management.MBeanServer NewMBeanServer()
        {
            return SExecuteWithSignature<Javax.Management.MBeanServer>(LocalBridgeClazz, "newMBeanServer", "()Ljavax/management/MBeanServer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html#newMBeanServer(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.MBeanServer"/></returns>
        public static Javax.Management.MBeanServer NewMBeanServer(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Management.MBeanServer>(LocalBridgeClazz, "newMBeanServer", "(Ljava/lang/String;)Ljavax/management/MBeanServer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html#findMBeanServer(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.ArrayList"/></returns>
        public static Java.Util.ArrayList<Javax.Management.MBeanServer> FindMBeanServer(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.ArrayList<Javax.Management.MBeanServer>>(LocalBridgeClazz, "findMBeanServer", "(Ljava/lang/String;)Ljava/util/ArrayList;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html#releaseMBeanServer(javax.management.MBeanServer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        public static void ReleaseMBeanServer(Javax.Management.MBeanServer arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "releaseMBeanServer", "(Ljavax/management/MBeanServer;)V", arg0);
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