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

namespace Java.Awt
{
    #region Taskbar
    public partial class Taskbar
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#getTaskbar()"/> 
        /// </summary>
        public static Java.Awt.Taskbar GetTaskbar
        {
            get { return SExecuteWithSignature<Java.Awt.Taskbar>(LocalBridgeClazz, "getTaskbar", "()Ljava/awt/Taskbar;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#isTaskbarSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsTaskbarSupported()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isTaskbarSupported", "()Z");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#getIconImage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#setIconImage(java.awt.Image)"/>
        /// </summary>
        public Java.Awt.Image IconImage
        {
            get { return IExecuteWithSignature<Java.Awt.Image>("getIconImage", "()Ljava/awt/Image;"); } set { IExecuteWithSignature("setIconImage", "(Ljava/awt/Image;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#getMenu()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#setMenu(java.awt.PopupMenu)"/>
        /// </summary>
        public Java.Awt.PopupMenu Menu
        {
            get { return IExecuteWithSignature<Java.Awt.PopupMenu>("getMenu", "()Ljava/awt/PopupMenu;"); } set { IExecuteWithSignature("setMenu", "(Ljava/awt/PopupMenu;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#isSupported(java.awt.Taskbar.Feature)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Taskbar.Feature"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Awt.Taskbar.Feature arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/awt/Taskbar$Feature;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#requestUserAttention(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void RequestUserAttention(bool arg0, bool arg1)
        {
            IExecute("requestUserAttention", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#requestWindowUserAttention(java.awt.Window)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        public void RequestWindowUserAttention(Java.Awt.Window arg0)
        {
            IExecuteWithSignature("requestWindowUserAttention", "(Ljava/awt/Window;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#setIconBadge(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetIconBadge(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setIconBadge", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#setProgressValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetProgressValue(int arg0)
        {
            IExecuteWithSignature("setProgressValue", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#setWindowIconBadge(java.awt.Window,java.awt.Image)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Image"/></param>
        public void SetWindowIconBadge(Java.Awt.Window arg0, Java.Awt.Image arg1)
        {
            IExecute("setWindowIconBadge", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#setWindowProgressState(java.awt.Window,java.awt.Taskbar.State)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Taskbar.State"/></param>
        public void SetWindowProgressState(Java.Awt.Window arg0, Java.Awt.Taskbar.State arg1)
        {
            IExecute("setWindowProgressState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#setWindowProgressValue(java.awt.Window,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetWindowProgressValue(Java.Awt.Window arg0, int arg1)
        {
            IExecute("setWindowProgressValue", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Feature
        public partial class Feature
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#ICON_BADGE_IMAGE_WINDOW"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature ICON_BADGE_IMAGE_WINDOW { get { if (!_ICON_BADGE_IMAGE_WINDOWReady) { _ICON_BADGE_IMAGE_WINDOWContent = SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "ICON_BADGE_IMAGE_WINDOW"); _ICON_BADGE_IMAGE_WINDOWReady = true; } return _ICON_BADGE_IMAGE_WINDOWContent; } }
            private static Java.Awt.Taskbar.Feature _ICON_BADGE_IMAGE_WINDOWContent = default;
            private static bool _ICON_BADGE_IMAGE_WINDOWReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#ICON_BADGE_NUMBER"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature ICON_BADGE_NUMBER { get { if (!_ICON_BADGE_NUMBERReady) { _ICON_BADGE_NUMBERContent = SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "ICON_BADGE_NUMBER"); _ICON_BADGE_NUMBERReady = true; } return _ICON_BADGE_NUMBERContent; } }
            private static Java.Awt.Taskbar.Feature _ICON_BADGE_NUMBERContent = default;
            private static bool _ICON_BADGE_NUMBERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#ICON_BADGE_TEXT"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature ICON_BADGE_TEXT { get { if (!_ICON_BADGE_TEXTReady) { _ICON_BADGE_TEXTContent = SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "ICON_BADGE_TEXT"); _ICON_BADGE_TEXTReady = true; } return _ICON_BADGE_TEXTContent; } }
            private static Java.Awt.Taskbar.Feature _ICON_BADGE_TEXTContent = default;
            private static bool _ICON_BADGE_TEXTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#ICON_IMAGE"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature ICON_IMAGE { get { if (!_ICON_IMAGEReady) { _ICON_IMAGEContent = SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "ICON_IMAGE"); _ICON_IMAGEReady = true; } return _ICON_IMAGEContent; } }
            private static Java.Awt.Taskbar.Feature _ICON_IMAGEContent = default;
            private static bool _ICON_IMAGEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#MENU"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature MENU { get { if (!_MENUReady) { _MENUContent = SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "MENU"); _MENUReady = true; } return _MENUContent; } }
            private static Java.Awt.Taskbar.Feature _MENUContent = default;
            private static bool _MENUReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#PROGRESS_STATE_WINDOW"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature PROGRESS_STATE_WINDOW { get { if (!_PROGRESS_STATE_WINDOWReady) { _PROGRESS_STATE_WINDOWContent = SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "PROGRESS_STATE_WINDOW"); _PROGRESS_STATE_WINDOWReady = true; } return _PROGRESS_STATE_WINDOWContent; } }
            private static Java.Awt.Taskbar.Feature _PROGRESS_STATE_WINDOWContent = default;
            private static bool _PROGRESS_STATE_WINDOWReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#PROGRESS_VALUE"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature PROGRESS_VALUE { get { if (!_PROGRESS_VALUEReady) { _PROGRESS_VALUEContent = SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "PROGRESS_VALUE"); _PROGRESS_VALUEReady = true; } return _PROGRESS_VALUEContent; } }
            private static Java.Awt.Taskbar.Feature _PROGRESS_VALUEContent = default;
            private static bool _PROGRESS_VALUEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#PROGRESS_VALUE_WINDOW"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature PROGRESS_VALUE_WINDOW { get { if (!_PROGRESS_VALUE_WINDOWReady) { _PROGRESS_VALUE_WINDOWContent = SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "PROGRESS_VALUE_WINDOW"); _PROGRESS_VALUE_WINDOWReady = true; } return _PROGRESS_VALUE_WINDOWContent; } }
            private static Java.Awt.Taskbar.Feature _PROGRESS_VALUE_WINDOWContent = default;
            private static bool _PROGRESS_VALUE_WINDOWReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#USER_ATTENTION"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature USER_ATTENTION { get { if (!_USER_ATTENTIONReady) { _USER_ATTENTIONContent = SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "USER_ATTENTION"); _USER_ATTENTIONReady = true; } return _USER_ATTENTIONContent; } }
            private static Java.Awt.Taskbar.Feature _USER_ATTENTIONContent = default;
            private static bool _USER_ATTENTIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#USER_ATTENTION_WINDOW"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature USER_ATTENTION_WINDOW { get { if (!_USER_ATTENTION_WINDOWReady) { _USER_ATTENTION_WINDOWContent = SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "USER_ATTENTION_WINDOW"); _USER_ATTENTION_WINDOWReady = true; } return _USER_ATTENTION_WINDOWContent; } }
            private static Java.Awt.Taskbar.Feature _USER_ATTENTION_WINDOWContent = default;
            private static bool _USER_ATTENTION_WINDOWReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Awt.Taskbar.Feature"/></returns>
            public static Java.Awt.Taskbar.Feature ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/awt/Taskbar$Feature;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Awt.Taskbar.Feature"/></returns>
            public static Java.Awt.Taskbar.Feature[] Values()
            {
                return SExecuteWithSignatureArray<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "values", "()[Ljava/awt/Taskbar$Feature;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region State
        public partial class State
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.State.html#ERROR"/>
            /// </summary>
            public static Java.Awt.Taskbar.State ERROR { get { if (!_ERRORReady) { _ERRORContent = SGetField<Java.Awt.Taskbar.State>(LocalBridgeClazz, "ERROR"); _ERRORReady = true; } return _ERRORContent; } }
            private static Java.Awt.Taskbar.State _ERRORContent = default;
            private static bool _ERRORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.State.html#INDETERMINATE"/>
            /// </summary>
            public static Java.Awt.Taskbar.State INDETERMINATE { get { if (!_INDETERMINATEReady) { _INDETERMINATEContent = SGetField<Java.Awt.Taskbar.State>(LocalBridgeClazz, "INDETERMINATE"); _INDETERMINATEReady = true; } return _INDETERMINATEContent; } }
            private static Java.Awt.Taskbar.State _INDETERMINATEContent = default;
            private static bool _INDETERMINATEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.State.html#NORMAL"/>
            /// </summary>
            public static Java.Awt.Taskbar.State NORMAL { get { if (!_NORMALReady) { _NORMALContent = SGetField<Java.Awt.Taskbar.State>(LocalBridgeClazz, "NORMAL"); _NORMALReady = true; } return _NORMALContent; } }
            private static Java.Awt.Taskbar.State _NORMALContent = default;
            private static bool _NORMALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.State.html#OFF"/>
            /// </summary>
            public static Java.Awt.Taskbar.State OFF { get { if (!_OFFReady) { _OFFContent = SGetField<Java.Awt.Taskbar.State>(LocalBridgeClazz, "OFF"); _OFFReady = true; } return _OFFContent; } }
            private static Java.Awt.Taskbar.State _OFFContent = default;
            private static bool _OFFReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.State.html#PAUSED"/>
            /// </summary>
            public static Java.Awt.Taskbar.State PAUSED { get { if (!_PAUSEDReady) { _PAUSEDContent = SGetField<Java.Awt.Taskbar.State>(LocalBridgeClazz, "PAUSED"); _PAUSEDReady = true; } return _PAUSEDContent; } }
            private static Java.Awt.Taskbar.State _PAUSEDContent = default;
            private static bool _PAUSEDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.State.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Awt.Taskbar.State"/></returns>
            public static Java.Awt.Taskbar.State ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Awt.Taskbar.State>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/awt/Taskbar$State;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.State.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Awt.Taskbar.State"/></returns>
            public static Java.Awt.Taskbar.State[] Values()
            {
                return SExecuteWithSignatureArray<Java.Awt.Taskbar.State>(LocalBridgeClazz, "values", "()[Ljava/awt/Taskbar$State;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}