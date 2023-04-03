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

namespace Java.Lang.Reflect
{
    #region Executable
    public partial class Executable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.Executable"/> to <see cref="Java.Lang.Reflect.Member"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.Member(Java.Lang.Reflect.Executable t) => t.Cast<Java.Lang.Reflect.Member>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.Executable"/> to <see cref="Java.Lang.Reflect.GenericDeclaration"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.GenericDeclaration(Java.Lang.Reflect.Executable t) => t.Cast<Java.Lang.Reflect.GenericDeclaration>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getAnnotatedExceptionTypes()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType[] AnnotatedExceptionTypes
        {
            get { return IExecuteArray<Java.Lang.Reflect.AnnotatedType>("getAnnotatedExceptionTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getAnnotatedParameterTypes()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType[] AnnotatedParameterTypes
        {
            get { return IExecuteArray<Java.Lang.Reflect.AnnotatedType>("getAnnotatedParameterTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getAnnotatedReceiverType()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType AnnotatedReceiverType
        {
            get { return IExecute<Java.Lang.Reflect.AnnotatedType>("getAnnotatedReceiverType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getAnnotatedReturnType()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType AnnotatedReturnType
        {
            get { return IExecute<Java.Lang.Reflect.AnnotatedType>("getAnnotatedReturnType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getDeclaringClass()"/> 
        /// </summary>
        public Java.Lang.Class DeclaringClass
        {
            get { return IExecute<Java.Lang.Class>("getDeclaringClass"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getExceptionTypes()"/> 
        /// </summary>
        public Java.Lang.Class[] ExceptionTypes
        {
            get { return IExecuteArray<Java.Lang.Class>("getExceptionTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getGenericExceptionTypes()"/> 
        /// </summary>
        public Java.Lang.Reflect.Type[] GenericExceptionTypes
        {
            get { return IExecuteArray<Java.Lang.Reflect.Type>("getGenericExceptionTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getGenericParameterTypes()"/> 
        /// </summary>
        public Java.Lang.Reflect.Type[] GenericParameterTypes
        {
            get { return IExecuteArray<Java.Lang.Reflect.Type>("getGenericParameterTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#isSynthetic()"/> 
        /// </summary>
        public bool IsSynthetic
        {
            get { return IExecute<bool>("isSynthetic"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#isVarArgs()"/> 
        /// </summary>
        public bool IsVarArgs
        {
            get { return IExecute<bool>("isVarArgs"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getModifiers()"/> 
        /// </summary>
        public int Modifiers
        {
            get { return IExecute<int>("getModifiers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getParameterAnnotations()"/> 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] ParameterAnnotations
        {
            get { return IExecuteArray<Java.Lang.Annotation.Annotation>("getParameterAnnotations"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getParameterCount()"/> 
        /// </summary>
        public int ParameterCount
        {
            get { return IExecute<int>("getParameterCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getParameters()"/> 
        /// </summary>
        public Java.Lang.Reflect.Parameter[] Parameters
        {
            get { return IExecuteArray<Java.Lang.Reflect.Parameter>("getParameters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getParameterTypes()"/> 
        /// </summary>
        public Java.Lang.Class[] ParameterTypes
        {
            get { return IExecuteArray<Java.Lang.Class>("getParameterTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#toGenericString()"/> 
        /// </summary>
        public string ToGenericString
        {
            get { return IExecute<string>("toGenericString"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Executable.html#getTypeParameters()"/> 
        /// </summary>
        public Java.Lang.Reflect.TypeVariable[] TypeParameters
        {
            get { return IExecuteArray<Java.Lang.Reflect.TypeVariable>("getTypeParameters"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}