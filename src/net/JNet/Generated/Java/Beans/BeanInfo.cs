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

namespace Java.Beans
{
    #region IBeanInfo
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBeanInfo
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getAdditionalBeanInfo()"/> 
        /// </summary>
        Java.Beans.BeanInfo[] AdditionalBeanInfo { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getBeanDescriptor()"/> 
        /// </summary>
        Java.Beans.BeanDescriptor BeanDescriptor { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getDefaultEventIndex()"/> 
        /// </summary>
        int DefaultEventIndex { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getDefaultPropertyIndex()"/> 
        /// </summary>
        int DefaultPropertyIndex { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getEventSetDescriptors()"/> 
        /// </summary>
        Java.Beans.EventSetDescriptor[] EventSetDescriptors { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getMethodDescriptors()"/> 
        /// </summary>
        Java.Beans.MethodDescriptor[] MethodDescriptors { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getPropertyDescriptors()"/> 
        /// </summary>
        Java.Beans.PropertyDescriptor[] PropertyDescriptors { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getIcon(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        Java.Awt.Image GetIcon(int arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BeanInfo
    public partial class BeanInfo : Java.Beans.IBeanInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#ICON_COLOR_16x16"/>
        /// </summary>
        public static int ICON_COLOR_16x16 { get { if (!_ICON_COLOR_16x16Ready) { _ICON_COLOR_16x16Content = SGetField<int>(LocalBridgeClazz, "ICON_COLOR_16x16"); _ICON_COLOR_16x16Ready = true; } return _ICON_COLOR_16x16Content; } }
        private static int _ICON_COLOR_16x16Content = default;
        private static bool _ICON_COLOR_16x16Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#ICON_COLOR_32x32"/>
        /// </summary>
        public static int ICON_COLOR_32x32 { get { if (!_ICON_COLOR_32x32Ready) { _ICON_COLOR_32x32Content = SGetField<int>(LocalBridgeClazz, "ICON_COLOR_32x32"); _ICON_COLOR_32x32Ready = true; } return _ICON_COLOR_32x32Content; } }
        private static int _ICON_COLOR_32x32Content = default;
        private static bool _ICON_COLOR_32x32Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#ICON_MONO_16x16"/>
        /// </summary>
        public static int ICON_MONO_16x16 { get { if (!_ICON_MONO_16x16Ready) { _ICON_MONO_16x16Content = SGetField<int>(LocalBridgeClazz, "ICON_MONO_16x16"); _ICON_MONO_16x16Ready = true; } return _ICON_MONO_16x16Content; } }
        private static int _ICON_MONO_16x16Content = default;
        private static bool _ICON_MONO_16x16Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#ICON_MONO_32x32"/>
        /// </summary>
        public static int ICON_MONO_32x32 { get { if (!_ICON_MONO_32x32Ready) { _ICON_MONO_32x32Content = SGetField<int>(LocalBridgeClazz, "ICON_MONO_32x32"); _ICON_MONO_32x32Ready = true; } return _ICON_MONO_32x32Content; } }
        private static int _ICON_MONO_32x32Content = default;
        private static bool _ICON_MONO_32x32Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getAdditionalBeanInfo()"/> 
        /// </summary>
        public Java.Beans.BeanInfo[] AdditionalBeanInfo
        {
            get { return IExecuteWithSignatureArray<Java.Beans.BeanInfo>("getAdditionalBeanInfo", "()[Ljava/beans/BeanInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getBeanDescriptor()"/> 
        /// </summary>
        public Java.Beans.BeanDescriptor BeanDescriptor
        {
            get { return IExecuteWithSignature<Java.Beans.BeanDescriptor>("getBeanDescriptor", "()Ljava/beans/BeanDescriptor;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getDefaultEventIndex()"/> 
        /// </summary>
        public int DefaultEventIndex
        {
            get { return IExecuteWithSignature<int>("getDefaultEventIndex", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getDefaultPropertyIndex()"/> 
        /// </summary>
        public int DefaultPropertyIndex
        {
            get { return IExecuteWithSignature<int>("getDefaultPropertyIndex", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getEventSetDescriptors()"/> 
        /// </summary>
        public Java.Beans.EventSetDescriptor[] EventSetDescriptors
        {
            get { return IExecuteWithSignatureArray<Java.Beans.EventSetDescriptor>("getEventSetDescriptors", "()[Ljava/beans/EventSetDescriptor;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getMethodDescriptors()"/> 
        /// </summary>
        public Java.Beans.MethodDescriptor[] MethodDescriptors
        {
            get { return IExecuteWithSignatureArray<Java.Beans.MethodDescriptor>("getMethodDescriptors", "()[Ljava/beans/MethodDescriptor;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getPropertyDescriptors()"/> 
        /// </summary>
        public Java.Beans.PropertyDescriptor[] PropertyDescriptors
        {
            get { return IExecuteWithSignatureArray<Java.Beans.PropertyDescriptor>("getPropertyDescriptors", "()[Ljava/beans/PropertyDescriptor;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getIcon(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image GetIcon(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.Image>("getIcon", "(I)Ljava/awt/Image;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}