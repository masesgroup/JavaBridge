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

namespace Java.Util
{
    #region Formatter declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html"/>
    /// </summary>
    public partial class Formatter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Formatter>
    {
        const string _bridgeClassName = "java.util.Formatter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Formatter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Formatter(params object[] args) : base(args) { }

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
        public override bool IsBridgeCloseable => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region BigDecimalLayoutForm declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.BigDecimalLayoutForm.html"/>
        /// </summary>
        public partial class BigDecimalLayoutForm : Java.Lang.Enum<Java.Util.Formatter.BigDecimalLayoutForm>
        {
            const string _bridgeClassName = "java.util.Formatter$BigDecimalLayoutForm";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public BigDecimalLayoutForm() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public BigDecimalLayoutForm(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region Formatter implementation
    public partial class Formatter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.io.File,java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Java.Io.UnsupportedEncodingException"/>
        public Formatter(Java.Io.File arg0, Java.Lang.String arg1, Java.Util.Locale arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.io.File,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Java.Io.UnsupportedEncodingException"/>
        public Formatter(Java.Io.File arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.io.File,java.nio.charset.Charset,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Formatter(Java.Io.File arg0, Java.Nio.Charset.Charset arg1, Java.Util.Locale arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Formatter(Java.Io.File arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.io.OutputStream,java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        /// <exception cref="Java.Io.UnsupportedEncodingException"/>
        public Formatter(Java.Io.OutputStream arg0, Java.Lang.String arg1, Java.Util.Locale arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.io.OutputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.UnsupportedEncodingException"/>
        public Formatter(Java.Io.OutputStream arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.io.OutputStream,java.nio.charset.Charset,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        public Formatter(Java.Io.OutputStream arg0, Java.Nio.Charset.Charset arg1, Java.Util.Locale arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        public Formatter(Java.Io.OutputStream arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.io.PrintStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintStream"/></param>
        public Formatter(Java.Io.PrintStream arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.lang.Appendable,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Appendable"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        public Formatter(Java.Lang.Appendable arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.lang.Appendable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Appendable"/></param>
        public Formatter(Java.Lang.Appendable arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.lang.String,java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Java.Io.UnsupportedEncodingException"/>
        public Formatter(Java.Lang.String arg0, Java.Lang.String arg1, Java.Util.Locale arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Java.Io.UnsupportedEncodingException"/>
        public Formatter(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.lang.String,java.nio.charset.Charset,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Formatter(Java.Lang.String arg0, Java.Nio.Charset.Charset arg1, Java.Util.Locale arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Formatter(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public Formatter(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Formatter"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Util.Formatter t) => t.Cast<Java.Io.Closeable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Formatter"/> to <see cref="Java.Io.Flushable"/>
        /// </summary>
        public static implicit operator Java.Io.Flushable(Java.Util.Formatter t) => t.Cast<Java.Io.Flushable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#ioException()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.IOException"/></returns>
        public Java.Io.IOException IoException()
        {
            var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("ioException", "()Ljava/io/IOException;"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Io.IOException>(obj);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#out()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Appendable"/></returns>
        public Java.Lang.Appendable Out()
        {
            return IExecuteWithSignature<Java.Lang.Appendable>("out", "()Ljava/lang/Appendable;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#format(java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Formatter"/></returns>
        public Java.Util.Formatter Format(Java.Lang.String arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return IExecuteWithSignature<Java.Util.Formatter>("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;", arg0); else return IExecuteWithSignature<Java.Util.Formatter>("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#format(java.util.Locale,java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Formatter"/></returns>
        public Java.Util.Formatter Format(Java.Util.Locale arg0, Java.Lang.String arg1, params object[] arg2)
        {
            if (arg2.Length == 0) return IExecuteWithSignature<Java.Util.Formatter>("format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;", arg0, arg1); else return IExecuteWithSignature<Java.Util.Formatter>("format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#locale()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public Java.Util.Locale Locale()
        {
            return IExecuteWithSignature<Java.Util.Locale>("locale", "()Ljava/util/Locale;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }

        #endregion

        #region Nested classes
        #region BigDecimalLayoutForm implementation
        public partial class BigDecimalLayoutForm
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.BigDecimalLayoutForm.html#DECIMAL_FLOAT"/>
            /// </summary>
            public static Java.Util.Formatter.BigDecimalLayoutForm DECIMAL_FLOAT { get { if (!_DECIMAL_FLOATReady) { _DECIMAL_FLOATContent = SGetField<Java.Util.Formatter.BigDecimalLayoutForm>(LocalBridgeClazz, "DECIMAL_FLOAT"); _DECIMAL_FLOATReady = true; } return _DECIMAL_FLOATContent; } }
            private static Java.Util.Formatter.BigDecimalLayoutForm _DECIMAL_FLOATContent = default;
            private static bool _DECIMAL_FLOATReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.BigDecimalLayoutForm.html#SCIENTIFIC"/>
            /// </summary>
            public static Java.Util.Formatter.BigDecimalLayoutForm SCIENTIFIC { get { if (!_SCIENTIFICReady) { _SCIENTIFICContent = SGetField<Java.Util.Formatter.BigDecimalLayoutForm>(LocalBridgeClazz, "SCIENTIFIC"); _SCIENTIFICReady = true; } return _SCIENTIFICContent; } }
            private static Java.Util.Formatter.BigDecimalLayoutForm _SCIENTIFICContent = default;
            private static bool _SCIENTIFICReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.BigDecimalLayoutForm.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Util.Formatter.BigDecimalLayoutForm"/></returns>
            public static Java.Util.Formatter.BigDecimalLayoutForm ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Util.Formatter.BigDecimalLayoutForm>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/util/Formatter$BigDecimalLayoutForm;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.BigDecimalLayoutForm.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Formatter.BigDecimalLayoutForm"/></returns>
            public static Java.Util.Formatter.BigDecimalLayoutForm[] Values()
            {
                return SExecuteWithSignatureArray<Java.Util.Formatter.BigDecimalLayoutForm>(LocalBridgeClazz, "values", "()[Ljava/util/Formatter$BigDecimalLayoutForm;");
            }

            #endregion

            #region Instance methods

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