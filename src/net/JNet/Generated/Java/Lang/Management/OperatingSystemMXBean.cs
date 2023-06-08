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
    #region IOperatingSystemMXBean
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html"/>
    /// </summary>
    public partial interface IOperatingSystemMXBean : Java.Lang.Management.IPlatformManagedObject
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getArch()"/> 
        /// </summary>
        string Arch { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getAvailableProcessors()"/> 
        /// </summary>
        int AvailableProcessors { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getName()"/> 
        /// </summary>
        string Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getSystemLoadAverage()"/> 
        /// </summary>
        double SystemLoadAverage { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getVersion()"/> 
        /// </summary>
        string Version { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OperatingSystemMXBean
    public partial class OperatingSystemMXBean : Java.Lang.Management.IOperatingSystemMXBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getArch()"/> 
        /// </summary>
        public string Arch
        {
            get { return IExecute<string>("getArch"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getAvailableProcessors()"/> 
        /// </summary>
        public int AvailableProcessors
        {
            get { return IExecute<int>("getAvailableProcessors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getSystemLoadAverage()"/> 
        /// </summary>
        public double SystemLoadAverage
        {
            get { return IExecute<double>("getSystemLoadAverage"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getVersion()"/> 
        /// </summary>
        public string Version
        {
            get { return IExecute<string>("getVersion"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}