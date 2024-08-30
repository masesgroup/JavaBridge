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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Io
{
    #region File definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html"/>
    /// </summary>
    public partial class File : MASES.JCOBridge.C2JBridge.JVMBridgeBase<File>
    {
        const string _bridgeClassName = "java.io.File";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public File() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public File(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
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

    #region File
    public partial class File
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#%3Cinit%3E(java.io.File,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public File(Java.Io.File arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public File(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public File(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#%3Cinit%3E(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        public File(Java.Net.URI arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Io.File"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Io.File t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Io.File"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Io.File t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#pathSeparatorChar"/>
        /// </summary>
        public static char pathSeparatorChar { get { if (!_pathSeparatorCharReady) { _pathSeparatorCharContent = SGetField<char>(LocalBridgeClazz, "pathSeparatorChar"); _pathSeparatorCharReady = true; } return _pathSeparatorCharContent; } }
        private static char _pathSeparatorCharContent = default;
        private static bool _pathSeparatorCharReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#separatorChar"/>
        /// </summary>
        public static char separatorChar { get { if (!_separatorCharReady) { _separatorCharContent = SGetField<char>(LocalBridgeClazz, "separatorChar"); _separatorCharReady = true; } return _separatorCharContent; } }
        private static char _separatorCharContent = default;
        private static bool _separatorCharReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#pathSeparator"/>
        /// </summary>
        public static Java.Lang.String pathSeparator { get { if (!_pathSeparatorReady) { _pathSeparatorContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "pathSeparator"); _pathSeparatorReady = true; } return _pathSeparatorContent; } }
        private static Java.Lang.String _pathSeparatorContent = default;
        private static bool _pathSeparatorReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#separator"/>
        /// </summary>
        public static Java.Lang.String separator { get { if (!_separatorReady) { _separatorContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "separator"); _separatorReady = true; } return _separatorContent; } }
        private static Java.Lang.String _separatorContent = default;
        private static bool _separatorReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#createTempFile(java.lang.String,java.lang.String,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Io.File CreateTempFile(Java.Lang.String arg0, Java.Lang.String arg1, Java.Io.File arg2)
        {
            return SExecute<Java.Io.File>(LocalBridgeClazz, "createTempFile", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#createTempFile(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Io.File CreateTempFile(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Io.File>(LocalBridgeClazz, "createTempFile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#listRoots()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public static Java.Io.File[] ListRoots()
        {
            return SExecuteWithSignatureArray<Java.Io.File>(LocalBridgeClazz, "listRoots", "()[Ljava/io/File;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getAbsoluteFile()"/> 
        /// </summary>
        public Java.Io.File AbsoluteFile
        {
            get { return IExecuteWithSignature<Java.Io.File>("getAbsoluteFile", "()Ljava/io/File;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getAbsolutePath()"/> 
        /// </summary>
        public Java.Lang.String AbsolutePath
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAbsolutePath", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getCanonicalFile()"/> 
        /// </summary>
        public Java.Io.File CanonicalFile
        {
            get { return IExecuteWithSignature<Java.Io.File>("getCanonicalFile", "()Ljava/io/File;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getCanonicalPath()"/> 
        /// </summary>
        public Java.Lang.String CanonicalPath
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCanonicalPath", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getFreeSpace()"/> 
        /// </summary>
        public long FreeSpace
        {
            get { return IExecuteWithSignature<long>("getFreeSpace", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getParent()"/> 
        /// </summary>
        public Java.Lang.String Parent
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getParent", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getParentFile()"/> 
        /// </summary>
        public Java.Io.File ParentFile
        {
            get { return IExecuteWithSignature<Java.Io.File>("getParentFile", "()Ljava/io/File;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getPath()"/> 
        /// </summary>
        public Java.Lang.String Path
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPath", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getTotalSpace()"/> 
        /// </summary>
        public long TotalSpace
        {
            get { return IExecuteWithSignature<long>("getTotalSpace", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getUsableSpace()"/> 
        /// </summary>
        public long UsableSpace
        {
            get { return IExecuteWithSignature<long>("getUsableSpace", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#canExecute()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanExecute()
        {
            return IExecuteWithSignature<bool>("canExecute", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#canRead()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanRead()
        {
            return IExecuteWithSignature<bool>("canRead", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#canWrite()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanWrite()
        {
            return IExecuteWithSignature<bool>("canWrite", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#createNewFile()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CreateNewFile()
        {
            return IExecuteWithSignature<bool>("createNewFile", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#delete()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Delete()
        {
            return IExecuteWithSignature<bool>("delete", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#exists()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Exists()
        {
            return IExecuteWithSignature<bool>("exists", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#isAbsolute()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAbsolute()
        {
            return IExecuteWithSignature<bool>("isAbsolute", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#isDirectory()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDirectory()
        {
            return IExecuteWithSignature<bool>("isDirectory", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#isFile()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFile()
        {
            return IExecuteWithSignature<bool>("isFile", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#isHidden()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsHidden()
        {
            return IExecuteWithSignature<bool>("isHidden", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#mkdir()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Mkdir()
        {
            return IExecuteWithSignature<bool>("mkdir", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#mkdirs()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Mkdirs()
        {
            return IExecuteWithSignature<bool>("mkdirs", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#renameTo(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RenameTo(Java.Io.File arg0)
        {
            return IExecuteWithSignature<bool>("renameTo", "(Ljava/io/File;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setExecutable(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetExecutable(bool arg0, bool arg1)
        {
            return IExecute<bool>("setExecutable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setExecutable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetExecutable(bool arg0)
        {
            return IExecuteWithSignature<bool>("setExecutable", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setLastModified(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetLastModified(long arg0)
        {
            return IExecuteWithSignature<bool>("setLastModified", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setReadable(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetReadable(bool arg0, bool arg1)
        {
            return IExecute<bool>("setReadable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setReadable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetReadable(bool arg0)
        {
            return IExecuteWithSignature<bool>("setReadable", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setReadOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SetReadOnly()
        {
            return IExecuteWithSignature<bool>("setReadOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setWritable(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetWritable(bool arg0, bool arg1)
        {
            return IExecute<bool>("setWritable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setWritable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetWritable(bool arg0)
        {
            return IExecuteWithSignature<bool>("setWritable", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#compareTo(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Io.File arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/io/File;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#listFiles()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File[] ListFiles()
        {
            return IExecuteWithSignatureArray<Java.Io.File>("listFiles", "()[Ljava/io/File;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#listFiles(java.io.FileFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileFilter"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File[] ListFiles(Java.Io.FileFilter arg0)
        {
            return IExecuteWithSignatureArray<Java.Io.File>("listFiles", "(Ljava/io/FileFilter;)[Ljava/io/File;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#listFiles(java.io.FilenameFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FilenameFilter"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File[] ListFiles(Java.Io.FilenameFilter arg0)
        {
            return IExecuteWithSignatureArray<Java.Io.File>("listFiles", "(Ljava/io/FilenameFilter;)[Ljava/io/File;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#list()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] List()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("list", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#list(java.io.FilenameFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FilenameFilter"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] List(Java.Io.FilenameFilter arg0)
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("list", "(Ljava/io/FilenameFilter;)[Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#toURI()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI ToURI()
        {
            return IExecuteWithSignature<Java.Net.URI>("toURI", "()Ljava/net/URI;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#toPath()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path ToPath()
        {
            return IExecuteWithSignature<Java.Nio.File.Path>("toPath", "()Ljava/nio/file/Path;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#lastModified()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long LastModified()
        {
            return IExecuteWithSignature<long>("lastModified", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#length()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Length()
        {
            return IExecuteWithSignature<long>("length", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#deleteOnExit()"/>
        /// </summary>
        public void DeleteOnExit()
        {
            IExecuteWithSignature("deleteOnExit", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}