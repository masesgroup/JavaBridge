﻿/*
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

using MASES.JCOBridge.C2JBridge;
using System;

namespace Java.Beans
{
    /// <summary>
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyChangeListener.html"/>
    /// </summary>
    public interface IPropertyChangeListener : IJVMBridgeBase
    {
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyChangeListener.html#propertyChange(java.beans.PropertyChangeEvent)
        /// </summary>
        /// <param name="evt"><see cref="PropertyChangeEvent"/></param>
        void PropertyChange(PropertyChangeEvent evt);
    }

    /// <summary>
    /// Listener for PropertyChangeListener. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IPropertyChangeListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class PropertyChangeListener : IPropertyChangeListener
    {
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public sealed override string ClassName => "org.mases.jnet.beans.JNetPropertyChangeListener";

        readonly Action<PropertyChangeEvent> PropertyChangeFunction = null;
        /// <summary>
        /// The <see cref="Action{PropertyChangeEvent}"/> to be executed on PropertyChange
        /// </summary>
        public virtual Action<PropertyChangeEvent> OnPropertyChange { get { return PropertyChangeFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="PropertyChangeListener"/>
        /// </summary>
        /// <param name="propertyChange">The <see cref="Action{PropertyChangeEvent}"/> to be executed on PropertyChange</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public PropertyChangeListener(Action<PropertyChangeEvent> propertyChange = null, bool attachEventHandler = true)
        {
            if (propertyChange != null) PropertyChangeFunction = propertyChange;
            else PropertyChangeFunction = PropertyChange;

            if (attachEventHandler)
            {
                AddEventHandler("propertyChange", new EventHandler<CLRListenerEventArgs<CLREventData<PropertyChangeEvent>>>(EventHandlerPropertyChange));
            }
        }

        void EventHandlerPropertyChange(object sender, CLRListenerEventArgs<CLREventData<PropertyChangeEvent>> data)
        {
            OnPropertyChange(data.EventData.TypedEventData);
        }
        /// <inheritdoc cref="IPropertyChangeListener.PropertyChange(PropertyChangeEvent)"/>
        public virtual void PropertyChange(PropertyChangeEvent evt)
        {

        }
    }
}
