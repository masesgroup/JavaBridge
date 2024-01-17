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
    #region DefaultCellEditor
    public partial class DefaultCellEditor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultCellEditor.html#%3Cinit%3E(javax.swing.JCheckBox)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JCheckBox"/></param>
        public DefaultCellEditor(Javax.Swing.JCheckBox arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultCellEditor.html#%3Cinit%3E(javax.swing.JComboBox)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComboBox"/></param>
        public DefaultCellEditor(Javax.Swing.JComboBox<object> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultCellEditor.html#%3Cinit%3E(javax.swing.JTextField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTextField"/></param>
        public DefaultCellEditor(Javax.Swing.JTextField arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultCellEditor"/> to <see cref="Javax.Swing.Table.TableCellEditor"/>
        /// </summary>
        public static implicit operator Javax.Swing.Table.TableCellEditor(Javax.Swing.DefaultCellEditor t) => t.Cast<Javax.Swing.Table.TableCellEditor>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultCellEditor"/> to <see cref="Javax.Swing.Tree.TreeCellEditor"/>
        /// </summary>
        public static implicit operator Javax.Swing.Tree.TreeCellEditor(Javax.Swing.DefaultCellEditor t) => t.Cast<Javax.Swing.Tree.TreeCellEditor>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultCellEditor.html#getClickCountToStart()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultCellEditor.html#setClickCountToStart(int)"/>
        /// </summary>
        public int ClickCountToStart
        {
            get { return IExecute<int>("getClickCountToStart"); } set { IExecute("setClickCountToStart", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultCellEditor.html#getComponent()"/> 
        /// </summary>
        public Java.Awt.Component Component
        {
            get { return IExecute<Java.Awt.Component>("getComponent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultCellEditor.html#getTableCellEditorComponent(javax.swing.JTable,java.lang.Object,boolean,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetTableCellEditorComponent(Javax.Swing.JTable arg0, object arg1, bool arg2, int arg3, int arg4)
        {
            return IExecute<Java.Awt.Component>("getTableCellEditorComponent", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultCellEditor.html#getTreeCellEditorComponent(javax.swing.JTree,java.lang.Object,boolean,boolean,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetTreeCellEditorComponent(Javax.Swing.JTree arg0, object arg1, bool arg2, bool arg3, bool arg4, int arg5)
        {
            return IExecute<Java.Awt.Component>("getTreeCellEditorComponent", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}