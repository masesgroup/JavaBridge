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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Integer
    public partial class Integer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Integer"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Lang.Integer t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#BYTES"/>
        /// </summary>
        public static int BYTES { get { if (!_BYTESReady) { _BYTESContent = SGetField<int>(LocalBridgeClazz, "BYTES"); _BYTESReady = true; } return _BYTESContent; } }
        private static int _BYTESContent = default;
        private static bool _BYTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#MAX_VALUE"/>
        /// </summary>
        public static int MAX_VALUE { get { if (!_MAX_VALUEReady) { _MAX_VALUEContent = SGetField<int>(LocalBridgeClazz, "MAX_VALUE"); _MAX_VALUEReady = true; } return _MAX_VALUEContent; } }
        private static int _MAX_VALUEContent = default;
        private static bool _MAX_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#MIN_VALUE"/>
        /// </summary>
        public static int MIN_VALUE { get { if (!_MIN_VALUEReady) { _MIN_VALUEContent = SGetField<int>(LocalBridgeClazz, "MIN_VALUE"); _MIN_VALUEReady = true; } return _MIN_VALUEContent; } }
        private static int _MIN_VALUEContent = default;
        private static bool _MIN_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#SIZE"/>
        /// </summary>
        public static int SIZE { get { if (!_SIZEReady) { _SIZEContent = SGetField<int>(LocalBridgeClazz, "SIZE"); _SIZEReady = true; } return _SIZEContent; } }
        private static int _SIZEContent = default;
        private static bool _SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#TYPE"/>
        /// </summary>
        public static Java.Lang.Class TYPE { get { if (!_TYPEReady) { _TYPEContent = SGetField<Java.Lang.Class>(LocalBridgeClazz, "TYPE"); _TYPEReady = true; } return _TYPEContent; } }
        private static Java.Lang.Class _TYPEContent = default;
        private static bool _TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#bitCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int BitCount(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "bitCount", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#compare(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Compare(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#compareUnsigned(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int CompareUnsigned(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compareUnsigned", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#divideUnsigned(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int DivideUnsigned(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "divideUnsigned", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#hashCode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HashCode(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "hashCode", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#highestOneBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HighestOneBit(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "highestOneBit", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#lowestOneBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int LowestOneBit(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "lowestOneBit", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#max(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Max(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#min(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Min(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#numberOfLeadingZeros(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int NumberOfLeadingZeros(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "numberOfLeadingZeros", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#numberOfTrailingZeros(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int NumberOfTrailingZeros(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "numberOfTrailingZeros", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#parseInt(java.lang.CharSequence,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static int ParseInt(Java.Lang.CharSequence arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<int>(LocalBridgeClazz, "parseInt", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#parseInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static int ParseInt(Java.Lang.String arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "parseInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#parseInt(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static int ParseInt(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "parseInt", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#parseUnsignedInt(java.lang.CharSequence,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static int ParseUnsignedInt(Java.Lang.CharSequence arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<int>(LocalBridgeClazz, "parseUnsignedInt", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#parseUnsignedInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static int ParseUnsignedInt(Java.Lang.String arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "parseUnsignedInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#parseUnsignedInt(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static int ParseUnsignedInt(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "parseUnsignedInt", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#remainderUnsigned(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int RemainderUnsigned(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "remainderUnsigned", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#reverse(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Reverse(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "reverse", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#reverseBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int ReverseBytes(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "reverseBytes", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#rotateLeft(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int RotateLeft(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "rotateLeft", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#rotateRight(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int RotateRight(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "rotateRight", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#signum(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Signum(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "signum", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#sum(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Sum(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "sum", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#decode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Integer Decode(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.Integer>(LocalBridgeClazz, "decode", "(Ljava/lang/String;)Ljava/lang/Integer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#getInteger(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public static Java.Lang.Integer GetInteger(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Java.Lang.Integer>(LocalBridgeClazz, "getInteger", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#getInteger(java.lang.String,java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public static Java.Lang.Integer GetInteger(Java.Lang.String arg0, Java.Lang.Integer arg1)
        {
            return SExecute<Java.Lang.Integer>(LocalBridgeClazz, "getInteger", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#getInteger(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public static Java.Lang.Integer GetInteger(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.Integer>(LocalBridgeClazz, "getInteger", "(Ljava/lang/String;)Ljava/lang/Integer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#valueOf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public static Java.Lang.Integer ValueOf(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.Integer>(LocalBridgeClazz, "valueOf", "(I)Ljava/lang/Integer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#valueOf(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Integer ValueOf(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Java.Lang.Integer>(LocalBridgeClazz, "valueOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Integer ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.Integer>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/lang/Integer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toBinaryString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToBinaryString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toBinaryString", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toHexString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToHexString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toHexString", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toOctalString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToOctalString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toOctalString", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toString(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToString(int arg0, int arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "toString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toString", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toUnsignedString(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToUnsignedString(int arg0, int arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "toUnsignedString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toUnsignedString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToUnsignedString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toUnsignedString", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toUnsignedLong(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long ToUnsignedLong(int arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "toUnsignedLong", "(I)J", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#compareTo(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Lang.Integer arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Integer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#compareTo(java.lang.Object)"/>
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