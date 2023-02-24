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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Reflect
{
    #region TypeVariable
    public partial class TypeVariable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.TypeVariable"/> to <see cref="Java.Lang.Reflect.Type"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.Type(Java.Lang.Reflect.TypeVariable t) => t.Cast<Java.Lang.Reflect.Type>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.TypeVariable"/> to <see cref="Java.Lang.Reflect.AnnotatedElement"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.AnnotatedElement(Java.Lang.Reflect.TypeVariable t) => t.Cast<Java.Lang.Reflect.AnnotatedElement>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getAnnotatedBounds()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType[] AnnotatedBounds
        {
            get { return IExecuteArray<Java.Lang.Reflect.AnnotatedType>("getAnnotatedBounds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getBounds()"/> 
        /// </summary>
        public Java.Lang.Reflect.Type[] Bounds
        {
            get { return IExecuteArray<Java.Lang.Reflect.Type>("getBounds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getGenericDeclaration()"/> 
        /// </summary>
        public Java.Lang.Reflect.GenericDeclaration GenericDeclaration
        {
            get { return IExecute<Java.Lang.Reflect.GenericDeclaration>("getGenericDeclaration"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/TypeVariable.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}