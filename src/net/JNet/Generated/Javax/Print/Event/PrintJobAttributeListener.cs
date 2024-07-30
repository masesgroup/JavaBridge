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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Event
{
    #region IPrintJobAttributeListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.print.event.PrintJobAttributeListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAttributeListener.html"/>
    /// </summary>
    public partial interface IPrintJobAttributeListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAttributeListener.html#attributeUpdate(javax.print.event.PrintJobAttributeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobAttributeEvent"/></param>
        void AttributeUpdate(Javax.Print.Event.PrintJobAttributeEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PrintJobAttributeListener
    public partial class PrintJobAttributeListener : Javax.Print.Event.IPrintJobAttributeListener
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
        /// Handlers initializer for <see cref="PrintJobAttributeListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("attributeUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobAttributeEvent>>>(AttributeUpdateEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAttributeListener.html#attributeUpdate(javax.print.event.PrintJobAttributeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAttributeUpdate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Print.Event.PrintJobAttributeEvent> OnAttributeUpdate { get; set; } = null;

        void AttributeUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobAttributeEvent>> data)
        {
            var methodToExecute = (OnAttributeUpdate != null) ? OnAttributeUpdate : AttributeUpdate;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAttributeListener.html#attributeUpdate(javax.print.event.PrintJobAttributeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobAttributeEvent"/></param>
        public virtual void AttributeUpdate(Javax.Print.Event.PrintJobAttributeEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PrintJobAttributeListenerDirect
    public partial class PrintJobAttributeListenerDirect : Javax.Print.Event.IPrintJobAttributeListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAttributeListener.html#attributeUpdate(javax.print.event.PrintJobAttributeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobAttributeEvent"/></param>
        public override void AttributeUpdate(Javax.Print.Event.PrintJobAttributeEvent arg0)
        {
            IExecuteWithSignature("attributeUpdate", "(Ljavax/print/event/PrintJobAttributeEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}