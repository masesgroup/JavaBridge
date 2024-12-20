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
    #region ButtonGroup declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html"/>
    /// </summary>
    public partial class ButtonGroup : Java.Io.Serializable
    {
        const string _bridgeClassName = "javax.swing.ButtonGroup";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ButtonGroup() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ButtonGroup(params object[] args) : base(args) { }

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

    #region ButtonGroup implementation
    public partial class ButtonGroup
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#getButtonCount()"/> 
        /// </summary>
        public int ButtonCount
        {
            get { return IExecuteWithSignature<int>("getButtonCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#getElements()"/> 
        /// </summary>
        public Java.Util.Enumeration<Javax.Swing.AbstractButton> Elements
        {
            get { return IExecuteWithSignature<Java.Util.Enumeration<Javax.Swing.AbstractButton>>("getElements", "()Ljava/util/Enumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#getSelection()"/> 
        /// </summary>
        public Javax.Swing.ButtonModel Selection
        {
            get { return IExecuteWithSignature<Javax.Swing.ButtonModel>("getSelection", "()Ljavax/swing/ButtonModel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#isSelected(javax.swing.ButtonModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.ButtonModel"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSelected(Javax.Swing.ButtonModel arg0)
        {
            return IExecuteWithSignature<bool>("isSelected", "(Ljavax/swing/ButtonModel;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#add(javax.swing.AbstractButton)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.AbstractButton"/></param>
        public void Add(Javax.Swing.AbstractButton arg0)
        {
            IExecuteWithSignature("add", "(Ljavax/swing/AbstractButton;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#clearSelection()"/>
        /// </summary>
        public void ClearSelection()
        {
            IExecuteWithSignature("clearSelection", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#remove(javax.swing.AbstractButton)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.AbstractButton"/></param>
        public void Remove(Javax.Swing.AbstractButton arg0)
        {
            IExecuteWithSignature("remove", "(Ljavax/swing/AbstractButton;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonGroup.html#setSelected(javax.swing.ButtonModel,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.ButtonModel"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetSelected(Javax.Swing.ButtonModel arg0, bool arg1)
        {
            IExecuteWithSignature("setSelected", "(Ljavax/swing/ButtonModel;Z)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}