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

namespace Java.Awt.EventNs
{
    #region IMouseListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.MouseListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html"/>
    /// </summary>
    public partial interface IMouseListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseClicked(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        void MouseClicked(Java.Awt.EventNs.MouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseEntered(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        void MouseEntered(Java.Awt.EventNs.MouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseExited(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        void MouseExited(Java.Awt.EventNs.MouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mousePressed(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        void MousePressed(Java.Awt.EventNs.MouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseReleased(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        void MouseReleased(Java.Awt.EventNs.MouseEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MouseListener
    public partial class MouseListener : Java.Awt.EventNs.IMouseListener
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
        /// Handlers initializer for <see cref="MouseListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("mouseClicked", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseClickedEventHandler));
            AddEventHandler("mouseEntered", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseEnteredEventHandler));
            AddEventHandler("mouseExited", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseExitedEventHandler));
            AddEventHandler("mousePressed", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MousePressedEventHandler));
            AddEventHandler("mouseReleased", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseReleasedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseClicked(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseClicked"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseEvent> OnMouseClicked { get; set; } = null;

        void MouseClickedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            var methodToExecute = (OnMouseClicked != null) ? OnMouseClicked : MouseClicked;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseClicked(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseClicked(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseEntered(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseEntered"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseEvent> OnMouseEntered { get; set; } = null;

        void MouseEnteredEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            var methodToExecute = (OnMouseEntered != null) ? OnMouseEntered : MouseEntered;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseEntered(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseEntered(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseExited(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseExited"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseEvent> OnMouseExited { get; set; } = null;

        void MouseExitedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            var methodToExecute = (OnMouseExited != null) ? OnMouseExited : MouseExited;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseExited(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseExited(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mousePressed(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMousePressed"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseEvent> OnMousePressed { get; set; } = null;

        void MousePressedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            var methodToExecute = (OnMousePressed != null) ? OnMousePressed : MousePressed;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mousePressed(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MousePressed(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseReleased(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseReleased"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseEvent> OnMouseReleased { get; set; } = null;

        void MouseReleasedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            var methodToExecute = (OnMouseReleased != null) ? OnMouseReleased : MouseReleased;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseReleased(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseReleased(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MouseListenerDirect
    public partial class MouseListenerDirect : Java.Awt.EventNs.IMouseListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseClicked(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public override void MouseClicked(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("mouseClicked", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseEntered(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public override void MouseEntered(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("mouseEntered", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseExited(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public override void MouseExited(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("mouseExited", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mousePressed(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public override void MousePressed(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("mousePressed", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseReleased(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public override void MouseReleased(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("mouseReleased", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}