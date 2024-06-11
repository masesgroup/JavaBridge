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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Dnd
{
    #region IDropTargetListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.dnd.DropTargetListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html"/>
    /// </summary>
    public partial interface IDropTargetListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragEnter(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        void DragEnter(Java.Awt.Dnd.DropTargetDragEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragExit(java.awt.dnd.DropTargetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetEvent"/></param>
        void DragExit(Java.Awt.Dnd.DropTargetEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragOver(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        void DragOver(Java.Awt.Dnd.DropTargetDragEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#drop(java.awt.dnd.DropTargetDropEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDropEvent"/></param>
        void Drop(Java.Awt.Dnd.DropTargetDropEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dropActionChanged(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        void DropActionChanged(Java.Awt.Dnd.DropTargetDragEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DropTargetListener
    public partial class DropTargetListener : Java.Awt.Dnd.IDropTargetListener
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
        /// Handlers initializer for <see cref="DropTargetListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("dragEnter", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDragEvent>>>(DragEnterEventHandler));
            AddEventHandler("dragExit", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetEvent>>>(DragExitEventHandler));
            AddEventHandler("dragOver", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDragEvent>>>(DragOverEventHandler));
            AddEventHandler("drop", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDropEvent>>>(DropEventHandler));
            AddEventHandler("dropActionChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDragEvent>>>(DropActionChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragEnter(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDragEnter"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.Dnd.DropTargetDragEvent> OnDragEnter { get; set; } = null;

        void DragEnterEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDragEvent>> data)
        {
            var methodToExecute = (OnDragEnter != null) ? OnDragEnter : DragEnter;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragEnter(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public virtual void DragEnter(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragExit(java.awt.dnd.DropTargetEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDragExit"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.Dnd.DropTargetEvent> OnDragExit { get; set; } = null;

        void DragExitEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetEvent>> data)
        {
            var methodToExecute = (OnDragExit != null) ? OnDragExit : DragExit;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragExit(java.awt.dnd.DropTargetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetEvent"/></param>
        public virtual void DragExit(Java.Awt.Dnd.DropTargetEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragOver(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDragOver"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.Dnd.DropTargetDragEvent> OnDragOver { get; set; } = null;

        void DragOverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDragEvent>> data)
        {
            var methodToExecute = (OnDragOver != null) ? OnDragOver : DragOver;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragOver(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public virtual void DragOver(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#drop(java.awt.dnd.DropTargetDropEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDrop"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.Dnd.DropTargetDropEvent> OnDrop { get; set; } = null;

        void DropEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDropEvent>> data)
        {
            var methodToExecute = (OnDrop != null) ? OnDrop : Drop;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#drop(java.awt.dnd.DropTargetDropEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDropEvent"/></param>
        public virtual void Drop(Java.Awt.Dnd.DropTargetDropEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dropActionChanged(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDropActionChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.Dnd.DropTargetDragEvent> OnDropActionChanged { get; set; } = null;

        void DropActionChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDragEvent>> data)
        {
            var methodToExecute = (OnDropActionChanged != null) ? OnDropActionChanged : DropActionChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dropActionChanged(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public virtual void DropActionChanged(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DropTargetListenerDirect
    public partial class DropTargetListenerDirect : Java.Awt.Dnd.IDropTargetListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragEnter(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public override void DragEnter(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            IExecuteWithSignature("dragEnter", "(Ljava/awt/dnd/DropTargetDragEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragExit(java.awt.dnd.DropTargetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetEvent"/></param>
        public override void DragExit(Java.Awt.Dnd.DropTargetEvent arg0)
        {
            IExecuteWithSignature("dragExit", "(Ljava/awt/dnd/DropTargetEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragOver(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public override void DragOver(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            IExecuteWithSignature("dragOver", "(Ljava/awt/dnd/DropTargetDragEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#drop(java.awt.dnd.DropTargetDropEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDropEvent"/></param>
        public override void Drop(Java.Awt.Dnd.DropTargetDropEvent arg0)
        {
            IExecuteWithSignature("drop", "(Ljava/awt/dnd/DropTargetDropEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dropActionChanged(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public override void DropActionChanged(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            IExecuteWithSignature("dropActionChanged", "(Ljava/awt/dnd/DropTargetDragEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}