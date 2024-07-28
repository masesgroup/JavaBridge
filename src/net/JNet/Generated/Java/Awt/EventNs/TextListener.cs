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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region ITextListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.TextListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/TextListener.html"/>
    /// </summary>
    public partial interface ITextListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/TextListener.html#textValueChanged(java.awt.event.TextEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.TextEvent"/></param>
        void TextValueChanged(Java.Awt.EventNs.TextEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TextListener
    public partial class TextListener : Java.Awt.EventNs.ITextListener
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
        /// Handlers initializer for <see cref="TextListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("textValueChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.TextEvent>>>(TextValueChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/TextListener.html#textValueChanged(java.awt.event.TextEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTextValueChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.TextEvent> OnTextValueChanged { get; set; } = null;

        void TextValueChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.TextEvent>> data)
        {
            var methodToExecute = (OnTextValueChanged != null) ? OnTextValueChanged : TextValueChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/TextListener.html#textValueChanged(java.awt.event.TextEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.TextEvent"/></param>
        public virtual void TextValueChanged(Java.Awt.EventNs.TextEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TextListenerDirect
    public partial class TextListenerDirect : Java.Awt.EventNs.ITextListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/TextListener.html#textValueChanged(java.awt.event.TextEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.TextEvent"/></param>
        public override void TextValueChanged(Java.Awt.EventNs.TextEvent arg0)
        {
            IExecuteWithSignature("textValueChanged", "(Ljava/awt/event/TextEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}