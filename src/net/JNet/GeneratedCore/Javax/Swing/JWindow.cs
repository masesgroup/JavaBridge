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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JWindow definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JWindow.html"/>
    /// </summary>
    public partial class JWindow : Java.Awt.Window
    {
        const string _bridgeClassName = "javax.swing.JWindow";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JWindow() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JWindow(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region JWindow
    public partial class JWindow
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JWindow.html#%3Cinit%3E(java.awt.Frame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        public JWindow(Java.Awt.Frame arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JWindow.html#%3Cinit%3E(java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        public JWindow(Java.Awt.GraphicsConfiguration arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JWindow.html#%3Cinit%3E(java.awt.Window,java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        public JWindow(Java.Awt.Window arg0, Java.Awt.GraphicsConfiguration arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JWindow.html#%3Cinit%3E(java.awt.Window)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        public JWindow(Java.Awt.Window arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JWindow"/> to <see cref="Javax.Swing.RootPaneContainer"/>
        /// </summary>
        public static implicit operator Javax.Swing.RootPaneContainer(Javax.Swing.JWindow t) => t.Cast<Javax.Swing.RootPaneContainer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JWindow.html#getContentPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JWindow.html#setContentPane(java.awt.Container)"/>
        /// </summary>
        public Java.Awt.Container ContentPane
        {
            get { return IExecuteWithSignature<Java.Awt.Container>("getContentPane", "()Ljava/awt/Container;"); } set { IExecuteWithSignature("setContentPane", "(Ljava/awt/Container;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JWindow.html#getGlassPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JWindow.html#setGlassPane(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component GlassPane
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getGlassPane", "()Ljava/awt/Component;"); } set { IExecuteWithSignature("setGlassPane", "(Ljava/awt/Component;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JWindow.html#getLayeredPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JWindow.html#setLayeredPane(javax.swing.JLayeredPane)"/>
        /// </summary>
        public Javax.Swing.JLayeredPane LayeredPane
        {
            get { return IExecuteWithSignature<Javax.Swing.JLayeredPane>("getLayeredPane", "()Ljavax/swing/JLayeredPane;"); } set { IExecuteWithSignature("setLayeredPane", "(Ljavax/swing/JLayeredPane;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JWindow.html#getRootPane()"/> 
        /// </summary>
        public Javax.Swing.JRootPane RootPane
        {
            get { return IExecuteWithSignature<Javax.Swing.JRootPane>("getRootPane", "()Ljavax/swing/JRootPane;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JWindow.html#getTransferHandler()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JWindow.html#setTransferHandler(javax.swing.TransferHandler)"/>
        /// </summary>
        public Javax.Swing.TransferHandler TransferHandler
        {
            get { return IExecuteWithSignature<Javax.Swing.TransferHandler>("getTransferHandler", "()Ljavax/swing/TransferHandler;"); } set { IExecuteWithSignature("setTransferHandler", "(Ljavax/swing/TransferHandler;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}