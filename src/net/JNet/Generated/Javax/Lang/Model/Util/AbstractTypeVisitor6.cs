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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Lang.Model.Util
{
    #region AbstractTypeVisitor6
    public partial class AbstractTypeVisitor6
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractTypeVisitor6.html#visit(javax.lang.model.type.TypeMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Visit(Javax.Lang.Model.Type.TypeMirror arg0, object arg1)
        {
            return IExecute("visit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractTypeVisitor6.html#visit(javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="object"/></returns>
        public object Visit(Javax.Lang.Model.Type.TypeMirror arg0)
        {
            return IExecuteWithSignature("visit", "(Ljavax/lang/model/type/TypeMirror;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractTypeVisitor6.html#visitIntersection(javax.lang.model.type.IntersectionType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.IntersectionType"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitIntersection(Javax.Lang.Model.Type.IntersectionType arg0, object arg1)
        {
            return IExecute("visitIntersection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractTypeVisitor6.html#visitUnion(javax.lang.model.type.UnionType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.UnionType"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitUnion(Javax.Lang.Model.Type.UnionType arg0, object arg1)
        {
            return IExecute("visitUnion", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractTypeVisitor6.html#visitUnknown(javax.lang.model.type.TypeMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitUnknown(Javax.Lang.Model.Type.TypeMirror arg0, object arg1)
        {
            return IExecute("visitUnknown", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AbstractTypeVisitor6<R, P>
    public partial class AbstractTypeVisitor6<R, P>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Util.AbstractTypeVisitor6{R, P}"/> to <see cref="Javax.Lang.Model.Util.AbstractTypeVisitor6"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Util.AbstractTypeVisitor6(Javax.Lang.Model.Util.AbstractTypeVisitor6<R, P> t) => t.Cast<Javax.Lang.Model.Util.AbstractTypeVisitor6>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractTypeVisitor6.html#visit(javax.lang.model.type.TypeMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Visit(Javax.Lang.Model.Type.TypeMirror arg0, P arg1)
        {
            return IExecute<R>("visit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractTypeVisitor6.html#visit(javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Visit(Javax.Lang.Model.Type.TypeMirror arg0)
        {
            return IExecuteWithSignature<R>("visit", "(Ljavax/lang/model/type/TypeMirror;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractTypeVisitor6.html#visitIntersection(javax.lang.model.type.IntersectionType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.IntersectionType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitIntersection(Javax.Lang.Model.Type.IntersectionType arg0, P arg1)
        {
            return IExecute<R>("visitIntersection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractTypeVisitor6.html#visitUnion(javax.lang.model.type.UnionType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.UnionType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitUnion(Javax.Lang.Model.Type.UnionType arg0, P arg1)
        {
            return IExecute<R>("visitUnion", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractTypeVisitor6.html#visitUnknown(javax.lang.model.type.TypeMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitUnknown(Javax.Lang.Model.Type.TypeMirror arg0, P arg1)
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