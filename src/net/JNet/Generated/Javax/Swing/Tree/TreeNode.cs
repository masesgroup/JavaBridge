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
    #region TreeNode
    public partial class TreeNode
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getAllowsChildren()"/> 
        /// </summary>
        public bool AllowsChildren
        {
            get { return IExecute<bool>("getAllowsChildren"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getChildCount()"/> 
        /// </summary>
        public int ChildCount
        {
            get { return IExecute<int>("getChildCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getParent()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreeNode Parent
        {
            get { return IExecute<Javax.Swing.Tree.TreeNode>("getParent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#isLeaf()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsLeaf()
        {
            return IExecute<bool>("isLeaf");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getIndex(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetIndex(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecute<int>("getIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getChildAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreeNode"/></returns>
        public Javax.Swing.Tree.TreeNode GetChildAt(int arg0)
        {
            return IExecute<Javax.Swing.Tree.TreeNode>("getChildAt", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}