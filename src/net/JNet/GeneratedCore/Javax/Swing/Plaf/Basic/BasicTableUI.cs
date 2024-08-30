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

namespace Javax.Swing.Plaf.Basic
{
    #region BasicTableUI definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.html"/>
    /// </summary>
    public partial class BasicTableUI : Javax.Swing.Plaf.TableUI
    {
        const string _bridgeClassName = "javax.swing.plaf.basic.BasicTableUI";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BasicTableUI() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BasicTableUI(params object[] args) : base(args) { }

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
        #region FocusHandler definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.FocusHandler.html"/>
        /// </summary>
        public partial class FocusHandler : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FocusHandler>
        {
            const string _bridgeClassName = "javax.swing.plaf.basic.BasicTableUI$FocusHandler";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public FocusHandler() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public FocusHandler(params object[] args) : base(args) { }

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

        #region KeyHandler definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.KeyHandler.html"/>
        /// </summary>
        public partial class KeyHandler : MASES.JCOBridge.C2JBridge.JVMBridgeBase<KeyHandler>
        {
            const string _bridgeClassName = "javax.swing.plaf.basic.BasicTableUI$KeyHandler";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public KeyHandler() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public KeyHandler(params object[] args) : base(args) { }

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

        #region MouseInputHandler definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html"/>
        /// </summary>
        public partial class MouseInputHandler : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MouseInputHandler>
        {
            const string _bridgeClassName = "javax.swing.plaf.basic.BasicTableUI$MouseInputHandler";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public MouseInputHandler() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public MouseInputHandler(params object[] args) : base(args) { }

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

    
    }
    #endregion

    #region BasicTableUI
    public partial class BasicTableUI
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region FocusHandler
        public partial class FocusHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.FocusHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTableUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTableUI"/></param>
            public FocusHandler(Javax.Swing.Plaf.Basic.BasicTableUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicTableUI.FocusHandler"/> to <see cref="Java.Awt.EventNs.FocusListener"/>
            /// </summary>
            public static implicit operator Java.Awt.EventNs.FocusListener(Javax.Swing.Plaf.Basic.BasicTableUI.FocusHandler t) => t.Cast<Java.Awt.EventNs.FocusListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.FocusHandler.html#focusGained(java.awt.event.FocusEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
            public void FocusGained(Java.Awt.EventNs.FocusEvent arg0)
            {
                IExecuteWithSignature("focusGained", "(Ljava/awt/event/FocusEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.FocusHandler.html#focusLost(java.awt.event.FocusEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
            public void FocusLost(Java.Awt.EventNs.FocusEvent arg0)
            {
                IExecuteWithSignature("focusLost", "(Ljava/awt/event/FocusEvent;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region KeyHandler
        public partial class KeyHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.KeyHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTableUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTableUI"/></param>
            public KeyHandler(Javax.Swing.Plaf.Basic.BasicTableUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicTableUI.KeyHandler"/> to <see cref="Java.Awt.EventNs.KeyListener"/>
            /// </summary>
            public static implicit operator Java.Awt.EventNs.KeyListener(Javax.Swing.Plaf.Basic.BasicTableUI.KeyHandler t) => t.Cast<Java.Awt.EventNs.KeyListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.KeyHandler.html#keyPressed(java.awt.event.KeyEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
            public void KeyPressed(Java.Awt.EventNs.KeyEvent arg0)
            {
                IExecuteWithSignature("keyPressed", "(Ljava/awt/event/KeyEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.KeyHandler.html#keyReleased(java.awt.event.KeyEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
            public void KeyReleased(Java.Awt.EventNs.KeyEvent arg0)
            {
                IExecuteWithSignature("keyReleased", "(Ljava/awt/event/KeyEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.KeyHandler.html#keyTyped(java.awt.event.KeyEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
            public void KeyTyped(Java.Awt.EventNs.KeyEvent arg0)
            {
                IExecuteWithSignature("keyTyped", "(Ljava/awt/event/KeyEvent;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region MouseInputHandler
        public partial class MouseInputHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTableUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTableUI"/></param>
            public MouseInputHandler(Javax.Swing.Plaf.Basic.BasicTableUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicTableUI.MouseInputHandler"/> to <see cref="Javax.Swing.Event.MouseInputListener"/>
            /// </summary>
            public static implicit operator Javax.Swing.Event.MouseInputListener(Javax.Swing.Plaf.Basic.BasicTableUI.MouseInputHandler t) => t.Cast<Javax.Swing.Event.MouseInputListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#mouseClicked(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseClicked(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecuteWithSignature("mouseClicked", "(Ljava/awt/event/MouseEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#mouseDragged(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseDragged(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecuteWithSignature("mouseDragged", "(Ljava/awt/event/MouseEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#mouseEntered(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseEntered(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecuteWithSignature("mouseEntered", "(Ljava/awt/event/MouseEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#mouseExited(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseExited(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecuteWithSignature("mouseExited", "(Ljava/awt/event/MouseEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#mouseMoved(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseMoved(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecuteWithSignature("mouseMoved", "(Ljava/awt/event/MouseEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#mousePressed(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MousePressed(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecuteWithSignature("mousePressed", "(Ljava/awt/event/MouseEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#mouseReleased(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseReleased(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecuteWithSignature("mouseReleased", "(Ljava/awt/event/MouseEvent;)V", arg0);
            }

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