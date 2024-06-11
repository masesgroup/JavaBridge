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

namespace Java.Awt.EventNs
{
    #region IMouseWheelListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.MouseWheelListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelListener.html"/>
    /// </summary>
    public partial interface IMouseWheelListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelListener.html#mouseWheelMoved(java.awt.event.MouseWheelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseWheelEvent"/></param>
        void MouseWheelMoved(Java.Awt.EventNs.MouseWheelEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MouseWheelListener
    public partial class MouseWheelListener : Java.Awt.EventNs.IMouseWheelListener
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
        /// Handlers initializer for <see cref="MouseWheelListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("mouseWheelMoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseWheelEvent>>>(MouseWheelMovedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelListener.html#mouseWheelMoved(java.awt.event.MouseWheelEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseWheelMoved"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseWheelEvent> OnMouseWheelMoved { get; set; } = null;

        void MouseWheelMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseWheelEvent>> data)
        {
            var methodToExecute = (OnMouseWheelMoved != null) ? OnMouseWheelMoved : MouseWheelMoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelListener.html#mouseWheelMoved(java.awt.event.MouseWheelEvent)"/>
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

    #region MouseWheelListenerDirect
    public partial class MouseWheelListenerDirect : Java.Awt.EventNs.IMouseWheelListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelListener.html#mouseWheelMoved(java.awt.event.MouseWheelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseWheelEvent"/></param>
        public override void MouseWheelMoved(Java.Awt.EventNs.MouseWheelEvent arg0)
        {
            IExecuteWithSignature("mouseWheelMoved", "(Ljava/awt/event/MouseWheelEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}