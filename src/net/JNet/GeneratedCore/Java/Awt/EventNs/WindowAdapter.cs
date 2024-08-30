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

namespace Java.Awt.EventNs
{
    #region WindowAdapter definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html"/>
    /// </summary>
    public partial class WindowAdapter : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public WindowAdapter() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.awt.event.WindowAdapter";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region WindowAdapterDirect definition
    /// <summary>
    /// Direct override of <see cref="WindowAdapter"/> or its generic type if there is one
    /// </summary>
    public partial class WindowAdapterDirect : WindowAdapter
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.awt.event.WindowAdapter";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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
    }
    #endregion

    #region WindowAdapter
    public partial class WindowAdapter
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
        /// <summary>
        /// Handlers initializer for <see cref="WindowAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("windowActivated", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowActivatedEventHandler));
            AddEventHandler("windowClosed", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowClosedEventHandler));
            AddEventHandler("windowClosing", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowClosingEventHandler));
            AddEventHandler("windowDeactivated", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowDeactivatedEventHandler));
            AddEventHandler("windowDeiconified", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowDeiconifiedEventHandler));
            AddEventHandler("windowGainedFocus", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowGainedFocusEventHandler));
            AddEventHandler("windowIconified", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowIconifiedEventHandler));
            AddEventHandler("windowLostFocus", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowLostFocusEventHandler));
            AddEventHandler("windowOpened", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowOpenedEventHandler));
            AddEventHandler("windowStateChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowStateChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowActivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowActivated"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowActivated { get; set; } = null;

        void WindowActivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            var methodToExecute = (OnWindowActivated != null) ? OnWindowActivated : WindowActivated;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowActivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowActivated(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowClosed(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowClosed"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowClosed { get; set; } = null;

        void WindowClosedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            var methodToExecute = (OnWindowClosed != null) ? OnWindowClosed : WindowClosed;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowClosed(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowClosed(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowClosing(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowClosing"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowClosing { get; set; } = null;

        void WindowClosingEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            var methodToExecute = (OnWindowClosing != null) ? OnWindowClosing : WindowClosing;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowClosing(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowClosing(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowDeactivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowDeactivated"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowDeactivated { get; set; } = null;

        void WindowDeactivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            var methodToExecute = (OnWindowDeactivated != null) ? OnWindowDeactivated : WindowDeactivated;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowDeactivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowDeactivated(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowDeiconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowDeiconified"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowDeiconified { get; set; } = null;

        void WindowDeiconifiedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            var methodToExecute = (OnWindowDeiconified != null) ? OnWindowDeiconified : WindowDeiconified;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowDeiconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowDeiconified(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowGainedFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowGainedFocus"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowGainedFocus { get; set; } = null;

        void WindowGainedFocusEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            var methodToExecute = (OnWindowGainedFocus != null) ? OnWindowGainedFocus : WindowGainedFocus;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowGainedFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowGainedFocus(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowIconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowIconified"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowIconified { get; set; } = null;

        void WindowIconifiedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            var methodToExecute = (OnWindowIconified != null) ? OnWindowIconified : WindowIconified;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowIconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowIconified(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowLostFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowLostFocus"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowLostFocus { get; set; } = null;

        void WindowLostFocusEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            var methodToExecute = (OnWindowLostFocus != null) ? OnWindowLostFocus : WindowLostFocus;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowLostFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowLostFocus(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowOpened(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowOpened"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowOpened { get; set; } = null;

        void WindowOpenedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            var methodToExecute = (OnWindowOpened != null) ? OnWindowOpened : WindowOpened;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowOpened(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowOpened(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowStateChanged(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowStateChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowStateChanged { get; set; } = null;

        void WindowStateChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            var methodToExecute = (OnWindowStateChanged != null) ? OnWindowStateChanged : WindowStateChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowStateChanged(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowStateChanged(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WindowAdapterDirect
    public partial class WindowAdapterDirect
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
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowActivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowActivated(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowActivated", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowClosed(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowClosed(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowClosed", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowClosing(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowClosing(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowClosing", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowDeactivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowDeactivated(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowDeactivated", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowDeiconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowDeiconified(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowDeiconified", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowGainedFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowGainedFocus(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowGainedFocus", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowIconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowIconified(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowIconified", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowLostFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowLostFocus(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowLostFocus", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowOpened(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowOpened(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowOpened", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowStateChanged(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowStateChanged(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowStateChanged", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}