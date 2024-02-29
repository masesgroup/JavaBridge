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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Long
    public partial class Long
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Long"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Lang.Long t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#BYTES"/>
        /// </summary>
        public static int BYTES { get { if (!_BYTESReady) { _BYTESContent = SGetField<int>(LocalBridgeClazz, "BYTES"); _BYTESReady = true; } return _BYTESContent; } }
        private static int _BYTESContent = default;
        private static bool _BYTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#SIZE"/>
        /// </summary>
        public static int SIZE { get { if (!_SIZEReady) { _SIZEContent = SGetField<int>(LocalBridgeClazz, "SIZE"); _SIZEReady = true; } return _SIZEContent; } }
        private static int _SIZEContent = default;
        private static bool _SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#TYPE"/>
        /// </summary>
        public static Java.Lang.Class TYPE { get { if (!_TYPEReady) { _TYPEContent = SGetField<Java.Lang.Class>(LocalBridgeClazz, "TYPE"); _TYPEReady = true; } return _TYPEContent; } }
        private static Java.Lang.Class _TYPEContent = default;
        private static bool _TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#MAX_VALUE"/>
        /// </summary>
        public static long MAX_VALUE { get { if (!_MAX_VALUEReady) { _MAX_VALUEContent = SGetField<long>(LocalBridgeClazz, "MAX_VALUE"); _MAX_VALUEReady = true; } return _MAX_VALUEContent; } }
        private static long _MAX_VALUEContent = default;
        private static bool _MAX_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#MIN_VALUE"/>
        /// </summary>
        public static long MIN_VALUE { get { if (!_MIN_VALUEReady) { _MIN_VALUEContent = SGetField<long>(LocalBridgeClazz, "MIN_VALUE"); _MIN_VALUEReady = true; } return _MIN_VALUEContent; } }
        private static long _MIN_VALUEContent = default;
        private static bool _MIN_VALUEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#bitCount(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public static int BitCount(long arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "bitCount", "(J)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#compare(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Compare(long arg0, long arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#compareUnsigned(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public static int CompareUnsigned(long arg0, long arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compareUnsigned", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#hashCode(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HashCode(long arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "hashCode", "(J)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#numberOfLeadingZeros(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public static int NumberOfLeadingZeros(long arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "numberOfLeadingZeros", "(J)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#numberOfTrailingZeros(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public static int NumberOfTrailingZeros(long arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "numberOfTrailingZeros", "(J)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#signum(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Signum(long arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "signum", "(J)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#decode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Long Decode(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.Long>(LocalBridgeClazz, "decode", "(Ljava/lang/String;)Ljava/lang/Long;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#getLong(java.lang.String,java.lang.Long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Long"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public static Java.Lang.Long GetLong(Java.Lang.String arg0, Java.Lang.Long arg1)
        {
            return SExecute<Java.Lang.Long>(LocalBridgeClazz, "getLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#getLong(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public static Java.Lang.Long GetLong(Java.Lang.String arg0, long arg1)
        {
            return SExecute<Java.Lang.Long>(LocalBridgeClazz, "getLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#getLong(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public static Java.Lang.Long GetLong(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.Long>(LocalBridgeClazz, "getLong", "(Ljava/lang/String;)Ljava/lang/Long;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#valueOf(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Long ValueOf(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Java.Lang.Long>(LocalBridgeClazz, "valueOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Long ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.Long>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/lang/Long;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#valueOf(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public static Java.Lang.Long ValueOf(long arg0)
        {
            return SExecuteWithSignature<Java.Lang.Long>(LocalBridgeClazz, "valueOf", "(J)Ljava/lang/Long;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#toBinaryString(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToBinaryString(long arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toBinaryString", "(J)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#toHexString(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToHexString(long arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toHexString", "(J)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#toOctalString(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToOctalString(long arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toOctalString", "(J)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#toString(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToString(long arg0, int arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "toString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#toString(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToString(long arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toString", "(J)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#toUnsignedString(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToUnsignedString(long arg0, int arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "toUnsignedString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#toUnsignedString(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToUnsignedString(long arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toUnsignedString", "(J)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#divideUnsigned(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long DivideUnsigned(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "divideUnsigned", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#highestOneBit(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long HighestOneBit(long arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "highestOneBit", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#lowestOneBit(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long LowestOneBit(long arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "lowestOneBit", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#max(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Max(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#min(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Min(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#parseLong(java.lang.CharSequence,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static long ParseLong(Java.Lang.CharSequence arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<long>(LocalBridgeClazz, "parseLong", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#parseLong(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static long ParseLong(Java.Lang.String arg0, int arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "parseLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#parseLong(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static long ParseLong(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "parseLong", "(Ljava/lang/String;)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#parseUnsignedLong(java.lang.CharSequence,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static long ParseUnsignedLong(Java.Lang.CharSequence arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<long>(LocalBridgeClazz, "parseUnsignedLong", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#parseUnsignedLong(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static long ParseUnsignedLong(Java.Lang.String arg0, int arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "parseUnsignedLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#parseUnsignedLong(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static long ParseUnsignedLong(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "parseUnsignedLong", "(Ljava/lang/String;)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#remainderUnsigned(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long RemainderUnsigned(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "remainderUnsigned", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#reverse(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Reverse(long arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "reverse", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#reverseBytes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long ReverseBytes(long arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "reverseBytes", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#rotateLeft(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long RotateLeft(long arg0, int arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "rotateLeft", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#rotateRight(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long RotateRight(long arg0, int arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "rotateRight", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#sum(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Sum(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "sum", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#compareTo(java.lang.Long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Long"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Lang.Long arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Long;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Long.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}