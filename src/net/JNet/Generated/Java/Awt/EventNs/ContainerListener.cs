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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region IContainerListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.ContainerListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerListener.html"/>
    /// </summary>
    public partial interface IContainerListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerListener.html#componentAdded(java.awt.event.ContainerEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ContainerEvent"/></param>
        void ComponentAdded(Java.Awt.EventNs.ContainerEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerListener.html#componentRemoved(java.awt.event.ContainerEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ContainerEvent"/></param>
        void ComponentRemoved(Java.Awt.EventNs.ContainerEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ContainerListener
    public partial class ContainerListener : Java.Awt.EventNs.IContainerListener
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
        /// Handlers initializer for <see cref="ContainerListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("componentAdded", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ContainerEvent>>>(ComponentAddedEventHandler));
            AddEventHandler("componentRemoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ContainerEvent>>>(ComponentRemovedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerListener.html#componentAdded(java.awt.event.ContainerEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnComponentAdded"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.EventNs.ContainerEvent> OnComponentAdded { get; set; } = null;

        void ComponentAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ContainerEvent>> data)
        {
            var methodToExecute = (OnComponentAdded != null) ? OnComponentAdded : ComponentAdded;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerListener.html#componentAdded(java.awt.event.ContainerEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ContainerEvent"/></param>
        public virtual void ComponentAdded(Java.Awt.EventNs.ContainerEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerListener.html#componentRemoved(java.awt.event.ContainerEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnComponentRemoved"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.EventNs.ContainerEvent> OnComponentRemoved { get; set; } = null;

        void ComponentRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ContainerEvent>> data)
        {
            var methodToExecute = (OnComponentRemoved != null) ? OnComponentRemoved : ComponentRemoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerListener.html#componentRemoved(java.awt.event.ContainerEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ContainerEvent"/></param>
        public virtual void ComponentRemoved(Java.Awt.EventNs.ContainerEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}