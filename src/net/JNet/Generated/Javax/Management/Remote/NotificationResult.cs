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

namespace Javax.Management.Remote
{
    #region NotificationResult
    public partial class NotificationResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/NotificationResult.html#%3Cinit%3E(long,long,javax.management.remote.TargetedNotification[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Remote.TargetedNotification"/></param>
        public NotificationResult(long arg0, long arg1, Javax.Management.Remote.TargetedNotification[] arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/NotificationResult.html#getEarliestSequenceNumber()"/> 
        /// </summary>
        public long EarliestSequenceNumber
        {
            get { return IExecute<long>("getEarliestSequenceNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/NotificationResult.html#getNextSequenceNumber()"/> 
        /// </summary>
        public long NextSequenceNumber
        {
            get { return IExecute<long>("getNextSequenceNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/NotificationResult.html#getTargetedNotifications()"/> 
        /// </summary>
        public Javax.Management.Remote.TargetedNotification[] TargetedNotifications
        {
            get { return IExecuteArray<Javax.Management.Remote.TargetedNotification>("getTargetedNotifications"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}