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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File
{
    #region IPath
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPath
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getFileName()"/> 
        /// </summary>
        Java.Nio.File.Path FileName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getFileSystem()"/> 
        /// </summary>
        Java.Nio.File.FileSystem FileSystem { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getNameCount()"/> 
        /// </summary>
        int NameCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getParent()"/> 
        /// </summary>
        Java.Nio.File.Path Parent { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getRoot()"/> 
        /// </summary>
        Java.Nio.File.Path Root { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#endsWith(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="bool"/></returns>
        bool EndsWith(Java.Nio.File.Path arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#isAbsolute()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsAbsolute();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#startsWith(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="bool"/></returns>
        bool StartsWith(Java.Nio.File.Path arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#compareTo(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="int"/></returns>
        int CompareTo(Java.Nio.File.Path arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toUri()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URI"/></returns>
        Java.Net.URI ToUri();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path GetName(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#normalize()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path Normalize();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#relativize(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path Relativize(Java.Nio.File.Path arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolve(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path Resolve(Java.Nio.File.Path arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#subpath(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path Subpath(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toAbsolutePath()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path ToAbsolutePath();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toRealPath(java.nio.file.LinkOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.LinkOption"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.File.Path ToRealPath(params Java.Nio.File.LinkOption[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#register(java.nio.file.WatchService,java.nio.file.WatchEvent.Kind[],java.nio.file.WatchEvent.Modifier[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.WatchService"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.WatchEvent.Kind"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.WatchEvent.Modifier"/></param>
        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.File.WatchKey Register(Java.Nio.File.WatchService arg0, Java.Nio.File.WatchEvent.Kind<object>[] arg1, params Java.Nio.File.WatchEvent.Modifier[] arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#endsWith(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        bool EndsWith(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#startsWith(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        bool StartsWith(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        int CompareTo(object arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toFile()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        Java.Io.File ToFile();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolve(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path Resolve(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolveSibling(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path ResolveSibling(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolveSibling(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path ResolveSibling(Java.Nio.File.Path arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#register(java.nio.file.WatchService,java.nio.file.WatchEvent.Kind[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.WatchService"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.WatchEvent.Kind"/></param>
        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.File.WatchKey Register(Java.Nio.File.WatchService arg0, params Java.Nio.File.WatchEvent.Kind<object>[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        Java.Util.Iterator<Java.Nio.File.Path> Iterator();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Path
    public partial class Path : Java.Nio.File.IPath
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.Path"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Nio.File.Path t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.Path"/> to <see cref="Java.Nio.File.Watchable"/>
        /// </summary>
        public static implicit operator Java.Nio.File.Watchable(Java.Nio.File.Path t) => t.Cast<Java.Nio.File.Watchable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#of(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public static Java.Nio.File.Path Of(Java.Lang.String arg0, params Java.Lang.String[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Java.Nio.File.Path>(LocalBridgeClazz, "of", arg0); else return SExecute<Java.Nio.File.Path>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#of(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public static Java.Nio.File.Path Of(Java.Net.URI arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.Path>(LocalBridgeClazz, "of", "(Ljava/net/URI;)Ljava/nio/file/Path;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getFileName()"/> 
        /// </summary>
        public Java.Nio.File.Path FileName
        {
            get { return IExecuteWithSignature<Java.Nio.File.Path>("getFileName", "()Ljava/nio/file/Path;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getFileSystem()"/> 
        /// </summary>
        public Java.Nio.File.FileSystem FileSystem
        {
            get { return IExecuteWithSignature<Java.Nio.File.FileSystem>("getFileSystem", "()Ljava/nio/file/FileSystem;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getNameCount()"/> 
        /// </summary>
        public int NameCount
        {
            get { return IExecuteWithSignature<int>("getNameCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getParent()"/> 
        /// </summary>
        public Java.Nio.File.Path Parent
        {
            get { return IExecuteWithSignature<Java.Nio.File.Path>("getParent", "()Ljava/nio/file/Path;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getRoot()"/> 
        /// </summary>
        public Java.Nio.File.Path Root
        {
            get { return IExecuteWithSignature<Java.Nio.File.Path>("getRoot", "()Ljava/nio/file/Path;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#endsWith(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool EndsWith(Java.Nio.File.Path arg0)
        {
            return IExecuteWithSignature<bool>("endsWith", "(Ljava/nio/file/Path;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#isAbsolute()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAbsolute()
        {
            return IExecuteWithSignature<bool>("isAbsolute", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#startsWith(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool StartsWith(Java.Nio.File.Path arg0)
        {
            return IExecuteWithSignature<bool>("startsWith", "(Ljava/nio/file/Path;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#compareTo(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Nio.File.Path arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/nio/file/Path;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toUri()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI ToUri()
        {
            return IExecuteWithSignature<Java.Net.URI>("toUri", "()Ljava/net/URI;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path GetName(int arg0)
        {
            return IExecuteWithSignature<Java.Nio.File.Path>("getName", "(I)Ljava/nio/file/Path;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#normalize()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path Normalize()
        {
            return IExecuteWithSignature<Java.Nio.File.Path>("normalize", "()Ljava/nio/file/Path;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#relativize(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path Relativize(Java.Nio.File.Path arg0)
        {
            return IExecuteWithSignature<Java.Nio.File.Path>("relativize", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolve(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path Resolve(Java.Nio.File.Path arg0)
        {
            return IExecuteWithSignature<Java.Nio.File.Path>("resolve", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#subpath(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path Subpath(int arg0, int arg1)
        {
            return IExecute<Java.Nio.File.Path>("subpath", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toAbsolutePath()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path ToAbsolutePath()
        {
            return IExecuteWithSignature<Java.Nio.File.Path>("toAbsolutePath", "()Ljava/nio/file/Path;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toRealPath(java.nio.file.LinkOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.LinkOption"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.Path ToRealPath(params Java.Nio.File.LinkOption[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Java.Nio.File.Path>("toRealPath", "([Ljava/nio/file/LinkOption;)Ljava/nio/file/Path;"); else return IExecuteWithSignature<Java.Nio.File.Path>("toRealPath", "([Ljava/nio/file/LinkOption;)Ljava/nio/file/Path;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#register(java.nio.file.WatchService,java.nio.file.WatchEvent.Kind[],java.nio.file.WatchEvent.Modifier[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.WatchService"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.WatchEvent.Kind"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.WatchEvent.Modifier"/></param>
        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.WatchKey Register(Java.Nio.File.WatchService arg0, Java.Nio.File.WatchEvent.Kind<object>[] arg1, params Java.Nio.File.WatchEvent.Modifier[] arg2)
        {
            if (arg2.Length == 0) return IExecute<Java.Nio.File.WatchKey>("register", arg0, arg1); else return IExecute<Java.Nio.File.WatchKey>("register", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#endsWith(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool EndsWith(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("endsWith", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#startsWith(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool StartsWith(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("startsWith", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toFile()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File ToFile()
        {
            return IExecuteWithSignature<Java.Io.File>("toFile", "()Ljava/io/File;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolve(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path Resolve(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Nio.File.Path>("resolve", "(Ljava/lang/String;)Ljava/nio/file/Path;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolveSibling(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path ResolveSibling(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Nio.File.Path>("resolveSibling", "(Ljava/lang/String;)Ljava/nio/file/Path;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolveSibling(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path ResolveSibling(Java.Nio.File.Path arg0)
        {
            return IExecuteWithSignature<Java.Nio.File.Path>("resolveSibling", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#register(java.nio.file.WatchService,java.nio.file.WatchEvent.Kind[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.WatchService"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.WatchEvent.Kind"/></param>
        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.WatchKey Register(Java.Nio.File.WatchService arg0, params Java.Nio.File.WatchEvent.Kind<object>[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Nio.File.WatchKey>("register", arg0); else return IExecute<Java.Nio.File.WatchKey>("register", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<Java.Nio.File.Path> Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<Java.Nio.File.Path>>("iterator", "()Ljava/util/Iterator;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}