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

namespace Javax.Print.Event
{
    #region PrintJobAttributeListener definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAttributeListener.html"/>
    /// </summary>
    public partial class PrintJobAttributeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PrintJobAttributeListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.print.event.PrintJobAttributeListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region PrintJobAttributeListenerDirect definition
    /// <summary>
    /// Direct override of <see cref="PrintJobAttributeListener"/> or its generic type if there is one
    /// </summary>
    public partial class PrintJobAttributeListenerDirect : PrintJobAttributeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.print.event.PrintJobAttributeListener";
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
    #endregion

    #region IPrintJobAttributeListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.print.event.PrintJobAttributeListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAttributeListener.html"/>
    /// </summary>
    public partial interface IPrintJobAttributeListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAttributeListener.html#attributeUpdate(javax.print.event.PrintJobAttributeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobAttributeEvent"/></param>
        void AttributeUpdate(Javax.Print.Event.PrintJobAttributeEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PrintJobAttributeListener
    public partial class PrintJobAttributeListener : Javax.Print.Event.IPrintJobAttributeListener
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
        /// Handlers initializer for <see cref="PrintJobAttributeListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("attributeUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobAttributeEvent>>>(AttributeUpdateEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAttributeListener.html#attributeUpdate(javax.print.event.PrintJobAttributeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAttributeUpdate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Print.Event.PrintJobAttributeEvent> OnAttributeUpdate { get; set; } = null;

        void AttributeUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobAttributeEvent>> data)
        {
            var methodToExecute = (OnAttributeUpdate != null) ? OnAttributeUpdate : AttributeUpdate;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAttributeListener.html#attributeUpdate(javax.print.event.PrintJobAttributeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobAttributeEvent"/></param>
        public virtual void AttributeUpdate(Javax.Print.Event.PrintJobAttributeEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PrintJobAttributeListenerDirect
    public partial class PrintJobAttributeListenerDirect : Javax.Print.Event.IPrintJobAttributeListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAttributeListener.html#attributeUpdate(javax.print.event.PrintJobAttributeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobAttributeEvent"/></param>
        public override void AttributeUpdate(Javax.Print.Event.PrintJobAttributeEvent arg0)
        {
            IExecuteWithSignature("attributeUpdate", "(Ljavax/print/event/PrintJobAttributeEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}