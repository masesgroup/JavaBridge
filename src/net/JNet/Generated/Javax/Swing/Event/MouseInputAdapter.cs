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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Event
{
    #region MouseInputAdapter
    public partial class MouseInputAdapter
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
        /// Handlers initializer for <see cref="MouseInputAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("mouseClicked", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseClickedEventHandler)); OnMouseClicked = MouseClicked;
            AddEventHandler("mouseDragged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseDraggedEventHandler)); OnMouseDragged = MouseDragged;
            AddEventHandler("mouseEntered", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseEnteredEventHandler)); OnMouseEntered = MouseEntered;
            AddEventHandler("mouseExited", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseExitedEventHandler)); OnMouseExited = MouseExited;
            AddEventHandler("mouseMoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseMovedEventHandler)); OnMouseMoved = MouseMoved;
            AddEventHandler("mousePressed", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MousePressedEventHandler)); OnMousePressed = MousePressed;
            AddEventHandler("mouseReleased", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseReleasedEventHandler)); OnMouseReleased = MouseReleased;
            AddEventHandler("mouseWheelMoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseWheelEvent>>>(MouseWheelMovedEventHandler)); OnMouseWheelMoved = MouseWheelMoved;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseClicked(java.awt.event.MouseEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.MouseEvent> OnMouseClicked { get; set; }

        void MouseClickedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            if (OnMouseClicked != null) OnMouseClicked.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseClicked(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseClicked(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseDragged(java.awt.event.MouseEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.MouseEvent> OnMouseDragged { get; set; }

        void MouseDraggedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            if (OnMouseDragged != null) OnMouseDragged.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseDragged(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseDragged(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseEntered(java.awt.event.MouseEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.MouseEvent> OnMouseEntered { get; set; }

        void MouseEnteredEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            if (OnMouseEntered != null) OnMouseEntered.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseEntered(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseEntered(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseExited(java.awt.event.MouseEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.MouseEvent> OnMouseExited { get; set; }

        void MouseExitedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            if (OnMouseExited != null) OnMouseExited.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseExited(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseExited(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseMoved(java.awt.event.MouseEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.MouseEvent> OnMouseMoved { get; set; }

        void MouseMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            if (OnMouseMoved != null) OnMouseMoved.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseMoved(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseMoved(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mousePressed(java.awt.event.MouseEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.MouseEvent> OnMousePressed { get; set; }

        void MousePressedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            if (OnMousePressed != null) OnMousePressed.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mousePressed(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MousePressed(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseReleased(java.awt.event.MouseEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.MouseEvent> OnMouseReleased { get; set; }

        void MouseReleasedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            if (OnMouseReleased != null) OnMouseReleased.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseReleased(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseReleased(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseWheelMoved(java.awt.event.MouseWheelEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.MouseWheelEvent> OnMouseWheelMoved { get; set; }

        void MouseWheelMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseWheelEvent>> data)
        {
            if (OnMouseWheelMoved != null) OnMouseWheelMoved.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseWheelMoved(java.awt.event.MouseWheelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseWheelEvent"/></param>
        public virtual void MouseWheelMoved(Java.Awt.EventNs.MouseWheelEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}