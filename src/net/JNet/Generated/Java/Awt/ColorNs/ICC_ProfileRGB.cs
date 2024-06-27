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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ColorNs
{
    #region ICC_ProfileRGB
    public partial class ICC_ProfileRGB
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_ProfileRGB.html#BLUECOMPONENT"/>
        /// </summary>
        public static int BLUECOMPONENT { get { if (!_BLUECOMPONENTReady) { _BLUECOMPONENTContent = SGetField<int>(LocalBridgeClazz, "BLUECOMPONENT"); _BLUECOMPONENTReady = true; } return _BLUECOMPONENTContent; } }
        private static int _BLUECOMPONENTContent = default;
        private static bool _BLUECOMPONENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_ProfileRGB.html#GREENCOMPONENT"/>
        /// </summary>
        public static int GREENCOMPONENT { get { if (!_GREENCOMPONENTReady) { _GREENCOMPONENTContent = SGetField<int>(LocalBridgeClazz, "GREENCOMPONENT"); _GREENCOMPONENTReady = true; } return _GREENCOMPONENTContent; } }
        private static int _GREENCOMPONENTContent = default;
        private static bool _GREENCOMPONENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_ProfileRGB.html#REDCOMPONENT"/>
        /// </summary>
        public static int REDCOMPONENT { get { if (!_REDCOMPONENTReady) { _REDCOMPONENTContent = SGetField<int>(LocalBridgeClazz, "REDCOMPONENT"); _REDCOMPONENTReady = true; } return _REDCOMPONENTContent; } }
        private static int _REDCOMPONENTContent = default;
        private static bool _REDCOMPONENTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_ProfileRGB.html#getMatrix()"/> 
        /// </summary>
        public float[] Matrix
        {
            get { return IExecuteWithSignatureArray<float>("getMatrix", "()[[F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_ProfileRGB.html#getMediaWhitePoint()"/> 
        /// </summary>
        public float[] MediaWhitePoint
        {
            get { return IExecuteWithSignatureArray<float>("getMediaWhitePoint", "()[F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_ProfileRGB.html#getGamma(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetGamma(int arg0)
        {
            return IExecuteWithSignature<float>("getGamma", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_ProfileRGB.html#getTRC(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="short"/></returns>
        public short[] GetTRC(int arg0)
        {
            return IExecuteWithSignatureArray<short>("getTRC", "(I)[S", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}