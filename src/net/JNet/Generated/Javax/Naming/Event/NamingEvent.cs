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

namespace Javax.Naming.Event
{
    #region NamingEvent
    public partial class NamingEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#%3Cinit%3E(javax.naming.event.EventContext,int,javax.naming.Binding,javax.naming.Binding,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.EventContext"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Binding"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Binding"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        public NamingEvent(Javax.Naming.Event.EventContext arg0, int arg1, Javax.Naming.Binding arg2, Javax.Naming.Binding arg3, object arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#OBJECT_ADDED"/>
        /// </summary>
        public static int OBJECT_ADDED { get { return SGetField<int>(LocalBridgeClazz, "OBJECT_ADDED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#OBJECT_CHANGED"/>
        /// </summary>
        public static int OBJECT_CHANGED { get { return SGetField<int>(LocalBridgeClazz, "OBJECT_CHANGED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#OBJECT_REMOVED"/>
        /// </summary>
        public static int OBJECT_REMOVED { get { return SGetField<int>(LocalBridgeClazz, "OBJECT_REMOVED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#OBJECT_RENAMED"/>
        /// </summary>
        public static int OBJECT_RENAMED { get { return SGetField<int>(LocalBridgeClazz, "OBJECT_RENAMED"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getChangeInfo()"/> 
        /// </summary>
        public object ChangeInfo
        {
            get { return IExecute("getChangeInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getEventContext()"/> 
        /// </summary>
        public Javax.Naming.Event.EventContext EventContext
        {
            get { return IExecute<Javax.Naming.Event.EventContext>("getEventContext"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getNewBinding()"/> 
        /// </summary>
        public Javax.Naming.Binding NewBinding
        {
            get { return IExecute<Javax.Naming.Binding>("getNewBinding"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getOldBinding()"/> 
        /// </summary>
        public Javax.Naming.Binding OldBinding
        {
            get { return IExecute<Javax.Naming.Binding>("getOldBinding"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecute<int>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#dispatch(javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingListener"/></param>
        public void Dispatch(Javax.Naming.Event.NamingListener arg0)
        {
            IExecute("dispatch", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}