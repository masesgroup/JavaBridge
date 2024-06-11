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

namespace Java.Awt
{
    #region Cursor
    public partial class Cursor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Cursor(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#CROSSHAIR_CURSOR"/>
        /// </summary>
        public static int CROSSHAIR_CURSOR { get { if (!_CROSSHAIR_CURSORReady) { _CROSSHAIR_CURSORContent = SGetField<int>(LocalBridgeClazz, "CROSSHAIR_CURSOR"); _CROSSHAIR_CURSORReady = true; } return _CROSSHAIR_CURSORContent; } }
        private static int _CROSSHAIR_CURSORContent = default;
        private static bool _CROSSHAIR_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#CUSTOM_CURSOR"/>
        /// </summary>
        public static int CUSTOM_CURSOR { get { if (!_CUSTOM_CURSORReady) { _CUSTOM_CURSORContent = SGetField<int>(LocalBridgeClazz, "CUSTOM_CURSOR"); _CUSTOM_CURSORReady = true; } return _CUSTOM_CURSORContent; } }
        private static int _CUSTOM_CURSORContent = default;
        private static bool _CUSTOM_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#DEFAULT_CURSOR"/>
        /// </summary>
        public static int DEFAULT_CURSOR { get { if (!_DEFAULT_CURSORReady) { _DEFAULT_CURSORContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_CURSOR"); _DEFAULT_CURSORReady = true; } return _DEFAULT_CURSORContent; } }
        private static int _DEFAULT_CURSORContent = default;
        private static bool _DEFAULT_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#E_RESIZE_CURSOR"/>
        /// </summary>
        public static int E_RESIZE_CURSOR { get { if (!_E_RESIZE_CURSORReady) { _E_RESIZE_CURSORContent = SGetField<int>(LocalBridgeClazz, "E_RESIZE_CURSOR"); _E_RESIZE_CURSORReady = true; } return _E_RESIZE_CURSORContent; } }
        private static int _E_RESIZE_CURSORContent = default;
        private static bool _E_RESIZE_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#HAND_CURSOR"/>
        /// </summary>
        public static int HAND_CURSOR { get { if (!_HAND_CURSORReady) { _HAND_CURSORContent = SGetField<int>(LocalBridgeClazz, "HAND_CURSOR"); _HAND_CURSORReady = true; } return _HAND_CURSORContent; } }
        private static int _HAND_CURSORContent = default;
        private static bool _HAND_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#MOVE_CURSOR"/>
        /// </summary>
        public static int MOVE_CURSOR { get { if (!_MOVE_CURSORReady) { _MOVE_CURSORContent = SGetField<int>(LocalBridgeClazz, "MOVE_CURSOR"); _MOVE_CURSORReady = true; } return _MOVE_CURSORContent; } }
        private static int _MOVE_CURSORContent = default;
        private static bool _MOVE_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#N_RESIZE_CURSOR"/>
        /// </summary>
        public static int N_RESIZE_CURSOR { get { if (!_N_RESIZE_CURSORReady) { _N_RESIZE_CURSORContent = SGetField<int>(LocalBridgeClazz, "N_RESIZE_CURSOR"); _N_RESIZE_CURSORReady = true; } return _N_RESIZE_CURSORContent; } }
        private static int _N_RESIZE_CURSORContent = default;
        private static bool _N_RESIZE_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#NE_RESIZE_CURSOR"/>
        /// </summary>
        public static int NE_RESIZE_CURSOR { get { if (!_NE_RESIZE_CURSORReady) { _NE_RESIZE_CURSORContent = SGetField<int>(LocalBridgeClazz, "NE_RESIZE_CURSOR"); _NE_RESIZE_CURSORReady = true; } return _NE_RESIZE_CURSORContent; } }
        private static int _NE_RESIZE_CURSORContent = default;
        private static bool _NE_RESIZE_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#NW_RESIZE_CURSOR"/>
        /// </summary>
        public static int NW_RESIZE_CURSOR { get { if (!_NW_RESIZE_CURSORReady) { _NW_RESIZE_CURSORContent = SGetField<int>(LocalBridgeClazz, "NW_RESIZE_CURSOR"); _NW_RESIZE_CURSORReady = true; } return _NW_RESIZE_CURSORContent; } }
        private static int _NW_RESIZE_CURSORContent = default;
        private static bool _NW_RESIZE_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#S_RESIZE_CURSOR"/>
        /// </summary>
        public static int S_RESIZE_CURSOR { get { if (!_S_RESIZE_CURSORReady) { _S_RESIZE_CURSORContent = SGetField<int>(LocalBridgeClazz, "S_RESIZE_CURSOR"); _S_RESIZE_CURSORReady = true; } return _S_RESIZE_CURSORContent; } }
        private static int _S_RESIZE_CURSORContent = default;
        private static bool _S_RESIZE_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#SE_RESIZE_CURSOR"/>
        /// </summary>
        public static int SE_RESIZE_CURSOR { get { if (!_SE_RESIZE_CURSORReady) { _SE_RESIZE_CURSORContent = SGetField<int>(LocalBridgeClazz, "SE_RESIZE_CURSOR"); _SE_RESIZE_CURSORReady = true; } return _SE_RESIZE_CURSORContent; } }
        private static int _SE_RESIZE_CURSORContent = default;
        private static bool _SE_RESIZE_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#SW_RESIZE_CURSOR"/>
        /// </summary>
        public static int SW_RESIZE_CURSOR { get { if (!_SW_RESIZE_CURSORReady) { _SW_RESIZE_CURSORContent = SGetField<int>(LocalBridgeClazz, "SW_RESIZE_CURSOR"); _SW_RESIZE_CURSORReady = true; } return _SW_RESIZE_CURSORContent; } }
        private static int _SW_RESIZE_CURSORContent = default;
        private static bool _SW_RESIZE_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#TEXT_CURSOR"/>
        /// </summary>
        public static int TEXT_CURSOR { get { if (!_TEXT_CURSORReady) { _TEXT_CURSORContent = SGetField<int>(LocalBridgeClazz, "TEXT_CURSOR"); _TEXT_CURSORReady = true; } return _TEXT_CURSORContent; } }
        private static int _TEXT_CURSORContent = default;
        private static bool _TEXT_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#W_RESIZE_CURSOR"/>
        /// </summary>
        public static int W_RESIZE_CURSOR { get { if (!_W_RESIZE_CURSORReady) { _W_RESIZE_CURSORContent = SGetField<int>(LocalBridgeClazz, "W_RESIZE_CURSOR"); _W_RESIZE_CURSORReady = true; } return _W_RESIZE_CURSORContent; } }
        private static int _W_RESIZE_CURSORContent = default;
        private static bool _W_RESIZE_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#WAIT_CURSOR"/>
        /// </summary>
        public static int WAIT_CURSOR { get { if (!_WAIT_CURSORReady) { _WAIT_CURSORContent = SGetField<int>(LocalBridgeClazz, "WAIT_CURSOR"); _WAIT_CURSORReady = true; } return _WAIT_CURSORContent; } }
        private static int _WAIT_CURSORContent = default;
        private static bool _WAIT_CURSORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#getDefaultCursor()"/> 
        /// </summary>
        public static Java.Awt.Cursor DefaultCursor
        {
            get { return SExecuteWithSignature<Java.Awt.Cursor>(LocalBridgeClazz, "getDefaultCursor", "()Ljava/awt/Cursor;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#getPredefinedCursor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Cursor"/></returns>
        public static Java.Awt.Cursor GetPredefinedCursor(int arg0)
        {
            return SExecuteWithSignature<Java.Awt.Cursor>(LocalBridgeClazz, "getPredefinedCursor", "(I)Ljava/awt/Cursor;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#getSystemCustomCursor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Awt.Cursor"/></returns>
        /// <exception cref="Java.Awt.AWTException"/>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static Java.Awt.Cursor GetSystemCustomCursor(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Awt.Cursor>(LocalBridgeClazz, "getSystemCustomCursor", "(Ljava/lang/String;)Ljava/awt/Cursor;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}