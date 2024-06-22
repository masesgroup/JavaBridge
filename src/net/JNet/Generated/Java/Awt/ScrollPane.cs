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
    #region ScrollPane
    public partial class ScrollPane
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public ScrollPane(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.ScrollPane"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Java.Awt.ScrollPane t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#SCROLLBARS_ALWAYS"/>
        /// </summary>
        public static int SCROLLBARS_ALWAYS { get { if (!_SCROLLBARS_ALWAYSReady) { _SCROLLBARS_ALWAYSContent = SGetField<int>(LocalBridgeClazz, "SCROLLBARS_ALWAYS"); _SCROLLBARS_ALWAYSReady = true; } return _SCROLLBARS_ALWAYSContent; } }
        private static int _SCROLLBARS_ALWAYSContent = default;
        private static bool _SCROLLBARS_ALWAYSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#SCROLLBARS_AS_NEEDED"/>
        /// </summary>
        public static int SCROLLBARS_AS_NEEDED { get { if (!_SCROLLBARS_AS_NEEDEDReady) { _SCROLLBARS_AS_NEEDEDContent = SGetField<int>(LocalBridgeClazz, "SCROLLBARS_AS_NEEDED"); _SCROLLBARS_AS_NEEDEDReady = true; } return _SCROLLBARS_AS_NEEDEDContent; } }
        private static int _SCROLLBARS_AS_NEEDEDContent = default;
        private static bool _SCROLLBARS_AS_NEEDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#SCROLLBARS_NEVER"/>
        /// </summary>
        public static int SCROLLBARS_NEVER { get { if (!_SCROLLBARS_NEVERReady) { _SCROLLBARS_NEVERContent = SGetField<int>(LocalBridgeClazz, "SCROLLBARS_NEVER"); _SCROLLBARS_NEVERReady = true; } return _SCROLLBARS_NEVERContent; } }
        private static int _SCROLLBARS_NEVERContent = default;
        private static bool _SCROLLBARS_NEVERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#getHAdjustable()"/> 
        /// </summary>
        public Java.Awt.Adjustable HAdjustable
        {
            get { return IExecuteWithSignature<Java.Awt.Adjustable>("getHAdjustable", "()Ljava/awt/Adjustable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#getHScrollbarHeight()"/> 
        /// </summary>
        public int HScrollbarHeight
        {
            get { return IExecuteWithSignature<int>("getHScrollbarHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#getScrollbarDisplayPolicy()"/> 
        /// </summary>
        public int ScrollbarDisplayPolicy
        {
            get { return IExecuteWithSignature<int>("getScrollbarDisplayPolicy", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#getScrollPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#setScrollPosition(java.awt.Point)"/>
        /// </summary>
        public Java.Awt.Point ScrollPosition
        {
            get { return IExecuteWithSignature<Java.Awt.Point>("getScrollPosition", "()Ljava/awt/Point;"); } set { IExecuteWithSignature("setScrollPosition", "(Ljava/awt/Point;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#getVAdjustable()"/> 
        /// </summary>
        public Java.Awt.Adjustable VAdjustable
        {
            get { return IExecuteWithSignature<Java.Awt.Adjustable>("getVAdjustable", "()Ljava/awt/Adjustable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#getViewportSize()"/> 
        /// </summary>
        public Java.Awt.Dimension ViewportSize
        {
            get { return IExecuteWithSignature<Java.Awt.Dimension>("getViewportSize", "()Ljava/awt/Dimension;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#getVScrollbarWidth()"/> 
        /// </summary>
        public int VScrollbarWidth
        {
            get { return IExecuteWithSignature<int>("getVScrollbarWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#isWheelScrollingEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWheelScrollingEnabled()
        {
            return IExecuteWithSignature<bool>("isWheelScrollingEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#paramString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ParamString()
        {
            return IExecuteWithSignature<Java.Lang.String>("paramString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#setScrollPosition(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetScrollPosition(int arg0, int arg1)
        {
            IExecute("setScrollPosition", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPane.html#setWheelScrollingEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetWheelScrollingEnabled(bool arg0)
        {
            IExecuteWithSignature("setWheelScrollingEnabled", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}