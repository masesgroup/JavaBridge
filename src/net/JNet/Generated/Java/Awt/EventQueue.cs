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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region EventQueue declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/EventQueue.html"/>
    /// </summary>
    public partial class EventQueue : MASES.JCOBridge.C2JBridge.JVMBridgeBase<EventQueue>
    {
        const string _bridgeClassName = "java.awt.EventQueue";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EventQueue() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public EventQueue(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region EventQueue implementation
    public partial class EventQueue
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/EventQueue.html#getCurrentEvent()"/> 
        /// </summary>
        public static Java.Awt.AWTEvent CurrentEvent
        {
            get { return SExecuteWithSignature<Java.Awt.AWTEvent>(LocalBridgeClazz, "getCurrentEvent", "()Ljava/awt/AWTEvent;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/EventQueue.html#getMostRecentEventTime()"/> 
        /// </summary>
        public static long MostRecentEventTime
        {
            get { return SExecuteWithSignature<long>(LocalBridgeClazz, "getMostRecentEventTime", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/EventQueue.html#isDispatchThread()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsDispatchThread()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isDispatchThread", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/EventQueue.html#invokeAndWait(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Lang.Reflect.InvocationTargetException"/>
        public static void InvokeAndWait(Java.Lang.Runnable arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "invokeAndWait", "(Ljava/lang/Runnable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/EventQueue.html#invokeLater(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        public static void InvokeLater(Java.Lang.Runnable arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "invokeLater", "(Ljava/lang/Runnable;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/EventQueue.html#getNextEvent()"/> 
        /// </summary>
        public Java.Awt.AWTEvent NextEvent
        {
            get { return IExecuteWithSignature<Java.Awt.AWTEvent>("getNextEvent", "()Ljava/awt/AWTEvent;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/EventQueue.html#peekEvent()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.AWTEvent"/></returns>
        public Java.Awt.AWTEvent PeekEvent()
        {
            return IExecuteWithSignature<Java.Awt.AWTEvent>("peekEvent", "()Ljava/awt/AWTEvent;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/EventQueue.html#peekEvent(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.AWTEvent"/></returns>
        public Java.Awt.AWTEvent PeekEvent(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.AWTEvent>("peekEvent", "(I)Ljava/awt/AWTEvent;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/EventQueue.html#createSecondaryLoop()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.SecondaryLoop"/></returns>
        public Java.Awt.SecondaryLoop CreateSecondaryLoop()
        {
            return IExecuteWithSignature<Java.Awt.SecondaryLoop>("createSecondaryLoop", "()Ljava/awt/SecondaryLoop;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/EventQueue.html#postEvent(java.awt.AWTEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.AWTEvent"/></param>
        public void PostEvent(Java.Awt.AWTEvent arg0)
        {
            IExecuteWithSignature("postEvent", "(Ljava/awt/AWTEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/EventQueue.html#push(java.awt.EventQueue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventQueue"/></param>
        public void Push(Java.Awt.EventQueue arg0)
        {
            IExecuteWithSignature("push", "(Ljava/awt/EventQueue;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}