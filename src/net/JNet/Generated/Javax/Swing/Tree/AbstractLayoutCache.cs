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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Tree
{
    #region AbstractLayoutCache
    public partial class AbstractLayoutCache
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getNodeDimensions()"/> 
        /// </summary>
        public Javax.Swing.Tree.AbstractLayoutCache.NodeDimensions GetNodeDimensions
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.AbstractLayoutCache.NodeDimensions>("getNodeDimensions", "()Ljavax/swing/tree/AbstractLayoutCache$NodeDimensions;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#setModel(javax.swing.tree.TreeModel)"/>
        /// </summary>
        public Javax.Swing.Tree.TreeModel Model
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.TreeModel>("getModel", "()Ljavax/swing/tree/TreeModel;"); } set { IExecuteWithSignature("setModel", "(Ljavax/swing/tree/TreeModel;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getPreferredHeight()"/> 
        /// </summary>
        public int PreferredHeight
        {
            get { return IExecuteWithSignature<int>("getPreferredHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getRowCount()"/> 
        /// </summary>
        public int RowCount
        {
            get { return IExecuteWithSignature<int>("getRowCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getRowHeight()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#setRowHeight(int)"/>
        /// </summary>
        public int RowHeight
        {
            get { return IExecuteWithSignature<int>("getRowHeight", "()I"); } set { IExecuteWithSignature("setRowHeight", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getSelectionModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#setSelectionModel(javax.swing.tree.TreeSelectionModel)"/>
        /// </summary>
        public Javax.Swing.Tree.TreeSelectionModel SelectionModel
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.TreeSelectionModel>("getSelectionModel", "()Ljavax/swing/tree/TreeSelectionModel;"); } set { IExecuteWithSignature("setSelectionModel", "(Ljavax/swing/tree/TreeSelectionModel;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getExpandedState(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetExpandedState(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecuteWithSignature<bool>("getExpandedState", "(Ljavax/swing/tree/TreePath;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#isExpanded(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsExpanded(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecuteWithSignature<bool>("isExpanded", "(Ljavax/swing/tree/TreePath;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getRowForPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRowForPath(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecuteWithSignature<int>("getRowForPath", "(Ljavax/swing/tree/TreePath;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getVisibleChildCount(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetVisibleChildCount(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecuteWithSignature<int>("getVisibleChildCount", "(Ljavax/swing/tree/TreePath;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getBounds(javax.swing.tree.TreePath,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public Java.Awt.Rectangle GetBounds(Javax.Swing.Tree.TreePath arg0, Java.Awt.Rectangle arg1)
        {
            return IExecute<Java.Awt.Rectangle>("getBounds", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getVisiblePathsFrom(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Javax.Swing.Tree.TreePath> GetVisiblePathsFrom(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Javax.Swing.Tree.TreePath>>("getVisiblePathsFrom", "(Ljavax/swing/tree/TreePath;)Ljava/util/Enumeration;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getPathClosestTo(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreePath"/></returns>
        public Javax.Swing.Tree.TreePath GetPathClosestTo(int arg0, int arg1)
        {
            return IExecute<Javax.Swing.Tree.TreePath>("getPathClosestTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getPathForRow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreePath"/></returns>
        public Javax.Swing.Tree.TreePath GetPathForRow(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Tree.TreePath>("getPathForRow", "(I)Ljavax/swing/tree/TreePath;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#invalidatePathBounds(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void InvalidatePathBounds(Javax.Swing.Tree.TreePath arg0)
        {
            IExecuteWithSignature("invalidatePathBounds", "(Ljavax/swing/tree/TreePath;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#invalidateSizes()"/>
        /// </summary>
        public void InvalidateSizes()
        {
            IExecuteWithSignature("invalidateSizes", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#setExpandedState(javax.swing.tree.TreePath,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetExpandedState(Javax.Swing.Tree.TreePath arg0, bool arg1)
        {
            IExecute("setExpandedState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#treeNodesChanged(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public void TreeNodesChanged(Javax.Swing.Event.TreeModelEvent arg0)
        {
            IExecuteWithSignature("treeNodesChanged", "(Ljavax/swing/event/TreeModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#treeNodesInserted(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public void TreeNodesInserted(Javax.Swing.Event.TreeModelEvent arg0)
        {
            IExecuteWithSignature("treeNodesInserted", "(Ljavax/swing/event/TreeModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#treeNodesRemoved(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public void TreeNodesRemoved(Javax.Swing.Event.TreeModelEvent arg0)
        {
            IExecuteWithSignature("treeNodesRemoved", "(Ljavax/swing/event/TreeModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#treeStructureChanged(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public void TreeStructureChanged(Javax.Swing.Event.TreeModelEvent arg0)
        {
            IExecuteWithSignature("treeStructureChanged", "(Ljavax/swing/event/TreeModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#isRootVisible()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRootVisible()
        {
            return IExecuteWithSignature<bool>("isRootVisible", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getPreferredWidth(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetPreferredWidth(Java.Awt.Rectangle arg0)
        {
            return IExecuteWithSignature<int>("getPreferredWidth", "(Ljava/awt/Rectangle;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getRowsForPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetRowsForPaths(Javax.Swing.Tree.TreePath[] arg0)
        {
            return IExecuteWithSignatureArray<int>("getRowsForPaths", "([Ljavax/swing/tree/TreePath;)[I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#setNodeDimensions(javax.swing.tree.AbstractLayoutCache.NodeDimensions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.AbstractLayoutCache.NodeDimensions"/></param>
        public void SetNodeDimensions(Javax.Swing.Tree.AbstractLayoutCache.NodeDimensions arg0)
        {
            IExecuteWithSignature("setNodeDimensions", "(Ljavax/swing/tree/AbstractLayoutCache$NodeDimensions;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#setRootVisible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRootVisible(bool arg0)
        {
            IExecuteWithSignature("setRootVisible", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes
        #region NodeDimensions
        public partial class NodeDimensions
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.NodeDimensions.html#getNodeDimensions(java.lang.Object,int,int,boolean,java.awt.Rectangle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="bool"/></param>
            /// <param name="arg4"><see cref="Java.Awt.Rectangle"/></param>
            /// <returns><see cref="Java.Awt.Rectangle"/></returns>
            public Java.Awt.Rectangle GetNodeDimensions(object arg0, int arg1, int arg2, bool arg3, Java.Awt.Rectangle arg4)
            {
                return IExecute<Java.Awt.Rectangle>("getNodeDimensions", arg0, arg1, arg2, arg3, arg4);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}