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
    #region FocusAdapter definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusAdapter.html"/>
    /// </summary>
    public partial class FocusAdapter : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FocusAdapter() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.awt.event.FocusAdapter";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region FocusAdapterDirect definition
    /// <summary>
    /// Direct override of <see cref="FocusAdapter"/> or its generic type if there is one
    /// </summary>
    public partial class FocusAdapterDirect : FocusAdapter
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.awt.event.FocusAdapter";
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

    #region FocusAdapter
    public partial class FocusAdapter
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
        /// Handlers initializer for <see cref="FocusAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("focusGained", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.FocusEvent>>>(FocusGainedEventHandler));
            AddEventHandler("focusLost", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.FocusEvent>>>(FocusLostEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusAdapter.html#focusGained(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnFocusGained"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.FocusEvent> OnFocusGained { get; set; } = null;

        void FocusGainedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.FocusEvent>> data)
        {
            var methodToExecute = (OnFocusGained != null) ? OnFocusGained : FocusGained;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusAdapter.html#focusGained(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        public virtual void FocusGained(Java.Awt.EventNs.FocusEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusAdapter.html#focusLost(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnFocusLost"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.FocusEvent> OnFocusLost { get; set; } = null;

        void FocusLostEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.FocusEvent>> data)
        {
            var methodToExecute = (OnFocusLost != null) ? OnFocusLost : FocusLost;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusAdapter.html#focusLost(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        public virtual void FocusLost(Java.Awt.EventNs.FocusEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region FocusAdapterDirect
    public partial class FocusAdapterDirect
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusAdapter.html#focusGained(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        public override void FocusGained(Java.Awt.EventNs.FocusEvent arg0)
        {
            IExecuteWithSignature("focusGained", "(Ljava/awt/event/FocusEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusAdapter.html#focusLost(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        public override void FocusLost(Java.Awt.EventNs.FocusEvent arg0)
        {
            IExecuteWithSignature("focusLost", "(Ljava/awt/event/FocusEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}