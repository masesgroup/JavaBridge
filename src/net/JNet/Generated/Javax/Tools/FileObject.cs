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

namespace Javax.Tools
{
    #region IFileObject
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IFileObject
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#getLastModified()"/> 
        /// </summary>
        long LastModified { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#getName()"/> 
        /// </summary>
        Java.Lang.String Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#delete()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool Delete();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#openInputStream()"/>
        /// </summary>

        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Io.InputStream OpenInputStream();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#openOutputStream()"/>
        /// </summary>

        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Io.OutputStream OpenOutputStream();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#openReader(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Io.Reader OpenReader(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#openWriter()"/>
        /// </summary>

        /// <returns><see cref="Java.Io.Writer"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Io.Writer OpenWriter();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#getCharContent(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Lang.CharSequence GetCharContent(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#toUri()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.URI"/></returns>
        Java.Net.URI ToUri();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region FileObject
    public partial class FileObject : Javax.Tools.IFileObject
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#getLastModified()"/> 
        /// </summary>
        public long LastModified
        {
            get { return IExecuteWithSignature<long>("getLastModified", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#delete()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Delete()
        {
            return IExecuteWithSignature<bool>("delete", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#openInputStream()"/>
        /// </summary>

        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream OpenInputStream()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("openInputStream", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#openOutputStream()"/>
        /// </summary>

        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.OutputStream OpenOutputStream()
        {
            return IExecuteWithSignature<Java.Io.OutputStream>("openOutputStream", "()Ljava/io/OutputStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#openReader(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.Reader OpenReader(bool arg0)
        {
            return IExecuteWithSignature<Java.Io.Reader>("openReader", "(Z)Ljava/io/Reader;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#openWriter()"/>
        /// </summary>

        /// <returns><see cref="Java.Io.Writer"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.Writer OpenWriter()
        {
            return IExecuteWithSignature<Java.Io.Writer>("openWriter", "()Ljava/io/Writer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#getCharContent(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.CharSequence GetCharContent(bool arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getCharContent", "(Z)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/FileObject.html#toUri()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI ToUri()
        {
            return IExecuteWithSignature<Java.Net.URI>("toUri", "()Ljava/net/URI;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}