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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.FontNs
{
    #region GlyphMetrics
    public partial class GlyphMetrics
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#%3Cinit%3E(boolean,float,float,java.awt.geom.Rectangle2D,byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg4"><see cref="byte"/></param>
        public GlyphMetrics(bool arg0, float arg1, float arg2, Java.Awt.Geom.Rectangle2D arg3, byte arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#%3Cinit%3E(float,java.awt.geom.Rectangle2D,byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        public GlyphMetrics(float arg0, Java.Awt.Geom.Rectangle2D arg1, byte arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#COMBINING"/>
        /// </summary>
        public static byte COMBINING { get { if (!_COMBININGReady) { _COMBININGContent = SGetField<byte>(LocalBridgeClazz, "COMBINING"); _COMBININGReady = true; } return _COMBININGContent; } }
        private static byte _COMBININGContent = default;
        private static bool _COMBININGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#COMPONENT"/>
        /// </summary>
        public static byte COMPONENT { get { if (!_COMPONENTReady) { _COMPONENTContent = SGetField<byte>(LocalBridgeClazz, "COMPONENT"); _COMPONENTReady = true; } return _COMPONENTContent; } }
        private static byte _COMPONENTContent = default;
        private static bool _COMPONENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#LIGATURE"/>
        /// </summary>
        public static byte LIGATURE { get { if (!_LIGATUREReady) { _LIGATUREContent = SGetField<byte>(LocalBridgeClazz, "LIGATURE"); _LIGATUREReady = true; } return _LIGATUREContent; } }
        private static byte _LIGATUREContent = default;
        private static bool _LIGATUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#STANDARD"/>
        /// </summary>
        public static byte STANDARD { get { if (!_STANDARDReady) { _STANDARDContent = SGetField<byte>(LocalBridgeClazz, "STANDARD"); _STANDARDReady = true; } return _STANDARDContent; } }
        private static byte _STANDARDContent = default;
        private static bool _STANDARDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#WHITESPACE"/>
        /// </summary>
        public static byte WHITESPACE { get { if (!_WHITESPACEReady) { _WHITESPACEContent = SGetField<byte>(LocalBridgeClazz, "WHITESPACE"); _WHITESPACEReady = true; } return _WHITESPACEContent; } }
        private static byte _WHITESPACEContent = default;
        private static bool _WHITESPACEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#getAdvance()"/> 
        /// </summary>
        public float Advance
        {
            get { return IExecuteWithSignature<float>("getAdvance", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#getAdvanceX()"/> 
        /// </summary>
        public float AdvanceX
        {
            get { return IExecuteWithSignature<float>("getAdvanceX", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#getAdvanceY()"/> 
        /// </summary>
        public float AdvanceY
        {
            get { return IExecuteWithSignature<float>("getAdvanceY", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#getBounds2D()"/> 
        /// </summary>
        public Java.Awt.Geom.Rectangle2D Bounds2D
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.Rectangle2D>("getBounds2D", "()Ljava/awt/geom/Rectangle2D;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#getLSB()"/> 
        /// </summary>
        public float LSB
        {
            get { return IExecuteWithSignature<float>("getLSB", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#getRSB()"/> 
        /// </summary>
        public float RSB
        {
            get { return IExecuteWithSignature<float>("getRSB", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#isCombining()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCombining()
        {
            return IExecuteWithSignature<bool>("isCombining", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#isComponent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsComponent()
        {
            return IExecuteWithSignature<bool>("isComponent", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#isLigature()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLigature()
        {
            return IExecuteWithSignature<bool>("isLigature", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#isStandard()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStandard()
        {
            return IExecuteWithSignature<bool>("isStandard", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#isWhitespace()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWhitespace()
        {
            return IExecuteWithSignature<bool>("isWhitespace", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}