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
    #region JTableHeader
    public partial class JTableHeader
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#%3Cinit%3E(javax.swing.table.TableColumnModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableColumnModel"/></param>
        public JTableHeader(Javax.Swing.Table.TableColumnModel arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.JTableHeader"/> to <see cref="Javax.Swing.Event.TableColumnModelListener"/>
        /// </summary>
        public static implicit operator Javax.Swing.Event.TableColumnModelListener(Javax.Swing.Table.JTableHeader t) => t.Cast<Javax.Swing.Event.TableColumnModelListener>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.JTableHeader"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.Table.JTableHeader t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#getColumnModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#setColumnModel(javax.swing.table.TableColumnModel)"/>
        /// </summary>
        public Javax.Swing.Table.TableColumnModel ColumnModel
        {
            get { return IExecuteWithSignature<Javax.Swing.Table.TableColumnModel>("getColumnModel", "()Ljavax/swing/table/TableColumnModel;"); } set { IExecuteWithSignature("setColumnModel", "(Ljavax/swing/table/TableColumnModel;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#getDefaultRenderer()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#setDefaultRenderer(javax.swing.table.TableCellRenderer)"/>
        /// </summary>
        public Javax.Swing.Table.TableCellRenderer DefaultRenderer
        {
            get { return IExecuteWithSignature<Javax.Swing.Table.TableCellRenderer>("getDefaultRenderer", "()Ljavax/swing/table/TableCellRenderer;"); } set { IExecuteWithSignature("setDefaultRenderer", "(Ljavax/swing/table/TableCellRenderer;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#getDraggedColumn()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#setDraggedColumn(javax.swing.table.TableColumn)"/>
        /// </summary>
        public Javax.Swing.Table.TableColumn DraggedColumn
        {
            get { return IExecuteWithSignature<Javax.Swing.Table.TableColumn>("getDraggedColumn", "()Ljavax/swing/table/TableColumn;"); } set { IExecuteWithSignature("setDraggedColumn", "(Ljavax/swing/table/TableColumn;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#getDraggedDistance()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#setDraggedDistance(int)"/>
        /// </summary>
        public int DraggedDistance
        {
            get { return IExecuteWithSignature<int>("getDraggedDistance", "()I"); } set { IExecuteWithSignature("setDraggedDistance", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#getReorderingAllowed()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#setReorderingAllowed(boolean)"/>
        /// </summary>
        public bool ReorderingAllowed
        {
            get { return IExecuteWithSignature<bool>("getReorderingAllowed", "()Z"); } set { IExecuteWithSignature("setReorderingAllowed", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#getResizingAllowed()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#setResizingAllowed(boolean)"/>
        /// </summary>
        public bool ResizingAllowed
        {
            get { return IExecuteWithSignature<bool>("getResizingAllowed", "()Z"); } set { IExecuteWithSignature("setResizingAllowed", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#getResizingColumn()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#setResizingColumn(javax.swing.table.TableColumn)"/>
        /// </summary>
        public Javax.Swing.Table.TableColumn ResizingColumn
        {
            get { return IExecuteWithSignature<Javax.Swing.Table.TableColumn>("getResizingColumn", "()Ljavax/swing/table/TableColumn;"); } set { IExecuteWithSignature("setResizingColumn", "(Ljavax/swing/table/TableColumn;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#getTable()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#setTable(javax.swing.JTable)"/>
        /// </summary>
        public Javax.Swing.JTable Table
        {
            get { return IExecuteWithSignature<Javax.Swing.JTable>("getTable", "()Ljavax/swing/JTable;"); } set { IExecuteWithSignature("setTable", "(Ljavax/swing/JTable;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#getUpdateTableInRealTime()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#setUpdateTableInRealTime(boolean)"/>
        /// </summary>
        public bool UpdateTableInRealTime
        {
            get { return IExecuteWithSignature<bool>("getUpdateTableInRealTime", "()Z"); } set { IExecuteWithSignature("setUpdateTableInRealTime", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#columnAtPoint(java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="int"/></returns>
        public int ColumnAtPoint(Java.Awt.Point arg0)
        {
            return IExecuteWithSignature<int>("columnAtPoint", "(Ljava/awt/Point;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#getHeaderRect(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public Java.Awt.Rectangle GetHeaderRect(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.Rectangle>("getHeaderRect", "(I)Ljava/awt/Rectangle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#columnAdded(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        public void ColumnAdded(Javax.Swing.Event.TableColumnModelEvent arg0)
        {
            IExecuteWithSignature("columnAdded", "(Ljavax/swing/event/TableColumnModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#columnMarginChanged(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        public void ColumnMarginChanged(Javax.Swing.Event.ChangeEvent arg0)
        {
            IExecuteWithSignature("columnMarginChanged", "(Ljavax/swing/event/ChangeEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#columnMoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        public void ColumnMoved(Javax.Swing.Event.TableColumnModelEvent arg0)
        {
            IExecuteWithSignature("columnMoved", "(Ljavax/swing/event/TableColumnModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#columnRemoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        public void ColumnRemoved(Javax.Swing.Event.TableColumnModelEvent arg0)
        {
            IExecuteWithSignature("columnRemoved", "(Ljavax/swing/event/TableColumnModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#columnSelectionChanged(javax.swing.event.ListSelectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionEvent"/></param>
        public void ColumnSelectionChanged(Javax.Swing.Event.ListSelectionEvent arg0)
        {
            IExecuteWithSignature("columnSelectionChanged", "(Ljavax/swing/event/ListSelectionEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#resizeAndRepaint()"/>
        /// </summary>
        public void ResizeAndRepaint()
        {
            IExecuteWithSignature("resizeAndRepaint", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/JTableHeader.html#setUI(javax.swing.plaf.TableHeaderUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.TableHeaderUI"/></param>
        public void SetUI(Javax.Swing.Plaf.TableHeaderUI arg0)
        {
            IExecuteWithSignature("setUI", "(Ljavax/swing/plaf/TableHeaderUI;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}