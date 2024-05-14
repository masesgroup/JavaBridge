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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans.Beancontext
{
    #region IBeanContextChild
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBeanContextChild
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChild.html#getBeanContext()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChild.html#setBeanContext(java.beans.beancontext.BeanContext)"/>
        /// </summary>
        Java.Beans.Beancontext.BeanContext BeanContext { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChild.html#addPropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        void AddPropertyChangeListener(Java.Lang.String arg0, Java.Beans.PropertyChangeListener arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChild.html#addVetoableChangeListener(java.lang.String,java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.VetoableChangeListener"/></param>
        void AddVetoableChangeListener(Java.Lang.String arg0, Java.Beans.VetoableChangeListener arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChild.html#removePropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        void RemovePropertyChangeListener(Java.Lang.String arg0, Java.Beans.PropertyChangeListener arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChild.html#removeVetoableChangeListener(java.lang.String,java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.VetoableChangeListener"/></param>
        void RemoveVetoableChangeListener(Java.Lang.String arg0, Java.Beans.VetoableChangeListener arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BeanContextChild
    public partial class BeanContextChild : Java.Beans.Beancontext.IBeanContextChild
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChild.html#getBeanContext()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChild.html#setBeanContext(java.beans.beancontext.BeanContext)"/>
        /// </summary>
        public Java.Beans.Beancontext.BeanContext BeanContext
        {
            get { return IExecuteWithSignature<Java.Beans.Beancontext.BeanContext>("getBeanContext", "()Ljava/beans/beancontext/BeanContext;"); } set { IExecuteWithSignature("setBeanContext", "(Ljava/beans/beancontext/BeanContext;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChild.html#addPropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Lang.String arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("addPropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChild.html#addVetoableChangeListener(java.lang.String,java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void AddVetoableChangeListener(Java.Lang.String arg0, Java.Beans.VetoableChangeListener arg1)
        {
            IExecute("addVetoableChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChild.html#removePropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Lang.String arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("removePropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChild.html#removeVetoableChangeListener(java.lang.String,java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void RemoveVetoableChangeListener(Java.Lang.String arg0, Java.Beans.VetoableChangeListener arg1)
        {
            IExecute("removeVetoableChangeListener", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}