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

namespace Java.Math
{
    #region BigDecimal
    public partial class BigDecimal
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(char[],int,int,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Math.MathContext"/></param>
        public BigDecimal(char[] arg0, int arg1, int arg2, Java.Math.MathContext arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public BigDecimal(char[] arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(char[],java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        public BigDecimal(char[] arg0, Java.Math.MathContext arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public BigDecimal(char[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(double,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        public BigDecimal(double arg0, Java.Math.MathContext arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public BigDecimal(double arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(int,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        public BigDecimal(int arg0, Java.Math.MathContext arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public BigDecimal(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(java.lang.String,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        public BigDecimal(Java.Lang.String arg0, Java.Math.MathContext arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public BigDecimal(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(java.math.BigInteger,int,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Math.MathContext"/></param>
        public BigDecimal(Java.Math.BigInteger arg0, int arg1, Java.Math.MathContext arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(java.math.BigInteger,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public BigDecimal(Java.Math.BigInteger arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(java.math.BigInteger,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        public BigDecimal(Java.Math.BigInteger arg0, Java.Math.MathContext arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        public BigDecimal(Java.Math.BigInteger arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(long,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        public BigDecimal(long arg0, Java.Math.MathContext arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public BigDecimal(long arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Math.BigDecimal"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Math.BigDecimal t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#ONE"/>
        /// </summary>
        public static Java.Math.BigDecimal ONE { get { if (!_ONEReady) { _ONEContent = SGetField<Java.Math.BigDecimal>(LocalBridgeClazz, "ONE"); _ONEReady = true; } return _ONEContent; } }
        private static Java.Math.BigDecimal _ONEContent = default;
        private static bool _ONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#TEN"/>
        /// </summary>
        public static Java.Math.BigDecimal TEN { get { if (!_TENReady) { _TENContent = SGetField<Java.Math.BigDecimal>(LocalBridgeClazz, "TEN"); _TENReady = true; } return _TENContent; } }
        private static Java.Math.BigDecimal _TENContent = default;
        private static bool _TENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#ZERO"/>
        /// </summary>
        public static Java.Math.BigDecimal ZERO { get { if (!_ZEROReady) { _ZEROContent = SGetField<Java.Math.BigDecimal>(LocalBridgeClazz, "ZERO"); _ZEROReady = true; } return _ZEROContent; } }
        private static Java.Math.BigDecimal _ZEROContent = default;
        private static bool _ZEROReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#valueOf(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public static Java.Math.BigDecimal ValueOf(double arg0)
        {
            return SExecuteWithSignature<Java.Math.BigDecimal>(LocalBridgeClazz, "valueOf", "(D)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#valueOf(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public static Java.Math.BigDecimal ValueOf(long arg0, int arg1)
        {
            return SExecute<Java.Math.BigDecimal>(LocalBridgeClazz, "valueOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#valueOf(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public static Java.Math.BigDecimal ValueOf(long arg0)
        {
            return SExecuteWithSignature<Java.Math.BigDecimal>(LocalBridgeClazz, "valueOf", "(J)Ljava/math/BigDecimal;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#byteValueExact()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte ByteValueExact()
        {
            return IExecuteWithSignature<byte>("byteValueExact", "()B");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#compareTo(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/math/BigDecimal;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#intValueExact()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int IntValueExact()
        {
            return IExecuteWithSignature<int>("intValueExact", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#precision()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Precision()
        {
            return IExecuteWithSignature<int>("precision", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#scale()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Scale()
        {
            return IExecuteWithSignature<int>("scale", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#signum()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Signum()
        {
            return IExecuteWithSignature<int>("signum", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#toEngineeringString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToEngineeringString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toEngineeringString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#toPlainString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToPlainString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toPlainString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#abs()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Abs()
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("abs", "()Ljava/math/BigDecimal;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#abs(java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Abs(Java.Math.MathContext arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("abs", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#add(java.math.BigDecimal,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Add(Java.Math.BigDecimal arg0, Java.Math.MathContext arg1)
        {
            return IExecute<Java.Math.BigDecimal>("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#add(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Add(Java.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("add", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#divide(java.math.BigDecimal,int,java.math.RoundingMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Math.RoundingMode"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Divide(Java.Math.BigDecimal arg0, int arg1, Java.Math.RoundingMode arg2)
        {
            return IExecute<Java.Math.BigDecimal>("divide", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#divide(java.math.BigDecimal,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Divide(Java.Math.BigDecimal arg0, Java.Math.MathContext arg1)
        {
            return IExecute<Java.Math.BigDecimal>("divide", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#divide(java.math.BigDecimal,java.math.RoundingMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Java.Math.RoundingMode"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Divide(Java.Math.BigDecimal arg0, Java.Math.RoundingMode arg1)
        {
            return IExecute<Java.Math.BigDecimal>("divide", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#divide(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Divide(Java.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("divide", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#divideToIntegralValue(java.math.BigDecimal,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal DivideToIntegralValue(Java.Math.BigDecimal arg0, Java.Math.MathContext arg1)
        {
            return IExecute<Java.Math.BigDecimal>("divideToIntegralValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#divideToIntegralValue(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal DivideToIntegralValue(Java.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("divideToIntegralValue", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#max(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Max(Java.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("max", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#min(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Min(Java.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("min", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#movePointLeft(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal MovePointLeft(int arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("movePointLeft", "(I)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#movePointRight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal MovePointRight(int arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("movePointRight", "(I)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#multiply(java.math.BigDecimal,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Multiply(Java.Math.BigDecimal arg0, Java.Math.MathContext arg1)
        {
            return IExecute<Java.Math.BigDecimal>("multiply", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#multiply(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Multiply(Java.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("multiply", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Negate()
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("negate", "()Ljava/math/BigDecimal;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#negate(java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Negate(Java.Math.MathContext arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("negate", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#plus()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Plus()
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("plus", "()Ljava/math/BigDecimal;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#plus(java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Plus(Java.Math.MathContext arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("plus", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#pow(int,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Pow(int arg0, Java.Math.MathContext arg1)
        {
            return IExecute<Java.Math.BigDecimal>("pow", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#pow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Pow(int arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("pow", "(I)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#remainder(java.math.BigDecimal,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Remainder(Java.Math.BigDecimal arg0, Java.Math.MathContext arg1)
        {
            return IExecute<Java.Math.BigDecimal>("remainder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#remainder(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Remainder(Java.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("remainder", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#round(java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Round(Java.Math.MathContext arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("round", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#scaleByPowerOfTen(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal ScaleByPowerOfTen(int arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("scaleByPowerOfTen", "(I)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#setScale(int,java.math.RoundingMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Math.RoundingMode"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal SetScale(int arg0, Java.Math.RoundingMode arg1)
        {
            return IExecute<Java.Math.BigDecimal>("setScale", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#setScale(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal SetScale(int arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("setScale", "(I)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#sqrt(java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Sqrt(Java.Math.MathContext arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("sqrt", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#stripTrailingZeros()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal StripTrailingZeros()
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("stripTrailingZeros", "()Ljava/math/BigDecimal;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#subtract(java.math.BigDecimal,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Subtract(Java.Math.BigDecimal arg0, Java.Math.MathContext arg1)
        {
            return IExecute<Java.Math.BigDecimal>("subtract", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#subtract(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Subtract(Java.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("subtract", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#ulp()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Ulp()
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("ulp", "()Ljava/math/BigDecimal;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#divideAndRemainder(java.math.BigDecimal,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal[] DivideAndRemainder(Java.Math.BigDecimal arg0, Java.Math.MathContext arg1)
        {
            return IExecuteArray<Java.Math.BigDecimal>("divideAndRemainder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#divideAndRemainder(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal[] DivideAndRemainder(Java.Math.BigDecimal arg0)
        {
            return IExecuteWithSignatureArray<Java.Math.BigDecimal>("divideAndRemainder", "(Ljava/math/BigDecimal;)[Ljava/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#toBigInteger()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ToBigInteger()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("toBigInteger", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#toBigIntegerExact()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ToBigIntegerExact()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("toBigIntegerExact", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#unscaledValue()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger UnscaledValue()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("unscaledValue", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#longValueExact()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long LongValueExact()
        {
            return IExecuteWithSignature<long>("longValueExact", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#shortValueExact()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public short ShortValueExact()
        {
            return IExecuteWithSignature<short>("shortValueExact", "()S");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}