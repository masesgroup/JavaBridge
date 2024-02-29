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

namespace Java.Beans.Beancontext
{
    #region BeanContextServicesSupport
    public partial class BeanContextServicesSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#%3Cinit%3E(java.beans.beancontext.BeanContextServices,java.util.Locale,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServices"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public BeanContextServicesSupport(Java.Beans.Beancontext.BeanContextServices arg0, Java.Util.Locale arg1, bool arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#%3Cinit%3E(java.beans.beancontext.BeanContextServices,java.util.Locale,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServices"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public BeanContextServicesSupport(Java.Beans.Beancontext.BeanContextServices arg0, Java.Util.Locale arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#%3Cinit%3E(java.beans.beancontext.BeanContextServices,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServices"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        public BeanContextServicesSupport(Java.Beans.Beancontext.BeanContextServices arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#%3Cinit%3E(java.beans.beancontext.BeanContextServices)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServices"/></param>
        public BeanContextServicesSupport(Java.Beans.Beancontext.BeanContextServices arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContextServicesSupport"/> to <see cref="Java.Beans.Beancontext.BeanContextServices"/>
        /// </summary>
        public static implicit operator Java.Beans.Beancontext.BeanContextServices(Java.Beans.Beancontext.BeanContextServicesSupport t) => t.Cast<Java.Beans.Beancontext.BeanContextServices>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#getBeanContextServicesPeer()"/> 
        /// </summary>
        public Java.Beans.Beancontext.BeanContextServices BeanContextServicesPeer
        {
            get { return IExecuteWithSignature<Java.Beans.Beancontext.BeanContextServices>("getBeanContextServicesPeer", "()Ljava/beans/beancontext/BeanContextServices;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#getCurrentServiceClasses()"/> 
        /// </summary>
        public Java.Util.Iterator<object> CurrentServiceClasses
        {
            get { return IExecuteWithSignature<Java.Util.Iterator<object>>("getCurrentServiceClasses", "()Ljava/util/Iterator;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#addService(java.lang.Class,java.beans.beancontext.BeanContextServiceProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextServiceProvider"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddService(Java.Lang.Class arg0, Java.Beans.Beancontext.BeanContextServiceProvider arg1)
        {
            return IExecute<bool>("addService", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#getService(java.beans.beancontext.BeanContextChild,java.lang.Object,java.lang.Class,java.lang.Object,java.beans.beancontext.BeanContextServiceRevokedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Java.Beans.Beancontext.BeanContextServiceRevokedListener"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Util.TooManyListenersException"/>
        public object GetService(Java.Beans.Beancontext.BeanContextChild arg0, object arg1, Java.Lang.Class arg2, object arg3, Java.Beans.Beancontext.BeanContextServiceRevokedListener arg4)
        {
            return IExecute("getService", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#getCurrentServiceSelectors(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<object> GetCurrentServiceSelectors(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<Java.Util.Iterator<object>>("getCurrentServiceSelectors", "(Ljava/lang/Class;)Ljava/util/Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#hasService(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasService(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<bool>("hasService", "(Ljava/lang/Class;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#addBeanContextServicesListener(java.beans.beancontext.BeanContextServicesListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServicesListener"/></param>
        public void AddBeanContextServicesListener(Java.Beans.Beancontext.BeanContextServicesListener arg0)
        {
            IExecuteWithSignature("addBeanContextServicesListener", "(Ljava/beans/beancontext/BeanContextServicesListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#initialize()"/>
        /// </summary>
        public void Initialize()
        {
            IExecuteWithSignature("initialize", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#releaseService(java.beans.beancontext.BeanContextChild,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void ReleaseService(Java.Beans.Beancontext.BeanContextChild arg0, object arg1, object arg2)
        {
            IExecute("releaseService", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#removeBeanContextServicesListener(java.beans.beancontext.BeanContextServicesListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServicesListener"/></param>
        public void RemoveBeanContextServicesListener(Java.Beans.Beancontext.BeanContextServicesListener arg0)
        {
            IExecuteWithSignature("removeBeanContextServicesListener", "(Ljava/beans/beancontext/BeanContextServicesListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesSupport.html#revokeService(java.lang.Class,java.beans.beancontext.BeanContextServiceProvider,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextServiceProvider"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void RevokeService(Java.Lang.Class arg0, Java.Beans.Beancontext.BeanContextServiceProvider arg1, bool arg2)
        {
            IExecute("revokeService", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}