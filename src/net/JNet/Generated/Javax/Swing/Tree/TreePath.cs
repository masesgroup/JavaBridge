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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Tree
{
    #region TreePath
    public partial class TreePath
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreePath.html#%3Cinit%3E(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public TreePath(object arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreePath.html#getLastPathComponent()"/> 
        /// </summary>
        public object LastPathComponent
        {
            get { return IExecute("getLastPathComponent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreePath.html#getParentPath()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreePath ParentPath
        {
            get { return IExecute<Javax.Swing.Tree.TreePath>("getParentPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreePath.html#getPath()"/> 
        /// </summary>
        public object[] Path
        {
            get { return IExecuteArray<object>("getPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreePath.html#getPathCount()"/> 
        /// </summary>
        public int PathCount
        {
            get { return IExecute<int>("getPathCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreePath.html#isDescendant(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDescendant(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecute<bool>("isDescendant", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreePath.html#getPathComponent(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetPathComponent(int arg0)
        {
            return IExecute("getPathComponent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreePath.html#pathByAddingChild(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreePath"/></returns>
        public Javax.Swing.Tree.TreePath PathByAddingChild(object arg0)
        {
            return IExecute<Javax.Swing.Tree.TreePath>("pathByAddingChild", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}