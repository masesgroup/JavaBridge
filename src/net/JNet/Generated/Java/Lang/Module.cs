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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Module
    public partial class Module
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getAnnotations()"/> 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] Annotations
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Annotation.Annotation>("getAnnotations", "()[Ljava/lang/annotation/Annotation;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getClassLoader()"/> 
        /// </summary>
        public Java.Lang.ClassLoader ClassLoader
        {
            get { return IExecuteWithSignature<Java.Lang.ClassLoader>("getClassLoader", "()Ljava/lang/ClassLoader;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getDeclaredAnnotations()"/> 
        /// </summary>
        public Java.Lang.Annotation.Annotation[] DeclaredAnnotations
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Annotation.Annotation>("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getDescriptor()"/> 
        /// </summary>
        public Java.Lang.ModuleNs.ModuleDescriptor Descriptor
        {
            get { return IExecuteWithSignature<Java.Lang.ModuleNs.ModuleDescriptor>("getDescriptor", "()Ljava/lang/module/ModuleDescriptor;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getLayer()"/> 
        /// </summary>
        public Java.Lang.ModuleLayer Layer
        {
            get { return IExecuteWithSignature<Java.Lang.ModuleLayer>("getLayer", "()Ljava/lang/ModuleLayer;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getPackages()"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.String> Packages
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getPackages", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetAnnotation<T>(Java.Lang.Class arg0) where T : Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecute<T>("getAnnotation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#canRead(java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanRead(Java.Lang.Module arg0)
        {
            return IExecuteWithSignature<bool>("canRead", "(Ljava/lang/Module;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#canUse(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanUse(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<bool>("canUse", "(Ljava/lang/Class;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#isExported(java.lang.String,java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsExported(Java.Lang.String arg0, Java.Lang.Module arg1)
        {
            return IExecute<bool>("isExported", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#isExported(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsExported(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isExported", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#isNamed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNamed()
        {
            return IExecuteWithSignature<bool>("isNamed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#isOpen(java.lang.String,java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpen(Java.Lang.String arg0, Java.Lang.Module arg1)
        {
            return IExecute<bool>("isOpen", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#isOpen(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpen(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isOpen", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#getResourceAsStream(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream GetResourceAsStream(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#addExports(java.lang.String,java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="Java.Lang.Module"/></returns>
        public Java.Lang.Module AddExports(Java.Lang.String arg0, Java.Lang.Module arg1)
        {
            return IExecute<Java.Lang.Module>("addExports", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#addOpens(java.lang.String,java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="Java.Lang.Module"/></returns>
        public Java.Lang.Module AddOpens(Java.Lang.String arg0, Java.Lang.Module arg1)
        {
            return IExecute<Java.Lang.Module>("addOpens", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#addReads(java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="Java.Lang.Module"/></returns>
        public Java.Lang.Module AddReads(Java.Lang.Module arg0)
        {
            return IExecuteWithSignature<Java.Lang.Module>("addReads", "(Ljava/lang/Module;)Ljava/lang/Module;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Module.html#addUses(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Module"/></returns>
        public Java.Lang.Module AddUses(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<Java.Lang.Module>("addUses", "(Ljava/lang/Class;)Ljava/lang/Module;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}