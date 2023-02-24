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

namespace Java.Awt.EventNs
{
    /// <summary>
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentListener.html"/>
    /// </summary>
    public interface IAdjustmentListener : IJVMBridgeBase
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentListener.html#adjustmentValueChanged(java.awt.event.AdjustmentEvent)"/>
        /// </summary>
        void AdjustmentValueChanged(AdjustmentEvent e);
    }

    /// <summary>
    /// Listener for AdjustmentListener. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IAdjustmentListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class AdjustmentListener : IAdjustmentListener
    {
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public sealed override string ClassName => "org.mases.jnet.awt.event.JNetAdjustmentListener";

        readonly Action<AdjustmentEvent> adjustmentValueChangedFunction = null;
        /// <summary>
        /// The <see cref="Action{AdjustmentEvent}"/> to be executed on AdjustmentValueChanged
        /// </summary>
        public virtual Action<AdjustmentEvent> OnAdjustmentValueChanged { get { return adjustmentValueChangedFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="AdjustmentListener"/>
        /// </summary>
        /// <param name="actionPerformed">The <see cref="Action{AdjustmentEvent}"/> to be executed on AdjustmentValueChanged</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public AdjustmentListener(Action<AdjustmentEvent> actionPerformed = null, bool attachEventHandler = true)
        {
            if (actionPerformed != null) adjustmentValueChangedFunction = actionPerformed;
            else adjustmentValueChangedFunction = AdjustmentValueChanged;

            if (attachEventHandler)
            {
                AddEventHandler("adjustmentValueChanged", new EventHandler<CLRListenerEventArgs<CLREventData<AdjustmentEvent>>>(EventHandlerAdjustmentValueChanged));
            }
        }

        void EventHandlerAdjustmentValueChanged(object sender, CLRListenerEventArgs<CLREventData<AdjustmentEvent>> data)
        {
            OnAdjustmentValueChanged(data.EventData.TypedEventData);
        }
        /// <inheritdoc cref="IAdjustmentListener.AdjustmentValueChanged(AdjustmentEvent)"/>
        public virtual void AdjustmentValueChanged(AdjustmentEvent e)
        {

        }
    }
}
