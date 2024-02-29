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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Remote
{
    #region JMXConnectionNotification
    public partial class JMXConnectionNotification
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectionNotification.html#%3Cinit%3E(java.lang.String,java.lang.Object,java.lang.String,long,java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        public JMXConnectionNotification(Java.Lang.String arg0, object arg1, Java.Lang.String arg2, long arg3, Java.Lang.String arg4, object arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectionNotification.html#CLOSED"/>
        /// </summary>
        public static Java.Lang.String CLOSED { get { if (!_CLOSEDReady) { _CLOSEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CLOSED"); _CLOSEDReady = true; } return _CLOSEDContent; } }
        private static Java.Lang.String _CLOSEDContent = default;
        private static bool _CLOSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectionNotification.html#FAILED"/>
        /// </summary>
        public static Java.Lang.String FAILED { get { if (!_FAILEDReady) { _FAILEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FAILED"); _FAILEDReady = true; } return _FAILEDContent; } }
        private static Java.Lang.String _FAILEDContent = default;
        private static bool _FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectionNotification.html#NOTIFS_LOST"/>
        /// </summary>
        public static Java.Lang.String NOTIFS_LOST { get { if (!_NOTIFS_LOSTReady) { _NOTIFS_LOSTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "NOTIFS_LOST"); _NOTIFS_LOSTReady = true; } return _NOTIFS_LOSTContent; } }
        private static Java.Lang.String _NOTIFS_LOSTContent = default;
        private static bool _NOTIFS_LOSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectionNotification.html#OPENED"/>
        /// </summary>
        public static Java.Lang.String OPENED { get { if (!_OPENEDReady) { _OPENEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OPENED"); _OPENEDReady = true; } return _OPENEDContent; } }
        private static Java.Lang.String _OPENEDContent = default;
        private static bool _OPENEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectionNotification.html#getConnectionId()"/> 
        /// </summary>
        public Java.Lang.String ConnectionId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getConnectionId", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}