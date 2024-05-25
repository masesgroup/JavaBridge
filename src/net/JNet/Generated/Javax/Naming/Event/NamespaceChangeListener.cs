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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Event
{
    #region INamespaceChangeListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.naming.event.NamespaceChangeListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html"/>
    /// </summary>
    public partial interface INamespaceChangeListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectAdded(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        void ObjectAdded(Javax.Naming.Event.NamingEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRemoved(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        void ObjectRemoved(Javax.Naming.Event.NamingEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRenamed(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        void ObjectRenamed(Javax.Naming.Event.NamingEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingExceptionEvent"/></param>
        void NamingExceptionThrown(Javax.Naming.Event.NamingExceptionEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NamespaceChangeListener
    public partial class NamespaceChangeListener : Javax.Naming.Event.INamespaceChangeListener
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
        /// Handlers initializer for <see cref="NamespaceChangeListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("objectAdded", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Naming.Event.NamingEvent>>>(ObjectAddedEventHandler));
            AddEventHandler("objectRemoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Naming.Event.NamingEvent>>>(ObjectRemovedEventHandler));
            AddEventHandler("objectRenamed", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Naming.Event.NamingEvent>>>(ObjectRenamedEventHandler));
            AddEventHandler("namingExceptionThrown", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Naming.Event.NamingExceptionEvent>>>(NamingExceptionThrownEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectAdded(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnObjectAdded"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Naming.Event.NamingEvent> OnObjectAdded { get; set; } = null;

        void ObjectAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Naming.Event.NamingEvent>> data)
        {
            var methodToExecute = (OnObjectAdded != null) ? OnObjectAdded : ObjectAdded;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectAdded(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        public virtual void ObjectAdded(Javax.Naming.Event.NamingEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRemoved(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnObjectRemoved"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Naming.Event.NamingEvent> OnObjectRemoved { get; set; } = null;

        void ObjectRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Naming.Event.NamingEvent>> data)
        {
            var methodToExecute = (OnObjectRemoved != null) ? OnObjectRemoved : ObjectRemoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRemoved(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        public virtual void ObjectRemoved(Javax.Naming.Event.NamingEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRenamed(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnObjectRenamed"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Naming.Event.NamingEvent> OnObjectRenamed { get; set; } = null;

        void ObjectRenamedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Naming.Event.NamingEvent>> data)
        {
            var methodToExecute = (OnObjectRenamed != null) ? OnObjectRenamed : ObjectRenamed;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRenamed(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        public virtual void ObjectRenamed(Javax.Naming.Event.NamingEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnNamingExceptionThrown"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Naming.Event.NamingExceptionEvent> OnNamingExceptionThrown { get; set; } = null;

        void NamingExceptionThrownEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Naming.Event.NamingExceptionEvent>> data)
        {
            var methodToExecute = (OnNamingExceptionThrown != null) ? OnNamingExceptionThrown : NamingExceptionThrown;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingExceptionEvent"/></param>
        public virtual void NamingExceptionThrown(Javax.Naming.Event.NamingExceptionEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NamespaceChangeListenerDirect
    public partial class NamespaceChangeListenerDirect : Javax.Naming.Event.INamespaceChangeListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectAdded(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        public override void ObjectAdded(Javax.Naming.Event.NamingEvent arg0)
        {
            IExecuteWithSignature("objectAdded", "(Ljavax/naming/event/NamingEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRemoved(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        public override void ObjectRemoved(Javax.Naming.Event.NamingEvent arg0)
        {
            IExecuteWithSignature("objectRemoved", "(Ljavax/naming/event/NamingEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRenamed(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        public override void ObjectRenamed(Javax.Naming.Event.NamingEvent arg0)
        {
            IExecuteWithSignature("objectRenamed", "(Ljavax/naming/event/NamingEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingExceptionEvent"/></param>
        public override void NamingExceptionThrown(Javax.Naming.Event.NamingExceptionEvent arg0)
        {
            IExecute("namingExceptionThrown", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}