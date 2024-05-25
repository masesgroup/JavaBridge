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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Remote.Rmi
{
    #region RMIConnector
    public partial class RMIConnector
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnector.html#%3Cinit%3E(javax.management.remote.JMXServiceURL,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.JMXServiceURL"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public RMIConnector(Javax.Management.Remote.JMXServiceURL arg0, Java.Util.Map<Java.Lang.String, object> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnector.html#%3Cinit%3E(javax.management.remote.rmi.RMIServer,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.Rmi.RMIServer"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public RMIConnector(Javax.Management.Remote.Rmi.RMIServer arg0, Java.Util.Map<Java.Lang.String, object> arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Remote.Rmi.RMIConnector"/> to <see cref="Javax.Management.Remote.JMXConnector"/>
        /// </summary>
        public static implicit operator Javax.Management.Remote.JMXConnector(Javax.Management.Remote.Rmi.RMIConnector t) => t.Cast<Javax.Management.Remote.JMXConnector>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Remote.Rmi.RMIConnector"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Management.Remote.Rmi.RMIConnector t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Remote.Rmi.RMIConnector"/> to <see cref="Javax.Management.Remote.JMXAddressable"/>
        /// </summary>
        public static implicit operator Javax.Management.Remote.JMXAddressable(Javax.Management.Remote.Rmi.RMIConnector t) => t.Cast<Javax.Management.Remote.JMXAddressable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnector.html#getAddress()"/> 
        /// </summary>
        public Javax.Management.Remote.JMXServiceURL Address
        {
            get { return IExecute<Javax.Management.Remote.JMXServiceURL>("getAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnector.html#getConnectionId()"/> 
        /// </summary>
        public Java.Lang.String ConnectionId
        {
            get { return IExecute<Java.Lang.String>("getConnectionId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnector.html#getMBeanServerConnection()"/> 
        /// </summary>
        public Javax.Management.MBeanServerConnection MBeanServerConnection
        {
            get { return IExecute<Javax.Management.MBeanServerConnection>("getMBeanServerConnection"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnector.html#getMBeanServerConnection(javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Javax.Management.MBeanServerConnection"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.MBeanServerConnection GetMBeanServerConnection(Javax.Security.Auth.Subject arg0)
        {
            return IExecute<Javax.Management.MBeanServerConnection>("getMBeanServerConnection", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnector.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnector.html#connect(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecute("connect", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnector.html#addConnectionNotificationListener(javax.management.NotificationListener,javax.management.NotificationFilter,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="Javax.Management.NotificationFilter"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void AddConnectionNotificationListener(Javax.Management.NotificationListener arg0, Javax.Management.NotificationFilter arg1, object arg2)
        {
            IExecute("addConnectionNotificationListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnector.html#connect()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect()
        {
            IExecute("connect");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnector.html#removeConnectionNotificationListener(javax.management.NotificationListener,javax.management.NotificationFilter,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="Javax.Management.NotificationFilter"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        public void RemoveConnectionNotificationListener(Javax.Management.NotificationListener arg0, Javax.Management.NotificationFilter arg1, object arg2)
        {
            IExecute("removeConnectionNotificationListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnector.html#removeConnectionNotificationListener(javax.management.NotificationListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        public void RemoveConnectionNotificationListener(Javax.Management.NotificationListener arg0)
        {
            IExecute("removeConnectionNotificationListener", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}