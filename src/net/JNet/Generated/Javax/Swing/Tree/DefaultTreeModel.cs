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

namespace Javax.Swing.Tree
{
    #region DefaultTreeModel
    public partial class DefaultTreeModel
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#%3Cinit%3E(javax.swing.tree.TreeNode,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public DefaultTreeModel(Javax.Swing.Tree.TreeNode arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#%3Cinit%3E(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        public DefaultTreeModel(Javax.Swing.Tree.TreeNode arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultTreeModel"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Tree.DefaultTreeModel t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultTreeModel"/> to <see cref="Javax.Swing.Tree.TreeModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.Tree.TreeModel(Javax.Swing.Tree.DefaultTreeModel t) => t.Cast<Javax.Swing.Tree.TreeModel>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#getRoot()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#setRoot(javax.swing.tree.TreeNode)"/>
        /// </summary>
        public object Root
        {
            get { return IExecute("getRoot"); } set { IExecute("setRoot", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#getTreeModelListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.TreeModelListener[] TreeModelListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.TreeModelListener>("getTreeModelListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#getListeners(java.lang.Class%3CT%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.EventListener"/></returns>
        public Java.Util.EventListener[] GetListeners(Java.Lang.Class arg0)
        {
            return IExecuteArray<Java.Util.EventListener>("getListeners", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#asksAllowsChildren()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool AsksAllowsChildren()
        {
            return IExecute<bool>("asksAllowsChildren");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#isLeaf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsLeaf(object arg0)
        {
            return IExecute<bool>("isLeaf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#getChildCount(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetChildCount(object arg0)
        {
            return IExecute<int>("getChildCount", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#getIndexOfChild(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetIndexOfChild(object arg0, object arg1)
        {
            return IExecute<int>("getIndexOfChild", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#getChild(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetChild(object arg0, int arg1)
        {
            return IExecute("getChild", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#getPathToRoot(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreeNode"/></returns>
        public Javax.Swing.Tree.TreeNode[] GetPathToRoot(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecuteArray<Javax.Swing.Tree.TreeNode>("getPathToRoot", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#addTreeModelListener(javax.swing.event.TreeModelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelListener"/></param>
        public void AddTreeModelListener(Javax.Swing.Event.TreeModelListener arg0)
        {
            IExecute("addTreeModelListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#insertNodeInto(javax.swing.tree.MutableTreeNode,javax.swing.tree.MutableTreeNode,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.MutableTreeNode"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Tree.MutableTreeNode"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void InsertNodeInto(Javax.Swing.Tree.MutableTreeNode arg0, Javax.Swing.Tree.MutableTreeNode arg1, int arg2)
        {
            IExecute("insertNodeInto", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#nodeChanged(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        public void NodeChanged(Javax.Swing.Tree.TreeNode arg0)
        {
            IExecute("nodeChanged", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#nodesChanged(javax.swing.tree.TreeNode,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void NodesChanged(Javax.Swing.Tree.TreeNode arg0, int[] arg1)
        {
            IExecute("nodesChanged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#nodeStructureChanged(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        public void NodeStructureChanged(Javax.Swing.Tree.TreeNode arg0)
        {
            IExecute("nodeStructureChanged", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#nodesWereInserted(javax.swing.tree.TreeNode,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void NodesWereInserted(Javax.Swing.Tree.TreeNode arg0, int[] arg1)
        {
            IExecute("nodesWereInserted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#nodesWereRemoved(javax.swing.tree.TreeNode,int[],java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void NodesWereRemoved(Javax.Swing.Tree.TreeNode arg0, int[] arg1, object[] arg2)
        {
            IExecute("nodesWereRemoved", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#reload()"/>
        /// </summary>
        public void Reload()
        {
            IExecute("reload");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#reload(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        public void Reload(Javax.Swing.Tree.TreeNode arg0)
        {
            IExecute("reload", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#removeNodeFromParent(javax.swing.tree.MutableTreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.MutableTreeNode"/></param>
        public void RemoveNodeFromParent(Javax.Swing.Tree.MutableTreeNode arg0)
        {
            IExecute("removeNodeFromParent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#removeTreeModelListener(javax.swing.event.TreeModelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelListener"/></param>
        public void RemoveTreeModelListener(Javax.Swing.Event.TreeModelListener arg0)
        {
            IExecute("removeTreeModelListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#setAsksAllowsChildren(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAsksAllowsChildren(bool arg0)
        {
            IExecute("setAsksAllowsChildren", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeModel.html#valueForPathChanged(javax.swing.tree.TreePath,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void ValueForPathChanged(Javax.Swing.Tree.TreePath arg0, object arg1)
        {
            IExecute("valueForPathChanged", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}