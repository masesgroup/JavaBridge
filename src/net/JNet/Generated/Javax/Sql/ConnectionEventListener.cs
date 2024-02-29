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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql
{
    #region IConnectionEventListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.sql.ConnectionEventListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionEventListener.html"/>
    /// </summary>
    public partial interface IConnectionEventListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionEventListener.html#connectionClosed(javax.sql.ConnectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.ConnectionEvent"/></param>
        void ConnectionClosed(Javax.Sql.ConnectionEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionEventListener.html#connectionErrorOccurred(javax.sql.ConnectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.ConnectionEvent"/></param>
        void ConnectionErrorOccurred(Javax.Sql.ConnectionEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConnectionEventListener
    public partial class ConnectionEventListener : Javax.Sql.IConnectionEventListener
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
        /// Handlers initializer for <see cref="ConnectionEventListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("connectionClosed", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Sql.ConnectionEvent>>>(ConnectionClosedEventHandler));
            AddEventHandler("connectionErrorOccurred", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Sql.ConnectionEvent>>>(ConnectionErrorOccurredEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionEventListener.html#connectionClosed(javax.sql.ConnectionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnConnectionClosed"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Sql.ConnectionEvent> OnConnectionClosed { get; set; } = null;

        void ConnectionClosedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Sql.ConnectionEvent>> data)
        {
            var methodToExecute = (OnConnectionClosed != null) ? OnConnectionClosed : ConnectionClosed;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionEventListener.html#connectionClosed(javax.sql.ConnectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.ConnectionEvent"/></param>
        public virtual void ConnectionClosed(Javax.Sql.ConnectionEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionEventListener.html#connectionErrorOccurred(javax.sql.ConnectionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnConnectionErrorOccurred"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Sql.ConnectionEvent> OnConnectionErrorOccurred { get; set; } = null;

        void ConnectionErrorOccurredEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Sql.ConnectionEvent>> data)
        {
            var methodToExecute = (OnConnectionErrorOccurred != null) ? OnConnectionErrorOccurred : ConnectionErrorOccurred;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionEventListener.html#connectionErrorOccurred(javax.sql.ConnectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.ConnectionEvent"/></param>
        public virtual void ConnectionErrorOccurred(Javax.Sql.ConnectionEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}