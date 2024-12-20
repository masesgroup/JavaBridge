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

namespace Java.Util.Jar
{
    #region JarFile declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html"/>
    /// </summary>
    public partial class JarFile : Java.Util.Zip.ZipFile
    {
        const string _bridgeClassName = "java.util.jar.JarFile";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JarFile() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JarFile(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region JarFile implementation
    public partial class JarFile
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#%3Cinit%3E(java.io.File,boolean,int,java.lang.Runtime.Version)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Runtime.Version"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public JarFile(Java.Io.File arg0, bool arg1, int arg2, Java.Lang.Runtime.Version arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#%3Cinit%3E(java.io.File,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public JarFile(Java.Io.File arg0, bool arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#%3Cinit%3E(java.io.File,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public JarFile(Java.Io.File arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#%3Cinit%3E(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public JarFile(Java.Io.File arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#%3Cinit%3E(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public JarFile(Java.Lang.String arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public JarFile(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#MANIFEST_NAME"/>
        /// </summary>
        public static Java.Lang.String MANIFEST_NAME { get { if (!_MANIFEST_NAMEReady) { _MANIFEST_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MANIFEST_NAME"); _MANIFEST_NAMEReady = true; } return _MANIFEST_NAMEContent; } }
        private static Java.Lang.String _MANIFEST_NAMEContent = default;
        private static bool _MANIFEST_NAMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#baseVersion()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Runtime.Version"/></returns>
        public static Java.Lang.Runtime.Version BaseVersion()
        {
            return SExecuteWithSignature<Java.Lang.Runtime.Version>(LocalBridgeClazz, "baseVersion", "()Ljava/lang/Runtime$Version;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#runtimeVersion()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Runtime.Version"/></returns>
        public static Java.Lang.Runtime.Version RuntimeVersion()
        {
            return SExecuteWithSignature<Java.Lang.Runtime.Version>(LocalBridgeClazz, "runtimeVersion", "()Ljava/lang/Runtime$Version;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#getManifest()"/> 
        /// </summary>
        public Java.Util.Jar.Manifest Manifest
        {
            get { return IExecuteWithSignature<Java.Util.Jar.Manifest>("getManifest", "()Ljava/util/jar/Manifest;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#getVersion()"/> 
        /// </summary>
        public Java.Lang.Runtime.Version Version
        {
            get { return IExecuteWithSignature<Java.Lang.Runtime.Version>("getVersion", "()Ljava/lang/Runtime$Version;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#isMultiRelease()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMultiRelease()
        {
            return IExecuteWithSignature<bool>("isMultiRelease", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#getJarEntry(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Jar.JarEntry"/></returns>
        public Java.Util.Jar.JarEntry GetJarEntry(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Jar.JarEntry>("getJarEntry", "(Ljava/lang/String;)Ljava/util/jar/JarEntry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#versionedStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Util.Jar.JarEntry> VersionedStream()
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Util.Jar.JarEntry>>("versionedStream", "()Ljava/util/stream/Stream;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}