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

namespace Javax.Swing.Plaf
{
    #region TreeUI declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TreeUI.html"/>
    /// </summary>
    public partial class TreeUI : Javax.Swing.Plaf.ComponentUI
    {
        const string _bridgeClassName = "javax.swing.plaf.TreeUI";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("TreeUI class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TreeUI() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("TreeUI class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TreeUI(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region TreeUI implementation
    public partial class TreeUI
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TreeUI.html#isEditing(javax.swing.JTree)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEditing(Javax.Swing.JTree arg0)
        {
            return IExecuteWithSignature<bool>("isEditing", "(Ljavax/swing/JTree;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TreeUI.html#stopEditing(javax.swing.JTree)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool StopEditing(Javax.Swing.JTree arg0)
        {
            return IExecuteWithSignature<bool>("stopEditing", "(Ljavax/swing/JTree;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TreeUI.html#getRowCount(javax.swing.JTree)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRowCount(Javax.Swing.JTree arg0)
        {
            return IExecuteWithSignature<int>("getRowCount", "(Ljavax/swing/JTree;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TreeUI.html#getRowForPath(javax.swing.JTree,javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRowForPath(Javax.Swing.JTree arg0, Javax.Swing.Tree.TreePath arg1)
        {
            return IExecuteWithSignature<int>("getRowForPath", "(Ljavax/swing/JTree;Ljavax/swing/tree/TreePath;)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TreeUI.html#getPathBounds(javax.swing.JTree,javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public Java.Awt.Rectangle GetPathBounds(Javax.Swing.JTree arg0, Javax.Swing.Tree.TreePath arg1)
        {
            return IExecuteWithSignature<Java.Awt.Rectangle>("getPathBounds", "(Ljavax/swing/JTree;Ljavax/swing/tree/TreePath;)Ljava/awt/Rectangle;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TreeUI.html#getClosestPathForLocation(javax.swing.JTree,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreePath"/></returns>
        public Javax.Swing.Tree.TreePath GetClosestPathForLocation(Javax.Swing.JTree arg0, int arg1, int arg2)
        {
            return IExecuteWithSignature<Javax.Swing.Tree.TreePath>("getClosestPathForLocation", "(Ljavax/swing/JTree;II)Ljavax/swing/tree/TreePath;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TreeUI.html#getEditingPath(javax.swing.JTree)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreePath"/></returns>
        public Javax.Swing.Tree.TreePath GetEditingPath(Javax.Swing.JTree arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Tree.TreePath>("getEditingPath", "(Ljavax/swing/JTree;)Ljavax/swing/tree/TreePath;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TreeUI.html#getPathForRow(javax.swing.JTree,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreePath"/></returns>
        public Javax.Swing.Tree.TreePath GetPathForRow(Javax.Swing.JTree arg0, int arg1)
        {
            return IExecuteWithSignature<Javax.Swing.Tree.TreePath>("getPathForRow", "(Ljavax/swing/JTree;I)Ljavax/swing/tree/TreePath;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TreeUI.html#cancelEditing(javax.swing.JTree)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        public void CancelEditing(Javax.Swing.JTree arg0)
        {
            IExecuteWithSignature("cancelEditing", "(Ljavax/swing/JTree;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TreeUI.html#startEditingAtPath(javax.swing.JTree,javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void StartEditingAtPath(Javax.Swing.JTree arg0, Javax.Swing.Tree.TreePath arg1)
        {
            IExecuteWithSignature("startEditingAtPath", "(Ljavax/swing/JTree;Ljavax/swing/tree/TreePath;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}