/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region IHierarchyBoundsListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.HierarchyBoundsListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyBoundsListener.html"/>
    /// </summary>
    public partial interface IHierarchyBoundsListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyBoundsListener.html#ancestorMoved(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.HierarchyEvent"/></param>
        void AncestorMoved(Java.Awt.EventNs.HierarchyEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyBoundsListener.html#ancestorResized(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.HierarchyEvent"/></param>
        void AncestorResized(Java.Awt.EventNs.HierarchyEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HierarchyBoundsListener
    public partial class HierarchyBoundsListener : Java.Awt.EventNs.IHierarchyBoundsListener
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
        /// Handlers initializer for <see cref="HierarchyBoundsListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("ancestorMoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.HierarchyEvent>>>(AncestorMovedEventHandler)); OnAncestorMoved = AncestorMoved;
            AddEventHandler("ancestorResized", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.HierarchyEvent>>>(AncestorResizedEventHandler)); OnAncestorResized = AncestorResized;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyBoundsListener.html#ancestorMoved(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.HierarchyEvent> OnAncestorMoved { get; set; }

        void AncestorMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.HierarchyEvent>> data)
        {
            if (OnAncestorMoved != null) OnAncestorMoved.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyBoundsListener.html#ancestorMoved(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.HierarchyEvent"/></param>
        public virtual void AncestorMoved(Java.Awt.EventNs.HierarchyEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyBoundsListener.html#ancestorResized(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.HierarchyEvent> OnAncestorResized { get; set; }

        void AncestorResizedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.HierarchyEvent>> data)
        {
            if (OnAncestorResized != null) OnAncestorResized.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyBoundsListener.html#ancestorResized(java.awt.event.HierarchyEvent)"/>
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
}