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

namespace Javax.Lang.Model.Util
{
    #region Types
    public partial class Types
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#getNullType()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.NullType NullType
        {
            get { return IExecute<Javax.Lang.Model.Type.NullType>("getNullType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#contains(javax.lang.model.type.TypeMirror,javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Javax.Lang.Model.Type.TypeMirror arg0, Javax.Lang.Model.Type.TypeMirror arg1)
        {
            return IExecute<bool>("contains", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#isAssignable(javax.lang.model.type.TypeMirror,javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAssignable(Javax.Lang.Model.Type.TypeMirror arg0, Javax.Lang.Model.Type.TypeMirror arg1)
        {
            return IExecute<bool>("isAssignable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#isSameType(javax.lang.model.type.TypeMirror,javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSameType(Javax.Lang.Model.Type.TypeMirror arg0, Javax.Lang.Model.Type.TypeMirror arg1)
        {
            return IExecute<bool>("isSameType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#isSubsignature(javax.lang.model.type.ExecutableType,javax.lang.model.type.ExecutableType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.ExecutableType"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Type.ExecutableType"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSubsignature(Javax.Lang.Model.Type.ExecutableType arg0, Javax.Lang.Model.Type.ExecutableType arg1)
        {
            return IExecute<bool>("isSubsignature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#isSubtype(javax.lang.model.type.TypeMirror,javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSubtype(Javax.Lang.Model.Type.TypeMirror arg0, Javax.Lang.Model.Type.TypeMirror arg1)
        {
            return IExecute<bool>("isSubtype", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#directSupertypes(javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List DirectSupertypes(Javax.Lang.Model.Type.TypeMirror arg0)
        {
            return IExecute<Java.Util.List>("directSupertypes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#asElement(javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="Javax.Lang.Model.Element.Element"/></returns>
        public Javax.Lang.Model.Element.Element AsElement(Javax.Lang.Model.Type.TypeMirror arg0)
        {
            return IExecute<Javax.Lang.Model.Element.Element>("asElement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#boxedClass(javax.lang.model.type.PrimitiveType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.PrimitiveType"/></param>
        /// <returns><see cref="Javax.Lang.Model.Element.TypeElement"/></returns>
        public Javax.Lang.Model.Element.TypeElement BoxedClass(Javax.Lang.Model.Type.PrimitiveType arg0)
        {
            return IExecute<Javax.Lang.Model.Element.TypeElement>("boxedClass", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#getArrayType(javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="Javax.Lang.Model.Type.ArrayType"/></returns>
        public Javax.Lang.Model.Type.ArrayType GetArrayType(Javax.Lang.Model.Type.TypeMirror arg0)
        {
            return IExecute<Javax.Lang.Model.Type.ArrayType>("getArrayType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#getDeclaredType(javax.lang.model.element.TypeElement,javax.lang.model.type.TypeMirror...)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="Javax.Lang.Model.Type.DeclaredType"/></returns>
        public Javax.Lang.Model.Type.DeclaredType GetDeclaredType(Javax.Lang.Model.Element.TypeElement arg0, params Javax.Lang.Model.Type.TypeMirror[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Javax.Lang.Model.Type.DeclaredType>("getDeclaredType", arg0); else return IExecute<Javax.Lang.Model.Type.DeclaredType>("getDeclaredType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#getDeclaredType(javax.lang.model.type.DeclaredType,javax.lang.model.element.TypeElement,javax.lang.model.type.TypeMirror...)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.DeclaredType"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <param name="arg2"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="Javax.Lang.Model.Type.DeclaredType"/></returns>
        public Javax.Lang.Model.Type.DeclaredType GetDeclaredType(Javax.Lang.Model.Type.DeclaredType arg0, Javax.Lang.Model.Element.TypeElement arg1, params Javax.Lang.Model.Type.TypeMirror[] arg2)
        {
            if (arg2.Length == 0) return IExecute<Javax.Lang.Model.Type.DeclaredType>("getDeclaredType", arg0, arg1); else return IExecute<Javax.Lang.Model.Type.DeclaredType>("getDeclaredType", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#getNoType(javax.lang.model.type.TypeKind)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeKind"/></param>
        /// <returns><see cref="Javax.Lang.Model.Type.NoType"/></returns>
        public Javax.Lang.Model.Type.NoType GetNoType(Javax.Lang.Model.Type.TypeKind arg0)
        {
            return IExecute<Javax.Lang.Model.Type.NoType>("getNoType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#getPrimitiveType(javax.lang.model.type.TypeKind)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeKind"/></param>
        /// <returns><see cref="Javax.Lang.Model.Type.PrimitiveType"/></returns>
        public Javax.Lang.Model.Type.PrimitiveType GetPrimitiveType(Javax.Lang.Model.Type.TypeKind arg0)
        {
            return IExecute<Javax.Lang.Model.Type.PrimitiveType>("getPrimitiveType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#unboxedType(javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="Javax.Lang.Model.Type.PrimitiveType"/></returns>
        public Javax.Lang.Model.Type.PrimitiveType UnboxedType(Javax.Lang.Model.Type.TypeMirror arg0)
        {
            return IExecute<Javax.Lang.Model.Type.PrimitiveType>("unboxedType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#asMemberOf(javax.lang.model.type.DeclaredType,javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.DeclaredType"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="Javax.Lang.Model.Type.TypeMirror"/></returns>
        public Javax.Lang.Model.Type.TypeMirror AsMemberOf(Javax.Lang.Model.Type.DeclaredType arg0, Javax.Lang.Model.Element.Element arg1)
        {
            return IExecute<Javax.Lang.Model.Type.TypeMirror>("asMemberOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#capture(javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="Javax.Lang.Model.Type.TypeMirror"/></returns>
        public Javax.Lang.Model.Type.TypeMirror Capture(Javax.Lang.Model.Type.TypeMirror arg0)
        {
            return IExecute<Javax.Lang.Model.Type.TypeMirror>("capture", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#erasure(javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="Javax.Lang.Model.Type.TypeMirror"/></returns>
        public Javax.Lang.Model.Type.TypeMirror Erasure(Javax.Lang.Model.Type.TypeMirror arg0)
        {
            return IExecute<Javax.Lang.Model.Type.TypeMirror>("erasure", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Types.html#getWildcardType(javax.lang.model.type.TypeMirror,javax.lang.model.type.TypeMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Type.TypeMirror"/></param>
        /// <returns><see cref="Javax.Lang.Model.Type.WildcardType"/></returns>
        public Javax.Lang.Model.Type.WildcardType GetWildcardType(Javax.Lang.Model.Type.TypeMirror arg0, Javax.Lang.Model.Type.TypeMirror arg1)
        {
            return IExecute<Javax.Lang.Model.Type.WildcardType>("getWildcardType", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}