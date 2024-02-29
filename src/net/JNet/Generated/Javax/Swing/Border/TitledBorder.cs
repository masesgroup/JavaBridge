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
    #region TitledBorder
    public partial class TitledBorder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public TitledBorder(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#%3Cinit%3E(javax.swing.border.Border,java.lang.String,int,int,java.awt.Font,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Font"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Color"/></param>
        public TitledBorder(Javax.Swing.Border.Border arg0, Java.Lang.String arg1, int arg2, int arg3, Java.Awt.Font arg4, Java.Awt.Color arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#%3Cinit%3E(javax.swing.border.Border,java.lang.String,int,int,java.awt.Font)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Font"/></param>
        public TitledBorder(Javax.Swing.Border.Border arg0, Java.Lang.String arg1, int arg2, int arg3, Java.Awt.Font arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#%3Cinit%3E(javax.swing.border.Border,java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public TitledBorder(Javax.Swing.Border.Border arg0, Java.Lang.String arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#%3Cinit%3E(javax.swing.border.Border,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public TitledBorder(Javax.Swing.Border.Border arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#%3Cinit%3E(javax.swing.border.Border)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        public TitledBorder(Javax.Swing.Border.Border arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#ABOVE_BOTTOM"/>
        /// </summary>
        public static int ABOVE_BOTTOM { get { if (!_ABOVE_BOTTOMReady) { _ABOVE_BOTTOMContent = SGetField<int>(LocalBridgeClazz, "ABOVE_BOTTOM"); _ABOVE_BOTTOMReady = true; } return _ABOVE_BOTTOMContent; } }
        private static int _ABOVE_BOTTOMContent = default;
        private static bool _ABOVE_BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#ABOVE_TOP"/>
        /// </summary>
        public static int ABOVE_TOP { get { if (!_ABOVE_TOPReady) { _ABOVE_TOPContent = SGetField<int>(LocalBridgeClazz, "ABOVE_TOP"); _ABOVE_TOPReady = true; } return _ABOVE_TOPContent; } }
        private static int _ABOVE_TOPContent = default;
        private static bool _ABOVE_TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#BELOW_BOTTOM"/>
        /// </summary>
        public static int BELOW_BOTTOM { get { if (!_BELOW_BOTTOMReady) { _BELOW_BOTTOMContent = SGetField<int>(LocalBridgeClazz, "BELOW_BOTTOM"); _BELOW_BOTTOMReady = true; } return _BELOW_BOTTOMContent; } }
        private static int _BELOW_BOTTOMContent = default;
        private static bool _BELOW_BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#BELOW_TOP"/>
        /// </summary>
        public static int BELOW_TOP { get { if (!_BELOW_TOPReady) { _BELOW_TOPContent = SGetField<int>(LocalBridgeClazz, "BELOW_TOP"); _BELOW_TOPReady = true; } return _BELOW_TOPContent; } }
        private static int _BELOW_TOPContent = default;
        private static bool _BELOW_TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#BOTTOM"/>
        /// </summary>
        public static int BOTTOM { get { if (!_BOTTOMReady) { _BOTTOMContent = SGetField<int>(LocalBridgeClazz, "BOTTOM"); _BOTTOMReady = true; } return _BOTTOMContent; } }
        private static int _BOTTOMContent = default;
        private static bool _BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#CENTER"/>
        /// </summary>
        public static int CENTER { get { if (!_CENTERReady) { _CENTERContent = SGetField<int>(LocalBridgeClazz, "CENTER"); _CENTERReady = true; } return _CENTERContent; } }
        private static int _CENTERContent = default;
        private static bool _CENTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#DEFAULT_JUSTIFICATION"/>
        /// </summary>
        public static int DEFAULT_JUSTIFICATION { get { if (!_DEFAULT_JUSTIFICATIONReady) { _DEFAULT_JUSTIFICATIONContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_JUSTIFICATION"); _DEFAULT_JUSTIFICATIONReady = true; } return _DEFAULT_JUSTIFICATIONContent; } }
        private static int _DEFAULT_JUSTIFICATIONContent = default;
        private static bool _DEFAULT_JUSTIFICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#DEFAULT_POSITION"/>
        /// </summary>
        public static int DEFAULT_POSITION { get { if (!_DEFAULT_POSITIONReady) { _DEFAULT_POSITIONContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_POSITION"); _DEFAULT_POSITIONReady = true; } return _DEFAULT_POSITIONContent; } }
        private static int _DEFAULT_POSITIONContent = default;
        private static bool _DEFAULT_POSITIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#LEADING"/>
        /// </summary>
        public static int LEADING { get { if (!_LEADINGReady) { _LEADINGContent = SGetField<int>(LocalBridgeClazz, "LEADING"); _LEADINGReady = true; } return _LEADINGContent; } }
        private static int _LEADINGContent = default;
        private static bool _LEADINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#LEFT"/>
        /// </summary>
        public static int LEFT { get { if (!_LEFTReady) { _LEFTContent = SGetField<int>(LocalBridgeClazz, "LEFT"); _LEFTReady = true; } return _LEFTContent; } }
        private static int _LEFTContent = default;
        private static bool _LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#RIGHT"/>
        /// </summary>
        public static int RIGHT { get { if (!_RIGHTReady) { _RIGHTContent = SGetField<int>(LocalBridgeClazz, "RIGHT"); _RIGHTReady = true; } return _RIGHTContent; } }
        private static int _RIGHTContent = default;
        private static bool _RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#TOP"/>
        /// </summary>
        public static int TOP { get { if (!_TOPReady) { _TOPContent = SGetField<int>(LocalBridgeClazz, "TOP"); _TOPReady = true; } return _TOPContent; } }
        private static int _TOPContent = default;
        private static bool _TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#TRAILING"/>
        /// </summary>
        public static int TRAILING { get { if (!_TRAILINGReady) { _TRAILINGContent = SGetField<int>(LocalBridgeClazz, "TRAILING"); _TRAILINGReady = true; } return _TRAILINGContent; } }
        private static int _TRAILINGContent = default;
        private static bool _TRAILINGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#getBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#setBorder(javax.swing.border.Border)"/>
        /// </summary>
        public Javax.Swing.Border.Border Border
        {
            get { return IExecuteWithSignature<Javax.Swing.Border.Border>("getBorder", "()Ljavax/swing/border/Border;"); } set { IExecuteWithSignature("setBorder", "(Ljavax/swing/border/Border;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#getTitle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#setTitle(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Title
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTitle", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setTitle", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#getTitleColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#setTitleColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color TitleColor
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getTitleColor", "()Ljava/awt/Color;"); } set { IExecuteWithSignature("setTitleColor", "(Ljava/awt/Color;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#getTitleFont()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#setTitleFont(java.awt.Font)"/>
        /// </summary>
        public Java.Awt.Font TitleFont
        {
            get { return IExecuteWithSignature<Java.Awt.Font>("getTitleFont", "()Ljava/awt/Font;"); } set { IExecuteWithSignature("setTitleFont", "(Ljava/awt/Font;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#getTitleJustification()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#setTitleJustification(int)"/>
        /// </summary>
        public int TitleJustification
        {
            get { return IExecuteWithSignature<int>("getTitleJustification", "()I"); } set { IExecuteWithSignature("setTitleJustification", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#getTitlePosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#setTitlePosition(int)"/>
        /// </summary>
        public int TitlePosition
        {
            get { return IExecuteWithSignature<int>("getTitlePosition", "()I"); } set { IExecuteWithSignature("setTitlePosition", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#getMinimumSize(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension GetMinimumSize(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("getMinimumSize", "(Ljava/awt/Component;)Ljava/awt/Dimension;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}