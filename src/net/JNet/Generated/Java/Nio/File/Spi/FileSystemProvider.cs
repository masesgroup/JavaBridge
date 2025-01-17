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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File.Spi
{
    #region FileSystemProvider declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html"/>
    /// </summary>
    public partial class FileSystemProvider : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FileSystemProvider>
    {
        const string _bridgeClassName = "java.nio.file.spi.FileSystemProvider";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("FileSystemProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FileSystemProvider() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("FileSystemProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FileSystemProvider(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region FileSystemProvider implementation
    public partial class FileSystemProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#installedProviders()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Java.Nio.File.Spi.FileSystemProvider> InstalledProviders()
        {
            return SExecuteWithSignature<Java.Util.List<Java.Nio.File.Spi.FileSystemProvider>>(LocalBridgeClazz, "installedProviders", "()Ljava/util/List;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#getScheme()"/> 
        /// </summary>
        public Java.Lang.String Scheme
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getScheme", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#readAttributes(java.nio.file.Path,java.lang.Class,java.nio.file.LinkOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.LinkOption"/></param>
        /// <typeparam name="A"><see cref="Java.Nio.File.Attribute.IBasicFileAttributes"/></typeparam>
        /// <returns><typeparamref name="A"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public A ReadAttributes<A>(Java.Nio.File.Path arg0, Java.Lang.Class arg1, params Java.Nio.File.LinkOption[] arg2) where A : Java.Nio.File.Attribute.IBasicFileAttributes, new()
        {
            if (arg2.Length == 0) return IExecute<A>("readAttributes", arg0, arg1); else return IExecute<A>("readAttributes", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#getFileAttributeView(java.nio.file.Path,java.lang.Class,java.nio.file.LinkOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.LinkOption"/></param>
        /// <typeparam name="V"><see cref="Java.Nio.File.Attribute.IFileAttributeView"/></typeparam>
        /// <returns><typeparamref name="V"/></returns>
        public V GetFileAttributeView<V>(Java.Nio.File.Path arg0, Java.Lang.Class arg1, params Java.Nio.File.LinkOption[] arg2) where V : Java.Nio.File.Attribute.IFileAttributeView, new()
        {
            if (arg2.Length == 0) return IExecute<V>("getFileAttributeView", arg0, arg1); else return IExecute<V>("getFileAttributeView", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#isHidden(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool IsHidden(Java.Nio.File.Path arg0)
        {
            return IExecuteWithSignature<bool>("isHidden", "(Ljava/nio/file/Path;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#isSameFile(java.nio.file.Path,java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool IsSameFile(Java.Nio.File.Path arg0, Java.Nio.File.Path arg1)
        {
            return IExecuteWithSignature<bool>("isSameFile", "(Ljava/nio/file/Path;Ljava/nio/file/Path;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#newByteChannel(java.nio.file.Path,java.util.Set,java.nio.file.attribute.FileAttribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.Attribute.FileAttribute"/></param>
        /// <typeparam name="Arg1ExtendsJava_Nio_File_OpenOption"><see cref="Java.Nio.File.OpenOption"/></typeparam>
        /// <returns><see cref="Java.Nio.Channels.SeekableByteChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.SeekableByteChannel NewByteChannel<Arg1ExtendsJava_Nio_File_OpenOption>(Java.Nio.File.Path arg0, Java.Util.Set<Arg1ExtendsJava_Nio_File_OpenOption> arg1, params Java.Nio.File.Attribute.FileAttribute<object>[] arg2) where Arg1ExtendsJava_Nio_File_OpenOption : Java.Nio.File.OpenOption
        {
            if (arg2.Length == 0) return IExecuteWithSignature<Java.Nio.Channels.SeekableByteChannel>("newByteChannel", "(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;", arg0, arg1); else return IExecuteWithSignature<Java.Nio.Channels.SeekableByteChannel>("newByteChannel", "(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#newDirectoryStream(java.nio.file.Path,java.nio.file.DirectoryStream.Filter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.DirectoryStream.Filter"/></param>
        /// <typeparam name="Arg1objectSuperJava_Nio_File_Path"><see cref="Java.Nio.File.Path"/></typeparam>
        /// <returns><see cref="Java.Nio.File.DirectoryStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.DirectoryStream<Java.Nio.File.Path> NewDirectoryStream<Arg1objectSuperJava_Nio_File_Path>(Java.Nio.File.Path arg0, Java.Nio.File.DirectoryStream.Filter<Arg1objectSuperJava_Nio_File_Path> arg1) where Arg1objectSuperJava_Nio_File_Path : Java.Nio.File.Path
        {
            return IExecuteWithSignature<Java.Nio.File.DirectoryStream<Java.Nio.File.Path>>("newDirectoryStream", "(Ljava/nio/file/Path;Ljava/nio/file/DirectoryStream$Filter;)Ljava/nio/file/DirectoryStream;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#getFileStore(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Nio.File.FileStore"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileStore GetFileStore(Java.Nio.File.Path arg0)
        {
            return IExecuteWithSignature<Java.Nio.File.FileStore>("getFileStore", "(Ljava/nio/file/Path;)Ljava/nio/file/FileStore;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#getFileSystem(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Nio.File.FileSystem"/></returns>
        public Java.Nio.File.FileSystem GetFileSystem(Java.Net.URI arg0)
        {
            return IExecuteWithSignature<Java.Nio.File.FileSystem>("getFileSystem", "(Ljava/net/URI;)Ljava/nio/file/FileSystem;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#newFileSystem(java.net.URI,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Nio.File.FileSystem"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileSystem NewFileSystem(Java.Net.URI arg0, Java.Util.Map<Java.Lang.String, object> arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileSystem>("newFileSystem", "(Ljava/net/URI;Ljava/util/Map;)Ljava/nio/file/FileSystem;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#getPath(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path GetPath(Java.Net.URI arg0)
        {
            return IExecuteWithSignature<Java.Nio.File.Path>("getPath", "(Ljava/net/URI;)Ljava/nio/file/Path;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#readAttributes(java.nio.file.Path,java.lang.String,java.nio.file.LinkOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.LinkOption"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Map<Java.Lang.String, object> ReadAttributes(Java.Nio.File.Path arg0, Java.Lang.String arg1, params Java.Nio.File.LinkOption[] arg2)
        {
            if (arg2.Length == 0) return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("readAttributes", "(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Ljava/util/Map;", arg0, arg1); else return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("readAttributes", "(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Ljava/util/Map;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#checkAccess(java.nio.file.Path,java.nio.file.AccessMode[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.AccessMode"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void CheckAccess(Java.Nio.File.Path arg0, params Java.Nio.File.AccessMode[] arg1)
        {
            if (arg1.Length == 0) IExecuteWithSignature("checkAccess", "(Ljava/nio/file/Path;[Ljava/nio/file/AccessMode;)V", arg0); else IExecuteWithSignature("checkAccess", "(Ljava/nio/file/Path;[Ljava/nio/file/AccessMode;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#copy(java.nio.file.Path,java.nio.file.Path,java.nio.file.CopyOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.CopyOption"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Copy(Java.Nio.File.Path arg0, Java.Nio.File.Path arg1, params Java.Nio.File.CopyOption[] arg2)
        {
            if (arg2.Length == 0) IExecuteWithSignature("copy", "(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)V", arg0, arg1); else IExecuteWithSignature("copy", "(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#createDirectory(java.nio.file.Path,java.nio.file.attribute.FileAttribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Attribute.FileAttribute"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void CreateDirectory(Java.Nio.File.Path arg0, params Java.Nio.File.Attribute.FileAttribute<object>[] arg1)
        {
            if (arg1.Length == 0) IExecuteWithSignature("createDirectory", "(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)V", arg0); else IExecuteWithSignature("createDirectory", "(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#delete(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Delete(Java.Nio.File.Path arg0)
        {
            IExecuteWithSignature("delete", "(Ljava/nio/file/Path;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#move(java.nio.file.Path,java.nio.file.Path,java.nio.file.CopyOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.CopyOption"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Move(Java.Nio.File.Path arg0, Java.Nio.File.Path arg1, params Java.Nio.File.CopyOption[] arg2)
        {
            if (arg2.Length == 0) IExecuteWithSignature("move", "(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)V", arg0, arg1); else IExecuteWithSignature("move", "(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#setAttribute(java.nio.file.Path,java.lang.String,java.lang.Object,java.nio.file.LinkOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Nio.File.LinkOption"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetAttribute(Java.Nio.File.Path arg0, Java.Lang.String arg1, object arg2, params Java.Nio.File.LinkOption[] arg3)
        {
            if (arg3.Length == 0) IExecuteWithSignature("setAttribute", "(Ljava/nio/file/Path;Ljava/lang/String;Ljava/lang/Object;[Ljava/nio/file/LinkOption;)V", arg0, arg1, arg2); else IExecuteWithSignature("setAttribute", "(Ljava/nio/file/Path;Ljava/lang/String;Ljava/lang/Object;[Ljava/nio/file/LinkOption;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#deleteIfExists(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool DeleteIfExists(Java.Nio.File.Path arg0)
        {
            return IExecuteWithSignature<bool>("deleteIfExists", "(Ljava/nio/file/Path;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#newInputStream(java.nio.file.Path,java.nio.file.OpenOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.OpenOption"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream NewInputStream(Java.Nio.File.Path arg0, params Java.Nio.File.OpenOption[] arg1)
        {
            if (arg1.Length == 0) return IExecuteWithSignature<Java.Io.InputStream>("newInputStream", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/InputStream;", arg0); else return IExecuteWithSignature<Java.Io.InputStream>("newInputStream", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/InputStream;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#newOutputStream(java.nio.file.Path,java.nio.file.OpenOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.OpenOption"/></param>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.OutputStream NewOutputStream(Java.Nio.File.Path arg0, params Java.Nio.File.OpenOption[] arg1)
        {
            if (arg1.Length == 0) return IExecuteWithSignature<Java.Io.OutputStream>("newOutputStream", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/OutputStream;", arg0); else return IExecuteWithSignature<Java.Io.OutputStream>("newOutputStream", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/OutputStream;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#newAsynchronousFileChannel(java.nio.file.Path,java.util.Set,java.util.concurrent.ExecutorService,java.nio.file.attribute.FileAttribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.ExecutorService"/></param>
        /// <param name="arg3"><see cref="Java.Nio.File.Attribute.FileAttribute"/></param>
        /// <typeparam name="Arg1ExtendsJava_Nio_File_OpenOption"><see cref="Java.Nio.File.OpenOption"/></typeparam>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousFileChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.AsynchronousFileChannel NewAsynchronousFileChannel<Arg1ExtendsJava_Nio_File_OpenOption>(Java.Nio.File.Path arg0, Java.Util.Set<Arg1ExtendsJava_Nio_File_OpenOption> arg1, Java.Util.Concurrent.ExecutorService arg2, params Java.Nio.File.Attribute.FileAttribute<object>[] arg3) where Arg1ExtendsJava_Nio_File_OpenOption : Java.Nio.File.OpenOption
        {
            if (arg3.Length == 0) return IExecuteWithSignature<Java.Nio.Channels.AsynchronousFileChannel>("newAsynchronousFileChannel", "(Ljava/nio/file/Path;Ljava/util/Set;Ljava/util/concurrent/ExecutorService;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/AsynchronousFileChannel;", arg0, arg1, arg2); else return IExecuteWithSignature<Java.Nio.Channels.AsynchronousFileChannel>("newAsynchronousFileChannel", "(Ljava/nio/file/Path;Ljava/util/Set;Ljava/util/concurrent/ExecutorService;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/AsynchronousFileChannel;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#newFileChannel(java.nio.file.Path,java.util.Set,java.nio.file.attribute.FileAttribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.Attribute.FileAttribute"/></param>
        /// <typeparam name="Arg1ExtendsJava_Nio_File_OpenOption"><see cref="Java.Nio.File.OpenOption"/></typeparam>
        /// <returns><see cref="Java.Nio.Channels.FileChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.FileChannel NewFileChannel<Arg1ExtendsJava_Nio_File_OpenOption>(Java.Nio.File.Path arg0, Java.Util.Set<Arg1ExtendsJava_Nio_File_OpenOption> arg1, params Java.Nio.File.Attribute.FileAttribute<object>[] arg2) where Arg1ExtendsJava_Nio_File_OpenOption : Java.Nio.File.OpenOption
        {
            if (arg2.Length == 0) return IExecuteWithSignature<Java.Nio.Channels.FileChannel>("newFileChannel", "(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/FileChannel;", arg0, arg1); else return IExecuteWithSignature<Java.Nio.Channels.FileChannel>("newFileChannel", "(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/FileChannel;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#newFileSystem(java.nio.file.Path,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Nio.File.FileSystem"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileSystem NewFileSystem(Java.Nio.File.Path arg0, Java.Util.Map<Java.Lang.String, object> arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileSystem>("newFileSystem", "(Ljava/nio/file/Path;Ljava/util/Map;)Ljava/nio/file/FileSystem;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#readSymbolicLink(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.Path ReadSymbolicLink(Java.Nio.File.Path arg0)
        {
            return IExecuteWithSignature<Java.Nio.File.Path>("readSymbolicLink", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#createLink(java.nio.file.Path,java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Path"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void CreateLink(Java.Nio.File.Path arg0, Java.Nio.File.Path arg1)
        {
            IExecuteWithSignature("createLink", "(Ljava/nio/file/Path;Ljava/nio/file/Path;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#createSymbolicLink(java.nio.file.Path,java.nio.file.Path,java.nio.file.attribute.FileAttribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.Attribute.FileAttribute"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void CreateSymbolicLink(Java.Nio.File.Path arg0, Java.Nio.File.Path arg1, params Java.Nio.File.Attribute.FileAttribute<object>[] arg2)
        {
            if (arg2.Length == 0) IExecuteWithSignature("createSymbolicLink", "(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)V", arg0, arg1); else IExecuteWithSignature("createSymbolicLink", "(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)V", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}