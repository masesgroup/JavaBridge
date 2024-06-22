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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time.Zone
{
    #region ZoneOffsetTransitionRule
    public partial class ZoneOffsetTransitionRule
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.html#of(java.time.Month,int,java.time.DayOfWeek,java.time.LocalTime,boolean,java.time.zone.ZoneOffsetTransitionRule.TimeDefinition,java.time.ZoneOffset,java.time.ZoneOffset,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Month"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Time.DayOfWeek"/></param>
        /// <param name="arg3"><see cref="Java.Time.LocalTime"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition"/></param>
        /// <param name="arg6"><see cref="Java.Time.ZoneOffset"/></param>
        /// <param name="arg7"><see cref="Java.Time.ZoneOffset"/></param>
        /// <param name="arg8"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneOffsetTransitionRule"/></returns>
        public static Java.Time.Zone.ZoneOffsetTransitionRule Of(Java.Time.Month arg0, int arg1, Java.Time.DayOfWeek arg2, Java.Time.LocalTime arg3, bool arg4, Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition arg5, Java.Time.ZoneOffset arg6, Java.Time.ZoneOffset arg7, Java.Time.ZoneOffset arg8)
        {
            return SExecute<Java.Time.Zone.ZoneOffsetTransitionRule>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.html#getDayOfMonthIndicator()"/> 
        /// </summary>
        public int DayOfMonthIndicator
        {
            get { return IExecuteWithSignature<int>("getDayOfMonthIndicator", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.html#getDayOfWeek()"/> 
        /// </summary>
        public Java.Time.DayOfWeek DayOfWeek
        {
            get { return IExecuteWithSignature<Java.Time.DayOfWeek>("getDayOfWeek", "()Ljava/time/DayOfWeek;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.html#getTimeDefinition()"/> 
        /// </summary>
        public Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition GetTimeDefinition
        {
            get { return IExecuteWithSignature<Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition>("getTimeDefinition", "()Ljava/time/zone/ZoneOffsetTransitionRule$TimeDefinition;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.html#getLocalTime()"/> 
        /// </summary>
        public Java.Time.LocalTime LocalTime
        {
            get { return IExecuteWithSignature<Java.Time.LocalTime>("getLocalTime", "()Ljava/time/LocalTime;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.html#getMonth()"/> 
        /// </summary>
        public Java.Time.Month Month
        {
            get { return IExecuteWithSignature<Java.Time.Month>("getMonth", "()Ljava/time/Month;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.html#getOffsetAfter()"/> 
        /// </summary>
        public Java.Time.ZoneOffset OffsetAfter
        {
            get { return IExecuteWithSignature<Java.Time.ZoneOffset>("getOffsetAfter", "()Ljava/time/ZoneOffset;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.html#getOffsetBefore()"/> 
        /// </summary>
        public Java.Time.ZoneOffset OffsetBefore
        {
            get { return IExecuteWithSignature<Java.Time.ZoneOffset>("getOffsetBefore", "()Ljava/time/ZoneOffset;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.html#getStandardOffset()"/> 
        /// </summary>
        public Java.Time.ZoneOffset StandardOffset
        {
            get { return IExecuteWithSignature<Java.Time.ZoneOffset>("getStandardOffset", "()Ljava/time/ZoneOffset;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.html#isMidnightEndOfDay()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMidnightEndOfDay()
        {
            return IExecuteWithSignature<bool>("isMidnightEndOfDay", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.html#createTransition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneOffsetTransition"/></returns>
        public Java.Time.Zone.ZoneOffsetTransition CreateTransition(int arg0)
        {
            return IExecuteWithSignature<Java.Time.Zone.ZoneOffsetTransition>("createTransition", "(I)Ljava/time/zone/ZoneOffsetTransition;", arg0);
        }

        #endregion

        #region Nested classes
        #region TimeDefinition
        public partial class TimeDefinition
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.TimeDefinition.html#STANDARD"/>
            /// </summary>
            public static Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition STANDARD { get { if (!_STANDARDReady) { _STANDARDContent = SGetField<Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition>(LocalBridgeClazz, "STANDARD"); _STANDARDReady = true; } return _STANDARDContent; } }
            private static Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition _STANDARDContent = default;
            private static bool _STANDARDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.TimeDefinition.html#UTC"/>
            /// </summary>
            public static Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition UTC { get { if (!_UTCReady) { _UTCContent = SGetField<Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition>(LocalBridgeClazz, "UTC"); _UTCReady = true; } return _UTCContent; } }
            private static Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition _UTCContent = default;
            private static bool _UTCReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.TimeDefinition.html#WALL"/>
            /// </summary>
            public static Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition WALL { get { if (!_WALLReady) { _WALLContent = SGetField<Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition>(LocalBridgeClazz, "WALL"); _WALLReady = true; } return _WALLContent; } }
            private static Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition _WALLContent = default;
            private static bool _WALLReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.TimeDefinition.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition"/></returns>
            public static Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/time/zone/ZoneOffsetTransitionRule$TimeDefinition;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.TimeDefinition.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition"/></returns>
            public static Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition[] Values()
            {
                return SExecuteWithSignatureArray<Java.Time.Zone.ZoneOffsetTransitionRule.TimeDefinition>(LocalBridgeClazz, "values", "()[Ljava/time/zone/ZoneOffsetTransitionRule$TimeDefinition;");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneOffsetTransitionRule.TimeDefinition.html#createDateTime(java.time.LocalDateTime,java.time.ZoneOffset,java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
            /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
            /// <param name="arg2"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
            public Java.Time.LocalDateTime CreateDateTime(Java.Time.LocalDateTime arg0, Java.Time.ZoneOffset arg1, Java.Time.ZoneOffset arg2)
            {
                return IExecute<Java.Time.LocalDateTime>("createDateTime", arg0, arg1, arg2);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}