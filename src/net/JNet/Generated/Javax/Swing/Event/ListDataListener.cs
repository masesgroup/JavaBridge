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

namespace Javax.Swing.Event
{
    #region ListDataListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html"/>
    /// </summary>
    public partial class ListDataListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ListDataListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.swing.event.ListDataListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region ListDataListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="ListDataListener"/> or its generic type if there is one
    /// </summary>
    public partial class ListDataListenerDirect : ListDataListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.swing.event.ListDataListener";
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

    #region IListDataListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.ListDataListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html"/>
    /// </summary>
    public partial interface IListDataListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#contentsChanged(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        void ContentsChanged(Javax.Swing.Event.ListDataEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#intervalAdded(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        void IntervalAdded(Javax.Swing.Event.ListDataEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#intervalRemoved(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        void IntervalRemoved(Javax.Swing.Event.ListDataEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ListDataListener implementation
    public partial class ListDataListener : Javax.Swing.Event.IListDataListener
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
        /// Handlers initializer for <see cref="ListDataListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("contentsChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ContentsChangedEventHandler));
            AddEventHandler("intervalAdded", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(IntervalAddedEventHandler));
            AddEventHandler("intervalRemoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(IntervalRemovedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#contentsChanged(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnContentsChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.ListDataEvent> OnContentsChanged { get; set; } = null;

        bool hasOverrideContentsChanged = true;
        void ContentsChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideContentsChanged = true;
            var methodToExecute = (OnContentsChanged != null) ? OnContentsChanged : ContentsChanged;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.ListDataEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideContentsChanged;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#contentsChanged(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        public virtual void ContentsChanged(Javax.Swing.Event.ListDataEvent arg0)
        {
            hasOverrideContentsChanged = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#intervalAdded(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnIntervalAdded"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.ListDataEvent> OnIntervalAdded { get; set; } = null;

        bool hasOverrideIntervalAdded = true;
        void IntervalAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideIntervalAdded = true;
            var methodToExecute = (OnIntervalAdded != null) ? OnIntervalAdded : IntervalAdded;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.ListDataEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideIntervalAdded;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#intervalAdded(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        public virtual void IntervalAdded(Javax.Swing.Event.ListDataEvent arg0)
        {
            hasOverrideIntervalAdded = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#intervalRemoved(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnIntervalRemoved"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.ListDataEvent> OnIntervalRemoved { get; set; } = null;

        bool hasOverrideIntervalRemoved = true;
        void IntervalRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideIntervalRemoved = true;
            var methodToExecute = (OnIntervalRemoved != null) ? OnIntervalRemoved : IntervalRemoved;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.ListDataEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideIntervalRemoved;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#intervalRemoved(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        public virtual void IntervalRemoved(Javax.Swing.Event.ListDataEvent arg0)
        {
            hasOverrideIntervalRemoved = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ListDataListenerDirect implementation
    public partial class ListDataListenerDirect : Javax.Swing.Event.IListDataListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#contentsChanged(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        public override void ContentsChanged(Javax.Swing.Event.ListDataEvent arg0)
        {
            IExecuteWithSignature("contentsChanged", "(Ljavax/swing/event/ListDataEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#intervalAdded(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        public override void IntervalAdded(Javax.Swing.Event.ListDataEvent arg0)
        {
            IExecuteWithSignature("intervalAdded", "(Ljavax/swing/event/ListDataEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#intervalRemoved(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        public override void IntervalRemoved(Javax.Swing.Event.ListDataEvent arg0)
        {
            IExecuteWithSignature("intervalRemoved", "(Ljavax/swing/event/ListDataEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}