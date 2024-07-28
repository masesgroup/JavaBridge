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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Management
{
    #region MemoryNotificationInfo
    public partial class MemoryNotificationInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryNotificationInfo.html#%3Cinit%3E(java.lang.String,java.lang.management.MemoryUsage,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Management.MemoryUsage"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public MemoryNotificationInfo(Java.Lang.String arg0, Java.Lang.Management.MemoryUsage arg1, long arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryNotificationInfo.html#MEMORY_COLLECTION_THRESHOLD_EXCEEDED"/>
        /// </summary>
        public static Java.Lang.String MEMORY_COLLECTION_THRESHOLD_EXCEEDED { get { if (!_MEMORY_COLLECTION_THRESHOLD_EXCEEDEDReady) { _MEMORY_COLLECTION_THRESHOLD_EXCEEDEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEMORY_COLLECTION_THRESHOLD_EXCEEDED"); _MEMORY_COLLECTION_THRESHOLD_EXCEEDEDReady = true; } return _MEMORY_COLLECTION_THRESHOLD_EXCEEDEDContent; } }
        private static Java.Lang.String _MEMORY_COLLECTION_THRESHOLD_EXCEEDEDContent = default;
        private static bool _MEMORY_COLLECTION_THRESHOLD_EXCEEDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryNotificationInfo.html#MEMORY_THRESHOLD_EXCEEDED"/>
        /// </summary>
        public static Java.Lang.String MEMORY_THRESHOLD_EXCEEDED { get { if (!_MEMORY_THRESHOLD_EXCEEDEDReady) { _MEMORY_THRESHOLD_EXCEEDEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEMORY_THRESHOLD_EXCEEDED"); _MEMORY_THRESHOLD_EXCEEDEDReady = true; } return _MEMORY_THRESHOLD_EXCEEDEDContent; } }
        private static Java.Lang.String _MEMORY_THRESHOLD_EXCEEDEDContent = default;
        private static bool _MEMORY_THRESHOLD_EXCEEDEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryNotificationInfo.html#from(javax.management.openmbean.CompositeData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        /// <returns><see cref="Java.Lang.Management.MemoryNotificationInfo"/></returns>
        public static Java.Lang.Management.MemoryNotificationInfo From(Javax.Management.Openmbean.CompositeData arg0)
        {
            return SExecuteWithSignature<Java.Lang.Management.MemoryNotificationInfo>(LocalBridgeClazz, "from", "(Ljavax/management/openmbean/CompositeData;)Ljava/lang/management/MemoryNotificationInfo;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryNotificationInfo.html#getCount()"/> 
        /// </summary>
        public long Count
        {
            get { return IExecuteWithSignature<long>("getCount", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryNotificationInfo.html#getPoolName()"/> 
        /// </summary>
        public Java.Lang.String PoolName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPoolName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryNotificationInfo.html#getUsage()"/> 
        /// </summary>
        public Java.Lang.Management.MemoryUsage Usage
        {
            get { return IExecuteWithSignature<Java.Lang.Management.MemoryUsage>("getUsage", "()Ljava/lang/management/MemoryUsage;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}