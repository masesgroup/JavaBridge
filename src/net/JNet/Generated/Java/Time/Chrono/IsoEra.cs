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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time.Chrono
{
    #region IsoEra
    public partial class IsoEra
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.IsoEra"/> to <see cref="Java.Time.Chrono.Era"/>
        /// </summary>
        public static implicit operator Java.Time.Chrono.Era(Java.Time.Chrono.IsoEra t) => t.Cast<Java.Time.Chrono.Era>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/IsoEra.html#BCE"/>
        /// </summary>
        public static Java.Time.Chrono.IsoEra BCE { get { if (!_BCEReady) { _BCEContent = SGetField<Java.Time.Chrono.IsoEra>(LocalBridgeClazz, "BCE"); _BCEReady = true; } return _BCEContent; } }
        private static Java.Time.Chrono.IsoEra _BCEContent = default;
        private static bool _BCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/IsoEra.html#CE"/>
        /// </summary>
        public static Java.Time.Chrono.IsoEra CE { get { if (!_CEReady) { _CEContent = SGetField<Java.Time.Chrono.IsoEra>(LocalBridgeClazz, "CE"); _CEReady = true; } return _CEContent; } }
        private static Java.Time.Chrono.IsoEra _CEContent = default;
        private static bool _CEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/IsoEra.html#of(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.IsoEra"/></returns>
        public static Java.Time.Chrono.IsoEra Of(int arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.IsoEra>(LocalBridgeClazz, "of", "(I)Ljava/time/chrono/IsoEra;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/IsoEra.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Chrono.IsoEra"/></returns>
        public static Java.Time.Chrono.IsoEra ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.IsoEra>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/time/chrono/IsoEra;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/IsoEra.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Chrono.IsoEra"/></returns>
        public static Java.Time.Chrono.IsoEra[] Values()
        {
            return SExecuteWithSignatureArray<Java.Time.Chrono.IsoEra>(LocalBridgeClazz, "values", "()[Ljava/time/chrono/IsoEra;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/IsoEra.html#getValue()"/> 
        /// </summary>
        public int Value
        {
            get { return IExecuteWithSignature<int>("getValue", "()I"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}