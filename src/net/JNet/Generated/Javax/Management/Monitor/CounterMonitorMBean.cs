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

namespace Javax.Management.Monitor
{
    #region CounterMonitorMBean declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html"/>
    /// </summary>
    public partial class CounterMonitorMBean : Javax.Management.Monitor.MonitorMBean
    {
        const string _bridgeClassName = "javax.management.monitor.CounterMonitorMBean";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CounterMonitorMBean class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CounterMonitorMBean() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CounterMonitorMBean class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CounterMonitorMBean(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ICounterMonitorMBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICounterMonitorMBean : Javax.Management.Monitor.IMonitorMBean
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getDifferenceMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setDifferenceMode(boolean)"/>
        /// </summary>
        bool DifferenceMode { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getInitThreshold()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setInitThreshold(java.lang.Number)"/>
        /// </summary>
        Java.Lang.Number InitThreshold { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getModulus()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setModulus(java.lang.Number)"/>
        /// </summary>
        Java.Lang.Number Modulus { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getNotify()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setNotify(boolean)"/>
        /// </summary>
        bool Notify { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setOffset(java.lang.Number)"/>
        /// </summary>
        Java.Lang.Number Offset { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getDerivedGauge(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        Java.Lang.Number GetDerivedGauge(Javax.Management.ObjectName arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getThreshold(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        Java.Lang.Number GetThreshold(Javax.Management.ObjectName arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getDerivedGaugeTimeStamp(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="long"/></returns>
        long GetDerivedGaugeTimeStamp(Javax.Management.ObjectName arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CounterMonitorMBean implementation
    public partial class CounterMonitorMBean : Javax.Management.Monitor.ICounterMonitorMBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getDifferenceMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setDifferenceMode(boolean)"/>
        /// </summary>
        public bool DifferenceMode
        {
            get { return IExecuteWithSignature<bool>("getDifferenceMode", "()Z"); } set { IExecuteWithSignature("setDifferenceMode", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getInitThreshold()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setInitThreshold(java.lang.Number)"/>
        /// </summary>
        public Java.Lang.Number InitThreshold
        {
            get { return IExecuteWithSignature<Java.Lang.Number>("getInitThreshold", "()Ljava/lang/Number;"); } set { IExecuteWithSignature("setInitThreshold", "(Ljava/lang/Number;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getModulus()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setModulus(java.lang.Number)"/>
        /// </summary>
        public Java.Lang.Number Modulus
        {
            get { return IExecuteWithSignature<Java.Lang.Number>("getModulus", "()Ljava/lang/Number;"); } set { IExecuteWithSignature("setModulus", "(Ljava/lang/Number;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getNotify()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setNotify(boolean)"/>
        /// </summary>
        public bool Notify
        {
            get { return IExecuteWithSignature<bool>("getNotify", "()Z"); } set { IExecuteWithSignature("setNotify", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#setOffset(java.lang.Number)"/>
        /// </summary>
        public Java.Lang.Number Offset
        {
            get { return IExecuteWithSignature<Java.Lang.Number>("getOffset", "()Ljava/lang/Number;"); } set { IExecuteWithSignature("setOffset", "(Ljava/lang/Number;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getDerivedGauge(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        public Java.Lang.Number GetDerivedGauge(Javax.Management.ObjectName arg0)
        {
            return IExecuteWithSignature<Java.Lang.Number>("getDerivedGauge", "(Ljavax/management/ObjectName;)Ljava/lang/Number;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getThreshold(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        public Java.Lang.Number GetThreshold(Javax.Management.ObjectName arg0)
        {
            return IExecuteWithSignature<Java.Lang.Number>("getThreshold", "(Ljavax/management/ObjectName;)Ljava/lang/Number;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/CounterMonitorMBean.html#getDerivedGaugeTimeStamp(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetDerivedGaugeTimeStamp(Javax.Management.ObjectName arg0)
        {
            return IExecuteWithSignature<long>("getDerivedGaugeTimeStamp", "(Ljavax/management/ObjectName;)J", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}