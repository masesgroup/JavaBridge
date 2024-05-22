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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Management
{
    #region IClassLoadingMXBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IClassLoadingMXBean : Java.Lang.Management.IPlatformManagedObject
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ClassLoadingMXBean.html#getLoadedClassCount()"/> 
        /// </summary>
        int LoadedClassCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ClassLoadingMXBean.html#getTotalLoadedClassCount()"/> 
        /// </summary>
        long TotalLoadedClassCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ClassLoadingMXBean.html#getUnloadedClassCount()"/> 
        /// </summary>
        long UnloadedClassCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ClassLoadingMXBean.html#isVerbose()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsVerbose();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ClassLoadingMXBean.html#setVerbose(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetVerbose(bool arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ClassLoadingMXBean
    public partial class ClassLoadingMXBean : Java.Lang.Management.IClassLoadingMXBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ClassLoadingMXBean.html#getLoadedClassCount()"/> 
        /// </summary>
        public int LoadedClassCount
        {
            get { return IExecuteWithSignature<int>("getLoadedClassCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ClassLoadingMXBean.html#getTotalLoadedClassCount()"/> 
        /// </summary>
        public long TotalLoadedClassCount
        {
            get { return IExecuteWithSignature<long>("getTotalLoadedClassCount", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ClassLoadingMXBean.html#getUnloadedClassCount()"/> 
        /// </summary>
        public long UnloadedClassCount
        {
            get { return IExecuteWithSignature<long>("getUnloadedClassCount", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ClassLoadingMXBean.html#isVerbose()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVerbose()
        {
            return IExecuteWithSignature<bool>("isVerbose", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ClassLoadingMXBean.html#setVerbose(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetVerbose(bool arg0)
        {
            IExecuteWithSignature("setVerbose", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}