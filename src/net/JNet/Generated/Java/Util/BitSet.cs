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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region BitSet
    public partial class BitSet
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public BitSet(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.BitSet"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.BitSet t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.BitSet"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.BitSet t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#valueOf(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Util.BitSet"/></returns>
        public static Java.Util.BitSet ValueOf(byte[] arg0)
        {
            return SExecuteWithSignature<Java.Util.BitSet>(LocalBridgeClazz, "valueOf", "([B)Ljava/util/BitSet;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#valueOf(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.BitSet"/></returns>
        public static Java.Util.BitSet ValueOf(Java.Nio.ByteBuffer arg0)
        {
            return SExecuteWithSignature<Java.Util.BitSet>(LocalBridgeClazz, "valueOf", "(Ljava/nio/ByteBuffer;)Ljava/util/BitSet;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#valueOf(java.nio.LongBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.LongBuffer"/></param>
        /// <returns><see cref="Java.Util.BitSet"/></returns>
        public static Java.Util.BitSet ValueOf(Java.Nio.LongBuffer arg0)
        {
            return SExecuteWithSignature<Java.Util.BitSet>(LocalBridgeClazz, "valueOf", "(Ljava/nio/LongBuffer;)Ljava/util/BitSet;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#valueOf(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.BitSet"/></returns>
        public static Java.Util.BitSet ValueOf(long[] arg0)
        {
            return SExecuteWithSignature<Java.Util.BitSet>(LocalBridgeClazz, "valueOf", "([J)Ljava/util/BitSet;", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Get(int arg0)
        {
            return IExecuteWithSignature<bool>("get", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#intersects(java.util.BitSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.BitSet"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersects(Java.Util.BitSet arg0)
        {
            return IExecuteWithSignature<bool>("intersects", "(Ljava/util/BitSet;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#toByteArray()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] ToByteArray()
        {
            return IExecuteWithSignatureArray<byte>("toByteArray", "()[B");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#cardinality()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Cardinality()
        {
            return IExecuteWithSignature<int>("cardinality", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#length()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Length()
        {
            return IExecuteWithSignature<int>("length", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#nextClearBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int NextClearBit(int arg0)
        {
            return IExecuteWithSignature<int>("nextClearBit", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#nextSetBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int NextSetBit(int arg0)
        {
            return IExecuteWithSignature<int>("nextSetBit", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#previousClearBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int PreviousClearBit(int arg0)
        {
            return IExecuteWithSignature<int>("previousClearBit", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#previousSetBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int PreviousSetBit(int arg0)
        {
            return IExecuteWithSignature<int>("previousSetBit", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#get(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.BitSet"/></returns>
        public Java.Util.BitSet Get(int arg0, int arg1)
        {
            return IExecute<Java.Util.BitSet>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#stream()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Stream()
        {
            return IExecuteWithSignature<Java.Util.Stream.IntStream>("stream", "()Ljava/util/stream/IntStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#toLongArray()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long[] ToLongArray()
        {
            return IExecuteWithSignatureArray<long>("toLongArray", "()[J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#and(java.util.BitSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.BitSet"/></param>
        public void And(Java.Util.BitSet arg0)
        {
            IExecuteWithSignature("and", "(Ljava/util/BitSet;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#andNot(java.util.BitSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.BitSet"/></param>
        public void AndNot(Java.Util.BitSet arg0)
        {
            IExecuteWithSignature("andNot", "(Ljava/util/BitSet;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#clear(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Clear(int arg0, int arg1)
        {
            IExecute("clear", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#clear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Clear(int arg0)
        {
            IExecuteWithSignature("clear", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#flip(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Flip(int arg0, int arg1)
        {
            IExecute("flip", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#flip(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Flip(int arg0)
        {
            IExecuteWithSignature("flip", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#or(java.util.BitSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.BitSet"/></param>
        public void Or(Java.Util.BitSet arg0)
        {
            IExecuteWithSignature("or", "(Ljava/util/BitSet;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#set(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Set(int arg0, bool arg1)
        {
            IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#set(int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void Set(int arg0, int arg1, bool arg2)
        {
            IExecute("set", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#set(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Set(int arg0, int arg1)
        {
            IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#set(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Set(int arg0)
        {
            IExecuteWithSignature("set", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/BitSet.html#xor(java.util.BitSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.BitSet"/></param>
        public void Xor(Java.Util.BitSet arg0)
        {
            IExecuteWithSignature("xor", "(Ljava/util/BitSet;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}