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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region MBeanInfo
    public partial class MBeanInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.MBeanAttributeInfo[],javax.management.MBeanConstructorInfo[],javax.management.MBeanOperationInfo[],javax.management.MBeanNotificationInfo[],javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.MBeanAttributeInfo"/></param>
        /// <param name="arg3"><see cref="Javax.Management.MBeanConstructorInfo"/></param>
        /// <param name="arg4"><see cref="Javax.Management.MBeanOperationInfo"/></param>
        /// <param name="arg5"><see cref="Javax.Management.MBeanNotificationInfo"/></param>
        /// <param name="arg6"><see cref="Javax.Management.Descriptor"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public MBeanInfo(string arg0, string arg1, Javax.Management.MBeanAttributeInfo[] arg2, Javax.Management.MBeanConstructorInfo[] arg3, Javax.Management.MBeanOperationInfo[] arg4, Javax.Management.MBeanNotificationInfo[] arg5, Javax.Management.Descriptor arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.MBeanAttributeInfo[],javax.management.MBeanConstructorInfo[],javax.management.MBeanOperationInfo[],javax.management.MBeanNotificationInfo[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.MBeanAttributeInfo"/></param>
        /// <param name="arg3"><see cref="Javax.Management.MBeanConstructorInfo"/></param>
        /// <param name="arg4"><see cref="Javax.Management.MBeanOperationInfo"/></param>
        /// <param name="arg5"><see cref="Javax.Management.MBeanNotificationInfo"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public MBeanInfo(string arg0, string arg1, Javax.Management.MBeanAttributeInfo[] arg2, Javax.Management.MBeanConstructorInfo[] arg3, Javax.Management.MBeanOperationInfo[] arg4, Javax.Management.MBeanNotificationInfo[] arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.MBeanInfo"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Management.MBeanInfo t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.MBeanInfo"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Management.MBeanInfo t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.MBeanInfo"/> to <see cref="Javax.Management.DescriptorRead"/>
        /// </summary>
        public static implicit operator Javax.Management.DescriptorRead(Javax.Management.MBeanInfo t) => t.Cast<Javax.Management.DescriptorRead>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanInfo.html#getAttributes()"/> 
        /// </summary>
        public Javax.Management.MBeanAttributeInfo[] Attributes
        {
            get { return IExecuteArray<Javax.Management.MBeanAttributeInfo>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanInfo.html#getClassName()"/> 
        /// </summary>
        public string ClassName
        {
            get { return IExecute<string>("getClassName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanInfo.html#getConstructors()"/> 
        /// </summary>
        public Javax.Management.MBeanConstructorInfo[] Constructors
        {
            get { return IExecuteArray<Javax.Management.MBeanConstructorInfo>("getConstructors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanInfo.html#getDescription()"/> 
        /// </summary>
        public string Description
        {
            get { return IExecute<string>("getDescription"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanInfo.html#getDescriptor()"/> 
        /// </summary>
        public Javax.Management.Descriptor Descriptor
        {
            get { return IExecute<Javax.Management.Descriptor>("getDescriptor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanInfo.html#getNotifications()"/> 
        /// </summary>
        public Javax.Management.MBeanNotificationInfo[] Notifications
        {
            get { return IExecuteArray<Javax.Management.MBeanNotificationInfo>("getNotifications"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanInfo.html#getOperations()"/> 
        /// </summary>
        public Javax.Management.MBeanOperationInfo[] Operations
        {
            get { return IExecuteArray<Javax.Management.MBeanOperationInfo>("getOperations"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}