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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region AbstractButton
    public partial class AbstractButton
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.AbstractButton"/> to <see cref="Java.Awt.ItemSelectable"/>
        /// </summary>
        public static implicit operator Java.Awt.ItemSelectable(Javax.Swing.AbstractButton t) => t.Cast<Java.Awt.ItemSelectable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.AbstractButton"/> to <see cref="Javax.Swing.SwingConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.SwingConstants(Javax.Swing.AbstractButton t) => t.Cast<Javax.Swing.SwingConstants>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#BORDER_PAINTED_CHANGED_PROPERTY"/>
        /// </summary>
        public static string BORDER_PAINTED_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "BORDER_PAINTED_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#CONTENT_AREA_FILLED_CHANGED_PROPERTY"/>
        /// </summary>
        public static string CONTENT_AREA_FILLED_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "CONTENT_AREA_FILLED_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#DISABLED_ICON_CHANGED_PROPERTY"/>
        /// </summary>
        public static string DISABLED_ICON_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "DISABLED_ICON_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#DISABLED_SELECTED_ICON_CHANGED_PROPERTY"/>
        /// </summary>
        public static string DISABLED_SELECTED_ICON_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "DISABLED_SELECTED_ICON_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#FOCUS_PAINTED_CHANGED_PROPERTY"/>
        /// </summary>
        public static string FOCUS_PAINTED_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "FOCUS_PAINTED_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#HORIZONTAL_ALIGNMENT_CHANGED_PROPERTY"/>
        /// </summary>
        public static string HORIZONTAL_ALIGNMENT_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "HORIZONTAL_ALIGNMENT_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#HORIZONTAL_TEXT_POSITION_CHANGED_PROPERTY"/>
        /// </summary>
        public static string HORIZONTAL_TEXT_POSITION_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "HORIZONTAL_TEXT_POSITION_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#ICON_CHANGED_PROPERTY"/>
        /// </summary>
        public static string ICON_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "ICON_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#MARGIN_CHANGED_PROPERTY"/>
        /// </summary>
        public static string MARGIN_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "MARGIN_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#MNEMONIC_CHANGED_PROPERTY"/>
        /// </summary>
        public static string MNEMONIC_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "MNEMONIC_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#MODEL_CHANGED_PROPERTY"/>
        /// </summary>
        public static string MODEL_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "MODEL_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#PRESSED_ICON_CHANGED_PROPERTY"/>
        /// </summary>
        public static string PRESSED_ICON_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "PRESSED_ICON_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#ROLLOVER_ENABLED_CHANGED_PROPERTY"/>
        /// </summary>
        public static string ROLLOVER_ENABLED_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "ROLLOVER_ENABLED_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#ROLLOVER_ICON_CHANGED_PROPERTY"/>
        /// </summary>
        public static string ROLLOVER_ICON_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "ROLLOVER_ICON_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#ROLLOVER_SELECTED_ICON_CHANGED_PROPERTY"/>
        /// </summary>
        public static string ROLLOVER_SELECTED_ICON_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "ROLLOVER_SELECTED_ICON_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#SELECTED_ICON_CHANGED_PROPERTY"/>
        /// </summary>
        public static string SELECTED_ICON_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "SELECTED_ICON_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#TEXT_CHANGED_PROPERTY"/>
        /// </summary>
        public static string TEXT_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "TEXT_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#VERTICAL_ALIGNMENT_CHANGED_PROPERTY"/>
        /// </summary>
        public static string VERTICAL_ALIGNMENT_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "VERTICAL_ALIGNMENT_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#VERTICAL_TEXT_POSITION_CHANGED_PROPERTY"/>
        /// </summary>
        public static string VERTICAL_TEXT_POSITION_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "VERTICAL_TEXT_POSITION_CHANGED_PROPERTY"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getAction()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setAction(javax.swing.Action)"/>
        /// </summary>
        public Javax.Swing.Action Action
        {
            get { return IExecute<Javax.Swing.Action>("getAction"); } set { IExecute("setAction", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getActionCommand()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setActionCommand(java.lang.String)"/>
        /// </summary>
        public string ActionCommand
        {
            get { return IExecute<string>("getActionCommand"); } set { IExecute("setActionCommand", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getActionListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ActionListener[] ActionListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.ActionListener>("getActionListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getChangeListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ChangeListener[] ChangeListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.ChangeListener>("getChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getDisabledIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setDisabledIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon DisabledIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getDisabledIcon"); } set { IExecute("setDisabledIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getDisabledSelectedIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setDisabledSelectedIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon DisabledSelectedIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getDisabledSelectedIcon"); } set { IExecute("setDisabledSelectedIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getDisplayedMnemonicIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setDisplayedMnemonicIndex(int)"/>
        /// </summary>
        public int DisplayedMnemonicIndex
        {
            get { return IExecute<int>("getDisplayedMnemonicIndex"); } set { IExecute("setDisplayedMnemonicIndex", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getHideActionText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setHideActionText(boolean)"/>
        /// </summary>
        public bool HideActionText
        {
            get { return IExecute<bool>("getHideActionText"); } set { IExecute("setHideActionText", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getHorizontalAlignment()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setHorizontalAlignment(int)"/>
        /// </summary>
        public int HorizontalAlignment
        {
            get { return IExecute<int>("getHorizontalAlignment"); } set { IExecute("setHorizontalAlignment", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getHorizontalTextPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setHorizontalTextPosition(int)"/>
        /// </summary>
        public int HorizontalTextPosition
        {
            get { return IExecute<int>("getHorizontalTextPosition"); } set { IExecute("setHorizontalTextPosition", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon Icon
        {
            get { return IExecute<Javax.Swing.Icon>("getIcon"); } set { IExecute("setIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getIconTextGap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setIconTextGap(int)"/>
        /// </summary>
        public int IconTextGap
        {
            get { return IExecute<int>("getIconTextGap"); } set { IExecute("setIconTextGap", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getItemListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ItemListener[] ItemListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.ItemListener>("getItemListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getMargin()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setMargin(java.awt.Insets)"/>
        /// </summary>
        public Java.Awt.Insets Margin
        {
            get { return IExecute<Java.Awt.Insets>("getMargin"); } set { IExecute("setMargin", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getMnemonic()"/> 
        /// </summary>
        public int Mnemonic
        {
            get { return IExecute<int>("getMnemonic"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setModel(javax.swing.ButtonModel)"/>
        /// </summary>
        public Javax.Swing.ButtonModel Model
        {
            get { return IExecute<Javax.Swing.ButtonModel>("getModel"); } set { IExecute("setModel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getMultiClickThreshhold()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setMultiClickThreshhold(long)"/>
        /// </summary>
        public long MultiClickThreshhold
        {
            get { return IExecute<long>("getMultiClickThreshhold"); } set { IExecute("setMultiClickThreshhold", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getPressedIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setPressedIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon PressedIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getPressedIcon"); } set { IExecute("setPressedIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getRolloverIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setRolloverIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon RolloverIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getRolloverIcon"); } set { IExecute("setRolloverIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getRolloverSelectedIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setRolloverSelectedIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon RolloverSelectedIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getRolloverSelectedIcon"); } set { IExecute("setRolloverSelectedIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getSelectedIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setSelectedIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon SelectedIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getSelectedIcon"); } set { IExecute("setSelectedIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getSelectedObjects()"/> 
        /// </summary>
        public object[] SelectedObjects
        {
            get { return IExecuteArray<object>("getSelectedObjects"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setText(java.lang.String)"/>
        /// </summary>
        public string Text
        {
            get { return IExecute<string>("getText"); } set { IExecute("setText", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getVerticalAlignment()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setVerticalAlignment(int)"/>
        /// </summary>
        public int VerticalAlignment
        {
            get { return IExecute<int>("getVerticalAlignment"); } set { IExecute("setVerticalAlignment", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getVerticalTextPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setVerticalTextPosition(int)"/>
        /// </summary>
        public int VerticalTextPosition
        {
            get { return IExecute<int>("getVerticalTextPosition"); } set { IExecute("setVerticalTextPosition", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#isBorderPainted()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsBorderPainted()
        {
            return IExecute<bool>("isBorderPainted");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#isContentAreaFilled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsContentAreaFilled()
        {
            return IExecute<bool>("isContentAreaFilled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#isFocusPainted()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFocusPainted()
        {
            return IExecute<bool>("isFocusPainted");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#isRolloverEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsRolloverEnabled()
        {
            return IExecute<bool>("isRolloverEnabled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#isSelected()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSelected()
        {
            return IExecute<bool>("isSelected");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#addActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void AddActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("addActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("addChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#addItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        public void AddItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecute("addItemListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#doClick()"/>
        /// </summary>
        public void DoClick()
        {
            IExecute("doClick");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#doClick(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void DoClick(int arg0)
        {
            IExecute("doClick", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#removeActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void RemoveActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("removeActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("removeChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#removeItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        public void RemoveItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecute("removeItemListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setBorderPainted(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetBorderPainted(bool arg0)
        {
            IExecute("setBorderPainted", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setContentAreaFilled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetContentAreaFilled(bool arg0)
        {
            IExecute("setContentAreaFilled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setFocusPainted(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFocusPainted(bool arg0)
        {
            IExecute("setFocusPainted", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setMnemonic(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void SetMnemonic(char arg0)
        {
            IExecute("setMnemonic", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setMnemonic(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMnemonic(int arg0)
        {
            IExecute("setMnemonic", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setRolloverEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRolloverEnabled(bool arg0)
        {
            IExecute("setRolloverEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setSelected(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetSelected(bool arg0)
        {
            IExecute("setSelected", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setUI(javax.swing.plaf.ButtonUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.ButtonUI"/></param>
        public void SetUI(Javax.Swing.Plaf.ButtonUI arg0)
        {
            IExecute("setUI", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}