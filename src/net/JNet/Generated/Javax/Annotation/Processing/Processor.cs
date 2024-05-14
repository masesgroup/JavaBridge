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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Annotation.Processing
{
    #region IProcessor
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IProcessor
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#getSupportedAnnotationTypes()"/> 
        /// </summary>
        Java.Util.Set<Java.Lang.String> SupportedAnnotationTypes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#getSupportedOptions()"/> 
        /// </summary>
        Java.Util.Set<Java.Lang.String> SupportedOptions { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#getSupportedSourceVersion()"/> 
        /// </summary>
        Javax.Lang.Model.SourceVersion SupportedSourceVersion { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#process(java.util.Set,javax.annotation.processing.RoundEnvironment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="Javax.Annotation.Processing.RoundEnvironment"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_TypeElement"><see cref="Javax.Lang.Model.Element.TypeElement"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        bool Process<Arg0ExtendsJavax_Lang_Model_Element_TypeElement>(Java.Util.Set<Arg0ExtendsJavax_Lang_Model_Element_TypeElement> arg0, Javax.Annotation.Processing.RoundEnvironment arg1) where Arg0ExtendsJavax_Lang_Model_Element_TypeElement: Javax.Lang.Model.Element.TypeElement;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#getCompletions(javax.lang.model.element.Element,javax.lang.model.element.AnnotationMirror,javax.lang.model.element.ExecutableElement,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.AnnotationMirror"/></param>
        /// <param name="arg2"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="ReturnExtendsJavax_Annotation_Processing_Completion"><see cref="Javax.Annotation.Processing.Completion"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        Java.Lang.Iterable<ReturnExtendsJavax_Annotation_Processing_Completion> GetCompletions<ReturnExtendsJavax_Annotation_Processing_Completion>(Javax.Lang.Model.Element.Element arg0, Javax.Lang.Model.Element.AnnotationMirror arg1, Javax.Lang.Model.Element.ExecutableElement arg2, Java.Lang.String arg3) where ReturnExtendsJavax_Annotation_Processing_Completion: Javax.Annotation.Processing.Completion;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#init(javax.annotation.processing.ProcessingEnvironment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Annotation.Processing.ProcessingEnvironment"/></param>
        void Init(Javax.Annotation.Processing.ProcessingEnvironment arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Processor
    public partial class Processor : Javax.Annotation.Processing.IProcessor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#getSupportedAnnotationTypes()"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.String> SupportedAnnotationTypes
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getSupportedAnnotationTypes", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#getSupportedOptions()"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.String> SupportedOptions
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getSupportedOptions", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#getSupportedSourceVersion()"/> 
        /// </summary>
        public Javax.Lang.Model.SourceVersion SupportedSourceVersion
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.SourceVersion>("getSupportedSourceVersion", "()Ljavax/lang/model/SourceVersion;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#process(java.util.Set,javax.annotation.processing.RoundEnvironment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="Javax.Annotation.Processing.RoundEnvironment"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_TypeElement"><see cref="Javax.Lang.Model.Element.TypeElement"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool Process<Arg0ExtendsJavax_Lang_Model_Element_TypeElement>(Java.Util.Set<Arg0ExtendsJavax_Lang_Model_Element_TypeElement> arg0, Javax.Annotation.Processing.RoundEnvironment arg1) where Arg0ExtendsJavax_Lang_Model_Element_TypeElement: Javax.Lang.Model.Element.TypeElement
        {
            return IExecute<bool>("process", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#getCompletions(javax.lang.model.element.Element,javax.lang.model.element.AnnotationMirror,javax.lang.model.element.ExecutableElement,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.AnnotationMirror"/></param>
        /// <param name="arg2"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="ReturnExtendsJavax_Annotation_Processing_Completion"><see cref="Javax.Annotation.Processing.Completion"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable<ReturnExtendsJavax_Annotation_Processing_Completion> GetCompletions<ReturnExtendsJavax_Annotation_Processing_Completion>(Javax.Lang.Model.Element.Element arg0, Javax.Lang.Model.Element.AnnotationMirror arg1, Javax.Lang.Model.Element.ExecutableElement arg2, Java.Lang.String arg3) where ReturnExtendsJavax_Annotation_Processing_Completion: Javax.Annotation.Processing.Completion
        {
            return IExecute<Java.Lang.Iterable<ReturnExtendsJavax_Annotation_Processing_Completion>>("getCompletions", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#init(javax.annotation.processing.ProcessingEnvironment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Annotation.Processing.ProcessingEnvironment"/></param>
        public void Init(Javax.Annotation.Processing.ProcessingEnvironment arg0)
        {
            IExecuteWithSignature("init", "(Ljavax/annotation/processing/ProcessingEnvironment;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}