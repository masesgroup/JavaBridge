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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Timer
{
    #region TimerNotification
    public partial class TimerNotification
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerNotification.html#%3Cinit%3E(java.lang.String,java.lang.Object,long,long,java.lang.String,java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see langword="object"/></param>
        /// <param name="arg2"><see langword="long"/></param>
        /// <param name="arg3"><see langword="long"/></param>
        /// <param name="arg4"><see langword="string"/></param>
        /// <param name="arg5"><see langword="int?"/></param>
        public TimerNotification(string arg0, object arg1, long arg2, long arg3, string arg4, int? arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/TimerNotification.html#getNotificationID()"/> 
        /// </summary>
        public int? NotificationID
        {
            get { return IExecute<int?>("getNotificationID"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}