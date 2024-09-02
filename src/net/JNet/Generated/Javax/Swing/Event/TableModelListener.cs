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

namespace Javax.Swing.Event
{
    #region TableModelListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelListener.html"/>
    /// </summary>
    public partial class TableModelListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TableModelListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.swing.event.TableModelListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region TableModelListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="TableModelListener"/> or its generic type if there is one
    /// </summary>
    public partial class TableModelListenerDirect : TableModelListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.swing.event.TableModelListener";
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

    #region ITableModelListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.TableModelListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelListener.html"/>
    /// </summary>
    public partial interface ITableModelListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelListener.html#tableChanged(javax.swing.event.TableModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableModelEvent"/></param>
        void TableChanged(Javax.Swing.Event.TableModelEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TableModelListener implementation
    public partial class TableModelListener : Javax.Swing.Event.ITableModelListener
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
        /// Handlers initializer for <see cref="TableModelListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("tableChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TableModelEvent>>>(TableChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelListener.html#tableChanged(javax.swing.event.TableModelEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTableChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.TableModelEvent> OnTableChanged { get; set; } = null;

        void TableChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TableModelEvent>> data)
        {
            var methodToExecute = (OnTableChanged != null) ? OnTableChanged : TableChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelListener.html#tableChanged(javax.swing.event.TableModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableModelEvent"/></param>
        public virtual void TableChanged(Javax.Swing.Event.TableModelEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TableModelListenerDirect implementation
    public partial class TableModelListenerDirect : Javax.Swing.Event.ITableModelListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelListener.html#tableChanged(javax.swing.event.TableModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableModelEvent"/></param>
        public override void TableChanged(Javax.Swing.Event.TableModelEvent arg0)
        {
            IExecuteWithSignature("tableChanged", "(Ljavax/swing/event/TableModelEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}