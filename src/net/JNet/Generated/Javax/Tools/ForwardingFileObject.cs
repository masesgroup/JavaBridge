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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Tools
{
    #region ForwardingFileObject
    public partial class ForwardingFileObject
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#getLastModified()"/> 
        /// </summary>
        public long LastModified
        {
            get { return IExecuteWithSignature<long>("getLastModified", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#delete()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Delete()
        {
            return IExecuteWithSignature<bool>("delete", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#openInputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream OpenInputStream()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("openInputStream", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#openOutputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.OutputStream OpenOutputStream()
        {
            return IExecuteWithSignature<Java.Io.OutputStream>("openOutputStream", "()Ljava/io/OutputStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#openReader(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.Reader OpenReader(bool arg0)
        {
            return IExecuteWithSignature<Java.Io.Reader>("openReader", "(Z)Ljava/io/Reader;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#openWriter()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.Writer"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.Writer OpenWriter()
        {
            return IExecuteWithSignature<Java.Io.Writer>("openWriter", "()Ljava/io/Writer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#getCharContent(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.CharSequence GetCharContent(bool arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getCharContent", "(Z)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#toUri()"/>
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

    #region ForwardingFileObject<F>
    public partial class ForwardingFileObject<F>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Tools.ForwardingFileObject{F}"/> to <see cref="Javax.Tools.ForwardingFileObject"/>
        /// </summary>
        public static implicit operator Javax.Tools.ForwardingFileObject(Javax.Tools.ForwardingFileObject<F> t) => t.Cast<Javax.Tools.ForwardingFileObject>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#getLastModified()"/> 
        /// </summary>
        public long LastModified
        {
            get { return IExecuteWithSignature<long>("getLastModified", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#delete()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Delete()
        {
            return IExecuteWithSignature<bool>("delete", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#openInputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream OpenInputStream()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("openInputStream", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#openOutputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.OutputStream OpenOutputStream()
        {
            return IExecuteWithSignature<Java.Io.OutputStream>("openOutputStream", "()Ljava/io/OutputStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#openReader(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.Reader OpenReader(bool arg0)
        {
            return IExecuteWithSignature<Java.Io.Reader>("openReader", "(Z)Ljava/io/Reader;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#openWriter()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.Writer"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.Writer OpenWriter()
        {
            return IExecuteWithSignature<Java.Io.Writer>("openWriter", "()Ljava/io/Writer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#getCharContent(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.CharSequence GetCharContent(bool arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getCharContent", "(Z)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingFileObject.html#toUri()"/>
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