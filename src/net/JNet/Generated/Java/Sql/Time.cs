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

namespace Java.Sql
{
    #region Time
    public partial class Time
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Time.html#%3Cinit%3E(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public Time(long arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Time.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.Time"/></returns>
        public static Java.Sql.Time ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Sql.Time>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/sql/Time;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Time.html#valueOf(java.time.LocalTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalTime"/></param>
        /// <returns><see cref="Java.Sql.Time"/></returns>
        public static Java.Sql.Time ValueOf(Java.Time.LocalTime arg0)
        {
            return SExecuteWithSignature<Java.Sql.Time>(LocalBridgeClazz, "valueOf", "(Ljava/time/LocalTime;)Ljava/sql/Time;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Time.html#toLocalTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime ToLocalTime()
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("toLocalTime", "()Ljava/time/LocalTime;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}