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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Event
{
    #region EventContext
    public partial class EventContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Naming.Event.EventContext"/> to <see cref="Javax.Naming.Context"/>
        /// </summary>
        public static implicit operator Javax.Naming.Context(Javax.Naming.Event.EventContext t) => t.Cast<Javax.Naming.Context>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#OBJECT_SCOPE"/>
        /// </summary>
        public static int OBJECT_SCOPE => Clazz.GetField<int>("OBJECT_SCOPE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#ONELEVEL_SCOPE"/>
        /// </summary>
        public static int ONELEVEL_SCOPE => Clazz.GetField<int>("ONELEVEL_SCOPE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#SUBTREE_SCOPE"/>
        /// </summary>
        public static int SUBTREE_SCOPE => Clazz.GetField<int>("SUBTREE_SCOPE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#targetMustExist()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public bool TargetMustExist()
        {
            return IExecute<bool>("targetMustExist");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#addNamingListener(java.lang.String,int,javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void AddNamingListener(string arg0, int arg1, Javax.Naming.Event.NamingListener arg2)
        {
            IExecute("addNamingListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#addNamingListener(javax.naming.Name,int,javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void AddNamingListener(Javax.Naming.Name arg0, int arg1, Javax.Naming.Event.NamingListener arg2)
        {
            IExecute("addNamingListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#removeNamingListener(javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void RemoveNamingListener(Javax.Naming.Event.NamingListener arg0)
        {
            IExecute("removeNamingListener", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}