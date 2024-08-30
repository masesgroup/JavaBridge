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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region DefaultButtonModel definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html"/>
    /// </summary>
    public partial class DefaultButtonModel : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DefaultButtonModel>
    {
        const string _bridgeClassName = "javax.swing.DefaultButtonModel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DefaultButtonModel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DefaultButtonModel(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region DefaultButtonModel
    public partial class DefaultButtonModel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultButtonModel"/> to <see cref="Javax.Swing.ButtonModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.ButtonModel(Javax.Swing.DefaultButtonModel t) => t.Cast<Javax.Swing.ButtonModel>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultButtonModel"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.DefaultButtonModel t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#ARMED"/>
        /// </summary>
        public static int ARMED { get { if (!_ARMEDReady) { _ARMEDContent = SGetField<int>(LocalBridgeClazz, "ARMED"); _ARMEDReady = true; } return _ARMEDContent; } }
        private static int _ARMEDContent = default;
        private static bool _ARMEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#ENABLED"/>
        /// </summary>
        public static int ENABLED { get { if (!_ENABLEDReady) { _ENABLEDContent = SGetField<int>(LocalBridgeClazz, "ENABLED"); _ENABLEDReady = true; } return _ENABLEDContent; } }
        private static int _ENABLEDContent = default;
        private static bool _ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#PRESSED"/>
        /// </summary>
        public static int PRESSED { get { if (!_PRESSEDReady) { _PRESSEDContent = SGetField<int>(LocalBridgeClazz, "PRESSED"); _PRESSEDReady = true; } return _PRESSEDContent; } }
        private static int _PRESSEDContent = default;
        private static bool _PRESSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#ROLLOVER"/>
        /// </summary>
        public static int ROLLOVER { get { if (!_ROLLOVERReady) { _ROLLOVERContent = SGetField<int>(LocalBridgeClazz, "ROLLOVER"); _ROLLOVERReady = true; } return _ROLLOVERContent; } }
        private static int _ROLLOVERContent = default;
        private static bool _ROLLOVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#SELECTED"/>
        /// </summary>
        public static int SELECTED { get { if (!_SELECTEDReady) { _SELECTEDContent = SGetField<int>(LocalBridgeClazz, "SELECTED"); _SELECTEDReady = true; } return _SELECTEDContent; } }
        private static int _SELECTEDContent = default;
        private static bool _SELECTEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getActionCommand()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setActionCommand(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ActionCommand
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getActionCommand", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setActionCommand", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getActionListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ActionListener[] ActionListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.ActionListener>("getActionListeners", "()[Ljava/awt/event/ActionListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getChangeListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ChangeListener[] ChangeListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.ChangeListener>("getChangeListeners", "()[Ljavax/swing/event/ChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getGroup()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setGroup(javax.swing.ButtonGroup)"/>
        /// </summary>
        public Javax.Swing.ButtonGroup Group
        {
            get { return IExecuteWithSignature<Javax.Swing.ButtonGroup>("getGroup", "()Ljavax/swing/ButtonGroup;"); } set { IExecuteWithSignature("setGroup", "(Ljavax/swing/ButtonGroup;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getItemListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ItemListener[] ItemListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.ItemListener>("getItemListeners", "()[Ljava/awt/event/ItemListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getMnemonic()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setMnemonic(int)"/>
        /// </summary>
        public int Mnemonic
        {
            get { return IExecuteWithSignature<int>("getMnemonic", "()I"); } set { IExecuteWithSignature("setMnemonic", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getSelectedObjects()"/> 
        /// </summary>
        public object[] SelectedObjects
        {
            get { return IExecuteWithSignatureArray<object>("getSelectedObjects", "()[Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#getListeners(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Util.IEventListener"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetListeners<T>(Java.Lang.Class arg0) where T : Java.Util.IEventListener, new()
        {
            return IExecuteArray<T>("getListeners", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#isArmed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsArmed()
        {
            return IExecuteWithSignature<bool>("isArmed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#isPressed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPressed()
        {
            return IExecuteWithSignature<bool>("isPressed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#isRollover()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRollover()
        {
            return IExecuteWithSignature<bool>("isRollover", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#isSelected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSelected()
        {
            return IExecuteWithSignature<bool>("isSelected", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#addActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void AddActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecuteWithSignature("addActionListener", "(Ljava/awt/event/ActionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("addChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#addItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        public void AddItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecuteWithSignature("addItemListener", "(Ljava/awt/event/ItemListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#removeActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void RemoveActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecuteWithSignature("removeActionListener", "(Ljava/awt/event/ActionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("removeChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#removeItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        public void RemoveItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecuteWithSignature("removeItemListener", "(Ljava/awt/event/ItemListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setArmed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetArmed(bool arg0)
        {
            IExecuteWithSignature("setArmed", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEnabled(bool arg0)
        {
            IExecuteWithSignature("setEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setPressed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPressed(bool arg0)
        {
            IExecuteWithSignature("setPressed", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setRollover(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRollover(bool arg0)
        {
            IExecuteWithSignature("setRollover", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultButtonModel.html#setSelected(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetSelected(bool arg0)
        {
            IExecuteWithSignature("setSelected", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}