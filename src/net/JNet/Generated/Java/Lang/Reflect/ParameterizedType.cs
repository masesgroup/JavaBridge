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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Reflect
{
    #region IParameterizedType
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IParameterizedType : Java.Lang.Reflect.IType
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/ParameterizedType.html#getActualTypeArguments()"/> 
        /// </summary>
        Java.Lang.Reflect.Type[] ActualTypeArguments { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/ParameterizedType.html#getOwnerType()"/> 
        /// </summary>
        Java.Lang.Reflect.Type OwnerType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/ParameterizedType.html#getRawType()"/> 
        /// </summary>
        Java.Lang.Reflect.Type RawType { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ParameterizedType
    public partial class ParameterizedType : Java.Lang.Reflect.IParameterizedType
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/ParameterizedType.html#getActualTypeArguments()"/> 
        /// </summary>
        public Java.Lang.Reflect.Type[] ActualTypeArguments
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Reflect.Type>("getActualTypeArguments", "()[Ljava/lang/reflect/Type;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/ParameterizedType.html#getOwnerType()"/> 
        /// </summary>
        public Java.Lang.Reflect.Type OwnerType
        {
            get { return IExecuteWithSignature<Java.Lang.Reflect.Type>("getOwnerType", "()Ljava/lang/reflect/Type;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/ParameterizedType.html#getRawType()"/> 
        /// </summary>
        public Java.Lang.Reflect.Type RawType
        {
            get { return IExecuteWithSignature<Java.Lang.Reflect.Type>("getRawType", "()Ljava/lang/reflect/Type;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}