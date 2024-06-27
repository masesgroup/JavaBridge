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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Openmbean
{
    #region IOpenMBeanInfo
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IOpenMBeanInfo
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanInfo.html#getAttributes()"/> 
        /// </summary>
        Javax.Management.MBeanAttributeInfo[] Attributes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanInfo.html#getClassName()"/> 
        /// </summary>
        Java.Lang.String ClassName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanInfo.html#getConstructors()"/> 
        /// </summary>
        Javax.Management.MBeanConstructorInfo[] Constructors { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanInfo.html#getDescription()"/> 
        /// </summary>
        Java.Lang.String Description { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanInfo.html#getNotifications()"/> 
        /// </summary>
        Javax.Management.MBeanNotificationInfo[] Notifications { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanInfo.html#getOperations()"/> 
        /// </summary>
        Javax.Management.MBeanOperationInfo[] Operations { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OpenMBeanInfo
    public partial class OpenMBeanInfo : Javax.Management.Openmbean.IOpenMBeanInfo
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanInfo.html#getAttributes()"/> 
        /// </summary>
        public Javax.Management.MBeanAttributeInfo[] Attributes
        {
            get { return IExecuteWithSignatureArray<Javax.Management.MBeanAttributeInfo>("getAttributes", "()[Ljavax/management/MBeanAttributeInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanInfo.html#getClassName()"/> 
        /// </summary>
        public Java.Lang.String ClassName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getClassName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanInfo.html#getConstructors()"/> 
        /// </summary>
        public Javax.Management.MBeanConstructorInfo[] Constructors
        {
            get { return IExecuteWithSignatureArray<Javax.Management.MBeanConstructorInfo>("getConstructors", "()[Ljavax/management/MBeanConstructorInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanInfo.html#getDescription()"/> 
        /// </summary>
        public Java.Lang.String Description
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanInfo.html#getNotifications()"/> 
        /// </summary>
        public Javax.Management.MBeanNotificationInfo[] Notifications
        {
            get { return IExecuteWithSignatureArray<Javax.Management.MBeanNotificationInfo>("getNotifications", "()[Ljavax/management/MBeanNotificationInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanInfo.html#getOperations()"/> 
        /// </summary>
        public Javax.Management.MBeanOperationInfo[] Operations
        {
            get { return IExecuteWithSignatureArray<Javax.Management.MBeanOperationInfo>("getOperations", "()[Ljavax/management/MBeanOperationInfo;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}