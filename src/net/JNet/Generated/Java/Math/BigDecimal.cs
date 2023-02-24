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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
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
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <param name="arg3"><see cref="Java.Math.MathContext"/></param>
        public BigDecimal(char[] arg0, int arg1, int arg2, Java.Math.MathContext arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see langword="int"/></param>
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
        /// <param name="arg0"><see langword="double"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        public BigDecimal(double arg0, Java.Math.MathContext arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(double)"/>
        /// </summary>
        /// <param name="arg0"><see langword="double"/></param>
        public BigDecimal(double arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(int,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        public BigDecimal(int arg0, Java.Math.MathContext arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        public BigDecimal(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(java.lang.String,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        public BigDecimal(string arg0, Java.Math.MathContext arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        public BigDecimal(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(java.math.BigInteger,int,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see cref="Java.Math.MathContext"/></param>
        public BigDecimal(Java.Math.BigInteger arg0, int arg1, Java.Math.MathContext arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(java.math.BigInteger,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see langword="int"/></param>
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
        /// <param name="arg0"><see langword="long"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        public BigDecimal(long arg0, Java.Math.MathContext arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#%3Cinit%3E(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        public BigDecimal(long arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#ONE"/>
        /// </summary>
        public static Java.Math.BigDecimal ONE => Clazz.GetField<Java.Math.BigDecimal>("ONE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#TEN"/>
        /// </summary>
        public static Java.Math.BigDecimal TEN => Clazz.GetField<Java.Math.BigDecimal>("TEN");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#ZERO"/>
        /// </summary>
        public static Java.Math.BigDecimal ZERO => Clazz.GetField<Java.Math.BigDecimal>("ZERO");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#valueOf(double)"/>
        /// </summary>
        /// <param name="arg0"><see langword="double"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public static Java.Math.BigDecimal ValueOf(double arg0)
        {
            return SExecute<Java.Math.BigDecimal>("valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#valueOf(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public static Java.Math.BigDecimal ValueOf(long arg0, int arg1)
        {
            return SExecute<Java.Math.BigDecimal>("valueOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#valueOf(long)"/>
        /// </summary>
        /// <param name="arg0"><see langword="long"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public static Java.Math.BigDecimal ValueOf(long arg0)
        {
            return SExecute<Java.Math.BigDecimal>("valueOf", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#byteValueExact()"/>
        /// </summary>
        
        /// <returns><see langword="byte"/></returns>
        public byte ByteValueExact()
        {
            return IExecute<byte>("byteValueExact");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#compareTo(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see langword="int"/></returns>
        public int CompareTo(Java.Math.BigDecimal arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#intValueExact()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int IntValueExact()
        {
            return IExecute<int>("intValueExact");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#precision()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int Precision()
        {
            return IExecute<int>("precision");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#scale()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int Scale()
        {
            return IExecute<int>("scale");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#signum()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int Signum()
        {
            return IExecute<int>("signum");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#toEngineeringString()"/>
        /// </summary>
        
        /// <returns><see langword="string"/></returns>
        public string ToEngineeringString()
        {
            return IExecute<string>("toEngineeringString");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#toPlainString()"/>
        /// </summary>
        
        /// <returns><see langword="string"/></returns>
        public string ToPlainString()
        {
            return IExecute<string>("toPlainString");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#abs()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Abs()
        {
            return IExecute<Java.Math.BigDecimal>("abs");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#abs(java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Abs(Java.Math.MathContext arg0)
        {
            return IExecute<Java.Math.BigDecimal>("abs", arg0);
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
            return IExecute<Java.Math.BigDecimal>("add", arg0);
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#divide(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Divide(Java.Math.BigDecimal arg0)
        {
            return IExecute<Java.Math.BigDecimal>("divide", arg0);
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
            return IExecute<Java.Math.BigDecimal>("divideToIntegralValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#max(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Max(Java.Math.BigDecimal arg0)
        {
            return IExecute<Java.Math.BigDecimal>("max", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#min(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Min(Java.Math.BigDecimal arg0)
        {
            return IExecute<Java.Math.BigDecimal>("min", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#movePointLeft(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal MovePointLeft(int arg0)
        {
            return IExecute<Java.Math.BigDecimal>("movePointLeft", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#movePointRight(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal MovePointRight(int arg0)
        {
            return IExecute<Java.Math.BigDecimal>("movePointRight", arg0);
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
            return IExecute<Java.Math.BigDecimal>("multiply", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#negate()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Negate()
        {
            return IExecute<Java.Math.BigDecimal>("negate");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#negate(java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Negate(Java.Math.MathContext arg0)
        {
            return IExecute<Java.Math.BigDecimal>("negate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#plus()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Plus()
        {
            return IExecute<Java.Math.BigDecimal>("plus");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#plus(java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Plus(Java.Math.MathContext arg0)
        {
            return IExecute<Java.Math.BigDecimal>("plus", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#pow(int,java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Pow(int arg0, Java.Math.MathContext arg1)
        {
            return IExecute<Java.Math.BigDecimal>("pow", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#pow(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Pow(int arg0)
        {
            return IExecute<Java.Math.BigDecimal>("pow", arg0);
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
            return IExecute<Java.Math.BigDecimal>("remainder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#round(java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Round(Java.Math.MathContext arg0)
        {
            return IExecute<Java.Math.BigDecimal>("round", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#scaleByPowerOfTen(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal ScaleByPowerOfTen(int arg0)
        {
            return IExecute<Java.Math.BigDecimal>("scaleByPowerOfTen", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#setScale(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal SetScale(int arg0)
        {
            return IExecute<Java.Math.BigDecimal>("setScale", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#sqrt(java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.MathContext"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Sqrt(Java.Math.MathContext arg0)
        {
            return IExecute<Java.Math.BigDecimal>("sqrt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#stripTrailingZeros()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal StripTrailingZeros()
        {
            return IExecute<Java.Math.BigDecimal>("stripTrailingZeros");
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
            return IExecute<Java.Math.BigDecimal>("subtract", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#ulp()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal Ulp()
        {
            return IExecute<Java.Math.BigDecimal>("ulp");
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
            return IExecuteArray<Java.Math.BigDecimal>("divideAndRemainder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#toBigInteger()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ToBigInteger()
        {
            return IExecute<Java.Math.BigInteger>("toBigInteger");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#toBigIntegerExact()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ToBigIntegerExact()
        {
            return IExecute<Java.Math.BigInteger>("toBigIntegerExact");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#unscaledValue()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger UnscaledValue()
        {
            return IExecute<Java.Math.BigInteger>("unscaledValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#longValueExact()"/>
        /// </summary>
        
        /// <returns><see langword="long"/></returns>
        public long LongValueExact()
        {
            return IExecute<long>("longValueExact");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html#shortValueExact()"/>
        /// </summary>
        
        /// <returns><see langword="short"/></returns>
        public short ShortValueExact()
        {
            return IExecute<short>("shortValueExact");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}