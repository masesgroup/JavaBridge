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
    #region IModuleElement
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html"/>
    /// </summary>
    public partial interface IModuleElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html#getDirectives()"/> 
        /// </summary>
        Java.Util.List Directives { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html#getEnclosedElements()"/> 
        /// </summary>
        Java.Util.List EnclosedElements { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html#getEnclosingElement()"/> 
        /// </summary>
        Javax.Lang.Model.Element.Element EnclosingElement { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html#isOpen()"/> 
        /// </summary>
        bool IsOpen { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html#isUnnamed()"/> 
        /// </summary>
        bool IsUnnamed { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html#getQualifiedName()"/> 
        /// </summary>
        Javax.Lang.Model.Element.Name QualifiedName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html#getSimpleName()"/> 
        /// </summary>
        Javax.Lang.Model.Element.Name SimpleName { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ModuleElement
    public partial class ModuleElement : Javax.Lang.Model.Element.IModuleElement
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Element.ModuleElement"/> to <see cref="Javax.Lang.Model.Element.Element"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Element.Element(Javax.Lang.Model.Element.ModuleElement t) => t.Cast<Javax.Lang.Model.Element.Element>();
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Element.ModuleElement"/> to <see cref="Javax.Lang.Model.Element.QualifiedNameable"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Element.QualifiedNameable(Javax.Lang.Model.Element.ModuleElement t) => t.Cast<Javax.Lang.Model.Element.QualifiedNameable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html#getDirectives()"/> 
        /// </summary>
        public Java.Util.List Directives
        {
            get { return IExecute<Java.Util.List>("getDirectives"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html#getEnclosedElements()"/> 
        /// </summary>
        public Java.Util.List EnclosedElements
        {
            get { return IExecute<Java.Util.List>("getEnclosedElements"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html#getEnclosingElement()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Element EnclosingElement
        {
            get { return IExecute<Javax.Lang.Model.Element.Element>("getEnclosingElement"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html#isOpen()"/> 
        /// </summary>
        public bool IsOpen
        {
            get { return IExecute<bool>("isOpen"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html#isUnnamed()"/> 
        /// </summary>
        public bool IsUnnamed
        {
            get { return IExecute<bool>("isUnnamed"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html#getQualifiedName()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Name QualifiedName
        {
            get { return IExecute<Javax.Lang.Model.Element.Name>("getQualifiedName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.html#getSimpleName()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Name SimpleName
        {
            get { return IExecute<Javax.Lang.Model.Element.Name>("getSimpleName"); }
        }

        #endregion

        #region Nested classes
        #region Directive
        public partial class Directive
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.Directive.html#getKind()"/> 
            /// </summary>
            public Javax.Lang.Model.Element.ModuleElement.DirectiveKind Kind
            {
                get { return IExecute<Javax.Lang.Model.Element.ModuleElement.DirectiveKind>("getKind"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.Directive.html#accept(javax.lang.model.element.ModuleElement.DirectiveVisitor,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.DirectiveVisitor"/></param>
            /// <param name="arg1"><typeparamref name="P"/></param>
            /// <typeparam name="R"></typeparam>
            /// <typeparam name="P"></typeparam>
            /// <returns><typeparamref name="R"/></returns>
            public R Accept<R, P>(Javax.Lang.Model.Element.ModuleElement.DirectiveVisitor<R, P> arg0, P arg1)
            {
                return IExecute<R>("accept", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region DirectiveKind
        public partial class DirectiveKind
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveKind.html#EXPORTS"/>
            /// </summary>
            public static Javax.Lang.Model.Element.ModuleElement.DirectiveKind EXPORTS { get { return SGetField<Javax.Lang.Model.Element.ModuleElement.DirectiveKind>(LocalBridgeClazz, "EXPORTS"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveKind.html#OPENS"/>
            /// </summary>
            public static Javax.Lang.Model.Element.ModuleElement.DirectiveKind OPENS { get { return SGetField<Javax.Lang.Model.Element.ModuleElement.DirectiveKind>(LocalBridgeClazz, "OPENS"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveKind.html#PROVIDES"/>
            /// </summary>
            public static Javax.Lang.Model.Element.ModuleElement.DirectiveKind PROVIDES { get { return SGetField<Javax.Lang.Model.Element.ModuleElement.DirectiveKind>(LocalBridgeClazz, "PROVIDES"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveKind.html#REQUIRES"/>
            /// </summary>
            public static Javax.Lang.Model.Element.ModuleElement.DirectiveKind REQUIRES { get { return SGetField<Javax.Lang.Model.Element.ModuleElement.DirectiveKind>(LocalBridgeClazz, "REQUIRES"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveKind.html#USES"/>
            /// </summary>
            public static Javax.Lang.Model.Element.ModuleElement.DirectiveKind USES { get { return SGetField<Javax.Lang.Model.Element.ModuleElement.DirectiveKind>(LocalBridgeClazz, "USES"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveKind.html#values()"/> 
            /// </summary>
            public static Javax.Lang.Model.Element.ModuleElement.DirectiveKind[] Values
            {
                get { return SExecuteArray<Javax.Lang.Model.Element.ModuleElement.DirectiveKind>(LocalBridgeClazz, "values"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveKind.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Lang.Model.Element.ModuleElement.DirectiveKind"/></returns>
            public static Javax.Lang.Model.Element.ModuleElement.DirectiveKind ValueOf(string arg0)
            {
                return SExecute<Javax.Lang.Model.Element.ModuleElement.DirectiveKind>(LocalBridgeClazz, "valueOf", arg0);
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region DirectiveVisitor
        public partial class DirectiveVisitor
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visitExports(javax.lang.model.element.ModuleElement.ExportsDirective,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.ExportsDirective"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object VisitExports(Javax.Lang.Model.Element.ModuleElement.ExportsDirective arg0, object arg1)
            {
                return IExecute("visitExports", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visitOpens(javax.lang.model.element.ModuleElement.OpensDirective,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.OpensDirective"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object VisitOpens(Javax.Lang.Model.Element.ModuleElement.OpensDirective arg0, object arg1)
            {
                return IExecute("visitOpens", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visitProvides(javax.lang.model.element.ModuleElement.ProvidesDirective,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.ProvidesDirective"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object VisitProvides(Javax.Lang.Model.Element.ModuleElement.ProvidesDirective arg0, object arg1)
            {
                return IExecute("visitProvides", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visitRequires(javax.lang.model.element.ModuleElement.RequiresDirective,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.RequiresDirective"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object VisitRequires(Javax.Lang.Model.Element.ModuleElement.RequiresDirective arg0, object arg1)
            {
                return IExecute("visitRequires", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visitUses(javax.lang.model.element.ModuleElement.UsesDirective,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.UsesDirective"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object VisitUses(Javax.Lang.Model.Element.ModuleElement.UsesDirective arg0, object arg1)
            {
                return IExecute("visitUses", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visit(javax.lang.model.element.ModuleElement.Directive,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.Directive"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object Visit(Javax.Lang.Model.Element.ModuleElement.Directive arg0, object arg1)
            {
                return IExecute("visit", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visit(javax.lang.model.element.ModuleElement.Directive)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.Directive"/></param>
            /// <returns><see cref="object"/></returns>
            public object Visit(Javax.Lang.Model.Element.ModuleElement.Directive arg0)
            {
                return IExecute("visit", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visitUnknown(javax.lang.model.element.ModuleElement.Directive,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.Directive"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object VisitUnknown(Javax.Lang.Model.Element.ModuleElement.Directive arg0, object arg1)
            {
                return IExecute("visitUnknown", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region DirectiveVisitor<R, P>
        public partial class DirectiveVisitor<R, P>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Lang.Model.Element.ModuleElement.DirectiveVisitor{R, P}"/> to <see cref="Javax.Lang.Model.Element.ModuleElement.DirectiveVisitor"/>
            /// </summary>
            public static implicit operator Javax.Lang.Model.Element.ModuleElement.DirectiveVisitor(Javax.Lang.Model.Element.ModuleElement.DirectiveVisitor<R, P> t) => t.Cast<Javax.Lang.Model.Element.ModuleElement.DirectiveVisitor>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visitExports(javax.lang.model.element.ModuleElement.ExportsDirective,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.ExportsDirective"/></param>
            /// <param name="arg1"><typeparamref name="P"/></param>
            /// <returns><typeparamref name="R"/></returns>
            public R VisitExports(Javax.Lang.Model.Element.ModuleElement.ExportsDirective arg0, P arg1)
            {
                return IExecute<R>("visitExports", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visitOpens(javax.lang.model.element.ModuleElement.OpensDirective,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.OpensDirective"/></param>
            /// <param name="arg1"><typeparamref name="P"/></param>
            /// <returns><typeparamref name="R"/></returns>
            public R VisitOpens(Javax.Lang.Model.Element.ModuleElement.OpensDirective arg0, P arg1)
            {
                return IExecute<R>("visitOpens", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visitProvides(javax.lang.model.element.ModuleElement.ProvidesDirective,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.ProvidesDirective"/></param>
            /// <param name="arg1"><typeparamref name="P"/></param>
            /// <returns><typeparamref name="R"/></returns>
            public R VisitProvides(Javax.Lang.Model.Element.ModuleElement.ProvidesDirective arg0, P arg1)
            {
                return IExecute<R>("visitProvides", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visitRequires(javax.lang.model.element.ModuleElement.RequiresDirective,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.RequiresDirective"/></param>
            /// <param name="arg1"><typeparamref name="P"/></param>
            /// <returns><typeparamref name="R"/></returns>
            public R VisitRequires(Javax.Lang.Model.Element.ModuleElement.RequiresDirective arg0, P arg1)
            {
                return IExecute<R>("visitRequires", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visitUses(javax.lang.model.element.ModuleElement.UsesDirective,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.UsesDirective"/></param>
            /// <param name="arg1"><typeparamref name="P"/></param>
            /// <returns><typeparamref name="R"/></returns>
            public R VisitUses(Javax.Lang.Model.Element.ModuleElement.UsesDirective arg0, P arg1)
            {
                return IExecute<R>("visitUses", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visit(javax.lang.model.element.ModuleElement.Directive,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.Directive"/></param>
            /// <param name="arg1"><typeparamref name="P"/></param>
            /// <returns><typeparamref name="R"/></returns>
            public R Visit(Javax.Lang.Model.Element.ModuleElement.Directive arg0, P arg1)
            {
                return IExecute<R>("visit", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visit(javax.lang.model.element.ModuleElement.Directive)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.Directive"/></param>
            /// <returns><typeparamref name="R"/></returns>
            public R Visit(Javax.Lang.Model.Element.ModuleElement.Directive arg0)
            {
                return IExecute<R>("visit", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.DirectiveVisitor.html#visitUnknown(javax.lang.model.element.ModuleElement.Directive,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement.Directive"/></param>
            /// <param name="arg1"><typeparamref name="P"/></param>
            /// <returns><typeparamref name="R"/></returns>
            public R VisitUnknown(Javax.Lang.Model.Element.ModuleElement.Directive arg0, P arg1)
            {
                return IExecute<R>("visitUnknown", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ExportsDirective
        public partial class ExportsDirective
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.ExportsDirective.html#getPackage()"/> 
            /// </summary>
            public Javax.Lang.Model.Element.PackageElement Package
            {
                get { return IExecute<Javax.Lang.Model.Element.PackageElement>("getPackage"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.ExportsDirective.html#getTargetModules()"/> 
            /// </summary>
            public Java.Util.List TargetModules
            {
                get { return IExecute<Java.Util.List>("getTargetModules"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OpensDirective
        public partial class OpensDirective
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.OpensDirective.html#getPackage()"/> 
            /// </summary>
            public Javax.Lang.Model.Element.PackageElement Package
            {
                get { return IExecute<Javax.Lang.Model.Element.PackageElement>("getPackage"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.OpensDirective.html#getTargetModules()"/> 
            /// </summary>
            public Java.Util.List TargetModules
            {
                get { return IExecute<Java.Util.List>("getTargetModules"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ProvidesDirective
        public partial class ProvidesDirective
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.ProvidesDirective.html#getImplementations()"/> 
            /// </summary>
            public Java.Util.List Implementations
            {
                get { return IExecute<Java.Util.List>("getImplementations"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.ProvidesDirective.html#getService()"/> 
            /// </summary>
            public Javax.Lang.Model.Element.TypeElement Service
            {
                get { return IExecute<Javax.Lang.Model.Element.TypeElement>("getService"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region RequiresDirective
        public partial class RequiresDirective
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.RequiresDirective.html#getDependency()"/> 
            /// </summary>
            public Javax.Lang.Model.Element.ModuleElement Dependency
            {
                get { return IExecute<Javax.Lang.Model.Element.ModuleElement>("getDependency"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.RequiresDirective.html#isStatic()"/> 
            /// </summary>
            public bool IsStatic
            {
                get { return IExecute<bool>("isStatic"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.RequiresDirective.html#isTransitive()"/> 
            /// </summary>
            public bool IsTransitive
            {
                get { return IExecute<bool>("isTransitive"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region UsesDirective
        public partial class UsesDirective
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ModuleElement.UsesDirective.html#getService()"/> 
            /// </summary>
            public Javax.Lang.Model.Element.TypeElement Service
            {
                get { return IExecute<Javax.Lang.Model.Element.TypeElement>("getService"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}