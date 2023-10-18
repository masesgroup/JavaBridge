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

namespace Javax.Swing.Plaf.Basic
{
    #region BasicTreeUI
    public partial class BasicTreeUI
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#getCollapsedIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#setCollapsedIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon CollapsedIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getCollapsedIcon"); } set { IExecute("setCollapsedIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#getExpandedIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#setExpandedIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon ExpandedIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getExpandedIcon"); } set { IExecute("setExpandedIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#getLeftChildIndent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#setLeftChildIndent(int)"/>
        /// </summary>
        public int LeftChildIndent
        {
            get { return IExecute<int>("getLeftChildIndent"); } set { IExecute("setLeftChildIndent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#getPreferredMinSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#setPreferredMinSize(java.awt.Dimension)"/>
        /// </summary>
        public Java.Awt.Dimension PreferredMinSize
        {
            get { return IExecute<Java.Awt.Dimension>("getPreferredMinSize"); } set { IExecute("setPreferredMinSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#getRightChildIndent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#setRightChildIndent(int)"/>
        /// </summary>
        public int RightChildIndent
        {
            get { return IExecute<int>("getRightChildIndent"); } set { IExecute("setRightChildIndent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#getPreferredSize(javax.swing.JComponent,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension GetPreferredSize(Javax.Swing.JComponent arg0, bool arg1)
        {
            return IExecute<Java.Awt.Dimension>("getPreferredSize", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region CellEditorHandler
        public partial class CellEditorHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.CellEditorHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            public CellEditorHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicTreeUI.CellEditorHandler"/> to <see cref="Javax.Swing.Event.CellEditorListener"/>
            /// </summary>
            public static implicit operator Javax.Swing.Event.CellEditorListener(Javax.Swing.Plaf.Basic.BasicTreeUI.CellEditorHandler t) => t.Cast<Javax.Swing.Event.CellEditorListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.CellEditorHandler.html#editingCanceled(javax.swing.event.ChangeEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
            public void EditingCanceled(Javax.Swing.Event.ChangeEvent arg0)
            {
                IExecute("editingCanceled", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.CellEditorHandler.html#editingStopped(javax.swing.event.ChangeEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
            public void EditingStopped(Javax.Swing.Event.ChangeEvent arg0)
            {
                IExecute("editingStopped", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region FocusHandler
        public partial class FocusHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.FocusHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            public FocusHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicTreeUI.FocusHandler"/> to <see cref="Java.Awt.EventNs.FocusListener"/>
            /// </summary>
            public static implicit operator Java.Awt.EventNs.FocusListener(Javax.Swing.Plaf.Basic.BasicTreeUI.FocusHandler t) => t.Cast<Java.Awt.EventNs.FocusListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.FocusHandler.html#focusGained(java.awt.event.FocusEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
            public void FocusGained(Java.Awt.EventNs.FocusEvent arg0)
            {
                IExecute("focusGained", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.FocusHandler.html#focusLost(java.awt.event.FocusEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
            public void FocusLost(Java.Awt.EventNs.FocusEvent arg0)
            {
                IExecute("focusLost", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region MouseInputHandler
        public partial class MouseInputHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI,java.awt.Component,java.awt.Component,java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
            /// <param name="arg3"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public MouseInputHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0, Java.Awt.Component arg1, Java.Awt.Component arg2, Java.Awt.EventNs.MouseEvent arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicTreeUI.MouseInputHandler"/> to <see cref="Javax.Swing.Event.MouseInputListener"/>
            /// </summary>
            public static implicit operator Javax.Swing.Event.MouseInputListener(Javax.Swing.Plaf.Basic.BasicTreeUI.MouseInputHandler t) => t.Cast<Javax.Swing.Event.MouseInputListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#mouseClicked(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseClicked(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseClicked", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#mouseDragged(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseDragged(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseDragged", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#mouseEntered(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseEntered(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseEntered", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#mouseExited(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseExited(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseExited", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#mouseMoved(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseMoved(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseMoved", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#mousePressed(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MousePressed(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mousePressed", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#mouseReleased(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseReleased(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseReleased", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region NodeDimensionsHandler
        public partial class NodeDimensionsHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.NodeDimensionsHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            public NodeDimensionsHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region PropertyChangeHandler
        public partial class PropertyChangeHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.PropertyChangeHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            public PropertyChangeHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicTreeUI.PropertyChangeHandler"/> to <see cref="Java.Beans.PropertyChangeListener"/>
            /// </summary>
            public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Plaf.Basic.BasicTreeUI.PropertyChangeHandler t) => t.Cast<Java.Beans.PropertyChangeListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.PropertyChangeHandler.html#propertyChange(java.beans.PropertyChangeEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
            public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
            {
                IExecute("propertyChange", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SelectionModelPropertyChangeHandler
        public partial class SelectionModelPropertyChangeHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.SelectionModelPropertyChangeHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            public SelectionModelPropertyChangeHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicTreeUI.SelectionModelPropertyChangeHandler"/> to <see cref="Java.Beans.PropertyChangeListener"/>
            /// </summary>
            public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Plaf.Basic.BasicTreeUI.SelectionModelPropertyChangeHandler t) => t.Cast<Java.Beans.PropertyChangeListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.SelectionModelPropertyChangeHandler.html#propertyChange(java.beans.PropertyChangeEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
            public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
            {
                IExecute("propertyChange", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeCancelEditingAction
        public partial class TreeCancelEditingAction
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeCancelEditingAction.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            public TreeCancelEditingAction(Javax.Swing.Plaf.Basic.BasicTreeUI arg0, string arg1)
                : base(arg0, arg1)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeExpansionHandler
        public partial class TreeExpansionHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeExpansionHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            public TreeExpansionHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicTreeUI.TreeExpansionHandler"/> to <see cref="Javax.Swing.Event.TreeExpansionListener"/>
            /// </summary>
            public static implicit operator Javax.Swing.Event.TreeExpansionListener(Javax.Swing.Plaf.Basic.BasicTreeUI.TreeExpansionHandler t) => t.Cast<Javax.Swing.Event.TreeExpansionListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeExpansionHandler.html#treeCollapsed(javax.swing.event.TreeExpansionEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.TreeExpansionEvent"/></param>
            public void TreeCollapsed(Javax.Swing.Event.TreeExpansionEvent arg0)
            {
                IExecute("treeCollapsed", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeExpansionHandler.html#treeExpanded(javax.swing.event.TreeExpansionEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.TreeExpansionEvent"/></param>
            public void TreeExpanded(Javax.Swing.Event.TreeExpansionEvent arg0)
            {
                IExecute("treeExpanded", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeHomeAction
        public partial class TreeHomeAction
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeHomeAction.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI,int,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="string"/></param>
            public TreeHomeAction(Javax.Swing.Plaf.Basic.BasicTreeUI arg0, int arg1, string arg2)
                : base(arg0, arg1, arg2)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeIncrementAction
        public partial class TreeIncrementAction
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeIncrementAction.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI,int,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="string"/></param>
            public TreeIncrementAction(Javax.Swing.Plaf.Basic.BasicTreeUI arg0, int arg1, string arg2)
                : base(arg0, arg1, arg2)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeModelHandler
        public partial class TreeModelHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeModelHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            public TreeModelHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicTreeUI.TreeModelHandler"/> to <see cref="Javax.Swing.Event.TreeModelListener"/>
            /// </summary>
            public static implicit operator Javax.Swing.Event.TreeModelListener(Javax.Swing.Plaf.Basic.BasicTreeUI.TreeModelHandler t) => t.Cast<Javax.Swing.Event.TreeModelListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeModelHandler.html#treeNodesChanged(javax.swing.event.TreeModelEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
            public void TreeNodesChanged(Javax.Swing.Event.TreeModelEvent arg0)
            {
                IExecute("treeNodesChanged", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeModelHandler.html#treeNodesInserted(javax.swing.event.TreeModelEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
            public void TreeNodesInserted(Javax.Swing.Event.TreeModelEvent arg0)
            {
                IExecute("treeNodesInserted", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeModelHandler.html#treeNodesRemoved(javax.swing.event.TreeModelEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
            public void TreeNodesRemoved(Javax.Swing.Event.TreeModelEvent arg0)
            {
                IExecute("treeNodesRemoved", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeModelHandler.html#treeStructureChanged(javax.swing.event.TreeModelEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
            public void TreeStructureChanged(Javax.Swing.Event.TreeModelEvent arg0)
            {
                IExecute("treeStructureChanged", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreePageAction
        public partial class TreePageAction
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreePageAction.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI,int,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="string"/></param>
            public TreePageAction(Javax.Swing.Plaf.Basic.BasicTreeUI arg0, int arg1, string arg2)
                : base(arg0, arg1, arg2)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeSelectionHandler
        public partial class TreeSelectionHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeSelectionHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            public TreeSelectionHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicTreeUI.TreeSelectionHandler"/> to <see cref="Javax.Swing.Event.TreeSelectionListener"/>
            /// </summary>
            public static implicit operator Javax.Swing.Event.TreeSelectionListener(Javax.Swing.Plaf.Basic.BasicTreeUI.TreeSelectionHandler t) => t.Cast<Javax.Swing.Event.TreeSelectionListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeSelectionHandler.html#valueChanged(javax.swing.event.TreeSelectionEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.TreeSelectionEvent"/></param>
            public void ValueChanged(Javax.Swing.Event.TreeSelectionEvent arg0)
            {
                IExecute("valueChanged", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeToggleAction
        public partial class TreeToggleAction
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeToggleAction.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            public TreeToggleAction(Javax.Swing.Plaf.Basic.BasicTreeUI arg0, string arg1)
                : base(arg0, arg1)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeTraverseAction
        public partial class TreeTraverseAction
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeTraverseAction.html#%3Cinit%3E(javax.swing.plaf.basic.BasicTreeUI,int,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicTreeUI"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="string"/></param>
            public TreeTraverseAction(Javax.Swing.Plaf.Basic.BasicTreeUI arg0, int arg1, string arg2)
                : base(arg0, arg1, arg2)
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