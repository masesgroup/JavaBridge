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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region MouseMotionAdapter
    public partial class MouseMotionAdapter
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
        /// Handlers initializer for <see cref="MouseMotionAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("mouseDragged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseDraggedEventHandler));
            AddEventHandler("mouseMoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseMovedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionAdapter.html#mouseDragged(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseDragged"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.EventNs.MouseEvent> OnMouseDragged { get; set; } = null;

        void MouseDraggedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            var methodToExecute = (OnMouseDragged != null) ? OnMouseDragged : MouseDragged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionAdapter.html#mouseDragged(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseDragged(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionAdapter.html#mouseMoved(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseMoved"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.EventNs.MouseEvent> OnMouseMoved { get; set; } = null;

        void MouseMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            var methodToExecute = (OnMouseMoved != null) ? OnMouseMoved : MouseMoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionAdapter.html#mouseMoved(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseMoved(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}