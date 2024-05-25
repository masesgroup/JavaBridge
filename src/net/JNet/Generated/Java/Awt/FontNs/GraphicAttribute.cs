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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.FontNs
{
    #region GraphicAttribute
    public partial class GraphicAttribute
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#BOTTOM_ALIGNMENT"/>
        /// </summary>
        public static int BOTTOM_ALIGNMENT { get { if (!_BOTTOM_ALIGNMENTReady) { _BOTTOM_ALIGNMENTContent = SGetField<int>(LocalBridgeClazz, "BOTTOM_ALIGNMENT"); _BOTTOM_ALIGNMENTReady = true; } return _BOTTOM_ALIGNMENTContent; } }
        private static int _BOTTOM_ALIGNMENTContent = default;
        private static bool _BOTTOM_ALIGNMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#CENTER_BASELINE"/>
        /// </summary>
        public static int CENTER_BASELINE { get { if (!_CENTER_BASELINEReady) { _CENTER_BASELINEContent = SGetField<int>(LocalBridgeClazz, "CENTER_BASELINE"); _CENTER_BASELINEReady = true; } return _CENTER_BASELINEContent; } }
        private static int _CENTER_BASELINEContent = default;
        private static bool _CENTER_BASELINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#HANGING_BASELINE"/>
        /// </summary>
        public static int HANGING_BASELINE { get { if (!_HANGING_BASELINEReady) { _HANGING_BASELINEContent = SGetField<int>(LocalBridgeClazz, "HANGING_BASELINE"); _HANGING_BASELINEReady = true; } return _HANGING_BASELINEContent; } }
        private static int _HANGING_BASELINEContent = default;
        private static bool _HANGING_BASELINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#ROMAN_BASELINE"/>
        /// </summary>
        public static int ROMAN_BASELINE { get { if (!_ROMAN_BASELINEReady) { _ROMAN_BASELINEContent = SGetField<int>(LocalBridgeClazz, "ROMAN_BASELINE"); _ROMAN_BASELINEReady = true; } return _ROMAN_BASELINEContent; } }
        private static int _ROMAN_BASELINEContent = default;
        private static bool _ROMAN_BASELINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#TOP_ALIGNMENT"/>
        /// </summary>
        public static int TOP_ALIGNMENT { get { if (!_TOP_ALIGNMENTReady) { _TOP_ALIGNMENTContent = SGetField<int>(LocalBridgeClazz, "TOP_ALIGNMENT"); _TOP_ALIGNMENTReady = true; } return _TOP_ALIGNMENTContent; } }
        private static int _TOP_ALIGNMENTContent = default;
        private static bool _TOP_ALIGNMENTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#getAdvance()"/> 
        /// </summary>
        public float Advance
        {
            get { return IExecuteWithSignature<float>("getAdvance", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#getAlignment()"/> 
        /// </summary>
        public int Alignment
        {
            get { return IExecuteWithSignature<int>("getAlignment", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#getAscent()"/> 
        /// </summary>
        public float Ascent
        {
            get { return IExecuteWithSignature<float>("getAscent", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#getBounds()"/> 
        /// </summary>
        public Java.Awt.Geom.Rectangle2D Bounds
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.Rectangle2D>("getBounds", "()Ljava/awt/geom/Rectangle2D;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#getDescent()"/> 
        /// </summary>
        public float Descent
        {
            get { return IExecuteWithSignature<float>("getDescent", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#getJustificationInfo()"/> 
        /// </summary>
        public Java.Awt.FontNs.GlyphJustificationInfo JustificationInfo
        {
            get { return IExecuteWithSignature<Java.Awt.FontNs.GlyphJustificationInfo>("getJustificationInfo", "()Ljava/awt/font/GlyphJustificationInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#draw(java.awt.Graphics2D,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics2D"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void Draw(Java.Awt.Graphics2D arg0, float arg1, float arg2)
        {
            IExecute("draw", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#getOutline(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetOutline(Java.Awt.Geom.AffineTransform arg0)
        {
            return IExecuteWithSignature<Java.Awt.Shape>("getOutline", "(Ljava/awt/geom/AffineTransform;)Ljava/awt/Shape;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}