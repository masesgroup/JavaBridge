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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Logging
{
    #region Level
    public partial class Level
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#ALL"/>
        /// </summary>
        public static Java.Util.Logging.Level ALL { get { if (!_ALLReady) { _ALLContent = SGetField<Java.Util.Logging.Level>(LocalBridgeClazz, "ALL"); _ALLReady = true; } return _ALLContent; } }
        private static Java.Util.Logging.Level _ALLContent = default;
        private static bool _ALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#CONFIG"/>
        /// </summary>
        public static Java.Util.Logging.Level CONFIG { get { if (!_CONFIGReady) { _CONFIGContent = SGetField<Java.Util.Logging.Level>(LocalBridgeClazz, "CONFIG"); _CONFIGReady = true; } return _CONFIGContent; } }
        private static Java.Util.Logging.Level _CONFIGContent = default;
        private static bool _CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#FINE"/>
        /// </summary>
        public static Java.Util.Logging.Level FINE { get { if (!_FINEReady) { _FINEContent = SGetField<Java.Util.Logging.Level>(LocalBridgeClazz, "FINE"); _FINEReady = true; } return _FINEContent; } }
        private static Java.Util.Logging.Level _FINEContent = default;
        private static bool _FINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#FINER"/>
        /// </summary>
        public static Java.Util.Logging.Level FINER { get { if (!_FINERReady) { _FINERContent = SGetField<Java.Util.Logging.Level>(LocalBridgeClazz, "FINER"); _FINERReady = true; } return _FINERContent; } }
        private static Java.Util.Logging.Level _FINERContent = default;
        private static bool _FINERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#FINEST"/>
        /// </summary>
        public static Java.Util.Logging.Level FINEST { get { if (!_FINESTReady) { _FINESTContent = SGetField<Java.Util.Logging.Level>(LocalBridgeClazz, "FINEST"); _FINESTReady = true; } return _FINESTContent; } }
        private static Java.Util.Logging.Level _FINESTContent = default;
        private static bool _FINESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#INFO"/>
        /// </summary>
        public static Java.Util.Logging.Level INFO { get { if (!_INFOReady) { _INFOContent = SGetField<Java.Util.Logging.Level>(LocalBridgeClazz, "INFO"); _INFOReady = true; } return _INFOContent; } }
        private static Java.Util.Logging.Level _INFOContent = default;
        private static bool _INFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#OFF"/>
        /// </summary>
        public static Java.Util.Logging.Level OFF { get { if (!_OFFReady) { _OFFContent = SGetField<Java.Util.Logging.Level>(LocalBridgeClazz, "OFF"); _OFFReady = true; } return _OFFContent; } }
        private static Java.Util.Logging.Level _OFFContent = default;
        private static bool _OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#SEVERE"/>
        /// </summary>
        public static Java.Util.Logging.Level SEVERE { get { if (!_SEVEREReady) { _SEVEREContent = SGetField<Java.Util.Logging.Level>(LocalBridgeClazz, "SEVERE"); _SEVEREReady = true; } return _SEVEREContent; } }
        private static Java.Util.Logging.Level _SEVEREContent = default;
        private static bool _SEVEREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#WARNING"/>
        /// </summary>
        public static Java.Util.Logging.Level WARNING { get { if (!_WARNINGReady) { _WARNINGContent = SGetField<Java.Util.Logging.Level>(LocalBridgeClazz, "WARNING"); _WARNINGReady = true; } return _WARNINGContent; } }
        private static Java.Util.Logging.Level _WARNINGContent = default;
        private static bool _WARNINGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Logging.Level"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public static Java.Util.Logging.Level Parse(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Logging.Level>(LocalBridgeClazz, "parse", "(Ljava/lang/String;)Ljava/util/logging/Level;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#getLocalizedName()"/> 
        /// </summary>
        public Java.Lang.String LocalizedName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLocalizedName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#getResourceBundleName()"/> 
        /// </summary>
        public Java.Lang.String ResourceBundleName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getResourceBundleName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#intValue()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int IntValue()
        {
            return IExecuteWithSignature<int>("intValue", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}