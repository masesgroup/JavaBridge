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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Management
{
    #region IThreadMXBean
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html"/>
    /// </summary>
    public partial interface IThreadMXBean : Java.Lang.Management.IPlatformManagedObject
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getAllThreadIds()"/> 
        /// </summary>
        long[] AllThreadIds { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getCurrentThreadCpuTime()"/> 
        /// </summary>
        long CurrentThreadCpuTime { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getCurrentThreadUserTime()"/> 
        /// </summary>
        long CurrentThreadUserTime { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getDaemonThreadCount()"/> 
        /// </summary>
        int DaemonThreadCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#findDeadlockedThreads()"/> 
        /// </summary>
        long[] FindDeadlockedThreads { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#findMonitorDeadlockedThreads()"/> 
        /// </summary>
        long[] FindMonitorDeadlockedThreads { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isCurrentThreadCpuTimeSupported()"/> 
        /// </summary>
        bool IsCurrentThreadCpuTimeSupported { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isObjectMonitorUsageSupported()"/> 
        /// </summary>
        bool IsObjectMonitorUsageSupported { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isSynchronizerUsageSupported()"/> 
        /// </summary>
        bool IsSynchronizerUsageSupported { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadContentionMonitoringEnabled()"/> 
        /// </summary>
        bool IsThreadContentionMonitoringEnabled { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadContentionMonitoringSupported()"/> 
        /// </summary>
        bool IsThreadContentionMonitoringSupported { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadCpuTimeEnabled()"/> 
        /// </summary>
        bool IsThreadCpuTimeEnabled { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadCpuTimeSupported()"/> 
        /// </summary>
        bool IsThreadCpuTimeSupported { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getPeakThreadCount()"/> 
        /// </summary>
        int PeakThreadCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadCount()"/> 
        /// </summary>
        int ThreadCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getTotalStartedThreadCount()"/> 
        /// </summary>
        long TotalStartedThreadCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo GetThreadInfo(long arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo GetThreadInfo(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#dumpAllThreads(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo[] DumpAllThreads(bool arg0, bool arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[],boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0, bool arg1, bool arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadCpuTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        long GetThreadCpuTime(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadUserTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        long GetThreadUserTime(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#resetPeakThreadCount()"/>
        /// </summary>
        void ResetPeakThreadCount();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#setThreadContentionMonitoringEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetThreadContentionMonitoringEnabled(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#setThreadCpuTimeEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetThreadCpuTimeEnabled(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#dumpAllThreads(boolean,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo[] DumpAllThreads(bool arg0, bool arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[],boolean,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0, bool arg1, bool arg2, int arg3);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ThreadMXBean
    public partial class ThreadMXBean : Java.Lang.Management.IThreadMXBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getAllThreadIds()"/> 
        /// </summary>
        public long[] AllThreadIds
        {
            get { return IExecuteArray<long>("getAllThreadIds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getCurrentThreadCpuTime()"/> 
        /// </summary>
        public long CurrentThreadCpuTime
        {
            get { return IExecute<long>("getCurrentThreadCpuTime"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getCurrentThreadUserTime()"/> 
        /// </summary>
        public long CurrentThreadUserTime
        {
            get { return IExecute<long>("getCurrentThreadUserTime"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getDaemonThreadCount()"/> 
        /// </summary>
        public int DaemonThreadCount
        {
            get { return IExecute<int>("getDaemonThreadCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#findDeadlockedThreads()"/> 
        /// </summary>
        public long[] FindDeadlockedThreads
        {
            get { return IExecuteArray<long>("findDeadlockedThreads"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#findMonitorDeadlockedThreads()"/> 
        /// </summary>
        public long[] FindMonitorDeadlockedThreads
        {
            get { return IExecuteArray<long>("findMonitorDeadlockedThreads"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isCurrentThreadCpuTimeSupported()"/> 
        /// </summary>
        public bool IsCurrentThreadCpuTimeSupported
        {
            get { return IExecute<bool>("isCurrentThreadCpuTimeSupported"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isObjectMonitorUsageSupported()"/> 
        /// </summary>
        public bool IsObjectMonitorUsageSupported
        {
            get { return IExecute<bool>("isObjectMonitorUsageSupported"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isSynchronizerUsageSupported()"/> 
        /// </summary>
        public bool IsSynchronizerUsageSupported
        {
            get { return IExecute<bool>("isSynchronizerUsageSupported"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadContentionMonitoringEnabled()"/> 
        /// </summary>
        public bool IsThreadContentionMonitoringEnabled
        {
            get { return IExecute<bool>("isThreadContentionMonitoringEnabled"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadContentionMonitoringSupported()"/> 
        /// </summary>
        public bool IsThreadContentionMonitoringSupported
        {
            get { return IExecute<bool>("isThreadContentionMonitoringSupported"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadCpuTimeEnabled()"/> 
        /// </summary>
        public bool IsThreadCpuTimeEnabled
        {
            get { return IExecute<bool>("isThreadCpuTimeEnabled"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadCpuTimeSupported()"/> 
        /// </summary>
        public bool IsThreadCpuTimeSupported
        {
            get { return IExecute<bool>("isThreadCpuTimeSupported"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getPeakThreadCount()"/> 
        /// </summary>
        public int PeakThreadCount
        {
            get { return IExecute<int>("getPeakThreadCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadCount()"/> 
        /// </summary>
        public int ThreadCount
        {
            get { return IExecute<int>("getThreadCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getTotalStartedThreadCount()"/> 
        /// </summary>
        public long TotalStartedThreadCount
        {
            get { return IExecute<long>("getTotalStartedThreadCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo GetThreadInfo(long arg0, int arg1)
        {
            return IExecute<Java.Lang.Management.ThreadInfo>("getThreadInfo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo GetThreadInfo(long arg0)
        {
            return IExecute<Java.Lang.Management.ThreadInfo>("getThreadInfo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#dumpAllThreads(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo[] DumpAllThreads(bool arg0, bool arg1)
        {
            return IExecuteArray<Java.Lang.Management.ThreadInfo>("dumpAllThreads", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[],boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0, bool arg1, bool arg2)
        {
            return IExecuteArray<Java.Lang.Management.ThreadInfo>("getThreadInfo", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0, int arg1)
        {
            return IExecuteArray<Java.Lang.Management.ThreadInfo>("getThreadInfo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0)
        {
            return IExecuteArray<Java.Lang.Management.ThreadInfo>("getThreadInfo", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadCpuTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetThreadCpuTime(long arg0)
        {
            return IExecute<long>("getThreadCpuTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadUserTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetThreadUserTime(long arg0)
        {
            return IExecute<long>("getThreadUserTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#resetPeakThreadCount()"/>
        /// </summary>
        public void ResetPeakThreadCount()
        {
            IExecute("resetPeakThreadCount");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#setThreadContentionMonitoringEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetThreadContentionMonitoringEnabled(bool arg0)
        {
            IExecute("setThreadContentionMonitoringEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#setThreadCpuTimeEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetThreadCpuTimeEnabled(bool arg0)
        {
            IExecute("setThreadCpuTimeEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#dumpAllThreads(boolean,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo[] DumpAllThreads(bool arg0, bool arg1, int arg2)
        {
            return IExecuteArray<Java.Lang.Management.ThreadInfo>("dumpAllThreads", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[],boolean,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0, bool arg1, bool arg2, int arg3)
        {
            return IExecuteArray<Java.Lang.Management.ThreadInfo>("getThreadInfo", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}