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

namespace Javax.Swing.Event
{
    #region IListDataListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.ListDataListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html"/>
    /// </summary>
    public partial interface IListDataListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#contentsChanged(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        void ContentsChanged(Javax.Swing.Event.ListDataEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#intervalAdded(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        void IntervalAdded(Javax.Swing.Event.ListDataEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#intervalRemoved(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        void IntervalRemoved(Javax.Swing.Event.ListDataEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ListDataListener
    public partial class ListDataListener : Javax.Swing.Event.IListDataListener
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
        /// Handlers initializer for <see cref="ListDataListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("contentsChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ListDataEvent>>>(ContentsChangedEventHandler)); OnContentsChanged = ContentsChanged;
            AddEventHandler("intervalAdded", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ListDataEvent>>>(IntervalAddedEventHandler)); OnIntervalAdded = IntervalAdded;
            AddEventHandler("intervalRemoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ListDataEvent>>>(IntervalRemovedEventHandler)); OnIntervalRemoved = IntervalRemoved;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#contentsChanged(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        public System.Action<Javax.Swing.Event.ListDataEvent> OnContentsChanged { get; set; }

        void ContentsChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ListDataEvent>> data)
        {
            if (OnContentsChanged != null) OnContentsChanged.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#contentsChanged(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        public virtual void ContentsChanged(Javax.Swing.Event.ListDataEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#intervalAdded(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        public System.Action<Javax.Swing.Event.ListDataEvent> OnIntervalAdded { get; set; }

        void IntervalAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ListDataEvent>> data)
        {
            if (OnIntervalAdded != null) OnIntervalAdded.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#intervalAdded(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        public virtual void IntervalAdded(Javax.Swing.Event.ListDataEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#intervalRemoved(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        public System.Action<Javax.Swing.Event.ListDataEvent> OnIntervalRemoved { get; set; }

        void IntervalRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ListDataEvent>> data)
        {
            if (OnIntervalRemoved != null) OnIntervalRemoved.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataListener.html#intervalRemoved(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        public virtual void IntervalRemoved(Javax.Swing.Event.ListDataEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}