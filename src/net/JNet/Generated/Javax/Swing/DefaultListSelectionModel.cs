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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region DefaultListSelectionModel
    public partial class DefaultListSelectionModel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultListSelectionModel"/> to <see cref="Javax.Swing.ListSelectionModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.ListSelectionModel(Javax.Swing.DefaultListSelectionModel t) => t.Cast<Javax.Swing.ListSelectionModel>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultListSelectionModel"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Swing.DefaultListSelectionModel t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultListSelectionModel"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.DefaultListSelectionModel t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#getAnchorSelectionIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#setAnchorSelectionIndex(int)"/>
        /// </summary>
        public int AnchorSelectionIndex
        {
            get { return IExecute<int>("getAnchorSelectionIndex"); } set { IExecute("setAnchorSelectionIndex", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#getLeadSelectionIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#setLeadSelectionIndex(int)"/>
        /// </summary>
        public int LeadSelectionIndex
        {
            get { return IExecute<int>("getLeadSelectionIndex"); } set { IExecute("setLeadSelectionIndex", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#getListSelectionListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ListSelectionListener[] ListSelectionListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.ListSelectionListener>("getListSelectionListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#getMaxSelectionIndex()"/> 
        /// </summary>
        public int MaxSelectionIndex
        {
            get { return IExecute<int>("getMaxSelectionIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#getMinSelectionIndex()"/> 
        /// </summary>
        public int MinSelectionIndex
        {
            get { return IExecute<int>("getMinSelectionIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#getSelectionMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#setSelectionMode(int)"/>
        /// </summary>
        public int SelectionMode
        {
            get { return IExecute<int>("getSelectionMode"); } set { IExecute("setSelectionMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#getValueIsAdjusting()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#setValueIsAdjusting(boolean)"/>
        /// </summary>
        public bool ValueIsAdjusting
        {
            get { return IExecute<bool>("getValueIsAdjusting"); } set { IExecute("setValueIsAdjusting", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#isLeadAnchorNotificationEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLeadAnchorNotificationEnabled()
        {
            return IExecute<bool>("isLeadAnchorNotificationEnabled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#isSelectedIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSelectedIndex(int arg0)
        {
            return IExecute<bool>("isSelectedIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#isSelectionEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSelectionEmpty()
        {
            return IExecute<bool>("isSelectionEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#addListSelectionListener(javax.swing.event.ListSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionListener"/></param>
        public void AddListSelectionListener(Javax.Swing.Event.ListSelectionListener arg0)
        {
            IExecute("addListSelectionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#addSelectionInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void AddSelectionInterval(int arg0, int arg1)
        {
            IExecute("addSelectionInterval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#clearSelection()"/>
        /// </summary>
        public void ClearSelection()
        {
            IExecute("clearSelection");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#insertIndexInterval(int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void InsertIndexInterval(int arg0, int arg1, bool arg2)
        {
            IExecute("insertIndexInterval", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#moveLeadSelectionIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void MoveLeadSelectionIndex(int arg0)
        {
            IExecute("moveLeadSelectionIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#removeIndexInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RemoveIndexInterval(int arg0, int arg1)
        {
            IExecute("removeIndexInterval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#removeListSelectionListener(javax.swing.event.ListSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionListener"/></param>
        public void RemoveListSelectionListener(Javax.Swing.Event.ListSelectionListener arg0)
        {
            IExecute("removeListSelectionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#removeSelectionInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RemoveSelectionInterval(int arg0, int arg1)
        {
            IExecute("removeSelectionInterval", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#setLeadAnchorNotificationEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetLeadAnchorNotificationEnabled(bool arg0)
        {
            IExecute("setLeadAnchorNotificationEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListSelectionModel.html#setSelectionInterval(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetSelectionInterval(int arg0, int arg1)
        {
            IExecute("setSelectionInterval", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}