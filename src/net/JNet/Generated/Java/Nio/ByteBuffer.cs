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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio
{
    #region ByteBuffer
    public partial class ByteBuffer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.ByteBuffer"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Nio.ByteBuffer t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#allocate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public static Java.Nio.ByteBuffer Allocate(int arg0)
        {
            return SExecuteWithSignature<Java.Nio.ByteBuffer>(LocalBridgeClazz, "allocate", "(I)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#allocateDirect(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public static Java.Nio.ByteBuffer AllocateDirect(int arg0)
        {
            return SExecuteWithSignature<Java.Nio.ByteBuffer>(LocalBridgeClazz, "allocateDirect", "(I)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#wrap(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public static Java.Nio.ByteBuffer Wrap(byte[] arg0, int arg1, int arg2)
        {
            return SExecute<Java.Nio.ByteBuffer>(LocalBridgeClazz, "wrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#wrap(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public static Java.Nio.ByteBuffer Wrap(byte[] arg0)
        {
            return SExecuteWithSignature<Java.Nio.ByteBuffer>(LocalBridgeClazz, "wrap", "([B)Ljava/nio/ByteBuffer;", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#getChar()"/> 
        /// </summary>
        public char Char
        {
            get { return IExecuteWithSignature<char>("getChar", "()C"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#getDouble()"/> 
        /// </summary>
        public double Double
        {
            get { return IExecuteWithSignature<double>("getDouble", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#getFloat()"/> 
        /// </summary>
        public float Float
        {
            get { return IExecuteWithSignature<float>("getFloat", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#getInt()"/> 
        /// </summary>
        public int Int
        {
            get { return IExecuteWithSignature<int>("getInt", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#getLong()"/> 
        /// </summary>
        public long Long
        {
            get { return IExecuteWithSignature<long>("getLong", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#getShort()"/> 
        /// </summary>
        public short Short
        {
            get { return IExecuteWithSignature<short>("getShort", "()S"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#get()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte Get()
        {
            return IExecuteWithSignature<byte>("get", "()B");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte Get(int arg0)
        {
            return IExecuteWithSignature<byte>("get", "(I)B", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#getChar(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char GetChar(int arg0)
        {
            return IExecuteWithSignature<char>("getChar", "(I)C", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#getDouble(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public double GetDouble(int arg0)
        {
            return IExecuteWithSignature<double>("getDouble", "(I)D", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#getFloat(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetFloat(int arg0)
        {
            return IExecuteWithSignature<float>("getFloat", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#getInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetInt(int arg0)
        {
            return IExecuteWithSignature<int>("getInt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#asReadOnlyBuffer()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer AsReadOnlyBuffer()
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#compact()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Compact()
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("compact", "()Ljava/nio/ByteBuffer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#put(byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Put(byte arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("put", "(B)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#put(int,byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Put(int arg0, byte arg1)
        {
            return IExecute<Java.Nio.ByteBuffer>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#putChar(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer PutChar(char arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("putChar", "(C)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#putChar(int,char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer PutChar(int arg0, char arg1)
        {
            return IExecute<Java.Nio.ByteBuffer>("putChar", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#putDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer PutDouble(double arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("putDouble", "(D)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#putDouble(int,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer PutDouble(int arg0, double arg1)
        {
            return IExecute<Java.Nio.ByteBuffer>("putDouble", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#putFloat(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer PutFloat(float arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("putFloat", "(F)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#putFloat(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer PutFloat(int arg0, float arg1)
        {
            return IExecute<Java.Nio.ByteBuffer>("putFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#putInt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer PutInt(int arg0, int arg1)
        {
            return IExecute<Java.Nio.ByteBuffer>("putInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#putInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer PutInt(int arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("putInt", "(I)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#putLong(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer PutLong(int arg0, long arg1)
        {
            return IExecute<Java.Nio.ByteBuffer>("putLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#putLong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer PutLong(long arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("putLong", "(J)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#putShort(int,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer PutShort(int arg0, short arg1)
        {
            return IExecute<Java.Nio.ByteBuffer>("putShort", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#putShort(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer PutShort(short arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("putShort", "(S)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#asCharBuffer()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public Java.Nio.CharBuffer AsCharBuffer()
        {
            return IExecuteWithSignature<Java.Nio.CharBuffer>("asCharBuffer", "()Ljava/nio/CharBuffer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#asDoubleBuffer()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer AsDoubleBuffer()
        {
            return IExecuteWithSignature<Java.Nio.DoubleBuffer>("asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#asFloatBuffer()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.FloatBuffer"/></returns>
        public Java.Nio.FloatBuffer AsFloatBuffer()
        {
            return IExecuteWithSignature<Java.Nio.FloatBuffer>("asFloatBuffer", "()Ljava/nio/FloatBuffer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#asIntBuffer()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer AsIntBuffer()
        {
            return IExecuteWithSignature<Java.Nio.IntBuffer>("asIntBuffer", "()Ljava/nio/IntBuffer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#asLongBuffer()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.LongBuffer"/></returns>
        public Java.Nio.LongBuffer AsLongBuffer()
        {
            return IExecuteWithSignature<Java.Nio.LongBuffer>("asLongBuffer", "()Ljava/nio/LongBuffer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#asShortBuffer()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ShortBuffer"/></returns>
        public Java.Nio.ShortBuffer AsShortBuffer()
        {
            return IExecuteWithSignature<Java.Nio.ShortBuffer>("asShortBuffer", "()Ljava/nio/ShortBuffer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#getLong(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(int arg0)
        {
            return IExecuteWithSignature<long>("getLong", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#getShort(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="short"/></returns>
        public short GetShort(int arg0)
        {
            return IExecuteWithSignature<short>("getShort", "(I)S", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#alignmentOffset(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int AlignmentOffset(int arg0, int arg1)
        {
            return IExecute<int>("alignmentOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#alignedSlice(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer AlignedSlice(int arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("alignedSlice", "(I)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#order(java.nio.ByteOrder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteOrder"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Order(Java.Nio.ByteOrder arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("order", "(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#put(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Put(byte[] arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("put", "([B)Ljava/nio/ByteBuffer;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#order()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteOrder"/></returns>
        public Java.Nio.ByteOrder Order()
        {
            return IExecuteWithSignature<Java.Nio.ByteOrder>("order", "()Ljava/nio/ByteOrder;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#compareTo(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/nio/ByteBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#mismatch(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int Mismatch(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<int>("mismatch", "(Ljava/nio/ByteBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#get(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Get(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.ByteBuffer>("get", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#get(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Get(byte[] arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("get", "([B)Ljava/nio/ByteBuffer;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#put(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Put(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.ByteBuffer>("put", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ByteBuffer.html#put(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Put(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("put", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}