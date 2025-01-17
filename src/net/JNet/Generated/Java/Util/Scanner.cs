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
    #region Scanner declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html"/>
    /// </summary>
    public partial class Scanner : Java.Util.Iterator<Java.Lang.String>
    {
        const string _bridgeClassName = "java.util.Scanner";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Scanner() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Scanner(params object[] args) : base(args) { }

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

    }
    #endregion

    #region Scanner implementation
    public partial class Scanner
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.io.File,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Scanner(Java.Io.File arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.io.File,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Scanner(Java.Io.File arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Scanner(Java.Io.File arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.io.InputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public Scanner(Java.Io.InputStream arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.io.InputStream,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        public Scanner(Java.Io.InputStream arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        public Scanner(Java.Io.InputStream arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.lang.Readable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Readable"/></param>
        public Scanner(Java.Lang.Readable arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public Scanner(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.nio.channels.ReadableByteChannel,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.ReadableByteChannel"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public Scanner(Java.Nio.Channels.ReadableByteChannel arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.nio.channels.ReadableByteChannel,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.ReadableByteChannel"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        public Scanner(Java.Nio.Channels.ReadableByteChannel arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.nio.channels.ReadableByteChannel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.ReadableByteChannel"/></param>
        public Scanner(Java.Nio.Channels.ReadableByteChannel arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.nio.file.Path,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Scanner(Java.Nio.File.Path arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.nio.file.Path,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Scanner(Java.Nio.File.Path arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Scanner(Java.Nio.File.Path arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Scanner"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Util.Scanner t) => t.Cast<Java.Io.Closeable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNext()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNext()
        {
            return IExecuteWithSignature<bool>("hasNext", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNext(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasNext(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("hasNext", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNext(java.util.regex.Pattern)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasNext(Java.Util.Regex.Pattern arg0)
        {
            return IExecuteWithSignature<bool>("hasNext", "(Ljava/util/regex/Pattern;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextBigDecimal()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextBigDecimal()
        {
            return IExecuteWithSignature<bool>("hasNextBigDecimal", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextBigInteger()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextBigInteger()
        {
            return IExecuteWithSignature<bool>("hasNextBigInteger", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextBigInteger(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextBigInteger(int arg0)
        {
            return IExecuteWithSignature<bool>("hasNextBigInteger", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextBoolean()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextBoolean()
        {
            return IExecuteWithSignature<bool>("hasNextBoolean", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextByte()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextByte()
        {
            return IExecuteWithSignature<bool>("hasNextByte", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextByte(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextByte(int arg0)
        {
            return IExecuteWithSignature<bool>("hasNextByte", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextDouble()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextDouble()
        {
            return IExecuteWithSignature<bool>("hasNextDouble", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextFloat()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextFloat()
        {
            return IExecuteWithSignature<bool>("hasNextFloat", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextInt()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextInt()
        {
            return IExecuteWithSignature<bool>("hasNextInt", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextInt(int arg0)
        {
            return IExecuteWithSignature<bool>("hasNextInt", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextLine()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextLine()
        {
            return IExecuteWithSignature<bool>("hasNextLine", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextLong()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextLong()
        {
            return IExecuteWithSignature<bool>("hasNextLong", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextLong(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextLong(int arg0)
        {
            return IExecuteWithSignature<bool>("hasNextLong", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextShort()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextShort()
        {
            return IExecuteWithSignature<bool>("hasNextShort", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextShort(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasNextShort(int arg0)
        {
            return IExecuteWithSignature<bool>("hasNextShort", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextBoolean()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool NextBoolean()
        {
            return IExecuteWithSignature<bool>("nextBoolean", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextByte()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte NextByte()
        {
            return IExecuteWithSignature<byte>("nextByte", "()B");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextByte(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte NextByte(int arg0)
        {
            return IExecuteWithSignature<byte>("nextByte", "(I)B", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextDouble()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double NextDouble()
        {
            return IExecuteWithSignature<double>("nextDouble", "()D");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextFloat()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float NextFloat()
        {
            return IExecuteWithSignature<float>("nextFloat", "()F");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int NextInt()
        {
            return IExecuteWithSignature<int>("nextInt", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int NextInt(int arg0)
        {
            return IExecuteWithSignature<int>("nextInt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#radix()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Radix()
        {
            return IExecuteWithSignature<int>("radix", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#ioException()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.IOException"/></returns>
        public Java.Io.IOException IoException()
        {
            var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("ioException", "()Ljava/io/IOException;"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Io.IOException>(obj);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#next()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Next()
        {
            return IExecuteWithSignature("next", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#findInLine(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FindInLine(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("findInLine", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#findInLine(java.util.regex.Pattern)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FindInLine(Java.Util.Regex.Pattern arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("findInLine", "(Ljava/util/regex/Pattern;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#findWithinHorizon(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FindWithinHorizon(Java.Lang.String arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Lang.String>("findWithinHorizon", "(Ljava/lang/String;I)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#findWithinHorizon(java.util.regex.Pattern,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FindWithinHorizon(Java.Util.Regex.Pattern arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Lang.String>("findWithinHorizon", "(Ljava/util/regex/Pattern;I)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#next(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Next(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("next", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#next(java.util.regex.Pattern)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Next(Java.Util.Regex.Pattern arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("next", "(Ljava/util/regex/Pattern;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextLine()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String NextLine()
        {
            return IExecuteWithSignature<Java.Lang.String>("nextLine", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextBigDecimal()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal NextBigDecimal()
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("nextBigDecimal", "()Ljava/math/BigDecimal;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextBigInteger()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger NextBigInteger()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("nextBigInteger", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextBigInteger(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger NextBigInteger(int arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("nextBigInteger", "(I)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#locale()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public Java.Util.Locale Locale()
        {
            return IExecuteWithSignature<Java.Util.Locale>("locale", "()Ljava/util/Locale;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#match()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Regex.MatchResult"/></returns>
        public Java.Util.Regex.MatchResult Match()
        {
            return IExecuteWithSignature<Java.Util.Regex.MatchResult>("match", "()Ljava/util/regex/MatchResult;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#delimiter()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Regex.Pattern"/></returns>
        public Java.Util.Regex.Pattern Delimiter()
        {
            return IExecuteWithSignature<Java.Util.Regex.Pattern>("delimiter", "()Ljava/util/regex/Pattern;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#reset()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Scanner"/></returns>
        public Java.Util.Scanner Reset()
        {
            return IExecuteWithSignature<Java.Util.Scanner>("reset", "()Ljava/util/Scanner;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#skip(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Scanner"/></returns>
        public Java.Util.Scanner Skip(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Scanner>("skip", "(Ljava/lang/String;)Ljava/util/Scanner;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#skip(java.util.regex.Pattern)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <returns><see cref="Java.Util.Scanner"/></returns>
        public Java.Util.Scanner Skip(Java.Util.Regex.Pattern arg0)
        {
            return IExecuteWithSignature<Java.Util.Scanner>("skip", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#useDelimiter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Scanner"/></returns>
        public Java.Util.Scanner UseDelimiter(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Scanner>("useDelimiter", "(Ljava/lang/String;)Ljava/util/Scanner;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#useDelimiter(java.util.regex.Pattern)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <returns><see cref="Java.Util.Scanner"/></returns>
        public Java.Util.Scanner UseDelimiter(Java.Util.Regex.Pattern arg0)
        {
            return IExecuteWithSignature<Java.Util.Scanner>("useDelimiter", "(Ljava/util/regex/Pattern;)Ljava/util/Scanner;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#useLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Util.Scanner"/></returns>
        public Java.Util.Scanner UseLocale(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<Java.Util.Scanner>("useLocale", "(Ljava/util/Locale;)Ljava/util/Scanner;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#useRadix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Scanner"/></returns>
        public Java.Util.Scanner UseRadix(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Scanner>("useRadix", "(I)Ljava/util/Scanner;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#tokens()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Lang.String> Tokens()
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Lang.String>>("tokens", "()Ljava/util/stream/Stream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#findAll(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Util.Regex.MatchResult> FindAll(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Util.Regex.MatchResult>>("findAll", "(Ljava/lang/String;)Ljava/util/stream/Stream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#findAll(java.util.regex.Pattern)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Util.Regex.MatchResult> FindAll(Java.Util.Regex.Pattern arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Util.Regex.MatchResult>>("findAll", "(Ljava/util/regex/Pattern;)Ljava/util/stream/Stream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long NextLong()
        {
            return IExecuteWithSignature<long>("nextLong", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextLong(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long NextLong(int arg0)
        {
            return IExecuteWithSignature<long>("nextLong", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextShort()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public short NextShort()
        {
            return IExecuteWithSignature<short>("nextShort", "()S");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextShort(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="short"/></returns>
        public short NextShort(int arg0)
        {
            return IExecuteWithSignature<short>("nextShort", "(I)S", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#remove()"/>
        /// </summary>
        public void Remove()
        {
            IExecuteWithSignature("remove", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}