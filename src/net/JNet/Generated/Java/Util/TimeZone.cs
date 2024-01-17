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

namespace Java.Util
{
    #region TimeZone
    public partial class TimeZone
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.TimeZone"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.TimeZone t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TimeZone"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.TimeZone t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#LONG"/>
        /// </summary>
        public static int LONG { get { return SGetField<int>(LocalBridgeClazz, "LONG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#SHORT"/>
        /// </summary>
        public static int SHORT { get { return SGetField<int>(LocalBridgeClazz, "SHORT"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getAvailableIDs()"/> 
        /// </summary>
        public static string[] AvailableIDs
        {
            get { return SExecuteArray<string>(LocalBridgeClazz, "getAvailableIDs"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getDefault()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#setDefault(java.util.TimeZone)"/>
        /// </summary>
        public static Java.Util.TimeZone Default
        {
            get { return SExecute<Java.Util.TimeZone>(LocalBridgeClazz, "getDefault"); } set { SExecute(LocalBridgeClazz, "setDefault", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getTimeZone(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Util.TimeZone"/></returns>
        public static Java.Util.TimeZone GetTimeZone(Java.Time.ZoneId arg0)
        {
            return SExecute<Java.Util.TimeZone>(LocalBridgeClazz, "getTimeZone", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getAvailableIDs(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string[] GetAvailableIDs(int arg0)
        {
            return SExecuteArray<string>(LocalBridgeClazz, "getAvailableIDs", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getTimeZone(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.TimeZone"/></returns>
        public static Java.Util.TimeZone GetTimeZone(string arg0)
        {
            return SExecute<Java.Util.TimeZone>(LocalBridgeClazz, "getTimeZone", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getDisplayName()"/> 
        /// </summary>
        public string DisplayName
        {
            get { return IExecute<string>("getDisplayName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getDSTSavings()"/> 
        /// </summary>
        public int DSTSavings
        {
            get { return IExecute<int>("getDSTSavings"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getID()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#setID(java.lang.String)"/>
        /// </summary>
        public string ID
        {
            get { return IExecute<string>("getID"); } set { IExecute("setID", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getRawOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#setRawOffset(int)"/>
        /// </summary>
        public int RawOffset
        {
            get { return IExecute<int>("getRawOffset"); } set { IExecute("setRawOffset", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#inDaylightTime(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool InDaylightTime(Java.Util.Date arg0)
        {
            return IExecute<bool>("inDaylightTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#useDaylightTime()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool UseDaylightTime()
        {
            return IExecute<bool>("useDaylightTime");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getOffset(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            return IExecute<int>("getOffset", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#hasSameRules(java.util.TimeZone)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.TimeZone"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasSameRules(Java.Util.TimeZone arg0)
        {
            return IExecute<bool>("hasSameRules", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#observesDaylightTime()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool ObservesDaylightTime()
        {
            return IExecute<bool>("observesDaylightTime");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getDisplayName(boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDisplayName(bool arg0, int arg1)
        {
            return IExecute<string>("getDisplayName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getDisplayName(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDisplayName(Java.Util.Locale arg0)
        {
            return IExecute<string>("getDisplayName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getOffset(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetOffset(long arg0)
        {
            return IExecute<int>("getOffset", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getDisplayName(boolean,int,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDisplayName(bool arg0, int arg1, Java.Util.Locale arg2)
        {
            return IExecute<string>("getDisplayName", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#toZoneId()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public Java.Time.ZoneId ToZoneId()
        {
            return IExecute<Java.Time.ZoneId>("toZoneId");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}