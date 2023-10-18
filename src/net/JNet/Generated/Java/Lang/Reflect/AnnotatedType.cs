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
    #region IAnnotatedType
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAnnotatedType : Java.Lang.Reflect.IAnnotatedElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AnnotatedType.html#getAnnotatedOwnerType()"/> 
        /// </summary>
        Java.Lang.Reflect.AnnotatedType AnnotatedOwnerType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AnnotatedType.html#getType()"/> 
        /// </summary>
        Java.Lang.Reflect.Type Type { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AnnotatedType
    public partial class AnnotatedType : Java.Lang.Reflect.IAnnotatedType
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AnnotatedType.html#getAnnotatedOwnerType()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType AnnotatedOwnerType
        {
            get { return IExecute<Java.Lang.Reflect.AnnotatedType>("getAnnotatedOwnerType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AnnotatedType.html#getType()"/> 
        /// </summary>
        public Java.Lang.Reflect.Type Type
        {
            get { return IExecute<Java.Lang.Reflect.Type>("getType"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}