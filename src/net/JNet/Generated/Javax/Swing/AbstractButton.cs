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
        public static Java.Lang.String BORDER_PAINTED_CHANGED_PROPERTY { get { if (!_BORDER_PAINTED_CHANGED_PROPERTYReady) { _BORDER_PAINTED_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "BORDER_PAINTED_CHANGED_PROPERTY"); _BORDER_PAINTED_CHANGED_PROPERTYReady = true; } return _BORDER_PAINTED_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _BORDER_PAINTED_CHANGED_PROPERTYContent = default;
        private static bool _BORDER_PAINTED_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#CONTENT_AREA_FILLED_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String CONTENT_AREA_FILLED_CHANGED_PROPERTY { get { if (!_CONTENT_AREA_FILLED_CHANGED_PROPERTYReady) { _CONTENT_AREA_FILLED_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONTENT_AREA_FILLED_CHANGED_PROPERTY"); _CONTENT_AREA_FILLED_CHANGED_PROPERTYReady = true; } return _CONTENT_AREA_FILLED_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _CONTENT_AREA_FILLED_CHANGED_PROPERTYContent = default;
        private static bool _CONTENT_AREA_FILLED_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#DISABLED_ICON_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String DISABLED_ICON_CHANGED_PROPERTY { get { if (!_DISABLED_ICON_CHANGED_PROPERTYReady) { _DISABLED_ICON_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DISABLED_ICON_CHANGED_PROPERTY"); _DISABLED_ICON_CHANGED_PROPERTYReady = true; } return _DISABLED_ICON_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _DISABLED_ICON_CHANGED_PROPERTYContent = default;
        private static bool _DISABLED_ICON_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#DISABLED_SELECTED_ICON_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String DISABLED_SELECTED_ICON_CHANGED_PROPERTY { get { if (!_DISABLED_SELECTED_ICON_CHANGED_PROPERTYReady) { _DISABLED_SELECTED_ICON_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DISABLED_SELECTED_ICON_CHANGED_PROPERTY"); _DISABLED_SELECTED_ICON_CHANGED_PROPERTYReady = true; } return _DISABLED_SELECTED_ICON_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _DISABLED_SELECTED_ICON_CHANGED_PROPERTYContent = default;
        private static bool _DISABLED_SELECTED_ICON_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#FOCUS_PAINTED_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String FOCUS_PAINTED_CHANGED_PROPERTY { get { if (!_FOCUS_PAINTED_CHANGED_PROPERTYReady) { _FOCUS_PAINTED_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FOCUS_PAINTED_CHANGED_PROPERTY"); _FOCUS_PAINTED_CHANGED_PROPERTYReady = true; } return _FOCUS_PAINTED_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _FOCUS_PAINTED_CHANGED_PROPERTYContent = default;
        private static bool _FOCUS_PAINTED_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#HORIZONTAL_ALIGNMENT_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String HORIZONTAL_ALIGNMENT_CHANGED_PROPERTY { get { if (!_HORIZONTAL_ALIGNMENT_CHANGED_PROPERTYReady) { _HORIZONTAL_ALIGNMENT_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HORIZONTAL_ALIGNMENT_CHANGED_PROPERTY"); _HORIZONTAL_ALIGNMENT_CHANGED_PROPERTYReady = true; } return _HORIZONTAL_ALIGNMENT_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _HORIZONTAL_ALIGNMENT_CHANGED_PROPERTYContent = default;
        private static bool _HORIZONTAL_ALIGNMENT_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#HORIZONTAL_TEXT_POSITION_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String HORIZONTAL_TEXT_POSITION_CHANGED_PROPERTY { get { if (!_HORIZONTAL_TEXT_POSITION_CHANGED_PROPERTYReady) { _HORIZONTAL_TEXT_POSITION_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HORIZONTAL_TEXT_POSITION_CHANGED_PROPERTY"); _HORIZONTAL_TEXT_POSITION_CHANGED_PROPERTYReady = true; } return _HORIZONTAL_TEXT_POSITION_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _HORIZONTAL_TEXT_POSITION_CHANGED_PROPERTYContent = default;
        private static bool _HORIZONTAL_TEXT_POSITION_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#ICON_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ICON_CHANGED_PROPERTY { get { if (!_ICON_CHANGED_PROPERTYReady) { _ICON_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ICON_CHANGED_PROPERTY"); _ICON_CHANGED_PROPERTYReady = true; } return _ICON_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _ICON_CHANGED_PROPERTYContent = default;
        private static bool _ICON_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#MARGIN_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String MARGIN_CHANGED_PROPERTY { get { if (!_MARGIN_CHANGED_PROPERTYReady) { _MARGIN_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MARGIN_CHANGED_PROPERTY"); _MARGIN_CHANGED_PROPERTYReady = true; } return _MARGIN_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _MARGIN_CHANGED_PROPERTYContent = default;
        private static bool _MARGIN_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#MNEMONIC_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String MNEMONIC_CHANGED_PROPERTY { get { if (!_MNEMONIC_CHANGED_PROPERTYReady) { _MNEMONIC_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MNEMONIC_CHANGED_PROPERTY"); _MNEMONIC_CHANGED_PROPERTYReady = true; } return _MNEMONIC_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _MNEMONIC_CHANGED_PROPERTYContent = default;
        private static bool _MNEMONIC_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#MODEL_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String MODEL_CHANGED_PROPERTY { get { if (!_MODEL_CHANGED_PROPERTYReady) { _MODEL_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MODEL_CHANGED_PROPERTY"); _MODEL_CHANGED_PROPERTYReady = true; } return _MODEL_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _MODEL_CHANGED_PROPERTYContent = default;
        private static bool _MODEL_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#PRESSED_ICON_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String PRESSED_ICON_CHANGED_PROPERTY { get { if (!_PRESSED_ICON_CHANGED_PROPERTYReady) { _PRESSED_ICON_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PRESSED_ICON_CHANGED_PROPERTY"); _PRESSED_ICON_CHANGED_PROPERTYReady = true; } return _PRESSED_ICON_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _PRESSED_ICON_CHANGED_PROPERTYContent = default;
        private static bool _PRESSED_ICON_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#ROLLOVER_ENABLED_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ROLLOVER_ENABLED_CHANGED_PROPERTY { get { if (!_ROLLOVER_ENABLED_CHANGED_PROPERTYReady) { _ROLLOVER_ENABLED_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ROLLOVER_ENABLED_CHANGED_PROPERTY"); _ROLLOVER_ENABLED_CHANGED_PROPERTYReady = true; } return _ROLLOVER_ENABLED_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _ROLLOVER_ENABLED_CHANGED_PROPERTYContent = default;
        private static bool _ROLLOVER_ENABLED_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#ROLLOVER_ICON_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ROLLOVER_ICON_CHANGED_PROPERTY { get { if (!_ROLLOVER_ICON_CHANGED_PROPERTYReady) { _ROLLOVER_ICON_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ROLLOVER_ICON_CHANGED_PROPERTY"); _ROLLOVER_ICON_CHANGED_PROPERTYReady = true; } return _ROLLOVER_ICON_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _ROLLOVER_ICON_CHANGED_PROPERTYContent = default;
        private static bool _ROLLOVER_ICON_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#ROLLOVER_SELECTED_ICON_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ROLLOVER_SELECTED_ICON_CHANGED_PROPERTY { get { if (!_ROLLOVER_SELECTED_ICON_CHANGED_PROPERTYReady) { _ROLLOVER_SELECTED_ICON_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ROLLOVER_SELECTED_ICON_CHANGED_PROPERTY"); _ROLLOVER_SELECTED_ICON_CHANGED_PROPERTYReady = true; } return _ROLLOVER_SELECTED_ICON_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _ROLLOVER_SELECTED_ICON_CHANGED_PROPERTYContent = default;
        private static bool _ROLLOVER_SELECTED_ICON_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#SELECTED_ICON_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String SELECTED_ICON_CHANGED_PROPERTY { get { if (!_SELECTED_ICON_CHANGED_PROPERTYReady) { _SELECTED_ICON_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SELECTED_ICON_CHANGED_PROPERTY"); _SELECTED_ICON_CHANGED_PROPERTYReady = true; } return _SELECTED_ICON_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _SELECTED_ICON_CHANGED_PROPERTYContent = default;
        private static bool _SELECTED_ICON_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#TEXT_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String TEXT_CHANGED_PROPERTY { get { if (!_TEXT_CHANGED_PROPERTYReady) { _TEXT_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TEXT_CHANGED_PROPERTY"); _TEXT_CHANGED_PROPERTYReady = true; } return _TEXT_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _TEXT_CHANGED_PROPERTYContent = default;
        private static bool _TEXT_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#VERTICAL_ALIGNMENT_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String VERTICAL_ALIGNMENT_CHANGED_PROPERTY { get { if (!_VERTICAL_ALIGNMENT_CHANGED_PROPERTYReady) { _VERTICAL_ALIGNMENT_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "VERTICAL_ALIGNMENT_CHANGED_PROPERTY"); _VERTICAL_ALIGNMENT_CHANGED_PROPERTYReady = true; } return _VERTICAL_ALIGNMENT_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _VERTICAL_ALIGNMENT_CHANGED_PROPERTYContent = default;
        private static bool _VERTICAL_ALIGNMENT_CHANGED_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#VERTICAL_TEXT_POSITION_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String VERTICAL_TEXT_POSITION_CHANGED_PROPERTY { get { if (!_VERTICAL_TEXT_POSITION_CHANGED_PROPERTYReady) { _VERTICAL_TEXT_POSITION_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "VERTICAL_TEXT_POSITION_CHANGED_PROPERTY"); _VERTICAL_TEXT_POSITION_CHANGED_PROPERTYReady = true; } return _VERTICAL_TEXT_POSITION_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _VERTICAL_TEXT_POSITION_CHANGED_PROPERTYContent = default;
        private static bool _VERTICAL_TEXT_POSITION_CHANGED_PROPERTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getAction()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setAction(javax.swing.Action)"/>
        /// </summary>
        public Javax.Swing.Action Action
        {
            get { return IExecuteWithSignature<Javax.Swing.Action>("getAction", "()Ljavax/swing/Action;"); } set { IExecuteWithSignature("setAction", "(Ljavax/swing/Action;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getActionCommand()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setActionCommand(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ActionCommand
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getActionCommand", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setActionCommand", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getActionListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ActionListener[] ActionListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.ActionListener>("getActionListeners", "()[Ljava/awt/event/ActionListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getChangeListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ChangeListener[] ChangeListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.ChangeListener>("getChangeListeners", "()[Ljavax/swing/event/ChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getDisabledIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setDisabledIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon DisabledIcon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getDisabledIcon", "()Ljavax/swing/Icon;"); } set { IExecuteWithSignature("setDisabledIcon", "(Ljavax/swing/Icon;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getDisabledSelectedIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setDisabledSelectedIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon DisabledSelectedIcon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getDisabledSelectedIcon", "()Ljavax/swing/Icon;"); } set { IExecuteWithSignature("setDisabledSelectedIcon", "(Ljavax/swing/Icon;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getDisplayedMnemonicIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setDisplayedMnemonicIndex(int)"/>
        /// </summary>
        public int DisplayedMnemonicIndex
        {
            get { return IExecuteWithSignature<int>("getDisplayedMnemonicIndex", "()I"); } set { IExecuteWithSignature("setDisplayedMnemonicIndex", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getHideActionText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setHideActionText(boolean)"/>
        /// </summary>
        public bool HideActionText
        {
            get { return IExecuteWithSignature<bool>("getHideActionText", "()Z"); } set { IExecuteWithSignature("setHideActionText", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getHorizontalAlignment()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setHorizontalAlignment(int)"/>
        /// </summary>
        public int HorizontalAlignment
        {
            get { return IExecuteWithSignature<int>("getHorizontalAlignment", "()I"); } set { IExecuteWithSignature("setHorizontalAlignment", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getHorizontalTextPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setHorizontalTextPosition(int)"/>
        /// </summary>
        public int HorizontalTextPosition
        {
            get { return IExecuteWithSignature<int>("getHorizontalTextPosition", "()I"); } set { IExecuteWithSignature("setHorizontalTextPosition", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon Icon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getIcon", "()Ljavax/swing/Icon;"); } set { IExecuteWithSignature("setIcon", "(Ljavax/swing/Icon;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getIconTextGap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setIconTextGap(int)"/>
        /// </summary>
        public int IconTextGap
        {
            get { return IExecuteWithSignature<int>("getIconTextGap", "()I"); } set { IExecuteWithSignature("setIconTextGap", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getItemListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ItemListener[] ItemListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.ItemListener>("getItemListeners", "()[Ljava/awt/event/ItemListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getMargin()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setMargin(java.awt.Insets)"/>
        /// </summary>
        public Java.Awt.Insets Margin
        {
            get { return IExecuteWithSignature<Java.Awt.Insets>("getMargin", "()Ljava/awt/Insets;"); } set { IExecuteWithSignature("setMargin", "(Ljava/awt/Insets;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getMnemonic()"/> 
        /// </summary>
        public int Mnemonic
        {
            get { return IExecuteWithSignature<int>("getMnemonic", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setModel(javax.swing.ButtonModel)"/>
        /// </summary>
        public Javax.Swing.ButtonModel Model
        {
            get { return IExecuteWithSignature<Javax.Swing.ButtonModel>("getModel", "()Ljavax/swing/ButtonModel;"); } set { IExecuteWithSignature("setModel", "(Ljavax/swing/ButtonModel;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getMultiClickThreshhold()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setMultiClickThreshhold(long)"/>
        /// </summary>
        public long MultiClickThreshhold
        {
            get { return IExecuteWithSignature<long>("getMultiClickThreshhold", "()J"); } set { IExecuteWithSignature("setMultiClickThreshhold", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getPressedIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setPressedIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon PressedIcon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getPressedIcon", "()Ljavax/swing/Icon;"); } set { IExecuteWithSignature("setPressedIcon", "(Ljavax/swing/Icon;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getRolloverIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setRolloverIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon RolloverIcon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getRolloverIcon", "()Ljavax/swing/Icon;"); } set { IExecuteWithSignature("setRolloverIcon", "(Ljavax/swing/Icon;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getRolloverSelectedIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setRolloverSelectedIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon RolloverSelectedIcon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getRolloverSelectedIcon", "()Ljavax/swing/Icon;"); } set { IExecuteWithSignature("setRolloverSelectedIcon", "(Ljavax/swing/Icon;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getSelectedIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setSelectedIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon SelectedIcon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getSelectedIcon", "()Ljavax/swing/Icon;"); } set { IExecuteWithSignature("setSelectedIcon", "(Ljavax/swing/Icon;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getSelectedObjects()"/> 
        /// </summary>
        public object[] SelectedObjects
        {
            get { return IExecuteWithSignatureArray<object>("getSelectedObjects", "()[Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setText(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Text
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getText", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setText", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getVerticalAlignment()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setVerticalAlignment(int)"/>
        /// </summary>
        public int VerticalAlignment
        {
            get { return IExecuteWithSignature<int>("getVerticalAlignment", "()I"); } set { IExecuteWithSignature("setVerticalAlignment", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#getVerticalTextPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setVerticalTextPosition(int)"/>
        /// </summary>
        public int VerticalTextPosition
        {
            get { return IExecuteWithSignature<int>("getVerticalTextPosition", "()I"); } set { IExecuteWithSignature("setVerticalTextPosition", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#isBorderPainted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBorderPainted()
        {
            return IExecuteWithSignature<bool>("isBorderPainted", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#isContentAreaFilled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsContentAreaFilled()
        {
            return IExecuteWithSignature<bool>("isContentAreaFilled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#isFocusPainted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFocusPainted()
        {
            return IExecuteWithSignature<bool>("isFocusPainted", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#isRolloverEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRolloverEnabled()
        {
            return IExecuteWithSignature<bool>("isRolloverEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#isSelected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSelected()
        {
            return IExecuteWithSignature<bool>("isSelected", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#addActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void AddActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecuteWithSignature("addActionListener", "(Ljava/awt/event/ActionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("addChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#addItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        public void AddItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecuteWithSignature("addItemListener", "(Ljava/awt/event/ItemListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#doClick()"/>
        /// </summary>
        public void DoClick()
        {
            IExecuteWithSignature("doClick", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#doClick(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void DoClick(int arg0)
        {
            IExecuteWithSignature("doClick", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#removeActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void RemoveActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecuteWithSignature("removeActionListener", "(Ljava/awt/event/ActionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("removeChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#removeItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        public void RemoveItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecuteWithSignature("removeItemListener", "(Ljava/awt/event/ItemListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setBorderPainted(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetBorderPainted(bool arg0)
        {
            IExecuteWithSignature("setBorderPainted", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setContentAreaFilled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetContentAreaFilled(bool arg0)
        {
            IExecuteWithSignature("setContentAreaFilled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setFocusPainted(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFocusPainted(bool arg0)
        {
            IExecuteWithSignature("setFocusPainted", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setMnemonic(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void SetMnemonic(char arg0)
        {
            IExecuteWithSignature("setMnemonic", "(C)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setMnemonic(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMnemonic(int arg0)
        {
            IExecuteWithSignature("setMnemonic", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setRolloverEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRolloverEnabled(bool arg0)
        {
            IExecuteWithSignature("setRolloverEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setSelected(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetSelected(bool arg0)
        {
            IExecuteWithSignature("setSelected", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractButton.html#setUI(javax.swing.plaf.ButtonUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.ButtonUI"/></param>
        public void SetUI(Javax.Swing.Plaf.ButtonUI arg0)
        {
            IExecuteWithSignature("setUI", "(Ljavax/swing/plaf/ButtonUI;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}