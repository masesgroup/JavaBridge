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

namespace Javax.Swing.Table
{
    #region TableColumnModel declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html"/>
    /// </summary>
    public partial class TableColumnModel : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TableColumnModel>
    {
        const string _bridgeClassName = "javax.swing.table.TableColumnModel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("TableColumnModel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TableColumnModel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("TableColumnModel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TableColumnModel(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ITableColumnModel
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITableColumnModel
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnCount()"/> 
        /// </summary>
        int ColumnCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnMargin()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#setColumnMargin(int)"/>
        /// </summary>
        int ColumnMargin { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumns()"/> 
        /// </summary>
        Java.Util.Enumeration<Javax.Swing.Table.TableColumn> Columns { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnSelectionAllowed()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#setColumnSelectionAllowed(boolean)"/>
        /// </summary>
        bool ColumnSelectionAllowed { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getSelectedColumnCount()"/> 
        /// </summary>
        int SelectedColumnCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getSelectedColumns()"/> 
        /// </summary>
        int[] SelectedColumns { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getSelectionModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#setSelectionModel(javax.swing.ListSelectionModel)"/>
        /// </summary>
        Javax.Swing.ListSelectionModel SelectionModel { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getTotalColumnWidth()"/> 
        /// </summary>
        int TotalColumnWidth { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnIndex(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        int GetColumnIndex(object arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnIndexAtX(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        int GetColumnIndexAtX(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumn(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Table.TableColumn"/></returns>
        Javax.Swing.Table.TableColumn GetColumn(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#addColumn(javax.swing.table.TableColumn)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableColumn"/></param>
        void AddColumn(Javax.Swing.Table.TableColumn arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#addColumnModelListener(javax.swing.event.TableColumnModelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelListener"/></param>
        void AddColumnModelListener(Javax.Swing.Event.TableColumnModelListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#moveColumn(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void MoveColumn(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#removeColumn(javax.swing.table.TableColumn)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableColumn"/></param>
        void RemoveColumn(Javax.Swing.Table.TableColumn arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#removeColumnModelListener(javax.swing.event.TableColumnModelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelListener"/></param>
        void RemoveColumnModelListener(Javax.Swing.Event.TableColumnModelListener arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TableColumnModel implementation
    public partial class TableColumnModel : Javax.Swing.Table.ITableColumnModel
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnCount()"/> 
        /// </summary>
        public int ColumnCount
        {
            get { return IExecuteWithSignature<int>("getColumnCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnMargin()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#setColumnMargin(int)"/>
        /// </summary>
        public int ColumnMargin
        {
            get { return IExecuteWithSignature<int>("getColumnMargin", "()I"); } set { IExecuteWithSignature("setColumnMargin", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumns()"/> 
        /// </summary>
        public Java.Util.Enumeration<Javax.Swing.Table.TableColumn> Columns
        {
            get { return IExecuteWithSignature<Java.Util.Enumeration<Javax.Swing.Table.TableColumn>>("getColumns", "()Ljava/util/Enumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnSelectionAllowed()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#setColumnSelectionAllowed(boolean)"/>
        /// </summary>
        public bool ColumnSelectionAllowed
        {
            get { return IExecuteWithSignature<bool>("getColumnSelectionAllowed", "()Z"); } set { IExecuteWithSignature("setColumnSelectionAllowed", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getSelectedColumnCount()"/> 
        /// </summary>
        public int SelectedColumnCount
        {
            get { return IExecuteWithSignature<int>("getSelectedColumnCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getSelectedColumns()"/> 
        /// </summary>
        public int[] SelectedColumns
        {
            get { return IExecuteWithSignatureArray<int>("getSelectedColumns", "()[I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getSelectionModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#setSelectionModel(javax.swing.ListSelectionModel)"/>
        /// </summary>
        public Javax.Swing.ListSelectionModel SelectionModel
        {
            get { return IExecuteWithSignature<Javax.Swing.ListSelectionModel>("getSelectionModel", "()Ljavax/swing/ListSelectionModel;"); } set { IExecuteWithSignature("setSelectionModel", "(Ljavax/swing/ListSelectionModel;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getTotalColumnWidth()"/> 
        /// </summary>
        public int TotalColumnWidth
        {
            get { return IExecuteWithSignature<int>("getTotalColumnWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnIndex(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetColumnIndex(object arg0)
        {
            return IExecuteWithSignature<int>("getColumnIndex", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnIndexAtX(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetColumnIndexAtX(int arg0)
        {
            return IExecuteWithSignature<int>("getColumnIndexAtX", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumn(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Table.TableColumn"/></returns>
        public Javax.Swing.Table.TableColumn GetColumn(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Table.TableColumn>("getColumn", "(I)Ljavax/swing/table/TableColumn;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#addColumn(javax.swing.table.TableColumn)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableColumn"/></param>
        public void AddColumn(Javax.Swing.Table.TableColumn arg0)
        {
            IExecuteWithSignature("addColumn", "(Ljavax/swing/table/TableColumn;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#addColumnModelListener(javax.swing.event.TableColumnModelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelListener"/></param>
        public void AddColumnModelListener(Javax.Swing.Event.TableColumnModelListener arg0)
        {
            IExecuteWithSignature("addColumnModelListener", "(Ljavax/swing/event/TableColumnModelListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#moveColumn(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void MoveColumn(int arg0, int arg1)
        {
            IExecuteWithSignature("moveColumn", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#removeColumn(javax.swing.table.TableColumn)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableColumn"/></param>
        public void RemoveColumn(Javax.Swing.Table.TableColumn arg0)
        {
            IExecuteWithSignature("removeColumn", "(Ljavax/swing/table/TableColumn;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#removeColumnModelListener(javax.swing.event.TableColumnModelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelListener"/></param>
        public void RemoveColumnModelListener(Javax.Swing.Event.TableColumnModelListener arg0)
        {
            IExecuteWithSignature("removeColumnModelListener", "(Ljavax/swing/event/TableColumnModelListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}