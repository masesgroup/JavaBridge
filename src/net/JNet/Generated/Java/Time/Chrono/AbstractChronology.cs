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

namespace Java.Time.Chrono
{
    #region AbstractChronology
    public partial class AbstractChronology
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.AbstractChronology"/> to <see cref="Java.Time.Chrono.Chronology"/>
        /// </summary>
        public static implicit operator Java.Time.Chrono.Chronology(Java.Time.Chrono.AbstractChronology t) => t.Cast<Java.Time.Chrono.Chronology>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/AbstractChronology.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/AbstractChronology.html#compareTo(java.time.chrono.Chronology)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Chronology"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Time.Chrono.Chronology arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/AbstractChronology.html#resolveDate(java.util.Map%3Cjava.time.temporal.TemporalField, java.lang.Long%3E,java.time.format.ResolverStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.ResolverStyle"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate ResolveDate(Java.Util.Map arg0, Java.Time.Format.ResolverStyle arg1)
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDate>("resolveDate", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}