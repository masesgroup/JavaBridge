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

namespace Javax.Swing.Plaf.Synth
{
    #region SynthOptionPaneUI declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthOptionPaneUI.html"/>
    /// </summary>
    public partial class SynthOptionPaneUI : Javax.Swing.Plaf.Basic.BasicOptionPaneUI
    {
        const string _bridgeClassName = "javax.swing.plaf.synth.SynthOptionPaneUI";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SynthOptionPaneUI() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SynthOptionPaneUI(params object[] args) : base(args) { }

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

    #region SynthOptionPaneUI implementation
    public partial class SynthOptionPaneUI
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.Synth.SynthOptionPaneUI"/> to <see cref="Java.Beans.PropertyChangeListener"/>
        /// </summary>
        public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Plaf.Synth.SynthOptionPaneUI t) => t.Cast<Java.Beans.PropertyChangeListener>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.Synth.SynthOptionPaneUI"/> to <see cref="Javax.Swing.Plaf.Synth.SynthUI"/>
        /// </summary>
        public static implicit operator Javax.Swing.Plaf.Synth.SynthUI(Javax.Swing.Plaf.Synth.SynthOptionPaneUI t) => t.Cast<Javax.Swing.Plaf.Synth.SynthUI>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthOptionPaneUI.html#getContext(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <returns><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></returns>
        public Javax.Swing.Plaf.Synth.SynthContext GetContext(Javax.Swing.JComponent arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Plaf.Synth.SynthContext>("getContext", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/synth/SynthContext;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthOptionPaneUI.html#paintBorder(javax.swing.plaf.synth.SynthContext,java.awt.Graphics,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public void PaintBorder(Javax.Swing.Plaf.Synth.SynthContext arg0, Java.Awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5)
        {
            IExecuteWithSignature("paintBorder", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;IIII)V", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthOptionPaneUI.html#propertyChange(java.beans.PropertyChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
        public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
        {
            IExecuteWithSignature("propertyChange", "(Ljava/beans/PropertyChangeEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}