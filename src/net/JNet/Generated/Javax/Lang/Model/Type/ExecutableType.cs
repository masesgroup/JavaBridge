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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Lang.Model.Type
{
    #region IExecutableType
    public partial interface IExecutableType : Javax.Lang.Model.Type.ITypeMirror
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/ExecutableType.html#getParameterTypes()"/> 
        /// </summary>
        Java.Util.List ParameterTypes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/ExecutableType.html#getReceiverType()"/> 
        /// </summary>
        Javax.Lang.Model.Type.TypeMirror ReceiverType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/ExecutableType.html#getReturnType()"/> 
        /// </summary>
        Javax.Lang.Model.Type.TypeMirror ReturnType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/ExecutableType.html#getThrownTypes()"/> 
        /// </summary>
        Java.Util.List ThrownTypes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/ExecutableType.html#getTypeVariables()"/> 
        /// </summary>
        Java.Util.List TypeVariables { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ExecutableType
    public partial class ExecutableType : Javax.Lang.Model.Type.IExecutableType
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/ExecutableType.html#getParameterTypes()"/> 
        /// </summary>
        public Java.Util.List ParameterTypes
        {
            get { return IExecute<Java.Util.List>("getParameterTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/ExecutableType.html#getReceiverType()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.TypeMirror ReceiverType
        {
            get { return IExecute<Javax.Lang.Model.Type.TypeMirror>("getReceiverType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/ExecutableType.html#getReturnType()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.TypeMirror ReturnType
        {
            get { return IExecute<Javax.Lang.Model.Type.TypeMirror>("getReturnType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/ExecutableType.html#getThrownTypes()"/> 
        /// </summary>
        public Java.Util.List ThrownTypes
        {
            get { return IExecute<Java.Util.List>("getThrownTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/ExecutableType.html#getTypeVariables()"/> 
        /// </summary>
        public Java.Util.List TypeVariables
        {
            get { return IExecute<Java.Util.List>("getTypeVariables"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}