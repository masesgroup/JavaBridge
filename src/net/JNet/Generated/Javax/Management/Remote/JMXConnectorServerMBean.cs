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

namespace Javax.Management.Remote
{
    #region IJMXConnectorServerMBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IJMXConnectorServerMBean
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getAddress()"/> 
        /// </summary>
        Javax.Management.Remote.JMXServiceURL Address { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getAttributes()"/> 
        /// </summary>
        Java.Util.Map<Java.Lang.String, object> Attributes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getConnectionIds()"/> 
        /// </summary>
        Java.Lang.String[] ConnectionIds { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#isActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsActive();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#toJMXConnector(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Javax.Management.Remote.JMXConnector"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Javax.Management.Remote.JMXConnector ToJMXConnector(Java.Util.Map<Java.Lang.String, object> arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#setMBeanServerForwarder(javax.management.remote.MBeanServerForwarder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.MBeanServerForwarder"/></param>
        void SetMBeanServerForwarder(Javax.Management.Remote.MBeanServerForwarder arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#start()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        void Start();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#stop()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        void Stop();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region JMXConnectorServerMBean
    public partial class JMXConnectorServerMBean : Javax.Management.Remote.IJMXConnectorServerMBean
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getAddress()"/> 
        /// </summary>
        public Javax.Management.Remote.JMXServiceURL Address
        {
            get { return IExecuteWithSignature<Javax.Management.Remote.JMXServiceURL>("getAddress", "()Ljavax/management/remote/JMXServiceURL;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getAttributes()"/> 
        /// </summary>
        public Java.Util.Map<Java.Lang.String, object> Attributes
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("getAttributes", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getConnectionIds()"/> 
        /// </summary>
        public Java.Lang.String[] ConnectionIds
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getConnectionIds", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#isActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsActive()
        {
            return IExecuteWithSignature<bool>("isActive", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#toJMXConnector(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Javax.Management.Remote.JMXConnector"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.Remote.JMXConnector ToJMXConnector(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<Javax.Management.Remote.JMXConnector>("toJMXConnector", "(Ljava/util/Map;)Ljavax/management/remote/JMXConnector;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#setMBeanServerForwarder(javax.management.remote.MBeanServerForwarder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.MBeanServerForwarder"/></param>
        public void SetMBeanServerForwarder(Javax.Management.Remote.MBeanServerForwarder arg0)
        {
            IExecuteWithSignature("setMBeanServerForwarder", "(Ljavax/management/remote/MBeanServerForwarder;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#start()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#stop()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}