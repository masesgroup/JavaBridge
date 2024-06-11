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

namespace Org.W3c.Dom.Events
{
    #region IEventTarget
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IEventTarget
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/EventTarget.html#dispatchEvent(org.w3c.dom.events.Event)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Events.Event"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.W3c.Dom.Events.EventException"/>
        bool DispatchEvent(Org.W3c.Dom.Events.Event arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/EventTarget.html#addEventListener(java.lang.String,org.w3c.dom.events.EventListener,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Events.EventListener"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        void AddEventListener(Java.Lang.String arg0, Org.W3c.Dom.Events.EventListener arg1, bool arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/EventTarget.html#removeEventListener(java.lang.String,org.w3c.dom.events.EventListener,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Events.EventListener"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        void RemoveEventListener(Java.Lang.String arg0, Org.W3c.Dom.Events.EventListener arg1, bool arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EventTarget
    public partial class EventTarget : Org.W3c.Dom.Events.IEventTarget
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/EventTarget.html#dispatchEvent(org.w3c.dom.events.Event)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Events.Event"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.W3c.Dom.Events.EventException"/>
        public bool DispatchEvent(Org.W3c.Dom.Events.Event arg0)
        {
            return IExecuteWithSignature<bool>("dispatchEvent", "(Lorg/w3c/dom/events/Event;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/EventTarget.html#addEventListener(java.lang.String,org.w3c.dom.events.EventListener,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Events.EventListener"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void AddEventListener(Java.Lang.String arg0, Org.W3c.Dom.Events.EventListener arg1, bool arg2)
        {
            IExecute("addEventListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/EventTarget.html#removeEventListener(java.lang.String,org.w3c.dom.events.EventListener,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Events.EventListener"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void RemoveEventListener(Java.Lang.String arg0, Org.W3c.Dom.Events.EventListener arg1, bool arg2)
        {
            IExecute("removeEventListener", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}