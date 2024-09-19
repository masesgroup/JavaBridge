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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans
{
    #region EventSetDescriptor declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html"/>
    /// </summary>
    public partial class EventSetDescriptor : Java.Beans.FeatureDescriptor
    {
        const string _bridgeClassName = "java.beans.EventSetDescriptor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EventSetDescriptor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public EventSetDescriptor(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region EventSetDescriptor implementation
    public partial class EventSetDescriptor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#%3Cinit%3E(java.lang.Class,java.lang.String,java.lang.Class,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public EventSetDescriptor(Java.Lang.Class arg0, Java.Lang.String arg1, Java.Lang.Class arg2, Java.Lang.String arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#%3Cinit%3E(java.lang.Class,java.lang.String,java.lang.Class,java.lang.String[],java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        /// <param name="arg6"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public EventSetDescriptor(Java.Lang.Class arg0, Java.Lang.String arg1, Java.Lang.Class arg2, Java.Lang.String[] arg3, Java.Lang.String arg4, Java.Lang.String arg5, Java.Lang.String arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#%3Cinit%3E(java.lang.Class,java.lang.String,java.lang.Class,java.lang.String[],java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public EventSetDescriptor(Java.Lang.Class arg0, Java.Lang.String arg1, Java.Lang.Class arg2, Java.Lang.String[] arg3, Java.Lang.String arg4, Java.Lang.String arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.Class,java.beans.MethodDescriptor[],java.lang.reflect.Method,java.lang.reflect.Method)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Beans.MethodDescriptor"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public EventSetDescriptor(Java.Lang.String arg0, Java.Lang.Class arg1, Java.Beans.MethodDescriptor[] arg2, Java.Lang.Reflect.Method arg3, Java.Lang.Reflect.Method arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.Class,java.lang.reflect.Method[],java.lang.reflect.Method,java.lang.reflect.Method,java.lang.reflect.Method)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg5"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public EventSetDescriptor(Java.Lang.String arg0, Java.Lang.Class arg1, Java.Lang.Reflect.Method[] arg2, Java.Lang.Reflect.Method arg3, Java.Lang.Reflect.Method arg4, Java.Lang.Reflect.Method arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.Class,java.lang.reflect.Method[],java.lang.reflect.Method,java.lang.reflect.Method)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public EventSetDescriptor(Java.Lang.String arg0, Java.Lang.Class arg1, Java.Lang.Reflect.Method[] arg2, Java.Lang.Reflect.Method arg3, Java.Lang.Reflect.Method arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#getAddListenerMethod()"/> 
        /// </summary>
        public Java.Lang.Reflect.Method AddListenerMethod
        {
            get { return IExecuteWithSignature<Java.Lang.Reflect.Method>("getAddListenerMethod", "()Ljava/lang/reflect/Method;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#getGetListenerMethod()"/> 
        /// </summary>
        public Java.Lang.Reflect.Method GetListenerMethod
        {
            get { return IExecuteWithSignature<Java.Lang.Reflect.Method>("getGetListenerMethod", "()Ljava/lang/reflect/Method;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#getListenerMethodDescriptors()"/> 
        /// </summary>
        public Java.Beans.MethodDescriptor[] ListenerMethodDescriptors
        {
            get { return IExecuteWithSignatureArray<Java.Beans.MethodDescriptor>("getListenerMethodDescriptors", "()[Ljava/beans/MethodDescriptor;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#getListenerMethods()"/> 
        /// </summary>
        public Java.Lang.Reflect.Method[] ListenerMethods
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Reflect.Method>("getListenerMethods", "()[Ljava/lang/reflect/Method;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#getListenerType()"/> 
        /// </summary>
        public Java.Lang.Class ListenerType
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getListenerType", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#getRemoveListenerMethod()"/> 
        /// </summary>
        public Java.Lang.Reflect.Method RemoveListenerMethod
        {
            get { return IExecuteWithSignature<Java.Lang.Reflect.Method>("getRemoveListenerMethod", "()Ljava/lang/reflect/Method;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#isInDefaultEventSet()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInDefaultEventSet()
        {
            return IExecuteWithSignature<bool>("isInDefaultEventSet", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#isUnicast()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnicast()
        {
            return IExecuteWithSignature<bool>("isUnicast", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#setInDefaultEventSet(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetInDefaultEventSet(bool arg0)
        {
            IExecuteWithSignature("setInDefaultEventSet", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventSetDescriptor.html#setUnicast(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetUnicast(bool arg0)
        {
            IExecuteWithSignature("setUnicast", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}