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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Tree
{
    #region DefaultMutableTreeNode
    public partial class DefaultMutableTreeNode
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#%3Cinit%3E(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public DefaultMutableTreeNode(object arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#%3Cinit%3E(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public DefaultMutableTreeNode(object arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultMutableTreeNode"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Swing.Tree.DefaultMutableTreeNode t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultMutableTreeNode"/> to <see cref="Javax.Swing.Tree.MutableTreeNode"/>
        /// </summary>
        public static implicit operator Javax.Swing.Tree.MutableTreeNode(Javax.Swing.Tree.DefaultMutableTreeNode t) => t.Cast<Javax.Swing.Tree.MutableTreeNode>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultMutableTreeNode"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Tree.DefaultMutableTreeNode t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#EMPTY_ENUMERATION"/>
        /// </summary>
        public static Java.Util.Enumeration EMPTY_ENUMERATION { get { if (!_EMPTY_ENUMERATIONReady) { _EMPTY_ENUMERATIONContent = SGetField<Java.Util.Enumeration>(LocalBridgeClazz, "EMPTY_ENUMERATION"); _EMPTY_ENUMERATIONReady = true; } return _EMPTY_ENUMERATIONContent; } }
        private static Java.Util.Enumeration _EMPTY_ENUMERATIONContent = default;
        private static bool _EMPTY_ENUMERATIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getAllowsChildren()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#setAllowsChildren(boolean)"/>
        /// </summary>
        public bool AllowsChildren
        {
            get { return IExecuteWithSignature<bool>("getAllowsChildren", "()Z"); } set { IExecuteWithSignature("setAllowsChildren", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getChildCount()"/> 
        /// </summary>
        public int ChildCount
        {
            get { return IExecuteWithSignature<int>("getChildCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getDepth()"/> 
        /// </summary>
        public int Depth
        {
            get { return IExecuteWithSignature<int>("getDepth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getFirstChild()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreeNode FirstChild
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.TreeNode>("getFirstChild", "()Ljavax/swing/tree/TreeNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getFirstLeaf()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode FirstLeaf
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.DefaultMutableTreeNode>("getFirstLeaf", "()Ljavax/swing/tree/DefaultMutableTreeNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getLastChild()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreeNode LastChild
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.TreeNode>("getLastChild", "()Ljavax/swing/tree/TreeNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getLastLeaf()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode LastLeaf
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.DefaultMutableTreeNode>("getLastLeaf", "()Ljavax/swing/tree/DefaultMutableTreeNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getLeafCount()"/> 
        /// </summary>
        public int LeafCount
        {
            get { return IExecuteWithSignature<int>("getLeafCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getLevel()"/> 
        /// </summary>
        public int Level
        {
            get { return IExecuteWithSignature<int>("getLevel", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getNextLeaf()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode NextLeaf
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.DefaultMutableTreeNode>("getNextLeaf", "()Ljavax/swing/tree/DefaultMutableTreeNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getNextNode()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode NextNode
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.DefaultMutableTreeNode>("getNextNode", "()Ljavax/swing/tree/DefaultMutableTreeNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getNextSibling()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode NextSibling
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.DefaultMutableTreeNode>("getNextSibling", "()Ljavax/swing/tree/DefaultMutableTreeNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#setParent(javax.swing.tree.MutableTreeNode)"/>
        /// </summary>
        public Javax.Swing.Tree.TreeNode Parent
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.TreeNode>("getParent", "()Ljavax/swing/tree/TreeNode;"); } set { IExecuteWithSignature("setParent", "(Ljavax/swing/tree/MutableTreeNode;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getPath()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreeNode[] Path
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Tree.TreeNode>("getPath", "()[Ljavax/swing/tree/TreeNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getPreviousLeaf()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode PreviousLeaf
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.DefaultMutableTreeNode>("getPreviousLeaf", "()Ljavax/swing/tree/DefaultMutableTreeNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getPreviousNode()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode PreviousNode
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.DefaultMutableTreeNode>("getPreviousNode", "()Ljavax/swing/tree/DefaultMutableTreeNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getPreviousSibling()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode PreviousSibling
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.DefaultMutableTreeNode>("getPreviousSibling", "()Ljavax/swing/tree/DefaultMutableTreeNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getRoot()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreeNode Root
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.TreeNode>("getRoot", "()Ljavax/swing/tree/TreeNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getSiblingCount()"/> 
        /// </summary>
        public int SiblingCount
        {
            get { return IExecuteWithSignature<int>("getSiblingCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getUserObject()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#setUserObject(java.lang.Object)"/>
        /// </summary>
        public object UserObject
        {
            get { return IExecuteWithSignature("getUserObject", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setUserObject", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getUserObjectPath()"/> 
        /// </summary>
        public object[] UserObjectPath
        {
            get { return IExecuteWithSignatureArray<object>("getUserObjectPath", "()[Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#isLeaf()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLeaf()
        {
            return IExecuteWithSignature<bool>("isLeaf", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#isNodeAncestor(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNodeAncestor(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecuteWithSignature<bool>("isNodeAncestor", "(Ljavax/swing/tree/TreeNode;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#isNodeChild(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNodeChild(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecuteWithSignature<bool>("isNodeChild", "(Ljavax/swing/tree/TreeNode;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#isNodeDescendant(javax.swing.tree.DefaultMutableTreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.DefaultMutableTreeNode"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNodeDescendant(Javax.Swing.Tree.DefaultMutableTreeNode arg0)
        {
            return IExecuteWithSignature<bool>("isNodeDescendant", "(Ljavax/swing/tree/DefaultMutableTreeNode;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#isNodeRelated(javax.swing.tree.DefaultMutableTreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.DefaultMutableTreeNode"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNodeRelated(Javax.Swing.Tree.DefaultMutableTreeNode arg0)
        {
            return IExecuteWithSignature<bool>("isNodeRelated", "(Ljavax/swing/tree/DefaultMutableTreeNode;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#isNodeSibling(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNodeSibling(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecuteWithSignature<bool>("isNodeSibling", "(Ljavax/swing/tree/TreeNode;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#isRoot()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsRoot()
        {
            return IExecuteWithSignature<bool>("isRoot", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getIndex(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetIndex(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecuteWithSignature<int>("getIndex", "(Ljavax/swing/tree/TreeNode;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#breadthFirstEnumeration()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Javax.Swing.Tree.TreeNode> BreadthFirstEnumerationMethod()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Javax.Swing.Tree.TreeNode>>("breadthFirstEnumeration", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#children()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Javax.Swing.Tree.TreeNode> Children()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Javax.Swing.Tree.TreeNode>>("children", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#depthFirstEnumeration()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Javax.Swing.Tree.TreeNode> DepthFirstEnumeration()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Javax.Swing.Tree.TreeNode>>("depthFirstEnumeration", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#pathFromAncestorEnumeration(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Javax.Swing.Tree.TreeNode> PathFromAncestorEnumeration(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Javax.Swing.Tree.TreeNode>>("pathFromAncestorEnumeration", "(Ljavax/swing/tree/TreeNode;)Ljava/util/Enumeration;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#postorderEnumeration()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Javax.Swing.Tree.TreeNode> PostorderEnumerationMethod()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Javax.Swing.Tree.TreeNode>>("postorderEnumeration", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#preorderEnumeration()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Javax.Swing.Tree.TreeNode> PreorderEnumerationMethod()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Javax.Swing.Tree.TreeNode>>("preorderEnumeration", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getChildAfter(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreeNode"/></returns>
        public Javax.Swing.Tree.TreeNode GetChildAfter(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Tree.TreeNode>("getChildAfter", "(Ljavax/swing/tree/TreeNode;)Ljavax/swing/tree/TreeNode;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getChildAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreeNode"/></returns>
        public Javax.Swing.Tree.TreeNode GetChildAt(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Tree.TreeNode>("getChildAt", "(I)Ljavax/swing/tree/TreeNode;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getChildBefore(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreeNode"/></returns>
        public Javax.Swing.Tree.TreeNode GetChildBefore(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Tree.TreeNode>("getChildBefore", "(Ljavax/swing/tree/TreeNode;)Ljavax/swing/tree/TreeNode;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getSharedAncestor(javax.swing.tree.DefaultMutableTreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.DefaultMutableTreeNode"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreeNode"/></returns>
        public Javax.Swing.Tree.TreeNode GetSharedAncestor(Javax.Swing.Tree.DefaultMutableTreeNode arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Tree.TreeNode>("getSharedAncestor", "(Ljavax/swing/tree/DefaultMutableTreeNode;)Ljavax/swing/tree/TreeNode;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#add(javax.swing.tree.MutableTreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.MutableTreeNode"/></param>
        public void Add(Javax.Swing.Tree.MutableTreeNode arg0)
        {
            IExecuteWithSignature("add", "(Ljavax/swing/tree/MutableTreeNode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#insert(javax.swing.tree.MutableTreeNode,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.MutableTreeNode"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Insert(Javax.Swing.Tree.MutableTreeNode arg0, int arg1)
        {
            IExecute("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Remove(int arg0)
        {
            IExecuteWithSignature("remove", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#remove(javax.swing.tree.MutableTreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.MutableTreeNode"/></param>
        public void Remove(Javax.Swing.Tree.MutableTreeNode arg0)
        {
            IExecuteWithSignature("remove", "(Ljavax/swing/tree/MutableTreeNode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#removeAllChildren()"/>
        /// </summary>
        public void RemoveAllChildren()
        {
            IExecuteWithSignature("removeAllChildren", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#removeFromParent()"/>
        /// </summary>
        public void RemoveFromParent()
        {
            IExecuteWithSignature("removeFromParent", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}