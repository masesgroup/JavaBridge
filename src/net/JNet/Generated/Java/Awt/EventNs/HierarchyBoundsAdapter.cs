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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region HierarchyBoundsAdapter
    public partial class HierarchyBoundsAdapter
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
        /// Handlers initializer for <see cref="HierarchyBoundsAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("ancestorMoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.HierarchyEvent>>>(AncestorMovedEventHandler));
            AddEventHandler("ancestorResized", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.HierarchyEvent>>>(AncestorResizedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyBoundsAdapter.html#ancestorMoved(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAncestorMoved"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.HierarchyEvent> OnAncestorMoved { get; set; } = null;

        void AncestorMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.HierarchyEvent>> data)
        {
            var methodToExecute = (OnAncestorMoved != null) ? OnAncestorMoved : AncestorMoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyBoundsAdapter.html#ancestorMoved(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.HierarchyEvent"/></param>
        public virtual void AncestorMoved(Java.Awt.EventNs.HierarchyEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyBoundsAdapter.html#ancestorResized(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAncestorResized"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.HierarchyEvent> OnAncestorResized { get; set; } = null;

        void AncestorResizedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.HierarchyEvent>> data)
        {
            var methodToExecute = (OnAncestorResized != null) ? OnAncestorResized : AncestorResized;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyBoundsAdapter.html#ancestorResized(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.HierarchyEvent"/></param>
        public virtual void AncestorResized(Java.Awt.EventNs.HierarchyEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HierarchyBoundsAdapterDirect
    public partial class HierarchyBoundsAdapterDirect
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyBoundsAdapter.html#ancestorMoved(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.HierarchyEvent"/></param>
        public override void AncestorMoved(Java.Awt.EventNs.HierarchyEvent arg0)
        {
            IExecuteWithSignature("ancestorMoved", "(Ljava/awt/event/HierarchyEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyBoundsAdapter.html#ancestorResized(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.HierarchyEvent"/></param>
        public override void AncestorResized(Java.Awt.EventNs.HierarchyEvent arg0)
        {
            IExecuteWithSignature("ancestorResized", "(Ljava/awt/event/HierarchyEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}