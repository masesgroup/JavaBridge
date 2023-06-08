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
    #region ManagementFactory
    public partial class ManagementFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#CLASS_LOADING_MXBEAN_NAME"/>
        /// </summary>
        public static string CLASS_LOADING_MXBEAN_NAME { get { return SGetField<string>(LocalBridgeClazz, "CLASS_LOADING_MXBEAN_NAME"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#COMPILATION_MXBEAN_NAME"/>
        /// </summary>
        public static string COMPILATION_MXBEAN_NAME { get { return SGetField<string>(LocalBridgeClazz, "COMPILATION_MXBEAN_NAME"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#GARBAGE_COLLECTOR_MXBEAN_DOMAIN_TYPE"/>
        /// </summary>
        public static string GARBAGE_COLLECTOR_MXBEAN_DOMAIN_TYPE { get { return SGetField<string>(LocalBridgeClazz, "GARBAGE_COLLECTOR_MXBEAN_DOMAIN_TYPE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#MEMORY_MANAGER_MXBEAN_DOMAIN_TYPE"/>
        /// </summary>
        public static string MEMORY_MANAGER_MXBEAN_DOMAIN_TYPE { get { return SGetField<string>(LocalBridgeClazz, "MEMORY_MANAGER_MXBEAN_DOMAIN_TYPE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#MEMORY_MXBEAN_NAME"/>
        /// </summary>
        public static string MEMORY_MXBEAN_NAME { get { return SGetField<string>(LocalBridgeClazz, "MEMORY_MXBEAN_NAME"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#MEMORY_POOL_MXBEAN_DOMAIN_TYPE"/>
        /// </summary>
        public static string MEMORY_POOL_MXBEAN_DOMAIN_TYPE { get { return SGetField<string>(LocalBridgeClazz, "MEMORY_POOL_MXBEAN_DOMAIN_TYPE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#OPERATING_SYSTEM_MXBEAN_NAME"/>
        /// </summary>
        public static string OPERATING_SYSTEM_MXBEAN_NAME { get { return SGetField<string>(LocalBridgeClazz, "OPERATING_SYSTEM_MXBEAN_NAME"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#RUNTIME_MXBEAN_NAME"/>
        /// </summary>
        public static string RUNTIME_MXBEAN_NAME { get { return SGetField<string>(LocalBridgeClazz, "RUNTIME_MXBEAN_NAME"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#THREAD_MXBEAN_NAME"/>
        /// </summary>
        public static string THREAD_MXBEAN_NAME { get { return SGetField<string>(LocalBridgeClazz, "THREAD_MXBEAN_NAME"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getClassLoadingMXBean()"/> 
        /// </summary>
        public static Java.Lang.Management.ClassLoadingMXBean ClassLoadingMXBean
        {
            get { return SExecute<Java.Lang.Management.ClassLoadingMXBean>(LocalBridgeClazz, "getClassLoadingMXBean"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getCompilationMXBean()"/> 
        /// </summary>
        public static Java.Lang.Management.CompilationMXBean CompilationMXBean
        {
            get { return SExecute<Java.Lang.Management.CompilationMXBean>(LocalBridgeClazz, "getCompilationMXBean"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getGarbageCollectorMXBeans()"/> 
        /// </summary>
        public static Java.Util.List<Java.Lang.Management.GarbageCollectorMXBean> GarbageCollectorMXBeans
        {
            get { return SExecute<Java.Util.List<Java.Lang.Management.GarbageCollectorMXBean>>(LocalBridgeClazz, "getGarbageCollectorMXBeans"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getMemoryManagerMXBeans()"/> 
        /// </summary>
        public static Java.Util.List<Java.Lang.Management.MemoryManagerMXBean> MemoryManagerMXBeans
        {
            get { return SExecute<Java.Util.List<Java.Lang.Management.MemoryManagerMXBean>>(LocalBridgeClazz, "getMemoryManagerMXBeans"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getMemoryMXBean()"/> 
        /// </summary>
        public static Java.Lang.Management.MemoryMXBean MemoryMXBean
        {
            get { return SExecute<Java.Lang.Management.MemoryMXBean>(LocalBridgeClazz, "getMemoryMXBean"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getMemoryPoolMXBeans()"/> 
        /// </summary>
        public static Java.Util.List<Java.Lang.Management.MemoryPoolMXBean> MemoryPoolMXBeans
        {
            get { return SExecute<Java.Util.List<Java.Lang.Management.MemoryPoolMXBean>>(LocalBridgeClazz, "getMemoryPoolMXBeans"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getOperatingSystemMXBean()"/> 
        /// </summary>
        public static Java.Lang.Management.OperatingSystemMXBean OperatingSystemMXBean
        {
            get { return SExecute<Java.Lang.Management.OperatingSystemMXBean>(LocalBridgeClazz, "getOperatingSystemMXBean"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getPlatformManagementInterfaces()"/> 
        /// </summary>
        public static Java.Util.Set PlatformManagementInterfaces
        {
            get { return SExecute<Java.Util.Set>(LocalBridgeClazz, "getPlatformManagementInterfaces"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getPlatformMBeanServer()"/> 
        /// </summary>
        public static Javax.Management.MBeanServer PlatformMBeanServer
        {
            get { return SExecute<Javax.Management.MBeanServer>(LocalBridgeClazz, "getPlatformMBeanServer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getRuntimeMXBean()"/> 
        /// </summary>
        public static Java.Lang.Management.RuntimeMXBean RuntimeMXBean
        {
            get { return SExecute<Java.Lang.Management.RuntimeMXBean>(LocalBridgeClazz, "getRuntimeMXBean"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getThreadMXBean()"/> 
        /// </summary>
        public static Java.Lang.Management.ThreadMXBean ThreadMXBean
        {
            get { return SExecute<Java.Lang.Management.ThreadMXBean>(LocalBridgeClazz, "getThreadMXBean"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getPlatformMXBeans(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Management.IPlatformManagedObject"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<T> GetPlatformMXBeans<T>(Java.Lang.Class arg0) where T: Java.Lang.Management.IPlatformManagedObject, new()
        {
            return SExecute<Java.Util.List<T>>(LocalBridgeClazz, "getPlatformMXBeans", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getPlatformMXBeans(javax.management.MBeanServerConnection,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServerConnection"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Management.IPlatformManagedObject"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Util.List<T> GetPlatformMXBeans<T>(Javax.Management.MBeanServerConnection arg0, Java.Lang.Class arg1) where T: Java.Lang.Management.IPlatformManagedObject, new()
        {
            return SExecute<Java.Util.List<T>>(LocalBridgeClazz, "getPlatformMXBeans", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getPlatformMXBean(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Management.IPlatformManagedObject"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T GetPlatformMXBean<T>(Java.Lang.Class arg0) where T: Java.Lang.Management.IPlatformManagedObject, new()
        {
            return SExecute<T>(LocalBridgeClazz, "getPlatformMXBean", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#getPlatformMXBean(javax.management.MBeanServerConnection,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServerConnection"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Management.IPlatformManagedObject"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static T GetPlatformMXBean<T>(Javax.Management.MBeanServerConnection arg0, Java.Lang.Class arg1) where T: Java.Lang.Management.IPlatformManagedObject, new()
        {
            return SExecute<T>(LocalBridgeClazz, "getPlatformMXBean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ManagementFactory.html#newPlatformMXBeanProxy(javax.management.MBeanServerConnection,java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServerConnection"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static T NewPlatformMXBeanProxy<T>(Javax.Management.MBeanServerConnection arg0, string arg1, Java.Lang.Class arg2)
        {
            return SExecute<T>(LocalBridgeClazz, "newPlatformMXBeanProxy", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}