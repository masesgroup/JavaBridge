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

namespace Java.Nio.File
{
    #region SimpleFileVisitor declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SimpleFileVisitor.html"/>
    /// </summary>
    public partial class SimpleFileVisitor : Java.Nio.File.FileVisitor
    {
        const string _bridgeClassName = "java.nio.file.SimpleFileVisitor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SimpleFileVisitor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SimpleFileVisitor(params object[] args) : base(args) { }

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

    #region SimpleFileVisitor<T> declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SimpleFileVisitor.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class SimpleFileVisitor<T> : Java.Nio.File.FileVisitor<T>
    {
        const string _bridgeClassName = "java.nio.file.SimpleFileVisitor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SimpleFileVisitor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SimpleFileVisitor(params object[] args) : base(args) { }

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

    #region SimpleFileVisitor implementation
    public partial class SimpleFileVisitor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SimpleFileVisitor.html#postVisitDirectory(java.lang.Object,java.io.IOException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Io.IOException"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult PostVisitDirectory(object arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("postVisitDirectory", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SimpleFileVisitor.html#preVisitDirectory(java.lang.Object,java.nio.file.attribute.BasicFileAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Attribute.BasicFileAttributes"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult PreVisitDirectory(object arg0, Java.Nio.File.Attribute.BasicFileAttributes arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("preVisitDirectory", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SimpleFileVisitor.html#visitFile(java.lang.Object,java.nio.file.attribute.BasicFileAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Attribute.BasicFileAttributes"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult VisitFile(object arg0, Java.Nio.File.Attribute.BasicFileAttributes arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("visitFile", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SimpleFileVisitor.html#visitFileFailed(java.lang.Object,java.io.IOException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Io.IOException"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult VisitFileFailed(object arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("visitFileFailed", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SimpleFileVisitor<T> implementation
    public partial class SimpleFileVisitor<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.SimpleFileVisitor{T}"/> to <see cref="Java.Nio.File.SimpleFileVisitor"/>
        /// </summary>
        public static implicit operator Java.Nio.File.SimpleFileVisitor(Java.Nio.File.SimpleFileVisitor<T> t) => t.Cast<Java.Nio.File.SimpleFileVisitor>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SimpleFileVisitor.html#postVisitDirectory(java.lang.Object,java.io.IOException)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Io.IOException"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult PostVisitDirectory(T arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("postVisitDirectory", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SimpleFileVisitor.html#preVisitDirectory(java.lang.Object,java.nio.file.attribute.BasicFileAttributes)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Attribute.BasicFileAttributes"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult PreVisitDirectory(T arg0, Java.Nio.File.Attribute.BasicFileAttributes arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("preVisitDirectory", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SimpleFileVisitor.html#visitFile(java.lang.Object,java.nio.file.attribute.BasicFileAttributes)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Attribute.BasicFileAttributes"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult VisitFile(T arg0, Java.Nio.File.Attribute.BasicFileAttributes arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("visitFile", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/SimpleFileVisitor.html#visitFileFailed(java.lang.Object,java.io.IOException)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Io.IOException"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult VisitFileFailed(T arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("visitFileFailed", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}