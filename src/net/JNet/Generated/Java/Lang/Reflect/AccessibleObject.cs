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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Reflect
{
    #region AccessibleObject
    public partial class AccessibleObject
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#setAccessible(java.lang.reflect.AccessibleObject[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Reflect.AccessibleObject"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public static void SetAccessible(Java.Lang.Reflect.AccessibleObject[] arg0, bool arg1)
        {
            SExecute(LocalBridgeClazz, "setAccessible", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#getAnnotations()"/> 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] Annotations
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Annotation.Annotation>("getAnnotations", "()[Ljava/lang/annotation/Annotation;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#getDeclaredAnnotations()"/> 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] DeclaredAnnotations
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Annotation.Annotation>("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#getAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetAnnotation<T>(Java.Lang.Class arg0) where T: Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecute<T>("getAnnotation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#getDeclaredAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetDeclaredAnnotation<T>(Java.Lang.Class arg0) where T: Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecute<T>("getDeclaredAnnotation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#getAnnotationsByType(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetAnnotationsByType<T>(Java.Lang.Class arg0) where T: Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteArray<T>("getAnnotationsByType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#getDeclaredAnnotationsByType(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetDeclaredAnnotationsByType<T>(Java.Lang.Class arg0) where T: Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteArray<T>("getDeclaredAnnotationsByType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#isAnnotationPresent(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAnnotationPresent(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<bool>("isAnnotationPresent", "(Ljava/lang/Class;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#canAccess(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanAccess(object arg0)
        {
            return IExecuteWithSignature<bool>("canAccess", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#trySetAccessible()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool TrySetAccessible()
        {
            return IExecuteWithSignature<bool>("trySetAccessible", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AccessibleObject.html#setAccessible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAccessible(bool arg0)
        {
            IExecuteWithSignature("setAccessible", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}