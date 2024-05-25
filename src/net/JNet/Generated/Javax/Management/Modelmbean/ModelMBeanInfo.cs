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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Modelmbean
{
    #region IModelMBeanInfo
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IModelMBeanInfo
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getAttributes()"/> 
        /// </summary>
        Javax.Management.MBeanAttributeInfo[] Attributes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getClassName()"/> 
        /// </summary>
        Java.Lang.String ClassName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getConstructors()"/> 
        /// </summary>
        Javax.Management.MBeanConstructorInfo[] Constructors { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getDescription()"/> 
        /// </summary>
        Java.Lang.String Description { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getMBeanDescriptor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#setMBeanDescriptor(javax.management.Descriptor)"/>
        /// </summary>
        Javax.Management.Descriptor MBeanDescriptor { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getNotifications()"/> 
        /// </summary>
        Javax.Management.MBeanNotificationInfo[] Notifications { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getOperations()"/> 
        /// </summary>
        Javax.Management.MBeanOperationInfo[] Operations { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getDescriptor(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Descriptor"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        Javax.Management.Descriptor GetDescriptor(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getDescriptors(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Descriptor"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        Javax.Management.Descriptor[] GetDescriptors(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Modelmbean.ModelMBeanAttributeInfo"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        Javax.Management.Modelmbean.ModelMBeanAttributeInfo GetAttribute(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getNotification(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Modelmbean.ModelMBeanNotificationInfo"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        Javax.Management.Modelmbean.ModelMBeanNotificationInfo GetNotification(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getOperation(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Modelmbean.ModelMBeanOperationInfo"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        Javax.Management.Modelmbean.ModelMBeanOperationInfo GetOperation(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#setDescriptor(javax.management.Descriptor,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Descriptor"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        void SetDescriptor(Javax.Management.Descriptor arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#setDescriptors(javax.management.Descriptor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Descriptor"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        void SetDescriptors(Javax.Management.Descriptor[] arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ModelMBeanInfo
    public partial class ModelMBeanInfo : Javax.Management.Modelmbean.IModelMBeanInfo
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getAttributes()"/> 
        /// </summary>
        public Javax.Management.MBeanAttributeInfo[] Attributes
        {
            get { return IExecuteWithSignatureArray<Javax.Management.MBeanAttributeInfo>("getAttributes", "()[Ljavax/management/MBeanAttributeInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getClassName()"/> 
        /// </summary>
        public Java.Lang.String ClassName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getClassName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getConstructors()"/> 
        /// </summary>
        public Javax.Management.MBeanConstructorInfo[] Constructors
        {
            get { return IExecuteWithSignatureArray<Javax.Management.MBeanConstructorInfo>("getConstructors", "()[Ljavax/management/MBeanConstructorInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getDescription()"/> 
        /// </summary>
        public Java.Lang.String Description
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getMBeanDescriptor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#setMBeanDescriptor(javax.management.Descriptor)"/>
        /// </summary>
        public Javax.Management.Descriptor MBeanDescriptor
        {
            get { return IExecuteWithSignature<Javax.Management.Descriptor>("getMBeanDescriptor", "()Ljavax/management/Descriptor;"); } set { IExecuteWithSignature("setMBeanDescriptor", "(Ljavax/management/Descriptor;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getNotifications()"/> 
        /// </summary>
        public Javax.Management.MBeanNotificationInfo[] Notifications
        {
            get { return IExecuteWithSignatureArray<Javax.Management.MBeanNotificationInfo>("getNotifications", "()[Ljavax/management/MBeanNotificationInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getOperations()"/> 
        /// </summary>
        public Javax.Management.MBeanOperationInfo[] Operations
        {
            get { return IExecuteWithSignatureArray<Javax.Management.MBeanOperationInfo>("getOperations", "()[Ljavax/management/MBeanOperationInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getDescriptor(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Descriptor"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public Javax.Management.Descriptor GetDescriptor(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Management.Descriptor>("getDescriptor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getDescriptors(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Descriptor"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public Javax.Management.Descriptor[] GetDescriptors(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Javax.Management.Descriptor>("getDescriptors", "(Ljava/lang/String;)[Ljavax/management/Descriptor;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Modelmbean.ModelMBeanAttributeInfo"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public Javax.Management.Modelmbean.ModelMBeanAttributeInfo GetAttribute(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Management.Modelmbean.ModelMBeanAttributeInfo>("getAttribute", "(Ljava/lang/String;)Ljavax/management/modelmbean/ModelMBeanAttributeInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getNotification(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Modelmbean.ModelMBeanNotificationInfo"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public Javax.Management.Modelmbean.ModelMBeanNotificationInfo GetNotification(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Management.Modelmbean.ModelMBeanNotificationInfo>("getNotification", "(Ljava/lang/String;)Ljavax/management/modelmbean/ModelMBeanNotificationInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#getOperation(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Modelmbean.ModelMBeanOperationInfo"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public Javax.Management.Modelmbean.ModelMBeanOperationInfo GetOperation(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Management.Modelmbean.ModelMBeanOperationInfo>("getOperation", "(Ljava/lang/String;)Ljavax/management/modelmbean/ModelMBeanOperationInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#setDescriptor(javax.management.Descriptor,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Descriptor"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SetDescriptor(Javax.Management.Descriptor arg0, Java.Lang.String arg1)
        {
            IExecute("setDescriptor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfo.html#setDescriptors(javax.management.Descriptor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Descriptor"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SetDescriptors(Javax.Management.Descriptor[] arg0)
        {
            IExecuteWithSignature("setDescriptors", "([Ljavax/management/Descriptor;)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}