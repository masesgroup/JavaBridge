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

namespace Javax.Swing.Event
{
    #region IMenuListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.MenuListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html"/>
    /// </summary>
    public partial interface IMenuListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuCanceled(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        void MenuCanceled(Javax.Swing.Event.MenuEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuDeselected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        void MenuDeselected(Javax.Swing.Event.MenuEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuSelected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        void MenuSelected(Javax.Swing.Event.MenuEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MenuListener
    public partial class MenuListener : Javax.Swing.Event.IMenuListener
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
        /// Handlers initializer for <see cref="MenuListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("menuCanceled", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuEvent>>>(MenuCanceledEventHandler));
            AddEventHandler("menuDeselected", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuEvent>>>(MenuDeselectedEventHandler));
            AddEventHandler("menuSelected", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuEvent>>>(MenuSelectedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuCanceled(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuCanceled"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.MenuEvent> OnMenuCanceled { get; set; } = null;

        void MenuCanceledEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuEvent>> data)
        {
            var methodToExecute = (OnMenuCanceled != null) ? OnMenuCanceled : MenuCanceled;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuCanceled(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        public virtual void MenuCanceled(Javax.Swing.Event.MenuEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuDeselected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuDeselected"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.MenuEvent> OnMenuDeselected { get; set; } = null;

        void MenuDeselectedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuEvent>> data)
        {
            var methodToExecute = (OnMenuDeselected != null) ? OnMenuDeselected : MenuDeselected;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuDeselected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        public virtual void MenuDeselected(Javax.Swing.Event.MenuEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuSelected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuSelected"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.MenuEvent> OnMenuSelected { get; set; } = null;

        void MenuSelectedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuEvent>> data)
        {
            var methodToExecute = (OnMenuSelected != null) ? OnMenuSelected : MenuSelected;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuSelected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        public virtual void MenuSelected(Javax.Swing.Event.MenuEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MenuListenerDirect
    public partial class MenuListenerDirect : Javax.Swing.Event.IMenuListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuCanceled(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        public override void MenuCanceled(Javax.Swing.Event.MenuEvent arg0)
        {
            IExecuteWithSignature("menuCanceled", "(Ljavax/swing/event/MenuEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuDeselected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        public override void MenuDeselected(Javax.Swing.Event.MenuEvent arg0)
        {
            IExecuteWithSignature("menuDeselected", "(Ljavax/swing/event/MenuEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuSelected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        public override void MenuSelected(Javax.Swing.Event.MenuEvent arg0)
        {
            IExecuteWithSignature("menuSelected", "(Ljavax/swing/event/MenuEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}