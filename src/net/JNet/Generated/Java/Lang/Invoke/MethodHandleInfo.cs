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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Invoke
{
    #region MethodHandleInfo
    public partial class MethodHandleInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_getField"/>
        /// </summary>
        public static int REF_getField => Clazz.GetField<int>("REF_getField");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_getStatic"/>
        /// </summary>
        public static int REF_getStatic => Clazz.GetField<int>("REF_getStatic");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_invokeInterface"/>
        /// </summary>
        public static int REF_invokeInterface => Clazz.GetField<int>("REF_invokeInterface");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_invokeSpecial"/>
        /// </summary>
        public static int REF_invokeSpecial => Clazz.GetField<int>("REF_invokeSpecial");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_invokeStatic"/>
        /// </summary>
        public static int REF_invokeStatic => Clazz.GetField<int>("REF_invokeStatic");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_invokeVirtual"/>
        /// </summary>
        public static int REF_invokeVirtual => Clazz.GetField<int>("REF_invokeVirtual");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_newInvokeSpecial"/>
        /// </summary>
        public static int REF_newInvokeSpecial => Clazz.GetField<int>("REF_newInvokeSpecial");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_putField"/>
        /// </summary>
        public static int REF_putField => Clazz.GetField<int>("REF_putField");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_putStatic"/>
        /// </summary>
        public static int REF_putStatic => Clazz.GetField<int>("REF_putStatic");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#referenceKindToString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ReferenceKindToString(int arg0)
        {
            return SExecute<string>("referenceKindToString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#toString(int,java.lang.Class,java.lang.String,java.lang.invoke.MethodType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Invoke.MethodType"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToString(int arg0, Java.Lang.Class arg1, string arg2, Java.Lang.Invoke.MethodType arg3)
        {
            return SExecute<string>("toString", arg0, arg1, arg2, arg3);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getDeclaringClass()"/> 
        /// </summary>
        public Java.Lang.Class DeclaringClass
        {
            get { return IExecute<Java.Lang.Class>("getDeclaringClass"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#isVarArgs()"/> 
        /// </summary>
        public bool IsVarArgs
        {
            get { return IExecute<bool>("isVarArgs"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getMethodType()"/> 
        /// </summary>
        public Java.Lang.Invoke.MethodType MethodType
        {
            get { return IExecute<Java.Lang.Invoke.MethodType>("getMethodType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getModifiers()"/> 
        /// </summary>
        public int Modifiers
        {
            get { return IExecute<int>("getModifiers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getReferenceKind()"/> 
        /// </summary>
        public int ReferenceKind
        {
            get { return IExecute<int>("getReferenceKind"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#reflectAs(java.lang.Class,java.lang.invoke.MethodHandles.Lookup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <returns><see cref="Java.Lang.Reflect.Member"/></returns>
        public Java.Lang.Reflect.Member ReflectAs(Java.Lang.Class arg0, Java.Lang.Invoke.MethodHandles.Lookup arg1)
        {
            return IExecute<Java.Lang.Reflect.Member>("reflectAs", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}