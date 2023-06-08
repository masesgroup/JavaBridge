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

namespace Java.Nio.File
{
    #region SecureDirectoryStream
    public partial class SecureDirectoryStream
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#getFileAttributeView(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.FileAttributeView"/></returns>
        public Java.Nio.File.Attribute.FileAttributeView GetFileAttributeView(Java.Lang.Class arg0)
        {
            return IExecute<Java.Nio.File.Attribute.FileAttributeView>("getFileAttributeView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#getFileAttributeView(java.lang.Object,java.lang.Class,java.nio.file.LinkOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.LinkOption"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.FileAttributeView"/></returns>
        public Java.Nio.File.Attribute.FileAttributeView GetFileAttributeView(object arg0, Java.Lang.Class arg1, params Java.Nio.File.LinkOption[] arg2)
        {
            if (arg2.Length == 0) return IExecute<Java.Nio.File.Attribute.FileAttributeView>("getFileAttributeView", arg0, arg1); else return IExecute<Java.Nio.File.Attribute.FileAttributeView>("getFileAttributeView", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#newByteChannel(java.lang.Object,java.util.Set,java.nio.file.attribute.FileAttribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.Attribute.FileAttribute"/></param>
        /// <returns><see cref="Java.Nio.Channels.SeekableByteChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.SeekableByteChannel NewByteChannel(object arg0, Java.Util.Set arg1, params Java.Nio.File.Attribute.FileAttribute[] arg2)
        {
            if (arg2.Length == 0) return IExecute<Java.Nio.Channels.SeekableByteChannel>("newByteChannel", arg0, arg1); else return IExecute<Java.Nio.Channels.SeekableByteChannel>("newByteChannel", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#newDirectoryStream(java.lang.Object,java.nio.file.LinkOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.LinkOption"/></param>
        /// <returns><see cref="Java.Nio.File.SecureDirectoryStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.SecureDirectoryStream NewDirectoryStream(object arg0, params Java.Nio.File.LinkOption[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Nio.File.SecureDirectoryStream>("newDirectoryStream", arg0); else return IExecute<Java.Nio.File.SecureDirectoryStream>("newDirectoryStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#deleteDirectory(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void DeleteDirectory(object arg0)
        {
            IExecute("deleteDirectory", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#deleteFile(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void DeleteFile(object arg0)
        {
            IExecute("deleteFile", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#move(java.lang.Object,java.nio.file.SecureDirectoryStream,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.SecureDirectoryStream"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Move(object arg0, Java.Nio.File.SecureDirectoryStream arg1, object arg2)
        {
            IExecute("move", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ISecureDirectoryStream<T>
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html"/>
    /// </summary>
    public partial interface ISecureDirectoryStream<T> : Java.Nio.File.IDirectoryStream<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#getFileAttributeView(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="V"><see cref="Java.Nio.File.Attribute.IFileAttributeView"/></typeparam>
        /// <returns><typeparamref name="V"/></returns>
        V GetFileAttributeView<V>(Java.Lang.Class arg0) where V: Java.Nio.File.Attribute.IFileAttributeView, new();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#getFileAttributeView(java.lang.Object,java.lang.Class,java.nio.file.LinkOption[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.LinkOption"/></param>
        /// <typeparam name="V"><see cref="Java.Nio.File.Attribute.IFileAttributeView"/></typeparam>
        /// <returns><typeparamref name="V"/></returns>
        V GetFileAttributeView<V>(T arg0, Java.Lang.Class arg1, params Java.Nio.File.LinkOption[] arg2) where V: Java.Nio.File.Attribute.IFileAttributeView, new();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#newByteChannel(java.lang.Object,java.util.Set,java.nio.file.attribute.FileAttribute[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.Attribute.FileAttribute"/></param>
        /// <typeparam name="Arg1ExtendsJava_Nio_File_OpenOption"><see cref="Java.Nio.File.OpenOption"/></typeparam>
        /// <returns><see cref="Java.Nio.Channels.SeekableByteChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.Channels.SeekableByteChannel NewByteChannel<Arg1ExtendsJava_Nio_File_OpenOption>(T arg0, Java.Util.Set<Arg1ExtendsJava_Nio_File_OpenOption> arg1, params Java.Nio.File.Attribute.FileAttribute<object>[] arg2) where Arg1ExtendsJava_Nio_File_OpenOption: Java.Nio.File.OpenOption;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#newDirectoryStream(java.lang.Object,java.nio.file.LinkOption[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.LinkOption"/></param>
        /// <returns><see cref="Java.Nio.File.SecureDirectoryStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.File.SecureDirectoryStream<T> NewDirectoryStream(T arg0, params Java.Nio.File.LinkOption[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#deleteDirectory(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void DeleteDirectory(T arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#deleteFile(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void DeleteFile(T arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#move(java.lang.Object,java.nio.file.SecureDirectoryStream,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.SecureDirectoryStream"/></param>
        /// <param name="arg2"><typeparamref name="T"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void Move(T arg0, Java.Nio.File.SecureDirectoryStream<T> arg1, T arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SecureDirectoryStream<T>
    public partial class SecureDirectoryStream<T> : Java.Nio.File.ISecureDirectoryStream<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.SecureDirectoryStream{T}"/> to <see cref="Java.Nio.File.SecureDirectoryStream"/>
        /// </summary>
        public static implicit operator Java.Nio.File.SecureDirectoryStream(Java.Nio.File.SecureDirectoryStream<T> t) => t.Cast<Java.Nio.File.SecureDirectoryStream>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#getFileAttributeView(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="V"><see cref="Java.Nio.File.Attribute.IFileAttributeView"/></typeparam>
        /// <returns><typeparamref name="V"/></returns>
        public V GetFileAttributeView<V>(Java.Lang.Class arg0) where V: Java.Nio.File.Attribute.IFileAttributeView, new()
        {
            return IExecute<V>("getFileAttributeView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#getFileAttributeView(java.lang.Object,java.lang.Class,java.nio.file.LinkOption[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.LinkOption"/></param>
        /// <typeparam name="V"><see cref="Java.Nio.File.Attribute.IFileAttributeView"/></typeparam>
        /// <returns><typeparamref name="V"/></returns>
        public V GetFileAttributeView<V>(T arg0, Java.Lang.Class arg1, params Java.Nio.File.LinkOption[] arg2) where V: Java.Nio.File.Attribute.IFileAttributeView, new()
        {
            if (arg2.Length == 0) return IExecute<V>("getFileAttributeView", arg0, arg1); else return IExecute<V>("getFileAttributeView", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#newByteChannel(java.lang.Object,java.util.Set,java.nio.file.attribute.FileAttribute[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.Attribute.FileAttribute"/></param>
        /// <typeparam name="Arg1ExtendsJava_Nio_File_OpenOption"><see cref="Java.Nio.File.OpenOption"/></typeparam>
        /// <returns><see cref="Java.Nio.Channels.SeekableByteChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.SeekableByteChannel NewByteChannel<Arg1ExtendsJava_Nio_File_OpenOption>(T arg0, Java.Util.Set<Arg1ExtendsJava_Nio_File_OpenOption> arg1, params Java.Nio.File.Attribute.FileAttribute<object>[] arg2) where Arg1ExtendsJava_Nio_File_OpenOption: Java.Nio.File.OpenOption
        {
            if (arg2.Length == 0) return IExecute<Java.Nio.Channels.SeekableByteChannel>("newByteChannel", arg0, arg1); else return IExecute<Java.Nio.Channels.SeekableByteChannel>("newByteChannel", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#newDirectoryStream(java.lang.Object,java.nio.file.LinkOption[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.LinkOption"/></param>
        /// <returns><see cref="Java.Nio.File.SecureDirectoryStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.SecureDirectoryStream<T> NewDirectoryStream(T arg0, params Java.Nio.File.LinkOption[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Nio.File.SecureDirectoryStream<T>>("newDirectoryStream", arg0); else return IExecute<Java.Nio.File.SecureDirectoryStream<T>>("newDirectoryStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#deleteDirectory(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void DeleteDirectory(T arg0)
        {
            IExecute("deleteDirectory", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#deleteFile(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void DeleteFile(T arg0)
        {
            IExecute("deleteFile", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SecureDirectoryStream.html#move(java.lang.Object,java.nio.file.SecureDirectoryStream,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.SecureDirectoryStream"/></param>
        /// <param name="arg2"><typeparamref name="T"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Move(T arg0, Java.Nio.File.SecureDirectoryStream<T> arg1, T arg2)
        {
            IExecute("move", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}