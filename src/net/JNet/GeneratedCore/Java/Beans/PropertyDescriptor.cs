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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans
{
    #region PropertyDescriptor definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html"/>
    /// </summary>
    public partial class PropertyDescriptor : Java.Beans.FeatureDescriptor
    {
        const string _bridgeClassName = "java.beans.PropertyDescriptor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PropertyDescriptor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PropertyDescriptor(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region PropertyDescriptor
    public partial class PropertyDescriptor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.Class,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public PropertyDescriptor(Java.Lang.String arg0, Java.Lang.Class arg1, Java.Lang.String arg2, Java.Lang.String arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public PropertyDescriptor(Java.Lang.String arg0, Java.Lang.Class arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.reflect.Method,java.lang.reflect.Method)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public PropertyDescriptor(Java.Lang.String arg0, Java.Lang.Reflect.Method arg1, Java.Lang.Reflect.Method arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#getPropertyEditorClass()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#setPropertyEditorClass(java.lang.Class)"/>
        /// </summary>
        public Java.Lang.Class PropertyEditorClass
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getPropertyEditorClass", "()Ljava/lang/Class;"); } set { IExecuteWithSignature("setPropertyEditorClass", "(Ljava/lang/Class;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#getPropertyType()"/> 
        /// </summary>
        public Java.Lang.Class PropertyType
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getPropertyType", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#getReadMethod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#setReadMethod(java.lang.reflect.Method)"/>
        /// </summary>
        public Java.Lang.Reflect.Method ReadMethod
        {
            get { return IExecuteWithSignature<Java.Lang.Reflect.Method>("getReadMethod", "()Ljava/lang/reflect/Method;"); } set { IExecuteWithSignature("setReadMethod", "(Ljava/lang/reflect/Method;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#getWriteMethod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#setWriteMethod(java.lang.reflect.Method)"/>
        /// </summary>
        public Java.Lang.Reflect.Method WriteMethod
        {
            get { return IExecuteWithSignature<Java.Lang.Reflect.Method>("getWriteMethod", "()Ljava/lang/reflect/Method;"); } set { IExecuteWithSignature("setWriteMethod", "(Ljava/lang/reflect/Method;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#isBound()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBound()
        {
            return IExecuteWithSignature<bool>("isBound", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#isConstrained()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConstrained()
        {
            return IExecuteWithSignature<bool>("isConstrained", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#createPropertyEditor(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Beans.PropertyEditor"/></returns>
        public Java.Beans.PropertyEditor CreatePropertyEditor(object arg0)
        {
            return IExecuteWithSignature<Java.Beans.PropertyEditor>("createPropertyEditor", "(Ljava/lang/Object;)Ljava/beans/PropertyEditor;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#setBound(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetBound(bool arg0)
        {
            IExecuteWithSignature("setBound", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyDescriptor.html#setConstrained(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetConstrained(bool arg0)
        {
            IExecuteWithSignature("setConstrained", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}