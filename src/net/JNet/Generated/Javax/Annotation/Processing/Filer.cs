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

namespace Javax.Annotation.Processing
{
    #region IFiler
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IFiler
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Filer.html#createResource(javax.tools.JavaFileManager.Location,java.lang.CharSequence,java.lang.CharSequence,javax.lang.model.element.Element[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg3"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="Javax.Tools.FileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Javax.Tools.FileObject CreateResource(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.CharSequence arg1, Java.Lang.CharSequence arg2, params Javax.Lang.Model.Element.Element[] arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Filer.html#getResource(javax.tools.JavaFileManager.Location,java.lang.CharSequence,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Javax.Tools.FileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Javax.Tools.FileObject GetResource(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.CharSequence arg1, Java.Lang.CharSequence arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Filer.html#createClassFile(java.lang.CharSequence,javax.lang.model.element.Element[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Javax.Tools.JavaFileObject CreateClassFile(Java.Lang.CharSequence arg0, params Javax.Lang.Model.Element.Element[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Filer.html#createSourceFile(java.lang.CharSequence,javax.lang.model.element.Element[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Javax.Tools.JavaFileObject CreateSourceFile(Java.Lang.CharSequence arg0, params Javax.Lang.Model.Element.Element[] arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Filer
    public partial class Filer : Javax.Annotation.Processing.IFiler
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Filer.html#createResource(javax.tools.JavaFileManager.Location,java.lang.CharSequence,java.lang.CharSequence,javax.lang.model.element.Element[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg3"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="Javax.Tools.FileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.FileObject CreateResource(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.CharSequence arg1, Java.Lang.CharSequence arg2, params Javax.Lang.Model.Element.Element[] arg3)
        {
            if (arg3.Length == 0) return IExecute<Javax.Tools.FileObject>("createResource", arg0, arg1, arg2); else return IExecute<Javax.Tools.FileObject>("createResource", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Filer.html#getResource(javax.tools.JavaFileManager.Location,java.lang.CharSequence,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Javax.Tools.FileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.FileObject GetResource(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.CharSequence arg1, Java.Lang.CharSequence arg2)
        {
            return IExecute<Javax.Tools.FileObject>("getResource", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Filer.html#createClassFile(java.lang.CharSequence,javax.lang.model.element.Element[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.JavaFileObject CreateClassFile(Java.Lang.CharSequence arg0, params Javax.Lang.Model.Element.Element[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Javax.Tools.JavaFileObject>("createClassFile", arg0); else return IExecute<Javax.Tools.JavaFileObject>("createClassFile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Filer.html#createSourceFile(java.lang.CharSequence,javax.lang.model.element.Element[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.JavaFileObject CreateSourceFile(Java.Lang.CharSequence arg0, params Javax.Lang.Model.Element.Element[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Javax.Tools.JavaFileObject>("createSourceFile", arg0); else return IExecute<Javax.Tools.JavaFileObject>("createSourceFile", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}