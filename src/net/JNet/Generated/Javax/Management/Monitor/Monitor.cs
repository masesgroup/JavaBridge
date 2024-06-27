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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Monitor
{
    #region Monitor
    public partial class Monitor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Monitor.Monitor"/> to <see cref="Javax.Management.Monitor.MonitorMBean"/>
        /// </summary>
        public static implicit operator Javax.Management.Monitor.MonitorMBean(Javax.Management.Monitor.Monitor t) => t.Cast<Javax.Management.Monitor.MonitorMBean>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Monitor.Monitor"/> to <see cref="Javax.Management.MBeanRegistration"/>
        /// </summary>
        public static implicit operator Javax.Management.MBeanRegistration(Javax.Management.Monitor.Monitor t) => t.Cast<Javax.Management.MBeanRegistration>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#getGranularityPeriod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#setGranularityPeriod(long)"/>
        /// </summary>
        public long GranularityPeriod
        {
            get { return IExecuteWithSignature<long>("getGranularityPeriod", "()J"); } set { IExecuteWithSignature("setGranularityPeriod", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#getObservedAttribute()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#setObservedAttribute(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ObservedAttribute
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getObservedAttribute", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setObservedAttribute", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#getObservedObjects()"/> 
        /// </summary>
        public Javax.Management.ObjectName[] ObservedObjects
        {
            get { return IExecuteWithSignatureArray<Javax.Management.ObjectName>("getObservedObjects", "()[Ljavax/management/ObjectName;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#stop()"/>
        /// </summary>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#preRegister(javax.management.MBeanServer,javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        public Javax.Management.ObjectName PreRegister(Javax.Management.MBeanServer arg0, Javax.Management.ObjectName arg1)
        {
            return IExecute<Javax.Management.ObjectName>("preRegister", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#containsObservedObject(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsObservedObject(Javax.Management.ObjectName arg0)
        {
            return IExecuteWithSignature<bool>("containsObservedObject", "(Ljavax/management/ObjectName;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#isActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsActive()
        {
            return IExecuteWithSignature<bool>("isActive", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#addObservedObject(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void AddObservedObject(Javax.Management.ObjectName arg0)
        {
            IExecuteWithSignature("addObservedObject", "(Ljavax/management/ObjectName;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#removeObservedObject(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        public void RemoveObservedObject(Javax.Management.ObjectName arg0)
        {
            IExecuteWithSignature("removeObservedObject", "(Ljavax/management/ObjectName;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#postDeregister()"/>
        /// </summary>
        public void PostDeregister()
        {
            IExecuteWithSignature("postDeregister", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#postRegister(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        public void PostRegister(Java.Lang.Boolean arg0)
        {
            IExecuteWithSignature("postRegister", "(Ljava/lang/Boolean;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#preDeregister()"/>
        /// </summary>
        /// <exception cref="Java.Lang.Exception"/>
        public void PreDeregister()
        {
            IExecuteWithSignature("preDeregister", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}