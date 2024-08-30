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

namespace Javax.Management
{
    #region JMX definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html"/>
    /// </summary>
    public partial class JMX : MASES.JCOBridge.C2JBridge.JVMBridgeBase<JMX>
    {
        const string _bridgeClassName = "javax.management.JMX";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JMX() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JMX(params object[] args) : base(args) { }

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

    #region JMX
    public partial class JMX
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#DEFAULT_VALUE_FIELD"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_VALUE_FIELD { get { if (!_DEFAULT_VALUE_FIELDReady) { _DEFAULT_VALUE_FIELDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_VALUE_FIELD"); _DEFAULT_VALUE_FIELDReady = true; } return _DEFAULT_VALUE_FIELDContent; } }
        private static Java.Lang.String _DEFAULT_VALUE_FIELDContent = default;
        private static bool _DEFAULT_VALUE_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#IMMUTABLE_INFO_FIELD"/>
        /// </summary>
        public static Java.Lang.String IMMUTABLE_INFO_FIELD { get { if (!_IMMUTABLE_INFO_FIELDReady) { _IMMUTABLE_INFO_FIELDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "IMMUTABLE_INFO_FIELD"); _IMMUTABLE_INFO_FIELDReady = true; } return _IMMUTABLE_INFO_FIELDContent; } }
        private static Java.Lang.String _IMMUTABLE_INFO_FIELDContent = default;
        private static bool _IMMUTABLE_INFO_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#INTERFACE_CLASS_NAME_FIELD"/>
        /// </summary>
        public static Java.Lang.String INTERFACE_CLASS_NAME_FIELD { get { if (!_INTERFACE_CLASS_NAME_FIELDReady) { _INTERFACE_CLASS_NAME_FIELDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INTERFACE_CLASS_NAME_FIELD"); _INTERFACE_CLASS_NAME_FIELDReady = true; } return _INTERFACE_CLASS_NAME_FIELDContent; } }
        private static Java.Lang.String _INTERFACE_CLASS_NAME_FIELDContent = default;
        private static bool _INTERFACE_CLASS_NAME_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#LEGAL_VALUES_FIELD"/>
        /// </summary>
        public static Java.Lang.String LEGAL_VALUES_FIELD { get { if (!_LEGAL_VALUES_FIELDReady) { _LEGAL_VALUES_FIELDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LEGAL_VALUES_FIELD"); _LEGAL_VALUES_FIELDReady = true; } return _LEGAL_VALUES_FIELDContent; } }
        private static Java.Lang.String _LEGAL_VALUES_FIELDContent = default;
        private static bool _LEGAL_VALUES_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#MAX_VALUE_FIELD"/>
        /// </summary>
        public static Java.Lang.String MAX_VALUE_FIELD { get { if (!_MAX_VALUE_FIELDReady) { _MAX_VALUE_FIELDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MAX_VALUE_FIELD"); _MAX_VALUE_FIELDReady = true; } return _MAX_VALUE_FIELDContent; } }
        private static Java.Lang.String _MAX_VALUE_FIELDContent = default;
        private static bool _MAX_VALUE_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#MIN_VALUE_FIELD"/>
        /// </summary>
        public static Java.Lang.String MIN_VALUE_FIELD { get { if (!_MIN_VALUE_FIELDReady) { _MIN_VALUE_FIELDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MIN_VALUE_FIELD"); _MIN_VALUE_FIELDReady = true; } return _MIN_VALUE_FIELDContent; } }
        private static Java.Lang.String _MIN_VALUE_FIELDContent = default;
        private static bool _MIN_VALUE_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#MXBEAN_FIELD"/>
        /// </summary>
        public static Java.Lang.String MXBEAN_FIELD { get { if (!_MXBEAN_FIELDReady) { _MXBEAN_FIELDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MXBEAN_FIELD"); _MXBEAN_FIELDReady = true; } return _MXBEAN_FIELDContent; } }
        private static Java.Lang.String _MXBEAN_FIELDContent = default;
        private static bool _MXBEAN_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#OPEN_TYPE_FIELD"/>
        /// </summary>
        public static Java.Lang.String OPEN_TYPE_FIELD { get { if (!_OPEN_TYPE_FIELDReady) { _OPEN_TYPE_FIELDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OPEN_TYPE_FIELD"); _OPEN_TYPE_FIELDReady = true; } return _OPEN_TYPE_FIELDContent; } }
        private static Java.Lang.String _OPEN_TYPE_FIELDContent = default;
        private static bool _OPEN_TYPE_FIELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#ORIGINAL_TYPE_FIELD"/>
        /// </summary>
        public static Java.Lang.String ORIGINAL_TYPE_FIELD { get { if (!_ORIGINAL_TYPE_FIELDReady) { _ORIGINAL_TYPE_FIELDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ORIGINAL_TYPE_FIELD"); _ORIGINAL_TYPE_FIELDReady = true; } return _ORIGINAL_TYPE_FIELDContent; } }
        private static Java.Lang.String _ORIGINAL_TYPE_FIELDContent = default;
        private static bool _ORIGINAL_TYPE_FIELDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#newMBeanProxy(javax.management.MBeanServerConnection,javax.management.ObjectName,java.lang.Class,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServerConnection"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T NewMBeanProxy<T>(Javax.Management.MBeanServerConnection arg0, Javax.Management.ObjectName arg1, Java.Lang.Class arg2, bool arg3)
        {
            return SExecute<T>(LocalBridgeClazz, "newMBeanProxy", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#newMBeanProxy(javax.management.MBeanServerConnection,javax.management.ObjectName,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServerConnection"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T NewMBeanProxy<T>(Javax.Management.MBeanServerConnection arg0, Javax.Management.ObjectName arg1, Java.Lang.Class arg2)
        {
            return SExecute<T>(LocalBridgeClazz, "newMBeanProxy", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#newMXBeanProxy(javax.management.MBeanServerConnection,javax.management.ObjectName,java.lang.Class,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServerConnection"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T NewMXBeanProxy<T>(Javax.Management.MBeanServerConnection arg0, Javax.Management.ObjectName arg1, Java.Lang.Class arg2, bool arg3)
        {
            return SExecute<T>(LocalBridgeClazz, "newMXBeanProxy", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#newMXBeanProxy(javax.management.MBeanServerConnection,javax.management.ObjectName,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServerConnection"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T NewMXBeanProxy<T>(Javax.Management.MBeanServerConnection arg0, Javax.Management.ObjectName arg1, Java.Lang.Class arg2)
        {
            return SExecute<T>(LocalBridgeClazz, "newMXBeanProxy", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#isMXBeanInterface(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsMXBeanInterface(Java.Lang.Class arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isMXBeanInterface", "(Ljava/lang/Class;)Z", arg0);
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