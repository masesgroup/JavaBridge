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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Event
{
    #region INamingListener
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html"/>
    /// </summary>
    public partial interface INamingListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingExceptionEvent"/></param>
        void NamingExceptionThrown(Javax.Naming.Event.NamingExceptionEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NamingListener
    public partial class NamingListener : Javax.Naming.Event.INamingListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingExceptionEvent"/></param>
        public virtual void NamingExceptionThrown(Javax.Naming.Event.NamingExceptionEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}