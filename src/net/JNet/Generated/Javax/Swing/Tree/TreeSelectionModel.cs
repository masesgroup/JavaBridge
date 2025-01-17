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

namespace Javax.Swing.Tree
{
    #region TreeSelectionModel declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html"/>
    /// </summary>
    public partial class TreeSelectionModel : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TreeSelectionModel>
    {
        const string _bridgeClassName = "javax.swing.tree.TreeSelectionModel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("TreeSelectionModel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TreeSelectionModel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("TreeSelectionModel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TreeSelectionModel(params object[] args) : base(args) { }

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

    #region ITreeSelectionModel
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITreeSelectionModel
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getLeadSelectionPath()"/> 
        /// </summary>
        Javax.Swing.Tree.TreePath LeadSelectionPath { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getLeadSelectionRow()"/> 
        /// </summary>
        int LeadSelectionRow { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getMaxSelectionRow()"/> 
        /// </summary>
        int MaxSelectionRow { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getMinSelectionRow()"/> 
        /// </summary>
        int MinSelectionRow { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getRowMapper()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setRowMapper(javax.swing.tree.RowMapper)"/>
        /// </summary>
        Javax.Swing.Tree.RowMapper RowMapper { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionCount()"/> 
        /// </summary>
        int SelectionCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setSelectionMode(int)"/>
        /// </summary>
        int SelectionMode { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionPath()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        Javax.Swing.Tree.TreePath SelectionPath { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionPaths()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        Javax.Swing.Tree.TreePath[] SelectionPaths { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionRows()"/> 
        /// </summary>
        int[] SelectionRows { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#isPathSelected(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsPathSelected(Javax.Swing.Tree.TreePath arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#isRowSelected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsRowSelected(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#isSelectionEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsSelectionEmpty();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        void AddSelectionPath(Javax.Swing.Tree.TreePath arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        void AddSelectionPaths(Javax.Swing.Tree.TreePath[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addTreeSelectionListener(javax.swing.event.TreeSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeSelectionListener"/></param>
        void AddTreeSelectionListener(Javax.Swing.Event.TreeSelectionListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#clearSelection()"/>
        /// </summary>
        void ClearSelection();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removeSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        void RemoveSelectionPath(Javax.Swing.Tree.TreePath arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removeSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        void RemoveSelectionPaths(Javax.Swing.Tree.TreePath[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removeTreeSelectionListener(javax.swing.event.TreeSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeSelectionListener"/></param>
        void RemoveTreeSelectionListener(Javax.Swing.Event.TreeSelectionListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#resetRowSelection()"/>
        /// </summary>
        void ResetRowSelection();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TreeSelectionModel implementation
    public partial class TreeSelectionModel : Javax.Swing.Tree.ITreeSelectionModel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#CONTIGUOUS_TREE_SELECTION"/>
        /// </summary>
        public static int CONTIGUOUS_TREE_SELECTION { get { if (!_CONTIGUOUS_TREE_SELECTIONReady) { _CONTIGUOUS_TREE_SELECTIONContent = SGetField<int>(LocalBridgeClazz, "CONTIGUOUS_TREE_SELECTION"); _CONTIGUOUS_TREE_SELECTIONReady = true; } return _CONTIGUOUS_TREE_SELECTIONContent; } }
        private static int _CONTIGUOUS_TREE_SELECTIONContent = default;
        private static bool _CONTIGUOUS_TREE_SELECTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#DISCONTIGUOUS_TREE_SELECTION"/>
        /// </summary>
        public static int DISCONTIGUOUS_TREE_SELECTION { get { if (!_DISCONTIGUOUS_TREE_SELECTIONReady) { _DISCONTIGUOUS_TREE_SELECTIONContent = SGetField<int>(LocalBridgeClazz, "DISCONTIGUOUS_TREE_SELECTION"); _DISCONTIGUOUS_TREE_SELECTIONReady = true; } return _DISCONTIGUOUS_TREE_SELECTIONContent; } }
        private static int _DISCONTIGUOUS_TREE_SELECTIONContent = default;
        private static bool _DISCONTIGUOUS_TREE_SELECTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#SINGLE_TREE_SELECTION"/>
        /// </summary>
        public static int SINGLE_TREE_SELECTION { get { if (!_SINGLE_TREE_SELECTIONReady) { _SINGLE_TREE_SELECTIONContent = SGetField<int>(LocalBridgeClazz, "SINGLE_TREE_SELECTION"); _SINGLE_TREE_SELECTIONReady = true; } return _SINGLE_TREE_SELECTIONContent; } }
        private static int _SINGLE_TREE_SELECTIONContent = default;
        private static bool _SINGLE_TREE_SELECTIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getLeadSelectionPath()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreePath LeadSelectionPath
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.TreePath>("getLeadSelectionPath", "()Ljavax/swing/tree/TreePath;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getLeadSelectionRow()"/> 
        /// </summary>
        public int LeadSelectionRow
        {
            get { return IExecuteWithSignature<int>("getLeadSelectionRow", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getMaxSelectionRow()"/> 
        /// </summary>
        public int MaxSelectionRow
        {
            get { return IExecuteWithSignature<int>("getMaxSelectionRow", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getMinSelectionRow()"/> 
        /// </summary>
        public int MinSelectionRow
        {
            get { return IExecuteWithSignature<int>("getMinSelectionRow", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getRowMapper()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setRowMapper(javax.swing.tree.RowMapper)"/>
        /// </summary>
        public Javax.Swing.Tree.RowMapper RowMapper
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.RowMapper>("getRowMapper", "()Ljavax/swing/tree/RowMapper;"); } set { IExecuteWithSignature("setRowMapper", "(Ljavax/swing/tree/RowMapper;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionCount()"/> 
        /// </summary>
        public int SelectionCount
        {
            get { return IExecuteWithSignature<int>("getSelectionCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setSelectionMode(int)"/>
        /// </summary>
        public int SelectionMode
        {
            get { return IExecuteWithSignature<int>("getSelectionMode", "()I"); } set { IExecuteWithSignature("setSelectionMode", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionPath()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        public Javax.Swing.Tree.TreePath SelectionPath
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.TreePath>("getSelectionPath", "()Ljavax/swing/tree/TreePath;"); } set { IExecuteWithSignature("setSelectionPath", "(Ljavax/swing/tree/TreePath;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionPaths()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        public Javax.Swing.Tree.TreePath[] SelectionPaths
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Tree.TreePath>("getSelectionPaths", "()[Ljavax/swing/tree/TreePath;"); } set { IExecuteWithSignature("setSelectionPaths", "([Ljavax/swing/tree/TreePath;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionRows()"/> 
        /// </summary>
        public int[] SelectionRows
        {
            get { return IExecuteWithSignatureArray<int>("getSelectionRows", "()[I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#isPathSelected(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPathSelected(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecuteWithSignature<bool>("isPathSelected", "(Ljavax/swing/tree/TreePath;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#isRowSelected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsRowSelected(int arg0)
        {
            return IExecuteWithSignature<bool>("isRowSelected", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#isSelectionEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSelectionEmpty()
        {
            return IExecuteWithSignature<bool>("isSelectionEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecuteWithSignature("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void AddSelectionPath(Javax.Swing.Tree.TreePath arg0)
        {
            IExecuteWithSignature("addSelectionPath", "(Ljavax/swing/tree/TreePath;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void AddSelectionPaths(Javax.Swing.Tree.TreePath[] arg0)
        {
            IExecuteWithSignature("addSelectionPaths", "([Ljavax/swing/tree/TreePath;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addTreeSelectionListener(javax.swing.event.TreeSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeSelectionListener"/></param>
        public void AddTreeSelectionListener(Javax.Swing.Event.TreeSelectionListener arg0)
        {
            IExecuteWithSignature("addTreeSelectionListener", "(Ljavax/swing/event/TreeSelectionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#clearSelection()"/>
        /// </summary>
        public void ClearSelection()
        {
            IExecuteWithSignature("clearSelection", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecuteWithSignature("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removeSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void RemoveSelectionPath(Javax.Swing.Tree.TreePath arg0)
        {
            IExecuteWithSignature("removeSelectionPath", "(Ljavax/swing/tree/TreePath;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removeSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void RemoveSelectionPaths(Javax.Swing.Tree.TreePath[] arg0)
        {
            IExecuteWithSignature("removeSelectionPaths", "([Ljavax/swing/tree/TreePath;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removeTreeSelectionListener(javax.swing.event.TreeSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeSelectionListener"/></param>
        public void RemoveTreeSelectionListener(Javax.Swing.Event.TreeSelectionListener arg0)
        {
            IExecuteWithSignature("removeTreeSelectionListener", "(Ljavax/swing/event/TreeSelectionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#resetRowSelection()"/>
        /// </summary>
        public void ResetRowSelection()
        {
            IExecuteWithSignature("resetRowSelection", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}