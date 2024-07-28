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

namespace Javax.Lang.Model.Util
{
    #region AbstractAnnotationValueVisitor6
    public partial class AbstractAnnotationValueVisitor6
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractAnnotationValueVisitor6.html#visit(javax.lang.model.element.AnnotationValue,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Visit(Javax.Lang.Model.Element.AnnotationValue arg0, object arg1)
        {
            return IExecute("visit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractAnnotationValueVisitor6.html#visit(javax.lang.model.element.AnnotationValue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <returns><see cref="object"/></returns>
        public object Visit(Javax.Lang.Model.Element.AnnotationValue arg0)
        {
            return IExecuteWithSignature("visit", "(Ljavax/lang/model/element/AnnotationValue;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractAnnotationValueVisitor6.html#visitUnknown(javax.lang.model.element.AnnotationValue,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitUnknown(Javax.Lang.Model.Element.AnnotationValue arg0, object arg1)
        {
            return IExecute("visitUnknown", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AbstractAnnotationValueVisitor6<R, P>
    public partial class AbstractAnnotationValueVisitor6<R, P>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Util.AbstractAnnotationValueVisitor6{R, P}"/> to <see cref="Javax.Lang.Model.Util.AbstractAnnotationValueVisitor6"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Util.AbstractAnnotationValueVisitor6(Javax.Lang.Model.Util.AbstractAnnotationValueVisitor6<R, P> t) => t.Cast<Javax.Lang.Model.Util.AbstractAnnotationValueVisitor6>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractAnnotationValueVisitor6.html#visit(javax.lang.model.element.AnnotationValue,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Visit(Javax.Lang.Model.Element.AnnotationValue arg0, P arg1)
        {
            return IExecute<R>("visit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractAnnotationValueVisitor6.html#visit(javax.lang.model.element.AnnotationValue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Visit(Javax.Lang.Model.Element.AnnotationValue arg0)
        {
            return IExecuteWithSignature<R>("visit", "(Ljavax/lang/model/element/AnnotationValue;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractAnnotationValueVisitor6.html#visitUnknown(javax.lang.model.element.AnnotationValue,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitUnknown(Javax.Lang.Model.Element.AnnotationValue arg0, P arg1)
        {
            return IExecute<R>("visitUnknown", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}