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

namespace Javax.Swing.Event
{
    #region IHyperlinkListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.HyperlinkListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkListener.html"/>
    /// </summary>
    public partial interface IHyperlinkListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkListener.html#hyperlinkUpdate(javax.swing.event.HyperlinkEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.HyperlinkEvent"/></param>
        void HyperlinkUpdate(Javax.Swing.Event.HyperlinkEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HyperlinkListener
    public partial class HyperlinkListener : Javax.Swing.Event.IHyperlinkListener
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
        /// Handlers initializer for <see cref="HyperlinkListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("hyperlinkUpdate", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.HyperlinkEvent>>>(HyperlinkUpdateEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkListener.html#hyperlinkUpdate(javax.swing.event.HyperlinkEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnHyperlinkUpdate"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.HyperlinkEvent> OnHyperlinkUpdate { get; set; } = null;

        void HyperlinkUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.HyperlinkEvent>> data)
        {
            var methodToExecute = (OnHyperlinkUpdate != null) ? OnHyperlinkUpdate : HyperlinkUpdate;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/HyperlinkListener.html#hyperlinkUpdate(javax.swing.event.HyperlinkEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.HyperlinkEvent"/></param>
        public virtual void HyperlinkUpdate(Javax.Swing.Event.HyperlinkEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}