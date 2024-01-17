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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Float
    public partial class Float
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Float"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Lang.Float t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MAX_VALUE"/>
        /// </summary>
        public static float MAX_VALUE { get { return SGetField<float>(LocalBridgeClazz, "MAX_VALUE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MIN_NORMAL"/>
        /// </summary>
        public static float MIN_NORMAL { get { return SGetField<float>(LocalBridgeClazz, "MIN_NORMAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MIN_VALUE"/>
        /// </summary>
        public static float MIN_VALUE { get { return SGetField<float>(LocalBridgeClazz, "MIN_VALUE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#NaN"/>
        /// </summary>
        public static float NaN { get { return SGetField<float>(LocalBridgeClazz, "NaN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#NEGATIVE_INFINITY"/>
        /// </summary>
        public static float NEGATIVE_INFINITY { get { return SGetField<float>(LocalBridgeClazz, "NEGATIVE_INFINITY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#POSITIVE_INFINITY"/>
        /// </summary>
        public static float POSITIVE_INFINITY { get { return SGetField<float>(LocalBridgeClazz, "POSITIVE_INFINITY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#BYTES"/>
        /// </summary>
        public static int BYTES { get { return SGetField<int>(LocalBridgeClazz, "BYTES"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MAX_EXPONENT"/>
        /// </summary>
        public static int MAX_EXPONENT { get { return SGetField<int>(LocalBridgeClazz, "MAX_EXPONENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#MIN_EXPONENT"/>
        /// </summary>
        public static int MIN_EXPONENT { get { return SGetField<int>(LocalBridgeClazz, "MIN_EXPONENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#SIZE"/>
        /// </summary>
        public static int SIZE { get { return SGetField<int>(LocalBridgeClazz, "SIZE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#TYPE"/>
        /// </summary>
        public static Java.Lang.Class TYPE { get { return SGetField<Java.Lang.Class>(LocalBridgeClazz, "TYPE"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isFinite(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsFinite(float arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isFinite", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isInfinite(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsInfinite(float arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isInfinite", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isNaN(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNaN(float arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isNaN", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#max(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Max(float arg0, float arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#min(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Min(float arg0, float arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#parseFloat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static float ParseFloat(string arg0)
        {
            return SExecute<float>(LocalBridgeClazz, "parseFloat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#sum(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Sum(float arg0, float arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "sum", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#compare(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Compare(float arg0, float arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#floatToIntBits(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FloatToIntBits(float arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "floatToIntBits", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#hashCode(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HashCode(float arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "hashCode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#valueOf(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Lang.Float"/></returns>
        public static Java.Lang.Float ValueOf(float arg0)
        {
            return SExecute<Java.Lang.Float>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Float"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Float ValueOf(string arg0)
        {
            return SExecute<Java.Lang.Float>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#toHexString(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToHexString(float arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "toHexString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#toString(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToString(float arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "toString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#intBitsToFloat(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public static float IntBitsToFloat(int arg0)
        {
            return SExecute<float>(LocalBridgeClazz, "intBitsToFloat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#floatToRawIntBits(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FloatToRawIntBits(float arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "floatToRawIntBits", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isInfinite()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsInfinite()
        {
            return IExecute<bool>("isInfinite");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#isNaN()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsNaN()
        {
            return IExecute<bool>("isNaN");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#compareTo(java.lang.Float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Float"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Lang.Float arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Float.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}