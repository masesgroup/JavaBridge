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

namespace Javax.Swing
{
    #region IButtonModel
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IButtonModel : Java.Awt.IItemSelectable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#getActionCommand()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setActionCommand(java.lang.String)"/>
        /// </summary>
        Java.Lang.String ActionCommand { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#getGroup()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setGroup(javax.swing.ButtonGroup)"/>
        /// </summary>
        Javax.Swing.ButtonGroup Group { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#getMnemonic()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setMnemonic(int)"/>
        /// </summary>
        int Mnemonic { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#isArmed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsArmed();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsEnabled();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#isPressed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsPressed();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#isRollover()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsRollover();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#isSelected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsSelected();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#addActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        void AddActionListener(Java.Awt.EventNs.ActionListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        void AddChangeListener(Javax.Swing.Event.ChangeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#addItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        void AddItemListener(Java.Awt.EventNs.ItemListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#removeActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        void RemoveActionListener(Java.Awt.EventNs.ActionListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#removeItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        void RemoveItemListener(Java.Awt.EventNs.ItemListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setArmed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetArmed(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetEnabled(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setPressed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetPressed(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setRollover(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetRollover(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setSelected(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetSelected(bool arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ButtonModel
    public partial class ButtonModel : Javax.Swing.IButtonModel
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#getActionCommand()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setActionCommand(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ActionCommand
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getActionCommand", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setActionCommand", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#getGroup()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setGroup(javax.swing.ButtonGroup)"/>
        /// </summary>
        public Javax.Swing.ButtonGroup Group
        {
            get { return IExecuteWithSignature<Javax.Swing.ButtonGroup>("getGroup", "()Ljavax/swing/ButtonGroup;"); } set { IExecuteWithSignature("setGroup", "(Ljavax/swing/ButtonGroup;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#getMnemonic()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setMnemonic(int)"/>
        /// </summary>
        public int Mnemonic
        {
            get { return IExecuteWithSignature<int>("getMnemonic", "()I"); } set { IExecuteWithSignature("setMnemonic", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#isArmed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsArmed()
        {
            return IExecuteWithSignature<bool>("isArmed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#isPressed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPressed()
        {
            return IExecuteWithSignature<bool>("isPressed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#isRollover()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRollover()
        {
            return IExecuteWithSignature<bool>("isRollover", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#isSelected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSelected()
        {
            return IExecuteWithSignature<bool>("isSelected", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#addActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void AddActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecuteWithSignature("addActionListener", "(Ljava/awt/event/ActionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("addChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#addItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        public void AddItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecuteWithSignature("addItemListener", "(Ljava/awt/event/ItemListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#removeActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void RemoveActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecuteWithSignature("removeActionListener", "(Ljava/awt/event/ActionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("removeChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#removeItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        public void RemoveItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecuteWithSignature("removeItemListener", "(Ljava/awt/event/ItemListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setArmed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetArmed(bool arg0)
        {
            IExecuteWithSignature("setArmed", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEnabled(bool arg0)
        {
            IExecuteWithSignature("setEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setPressed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPressed(bool arg0)
        {
            IExecuteWithSignature("setPressed", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setRollover(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRollover(bool arg0)
        {
            IExecuteWithSignature("setRollover", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/ButtonModel.html#setSelected(boolean)"/>
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