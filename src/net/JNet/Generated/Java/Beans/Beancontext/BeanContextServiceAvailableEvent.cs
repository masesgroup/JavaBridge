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

namespace Java.Beans.Beancontext
{
    #region BeanContextServiceAvailableEvent
    public partial class BeanContextServiceAvailableEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceAvailableEvent.html#%3Cinit%3E(java.beans.beancontext.BeanContextServices,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServices"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        public BeanContextServiceAvailableEvent(Java.Beans.Beancontext.BeanContextServices arg0, Java.Lang.Class arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceAvailableEvent.html#getCurrentServiceSelectors()"/> 
        /// </summary>
        public Java.Util.Iterator<object> CurrentServiceSelectors
        {
            get { return IExecute<Java.Util.Iterator<object>>("getCurrentServiceSelectors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceAvailableEvent.html#getServiceClass()"/> 
        /// </summary>
        public Java.Lang.Class ServiceClass
        {
            get { return IExecute<Java.Lang.Class>("getServiceClass"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceAvailableEvent.html#getSourceAsBeanContextServices()"/> 
        /// </summary>
        public Java.Beans.Beancontext.BeanContextServices SourceAsBeanContextServices
        {
            get { return IExecute<Java.Beans.Beancontext.BeanContextServices>("getSourceAsBeanContextServices"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}