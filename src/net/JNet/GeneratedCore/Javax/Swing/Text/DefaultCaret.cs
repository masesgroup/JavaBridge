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

namespace Javax.Swing.Text
{
    #region DefaultCaret definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html"/>
    /// </summary>
    public partial class DefaultCaret : Java.Awt.Rectangle
    {
        const string _bridgeClassName = "javax.swing.text.DefaultCaret";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DefaultCaret() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DefaultCaret(params object[] args) : base(args) { }

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

    #region DefaultCaret
    public partial class DefaultCaret
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.DefaultCaret"/> to <see cref="Javax.Swing.Text.Caret"/>
        /// </summary>
        public static implicit operator Javax.Swing.Text.Caret(Javax.Swing.Text.DefaultCaret t) => t.Cast<Javax.Swing.Text.Caret>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.DefaultCaret"/> to <see cref="Java.Awt.EventNs.FocusListener"/>
        /// </summary>
        public static implicit operator Java.Awt.EventNs.FocusListener(Javax.Swing.Text.DefaultCaret t) => t.Cast<Java.Awt.EventNs.FocusListener>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.DefaultCaret"/> to <see cref="Java.Awt.EventNs.MouseListener"/>
        /// </summary>
        public static implicit operator Java.Awt.EventNs.MouseListener(Javax.Swing.Text.DefaultCaret t) => t.Cast<Java.Awt.EventNs.MouseListener>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.DefaultCaret"/> to <see cref="Java.Awt.EventNs.MouseMotionListener"/>
        /// </summary>
        public static implicit operator Java.Awt.EventNs.MouseMotionListener(Javax.Swing.Text.DefaultCaret t) => t.Cast<Java.Awt.EventNs.MouseMotionListener>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#ALWAYS_UPDATE"/>
        /// </summary>
        public static int ALWAYS_UPDATE { get { if (!_ALWAYS_UPDATEReady) { _ALWAYS_UPDATEContent = SGetField<int>(LocalBridgeClazz, "ALWAYS_UPDATE"); _ALWAYS_UPDATEReady = true; } return _ALWAYS_UPDATEContent; } }
        private static int _ALWAYS_UPDATEContent = default;
        private static bool _ALWAYS_UPDATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#NEVER_UPDATE"/>
        /// </summary>
        public static int NEVER_UPDATE { get { if (!_NEVER_UPDATEReady) { _NEVER_UPDATEContent = SGetField<int>(LocalBridgeClazz, "NEVER_UPDATE"); _NEVER_UPDATEReady = true; } return _NEVER_UPDATEContent; } }
        private static int _NEVER_UPDATEContent = default;
        private static bool _NEVER_UPDATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#UPDATE_WHEN_ON_EDT"/>
        /// </summary>
        public static int UPDATE_WHEN_ON_EDT { get { if (!_UPDATE_WHEN_ON_EDTReady) { _UPDATE_WHEN_ON_EDTContent = SGetField<int>(LocalBridgeClazz, "UPDATE_WHEN_ON_EDT"); _UPDATE_WHEN_ON_EDTReady = true; } return _UPDATE_WHEN_ON_EDTContent; } }
        private static int _UPDATE_WHEN_ON_EDTContent = default;
        private static bool _UPDATE_WHEN_ON_EDTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#getBlinkRate()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#setBlinkRate(int)"/>
        /// </summary>
        public int BlinkRate
        {
            get { return IExecuteWithSignature<int>("getBlinkRate", "()I"); } set { IExecuteWithSignature("setBlinkRate", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#getChangeListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ChangeListener[] ChangeListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.ChangeListener>("getChangeListeners", "()[Ljavax/swing/event/ChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#getDot()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#setDot(int)"/>
        /// </summary>
        public int Dot
        {
            get { return IExecuteWithSignature<int>("getDot", "()I"); } set { IExecuteWithSignature("setDot", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#getDotBias()"/> 
        /// </summary>
        public Javax.Swing.Text.Position.Bias DotBias
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.Position.Bias>("getDotBias", "()Ljavax/swing/text/Position$Bias;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#getMagicCaretPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#setMagicCaretPosition(java.awt.Point)"/>
        /// </summary>
        public Java.Awt.Point MagicCaretPosition
        {
            get { return IExecuteWithSignature<Java.Awt.Point>("getMagicCaretPosition", "()Ljava/awt/Point;"); } set { IExecuteWithSignature("setMagicCaretPosition", "(Ljava/awt/Point;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#getMark()"/> 
        /// </summary>
        public int Mark
        {
            get { return IExecuteWithSignature<int>("getMark", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#getMarkBias()"/> 
        /// </summary>
        public Javax.Swing.Text.Position.Bias MarkBias
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.Position.Bias>("getMarkBias", "()Ljavax/swing/text/Position$Bias;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#getUpdatePolicy()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#setUpdatePolicy(int)"/>
        /// </summary>
        public int UpdatePolicy
        {
            get { return IExecuteWithSignature<int>("getUpdatePolicy", "()I"); } set { IExecuteWithSignature("setUpdatePolicy", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#getListeners(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Util.IEventListener"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetListeners<T>(Java.Lang.Class arg0) where T : Java.Util.IEventListener, new()
        {
            return IExecuteArray<T>("getListeners", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#isActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsActive()
        {
            return IExecuteWithSignature<bool>("isActive", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#isSelectionVisible()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSelectionVisible()
        {
            return IExecuteWithSignature<bool>("isSelectionVisible", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#isVisible()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVisible()
        {
            return IExecuteWithSignature<bool>("isVisible", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("addChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#deinstall(javax.swing.text.JTextComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        public void Deinstall(Javax.Swing.Text.JTextComponent arg0)
        {
            IExecuteWithSignature("deinstall", "(Ljavax/swing/text/JTextComponent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#focusGained(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        public void FocusGained(Java.Awt.EventNs.FocusEvent arg0)
        {
            IExecuteWithSignature("focusGained", "(Ljava/awt/event/FocusEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#focusLost(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        public void FocusLost(Java.Awt.EventNs.FocusEvent arg0)
        {
            IExecuteWithSignature("focusLost", "(Ljava/awt/event/FocusEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#install(javax.swing.text.JTextComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        public void Install(Javax.Swing.Text.JTextComponent arg0)
        {
            IExecuteWithSignature("install", "(Ljavax/swing/text/JTextComponent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#mouseClicked(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void MouseClicked(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("mouseClicked", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#mouseDragged(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void MouseDragged(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("mouseDragged", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#mouseEntered(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void MouseEntered(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("mouseEntered", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#mouseExited(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void MouseExited(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("mouseExited", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#mouseMoved(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void MouseMoved(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("mouseMoved", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#mousePressed(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void MousePressed(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("mousePressed", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#mouseReleased(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void MouseReleased(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("mouseReleased", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#moveDot(int,javax.swing.text.Position.Bias)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        public void MoveDot(int arg0, Javax.Swing.Text.Position.Bias arg1)
        {
            IExecute("moveDot", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#moveDot(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void MoveDot(int arg0)
        {
            IExecuteWithSignature("moveDot", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#paint(java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        public void Paint(Java.Awt.Graphics arg0)
        {
            IExecuteWithSignature("paint", "(Ljava/awt/Graphics;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("removeChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#setDot(int,javax.swing.text.Position.Bias)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        public void SetDot(int arg0, Javax.Swing.Text.Position.Bias arg1)
        {
            IExecute("setDot", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#setSelectionVisible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetSelectionVisible(bool arg0)
        {
            IExecuteWithSignature("setSelectionVisible", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultCaret.html#setVisible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetVisible(bool arg0)
        {
            IExecuteWithSignature("setVisible", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}