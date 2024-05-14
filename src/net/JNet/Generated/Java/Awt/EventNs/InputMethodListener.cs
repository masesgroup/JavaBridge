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

namespace Java.Awt.EventNs
{
    #region IInputMethodListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.InputMethodListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html"/>
    /// </summary>
    public partial interface IInputMethodListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html#caretPositionChanged(java.awt.event.InputMethodEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.InputMethodEvent"/></param>
        void CaretPositionChanged(Java.Awt.EventNs.InputMethodEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html#inputMethodTextChanged(java.awt.event.InputMethodEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.InputMethodEvent"/></param>
        void InputMethodTextChanged(Java.Awt.EventNs.InputMethodEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region InputMethodListener
    public partial class InputMethodListener : Java.Awt.EventNs.IInputMethodListener
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
        /// Handlers initializer for <see cref="InputMethodListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("caretPositionChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.InputMethodEvent>>>(CaretPositionChangedEventHandler));
            AddEventHandler("inputMethodTextChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.InputMethodEvent>>>(InputMethodTextChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html#caretPositionChanged(java.awt.event.InputMethodEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnCaretPositionChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.EventNs.InputMethodEvent> OnCaretPositionChanged { get; set; } = null;

        void CaretPositionChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.InputMethodEvent>> data)
        {
            var methodToExecute = (OnCaretPositionChanged != null) ? OnCaretPositionChanged : CaretPositionChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html#caretPositionChanged(java.awt.event.InputMethodEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.InputMethodEvent"/></param>
        public virtual void CaretPositionChanged(Java.Awt.EventNs.InputMethodEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html#inputMethodTextChanged(java.awt.event.InputMethodEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInputMethodTextChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.EventNs.InputMethodEvent> OnInputMethodTextChanged { get; set; } = null;

        void InputMethodTextChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.InputMethodEvent>> data)
        {
            var methodToExecute = (OnInputMethodTextChanged != null) ? OnInputMethodTextChanged : InputMethodTextChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodListener.html#inputMethodTextChanged(java.awt.event.InputMethodEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.InputMethodEvent"/></param>
        public virtual void InputMethodTextChanged(Java.Awt.EventNs.InputMethodEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}