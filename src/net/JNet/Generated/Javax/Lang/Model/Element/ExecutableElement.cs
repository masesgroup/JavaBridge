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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Lang.Model.Element
{
    #region IExecutableElement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IExecutableElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getDefaultValue()"/> 
        /// </summary>
        Javax.Lang.Model.Element.AnnotationValue DefaultValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getParameters()"/> 
        /// </summary>
        Java.Util.List Parameters { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getReceiverType()"/> 
        /// </summary>
        Javax.Lang.Model.Type.TypeMirror ReceiverType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getReturnType()"/> 
        /// </summary>
        Javax.Lang.Model.Type.TypeMirror ReturnType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getSimpleName()"/> 
        /// </summary>
        Javax.Lang.Model.Element.Name SimpleName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getThrownTypes()"/> 
        /// </summary>
        Java.Util.List ThrownTypes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getTypeParameters()"/> 
        /// </summary>
        Java.Util.List TypeParameters { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#isDefault()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsDefault();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#isVarArgs()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsVarArgs();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ExecutableElement
    public partial class ExecutableElement : Javax.Lang.Model.Element.IExecutableElement
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Element.ExecutableElement"/> to <see cref="Javax.Lang.Model.Element.Element"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Element.Element(Javax.Lang.Model.Element.ExecutableElement t) => t.Cast<Javax.Lang.Model.Element.Element>();
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Element.ExecutableElement"/> to <see cref="Javax.Lang.Model.Element.Parameterizable"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Element.Parameterizable(Javax.Lang.Model.Element.ExecutableElement t) => t.Cast<Javax.Lang.Model.Element.Parameterizable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getDefaultValue()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.AnnotationValue DefaultValue
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Element.AnnotationValue>("getDefaultValue", "()Ljavax/lang/model/element/AnnotationValue;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getParameters()"/> 
        /// </summary>
        public Java.Util.List Parameters
        {
            get { return IExecuteWithSignature<Java.Util.List>("getParameters", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getReceiverType()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.TypeMirror ReceiverType
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Type.TypeMirror>("getReceiverType", "()Ljavax/lang/model/type/TypeMirror;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getReturnType()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.TypeMirror ReturnType
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Type.TypeMirror>("getReturnType", "()Ljavax/lang/model/type/TypeMirror;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getSimpleName()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Name SimpleName
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Element.Name>("getSimpleName", "()Ljavax/lang/model/element/Name;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getThrownTypes()"/> 
        /// </summary>
        public Java.Util.List ThrownTypes
        {
            get { return IExecuteWithSignature<Java.Util.List>("getThrownTypes", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getTypeParameters()"/> 
        /// </summary>
        public Java.Util.List TypeParameters
        {
            get { return IExecuteWithSignature<Java.Util.List>("getTypeParameters", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#isDefault()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDefault()
        {
            return IExecuteWithSignature<bool>("isDefault", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#isVarArgs()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVarArgs()
        {
            return IExecuteWithSignature<bool>("isVarArgs", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}