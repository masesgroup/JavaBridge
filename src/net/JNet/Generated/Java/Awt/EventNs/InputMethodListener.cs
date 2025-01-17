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

namespace Java.Awt.EventNs
{
    #region InputMethodListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html"/>
    /// </summary>
    public partial class InputMethodListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public InputMethodListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.awt.event.InputMethodListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region InputMethodListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="InputMethodListener"/> or its generic type if there is one
    /// </summary>
    public partial class InputMethodListenerDirect : InputMethodListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.awt.event.InputMethodListener";
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

    #region IInputMethodListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.InputMethodListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html"/>
    /// </summary>
    public partial interface IInputMethodListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html#caretPositionChanged(java.awt.event.InputMethodEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.InputMethodEvent"/></param>
        void CaretPositionChanged(Java.Awt.EventNs.InputMethodEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html#inputMethodTextChanged(java.awt.event.InputMethodEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.InputMethodEvent"/></param>
        void InputMethodTextChanged(Java.Awt.EventNs.InputMethodEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region InputMethodListener implementation
    public partial class InputMethodListener : Java.Awt.EventNs.IInputMethodListener
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
        /// Handlers initializer for <see cref="InputMethodListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("caretPositionChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(CaretPositionChangedEventHandler));
            AddEventHandler("inputMethodTextChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(InputMethodTextChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html#caretPositionChanged(java.awt.event.InputMethodEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnCaretPositionChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.InputMethodEvent> OnCaretPositionChanged { get; set; } = null;

        bool hasOverrideCaretPositionChanged = true;
        void CaretPositionChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideCaretPositionChanged = true;
            var methodToExecute = (OnCaretPositionChanged != null) ? OnCaretPositionChanged : CaretPositionChanged;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.InputMethodEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideCaretPositionChanged;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html#caretPositionChanged(java.awt.event.InputMethodEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.InputMethodEvent"/></param>
        public virtual void CaretPositionChanged(Java.Awt.EventNs.InputMethodEvent arg0)
        {
            hasOverrideCaretPositionChanged = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html#inputMethodTextChanged(java.awt.event.InputMethodEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInputMethodTextChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.InputMethodEvent> OnInputMethodTextChanged { get; set; } = null;

        bool hasOverrideInputMethodTextChanged = true;
        void InputMethodTextChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideInputMethodTextChanged = true;
            var methodToExecute = (OnInputMethodTextChanged != null) ? OnInputMethodTextChanged : InputMethodTextChanged;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.InputMethodEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideInputMethodTextChanged;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html#inputMethodTextChanged(java.awt.event.InputMethodEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.InputMethodEvent"/></param>
        public virtual void InputMethodTextChanged(Java.Awt.EventNs.InputMethodEvent arg0)
        {
            hasOverrideInputMethodTextChanged = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region InputMethodListenerDirect implementation
    public partial class InputMethodListenerDirect : Java.Awt.EventNs.IInputMethodListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html#caretPositionChanged(java.awt.event.InputMethodEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.InputMethodEvent"/></param>
        public override void CaretPositionChanged(Java.Awt.EventNs.InputMethodEvent arg0)
        {
            IExecuteWithSignature("caretPositionChanged", "(Ljava/awt/event/InputMethodEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html#inputMethodTextChanged(java.awt.event.InputMethodEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.InputMethodEvent"/></param>
        public override void InputMethodTextChanged(Java.Awt.EventNs.InputMethodEvent arg0)
        {
            IExecuteWithSignature("inputMethodTextChanged", "(Ljava/awt/event/InputMethodEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}