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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Event
{
    #region IMenuDragMouseListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.MenuDragMouseListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html"/>
    /// </summary>
    public partial interface IMenuDragMouseListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseDragged(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        void MenuDragMouseDragged(Javax.Swing.Event.MenuDragMouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseEntered(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        void MenuDragMouseEntered(Javax.Swing.Event.MenuDragMouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseExited(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        void MenuDragMouseExited(Javax.Swing.Event.MenuDragMouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseReleased(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        void MenuDragMouseReleased(Javax.Swing.Event.MenuDragMouseEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MenuDragMouseListener
    public partial class MenuDragMouseListener : Javax.Swing.Event.IMenuDragMouseListener
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
        /// Handlers initializer for <see cref="MenuDragMouseListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("menuDragMouseDragged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuDragMouseEvent>>>(MenuDragMouseDraggedEventHandler));
            AddEventHandler("menuDragMouseEntered", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuDragMouseEvent>>>(MenuDragMouseEnteredEventHandler));
            AddEventHandler("menuDragMouseExited", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuDragMouseEvent>>>(MenuDragMouseExitedEventHandler));
            AddEventHandler("menuDragMouseReleased", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuDragMouseEvent>>>(MenuDragMouseReleasedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseDragged(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuDragMouseDragged"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.MenuDragMouseEvent> OnMenuDragMouseDragged { get; set; } = null;

        void MenuDragMouseDraggedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuDragMouseEvent>> data)
        {
            var methodToExecute = (OnMenuDragMouseDragged != null) ? OnMenuDragMouseDragged : MenuDragMouseDragged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseDragged(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        public virtual void MenuDragMouseDragged(Javax.Swing.Event.MenuDragMouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseEntered(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuDragMouseEntered"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.MenuDragMouseEvent> OnMenuDragMouseEntered { get; set; } = null;

        void MenuDragMouseEnteredEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuDragMouseEvent>> data)
        {
            var methodToExecute = (OnMenuDragMouseEntered != null) ? OnMenuDragMouseEntered : MenuDragMouseEntered;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseEntered(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        public virtual void MenuDragMouseEntered(Javax.Swing.Event.MenuDragMouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseExited(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuDragMouseExited"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.MenuDragMouseEvent> OnMenuDragMouseExited { get; set; } = null;

        void MenuDragMouseExitedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuDragMouseEvent>> data)
        {
            var methodToExecute = (OnMenuDragMouseExited != null) ? OnMenuDragMouseExited : MenuDragMouseExited;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseExited(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        public virtual void MenuDragMouseExited(Javax.Swing.Event.MenuDragMouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseReleased(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuDragMouseReleased"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.MenuDragMouseEvent> OnMenuDragMouseReleased { get; set; } = null;

        void MenuDragMouseReleasedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuDragMouseEvent>> data)
        {
            var methodToExecute = (OnMenuDragMouseReleased != null) ? OnMenuDragMouseReleased : MenuDragMouseReleased;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseReleased(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        public virtual void MenuDragMouseReleased(Javax.Swing.Event.MenuDragMouseEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}