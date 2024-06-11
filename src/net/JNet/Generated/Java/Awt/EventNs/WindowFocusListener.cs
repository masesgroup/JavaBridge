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
    #region IWindowFocusListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.WindowFocusListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowFocusListener.html"/>
    /// </summary>
    public partial interface IWindowFocusListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowFocusListener.html#windowGainedFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowGainedFocus(Java.Awt.EventNs.WindowEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowFocusListener.html#windowLostFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowLostFocus(Java.Awt.EventNs.WindowEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WindowFocusListener
    public partial class WindowFocusListener : Java.Awt.EventNs.IWindowFocusListener
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
        /// Handlers initializer for <see cref="WindowFocusListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("windowGainedFocus", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowGainedFocusEventHandler));
            AddEventHandler("windowLostFocus", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowLostFocusEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowFocusListener.html#windowGainedFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowGainedFocus"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowGainedFocus { get; set; } = null;

        void WindowGainedFocusEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            var methodToExecute = (OnWindowGainedFocus != null) ? OnWindowGainedFocus : WindowGainedFocus;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowFocusListener.html#windowGainedFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowGainedFocus(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowFocusListener.html#windowLostFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWindowLostFocus"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.WindowEvent> OnWindowLostFocus { get; set; } = null;

        void WindowLostFocusEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            var methodToExecute = (OnWindowLostFocus != null) ? OnWindowLostFocus : WindowLostFocus;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowFocusListener.html#windowLostFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowLostFocus(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WindowFocusListenerDirect
    public partial class WindowFocusListenerDirect : Java.Awt.EventNs.IWindowFocusListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowFocusListener.html#windowGainedFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowGainedFocus(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowGainedFocus", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowFocusListener.html#windowLostFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public override void WindowLostFocus(Java.Awt.EventNs.WindowEvent arg0)
        {
            IExecuteWithSignature("windowLostFocus", "(Ljava/awt/event/WindowEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}