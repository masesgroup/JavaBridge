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

namespace Javax.Swing.Plaf.Basic
{
    #region BasicComboBoxEditor
    public partial class BasicComboBoxEditor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicComboBoxEditor"/> to <see cref="Javax.Swing.ComboBoxEditor"/>
        /// </summary>
        public static implicit operator Javax.Swing.ComboBoxEditor(Javax.Swing.Plaf.Basic.BasicComboBoxEditor t) => t.Cast<Javax.Swing.ComboBoxEditor>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicComboBoxEditor"/> to <see cref="Java.Awt.EventNs.FocusListener"/>
        /// </summary>
        public static implicit operator Java.Awt.EventNs.FocusListener(Javax.Swing.Plaf.Basic.BasicComboBoxEditor t) => t.Cast<Java.Awt.EventNs.FocusListener>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxEditor.html#getEditorComponent()"/> 
        /// </summary>
        public Java.Awt.Component EditorComponent
        {
            get { return IExecute<Java.Awt.Component>("getEditorComponent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxEditor.html#getItem()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxEditor.html#setItem(java.lang.Object)"/>
        /// </summary>
        public object Item
        {
            get { return IExecute("getItem"); } set { IExecute("setItem", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxEditor.html#addActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void AddActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("addActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxEditor.html#focusGained(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        public void FocusGained(Java.Awt.EventNs.FocusEvent arg0)
        {
            IExecute("focusGained", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxEditor.html#focusLost(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        public void FocusLost(Java.Awt.EventNs.FocusEvent arg0)
        {
            IExecute("focusLost", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxEditor.html#removeActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void RemoveActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("removeActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxEditor.html#selectAll()"/>
        /// </summary>
        public void SelectAll()
        {
            IExecute("selectAll");
        }
        
        #endregion

        #region Nested classes
        #region UIResource
        public partial class UIResource
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicComboBoxEditor.UIResource"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.Basic.BasicComboBoxEditor.UIResource t) => t.Cast<Javax.Swing.Plaf.UIResource>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}