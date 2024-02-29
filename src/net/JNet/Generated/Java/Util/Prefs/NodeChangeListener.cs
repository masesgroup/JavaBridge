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

namespace Java.Util.Prefs
{
    #region INodeChangeListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.prefs.NodeChangeListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html"/>
    /// </summary>
    public partial interface INodeChangeListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html#childAdded(java.util.prefs.NodeChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.NodeChangeEvent"/></param>
        void ChildAdded(Java.Util.Prefs.NodeChangeEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html#childRemoved(java.util.prefs.NodeChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.NodeChangeEvent"/></param>
        void ChildRemoved(Java.Util.Prefs.NodeChangeEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NodeChangeListener
    public partial class NodeChangeListener : Java.Util.Prefs.INodeChangeListener
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
        /// Handlers initializer for <see cref="NodeChangeListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("childAdded", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Prefs.NodeChangeEvent>>>(ChildAddedEventHandler));
            AddEventHandler("childRemoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Prefs.NodeChangeEvent>>>(ChildRemovedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html#childAdded(java.util.prefs.NodeChangeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnChildAdded"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Util.Prefs.NodeChangeEvent> OnChildAdded { get; set; } = null;

        void ChildAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Prefs.NodeChangeEvent>> data)
        {
            var methodToExecute = (OnChildAdded != null) ? OnChildAdded : ChildAdded;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html#childAdded(java.util.prefs.NodeChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.NodeChangeEvent"/></param>
        public virtual void ChildAdded(Java.Util.Prefs.NodeChangeEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html#childRemoved(java.util.prefs.NodeChangeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnChildRemoved"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Util.Prefs.NodeChangeEvent> OnChildRemoved { get; set; } = null;

        void ChildRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Prefs.NodeChangeEvent>> data)
        {
            var methodToExecute = (OnChildRemoved != null) ? OnChildRemoved : ChildRemoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html#childRemoved(java.util.prefs.NodeChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.NodeChangeEvent"/></param>
        public virtual void ChildRemoved(Java.Util.Prefs.NodeChangeEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}