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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans
{
    #region IExceptionListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.beans.ExceptionListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/ExceptionListener.html"/>
    /// </summary>
    public partial interface IExceptionListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/ExceptionListener.html#exceptionThrown(java.lang.Exception)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Exception"/></param>
        void ExceptionThrown(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ExceptionListener
    public partial class ExceptionListener : Java.Beans.IExceptionListener
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
        /// Handlers initializer for <see cref="ExceptionListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("exceptionThrown", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(ExceptionThrownEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/ExceptionListener.html#exceptionThrown(java.lang.Exception)"/>
        /// </summary>
        /// <remarks>If <see cref="OnExceptionThrown"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<MASES.JCOBridge.C2JBridge.JVMBridgeException> OnExceptionThrown { get; set; } = null;

        void ExceptionThrownEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnExceptionThrown != null) ? OnExceptionThrown : ExceptionThrown;
            methodToExecute.Invoke(JVMBridgeException.New(data.EventData.EventData as MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/ExceptionListener.html#exceptionThrown(java.lang.Exception)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Exception"/></param>
        public virtual void ExceptionThrown(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ExceptionListenerDirect
    public partial class ExceptionListenerDirect : Java.Beans.IExceptionListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/ExceptionListener.html#exceptionThrown(java.lang.Exception)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Exception"/></param>
        public override void ExceptionThrown(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("exceptionThrown", "(Ljava/lang/Exception;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}