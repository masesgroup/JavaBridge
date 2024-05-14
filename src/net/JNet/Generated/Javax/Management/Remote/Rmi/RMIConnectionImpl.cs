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

namespace Javax.Management.Remote.Rmi
{
    #region RMIConnectionImpl
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
            return IExecute<bool>("isInstanceOf", arg0, arg1, arg2);
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
            return IExecute<bool>("isRegistered", arg0, arg1);
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
            return IExecuteArray<Java.Lang.Integer>("addNotificationListeners", arg0, arg1, arg2);
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
            return IExecute("getAttribute", arg0, arg1, arg2);
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
            return IExecute("invoke", arg0, arg1, arg2, arg3, arg4);
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
            return IExecute<Java.Util.Set<Javax.Management.ObjectInstance>>("queryMBeans", arg0, arg1, arg2);
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
            return IExecute<Java.Util.Set<Javax.Management.ObjectName>>("queryNames", arg0, arg1, arg2);
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
            return IExecute<Javax.Management.AttributeList>("getAttributes", arg0, arg1, arg2);
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
            return IExecute<Javax.Management.AttributeList>("setAttributes", arg0, arg1, arg2);
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
            return IExecute<Javax.Management.MBeanInfo>("getMBeanInfo", arg0, arg1);
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
            return IExecute<Javax.Management.ObjectInstance>("createMBean", arg0, arg1, arg2, arg3, arg4);
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
            return IExecute<Javax.Management.ObjectInstance>("createMBean", arg0, arg1, arg2, arg3, arg4, arg5);
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
            return IExecute<Javax.Management.ObjectInstance>("createMBean", arg0, arg1, arg2, arg3);
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
            return IExecute<Javax.Management.ObjectInstance>("createMBean", arg0, arg1, arg2);
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
            return IExecute<Javax.Management.ObjectInstance>("getObjectInstance", arg0, arg1);
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
            return IExecute<Javax.Management.Remote.NotificationResult>("fetchNotifications", arg0, arg1, arg2);
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
            IExecute("addNotificationListener", arg0, arg1, arg2, arg3, arg4);
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
            IExecute("removeNotificationListener", arg0, arg1, arg2, arg3, arg4);
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
            IExecute("removeNotificationListener", arg0, arg1, arg2);
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
            IExecute("removeNotificationListeners", arg0, arg1, arg2);
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
            IExecute("setAttribute", arg0, arg1, arg2);
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
            IExecute("unregisterMBean", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}