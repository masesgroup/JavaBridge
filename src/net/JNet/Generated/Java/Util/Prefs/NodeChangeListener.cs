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

namespace Java.Util.Prefs
{
    #region NodeChangeListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html"/>
    /// </summary>
    public partial class NodeChangeListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public NodeChangeListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.util.prefs.NodeChangeListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region NodeChangeListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="NodeChangeListener"/> or its generic type if there is one
    /// </summary>
    public partial class NodeChangeListenerDirect : NodeChangeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.util.prefs.NodeChangeListener";
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

    #region INodeChangeListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.prefs.NodeChangeListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html"/>
    /// </summary>
    public partial interface INodeChangeListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html#childAdded(java.util.prefs.NodeChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.NodeChangeEvent"/></param>
        void ChildAdded(Java.Util.Prefs.NodeChangeEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html#childRemoved(java.util.prefs.NodeChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.NodeChangeEvent"/></param>
        void ChildRemoved(Java.Util.Prefs.NodeChangeEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NodeChangeListener implementation
    public partial class NodeChangeListener : Java.Util.Prefs.INodeChangeListener
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
        /// Handlers initializer for <see cref="NodeChangeListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("childAdded", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ChildAddedEventHandler));
            AddEventHandler("childRemoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ChildRemovedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html#childAdded(java.util.prefs.NodeChangeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnChildAdded"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Prefs.NodeChangeEvent> OnChildAdded { get; set; } = null;

        bool hasOverrideChildAdded = true;
        void ChildAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideChildAdded = true;
            var methodToExecute = (OnChildAdded != null) ? OnChildAdded : ChildAdded;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Prefs.NodeChangeEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideChildAdded;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html#childAdded(java.util.prefs.NodeChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.NodeChangeEvent"/></param>
        public virtual void ChildAdded(Java.Util.Prefs.NodeChangeEvent arg0)
        {
            hasOverrideChildAdded = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html#childRemoved(java.util.prefs.NodeChangeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnChildRemoved"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Prefs.NodeChangeEvent> OnChildRemoved { get; set; } = null;

        bool hasOverrideChildRemoved = true;
        void ChildRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideChildRemoved = true;
            var methodToExecute = (OnChildRemoved != null) ? OnChildRemoved : ChildRemoved;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Prefs.NodeChangeEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideChildRemoved;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html#childRemoved(java.util.prefs.NodeChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.NodeChangeEvent"/></param>
        public virtual void ChildRemoved(Java.Util.Prefs.NodeChangeEvent arg0)
        {
            hasOverrideChildRemoved = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NodeChangeListenerDirect implementation
    public partial class NodeChangeListenerDirect : Java.Util.Prefs.INodeChangeListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html#childAdded(java.util.prefs.NodeChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.NodeChangeEvent"/></param>
        public override void ChildAdded(Java.Util.Prefs.NodeChangeEvent arg0)
        {
            IExecuteWithSignature("childAdded", "(Ljava/util/prefs/NodeChangeEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html#childRemoved(java.util.prefs.NodeChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.NodeChangeEvent"/></param>
        public override void ChildRemoved(Java.Util.Prefs.NodeChangeEvent arg0)
        {
            IExecuteWithSignature("childRemoved", "(Ljava/util/prefs/NodeChangeEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}