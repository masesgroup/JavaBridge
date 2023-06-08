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

namespace Javax.Lang.Model.Element
{
    #region IElement
    public partial interface IElement : Javax.Lang.Model.IAnnotatedConstruct
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getAnnotationMirrors()"/> 
        /// </summary>
        Java.Util.List AnnotationMirrors { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#asType()"/> 
        /// </summary>
        Javax.Lang.Model.Type.TypeMirror AsType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getEnclosedElements()"/> 
        /// </summary>
        Java.Util.List EnclosedElements { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getEnclosingElement()"/> 
        /// </summary>
        Javax.Lang.Model.Element.Element EnclosingElement { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getKind()"/> 
        /// </summary>
        Javax.Lang.Model.Element.ElementKind Kind { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getModifiers()"/> 
        /// </summary>
        Java.Util.Set<Javax.Lang.Model.Element.Modifier> Modifiers { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getSimpleName()"/> 
        /// </summary>
        Javax.Lang.Model.Element.Name SimpleName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="A"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="A"/></returns>
        A GetAnnotation<A>(Java.Lang.Class arg0) where A: Java.Lang.Annotation.IAnnotation, new();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#accept(javax.lang.model.element.ElementVisitor,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ElementVisitor"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        R Accept<R, P>(Javax.Lang.Model.Element.ElementVisitor<R, P> arg0, P arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Element
    public partial class Element : Javax.Lang.Model.Element.IElement
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getAnnotationMirrors()"/> 
        /// </summary>
        public Java.Util.List AnnotationMirrors
        {
            get { return IExecute<Java.Util.List>("getAnnotationMirrors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#asType()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.TypeMirror AsType
        {
            get { return IExecute<Javax.Lang.Model.Type.TypeMirror>("asType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getEnclosedElements()"/> 
        /// </summary>
        public Java.Util.List EnclosedElements
        {
            get { return IExecute<Java.Util.List>("getEnclosedElements"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getEnclosingElement()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Element EnclosingElement
        {
            get { return IExecute<Javax.Lang.Model.Element.Element>("getEnclosingElement"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getKind()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.ElementKind Kind
        {
            get { return IExecute<Javax.Lang.Model.Element.ElementKind>("getKind"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getModifiers()"/> 
        /// </summary>
        public Java.Util.Set<Javax.Lang.Model.Element.Modifier> Modifiers
        {
            get { return IExecute<Java.Util.Set<Javax.Lang.Model.Element.Modifier>>("getModifiers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getSimpleName()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Name SimpleName
        {
            get { return IExecute<Javax.Lang.Model.Element.Name>("getSimpleName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="A"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="A"/></returns>
        public A GetAnnotation<A>(Java.Lang.Class arg0) where A: Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecute<A>("getAnnotation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#accept(javax.lang.model.element.ElementVisitor,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ElementVisitor"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Accept<R, P>(Javax.Lang.Model.Element.ElementVisitor<R, P> arg0, P arg1)
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