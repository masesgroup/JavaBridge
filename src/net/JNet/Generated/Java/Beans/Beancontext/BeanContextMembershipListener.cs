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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans.Beancontext
{
    #region IBeanContextMembershipListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.beans.beancontext.BeanContextMembershipListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextMembershipListener.html"/>
    /// </summary>
    public partial interface IBeanContextMembershipListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextMembershipListener.html#childrenAdded(java.beans.beancontext.BeanContextMembershipEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipEvent"/></param>
        void ChildrenAdded(Java.Beans.Beancontext.BeanContextMembershipEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextMembershipListener.html#childrenRemoved(java.beans.beancontext.BeanContextMembershipEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipEvent"/></param>
        void ChildrenRemoved(Java.Beans.Beancontext.BeanContextMembershipEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BeanContextMembershipListener
    public partial class BeanContextMembershipListener : Java.Beans.Beancontext.IBeanContextMembershipListener
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
        /// Handlers initializer for <see cref="BeanContextMembershipListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("childrenAdded", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Beans.Beancontext.BeanContextMembershipEvent>>>(ChildrenAddedEventHandler));
            AddEventHandler("childrenRemoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Beans.Beancontext.BeanContextMembershipEvent>>>(ChildrenRemovedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextMembershipListener.html#childrenAdded(java.beans.beancontext.BeanContextMembershipEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnChildrenAdded"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Beans.Beancontext.BeanContextMembershipEvent> OnChildrenAdded { get; set; } = null;

        void ChildrenAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Beans.Beancontext.BeanContextMembershipEvent>> data)
        {
            var methodToExecute = (OnChildrenAdded != null) ? OnChildrenAdded : ChildrenAdded;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextMembershipListener.html#childrenAdded(java.beans.beancontext.BeanContextMembershipEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipEvent"/></param>
        public virtual void ChildrenAdded(Java.Beans.Beancontext.BeanContextMembershipEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextMembershipListener.html#childrenRemoved(java.beans.beancontext.BeanContextMembershipEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnChildrenRemoved"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Beans.Beancontext.BeanContextMembershipEvent> OnChildrenRemoved { get; set; } = null;

        void ChildrenRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Beans.Beancontext.BeanContextMembershipEvent>> data)
        {
            var methodToExecute = (OnChildrenRemoved != null) ? OnChildrenRemoved : ChildrenRemoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextMembershipListener.html#childrenRemoved(java.beans.beancontext.BeanContextMembershipEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipEvent"/></param>
        public virtual void ChildrenRemoved(Java.Beans.Beancontext.BeanContextMembershipEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BeanContextMembershipListenerDirect
    public partial class BeanContextMembershipListenerDirect : Java.Beans.Beancontext.IBeanContextMembershipListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextMembershipListener.html#childrenAdded(java.beans.beancontext.BeanContextMembershipEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipEvent"/></param>
        public override void ChildrenAdded(Java.Beans.Beancontext.BeanContextMembershipEvent arg0)
        {
            IExecuteWithSignature("childrenAdded", "(Ljava/beans/beancontext/BeanContextMembershipEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextMembershipListener.html#childrenRemoved(java.beans.beancontext.BeanContextMembershipEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipEvent"/></param>
        public override void ChildrenRemoved(Java.Beans.Beancontext.BeanContextMembershipEvent arg0)
        {
            IExecuteWithSignature("childrenRemoved", "(Ljava/beans/beancontext/BeanContextMembershipEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}