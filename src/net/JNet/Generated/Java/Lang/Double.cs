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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Double declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html"/>
    /// </summary>
    public partial class Double : Java.Lang.Number
    {
        const string _bridgeClassName = "java.lang.Double";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Double() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Double(params object[] args) : base(args) { }

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
        public override bool IsBridgeCloseable => false;
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

    #region Double implementation
    public partial class Double
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Double"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Lang.Double t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#MAX_VALUE"/>
        /// </summary>
        public static double MAX_VALUE { get { if (!_MAX_VALUEReady) { _MAX_VALUEContent = SGetField<double>(LocalBridgeClazz, "MAX_VALUE"); _MAX_VALUEReady = true; } return _MAX_VALUEContent; } }
        private static double _MAX_VALUEContent = default;
        private static bool _MAX_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#MIN_NORMAL"/>
        /// </summary>
        public static double MIN_NORMAL { get { if (!_MIN_NORMALReady) { _MIN_NORMALContent = SGetField<double>(LocalBridgeClazz, "MIN_NORMAL"); _MIN_NORMALReady = true; } return _MIN_NORMALContent; } }
        private static double _MIN_NORMALContent = default;
        private static bool _MIN_NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#MIN_VALUE"/>
        /// </summary>
        public static double MIN_VALUE { get { if (!_MIN_VALUEReady) { _MIN_VALUEContent = SGetField<double>(LocalBridgeClazz, "MIN_VALUE"); _MIN_VALUEReady = true; } return _MIN_VALUEContent; } }
        private static double _MIN_VALUEContent = default;
        private static bool _MIN_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#NaN"/>
        /// </summary>
        public static double NaN { get { if (!_NaNReady) { _NaNContent = SGetField<double>(LocalBridgeClazz, "NaN"); _NaNReady = true; } return _NaNContent; } }
        private static double _NaNContent = default;
        private static bool _NaNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#NEGATIVE_INFINITY"/>
        /// </summary>
        public static double NEGATIVE_INFINITY { get { if (!_NEGATIVE_INFINITYReady) { _NEGATIVE_INFINITYContent = SGetField<double>(LocalBridgeClazz, "NEGATIVE_INFINITY"); _NEGATIVE_INFINITYReady = true; } return _NEGATIVE_INFINITYContent; } }
        private static double _NEGATIVE_INFINITYContent = default;
        private static bool _NEGATIVE_INFINITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#POSITIVE_INFINITY"/>
        /// </summary>
        public static double POSITIVE_INFINITY { get { if (!_POSITIVE_INFINITYReady) { _POSITIVE_INFINITYContent = SGetField<double>(LocalBridgeClazz, "POSITIVE_INFINITY"); _POSITIVE_INFINITYReady = true; } return _POSITIVE_INFINITYContent; } }
        private static double _POSITIVE_INFINITYContent = default;
        private static bool _POSITIVE_INFINITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#BYTES"/>
        /// </summary>
        public static int BYTES { get { if (!_BYTESReady) { _BYTESContent = SGetField<int>(LocalBridgeClazz, "BYTES"); _BYTESReady = true; } return _BYTESContent; } }
        private static int _BYTESContent = default;
        private static bool _BYTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#MAX_EXPONENT"/>
        /// </summary>
        public static int MAX_EXPONENT { get { if (!_MAX_EXPONENTReady) { _MAX_EXPONENTContent = SGetField<int>(LocalBridgeClazz, "MAX_EXPONENT"); _MAX_EXPONENTReady = true; } return _MAX_EXPONENTContent; } }
        private static int _MAX_EXPONENTContent = default;
        private static bool _MAX_EXPONENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#MIN_EXPONENT"/>
        /// </summary>
        public static int MIN_EXPONENT { get { if (!_MIN_EXPONENTReady) { _MIN_EXPONENTContent = SGetField<int>(LocalBridgeClazz, "MIN_EXPONENT"); _MIN_EXPONENTReady = true; } return _MIN_EXPONENTContent; } }
        private static int _MIN_EXPONENTContent = default;
        private static bool _MIN_EXPONENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#SIZE"/>
        /// </summary>
        public static int SIZE { get { if (!_SIZEReady) { _SIZEContent = SGetField<int>(LocalBridgeClazz, "SIZE"); _SIZEReady = true; } return _SIZEContent; } }
        private static int _SIZEContent = default;
        private static bool _SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#TYPE"/>
        /// </summary>
        public static Java.Lang.Class TYPE { get { if (!_TYPEReady) { _TYPEContent = SGetField<Java.Lang.Class>(LocalBridgeClazz, "TYPE"); _TYPEReady = true; } return _TYPEContent; } }
        private static Java.Lang.Class _TYPEContent = default;
        private static bool _TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#isFinite(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsFinite(double arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isFinite", "(D)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#isInfinite(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsInfinite(double arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isInfinite", "(D)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#isNaN(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNaN(double arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isNaN", "(D)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#max(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Max(double arg0, double arg1)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "max", "(DD)D", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#min(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Min(double arg0, double arg1)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "min", "(DD)D", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#parseDouble(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static double ParseDouble(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "parseDouble", "(Ljava/lang/String;)D", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#sum(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Sum(double arg0, double arg1)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "sum", "(DD)D", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#compare(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Compare(double arg0, double arg1)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "compare", "(DD)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#hashCode(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HashCode(double arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "hashCode", "(D)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#valueOf(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Lang.Double"/></returns>
        public static Java.Lang.Double ValueOf(double arg0)
        {
            return SExecuteWithSignature<Java.Lang.Double>(LocalBridgeClazz, "valueOf", "(D)Ljava/lang/Double;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Double"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Double ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.Double>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/lang/Double;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#toHexString(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToHexString(double arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toHexString", "(D)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#toString(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToString(double arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toString", "(D)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#doubleToLongBits(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="long"/></returns>
        public static long DoubleToLongBits(double arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "doubleToLongBits", "(D)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#longBitsToDouble(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="double"/></returns>
        public static double LongBitsToDouble(long arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "longBitsToDouble", "(J)D", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#doubleToRawLongBits(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="long"/></returns>
        public static long DoubleToRawLongBits(double arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "doubleToRawLongBits", "(D)J", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#isInfinite()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInfinite()
        {
            return IExecuteWithSignature<bool>("isInfinite", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#isNaN()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNaN()
        {
            return IExecuteWithSignature<bool>("isNaN", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#compareTo(java.lang.Double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Double"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Lang.Double arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Double;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Double.html#compareTo(java.lang.Object)"/>
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