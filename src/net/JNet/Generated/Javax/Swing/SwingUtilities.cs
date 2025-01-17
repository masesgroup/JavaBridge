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
    #region SwingUtilities declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html"/>
    /// </summary>
    public partial class SwingUtilities : Javax.Swing.SwingConstants
    {
        const string _bridgeClassName = "javax.swing.SwingUtilities";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SwingUtilities() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SwingUtilities(params object[] args) : base(args) { }

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

    #region SwingUtilities implementation
    public partial class SwingUtilities
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#isDescendingFrom(java.awt.Component,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsDescendingFrom(Java.Awt.Component arg0, Java.Awt.Component arg1)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isDescendingFrom", "(Ljava/awt/Component;Ljava/awt/Component;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#isEventDispatchThread()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsEventDispatchThread()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isEventDispatchThread", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#isLeftMouseButton(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsLeftMouseButton(Java.Awt.EventNs.MouseEvent arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isLeftMouseButton", "(Ljava/awt/event/MouseEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#isMiddleMouseButton(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsMiddleMouseButton(Java.Awt.EventNs.MouseEvent arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isMiddleMouseButton", "(Ljava/awt/event/MouseEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#isRightMouseButton(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsRightMouseButton(Java.Awt.EventNs.MouseEvent arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isRightMouseButton", "(Ljava/awt/event/MouseEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#notifyAction(javax.swing.Action,javax.swing.KeyStroke,java.awt.event.KeyEvent,java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Action"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <param name="arg2"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool NotifyAction(Javax.Swing.Action arg0, Javax.Swing.KeyStroke arg1, Java.Awt.EventNs.KeyEvent arg2, object arg3, int arg4)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "notifyAction", "(Ljavax/swing/Action;Ljavax/swing/KeyStroke;Ljava/awt/event/KeyEvent;Ljava/lang/Object;I)Z", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#processKeyBindings(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ProcessKeyBindings(Java.Awt.EventNs.KeyEvent arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "processKeyBindings", "(Ljava/awt/event/KeyEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#isRectangleContainingRectangle(java.awt.Rectangle,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsRectangleContainingRectangle(Java.Awt.Rectangle arg0, Java.Awt.Rectangle arg1)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isRectangleContainingRectangle", "(Ljava/awt/Rectangle;Ljava/awt/Rectangle;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#computeStringWidth(java.awt.FontMetrics,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontMetrics"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int ComputeStringWidth(Java.Awt.FontMetrics arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "computeStringWidth", "(Ljava/awt/FontMetrics;Ljava/lang/String;)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getAccessibleChildrenCount(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetAccessibleChildrenCount(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getAccessibleChildrenCount", "(Ljava/awt/Component;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getAccessibleIndexInParent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetAccessibleIndexInParent(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getAccessibleIndexInParent", "(Ljava/awt/Component;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getDeepestComponentAt(java.awt.Component,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public static Java.Awt.Component GetDeepestComponentAt(Java.Awt.Component arg0, int arg1, int arg2)
        {
            return SExecuteWithSignature<Java.Awt.Component>(LocalBridgeClazz, "getDeepestComponentAt", "(Ljava/awt/Component;II)Ljava/awt/Component;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getRoot(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public static Java.Awt.Component GetRoot(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<Java.Awt.Component>(LocalBridgeClazz, "getRoot", "(Ljava/awt/Component;)Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getUnwrappedView(javax.swing.JViewport)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JViewport"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public static Java.Awt.Component GetUnwrappedView(Javax.Swing.JViewport arg0)
        {
            return SExecuteWithSignature<Java.Awt.Component>(LocalBridgeClazz, "getUnwrappedView", "(Ljavax/swing/JViewport;)Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getAncestorNamed(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Container"/></returns>
        public static Java.Awt.Container GetAncestorNamed(Java.Lang.String arg0, Java.Awt.Component arg1)
        {
            return SExecuteWithSignature<Java.Awt.Container>(LocalBridgeClazz, "getAncestorNamed", "(Ljava/lang/String;Ljava/awt/Component;)Ljava/awt/Container;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getAncestorOfClass(java.lang.Class,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Container"/></returns>
        public static Java.Awt.Container GetAncestorOfClass(Java.Lang.Class arg0, Java.Awt.Component arg1)
        {
            return SExecuteWithSignature<Java.Awt.Container>(LocalBridgeClazz, "getAncestorOfClass", "(Ljava/lang/Class;Ljava/awt/Component;)Ljava/awt/Container;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getUnwrappedParent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Container"/></returns>
        public static Java.Awt.Container GetUnwrappedParent(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<Java.Awt.Container>(LocalBridgeClazz, "getUnwrappedParent", "(Ljava/awt/Component;)Ljava/awt/Container;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#convertMouseEvent(java.awt.Component,java.awt.event.MouseEvent,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.EventNs.MouseEvent"/></returns>
        public static Java.Awt.EventNs.MouseEvent ConvertMouseEvent(Java.Awt.Component arg0, Java.Awt.EventNs.MouseEvent arg1, Java.Awt.Component arg2)
        {
            return SExecuteWithSignature<Java.Awt.EventNs.MouseEvent>(LocalBridgeClazz, "convertMouseEvent", "(Ljava/awt/Component;Ljava/awt/event/MouseEvent;Ljava/awt/Component;)Ljava/awt/event/MouseEvent;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#convertPoint(java.awt.Component,int,int,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Point"/></returns>
        public static Java.Awt.Point ConvertPoint(Java.Awt.Component arg0, int arg1, int arg2, Java.Awt.Component arg3)
        {
            return SExecuteWithSignature<Java.Awt.Point>(LocalBridgeClazz, "convertPoint", "(Ljava/awt/Component;IILjava/awt/Component;)Ljava/awt/Point;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#convertPoint(java.awt.Component,java.awt.Point,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Point"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Point"/></returns>
        public static Java.Awt.Point ConvertPoint(Java.Awt.Component arg0, Java.Awt.Point arg1, Java.Awt.Component arg2)
        {
            return SExecuteWithSignature<Java.Awt.Point>(LocalBridgeClazz, "convertPoint", "(Ljava/awt/Component;Ljava/awt/Point;Ljava/awt/Component;)Ljava/awt/Point;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#calculateInnerArea(javax.swing.JComponent,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public static Java.Awt.Rectangle CalculateInnerArea(Javax.Swing.JComponent arg0, Java.Awt.Rectangle arg1)
        {
            return SExecuteWithSignature<Java.Awt.Rectangle>(LocalBridgeClazz, "calculateInnerArea", "(Ljavax/swing/JComponent;Ljava/awt/Rectangle;)Ljava/awt/Rectangle;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#computeIntersection(int,int,int,int,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public static Java.Awt.Rectangle ComputeIntersection(int arg0, int arg1, int arg2, int arg3, Java.Awt.Rectangle arg4)
        {
            return SExecuteWithSignature<Java.Awt.Rectangle>(LocalBridgeClazz, "computeIntersection", "(IIIILjava/awt/Rectangle;)Ljava/awt/Rectangle;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#computeUnion(int,int,int,int,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public static Java.Awt.Rectangle ComputeUnion(int arg0, int arg1, int arg2, int arg3, Java.Awt.Rectangle arg4)
        {
            return SExecuteWithSignature<Java.Awt.Rectangle>(LocalBridgeClazz, "computeUnion", "(IIIILjava/awt/Rectangle;)Ljava/awt/Rectangle;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#convertRectangle(java.awt.Component,java.awt.Rectangle,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public static Java.Awt.Rectangle ConvertRectangle(Java.Awt.Component arg0, Java.Awt.Rectangle arg1, Java.Awt.Component arg2)
        {
            return SExecuteWithSignature<Java.Awt.Rectangle>(LocalBridgeClazz, "convertRectangle", "(Ljava/awt/Component;Ljava/awt/Rectangle;Ljava/awt/Component;)Ljava/awt/Rectangle;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getLocalBounds(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public static Java.Awt.Rectangle GetLocalBounds(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<Java.Awt.Rectangle>(LocalBridgeClazz, "getLocalBounds", "(Ljava/awt/Component;)Ljava/awt/Rectangle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#computeDifference(java.awt.Rectangle,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public static Java.Awt.Rectangle[] ComputeDifference(Java.Awt.Rectangle arg0, Java.Awt.Rectangle arg1)
        {
            return SExecuteWithSignatureArray<Java.Awt.Rectangle>(LocalBridgeClazz, "computeDifference", "(Ljava/awt/Rectangle;Ljava/awt/Rectangle;)[Ljava/awt/Rectangle;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getWindowAncestor(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Window"/></returns>
        public static Java.Awt.Window GetWindowAncestor(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<Java.Awt.Window>(LocalBridgeClazz, "getWindowAncestor", "(Ljava/awt/Component;)Ljava/awt/Window;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#windowForComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Window"/></returns>
        public static Java.Awt.Window WindowForComponent(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<Java.Awt.Window>(LocalBridgeClazz, "windowForComponent", "(Ljava/awt/Component;)Ljava/awt/Window;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#layoutCompoundLabel(java.awt.FontMetrics,java.lang.String,javax.swing.Icon,int,int,int,int,java.awt.Rectangle,java.awt.Rectangle,java.awt.Rectangle,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontMetrics"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg8"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg9"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg10"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String LayoutCompoundLabel(Java.Awt.FontMetrics arg0, Java.Lang.String arg1, Javax.Swing.Icon arg2, int arg3, int arg4, int arg5, int arg6, Java.Awt.Rectangle arg7, Java.Awt.Rectangle arg8, Java.Awt.Rectangle arg9, int arg10)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "layoutCompoundLabel", "(Ljava/awt/FontMetrics;Ljava/lang/String;Ljavax/swing/Icon;IIIILjava/awt/Rectangle;Ljava/awt/Rectangle;Ljava/awt/Rectangle;I)Ljava/lang/String;", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#layoutCompoundLabel(javax.swing.JComponent,java.awt.FontMetrics,java.lang.String,javax.swing.Icon,int,int,int,int,java.awt.Rectangle,java.awt.Rectangle,java.awt.Rectangle,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontMetrics"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg9"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg10"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg11"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String LayoutCompoundLabel(Javax.Swing.JComponent arg0, Java.Awt.FontMetrics arg1, Java.Lang.String arg2, Javax.Swing.Icon arg3, int arg4, int arg5, int arg6, int arg7, Java.Awt.Rectangle arg8, Java.Awt.Rectangle arg9, Java.Awt.Rectangle arg10, int arg11)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "layoutCompoundLabel", "(Ljavax/swing/JComponent;Ljava/awt/FontMetrics;Ljava/lang/String;Ljavax/swing/Icon;IIIILjava/awt/Rectangle;Ljava/awt/Rectangle;Ljava/awt/Rectangle;I)Ljava/lang/String;", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getAccessibleAt(java.awt.Component,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Javax.Accessibility.Accessible"/></returns>
        public static Javax.Accessibility.Accessible GetAccessibleAt(Java.Awt.Component arg0, Java.Awt.Point arg1)
        {
            return SExecuteWithSignature<Javax.Accessibility.Accessible>(LocalBridgeClazz, "getAccessibleAt", "(Ljava/awt/Component;Ljava/awt/Point;)Ljavax/accessibility/Accessible;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getAccessibleChild(java.awt.Component,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Accessibility.Accessible"/></returns>
        public static Javax.Accessibility.Accessible GetAccessibleChild(Java.Awt.Component arg0, int arg1)
        {
            return SExecuteWithSignature<Javax.Accessibility.Accessible>(LocalBridgeClazz, "getAccessibleChild", "(Ljava/awt/Component;I)Ljavax/accessibility/Accessible;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getAccessibleStateSet(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Javax.Accessibility.AccessibleStateSet"/></returns>
        public static Javax.Accessibility.AccessibleStateSet GetAccessibleStateSet(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<Javax.Accessibility.AccessibleStateSet>(LocalBridgeClazz, "getAccessibleStateSet", "(Ljava/awt/Component;)Ljavax/accessibility/AccessibleStateSet;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getUIActionMap(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <returns><see cref="Javax.Swing.ActionMap"/></returns>
        public static Javax.Swing.ActionMap GetUIActionMap(Javax.Swing.JComponent arg0)
        {
            return SExecuteWithSignature<Javax.Swing.ActionMap>(LocalBridgeClazz, "getUIActionMap", "(Ljavax/swing/JComponent;)Ljavax/swing/ActionMap;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getUIInputMap(javax.swing.JComponent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.InputMap"/></returns>
        public static Javax.Swing.InputMap GetUIInputMap(Javax.Swing.JComponent arg0, int arg1)
        {
            return SExecuteWithSignature<Javax.Swing.InputMap>(LocalBridgeClazz, "getUIInputMap", "(Ljavax/swing/JComponent;I)Ljavax/swing/InputMap;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#getRootPane(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Javax.Swing.JRootPane"/></returns>
        public static Javax.Swing.JRootPane GetRootPane(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<Javax.Swing.JRootPane>(LocalBridgeClazz, "getRootPane", "(Ljava/awt/Component;)Ljavax/swing/JRootPane;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#convertPointFromScreen(java.awt.Point,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Point"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public static void ConvertPointFromScreen(Java.Awt.Point arg0, Java.Awt.Component arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "convertPointFromScreen", "(Ljava/awt/Point;Ljava/awt/Component;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#convertPointToScreen(java.awt.Point,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Point"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public static void ConvertPointToScreen(Java.Awt.Point arg0, Java.Awt.Component arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "convertPointToScreen", "(Ljava/awt/Point;Ljava/awt/Component;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#invokeAndWait(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Lang.Reflect.InvocationTargetException"/>
        public static void InvokeAndWait(Java.Lang.Runnable arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "invokeAndWait", "(Ljava/lang/Runnable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#invokeLater(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        public static void InvokeLater(Java.Lang.Runnable arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "invokeLater", "(Ljava/lang/Runnable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#paintComponent(java.awt.Graphics,java.awt.Component,java.awt.Container,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        public static void PaintComponent(Java.Awt.Graphics arg0, Java.Awt.Component arg1, Java.Awt.Container arg2, int arg3, int arg4, int arg5, int arg6)
        {
            SExecuteWithSignature(LocalBridgeClazz, "paintComponent", "(Ljava/awt/Graphics;Ljava/awt/Component;Ljava/awt/Container;IIII)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#paintComponent(java.awt.Graphics,java.awt.Component,java.awt.Container,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Rectangle"/></param>
        public static void PaintComponent(Java.Awt.Graphics arg0, Java.Awt.Component arg1, Java.Awt.Container arg2, Java.Awt.Rectangle arg3)
        {
            SExecuteWithSignature(LocalBridgeClazz, "paintComponent", "(Ljava/awt/Graphics;Ljava/awt/Component;Ljava/awt/Container;Ljava/awt/Rectangle;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#replaceUIActionMap(javax.swing.JComponent,javax.swing.ActionMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.ActionMap"/></param>
        public static void ReplaceUIActionMap(Javax.Swing.JComponent arg0, Javax.Swing.ActionMap arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "replaceUIActionMap", "(Ljavax/swing/JComponent;Ljavax/swing/ActionMap;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#replaceUIInputMap(javax.swing.JComponent,int,javax.swing.InputMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.InputMap"/></param>
        public static void ReplaceUIInputMap(Javax.Swing.JComponent arg0, int arg1, Javax.Swing.InputMap arg2)
        {
            SExecuteWithSignature(LocalBridgeClazz, "replaceUIInputMap", "(Ljavax/swing/JComponent;ILjavax/swing/InputMap;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingUtilities.html#updateComponentTreeUI(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public static void UpdateComponentTreeUI(Java.Awt.Component arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "updateComponentTreeUI", "(Ljava/awt/Component;)V", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}