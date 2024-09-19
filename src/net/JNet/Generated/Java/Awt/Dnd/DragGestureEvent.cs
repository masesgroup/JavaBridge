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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Dnd
{
    #region DragGestureEvent declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureEvent.html"/>
    /// </summary>
    public partial class DragGestureEvent : Java.Util.EventObject
    {
        const string _bridgeClassName = "java.awt.dnd.DragGestureEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DragGestureEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DragGestureEvent(params object[] args) : base(args) { }

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

    #region DragGestureEvent implementation
    public partial class DragGestureEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureEvent.html#%3Cinit%3E(java.awt.dnd.DragGestureRecognizer,int,java.awt.Point,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragGestureRecognizer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Point"/></param>
        /// <param name="arg3"><see cref="Java.Util.List"/></param>
        public DragGestureEvent(Java.Awt.Dnd.DragGestureRecognizer arg0, int arg1, Java.Awt.Point arg2, Java.Util.List arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureEvent.html#getComponent()"/> 
        /// </summary>
        public Java.Awt.Component Component
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getComponent", "()Ljava/awt/Component;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureEvent.html#getDragAction()"/> 
        /// </summary>
        public int DragAction
        {
            get { return IExecuteWithSignature<int>("getDragAction", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureEvent.html#getDragOrigin()"/> 
        /// </summary>
        public Java.Awt.Point DragOrigin
        {
            get { return IExecuteWithSignature<Java.Awt.Point>("getDragOrigin", "()Ljava/awt/Point;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureEvent.html#getDragSource()"/> 
        /// </summary>
        public Java.Awt.Dnd.DragSource DragSource
        {
            get { return IExecuteWithSignature<Java.Awt.Dnd.DragSource>("getDragSource", "()Ljava/awt/dnd/DragSource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureEvent.html#getSourceAsDragGestureRecognizer()"/> 
        /// </summary>
        public Java.Awt.Dnd.DragGestureRecognizer SourceAsDragGestureRecognizer
        {
            get { return IExecuteWithSignature<Java.Awt.Dnd.DragGestureRecognizer>("getSourceAsDragGestureRecognizer", "()Ljava/awt/dnd/DragGestureRecognizer;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureEvent.html#getTriggerEvent()"/> 
        /// </summary>
        public Java.Awt.EventNs.InputEvent TriggerEvent
        {
            get { return IExecuteWithSignature<Java.Awt.EventNs.InputEvent>("getTriggerEvent", "()Ljava/awt/event/InputEvent;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureEvent.html#toArray()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray()
        {
            return IExecuteWithSignatureArray<object>("toArray", "()[Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureEvent.html#toArray(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray(object[] arg0)
        {
            return IExecuteWithSignatureArray<object>("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureEvent.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<Java.Awt.EventNs.InputEvent> Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<Java.Awt.EventNs.InputEvent>>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureEvent.html#startDrag(java.awt.Cursor,java.awt.datatransfer.Transferable,java.awt.dnd.DragSourceListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Cursor"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Dnd.DragSourceListener"/></param>
        /// <exception cref="Java.Awt.Dnd.InvalidDnDOperationException"/>
        public void StartDrag(Java.Awt.Cursor arg0, Java.Awt.Datatransfer.Transferable arg1, Java.Awt.Dnd.DragSourceListener arg2)
        {
            IExecute("startDrag", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureEvent.html#startDrag(java.awt.Cursor,java.awt.datatransfer.Transferable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Cursor"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        /// <exception cref="Java.Awt.Dnd.InvalidDnDOperationException"/>
        public void StartDrag(Java.Awt.Cursor arg0, Java.Awt.Datatransfer.Transferable arg1)
        {
            IExecute("startDrag", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureEvent.html#startDrag(java.awt.Cursor,java.awt.Image,java.awt.Point,java.awt.datatransfer.Transferable,java.awt.dnd.DragSourceListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Cursor"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Point"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Dnd.DragSourceListener"/></param>
        /// <exception cref="Java.Awt.Dnd.InvalidDnDOperationException"/>
        public void StartDrag(Java.Awt.Cursor arg0, Java.Awt.Image arg1, Java.Awt.Point arg2, Java.Awt.Datatransfer.Transferable arg3, Java.Awt.Dnd.DragSourceListener arg4)
        {
            IExecute("startDrag", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}