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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region MBeanOperationInfo
    public partial class MBeanOperationInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#%3Cinit%3E(java.lang.String,java.lang.reflect.Method)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Reflect.Method"/></param>
        public MBeanOperationInfo(Java.Lang.String arg0, Java.Lang.Reflect.Method arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.MBeanParameterInfo[],java.lang.String,int,javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Management.MBeanParameterInfo"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Javax.Management.Descriptor"/></param>
        public MBeanOperationInfo(Java.Lang.String arg0, Java.Lang.String arg1, Javax.Management.MBeanParameterInfo[] arg2, Java.Lang.String arg3, int arg4, Javax.Management.Descriptor arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.MBeanParameterInfo[],java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Management.MBeanParameterInfo"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public MBeanOperationInfo(Java.Lang.String arg0, Java.Lang.String arg1, Javax.Management.MBeanParameterInfo[] arg2, Java.Lang.String arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.MBeanOperationInfo"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Management.MBeanOperationInfo t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#ACTION"/>
        /// </summary>
        public static int ACTION { get { if (!_ACTIONReady) { _ACTIONContent = SGetField<int>(LocalBridgeClazz, "ACTION"); _ACTIONReady = true; } return _ACTIONContent; } }
        private static int _ACTIONContent = default;
        private static bool _ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#ACTION_INFO"/>
        /// </summary>
        public static int ACTION_INFO { get { if (!_ACTION_INFOReady) { _ACTION_INFOContent = SGetField<int>(LocalBridgeClazz, "ACTION_INFO"); _ACTION_INFOReady = true; } return _ACTION_INFOContent; } }
        private static int _ACTION_INFOContent = default;
        private static bool _ACTION_INFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#INFO"/>
        /// </summary>
        public static int INFO { get { if (!_INFOReady) { _INFOContent = SGetField<int>(LocalBridgeClazz, "INFO"); _INFOReady = true; } return _INFOContent; } }
        private static int _INFOContent = default;
        private static bool _INFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#UNKNOWN"/>
        /// </summary>
        public static int UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static int _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#getImpact()"/> 
        /// </summary>
        public int Impact
        {
            get { return IExecuteWithSignature<int>("getImpact", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#getReturnType()"/> 
        /// </summary>
        public Java.Lang.String ReturnType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getReturnType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanOperationInfo.html#getSignature()"/> 
        /// </summary>
        public Javax.Management.MBeanParameterInfo[] Signature
        {
            get { return IExecuteWithSignatureArray<Javax.Management.MBeanParameterInfo>("getSignature", "()[Ljavax/management/MBeanParameterInfo;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}