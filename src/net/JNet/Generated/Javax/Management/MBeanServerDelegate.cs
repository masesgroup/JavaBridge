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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region MBeanServerDelegate
    public partial class MBeanServerDelegate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.MBeanServerDelegate"/> to <see cref="Javax.Management.MBeanServerDelegateMBean"/>
        /// </summary>
        public static implicit operator Javax.Management.MBeanServerDelegateMBean(Javax.Management.MBeanServerDelegate t) => t.Cast<Javax.Management.MBeanServerDelegateMBean>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.MBeanServerDelegate"/> to <see cref="Javax.Management.NotificationEmitter"/>
        /// </summary>
        public static implicit operator Javax.Management.NotificationEmitter(Javax.Management.MBeanServerDelegate t) => t.Cast<Javax.Management.NotificationEmitter>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerDelegate.html#DELEGATE_NAME"/>
        /// </summary>
        public static Javax.Management.ObjectName DELEGATE_NAME { get { if (!_DELEGATE_NAMEReady) { _DELEGATE_NAMEContent = SGetField<Javax.Management.ObjectName>(LocalBridgeClazz, "DELEGATE_NAME"); _DELEGATE_NAMEReady = true; } return _DELEGATE_NAMEContent; } }
        private static Javax.Management.ObjectName _DELEGATE_NAMEContent = default;
        private static bool _DELEGATE_NAMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerDelegate.html#getImplementationName()"/> 
        /// </summary>
        public Java.Lang.String ImplementationName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getImplementationName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerDelegate.html#getImplementationVendor()"/> 
        /// </summary>
        public Java.Lang.String ImplementationVendor
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getImplementationVendor", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerDelegate.html#getImplementationVersion()"/> 
        /// </summary>
        public Java.Lang.String ImplementationVersion
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getImplementationVersion", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerDelegate.html#getMBeanServerId()"/> 
        /// </summary>
        public Java.Lang.String MBeanServerId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMBeanServerId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerDelegate.html#getNotificationInfo()"/> 
        /// </summary>
        public Javax.Management.MBeanNotificationInfo[] NotificationInfo
        {
            get { return IExecuteWithSignatureArray<Javax.Management.MBeanNotificationInfo>("getNotificationInfo", "()[Ljavax/management/MBeanNotificationInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerDelegate.html#getSpecificationName()"/> 
        /// </summary>
        public Java.Lang.String SpecificationName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSpecificationName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerDelegate.html#getSpecificationVendor()"/> 
        /// </summary>
        public Java.Lang.String SpecificationVendor
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSpecificationVendor", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerDelegate.html#getSpecificationVersion()"/> 
        /// </summary>
        public Java.Lang.String SpecificationVersion
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSpecificationVersion", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerDelegate.html#addNotificationListener(javax.management.NotificationListener,javax.management.NotificationFilter,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="Javax.Management.NotificationFilter"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void AddNotificationListener(Javax.Management.NotificationListener arg0, Javax.Management.NotificationFilter arg1, object arg2)
        {
            IExecute("addNotificationListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerDelegate.html#removeNotificationListener(javax.management.NotificationListener,javax.management.NotificationFilter,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="Javax.Management.NotificationFilter"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        public void RemoveNotificationListener(Javax.Management.NotificationListener arg0, Javax.Management.NotificationFilter arg1, object arg2)
        {
            IExecute("removeNotificationListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerDelegate.html#removeNotificationListener(javax.management.NotificationListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        public void RemoveNotificationListener(Javax.Management.NotificationListener arg0)
        {
            IExecuteWithSignature("removeNotificationListener", "(Ljavax/management/NotificationListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerDelegate.html#sendNotification(javax.management.Notification)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Notification"/></param>
        public void SendNotification(Javax.Management.Notification arg0)
        {
            IExecuteWithSignature("sendNotification", "(Ljavax/management/Notification;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}