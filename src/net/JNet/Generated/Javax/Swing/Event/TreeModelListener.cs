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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Event
{
    #region ITreeModelListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.TreeModelListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html"/>
    /// </summary>
    public partial interface ITreeModelListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeNodesChanged(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        void TreeNodesChanged(Javax.Swing.Event.TreeModelEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeNodesInserted(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        void TreeNodesInserted(Javax.Swing.Event.TreeModelEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeNodesRemoved(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        void TreeNodesRemoved(Javax.Swing.Event.TreeModelEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeStructureChanged(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        void TreeStructureChanged(Javax.Swing.Event.TreeModelEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TreeModelListener
    public partial class TreeModelListener : Javax.Swing.Event.ITreeModelListener
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
        /// Handlers initializer for <see cref="TreeModelListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("treeNodesChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeModelEvent>>>(TreeNodesChangedEventHandler));
            AddEventHandler("treeNodesInserted", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeModelEvent>>>(TreeNodesInsertedEventHandler));
            AddEventHandler("treeNodesRemoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeModelEvent>>>(TreeNodesRemovedEventHandler));
            AddEventHandler("treeStructureChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeModelEvent>>>(TreeStructureChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeNodesChanged(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTreeNodesChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.TreeModelEvent> OnTreeNodesChanged { get; set; } = null;

        void TreeNodesChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeModelEvent>> data)
        {
            var methodToExecute = (OnTreeNodesChanged != null) ? OnTreeNodesChanged : TreeNodesChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeNodesChanged(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public virtual void TreeNodesChanged(Javax.Swing.Event.TreeModelEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeNodesInserted(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTreeNodesInserted"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.TreeModelEvent> OnTreeNodesInserted { get; set; } = null;

        void TreeNodesInsertedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeModelEvent>> data)
        {
            var methodToExecute = (OnTreeNodesInserted != null) ? OnTreeNodesInserted : TreeNodesInserted;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeNodesInserted(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public virtual void TreeNodesInserted(Javax.Swing.Event.TreeModelEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeNodesRemoved(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTreeNodesRemoved"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.TreeModelEvent> OnTreeNodesRemoved { get; set; } = null;

        void TreeNodesRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeModelEvent>> data)
        {
            var methodToExecute = (OnTreeNodesRemoved != null) ? OnTreeNodesRemoved : TreeNodesRemoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeNodesRemoved(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public virtual void TreeNodesRemoved(Javax.Swing.Event.TreeModelEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeStructureChanged(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTreeStructureChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.TreeModelEvent> OnTreeStructureChanged { get; set; } = null;

        void TreeStructureChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeModelEvent>> data)
        {
            var methodToExecute = (OnTreeStructureChanged != null) ? OnTreeStructureChanged : TreeStructureChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeStructureChanged(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public virtual void TreeStructureChanged(Javax.Swing.Event.TreeModelEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TreeModelListenerDirect
    public partial class TreeModelListenerDirect : Javax.Swing.Event.ITreeModelListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeNodesChanged(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public override void TreeNodesChanged(Javax.Swing.Event.TreeModelEvent arg0)
        {
            IExecuteWithSignature("treeNodesChanged", "(Ljavax/swing/event/TreeModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeNodesInserted(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public override void TreeNodesInserted(Javax.Swing.Event.TreeModelEvent arg0)
        {
            IExecuteWithSignature("treeNodesInserted", "(Ljavax/swing/event/TreeModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeNodesRemoved(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public override void TreeNodesRemoved(Javax.Swing.Event.TreeModelEvent arg0)
        {
            IExecuteWithSignature("treeNodesRemoved", "(Ljavax/swing/event/TreeModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelListener.html#treeStructureChanged(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public override void TreeStructureChanged(Javax.Swing.Event.TreeModelEvent arg0)
        {
            IExecuteWithSignature("treeStructureChanged", "(Ljavax/swing/event/TreeModelEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}