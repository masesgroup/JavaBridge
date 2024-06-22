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

namespace Javax.Management.Remote
{
    #region TargetedNotification
    public partial class TargetedNotification
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/TargetedNotification.html#%3Cinit%3E(javax.management.Notification,java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Notification"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        public TargetedNotification(Javax.Management.Notification arg0, Java.Lang.Integer arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/TargetedNotification.html#getListenerID()"/> 
        /// </summary>
        public Java.Lang.Integer ListenerID
        {
            get { return IExecuteWithSignature<Java.Lang.Integer>("getListenerID", "()Ljava/lang/Integer;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/TargetedNotification.html#getNotification()"/> 
        /// </summary>
        public Javax.Management.Notification Notification
        {
            get { return IExecuteWithSignature<Javax.Management.Notification>("getNotification", "()Ljavax/management/Notification;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}