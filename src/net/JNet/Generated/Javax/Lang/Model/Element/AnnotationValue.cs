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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Lang.Model.Element
{
    #region IAnnotationValue
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAnnotationValue
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValue.html#getValue()"/> 
        /// </summary>
        object Value { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValue.html#accept(javax.lang.model.element.AnnotationValueVisitor,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValueVisitor"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        R Accept<R, P>(Javax.Lang.Model.Element.AnnotationValueVisitor<R, P> arg0, P arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AnnotationValue
    public partial class AnnotationValue : Javax.Lang.Model.Element.IAnnotationValue
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValue.html#getValue()"/> 
        /// </summary>
        public object Value
        {
            get { return IExecuteWithSignature("getValue", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/AnnotationValue.html#accept(javax.lang.model.element.AnnotationValueVisitor,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValueVisitor"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Accept<R, P>(Javax.Lang.Model.Element.AnnotationValueVisitor<R, P> arg0, P arg1)
        {
            return IExecute<R>("accept", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}