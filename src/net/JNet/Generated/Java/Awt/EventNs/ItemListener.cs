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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region IItemListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.ItemListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemListener.html"/>
    /// </summary>
    public partial interface IItemListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemListener.html#itemStateChanged(java.awt.event.ItemEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemEvent"/></param>
        void ItemStateChanged(Java.Awt.EventNs.ItemEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ItemListener
    public partial class ItemListener : Java.Awt.EventNs.IItemListener
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
        /// Handlers initializer for <see cref="ItemListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("itemStateChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ItemEvent>>>(ItemStateChangedEventHandler)); OnItemStateChanged = ItemStateChanged;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemListener.html#itemStateChanged(java.awt.event.ItemEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.ItemEvent> OnItemStateChanged { get; set; }

        void ItemStateChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ItemEvent>> data)
        {
            if (OnItemStateChanged != null) OnItemStateChanged.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemListener.html#itemStateChanged(java.awt.event.ItemEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemEvent"/></param>
        public virtual void ItemStateChanged(Java.Awt.EventNs.ItemEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}