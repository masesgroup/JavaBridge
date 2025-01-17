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

namespace Javax.Swing
{
    #region RepaintManager declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html"/>
    /// </summary>
    public partial class RepaintManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RepaintManager>
    {
        const string _bridgeClassName = "javax.swing.RepaintManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RepaintManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RepaintManager(params object[] args) : base(args) { }

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

    #region RepaintManager implementation
    public partial class RepaintManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#currentManager(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Javax.Swing.RepaintManager"/></returns>
        public static Javax.Swing.RepaintManager CurrentManager(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<Javax.Swing.RepaintManager>(LocalBridgeClazz, "currentManager", "(Ljava/awt/Component;)Ljavax/swing/RepaintManager;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#currentManager(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <returns><see cref="Javax.Swing.RepaintManager"/></returns>
        public static Javax.Swing.RepaintManager CurrentManager(Javax.Swing.JComponent arg0)
        {
            return SExecuteWithSignature<Javax.Swing.RepaintManager>(LocalBridgeClazz, "currentManager", "(Ljavax/swing/JComponent;)Ljavax/swing/RepaintManager;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#setCurrentManager(javax.swing.RepaintManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RepaintManager"/></param>
        public static void SetCurrentManager(Javax.Swing.RepaintManager arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setCurrentManager", "(Ljavax/swing/RepaintManager;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#getDoubleBufferMaximumSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#setDoubleBufferMaximumSize(java.awt.Dimension)"/>
        /// </summary>
        public Java.Awt.Dimension DoubleBufferMaximumSize
        {
            get { return IExecuteWithSignature<Java.Awt.Dimension>("getDoubleBufferMaximumSize", "()Ljava/awt/Dimension;"); } set { IExecuteWithSignature("setDoubleBufferMaximumSize", "(Ljava/awt/Dimension;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#isCompletelyDirty(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompletelyDirty(Javax.Swing.JComponent arg0)
        {
            return IExecuteWithSignature<bool>("isCompletelyDirty", "(Ljavax/swing/JComponent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#isDoubleBufferingEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDoubleBufferingEnabled()
        {
            return IExecuteWithSignature<bool>("isDoubleBufferingEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#getOffscreenBuffer(java.awt.Component,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image GetOffscreenBuffer(Java.Awt.Component arg0, int arg1, int arg2)
        {
            return IExecuteWithSignature<Java.Awt.Image>("getOffscreenBuffer", "(Ljava/awt/Component;II)Ljava/awt/Image;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#getVolatileOffscreenBuffer(java.awt.Component,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image GetVolatileOffscreenBuffer(Java.Awt.Component arg0, int arg1, int arg2)
        {
            return IExecuteWithSignature<Java.Awt.Image>("getVolatileOffscreenBuffer", "(Ljava/awt/Component;II)Ljava/awt/Image;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#getDirtyRegion(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public Java.Awt.Rectangle GetDirtyRegion(Javax.Swing.JComponent arg0)
        {
            return IExecuteWithSignature<Java.Awt.Rectangle>("getDirtyRegion", "(Ljavax/swing/JComponent;)Ljava/awt/Rectangle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#addInvalidComponent(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        public void AddInvalidComponent(Javax.Swing.JComponent arg0)
        {
            IExecuteWithSignature("addInvalidComponent", "(Ljavax/swing/JComponent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#removeInvalidComponent(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        public void RemoveInvalidComponent(Javax.Swing.JComponent arg0)
        {
            IExecuteWithSignature("removeInvalidComponent", "(Ljavax/swing/JComponent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#addDirtyRegion(java.awt.Window,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void AddDirtyRegion(Java.Awt.Window arg0, int arg1, int arg2, int arg3, int arg4)
        {
            IExecuteWithSignature("addDirtyRegion", "(Ljava/awt/Window;IIII)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#addDirtyRegion(javax.swing.JComponent,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void AddDirtyRegion(Javax.Swing.JComponent arg0, int arg1, int arg2, int arg3, int arg4)
        {
            IExecuteWithSignature("addDirtyRegion", "(Ljavax/swing/JComponent;IIII)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#markCompletelyClean(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        public void MarkCompletelyClean(Javax.Swing.JComponent arg0)
        {
            IExecuteWithSignature("markCompletelyClean", "(Ljavax/swing/JComponent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#markCompletelyDirty(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        public void MarkCompletelyDirty(Javax.Swing.JComponent arg0)
        {
            IExecuteWithSignature("markCompletelyDirty", "(Ljavax/swing/JComponent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#paintDirtyRegions()"/>
        /// </summary>
        public void PaintDirtyRegions()
        {
            IExecuteWithSignature("paintDirtyRegions", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#setDoubleBufferingEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDoubleBufferingEnabled(bool arg0)
        {
            IExecuteWithSignature("setDoubleBufferingEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RepaintManager.html#validateInvalidComponents()"/>
        /// </summary>
        public void ValidateInvalidComponents()
        {
            IExecuteWithSignature("validateInvalidComponents", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}