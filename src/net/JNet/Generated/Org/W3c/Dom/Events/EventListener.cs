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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Events
{
    #region IEventListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.org.w3c.dom.events.EventListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/EventListener.html"/>
    /// </summary>
    public partial interface IEventListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/EventListener.html#handleEvent(org.w3c.dom.events.Event)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Events.Event"/></param>
        void HandleEvent(Org.W3c.Dom.Events.Event arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EventListener
    public partial class EventListener : Org.W3c.Dom.Events.IEventListener
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
        /// Handlers initializer for <see cref="EventListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("handleEvent", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.W3c.Dom.Events.Event>>>(HandleEventEventHandler)); OnHandleEvent = HandleEvent;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/EventListener.html#handleEvent(org.w3c.dom.events.Event)"/>
        /// </summary>
        public System.Action<Org.W3c.Dom.Events.Event> OnHandleEvent { get; set; }

        void HandleEventEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.W3c.Dom.Events.Event>> data)
        {
            if (OnHandleEvent != null) OnHandleEvent.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/EventListener.html#handleEvent(org.w3c.dom.events.Event)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Events.Event"/></param>
        public virtual void HandleEvent(Org.W3c.Dom.Events.Event arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}