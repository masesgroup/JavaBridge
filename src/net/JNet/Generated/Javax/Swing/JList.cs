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

namespace Javax.Swing
{
    #region JList
    public partial class JList
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JList"/> to <see cref="Javax.Swing.Scrollable"/>
        /// </summary>
        public static implicit operator Javax.Swing.Scrollable(Javax.Swing.JList t) => t.Cast<Javax.Swing.Scrollable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JList"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JList t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#HORIZONTAL_WRAP"/>
        /// </summary>
        public static int HORIZONTAL_WRAP => Clazz.GetField<int>("HORIZONTAL_WRAP");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#VERTICAL"/>
        /// </summary>
        public static int VERTICAL => Clazz.GetField<int>("VERTICAL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#VERTICAL_WRAP"/>
        /// </summary>
        public static int VERTICAL_WRAP => Clazz.GetField<int>("VERTICAL_WRAP");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getAnchorSelectionIndex()"/> 
        /// </summary>
        public int AnchorSelectionIndex
        {
            get { return IExecute<int>("getAnchorSelectionIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getDragEnabled()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setDragEnabled(boolean)"/>
        /// </summary>
        public bool DragEnabled
        {
            get { return IExecute<bool>("getDragEnabled"); } set { IExecute("setDragEnabled", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getFirstVisibleIndex()"/> 
        /// </summary>
        public int FirstVisibleIndex
        {
            get { return IExecute<int>("getFirstVisibleIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getFixedCellHeight()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setFixedCellHeight(int)"/>
        /// </summary>
        public int FixedCellHeight
        {
            get { return IExecute<int>("getFixedCellHeight"); } set { IExecute("setFixedCellHeight", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getFixedCellWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setFixedCellWidth(int)"/>
        /// </summary>
        public int FixedCellWidth
        {
            get { return IExecute<int>("getFixedCellWidth"); } set { IExecute("setFixedCellWidth", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getLastVisibleIndex()"/> 
        /// </summary>
        public int LastVisibleIndex
        {
            get { return IExecute<int>("getLastVisibleIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getLayoutOrientation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setLayoutOrientation(int)"/>
        /// </summary>
        public int LayoutOrientation
        {
            get { return IExecute<int>("getLayoutOrientation"); } set { IExecute("setLayoutOrientation", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getLeadSelectionIndex()"/> 
        /// </summary>
        public int LeadSelectionIndex
        {
            get { return IExecute<int>("getLeadSelectionIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getListSelectionListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ListSelectionListener[] ListSelectionListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.ListSelectionListener>("getListSelectionListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getMaxSelectionIndex()"/> 
        /// </summary>
        public int MaxSelectionIndex
        {
            get { return IExecute<int>("getMaxSelectionIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getMinSelectionIndex()"/> 
        /// </summary>
        public int MinSelectionIndex
        {
            get { return IExecute<int>("getMinSelectionIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getPreferredScrollableViewportSize()"/> 
        /// </summary>
        public Java.Awt.Dimension PreferredScrollableViewportSize
        {
            get { return IExecute<Java.Awt.Dimension>("getPreferredScrollableViewportSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getPrototypeCellValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setPrototypeCellValue(E)"/>
        /// </summary>
        public object PrototypeCellValue
        {
            get { return IExecute("getPrototypeCellValue"); } set { IExecute("setPrototypeCellValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getScrollableTracksViewportHeight()"/> 
        /// </summary>
        public bool ScrollableTracksViewportHeight
        {
            get { return IExecute<bool>("getScrollableTracksViewportHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getScrollableTracksViewportWidth()"/> 
        /// </summary>
        public bool ScrollableTracksViewportWidth
        {
            get { return IExecute<bool>("getScrollableTracksViewportWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getSelectedIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setSelectedIndex(int)"/>
        /// </summary>
        public int SelectedIndex
        {
            get { return IExecute<int>("getSelectedIndex"); } set { IExecute("setSelectedIndex", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getSelectedIndices()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setSelectedIndices(int[])"/>
        /// </summary>
        public int[] SelectedIndices
        {
            get { return IExecuteArray<int>("getSelectedIndices"); } set { IExecute("setSelectedIndices", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getSelectedValue()"/> 
        /// </summary>
        public object SelectedValue
        {
            get { return IExecute("getSelectedValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getSelectionBackground()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setSelectionBackground(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color SelectionBackground
        {
            get { return IExecute<Java.Awt.Color>("getSelectionBackground"); } set { IExecute("setSelectionBackground", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getSelectionForeground()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setSelectionForeground(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color SelectionForeground
        {
            get { return IExecute<Java.Awt.Color>("getSelectionForeground"); } set { IExecute("setSelectionForeground", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getSelectionMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setSelectionMode(int)"/>
        /// </summary>
        public int SelectionMode
        {
            get { return IExecute<int>("getSelectionMode"); } set { IExecute("setSelectionMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getSelectionModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setSelectionModel(javax.swing.ListSelectionModel)"/>
        /// </summary>
        public Javax.Swing.ListSelectionModel SelectionModel
        {
            get { return IExecute<Javax.Swing.ListSelectionModel>("getSelectionModel"); } set { IExecute("setSelectionModel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getValueIsAdjusting()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setValueIsAdjusting(boolean)"/>
        /// </summary>
        public bool ValueIsAdjusting
        {
            get { return IExecute<bool>("getValueIsAdjusting"); } set { IExecute("setValueIsAdjusting", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getVisibleRowCount()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setVisibleRowCount(int)"/>
        /// </summary>
        public int VisibleRowCount
        {
            get { return IExecute<int>("getVisibleRowCount"); } set { IExecute("setVisibleRowCount", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#isSelectedIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsSelectedIndex(int arg0)
        {
            return IExecute<bool>("isSelectedIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#isSelectionEmpty()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsSelectionEmpty()
        {
            return IExecute<bool>("isSelectionEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getNextMatch(java.lang.String,int,javax.swing.text.Position$Bias)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetNextMatch(string arg0, int arg1, Javax.Swing.Text.Position.Bias arg2)
        {
            return IExecute<int>("getNextMatch", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getScrollableBlockIncrement(java.awt.Rectangle,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetScrollableBlockIncrement(Java.Awt.Rectangle arg0, int arg1, int arg2)
        {
            return IExecute<int>("getScrollableBlockIncrement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getScrollableUnitIncrement(java.awt.Rectangle,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetScrollableUnitIncrement(Java.Awt.Rectangle arg0, int arg1, int arg2)
        {
            return IExecute<int>("getScrollableUnitIncrement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#locationToIndex(java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Point"/></param>
        /// <returns><see langword="int"/></returns>
        public int LocationToIndex(Java.Awt.Point arg0)
        {
            return IExecute<int>("locationToIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#indexToLocation(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Awt.Point"/></returns>
        public Java.Awt.Point IndexToLocation(int arg0)
        {
            return IExecute<Java.Awt.Point>("indexToLocation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#getCellBounds(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public Java.Awt.Rectangle GetCellBounds(int arg0, int arg1)
        {
            return IExecute<Java.Awt.Rectangle>("getCellBounds", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#addListSelectionListener(javax.swing.event.ListSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionListener"/></param>
        public void AddListSelectionListener(Javax.Swing.Event.ListSelectionListener arg0)
        {
            IExecute("addListSelectionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#addSelectionInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        public void AddSelectionInterval(int arg0, int arg1)
        {
            IExecute("addSelectionInterval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#clearSelection()"/>
        /// </summary>
        public void ClearSelection()
        {
            IExecute("clearSelection");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#ensureIndexIsVisible(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        public void EnsureIndexIsVisible(int arg0)
        {
            IExecute("ensureIndexIsVisible", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#removeListSelectionListener(javax.swing.event.ListSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionListener"/></param>
        public void RemoveListSelectionListener(Javax.Swing.Event.ListSelectionListener arg0)
        {
            IExecute("removeListSelectionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#removeSelectionInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        public void RemoveSelectionInterval(int arg0, int arg1)
        {
            IExecute("removeSelectionInterval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setSelectedValue(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see langword="bool"/></param>
        public void SetSelectedValue(object arg0, bool arg1)
        {
            IExecute("setSelectedValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setSelectionInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        public void SetSelectionInterval(int arg0, int arg1)
        {
            IExecute("setSelectionInterval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.html#setUI(javax.swing.plaf.ListUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.ListUI"/></param>
        public void SetUI(Javax.Swing.Plaf.ListUI arg0)
        {
            IExecute("setUI", arg0);
        }
        
        #endregion

        #region Nested classes
        #region DropLocation
        public partial class DropLocation
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.DropLocation.html#getIndex()"/> 
            /// </summary>
            public int Index
            {
                get { return IExecute<int>("getIndex"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JList.DropLocation.html#isInsert()"/>
            /// </summary>
            
            /// <returns><see langword="bool"/></returns>
            public bool IsInsert()
            {
                return IExecute<bool>("isInsert");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}