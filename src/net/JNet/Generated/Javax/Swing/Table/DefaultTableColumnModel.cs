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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Table
{
    #region DefaultTableColumnModel
    public partial class DefaultTableColumnModel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.DefaultTableColumnModel"/> to <see cref="Javax.Swing.Table.TableColumnModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.Table.TableColumnModel(Javax.Swing.Table.DefaultTableColumnModel t) => t.Cast<Javax.Swing.Table.TableColumnModel>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.DefaultTableColumnModel"/> to <see cref="Java.Beans.PropertyChangeListener"/>
        /// </summary>
        public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Table.DefaultTableColumnModel t) => t.Cast<Java.Beans.PropertyChangeListener>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.DefaultTableColumnModel"/> to <see cref="Javax.Swing.Event.ListSelectionListener"/>
        /// </summary>
        public static implicit operator Javax.Swing.Event.ListSelectionListener(Javax.Swing.Table.DefaultTableColumnModel t) => t.Cast<Javax.Swing.Event.ListSelectionListener>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.DefaultTableColumnModel"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Table.DefaultTableColumnModel t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumnCount()"/> 
        /// </summary>
        public int ColumnCount
        {
            get { return IExecuteWithSignature<int>("getColumnCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumnMargin()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#setColumnMargin(int)"/>
        /// </summary>
        public int ColumnMargin
        {
            get { return IExecuteWithSignature<int>("getColumnMargin", "()I"); } set { IExecuteWithSignature("setColumnMargin", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumnModelListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.TableColumnModelListener[] ColumnModelListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.TableColumnModelListener>("getColumnModelListeners", "()[Ljavax/swing/event/TableColumnModelListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumns()"/> 
        /// </summary>
        public Java.Util.Enumeration<Javax.Swing.Table.TableColumn> Columns
        {
            get { return IExecuteWithSignature<Java.Util.Enumeration<Javax.Swing.Table.TableColumn>>("getColumns", "()Ljava/util/Enumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumnSelectionAllowed()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#setColumnSelectionAllowed(boolean)"/>
        /// </summary>
        public bool ColumnSelectionAllowed
        {
            get { return IExecuteWithSignature<bool>("getColumnSelectionAllowed", "()Z"); } set { IExecuteWithSignature("setColumnSelectionAllowed", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getSelectedColumnCount()"/> 
        /// </summary>
        public int SelectedColumnCount
        {
            get { return IExecuteWithSignature<int>("getSelectedColumnCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getSelectedColumns()"/> 
        /// </summary>
        public int[] SelectedColumns
        {
            get { return IExecuteWithSignatureArray<int>("getSelectedColumns", "()[I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getSelectionModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#setSelectionModel(javax.swing.ListSelectionModel)"/>
        /// </summary>
        public Javax.Swing.ListSelectionModel SelectionModel
        {
            get { return IExecuteWithSignature<Javax.Swing.ListSelectionModel>("getSelectionModel", "()Ljavax/swing/ListSelectionModel;"); } set { IExecuteWithSignature("setSelectionModel", "(Ljavax/swing/ListSelectionModel;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getTotalColumnWidth()"/> 
        /// </summary>
        public int TotalColumnWidth
        {
            get { return IExecuteWithSignature<int>("getTotalColumnWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumnIndex(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetColumnIndex(object arg0)
        {
            return IExecuteWithSignature<int>("getColumnIndex", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumnIndexAtX(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetColumnIndexAtX(int arg0)
        {
            return IExecuteWithSignature<int>("getColumnIndexAtX", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumn(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Table.TableColumn"/></returns>
        public Javax.Swing.Table.TableColumn GetColumn(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Table.TableColumn>("getColumn", "(I)Ljavax/swing/table/TableColumn;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#addColumn(javax.swing.table.TableColumn)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableColumn"/></param>
        public void AddColumn(Javax.Swing.Table.TableColumn arg0)
        {
            IExecuteWithSignature("addColumn", "(Ljavax/swing/table/TableColumn;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#addColumnModelListener(javax.swing.event.TableColumnModelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelListener"/></param>
        public void AddColumnModelListener(Javax.Swing.Event.TableColumnModelListener arg0)
        {
            IExecuteWithSignature("addColumnModelListener", "(Ljavax/swing/event/TableColumnModelListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#moveColumn(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void MoveColumn(int arg0, int arg1)
        {
            IExecute("moveColumn", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#propertyChange(java.beans.PropertyChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
        public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
        {
            IExecuteWithSignature("propertyChange", "(Ljava/beans/PropertyChangeEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#removeColumn(javax.swing.table.TableColumn)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableColumn"/></param>
        public void RemoveColumn(Javax.Swing.Table.TableColumn arg0)
        {
            IExecuteWithSignature("removeColumn", "(Ljavax/swing/table/TableColumn;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#removeColumnModelListener(javax.swing.event.TableColumnModelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelListener"/></param>
        public void RemoveColumnModelListener(Javax.Swing.Event.TableColumnModelListener arg0)
        {
            IExecuteWithSignature("removeColumnModelListener", "(Ljavax/swing/event/TableColumnModelListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#valueChanged(javax.swing.event.ListSelectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionEvent"/></param>
        public void ValueChanged(Javax.Swing.Event.ListSelectionEvent arg0)
        {
            IExecuteWithSignature("valueChanged", "(Ljavax/swing/event/ListSelectionEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}