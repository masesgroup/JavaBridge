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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region InvocationEvent
    public partial class InvocationEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InvocationEvent.html#%3Cinit%3E(java.lang.Object,java.lang.Runnable,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public InvocationEvent(object arg0, Java.Lang.Runnable arg1, object arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InvocationEvent.html#%3Cinit%3E(java.lang.Object,java.lang.Runnable,java.lang.Runnable,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public InvocationEvent(object arg0, Java.Lang.Runnable arg1, Java.Lang.Runnable arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InvocationEvent.html#%3Cinit%3E(java.lang.Object,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        public InvocationEvent(object arg0, Java.Lang.Runnable arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.EventNs.InvocationEvent"/> to <see cref="Java.Awt.ActiveEvent"/>
        /// </summary>
        public static implicit operator Java.Awt.ActiveEvent(Java.Awt.EventNs.InvocationEvent t) => t.Cast<Java.Awt.ActiveEvent>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InvocationEvent.html#INVOCATION_DEFAULT"/>
        /// </summary>
        public static int INVOCATION_DEFAULT { get { return SGetField<int>(LocalBridgeClazz, "INVOCATION_DEFAULT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InvocationEvent.html#INVOCATION_FIRST"/>
        /// </summary>
        public static int INVOCATION_FIRST { get { return SGetField<int>(LocalBridgeClazz, "INVOCATION_FIRST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InvocationEvent.html#INVOCATION_LAST"/>
        /// </summary>
        public static int INVOCATION_LAST { get { return SGetField<int>(LocalBridgeClazz, "INVOCATION_LAST"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InvocationEvent.html#getException()"/> 
        /// </summary>
        public Java.Lang.Exception Exception
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getException"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Lang.Exception>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InvocationEvent.html#getThrowable()"/> 
        /// </summary>
        public Java.Lang.Throwable Throwable
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getThrowable"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Lang.Throwable>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InvocationEvent.html#getWhen()"/> 
        /// </summary>
        public long When
        {
            get { return IExecute<long>("getWhen"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InvocationEvent.html#isDispatched()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDispatched()
        {
            return IExecute<bool>("isDispatched");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InvocationEvent.html#dispatch()"/>
        /// </summary>
        public void Dispatch()
        {
            IExecute("dispatch");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}