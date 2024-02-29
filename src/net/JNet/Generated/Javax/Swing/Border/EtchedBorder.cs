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

namespace Javax.Swing.Border
{
    #region EtchedBorder
    public partial class EtchedBorder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#%3Cinit%3E(int,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        public EtchedBorder(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public EtchedBorder(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#%3Cinit%3E(java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        public EtchedBorder(Java.Awt.Color arg0, Java.Awt.Color arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#LOWERED"/>
        /// </summary>
        public static int LOWERED { get { if (!_LOWEREDReady) { _LOWEREDContent = SGetField<int>(LocalBridgeClazz, "LOWERED"); _LOWEREDReady = true; } return _LOWEREDContent; } }
        private static int _LOWEREDContent = default;
        private static bool _LOWEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#RAISED"/>
        /// </summary>
        public static int RAISED { get { if (!_RAISEDReady) { _RAISEDContent = SGetField<int>(LocalBridgeClazz, "RAISED"); _RAISEDReady = true; } return _RAISEDContent; } }
        private static int _RAISEDContent = default;
        private static bool _RAISEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#getEtchType()"/> 
        /// </summary>
        public int EtchType
        {
            get { return IExecuteWithSignature<int>("getEtchType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#getHighlightColor()"/> 
        /// </summary>
        public Java.Awt.Color HighlightColor
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getHighlightColor", "()Ljava/awt/Color;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#getShadowColor()"/> 
        /// </summary>
        public Java.Awt.Color ShadowColor
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getShadowColor", "()Ljava/awt/Color;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#getHighlightColor(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetHighlightColor(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getHighlightColor", "(Ljava/awt/Component;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#getShadowColor(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetShadowColor(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getShadowColor", "(Ljava/awt/Component;)Ljava/awt/Color;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}