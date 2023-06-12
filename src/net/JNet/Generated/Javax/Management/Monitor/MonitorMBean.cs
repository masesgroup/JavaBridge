/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Monitor
{
    #region IMonitorMBean
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html"/>
    /// </summary>
    public partial interface IMonitorMBean
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#getGranularityPeriod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#setGranularityPeriod(long)"/>
        /// </summary>
        long GranularityPeriod { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#getObservedAttribute()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#setObservedAttribute(java.lang.String)"/>
        /// </summary>
        string ObservedAttribute { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#getObservedObjects()"/> 
        /// </summary>
        Javax.Management.ObjectName[] ObservedObjects { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#containsObservedObject(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="bool"/></returns>
        bool ContainsObservedObject(Javax.Management.ObjectName arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#isActive()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsActive();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#addObservedObject(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        void AddObservedObject(Javax.Management.ObjectName arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#removeObservedObject(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        void RemoveObservedObject(Javax.Management.ObjectName arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#start()"/>
        /// </summary>
        void Start();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#stop()"/>
        /// </summary>
        void Stop();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MonitorMBean
    public partial class MonitorMBean : Javax.Management.Monitor.IMonitorMBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#getGranularityPeriod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#setGranularityPeriod(long)"/>
        /// </summary>
        public long GranularityPeriod
        {
            get { return IExecute<long>("getGranularityPeriod"); } set { IExecute("setGranularityPeriod", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#getObservedAttribute()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#setObservedAttribute(java.lang.String)"/>
        /// </summary>
        public string ObservedAttribute
        {
            get { return IExecute<string>("getObservedAttribute"); } set { IExecute("setObservedAttribute", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#getObservedObjects()"/> 
        /// </summary>
        public Javax.Management.ObjectName[] ObservedObjects
        {
            get { return IExecuteArray<Javax.Management.ObjectName>("getObservedObjects"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#containsObservedObject(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsObservedObject(Javax.Management.ObjectName arg0)
        {
            return IExecute<bool>("containsObservedObject", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#isActive()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsActive()
        {
            return IExecute<bool>("isActive");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#addObservedObject(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void AddObservedObject(Javax.Management.ObjectName arg0)
        {
            IExecute("addObservedObject", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#removeObservedObject(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        public void RemoveObservedObject(Javax.Management.ObjectName arg0)
        {
            IExecute("removeObservedObject", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecute("start");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorMBean.html#stop()"/>
        /// </summary>
        public void Stop()
        {
            IExecute("stop");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}