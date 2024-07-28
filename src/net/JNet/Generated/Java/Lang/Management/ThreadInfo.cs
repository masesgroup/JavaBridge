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
    #region ThreadInfo
    public partial class ThreadInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#from(javax.management.openmbean.CompositeData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public static Java.Lang.Management.ThreadInfo From(Javax.Management.Openmbean.CompositeData arg0)
        {
            return SExecuteWithSignature<Java.Lang.Management.ThreadInfo>(LocalBridgeClazz, "from", "(Ljavax/management/openmbean/CompositeData;)Ljava/lang/management/ThreadInfo;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getBlockedCount()"/> 
        /// </summary>
        public long BlockedCount
        {
            get { return IExecuteWithSignature<long>("getBlockedCount", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getBlockedTime()"/> 
        /// </summary>
        public long BlockedTime
        {
            get { return IExecuteWithSignature<long>("getBlockedTime", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getLockedMonitors()"/> 
        /// </summary>
        public Java.Lang.Management.MonitorInfo[] LockedMonitors
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Management.MonitorInfo>("getLockedMonitors", "()[Ljava/lang/management/MonitorInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getLockedSynchronizers()"/> 
        /// </summary>
        public Java.Lang.Management.LockInfo[] LockedSynchronizers
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Management.LockInfo>("getLockedSynchronizers", "()[Ljava/lang/management/LockInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getLockInfo()"/> 
        /// </summary>
        public Java.Lang.Management.LockInfo LockInfo
        {
            get { return IExecuteWithSignature<Java.Lang.Management.LockInfo>("getLockInfo", "()Ljava/lang/management/LockInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getLockName()"/> 
        /// </summary>
        public Java.Lang.String LockName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLockName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getLockOwnerId()"/> 
        /// </summary>
        public long LockOwnerId
        {
            get { return IExecuteWithSignature<long>("getLockOwnerId", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getLockOwnerName()"/> 
        /// </summary>
        public Java.Lang.String LockOwnerName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLockOwnerName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getPriority()"/> 
        /// </summary>
        public int Priority
        {
            get { return IExecuteWithSignature<int>("getPriority", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getStackTrace()"/> 
        /// </summary>
        public Java.Lang.StackTraceElement[] StackTrace
        {
            get { return IExecuteWithSignatureArray<Java.Lang.StackTraceElement>("getStackTrace", "()[Ljava/lang/StackTraceElement;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getThreadId()"/> 
        /// </summary>
        public long ThreadId
        {
            get { return IExecuteWithSignature<long>("getThreadId", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getThreadName()"/> 
        /// </summary>
        public Java.Lang.String ThreadName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getThreadName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getThreadState()"/> 
        /// </summary>
        public Java.Lang.Thread.State ThreadState
        {
            get { return IExecuteWithSignature<Java.Lang.Thread.State>("getThreadState", "()Ljava/lang/Thread$State;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getWaitedCount()"/> 
        /// </summary>
        public long WaitedCount
        {
            get { return IExecuteWithSignature<long>("getWaitedCount", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#getWaitedTime()"/> 
        /// </summary>
        public long WaitedTime
        {
            get { return IExecuteWithSignature<long>("getWaitedTime", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#isDaemon()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDaemon()
        {
            return IExecuteWithSignature<bool>("isDaemon", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#isInNative()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInNative()
        {
            return IExecuteWithSignature<bool>("isInNative", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadInfo.html#isSuspended()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSuspended()
        {
            return IExecuteWithSignature<bool>("isSuspended", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}