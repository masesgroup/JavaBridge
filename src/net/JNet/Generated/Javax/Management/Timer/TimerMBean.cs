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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Timer
{
    #region ITimerMBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITimerMBean
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getAllNotificationIDs()"/> 
        /// </summary>
        Java.Util.Vector<Java.Lang.Integer> AllNotificationIDs { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNbNotifications()"/> 
        /// </summary>
        int NbNotifications { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getSendPastNotifications()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#setSendPastNotifications(boolean)"/>
        /// </summary>
        bool SendPastNotifications { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#isActive()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsActive();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#isEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsEmpty();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getFixedRate(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        Java.Lang.Boolean GetFixedRate(Java.Lang.Integer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long,long,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        Java.Lang.Integer AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3, long arg4, long arg5, bool arg6);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        Java.Lang.Integer AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3, long arg4, long arg5);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        Java.Lang.Integer AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3, long arg4);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        Java.Lang.Integer AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNbOccurences(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        Java.Lang.Long GetNbOccurences(Java.Lang.Integer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getPeriod(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        Java.Lang.Long GetPeriod(Java.Lang.Integer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationUserData(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="object"/></returns>
        object GetNotificationUserData(Java.Lang.Integer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationMessage(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="string"/></returns>
        string GetNotificationMessage(Java.Lang.Integer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationType(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="string"/></returns>
        string GetNotificationType(Java.Lang.Integer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getDate(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        Java.Util.Date GetDate(Java.Lang.Integer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationIDs(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Vector"/></returns>
        Java.Util.Vector<Java.Lang.Integer> GetNotificationIDs(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#removeAllNotifications()"/>
        /// </summary>
        void RemoveAllNotifications();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#removeNotification(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        void RemoveNotification(Java.Lang.Integer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#removeNotifications(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        void RemoveNotifications(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#start()"/>
        /// </summary>
        void Start();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#stop()"/>
        /// </summary>
        void Stop();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TimerMBean
    public partial class TimerMBean : Javax.Management.Timer.ITimerMBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getAllNotificationIDs()"/> 
        /// </summary>
        public Java.Util.Vector<Java.Lang.Integer> AllNotificationIDs
        {
            get { return IExecute<Java.Util.Vector<Java.Lang.Integer>>("getAllNotificationIDs"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNbNotifications()"/> 
        /// </summary>
        public int NbNotifications
        {
            get { return IExecute<int>("getNbNotifications"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getSendPastNotifications()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#setSendPastNotifications(boolean)"/>
        /// </summary>
        public bool SendPastNotifications
        {
            get { return IExecute<bool>("getSendPastNotifications"); } set { IExecute("setSendPastNotifications", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#isActive()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsActive()
        {
            return IExecute<bool>("isActive");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#isEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getFixedRate(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public Java.Lang.Boolean GetFixedRate(Java.Lang.Integer arg0)
        {
            return IExecute<Java.Lang.Boolean>("getFixedRate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long,long,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Lang.Integer AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3, long arg4, long arg5, bool arg6)
        {
            return IExecute<Java.Lang.Integer>("addNotification", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Lang.Integer AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3, long arg4, long arg5)
        {
            return IExecute<Java.Lang.Integer>("addNotification", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Lang.Integer AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3, long arg4)
        {
            return IExecute<Java.Lang.Integer>("addNotification", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Lang.Integer AddNotification(string arg0, string arg1, object arg2, Java.Util.Date arg3)
        {
            return IExecute<Java.Lang.Integer>("addNotification", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNbOccurences(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long GetNbOccurences(Java.Lang.Integer arg0)
        {
            return IExecute<Java.Lang.Long>("getNbOccurences", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getPeriod(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long GetPeriod(Java.Lang.Integer arg0)
        {
            return IExecute<Java.Lang.Long>("getPeriod", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationUserData(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetNotificationUserData(Java.Lang.Integer arg0)
        {
            return IExecute("getNotificationUserData", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationMessage(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetNotificationMessage(Java.Lang.Integer arg0)
        {
            return IExecute<string>("getNotificationMessage", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationType(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetNotificationType(Java.Lang.Integer arg0)
        {
            return IExecute<string>("getNotificationType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getDate(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetDate(Java.Lang.Integer arg0)
        {
            return IExecute<Java.Util.Date>("getDate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#getNotificationIDs(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Vector"/></returns>
        public Java.Util.Vector<Java.Lang.Integer> GetNotificationIDs(string arg0)
        {
            return IExecute<Java.Util.Vector<Java.Lang.Integer>>("getNotificationIDs", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#removeAllNotifications()"/>
        /// </summary>
        public void RemoveAllNotifications()
        {
            IExecute("removeAllNotifications");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#removeNotification(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        public void RemoveNotification(Java.Lang.Integer arg0)
        {
            IExecute("removeNotification", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#removeNotifications(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        public void RemoveNotifications(string arg0)
        {
            IExecute("removeNotifications", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecute("start");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerMBean.html#stop()"/>
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