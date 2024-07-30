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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Io
{
    #region Writer
    public partial class Writer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Io.Writer"/> to <see cref="Java.Lang.Appendable"/>
        /// </summary>
        public static implicit operator Java.Lang.Appendable(Java.Io.Writer t) => t.Cast<Java.Lang.Appendable>();
        /// <summary>
        /// Converter from <see cref="Java.Io.Writer"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Io.Writer t) => t.Cast<Java.Io.Closeable>();
        /// <summary>
        /// Converter from <see cref="Java.Io.Writer"/> to <see cref="Java.Io.Flushable"/>
        /// </summary>
        public static implicit operator Java.Io.Flushable(Java.Io.Writer t) => t.Cast<Java.Io.Flushable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/Writer.html#nullWriter()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.Writer"/></returns>
        public static Java.Io.Writer NullWriter()
        {
            return SExecuteWithSignature<Java.Io.Writer>(LocalBridgeClazz, "nullWriter", "()Ljava/io/Writer;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/Writer.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/Writer.html#flush()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/Writer.html#write(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(char[] arg0, int arg1, int arg2)
        {
            IExecute("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/Writer.html#append(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Lang.Appendable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Appendable Append(char arg0)
        {
            return IExecuteWithSignature<Java.Lang.Appendable>("append", "(C)Ljava/lang/Appendable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/Writer.html#append(java.lang.CharSequence,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Appendable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Appendable Append(Java.Lang.CharSequence arg0, int arg1, int arg2)
        {
            return IExecute<Java.Lang.Appendable>("append", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/Writer.html#append(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.Appendable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Appendable Append(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Java.Lang.Appendable>("append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/Writer.html#write(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(char[] arg0)
        {
            IExecuteWithSignature("write", "([C)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/Writer.html#write(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(int arg0)
        {
            IExecuteWithSignature("write", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/Writer.html#write(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(Java.Lang.String arg0, int arg1, int arg2)
        {
            IExecute("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/Writer.html#write(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(Java.Lang.String arg0)
        {
            IExecuteWithSignature("write", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}