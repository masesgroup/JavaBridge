/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JComboBox
    public partial class JComboBox
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#%3Cinit%3E(java.util.Vector%3CE%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Vector"/></param>
        public JComboBox(Java.Util.Vector arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#%3Cinit%3E(javax.swing.ComboBoxModel%3CE%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.ComboBoxModel"/></param>
        public JComboBox(Javax.Swing.ComboBoxModel arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JComboBox"/> to <see cref="Java.Awt.ItemSelectable"/>
        /// </summary>
        public static implicit operator Java.Awt.ItemSelectable(Javax.Swing.JComboBox t) => t.Cast<Java.Awt.ItemSelectable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JComboBox"/> to <see cref="Javax.Swing.Event.ListDataListener"/>
        /// </summary>
        public static implicit operator Javax.Swing.Event.ListDataListener(Javax.Swing.JComboBox t) => t.Cast<Javax.Swing.Event.ListDataListener>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JComboBox"/> to <see cref="Java.Awt.EventNs.ActionListener"/>
        /// </summary>
        public static implicit operator Java.Awt.EventNs.ActionListener(Javax.Swing.JComboBox t) => t.Cast<Java.Awt.EventNs.ActionListener>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JComboBox"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JComboBox t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getAction()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#setAction(javax.swing.Action)"/>
        /// </summary>
        public Javax.Swing.Action Action
        {
            get { return IExecute<Javax.Swing.Action>("getAction"); } set { IExecute("setAction", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getActionCommand()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#setActionCommand(java.lang.String)"/>
        /// </summary>
        public string ActionCommand
        {
            get { return IExecute<string>("getActionCommand"); } set { IExecute("setActionCommand", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getActionListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ActionListener[] ActionListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.ActionListener>("getActionListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getEditor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#setEditor(javax.swing.ComboBoxEditor)"/>
        /// </summary>
        public Javax.Swing.ComboBoxEditor Editor
        {
            get { return IExecute<Javax.Swing.ComboBoxEditor>("getEditor"); } set { IExecute("setEditor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getItemCount()"/> 
        /// </summary>
        public int ItemCount
        {
            get { return IExecute<int>("getItemCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getItemListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ItemListener[] ItemListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.ItemListener>("getItemListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getMaximumRowCount()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#setMaximumRowCount(int)"/>
        /// </summary>
        public int MaximumRowCount
        {
            get { return IExecute<int>("getMaximumRowCount"); } set { IExecute("setMaximumRowCount", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#setModel(javax.swing.ComboBoxModel%3CE%3E)"/>
        /// </summary>
        public Javax.Swing.ComboBoxModel Model
        {
            get { return IExecute<Javax.Swing.ComboBoxModel>("getModel"); } set { IExecute("setModel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getPopupMenuListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.PopupMenuListener[] PopupMenuListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.PopupMenuListener>("getPopupMenuListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getPrototypeDisplayValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#setPrototypeDisplayValue(E)"/>
        /// </summary>
        public object PrototypeDisplayValue
        {
            get { return IExecute("getPrototypeDisplayValue"); } set { IExecute("setPrototypeDisplayValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getRenderer()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#setRenderer(javax.swing.ListCellRenderer%3C? super E%3E)"/>
        /// </summary>
        public Javax.Swing.ListCellRenderer Renderer
        {
            get { return IExecute<Javax.Swing.ListCellRenderer>("getRenderer"); } set { IExecute("setRenderer", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getSelectedIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#setSelectedIndex(int)"/>
        /// </summary>
        public int SelectedIndex
        {
            get { return IExecute<int>("getSelectedIndex"); } set { IExecute("setSelectedIndex", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getSelectedItem()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#setSelectedItem(java.lang.Object)"/>
        /// </summary>
        public object SelectedItem
        {
            get { return IExecute("getSelectedItem"); } set { IExecute("setSelectedItem", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getSelectedObjects()"/> 
        /// </summary>
        public object[] SelectedObjects
        {
            get { return IExecuteArray<object>("getSelectedObjects"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#isEditable()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsEditable()
        {
            return IExecute<bool>("isEditable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#isLightWeightPopupEnabled()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsLightWeightPopupEnabled()
        {
            return IExecute<bool>("isLightWeightPopupEnabled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#isPopupVisible()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsPopupVisible()
        {
            return IExecute<bool>("isPopupVisible");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#selectWithKeyChar(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SelectWithKeyChar(char arg0)
        {
            return IExecute<bool>("selectWithKeyChar", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getItemAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetItemAt(int arg0)
        {
            return IExecute("getItemAt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#getKeySelectionManager()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Swing.JComboBox.KeySelectionManager"/></returns>
        public Javax.Swing.JComboBox.KeySelectionManager GetKeySelectionManager()
        {
            return IExecute<Javax.Swing.JComboBox.KeySelectionManager>("getKeySelectionManager");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#actionPerformed(java.awt.event.ActionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionEvent"/></param>
        public void ActionPerformed(Java.Awt.EventNs.ActionEvent arg0)
        {
            IExecute("actionPerformed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#addActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void AddActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("addActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#addItem(E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddItem(object arg0)
        {
            IExecute("addItem", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#addItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        public void AddItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecute("addItemListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#addPopupMenuListener(javax.swing.event.PopupMenuListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuListener"/></param>
        public void AddPopupMenuListener(Javax.Swing.Event.PopupMenuListener arg0)
        {
            IExecute("addPopupMenuListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#configureEditor(javax.swing.ComboBoxEditor,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.ComboBoxEditor"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void ConfigureEditor(Javax.Swing.ComboBoxEditor arg0, object arg1)
        {
            IExecute("configureEditor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#contentsChanged(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        public void ContentsChanged(Javax.Swing.Event.ListDataEvent arg0)
        {
            IExecute("contentsChanged", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#firePopupMenuCanceled()"/>
        /// </summary>
        public void FirePopupMenuCanceled()
        {
            IExecute("firePopupMenuCanceled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#firePopupMenuWillBecomeInvisible()"/>
        /// </summary>
        public void FirePopupMenuWillBecomeInvisible()
        {
            IExecute("firePopupMenuWillBecomeInvisible");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#firePopupMenuWillBecomeVisible()"/>
        /// </summary>
        public void FirePopupMenuWillBecomeVisible()
        {
            IExecute("firePopupMenuWillBecomeVisible");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#hidePopup()"/>
        /// </summary>
        public void HidePopup()
        {
            IExecute("hidePopup");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#insertItemAt(E,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void InsertItemAt(object arg0, int arg1)
        {
            IExecute("insertItemAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#intervalAdded(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        public void IntervalAdded(Javax.Swing.Event.ListDataEvent arg0)
        {
            IExecute("intervalAdded", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#intervalRemoved(javax.swing.event.ListDataEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
        public void IntervalRemoved(Javax.Swing.Event.ListDataEvent arg0)
        {
            IExecute("intervalRemoved", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#processKeyEvent(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        public void ProcessKeyEvent(Java.Awt.EventNs.KeyEvent arg0)
        {
            IExecute("processKeyEvent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#removeActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void RemoveActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("removeActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#removeAllItems()"/>
        /// </summary>
        public void RemoveAllItems()
        {
            IExecute("removeAllItems");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#removeItem(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void RemoveItem(object arg0)
        {
            IExecute("removeItem", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#removeItemAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveItemAt(int arg0)
        {
            IExecute("removeItemAt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#removeItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        public void RemoveItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecute("removeItemListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#removePopupMenuListener(javax.swing.event.PopupMenuListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuListener"/></param>
        public void RemovePopupMenuListener(Javax.Swing.Event.PopupMenuListener arg0)
        {
            IExecute("removePopupMenuListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#setEditable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEditable(bool arg0)
        {
            IExecute("setEditable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#setKeySelectionManager(javax.swing.JComboBox$KeySelectionManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComboBox.KeySelectionManager"/></param>
        public void SetKeySelectionManager(Javax.Swing.JComboBox.KeySelectionManager arg0)
        {
            IExecute("setKeySelectionManager", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#setLightWeightPopupEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetLightWeightPopupEnabled(bool arg0)
        {
            IExecute("setLightWeightPopupEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#setPopupVisible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPopupVisible(bool arg0)
        {
            IExecute("setPopupVisible", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#setUI(javax.swing.plaf.ComboBoxUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.ComboBoxUI"/></param>
        public void SetUI(Javax.Swing.Plaf.ComboBoxUI arg0)
        {
            IExecute("setUI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.html#showPopup()"/>
        /// </summary>
        public void ShowPopup()
        {
            IExecute("showPopup");
        }
        
        #endregion

        #region Nested classes
        #region KeySelectionManager
        public partial class KeySelectionManager
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComboBox.KeySelectionManager.html#selectionForKey(char,javax.swing.ComboBoxModel%3C?%3E)"/>
            /// </summary>
            /// <param name="arg0"><see cref="char"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.ComboBoxModel"/></param>
            /// <returns><see cref="int"/></returns>
            public int SelectionForKey(char arg0, Javax.Swing.ComboBoxModel arg1)
            {
                return IExecute<int>("selectionForKey", arg0, arg1);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}