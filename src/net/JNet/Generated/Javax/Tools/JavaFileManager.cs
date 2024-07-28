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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Tools
{
    #region IJavaFileManager
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IJavaFileManager
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#handleOption(java.lang.String,java.util.Iterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Iterator"/></param>
        /// <returns><see cref="bool"/></returns>
        bool HandleOption(Java.Lang.String arg0, Java.Util.Iterator<Java.Lang.String> arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#hasLocation(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="bool"/></returns>
        bool HasLocation(Javax.Tools.JavaFileManager.Location arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#isSameFile(javax.tools.FileObject,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.FileObject"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsSameFile(Javax.Tools.FileObject arg0, Javax.Tools.FileObject arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getClassLoader(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="Java.Lang.ClassLoader"/></returns>
        Java.Lang.ClassLoader GetClassLoader(Javax.Tools.JavaFileManager.Location arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#list(javax.tools.JavaFileManager.Location,java.lang.String,java.util.Set,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Set"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Lang.Iterable<Javax.Tools.JavaFileObject> List(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Java.Util.Set<Javax.Tools.JavaFileObject.Kind> arg2, bool arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#inferBinaryName(javax.tools.JavaFileManager.Location,javax.tools.JavaFileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String InferBinaryName(Javax.Tools.JavaFileManager.Location arg0, Javax.Tools.JavaFileObject arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getFileForInput(javax.tools.JavaFileManager.Location,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Tools.FileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Javax.Tools.FileObject GetFileForInput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Java.Lang.String arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getFileForOutput(javax.tools.JavaFileManager.Location,java.lang.String,java.lang.String,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="Javax.Tools.FileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Javax.Tools.FileObject GetFileForOutput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Java.Lang.String arg2, Javax.Tools.FileObject arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getJavaFileForInput(javax.tools.JavaFileManager.Location,java.lang.String,javax.tools.JavaFileObject.Kind)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Javax.Tools.JavaFileObject GetJavaFileForInput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Javax.Tools.JavaFileObject.Kind arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getJavaFileForOutput(javax.tools.JavaFileManager.Location,java.lang.String,javax.tools.JavaFileObject.Kind,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <param name="arg3"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Javax.Tools.JavaFileObject GetJavaFileForOutput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Javax.Tools.JavaFileObject.Kind arg2, Javax.Tools.FileObject arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        void Close();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#flush()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        void Flush();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getServiceLoader(javax.tools.JavaFileManager.Location,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="S"></typeparam>
        /// <returns><see cref="Java.Util.ServiceLoader"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Util.ServiceLoader<S> GetServiceLoader<S>(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.Class arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#contains(javax.tools.JavaFileManager.Location,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        bool Contains(Javax.Tools.JavaFileManager.Location arg0, Javax.Tools.FileObject arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#listLocationsForModules(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Lang.Iterable<Java.Util.Set<Javax.Tools.JavaFileManager.Location>> ListLocationsForModules(Javax.Tools.JavaFileManager.Location arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#inferModuleName(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Lang.String InferModuleName(Javax.Tools.JavaFileManager.Location arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getLocationForModule(javax.tools.JavaFileManager.Location,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileManager.Location"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Javax.Tools.JavaFileManager.Location GetLocationForModule(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getLocationForModule(javax.tools.JavaFileManager.Location,javax.tools.JavaFileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileManager.Location"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Javax.Tools.JavaFileManager.Location GetLocationForModule(Javax.Tools.JavaFileManager.Location arg0, Javax.Tools.JavaFileObject arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region JavaFileManager
    public partial class JavaFileManager : Javax.Tools.IJavaFileManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Tools.JavaFileManager"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Javax.Tools.JavaFileManager t) => t.Cast<Java.Io.Closeable>();
        /// <summary>
        /// Converter from <see cref="Javax.Tools.JavaFileManager"/> to <see cref="Java.Io.Flushable"/>
        /// </summary>
        public static implicit operator Java.Io.Flushable(Javax.Tools.JavaFileManager t) => t.Cast<Java.Io.Flushable>();
        /// <summary>
        /// Converter from <see cref="Javax.Tools.JavaFileManager"/> to <see cref="Javax.Tools.OptionChecker"/>
        /// </summary>
        public static implicit operator Javax.Tools.OptionChecker(Javax.Tools.JavaFileManager t) => t.Cast<Javax.Tools.OptionChecker>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#handleOption(java.lang.String,java.util.Iterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Iterator"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HandleOption(Java.Lang.String arg0, Java.Util.Iterator<Java.Lang.String> arg1)
        {
            return IExecute<bool>("handleOption", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#hasLocation(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasLocation(Javax.Tools.JavaFileManager.Location arg0)
        {
            return IExecuteWithSignature<bool>("hasLocation", "(Ljavax/tools/JavaFileManager$Location;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#isSameFile(javax.tools.FileObject,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.FileObject"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSameFile(Javax.Tools.FileObject arg0, Javax.Tools.FileObject arg1)
        {
            return IExecute<bool>("isSameFile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getClassLoader(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="Java.Lang.ClassLoader"/></returns>
        public Java.Lang.ClassLoader GetClassLoader(Javax.Tools.JavaFileManager.Location arg0)
        {
            return IExecuteWithSignature<Java.Lang.ClassLoader>("getClassLoader", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/ClassLoader;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#list(javax.tools.JavaFileManager.Location,java.lang.String,java.util.Set,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Set"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Iterable<Javax.Tools.JavaFileObject> List(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Java.Util.Set<Javax.Tools.JavaFileObject.Kind> arg2, bool arg3)
        {
            return IExecute<Java.Lang.Iterable<Javax.Tools.JavaFileObject>>("list", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#inferBinaryName(javax.tools.JavaFileManager.Location,javax.tools.JavaFileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String InferBinaryName(Javax.Tools.JavaFileManager.Location arg0, Javax.Tools.JavaFileObject arg1)
        {
            return IExecute<Java.Lang.String>("inferBinaryName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getFileForInput(javax.tools.JavaFileManager.Location,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Tools.FileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.FileObject GetFileForInput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecute<Javax.Tools.FileObject>("getFileForInput", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getFileForOutput(javax.tools.JavaFileManager.Location,java.lang.String,java.lang.String,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="Javax.Tools.FileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.FileObject GetFileForOutput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Java.Lang.String arg2, Javax.Tools.FileObject arg3)
        {
            return IExecute<Javax.Tools.FileObject>("getFileForOutput", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getJavaFileForInput(javax.tools.JavaFileManager.Location,java.lang.String,javax.tools.JavaFileObject.Kind)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.JavaFileObject GetJavaFileForInput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Javax.Tools.JavaFileObject.Kind arg2)
        {
            return IExecute<Javax.Tools.JavaFileObject>("getJavaFileForInput", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getJavaFileForOutput(javax.tools.JavaFileManager.Location,java.lang.String,javax.tools.JavaFileObject.Kind,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <param name="arg3"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.JavaFileObject GetJavaFileForOutput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Javax.Tools.JavaFileObject.Kind arg2, Javax.Tools.FileObject arg3)
        {
            return IExecute<Javax.Tools.JavaFileObject>("getJavaFileForOutput", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#flush()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getServiceLoader(javax.tools.JavaFileManager.Location,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="S"></typeparam>
        /// <returns><see cref="Java.Util.ServiceLoader"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.ServiceLoader<S> GetServiceLoader<S>(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.Class arg1)
        {
            return IExecute<Java.Util.ServiceLoader<S>>("getServiceLoader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#contains(javax.tools.JavaFileManager.Location,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool Contains(Javax.Tools.JavaFileManager.Location arg0, Javax.Tools.FileObject arg1)
        {
            return IExecute<bool>("contains", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#listLocationsForModules(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Iterable<Java.Util.Set<Javax.Tools.JavaFileManager.Location>> ListLocationsForModules(Javax.Tools.JavaFileManager.Location arg0)
        {
            return IExecuteWithSignature<Java.Lang.Iterable<Java.Util.Set<Javax.Tools.JavaFileManager.Location>>>("listLocationsForModules", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#inferModuleName(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String InferModuleName(Javax.Tools.JavaFileManager.Location arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("inferModuleName", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getLocationForModule(javax.tools.JavaFileManager.Location,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileManager.Location"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.JavaFileManager.Location GetLocationForModule(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Tools.JavaFileManager.Location>("getLocationForModule", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.html#getLocationForModule(javax.tools.JavaFileManager.Location,javax.tools.JavaFileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileManager.Location"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.JavaFileManager.Location GetLocationForModule(Javax.Tools.JavaFileManager.Location arg0, Javax.Tools.JavaFileObject arg1)
        {
            return IExecute<Javax.Tools.JavaFileManager.Location>("getLocationForModule", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Location
        public partial class Location
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.Location.html#getName()"/> 
            /// </summary>
            public Java.Lang.String Name
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.Location.html#isOutputLocation()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsOutputLocation()
            {
                return IExecuteWithSignature<bool>("isOutputLocation", "()Z");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileManager.Location.html#isModuleOrientedLocation()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsModuleOrientedLocation()
            {
                return IExecuteWithSignature<bool>("isModuleOrientedLocation", "()Z");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}