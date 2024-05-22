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

namespace Java.Awt.Dnd
{
    #region DragSource
    public partial class DragSource
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#DefaultCopyDrop"/>
        /// </summary>
        public static Java.Awt.Cursor DefaultCopyDrop { get { if (!_DefaultCopyDropReady) { _DefaultCopyDropContent = SGetField<Java.Awt.Cursor>(LocalBridgeClazz, "DefaultCopyDrop"); _DefaultCopyDropReady = true; } return _DefaultCopyDropContent; } }
        private static Java.Awt.Cursor _DefaultCopyDropContent = default;
        private static bool _DefaultCopyDropReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#DefaultCopyNoDrop"/>
        /// </summary>
        public static Java.Awt.Cursor DefaultCopyNoDrop { get { if (!_DefaultCopyNoDropReady) { _DefaultCopyNoDropContent = SGetField<Java.Awt.Cursor>(LocalBridgeClazz, "DefaultCopyNoDrop"); _DefaultCopyNoDropReady = true; } return _DefaultCopyNoDropContent; } }
        private static Java.Awt.Cursor _DefaultCopyNoDropContent = default;
        private static bool _DefaultCopyNoDropReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#DefaultLinkDrop"/>
        /// </summary>
        public static Java.Awt.Cursor DefaultLinkDrop { get { if (!_DefaultLinkDropReady) { _DefaultLinkDropContent = SGetField<Java.Awt.Cursor>(LocalBridgeClazz, "DefaultLinkDrop"); _DefaultLinkDropReady = true; } return _DefaultLinkDropContent; } }
        private static Java.Awt.Cursor _DefaultLinkDropContent = default;
        private static bool _DefaultLinkDropReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#DefaultLinkNoDrop"/>
        /// </summary>
        public static Java.Awt.Cursor DefaultLinkNoDrop { get { if (!_DefaultLinkNoDropReady) { _DefaultLinkNoDropContent = SGetField<Java.Awt.Cursor>(LocalBridgeClazz, "DefaultLinkNoDrop"); _DefaultLinkNoDropReady = true; } return _DefaultLinkNoDropContent; } }
        private static Java.Awt.Cursor _DefaultLinkNoDropContent = default;
        private static bool _DefaultLinkNoDropReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#DefaultMoveDrop"/>
        /// </summary>
        public static Java.Awt.Cursor DefaultMoveDrop { get { if (!_DefaultMoveDropReady) { _DefaultMoveDropContent = SGetField<Java.Awt.Cursor>(LocalBridgeClazz, "DefaultMoveDrop"); _DefaultMoveDropReady = true; } return _DefaultMoveDropContent; } }
        private static Java.Awt.Cursor _DefaultMoveDropContent = default;
        private static bool _DefaultMoveDropReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#DefaultMoveNoDrop"/>
        /// </summary>
        public static Java.Awt.Cursor DefaultMoveNoDrop { get { if (!_DefaultMoveNoDropReady) { _DefaultMoveNoDropContent = SGetField<Java.Awt.Cursor>(LocalBridgeClazz, "DefaultMoveNoDrop"); _DefaultMoveNoDropReady = true; } return _DefaultMoveNoDropContent; } }
        private static Java.Awt.Cursor _DefaultMoveNoDropContent = default;
        private static bool _DefaultMoveNoDropReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#getDefaultDragSource()"/> 
        /// </summary>
        public static Java.Awt.Dnd.DragSource DefaultDragSource
        {
            get { return SExecuteWithSignature<Java.Awt.Dnd.DragSource>(LocalBridgeClazz, "getDefaultDragSource", "()Ljava/awt/dnd/DragSource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#getDragThreshold()"/> 
        /// </summary>
        public static int DragThreshold
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getDragThreshold", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#isDragImageSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsDragImageSupported()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isDragImageSupported", "()Z");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#getDragSourceListeners()"/> 
        /// </summary>
        public Java.Awt.Dnd.DragSourceListener[] DragSourceListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.Dnd.DragSourceListener>("getDragSourceListeners", "()[Ljava/awt/dnd/DragSourceListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#getDragSourceMotionListeners()"/> 
        /// </summary>
        public Java.Awt.Dnd.DragSourceMotionListener[] DragSourceMotionListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.Dnd.DragSourceMotionListener>("getDragSourceMotionListeners", "()[Ljava/awt/dnd/DragSourceMotionListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#getFlavorMap()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.FlavorMap FlavorMap
        {
            get { return IExecuteWithSignature<Java.Awt.Datatransfer.FlavorMap>("getFlavorMap", "()Ljava/awt/datatransfer/FlavorMap;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#createDragGestureRecognizer(java.lang.Class,java.awt.Component,int,java.awt.dnd.DragGestureListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Dnd.DragGestureListener"/></param>
        /// <typeparam name="T"><see cref="Java.Awt.Dnd.DragGestureRecognizer"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T CreateDragGestureRecognizer<T>(Java.Lang.Class arg0, Java.Awt.Component arg1, int arg2, Java.Awt.Dnd.DragGestureListener arg3) where T: Java.Awt.Dnd.DragGestureRecognizer
        {
            return IExecute<T>("createDragGestureRecognizer", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#createDefaultDragGestureRecognizer(java.awt.Component,int,java.awt.dnd.DragGestureListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Dnd.DragGestureListener"/></param>
        /// <returns><see cref="Java.Awt.Dnd.DragGestureRecognizer"/></returns>
        public Java.Awt.Dnd.DragGestureRecognizer CreateDefaultDragGestureRecognizer(Java.Awt.Component arg0, int arg1, Java.Awt.Dnd.DragGestureListener arg2)
        {
            return IExecute<Java.Awt.Dnd.DragGestureRecognizer>("createDefaultDragGestureRecognizer", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#addDragSourceListener(java.awt.dnd.DragSourceListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragSourceListener"/></param>
        public void AddDragSourceListener(Java.Awt.Dnd.DragSourceListener arg0)
        {
            IExecuteWithSignature("addDragSourceListener", "(Ljava/awt/dnd/DragSourceListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#addDragSourceMotionListener(java.awt.dnd.DragSourceMotionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragSourceMotionListener"/></param>
        public void AddDragSourceMotionListener(Java.Awt.Dnd.DragSourceMotionListener arg0)
        {
            IExecuteWithSignature("addDragSourceMotionListener", "(Ljava/awt/dnd/DragSourceMotionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#removeDragSourceListener(java.awt.dnd.DragSourceListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragSourceListener"/></param>
        public void RemoveDragSourceListener(Java.Awt.Dnd.DragSourceListener arg0)
        {
            IExecuteWithSignature("removeDragSourceListener", "(Ljava/awt/dnd/DragSourceListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#removeDragSourceMotionListener(java.awt.dnd.DragSourceMotionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragSourceMotionListener"/></param>
        public void RemoveDragSourceMotionListener(Java.Awt.Dnd.DragSourceMotionListener arg0)
        {
            IExecuteWithSignature("removeDragSourceMotionListener", "(Ljava/awt/dnd/DragSourceMotionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#startDrag(java.awt.dnd.DragGestureEvent,java.awt.Cursor,java.awt.datatransfer.Transferable,java.awt.dnd.DragSourceListener,java.awt.datatransfer.FlavorMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragGestureEvent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Cursor"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Dnd.DragSourceListener"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Datatransfer.FlavorMap"/></param>
        /// <exception cref="Java.Awt.Dnd.InvalidDnDOperationException"/>
        public void StartDrag(Java.Awt.Dnd.DragGestureEvent arg0, Java.Awt.Cursor arg1, Java.Awt.Datatransfer.Transferable arg2, Java.Awt.Dnd.DragSourceListener arg3, Java.Awt.Datatransfer.FlavorMap arg4)
        {
            IExecute("startDrag", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#startDrag(java.awt.dnd.DragGestureEvent,java.awt.Cursor,java.awt.datatransfer.Transferable,java.awt.dnd.DragSourceListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragGestureEvent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Cursor"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Dnd.DragSourceListener"/></param>
        /// <exception cref="Java.Awt.Dnd.InvalidDnDOperationException"/>
        public void StartDrag(Java.Awt.Dnd.DragGestureEvent arg0, Java.Awt.Cursor arg1, Java.Awt.Datatransfer.Transferable arg2, Java.Awt.Dnd.DragSourceListener arg3)
        {
            IExecute("startDrag", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#startDrag(java.awt.dnd.DragGestureEvent,java.awt.Cursor,java.awt.Image,java.awt.Point,java.awt.datatransfer.Transferable,java.awt.dnd.DragSourceListener,java.awt.datatransfer.FlavorMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragGestureEvent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Cursor"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Point"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Dnd.DragSourceListener"/></param>
        /// <param name="arg6"><see cref="Java.Awt.Datatransfer.FlavorMap"/></param>
        /// <exception cref="Java.Awt.Dnd.InvalidDnDOperationException"/>
        public void StartDrag(Java.Awt.Dnd.DragGestureEvent arg0, Java.Awt.Cursor arg1, Java.Awt.Image arg2, Java.Awt.Point arg3, Java.Awt.Datatransfer.Transferable arg4, Java.Awt.Dnd.DragSourceListener arg5, Java.Awt.Datatransfer.FlavorMap arg6)
        {
            IExecute("startDrag", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#startDrag(java.awt.dnd.DragGestureEvent,java.awt.Cursor,java.awt.Image,java.awt.Point,java.awt.datatransfer.Transferable,java.awt.dnd.DragSourceListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragGestureEvent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Cursor"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Point"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Dnd.DragSourceListener"/></param>
        /// <exception cref="Java.Awt.Dnd.InvalidDnDOperationException"/>
        public void StartDrag(Java.Awt.Dnd.DragGestureEvent arg0, Java.Awt.Cursor arg1, Java.Awt.Image arg2, Java.Awt.Point arg3, Java.Awt.Datatransfer.Transferable arg4, Java.Awt.Dnd.DragSourceListener arg5)
        {
            IExecute("startDrag", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}