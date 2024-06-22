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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region INotificationFilter
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.management.NotificationFilter implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/NotificationFilter.html"/>
    /// </summary>
    public partial interface INotificationFilter
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/NotificationFilter.html#isNotificationEnabled(javax.management.Notification)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Notification"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsNotificationEnabled(Javax.Management.Notification arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NotificationFilter
    public partial class NotificationFilter : Javax.Management.INotificationFilter
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
        /// Handlers initializer for <see cref="NotificationFilter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("isNotificationEnabled", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Management.Notification>>>(IsNotificationEnabledEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/NotificationFilter.html#isNotificationEnabled(javax.management.Notification)"/>
        /// </summary>
        /// <remarks>If <see cref="OnIsNotificationEnabled"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Javax.Management.Notification, bool> OnIsNotificationEnabled { get; set; } = null;

        void IsNotificationEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Management.Notification>> data)
        {
            var methodToExecute = (OnIsNotificationEnabled != null) ? OnIsNotificationEnabled : IsNotificationEnabled;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/NotificationFilter.html#isNotificationEnabled(javax.management.Notification)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Notification"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool IsNotificationEnabled(Javax.Management.Notification arg0)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NotificationFilterDirect
    public partial class NotificationFilterDirect : Javax.Management.INotificationFilter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/NotificationFilter.html#isNotificationEnabled(javax.management.Notification)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Notification"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool IsNotificationEnabled(Javax.Management.Notification arg0)
        {
            return IExecuteWithSignature<bool>("isNotificationEnabled", "(Ljavax/management/Notification;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}