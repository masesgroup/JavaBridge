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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time
{
    #region LocalTime declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html"/>
    /// </summary>
    public partial class LocalTime : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LocalTime>
    {
        const string _bridgeClassName = "java.time.LocalTime";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LocalTime() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LocalTime(params object[] args) : base(args) { }

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

    #region LocalTime implementation
    public partial class LocalTime
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalTime"/> to <see cref="Java.Time.Temporal.Temporal"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.Temporal(Java.Time.LocalTime t) => t.Cast<Java.Time.Temporal.Temporal>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalTime"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.LocalTime t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalTime"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Time.LocalTime t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalTime"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.LocalTime t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#MAX"/>
        /// </summary>
        public static Java.Time.LocalTime MAX { get { if (!_MAXReady) { _MAXContent = SGetField<Java.Time.LocalTime>(LocalBridgeClazz, "MAX"); _MAXReady = true; } return _MAXContent; } }
        private static Java.Time.LocalTime _MAXContent = default;
        private static bool _MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#MIDNIGHT"/>
        /// </summary>
        public static Java.Time.LocalTime MIDNIGHT { get { if (!_MIDNIGHTReady) { _MIDNIGHTContent = SGetField<Java.Time.LocalTime>(LocalBridgeClazz, "MIDNIGHT"); _MIDNIGHTReady = true; } return _MIDNIGHTContent; } }
        private static Java.Time.LocalTime _MIDNIGHTContent = default;
        private static bool _MIDNIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#MIN"/>
        /// </summary>
        public static Java.Time.LocalTime MIN { get { if (!_MINReady) { _MINContent = SGetField<Java.Time.LocalTime>(LocalBridgeClazz, "MIN"); _MINReady = true; } return _MINContent; } }
        private static Java.Time.LocalTime _MINContent = default;
        private static bool _MINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#NOON"/>
        /// </summary>
        public static Java.Time.LocalTime NOON { get { if (!_NOONReady) { _NOONContent = SGetField<Java.Time.LocalTime>(LocalBridgeClazz, "NOON"); _NOONReady = true; } return _NOONContent; } }
        private static Java.Time.LocalTime _NOONContent = default;
        private static bool _NOONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecuteWithSignature<Java.Time.LocalTime>(LocalBridgeClazz, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#now()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Now()
        {
            return SExecuteWithSignature<Java.Time.LocalTime>(LocalBridgeClazz, "now", "()Ljava/time/LocalTime;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#now(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Now(Java.Time.Clock arg0)
        {
            return SExecuteWithSignature<Java.Time.LocalTime>(LocalBridgeClazz, "now", "(Ljava/time/Clock;)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#now(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Now(Java.Time.ZoneId arg0)
        {
            return SExecuteWithSignature<Java.Time.LocalTime>(LocalBridgeClazz, "now", "(Ljava/time/ZoneId;)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#of(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Of(int arg0, int arg1, int arg2, int arg3)
        {
            return SExecuteWithSignature<Java.Time.LocalTime>(LocalBridgeClazz, "of", "(IIII)Ljava/time/LocalTime;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#of(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Of(int arg0, int arg1, int arg2)
        {
            return SExecuteWithSignature<Java.Time.LocalTime>(LocalBridgeClazz, "of", "(III)Ljava/time/LocalTime;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#of(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Of(int arg0, int arg1)
        {
            return SExecuteWithSignature<Java.Time.LocalTime>(LocalBridgeClazz, "of", "(II)Ljava/time/LocalTime;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#ofInstant(java.time.Instant,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime OfInstant(Java.Time.Instant arg0, Java.Time.ZoneId arg1)
        {
            return SExecuteWithSignature<Java.Time.LocalTime>(LocalBridgeClazz, "ofInstant", "(Ljava/time/Instant;Ljava/time/ZoneId;)Ljava/time/LocalTime;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#ofNanoOfDay(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime OfNanoOfDay(long arg0)
        {
            return SExecuteWithSignature<Java.Time.LocalTime>(LocalBridgeClazz, "ofNanoOfDay", "(J)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#ofSecondOfDay(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime OfSecondOfDay(long arg0)
        {
            return SExecuteWithSignature<Java.Time.LocalTime>(LocalBridgeClazz, "ofSecondOfDay", "(J)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#parse(java.lang.CharSequence,java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Parse(Java.Lang.CharSequence arg0, Java.Time.Format.DateTimeFormatter arg1)
        {
            return SExecuteWithSignature<Java.Time.LocalTime>(LocalBridgeClazz, "parse", "(Ljava/lang/CharSequence;Ljava/time/format/DateTimeFormatter;)Ljava/time/LocalTime;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public static Java.Time.LocalTime Parse(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<Java.Time.LocalTime>(LocalBridgeClazz, "parse", "(Ljava/lang/CharSequence;)Ljava/time/LocalTime;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#getHour()"/> 
        /// </summary>
        public int Hour
        {
            get { return IExecuteWithSignature<int>("getHour", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#getMinute()"/> 
        /// </summary>
        public int Minute
        {
            get { return IExecuteWithSignature<int>("getMinute", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#getNano()"/> 
        /// </summary>
        public int Nano
        {
            get { return IExecuteWithSignature<int>("getNano", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#getSecond()"/> 
        /// </summary>
        public int Second
        {
            get { return IExecuteWithSignature<int>("getSecond", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecuteWithSignature<R>("query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#isAfter(java.time.LocalTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalTime"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAfter(Java.Time.LocalTime arg0)
        {
            return IExecuteWithSignature<bool>("isAfter", "(Ljava/time/LocalTime;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#isBefore(java.time.LocalTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalTime"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsBefore(Java.Time.LocalTime arg0)
        {
            return IExecuteWithSignature<bool>("isBefore", "(Ljava/time/LocalTime;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalField;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#isSupported(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalUnit;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#compareTo(java.time.LocalTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalTime"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Time.LocalTime arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/time/LocalTime;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<int>("get", "(Ljava/time/temporal/TemporalField;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#toSecondOfDay()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ToSecondOfDay()
        {
            return IExecuteWithSignature<int>("toSecondOfDay", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#format(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#atDate(java.time.LocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime AtDate(Java.Time.LocalDate arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("atDate", "(Ljava/time/LocalDate;)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#minusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime MinusHours(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("minusHours", "(J)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#minusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime MinusMinutes(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("minusMinutes", "(J)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#minusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime MinusNanos(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("minusNanos", "(J)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#minusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime MinusSeconds(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("minusSeconds", "(J)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#plusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime PlusHours(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("plusHours", "(J)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#plusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime PlusMinutes(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("plusMinutes", "(J)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#plusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime PlusNanos(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("plusNanos", "(J)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#plusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime PlusSeconds(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("plusSeconds", "(J)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#truncatedTo(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime TruncatedTo(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("truncatedTo", "(Ljava/time/temporal/TemporalUnit;)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#withHour(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime WithHour(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("withHour", "(I)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#withMinute(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime WithMinute(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("withMinute", "(I)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#withNano(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime WithNano(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("withNano", "(I)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#withSecond(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime WithSecond(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("withSecond", "(I)Ljava/time/LocalTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#atOffset(java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime AtOffset(Java.Time.ZoneOffset arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("atOffset", "(Ljava/time/ZoneOffset;)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("adjustInto", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#minus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Minus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("minus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#minus(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Minus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("minus", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#plus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Plus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("plus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#plus(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Plus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("plus", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#with(java.time.temporal.TemporalAdjuster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAdjuster"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalAdjuster arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("with", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#with(java.time.temporal.TemporalField,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalField arg0, long arg1)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("with", "(Ljava/time/temporal/TemporalField;J)Ljava/time/temporal/Temporal;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.ValueRange>("range", "(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<long>("getLong", "(Ljava/time/temporal/TemporalField;)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#toEpochSecond(java.time.LocalDate,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToEpochSecond(Java.Time.LocalDate arg0, Java.Time.ZoneOffset arg1)
        {
            return IExecuteWithSignature<long>("toEpochSecond", "(Ljava/time/LocalDate;Ljava/time/ZoneOffset;)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#toNanoOfDay()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ToNanoOfDay()
        {
            return IExecuteWithSignature<long>("toNanoOfDay", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/LocalTime.html#until(java.time.temporal.Temporal,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="long"/></returns>
        public long Until(Java.Time.Temporal.Temporal arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecuteWithSignature<long>("until", "(Ljava/time/temporal/Temporal;Ljava/time/temporal/TemporalUnit;)J", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}