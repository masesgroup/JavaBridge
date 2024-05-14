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
    #region IAnnotatedParameterizedType
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAnnotatedParameterizedType : Java.Lang.Reflect.IAnnotatedType
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AnnotatedParameterizedType.html#getAnnotatedActualTypeArguments()"/> 
        /// </summary>
        Java.Lang.Reflect.AnnotatedType[] AnnotatedActualTypeArguments { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AnnotatedParameterizedType.html#getAnnotatedOwnerType()"/> 
        /// </summary>
        Java.Lang.Reflect.AnnotatedType AnnotatedOwnerType { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AnnotatedParameterizedType
    public partial class AnnotatedParameterizedType : Java.Lang.Reflect.IAnnotatedParameterizedType
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AnnotatedParameterizedType.html#getAnnotatedActualTypeArguments()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType[] AnnotatedActualTypeArguments
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Reflect.AnnotatedType>("getAnnotatedActualTypeArguments", "()[Ljava/lang/reflect/AnnotatedType;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AnnotatedParameterizedType.html#getAnnotatedOwnerType()"/> 
        /// </summary>
        public Java.Lang.Reflect.AnnotatedType AnnotatedOwnerType
        {
            get { return IExecuteWithSignature<Java.Lang.Reflect.AnnotatedType>("getAnnotatedOwnerType", "()Ljava/lang/reflect/AnnotatedType;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}