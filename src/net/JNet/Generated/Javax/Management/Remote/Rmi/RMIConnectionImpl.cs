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

namespace Javax.Management.Remote.Rmi
{
    #region RMIConnectionImpl declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html"/>
    /// </summary>
    public partial class RMIConnectionImpl : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RMIConnectionImpl>
    {
        const string _bridgeClassName = "javax.management.remote.rmi.RMIConnectionImpl";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RMIConnectionImpl() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RMIConnectionImpl(params object[] args) : base(args) { }

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

    #region RMIConnectionImpl implementation
    public partial class RMIConnectionImpl
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#%3Cinit%3E(javax.management.remote.rmi.RMIServerImpl,java.lang.String,java.lang.ClassLoader,javax.security.auth.Subject,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.Rmi.RMIServerImpl"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg3"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <param name="arg4"><see cref="Java.Util.Map"/></param>
        public RMIConnectionImpl(Javax.Management.Remote.Rmi.RMIServerImpl arg0, Java.Lang.String arg1, Java.Lang.ClassLoader arg2, Javax.Security.Auth.Subject arg3, Java.Util.Map<Java.Lang.String, object> arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Remote.Rmi.RMIConnectionImpl"/> to <see cref="Javax.Management.Remote.Rmi.RMIConnection"/>
        /// </summary>
        public static implicit operator Javax.Management.Remote.Rmi.RMIConnection(Javax.Management.Remote.Rmi.RMIConnectionImpl t) => t.Cast<Javax.Management.Remote.Rmi.RMIConnection>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Remote.Rmi.RMIConnectionImpl"/> to <see cref="Java.Rmi.Server.Unreferenced"/>
        /// </summary>
        public static implicit operator Java.Rmi.Server.Unreferenced(Javax.Management.Remote.Rmi.RMIConnectionImpl t) => t.Cast<Java.Rmi.Server.Unreferenced>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#getConnectionId()"/> 
        /// </summary>
        public Java.Lang.String ConnectionId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getConnectionId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#isInstanceOf(javax.management.ObjectName,java.lang.String,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Java.Io.IOException"/>
        public bool IsInstanceOf(Javax.Management.ObjectName arg0, Java.Lang.String arg1, Javax.Security.Auth.Subject arg2)
        {
            return IExecuteWithSignature<bool>("isInstanceOf", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljavax/security/auth/Subject;)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#isRegistered(javax.management.ObjectName,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool IsRegistered(Javax.Management.ObjectName arg0, Javax.Security.Auth.Subject arg1)
        {
            return IExecuteWithSignature<bool>("isRegistered", "(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#getMBeanCount(javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Integer GetMBeanCount(Javax.Security.Auth.Subject arg0)
        {
            return IExecuteWithSignature<Java.Lang.Integer>("getMBeanCount", "(Ljavax/security/auth/Subject;)Ljava/lang/Integer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#addNotificationListeners(javax.management.ObjectName[],java.rmi.MarshalledObject[],javax.security.auth.Subject[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Integer[] AddNotificationListeners(Javax.Management.ObjectName[] arg0, Java.Rmi.MarshalledObject[] arg1, Javax.Security.Auth.Subject[] arg2)
        {
            return IExecuteWithSignatureArray<Java.Lang.Integer>("addNotificationListeners", "([Ljavax/management/ObjectName;[Ljava/rmi/MarshalledObject;[Ljavax/security/auth/Subject;)[Ljava/lang/Integer;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#getAttribute(javax.management.ObjectName,java.lang.String,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.AttributeNotFoundException"/>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Javax.Management.ReflectionException"/>
        /// <exception cref="Java.Io.IOException"/>
        public object GetAttribute(Javax.Management.ObjectName arg0, Java.Lang.String arg1, Javax.Security.Auth.Subject arg2)
        {
            return IExecuteWithSignature("getAttribute", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljavax/security/auth/Subject;)Ljava/lang/Object;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#invoke(javax.management.ObjectName,java.lang.String,java.rmi.MarshalledObject,java.lang.String[],javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.ReflectionException"/>
        /// <exception cref="Java.Io.IOException"/>
        public object Invoke(Javax.Management.ObjectName arg0, Java.Lang.String arg1, Java.Rmi.MarshalledObject arg2, Java.Lang.String[] arg3, Javax.Security.Auth.Subject arg4)
        {
            return IExecuteWithSignature("invoke", "(Ljavax/management/ObjectName;Ljava/lang/String;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljava/lang/Object;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#getDefaultDomain(javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String GetDefaultDomain(Javax.Security.Auth.Subject arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getDefaultDomain", "(Ljavax/security/auth/Subject;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#getDomains(javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String[] GetDomains(Javax.Security.Auth.Subject arg0)
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getDomains", "(Ljavax/security/auth/Subject;)[Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#queryMBeans(javax.management.ObjectName,java.rmi.MarshalledObject,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Set<Javax.Management.ObjectInstance> QueryMBeans(Javax.Management.ObjectName arg0, Java.Rmi.MarshalledObject arg1, Javax.Security.Auth.Subject arg2)
        {
            return IExecuteWithSignature<Java.Util.Set<Javax.Management.ObjectInstance>>("queryMBeans", "(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljava/util/Set;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#queryNames(javax.management.ObjectName,java.rmi.MarshalledObject,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Set<Javax.Management.ObjectName> QueryNames(Javax.Management.ObjectName arg0, Java.Rmi.MarshalledObject arg1, Javax.Security.Auth.Subject arg2)
        {
            return IExecuteWithSignature<Java.Util.Set<Javax.Management.ObjectName>>("queryNames", "(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljava/util/Set;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#getAttributes(javax.management.ObjectName,java.lang.String[],javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Javax.Management.AttributeList"/></returns>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Javax.Management.ReflectionException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.AttributeList GetAttributes(Javax.Management.ObjectName arg0, Java.Lang.String[] arg1, Javax.Security.Auth.Subject arg2)
        {
            return IExecuteWithSignature<Javax.Management.AttributeList>("getAttributes", "(Ljavax/management/ObjectName;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/AttributeList;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#setAttributes(javax.management.ObjectName,java.rmi.MarshalledObject,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Javax.Management.AttributeList"/></returns>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Javax.Management.ReflectionException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.AttributeList SetAttributes(Javax.Management.ObjectName arg0, Java.Rmi.MarshalledObject arg1, Javax.Security.Auth.Subject arg2)
        {
            return IExecuteWithSignature<Javax.Management.AttributeList>("setAttributes", "(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)Ljavax/management/AttributeList;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#getMBeanInfo(javax.management.ObjectName,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Javax.Management.MBeanInfo"/></returns>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Javax.Management.IntrospectionException"/>
        /// <exception cref="Javax.Management.ReflectionException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.MBeanInfo GetMBeanInfo(Javax.Management.ObjectName arg0, Javax.Security.Auth.Subject arg1)
        {
            return IExecuteWithSignature<Javax.Management.MBeanInfo>("getMBeanInfo", "(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/MBeanInfo;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#createMBean(java.lang.String,javax.management.ObjectName,java.rmi.MarshalledObject,java.lang.String[],javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Javax.Management.ObjectInstance"/></returns>
        /// <exception cref="Javax.Management.ReflectionException"/>
        /// <exception cref="Javax.Management.InstanceAlreadyExistsException"/>
        /// <exception cref="Javax.Management.MBeanRegistrationException"/>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.NotCompliantMBeanException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.ObjectInstance CreateMBean(Java.Lang.String arg0, Javax.Management.ObjectName arg1, Java.Rmi.MarshalledObject arg2, Java.Lang.String[] arg3, Javax.Security.Auth.Subject arg4)
        {
            return IExecuteWithSignature<Javax.Management.ObjectInstance>("createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#createMBean(java.lang.String,javax.management.ObjectName,javax.management.ObjectName,java.rmi.MarshalledObject,java.lang.String[],javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg3"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Javax.Management.ObjectInstance"/></returns>
        /// <exception cref="Javax.Management.ReflectionException"/>
        /// <exception cref="Javax.Management.InstanceAlreadyExistsException"/>
        /// <exception cref="Javax.Management.MBeanRegistrationException"/>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.NotCompliantMBeanException"/>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.ObjectInstance CreateMBean(Java.Lang.String arg0, Javax.Management.ObjectName arg1, Javax.Management.ObjectName arg2, Java.Rmi.MarshalledObject arg3, Java.Lang.String[] arg4, Javax.Security.Auth.Subject arg5)
        {
            return IExecuteWithSignature<Javax.Management.ObjectInstance>("createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;[Ljava/lang/String;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#createMBean(java.lang.String,javax.management.ObjectName,javax.management.ObjectName,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg3"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Javax.Management.ObjectInstance"/></returns>
        /// <exception cref="Javax.Management.ReflectionException"/>
        /// <exception cref="Javax.Management.InstanceAlreadyExistsException"/>
        /// <exception cref="Javax.Management.MBeanRegistrationException"/>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.NotCompliantMBeanException"/>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.ObjectInstance CreateMBean(Java.Lang.String arg0, Javax.Management.ObjectName arg1, Javax.Management.ObjectName arg2, Javax.Security.Auth.Subject arg3)
        {
            return IExecuteWithSignature<Javax.Management.ObjectInstance>("createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#createMBean(java.lang.String,javax.management.ObjectName,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Javax.Management.ObjectInstance"/></returns>
        /// <exception cref="Javax.Management.ReflectionException"/>
        /// <exception cref="Javax.Management.InstanceAlreadyExistsException"/>
        /// <exception cref="Javax.Management.MBeanRegistrationException"/>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.NotCompliantMBeanException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.ObjectInstance CreateMBean(Java.Lang.String arg0, Javax.Management.ObjectName arg1, Javax.Security.Auth.Subject arg2)
        {
            return IExecuteWithSignature<Javax.Management.ObjectInstance>("createMBean", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#getObjectInstance(javax.management.ObjectName,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Javax.Management.ObjectInstance"/></returns>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.ObjectInstance GetObjectInstance(Javax.Management.ObjectName arg0, Javax.Security.Auth.Subject arg1)
        {
            return IExecuteWithSignature<Javax.Management.ObjectInstance>("getObjectInstance", "(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)Ljavax/management/ObjectInstance;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#fetchNotifications(long,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Javax.Management.Remote.NotificationResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.Remote.NotificationResult FetchNotifications(long arg0, int arg1, long arg2)
        {
            return IExecuteWithSignature<Javax.Management.Remote.NotificationResult>("fetchNotifications", "(JIJ)Ljavax/management/remote/NotificationResult;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#addNotificationListener(javax.management.ObjectName,javax.management.ObjectName,java.rmi.MarshalledObject,java.rmi.MarshalledObject,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg3"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg4"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void AddNotificationListener(Javax.Management.ObjectName arg0, Javax.Management.ObjectName arg1, Java.Rmi.MarshalledObject arg2, Java.Rmi.MarshalledObject arg3, Javax.Security.Auth.Subject arg4)
        {
            IExecuteWithSignature("addNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#removeNotificationListener(javax.management.ObjectName,javax.management.ObjectName,java.rmi.MarshalledObject,java.rmi.MarshalledObject,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg3"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg4"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void RemoveNotificationListener(Javax.Management.ObjectName arg0, Javax.Management.ObjectName arg1, Java.Rmi.MarshalledObject arg2, Java.Rmi.MarshalledObject arg3, Javax.Security.Auth.Subject arg4)
        {
            IExecuteWithSignature("removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#removeNotificationListener(javax.management.ObjectName,javax.management.ObjectName,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void RemoveNotificationListener(Javax.Management.ObjectName arg0, Javax.Management.ObjectName arg1, Javax.Security.Auth.Subject arg2)
        {
            IExecuteWithSignature("removeNotificationListener", "(Ljavax/management/ObjectName;Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#removeNotificationListeners(javax.management.ObjectName,java.lang.Integer[],javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void RemoveNotificationListeners(Javax.Management.ObjectName arg0, Java.Lang.Integer[] arg1, Javax.Security.Auth.Subject arg2)
        {
            IExecuteWithSignature("removeNotificationListeners", "(Ljavax/management/ObjectName;[Ljava/lang/Integer;Ljavax/security/auth/Subject;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#setAttribute(javax.management.ObjectName,java.rmi.MarshalledObject,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Javax.Management.AttributeNotFoundException"/>
        /// <exception cref="Javax.Management.InvalidAttributeValueException"/>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.ReflectionException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void SetAttribute(Javax.Management.ObjectName arg0, Java.Rmi.MarshalledObject arg1, Javax.Security.Auth.Subject arg2)
        {
            IExecuteWithSignature("setAttribute", "(Ljavax/management/ObjectName;Ljava/rmi/MarshalledObject;Ljavax/security/auth/Subject;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#unreferenced()"/>
        /// </summary>
        public void Unreferenced()
        {
            IExecuteWithSignature("unreferenced", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectionImpl.html#unregisterMBean(javax.management.ObjectName,javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Javax.Management.MBeanRegistrationException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void UnregisterMBean(Javax.Management.ObjectName arg0, Javax.Security.Auth.Subject arg1)
        {
            IExecuteWithSignature("unregisterMBean", "(Ljavax/management/ObjectName;Ljavax/security/auth/Subject;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}