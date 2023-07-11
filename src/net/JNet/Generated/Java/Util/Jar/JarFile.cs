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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Jar
{
    #region JarFile
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
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public JarFile(string arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public JarFile(string arg0)
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
        public static string MANIFEST_NAME { get { return SGetField<string>(LocalBridgeClazz, "MANIFEST_NAME"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#baseVersion()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Runtime.Version"/></returns>
        public static Java.Lang.Runtime.Version BaseVersion()
        {
            return SExecute<Java.Lang.Runtime.Version>(LocalBridgeClazz, "baseVersion");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#runtimeVersion()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Runtime.Version"/></returns>
        public static Java.Lang.Runtime.Version RuntimeVersion()
        {
            return SExecute<Java.Lang.Runtime.Version>(LocalBridgeClazz, "runtimeVersion");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#getManifest()"/> 
        /// </summary>
        public Java.Util.Jar.Manifest Manifest
        {
            get { return IExecute<Java.Util.Jar.Manifest>("getManifest"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#getVersion()"/> 
        /// </summary>
        public Java.Lang.Runtime.Version Version
        {
            get { return IExecute<Java.Lang.Runtime.Version>("getVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#isMultiRelease()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMultiRelease()
        {
            return IExecute<bool>("isMultiRelease");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#getJarEntry(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Jar.JarEntry"/></returns>
        public Java.Util.Jar.JarEntry GetJarEntry(string arg0)
        {
            return IExecute<Java.Util.Jar.JarEntry>("getJarEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/JarFile.html#versionedStream()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Util.Jar.JarEntry> VersionedStream()
        {
            return IExecute<Java.Util.Stream.Stream<Java.Util.Jar.JarEntry>>("versionedStream");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}