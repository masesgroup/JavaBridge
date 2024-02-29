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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Lang.Model.Type
{
    #region TypeVisitor
    public partial class TypeVisitor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visit(javax.lang.model.type.TypeMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Visit(Javax.Lang.Model.Type.TypeMirror arg0, object arg1)
        {
            return IExecute("visit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitArray(javax.lang.model.type.ArrayType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.ArrayType"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitArray(Javax.Lang.Model.Type.ArrayType arg0, object arg1)
        {
            return IExecute("visitArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitDeclared(javax.lang.model.type.DeclaredType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.DeclaredType"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitDeclared(Javax.Lang.Model.Type.DeclaredType arg0, object arg1)
        {
            return IExecute("visitDeclared", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitError(javax.lang.model.type.ErrorType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.ErrorType"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitError(Javax.Lang.Model.Type.ErrorType arg0, object arg1)
        {
            return IExecute("visitError", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitExecutable(javax.lang.model.type.ExecutableType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.ExecutableType"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitExecutable(Javax.Lang.Model.Type.ExecutableType arg0, object arg1)
        {
            return IExecute("visitExecutable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitIntersection(javax.lang.model.type.IntersectionType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.IntersectionType"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitIntersection(Javax.Lang.Model.Type.IntersectionType arg0, object arg1)
        {
            return IExecute("visitIntersection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitNoType(javax.lang.model.type.NoType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.NoType"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitNoType(Javax.Lang.Model.Type.NoType arg0, object arg1)
        {
            return IExecute("visitNoType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitNull(javax.lang.model.type.NullType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.NullType"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitNull(Javax.Lang.Model.Type.NullType arg0, object arg1)
        {
            return IExecute("visitNull", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitPrimitive(javax.lang.model.type.PrimitiveType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.PrimitiveType"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitPrimitive(Javax.Lang.Model.Type.PrimitiveType arg0, object arg1)
        {
            return IExecute("visitPrimitive", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitTypeVariable(javax.lang.model.type.TypeVariable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeVariable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitTypeVariable(Javax.Lang.Model.Type.TypeVariable arg0, object arg1)
        {
            return IExecute("visitTypeVariable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitUnion(javax.lang.model.type.UnionType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.UnionType"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitUnion(Javax.Lang.Model.Type.UnionType arg0, object arg1)
        {
            return IExecute("visitUnion", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitUnknown(javax.lang.model.type.TypeMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitUnknown(Javax.Lang.Model.Type.TypeMirror arg0, object arg1)
        {
            return IExecute("visitUnknown", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitWildcard(javax.lang.model.type.WildcardType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.WildcardType"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitWildcard(Javax.Lang.Model.Type.WildcardType arg0, object arg1)
        {
            return IExecute("visitWildcard", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visit(javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="object"/></returns>
        public object Visit(Javax.Lang.Model.Type.TypeMirror arg0)
        {
            return IExecuteWithSignature("visit", "(Ljavax/lang/model/type/TypeMirror;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ITypeVisitor<R, P>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITypeVisitor<R, P>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visit(javax.lang.model.type.TypeMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R Visit(Javax.Lang.Model.Type.TypeMirror arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitArray(javax.lang.model.type.ArrayType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.ArrayType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitArray(Javax.Lang.Model.Type.ArrayType arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitDeclared(javax.lang.model.type.DeclaredType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.DeclaredType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitDeclared(Javax.Lang.Model.Type.DeclaredType arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitError(javax.lang.model.type.ErrorType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.ErrorType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitError(Javax.Lang.Model.Type.ErrorType arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitExecutable(javax.lang.model.type.ExecutableType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.ExecutableType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitExecutable(Javax.Lang.Model.Type.ExecutableType arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitIntersection(javax.lang.model.type.IntersectionType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.IntersectionType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitIntersection(Javax.Lang.Model.Type.IntersectionType arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitNoType(javax.lang.model.type.NoType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.NoType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitNoType(Javax.Lang.Model.Type.NoType arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitNull(javax.lang.model.type.NullType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.NullType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitNull(Javax.Lang.Model.Type.NullType arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitPrimitive(javax.lang.model.type.PrimitiveType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.PrimitiveType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitPrimitive(Javax.Lang.Model.Type.PrimitiveType arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitTypeVariable(javax.lang.model.type.TypeVariable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeVariable"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitTypeVariable(Javax.Lang.Model.Type.TypeVariable arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitUnion(javax.lang.model.type.UnionType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.UnionType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitUnion(Javax.Lang.Model.Type.UnionType arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitUnknown(javax.lang.model.type.TypeMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitUnknown(Javax.Lang.Model.Type.TypeMirror arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitWildcard(javax.lang.model.type.WildcardType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.WildcardType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitWildcard(Javax.Lang.Model.Type.WildcardType arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visit(javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R Visit(Javax.Lang.Model.Type.TypeMirror arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TypeVisitor<R, P>
    public partial class TypeVisitor<R, P> : Javax.Lang.Model.Type.ITypeVisitor<R, P>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Type.TypeVisitor{R, P}"/> to <see cref="Javax.Lang.Model.Type.TypeVisitor"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Type.TypeVisitor(Javax.Lang.Model.Type.TypeVisitor<R, P> t) => t.Cast<Javax.Lang.Model.Type.TypeVisitor>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visit(javax.lang.model.type.TypeMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Visit(Javax.Lang.Model.Type.TypeMirror arg0, P arg1)
        {
            return IExecute<R>("visit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitArray(javax.lang.model.type.ArrayType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.ArrayType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitArray(Javax.Lang.Model.Type.ArrayType arg0, P arg1)
        {
            return IExecute<R>("visitArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitDeclared(javax.lang.model.type.DeclaredType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.DeclaredType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitDeclared(Javax.Lang.Model.Type.DeclaredType arg0, P arg1)
        {
            return IExecute<R>("visitDeclared", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitError(javax.lang.model.type.ErrorType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.ErrorType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitError(Javax.Lang.Model.Type.ErrorType arg0, P arg1)
        {
            return IExecute<R>("visitError", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitExecutable(javax.lang.model.type.ExecutableType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.ExecutableType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitExecutable(Javax.Lang.Model.Type.ExecutableType arg0, P arg1)
        {
            return IExecute<R>("visitExecutable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitIntersection(javax.lang.model.type.IntersectionType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.IntersectionType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitIntersection(Javax.Lang.Model.Type.IntersectionType arg0, P arg1)
        {
            return IExecute<R>("visitIntersection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitNoType(javax.lang.model.type.NoType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.NoType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitNoType(Javax.Lang.Model.Type.NoType arg0, P arg1)
        {
            return IExecute<R>("visitNoType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitNull(javax.lang.model.type.NullType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.NullType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitNull(Javax.Lang.Model.Type.NullType arg0, P arg1)
        {
            return IExecute<R>("visitNull", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitPrimitive(javax.lang.model.type.PrimitiveType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.PrimitiveType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitPrimitive(Javax.Lang.Model.Type.PrimitiveType arg0, P arg1)
        {
            return IExecute<R>("visitPrimitive", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitTypeVariable(javax.lang.model.type.TypeVariable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeVariable"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitTypeVariable(Javax.Lang.Model.Type.TypeVariable arg0, P arg1)
        {
            return IExecute<R>("visitTypeVariable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitUnion(javax.lang.model.type.UnionType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.UnionType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitUnion(Javax.Lang.Model.Type.UnionType arg0, P arg1)
        {
            return IExecute<R>("visitUnion", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitUnknown(javax.lang.model.type.TypeMirror,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitUnknown(Javax.Lang.Model.Type.TypeMirror arg0, P arg1)
        {
            return IExecute<R>("visitUnknown", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visitWildcard(javax.lang.model.type.WildcardType,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.WildcardType"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitWildcard(Javax.Lang.Model.Type.WildcardType arg0, P arg1)
        {
            return IExecute<R>("visitWildcard", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVisitor.html#visit(javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Visit(Javax.Lang.Model.Type.TypeMirror arg0)
        {
            return IExecuteWithSignature<R>("visit", "(Ljavax/lang/model/type/TypeMirror;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}