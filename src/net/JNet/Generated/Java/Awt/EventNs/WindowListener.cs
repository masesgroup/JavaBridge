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
    #region WindowListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html"/>
    /// </summary>
    public partial class WindowListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public WindowListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.awt.event.WindowListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region WindowListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="WindowListener"/> or its generic type if there is one
    /// </summary>
    public partial class WindowListenerDirect : WindowListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.awt.event.WindowListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
    #endregion

    #region IWindowListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.WindowListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html"/>
    /// </summary>
    public partial interface IWindowListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowActivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowActivated(Java.Awt.EventNs.WindowEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowClosed(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowClosed(Java.Awt.EventNs.WindowEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowClosing(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowClosing(Java.Awt.EventNs.WindowEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowDeactivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowDeactivated(Java.Awt.EventNs.WindowEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowDeiconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowDeiconified(Java.Awt.EventNs.WindowEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowIconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowIconified(Java.Awt.EventNs.WindowEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowOpened(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowOpened(Java.Awt.EventNs.WindowEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WindowListener implementation
    public partial class WindowListener : Java.Awt.EventNs.IWindowListener
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
        /// Handlers initializer for <see cref="WindowListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("windowActivated", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(WindowActivatedEventHandler));
            AddEventHandler("windowClosed", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(WindowClosedEventHandler));
            AddEventHandler("windowClosing", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(WindowClosingEventHandler));
            AddEventHandler("windowDeactivated", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(WindowDeactivatedEventHandler));
            AddEventHandler("windowDeiconified", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(WindowDeiconifiedEventHandler));
            AddEventHandler("windowIconified", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(WindowIconifiedEventHandler));
            AddEventHandler("windowOpened", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(WindowOpenedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowActivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowActivated"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowActivated { get; set; } = null;

        bool hasOverrideWindowActivated = true;
        void WindowActivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideWindowActivated = true;
            var methodToExecute = (OnWindowActivated != null) ? OnWindowActivated : WindowActivated;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.WindowEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideWindowActivated;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowActivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowActivated(Java.Awt.EventNs.WindowEvent arg0)
        {
            hasOverrideWindowActivated = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowClosed(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowClosed"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowClosed { get; set; } = null;

        bool hasOverrideWindowClosed = true;
        void WindowClosedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideWindowClosed = true;
            var methodToExecute = (OnWindowClosed != null) ? OnWindowClosed : WindowClosed;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.WindowEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideWindowClosed;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowClosed(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowClosed(Java.Awt.EventNs.WindowEvent arg0)
        {
            hasOverrideWindowClosed = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowClosing(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowClosing"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowClosing { get; set; } = null;

        bool hasOverrideWindowClosing = true;
        void WindowClosingEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideWindowClosing = true;
            var methodToExecute = (OnWindowClosing != null) ? OnWindowClosing : WindowClosing;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.WindowEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideWindowClosing;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowClosing(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowClosing(Java.Awt.EventNs.WindowEvent arg0)
        {
            hasOverrideWindowClosing = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowDeactivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowDeactivated"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowDeactivated { get; set; } = null;

        bool hasOverrideWindowDeactivated = true;
        void WindowDeactivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideWindowDeactivated = true;
            var methodToExecute = (OnWindowDeactivated != null) ? OnWindowDeactivated : WindowDeactivated;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.WindowEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideWindowDeactivated;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowDeactivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowDeactivated(Java.Awt.EventNs.WindowEvent arg0)
        {
            hasOverrideWindowDeactivated = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowDeiconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowDeiconified"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowDeiconified { get; set; } = null;

        bool hasOverrideWindowDeiconified = true;
        void WindowDeiconifiedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideWindowDeiconified = true;
            var methodToExecute = (OnWindowDeiconified != null) ? OnWindowDeiconified : WindowDeiconified;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.WindowEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideWindowDeiconified;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowDeiconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowDeiconified(Java.Awt.EventNs.WindowEvent arg0)
        {
            hasOverrideWindowDeiconified = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowIconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowIconified"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowIconified { get; set; } = null;

        bool hasOverrideWindowIconified = true;
        void WindowIconifiedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideWindowIconified = true;
            var methodToExecute = (OnWindowIconified != null) ? OnWindowIconified : WindowIconified;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.WindowEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideWindowIconified;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowIconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowIconified(Java.Awt.EventNs.WindowEvent arg0)
        {
            hasOverrideWindowIconified = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowOpened(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowOpened"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowOpened { get; set; } = null;

        bool hasOverrideWindowOpened = true;
        void WindowOpenedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideWindowOpened = true;
            var methodToExecute = (OnWindowOpened != null) ? OnWindowOpened : WindowOpened;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.WindowEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideWindowOpened;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowOpened(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowOpened(Java.Awt.EventNs.WindowEvent arg0)
        {
            hasOverrideWindowOpened = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WindowListenerDirect implementation
    public partial class WindowListenerDirect : Java.Awt.EventNs.IWindowListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowActivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowActivated(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowActivated", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowClosed(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowClosed(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowClosed", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowClosing(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowClosing(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowClosing", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowDeactivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowDeactivated(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowDeactivated", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowDeiconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowDeiconified(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowDeiconified", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowIconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowIconified(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowIconified", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowOpened(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowOpened(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowOpened", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}