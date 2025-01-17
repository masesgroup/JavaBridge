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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region TrayIcon declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html"/>
    /// </summary>
    public partial class TrayIcon : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TrayIcon>
    {
        const string _bridgeClassName = "java.awt.TrayIcon";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TrayIcon() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TrayIcon(params object[] args) : base(args) { }

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
        #region MessageType declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.MessageType.html"/>
        /// </summary>
        public partial class MessageType : Java.Lang.Enum<Java.Awt.TrayIcon.MessageType>
        {
            const string _bridgeClassName = "java.awt.TrayIcon$MessageType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public MessageType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public MessageType(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region TrayIcon implementation
    public partial class TrayIcon
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#%3Cinit%3E(java.awt.Image,java.lang.String,java.awt.PopupMenu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Awt.PopupMenu"/></param>
        public TrayIcon(Java.Awt.Image arg0, Java.Lang.String arg1, Java.Awt.PopupMenu arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#%3Cinit%3E(java.awt.Image,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public TrayIcon(Java.Awt.Image arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#%3Cinit%3E(java.awt.Image)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        public TrayIcon(Java.Awt.Image arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getActionCommand()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#setActionCommand(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ActionCommand
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getActionCommand", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setActionCommand", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getActionListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ActionListener[] ActionListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.ActionListener>("getActionListeners", "()[Ljava/awt/event/ActionListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getImage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#setImage(java.awt.Image)"/>
        /// </summary>
        public Java.Awt.Image Image
        {
            get { return IExecuteWithSignature<Java.Awt.Image>("getImage", "()Ljava/awt/Image;"); } set { IExecuteWithSignature("setImage", "(Ljava/awt/Image;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getMouseListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.MouseListener[] MouseListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.MouseListener>("getMouseListeners", "()[Ljava/awt/event/MouseListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getMouseMotionListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.MouseMotionListener[] MouseMotionListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.MouseMotionListener>("getMouseMotionListeners", "()[Ljava/awt/event/MouseMotionListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getPopupMenu()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#setPopupMenu(java.awt.PopupMenu)"/>
        /// </summary>
        public Java.Awt.PopupMenu PopupMenu
        {
            get { return IExecuteWithSignature<Java.Awt.PopupMenu>("getPopupMenu", "()Ljava/awt/PopupMenu;"); } set { IExecuteWithSignature("setPopupMenu", "(Ljava/awt/PopupMenu;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getSize()"/> 
        /// </summary>
        public Java.Awt.Dimension Size
        {
            get { return IExecuteWithSignature<Java.Awt.Dimension>("getSize", "()Ljava/awt/Dimension;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getToolTip()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#setToolTip(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ToolTip
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getToolTip", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setToolTip", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#isImageAutoSize()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsImageAutoSize()
        {
            return IExecuteWithSignature<bool>("isImageAutoSize", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#addActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void AddActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecuteWithSignature("addActionListener", "(Ljava/awt/event/ActionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#addMouseListener(java.awt.event.MouseListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseListener"/></param>
        public void AddMouseListener(Java.Awt.EventNs.MouseListener arg0)
        {
            IExecuteWithSignature("addMouseListener", "(Ljava/awt/event/MouseListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#addMouseMotionListener(java.awt.event.MouseMotionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseMotionListener"/></param>
        public void AddMouseMotionListener(Java.Awt.EventNs.MouseMotionListener arg0)
        {
            IExecuteWithSignature("addMouseMotionListener", "(Ljava/awt/event/MouseMotionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#removeActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void RemoveActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecuteWithSignature("removeActionListener", "(Ljava/awt/event/ActionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#removeMouseListener(java.awt.event.MouseListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseListener"/></param>
        public void RemoveMouseListener(Java.Awt.EventNs.MouseListener arg0)
        {
            IExecuteWithSignature("removeMouseListener", "(Ljava/awt/event/MouseListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#removeMouseMotionListener(java.awt.event.MouseMotionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseMotionListener"/></param>
        public void RemoveMouseMotionListener(Java.Awt.EventNs.MouseMotionListener arg0)
        {
            IExecuteWithSignature("removeMouseMotionListener", "(Ljava/awt/event/MouseMotionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#displayMessage(java.lang.String,java.lang.String,java.awt.TrayIcon.MessageType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Awt.TrayIcon.MessageType"/></param>
        public void DisplayMessage(Java.Lang.String arg0, Java.Lang.String arg1, Java.Awt.TrayIcon.MessageType arg2)
        {
            IExecuteWithSignature("displayMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/awt/TrayIcon$MessageType;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#setImageAutoSize(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetImageAutoSize(bool arg0)
        {
            IExecuteWithSignature("setImageAutoSize", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes
        #region MessageType implementation
        public partial class MessageType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.MessageType.html#ERROR"/>
            /// </summary>
            public static Java.Awt.TrayIcon.MessageType ERROR { get { if (!_ERRORReady) { _ERRORContent = SGetField<Java.Awt.TrayIcon.MessageType>(LocalBridgeClazz, "ERROR"); _ERRORReady = true; } return _ERRORContent; } }
            private static Java.Awt.TrayIcon.MessageType _ERRORContent = default;
            private static bool _ERRORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.MessageType.html#INFO"/>
            /// </summary>
            public static Java.Awt.TrayIcon.MessageType INFO { get { if (!_INFOReady) { _INFOContent = SGetField<Java.Awt.TrayIcon.MessageType>(LocalBridgeClazz, "INFO"); _INFOReady = true; } return _INFOContent; } }
            private static Java.Awt.TrayIcon.MessageType _INFOContent = default;
            private static bool _INFOReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.MessageType.html#NONE"/>
            /// </summary>
            public static Java.Awt.TrayIcon.MessageType NONE { get { if (!_NONEReady) { _NONEContent = SGetField<Java.Awt.TrayIcon.MessageType>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
            private static Java.Awt.TrayIcon.MessageType _NONEContent = default;
            private static bool _NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.MessageType.html#WARNING"/>
            /// </summary>
            public static Java.Awt.TrayIcon.MessageType WARNING { get { if (!_WARNINGReady) { _WARNINGContent = SGetField<Java.Awt.TrayIcon.MessageType>(LocalBridgeClazz, "WARNING"); _WARNINGReady = true; } return _WARNINGContent; } }
            private static Java.Awt.TrayIcon.MessageType _WARNINGContent = default;
            private static bool _WARNINGReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.MessageType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Awt.TrayIcon.MessageType"/></returns>
            public static Java.Awt.TrayIcon.MessageType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Awt.TrayIcon.MessageType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/awt/TrayIcon$MessageType;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.MessageType.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Awt.TrayIcon.MessageType"/></returns>
            public static Java.Awt.TrayIcon.MessageType[] Values()
            {
                return SExecuteWithSignatureArray<Java.Awt.TrayIcon.MessageType>(LocalBridgeClazz, "values", "()[Ljava/awt/TrayIcon$MessageType;");
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