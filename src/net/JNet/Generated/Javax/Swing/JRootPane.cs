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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JRootPane declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html"/>
    /// </summary>
    public partial class JRootPane : Javax.Swing.JComponent
    {
        const string _bridgeClassName = "javax.swing.JRootPane";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JRootPane() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JRootPane(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region JRootPane implementation
    public partial class JRootPane
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JRootPane"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JRootPane t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#COLOR_CHOOSER_DIALOG"/>
        /// </summary>
        public static int COLOR_CHOOSER_DIALOG { get { if (!_COLOR_CHOOSER_DIALOGReady) { _COLOR_CHOOSER_DIALOGContent = SGetField<int>(LocalBridgeClazz, "COLOR_CHOOSER_DIALOG"); _COLOR_CHOOSER_DIALOGReady = true; } return _COLOR_CHOOSER_DIALOGContent; } }
        private static int _COLOR_CHOOSER_DIALOGContent = default;
        private static bool _COLOR_CHOOSER_DIALOGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#ERROR_DIALOG"/>
        /// </summary>
        public static int ERROR_DIALOG { get { if (!_ERROR_DIALOGReady) { _ERROR_DIALOGContent = SGetField<int>(LocalBridgeClazz, "ERROR_DIALOG"); _ERROR_DIALOGReady = true; } return _ERROR_DIALOGContent; } }
        private static int _ERROR_DIALOGContent = default;
        private static bool _ERROR_DIALOGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#FILE_CHOOSER_DIALOG"/>
        /// </summary>
        public static int FILE_CHOOSER_DIALOG { get { if (!_FILE_CHOOSER_DIALOGReady) { _FILE_CHOOSER_DIALOGContent = SGetField<int>(LocalBridgeClazz, "FILE_CHOOSER_DIALOG"); _FILE_CHOOSER_DIALOGReady = true; } return _FILE_CHOOSER_DIALOGContent; } }
        private static int _FILE_CHOOSER_DIALOGContent = default;
        private static bool _FILE_CHOOSER_DIALOGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#FRAME"/>
        /// </summary>
        public static int FRAME { get { if (!_FRAMEReady) { _FRAMEContent = SGetField<int>(LocalBridgeClazz, "FRAME"); _FRAMEReady = true; } return _FRAMEContent; } }
        private static int _FRAMEContent = default;
        private static bool _FRAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#INFORMATION_DIALOG"/>
        /// </summary>
        public static int INFORMATION_DIALOG { get { if (!_INFORMATION_DIALOGReady) { _INFORMATION_DIALOGContent = SGetField<int>(LocalBridgeClazz, "INFORMATION_DIALOG"); _INFORMATION_DIALOGReady = true; } return _INFORMATION_DIALOGContent; } }
        private static int _INFORMATION_DIALOGContent = default;
        private static bool _INFORMATION_DIALOGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#NONE"/>
        /// </summary>
        public static int NONE { get { if (!_NONEReady) { _NONEContent = SGetField<int>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
        private static int _NONEContent = default;
        private static bool _NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#PLAIN_DIALOG"/>
        /// </summary>
        public static int PLAIN_DIALOG { get { if (!_PLAIN_DIALOGReady) { _PLAIN_DIALOGContent = SGetField<int>(LocalBridgeClazz, "PLAIN_DIALOG"); _PLAIN_DIALOGReady = true; } return _PLAIN_DIALOGContent; } }
        private static int _PLAIN_DIALOGContent = default;
        private static bool _PLAIN_DIALOGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#QUESTION_DIALOG"/>
        /// </summary>
        public static int QUESTION_DIALOG { get { if (!_QUESTION_DIALOGReady) { _QUESTION_DIALOGContent = SGetField<int>(LocalBridgeClazz, "QUESTION_DIALOG"); _QUESTION_DIALOGReady = true; } return _QUESTION_DIALOGContent; } }
        private static int _QUESTION_DIALOGContent = default;
        private static bool _QUESTION_DIALOGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#WARNING_DIALOG"/>
        /// </summary>
        public static int WARNING_DIALOG { get { if (!_WARNING_DIALOGReady) { _WARNING_DIALOGContent = SGetField<int>(LocalBridgeClazz, "WARNING_DIALOG"); _WARNING_DIALOGReady = true; } return _WARNING_DIALOGContent; } }
        private static int _WARNING_DIALOGContent = default;
        private static bool _WARNING_DIALOGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#getContentPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#setContentPane(java.awt.Container)"/>
        /// </summary>
        public Java.Awt.Container ContentPane
        {
            get { return IExecuteWithSignature<Java.Awt.Container>("getContentPane", "()Ljava/awt/Container;"); } set { IExecuteWithSignature("setContentPane", "(Ljava/awt/Container;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#getDefaultButton()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#setDefaultButton(javax.swing.JButton)"/>
        /// </summary>
        public Javax.Swing.JButton DefaultButton
        {
            get { return IExecuteWithSignature<Javax.Swing.JButton>("getDefaultButton", "()Ljavax/swing/JButton;"); } set { IExecuteWithSignature("setDefaultButton", "(Ljavax/swing/JButton;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#getGlassPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#setGlassPane(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component GlassPane
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getGlassPane", "()Ljava/awt/Component;"); } set { IExecuteWithSignature("setGlassPane", "(Ljava/awt/Component;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#getJMenuBar()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#setJMenuBar(javax.swing.JMenuBar)"/>
        /// </summary>
        public Javax.Swing.JMenuBar JMenuBar
        {
            get { return IExecuteWithSignature<Javax.Swing.JMenuBar>("getJMenuBar", "()Ljavax/swing/JMenuBar;"); } set { IExecuteWithSignature("setJMenuBar", "(Ljavax/swing/JMenuBar;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#getLayeredPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#setLayeredPane(javax.swing.JLayeredPane)"/>
        /// </summary>
        public Javax.Swing.JLayeredPane LayeredPane
        {
            get { return IExecuteWithSignature<Javax.Swing.JLayeredPane>("getLayeredPane", "()Ljavax/swing/JLayeredPane;"); } set { IExecuteWithSignature("setLayeredPane", "(Ljavax/swing/JLayeredPane;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#getWindowDecorationStyle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#setWindowDecorationStyle(int)"/>
        /// </summary>
        public int WindowDecorationStyle
        {
            get { return IExecuteWithSignature<int>("getWindowDecorationStyle", "()I"); } set { IExecuteWithSignature("setWindowDecorationStyle", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#setUI(javax.swing.plaf.RootPaneUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.RootPaneUI"/></param>
        public void SetUI(Javax.Swing.Plaf.RootPaneUI arg0)
        {
            IExecuteWithSignature("setUI", "(Ljavax/swing/plaf/RootPaneUI;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}