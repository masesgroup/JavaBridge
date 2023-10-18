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

namespace Java.Lang.Reflect
{
    #region Parameter
    public partial class Parameter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#getAnnotatedType()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType AnnotatedType
        {
            get { return IExecute<Java.Lang.Reflect.AnnotatedType>("getAnnotatedType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#getAnnotations()"/> 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] Annotations
        {
            get { return IExecuteArray<Java.Lang.Annotation.Annotation>("getAnnotations"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#getDeclaredAnnotations()"/> 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] DeclaredAnnotations
        {
            get { return IExecuteArray<Java.Lang.Annotation.Annotation>("getDeclaredAnnotations"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#getDeclaringExecutable()"/> 
        /// </summary>
        public Java.Lang.Reflect.Executable DeclaringExecutable
        {
            get { return IExecute<Java.Lang.Reflect.Executable>("getDeclaringExecutable"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#getModifiers()"/> 
        /// </summary>
        public int Modifiers
        {
            get { return IExecute<int>("getModifiers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#getParameterizedType()"/> 
        /// </summary>
        public Java.Lang.Reflect.Type ParameterizedType
        {
            get { return IExecute<Java.Lang.Reflect.Type>("getParameterizedType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#getType()"/> 
        /// </summary>
        public Java.Lang.Class Type
        {
            get { return IExecute<Java.Lang.Class>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#getAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetAnnotation<T>(Java.Lang.Class arg0) where T: Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecute<T>("getAnnotation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#getDeclaredAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetDeclaredAnnotation<T>(Java.Lang.Class arg0) where T: Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecute<T>("getDeclaredAnnotation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#getAnnotationsByType(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetAnnotationsByType<T>(Java.Lang.Class arg0) where T: Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteArray<T>("getAnnotationsByType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#getDeclaredAnnotationsByType(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetDeclaredAnnotationsByType<T>(Java.Lang.Class arg0) where T: Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteArray<T>("getDeclaredAnnotationsByType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#isImplicit()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsImplicit()
        {
            return IExecute<bool>("isImplicit");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#isNamePresent()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsNamePresent()
        {
            return IExecute<bool>("isNamePresent");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#isSynthetic()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSynthetic()
        {
            return IExecute<bool>("isSynthetic");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Parameter.html#isVarArgs()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsVarArgs()
        {
            return IExecute<bool>("isVarArgs");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}