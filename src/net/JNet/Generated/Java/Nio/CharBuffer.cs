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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio
{
    #region CharBuffer
    public partial class CharBuffer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.CharBuffer"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Nio.CharBuffer t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.CharBuffer"/> to <see cref="Java.Lang.Appendable"/>
        /// </summary>
        public static implicit operator Java.Lang.Appendable(Java.Nio.CharBuffer t) => t.Cast<Java.Lang.Appendable>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.CharBuffer"/> to <see cref="Java.Lang.CharSequence"/>
        /// </summary>
        public static implicit operator Java.Lang.CharSequence(Java.Nio.CharBuffer t) => t.Cast<Java.Lang.CharSequence>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.CharBuffer"/> to <see cref="Java.Lang.Readable"/>
        /// </summary>
        public static implicit operator Java.Lang.Readable(Java.Nio.CharBuffer t) => t.Cast<Java.Lang.Readable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#allocate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public static Java.Nio.CharBuffer Allocate(int arg0)
        {
            return SExecute<Java.Nio.CharBuffer>(LocalBridgeClazz, "allocate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#wrap(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public static Java.Nio.CharBuffer Wrap(char[] arg0, int arg1, int arg2)
        {
            return SExecute<Java.Nio.CharBuffer>(LocalBridgeClazz, "wrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#wrap(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public static Java.Nio.CharBuffer Wrap(char[] arg0)
        {
            return SExecute<Java.Nio.CharBuffer>(LocalBridgeClazz, "wrap", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#wrap(java.lang.CharSequence,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public static Java.Nio.CharBuffer Wrap(Java.Lang.CharSequence arg0, int arg1, int arg2)
        {
            return SExecute<Java.Nio.CharBuffer>(LocalBridgeClazz, "wrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#wrap(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public static Java.Nio.CharBuffer Wrap(Java.Lang.CharSequence arg0)
        {
            return SExecute<Java.Nio.CharBuffer>(LocalBridgeClazz, "wrap", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#get()"/>
        /// </summary>

        /// <returns><see cref="char"/></returns>
        public char Get()
        {
            return IExecute<char>("get");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char Get(int arg0)
        {
            return IExecute<char>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#order()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.ByteOrder"/></returns>
        public Java.Nio.ByteOrder Order()
        {
            return IExecute<Java.Nio.ByteOrder>("order");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#asReadOnlyBuffer()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public Java.Nio.CharBuffer AsReadOnlyBuffer()
        {
            return IExecute<Java.Nio.CharBuffer>("asReadOnlyBuffer");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#compact()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public Java.Nio.CharBuffer Compact()
        {
            return IExecute<Java.Nio.CharBuffer>("compact");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#put(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public Java.Nio.CharBuffer Put(char arg0)
        {
            return IExecute<Java.Nio.CharBuffer>("put", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#put(int,char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public Java.Nio.CharBuffer Put(int arg0, char arg1)
        {
            return IExecute<Java.Nio.CharBuffer>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#charAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char CharAt(int arg0)
        {
            return IExecute<char>("charAt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#length()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Length()
        {
            return IExecute<int>("length");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#put(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public Java.Nio.CharBuffer Put(char[] arg0)
        {
            return IExecute<Java.Nio.CharBuffer>("put", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#put(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public Java.Nio.CharBuffer Put(string arg0)
        {
            return IExecute<Java.Nio.CharBuffer>("put", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#compareTo(java.nio.CharBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.CharBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Nio.CharBuffer arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#mismatch(java.nio.CharBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.CharBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int Mismatch(Java.Nio.CharBuffer arg0)
        {
            return IExecute<int>("mismatch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#read(java.nio.CharBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.CharBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(Java.Nio.CharBuffer arg0)
        {
            return IExecute<int>("read", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#append(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Lang.Appendable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Appendable Append(char arg0)
        {
            return IExecute<Java.Lang.Appendable>("append", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#append(java.lang.CharSequence,int,int)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#append(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.Appendable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Appendable Append(Java.Lang.CharSequence arg0)
        {
            return IExecute<Java.Lang.Appendable>("append", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#subSequence(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence SubSequence(int arg0, int arg1)
        {
            return IExecute<Java.Lang.CharSequence>("subSequence", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#get(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public Java.Nio.CharBuffer Get(char[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.CharBuffer>("get", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#get(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public Java.Nio.CharBuffer Get(char[] arg0)
        {
            return IExecute<Java.Nio.CharBuffer>("get", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#put(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public Java.Nio.CharBuffer Put(char[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.CharBuffer>("put", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#put(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public Java.Nio.CharBuffer Put(string arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.CharBuffer>("put", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#put(java.nio.CharBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.CharBuffer"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public Java.Nio.CharBuffer Put(Java.Nio.CharBuffer arg0)
        {
            return IExecute<Java.Nio.CharBuffer>("put", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/CharBuffer.html#chars()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Chars()
        {
            return IExecute<Java.Util.Stream.IntStream>("chars");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}