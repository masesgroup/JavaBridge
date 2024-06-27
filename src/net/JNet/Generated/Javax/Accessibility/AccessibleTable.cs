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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Accessibility
{
    #region IAccessibleTable
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAccessibleTable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleCaption()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleCaption(javax.accessibility.Accessible)"/>
        /// </summary>
        Javax.Accessibility.Accessible AccessibleCaption { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleColumnCount()"/> 
        /// </summary>
        int AccessibleColumnCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleColumnHeader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleColumnHeader(javax.accessibility.AccessibleTable)"/>
        /// </summary>
        Javax.Accessibility.AccessibleTable AccessibleColumnHeader { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleRowCount()"/> 
        /// </summary>
        int AccessibleRowCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleRowHeader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleRowHeader(javax.accessibility.AccessibleTable)"/>
        /// </summary>
        Javax.Accessibility.AccessibleTable AccessibleRowHeader { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleSummary()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleSummary(javax.accessibility.Accessible)"/>
        /// </summary>
        Javax.Accessibility.Accessible AccessibleSummary { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getSelectedAccessibleColumns()"/> 
        /// </summary>
        int[] SelectedAccessibleColumns { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getSelectedAccessibleRows()"/> 
        /// </summary>
        int[] SelectedAccessibleRows { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#isAccessibleColumnSelected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsAccessibleColumnSelected(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#isAccessibleRowSelected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsAccessibleRowSelected(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#isAccessibleSelected(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsAccessibleSelected(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleColumnExtentAt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        int GetAccessibleColumnExtentAt(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleRowExtentAt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        int GetAccessibleRowExtentAt(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleAt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Accessibility.Accessible"/></returns>
        Javax.Accessibility.Accessible GetAccessibleAt(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleColumnDescription(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Accessibility.Accessible"/></returns>
        Javax.Accessibility.Accessible GetAccessibleColumnDescription(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleRowDescription(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Accessibility.Accessible"/></returns>
        Javax.Accessibility.Accessible GetAccessibleRowDescription(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleColumnDescription(int,javax.accessibility.Accessible)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Accessibility.Accessible"/></param>
        void SetAccessibleColumnDescription(int arg0, Javax.Accessibility.Accessible arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleRowDescription(int,javax.accessibility.Accessible)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Accessibility.Accessible"/></param>
        void SetAccessibleRowDescription(int arg0, Javax.Accessibility.Accessible arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AccessibleTable
    public partial class AccessibleTable : Javax.Accessibility.IAccessibleTable
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleCaption()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleCaption(javax.accessibility.Accessible)"/>
        /// </summary>
        public Javax.Accessibility.Accessible AccessibleCaption
        {
            get { return IExecuteWithSignature<Javax.Accessibility.Accessible>("getAccessibleCaption", "()Ljavax/accessibility/Accessible;"); } set { IExecuteWithSignature("setAccessibleCaption", "(Ljavax/accessibility/Accessible;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleColumnCount()"/> 
        /// </summary>
        public int AccessibleColumnCount
        {
            get { return IExecuteWithSignature<int>("getAccessibleColumnCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleColumnHeader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleColumnHeader(javax.accessibility.AccessibleTable)"/>
        /// </summary>
        public Javax.Accessibility.AccessibleTable AccessibleColumnHeader
        {
            get { return IExecuteWithSignature<Javax.Accessibility.AccessibleTable>("getAccessibleColumnHeader", "()Ljavax/accessibility/AccessibleTable;"); } set { IExecuteWithSignature("setAccessibleColumnHeader", "(Ljavax/accessibility/AccessibleTable;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleRowCount()"/> 
        /// </summary>
        public int AccessibleRowCount
        {
            get { return IExecuteWithSignature<int>("getAccessibleRowCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleRowHeader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleRowHeader(javax.accessibility.AccessibleTable)"/>
        /// </summary>
        public Javax.Accessibility.AccessibleTable AccessibleRowHeader
        {
            get { return IExecuteWithSignature<Javax.Accessibility.AccessibleTable>("getAccessibleRowHeader", "()Ljavax/accessibility/AccessibleTable;"); } set { IExecuteWithSignature("setAccessibleRowHeader", "(Ljavax/accessibility/AccessibleTable;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleSummary()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleSummary(javax.accessibility.Accessible)"/>
        /// </summary>
        public Javax.Accessibility.Accessible AccessibleSummary
        {
            get { return IExecuteWithSignature<Javax.Accessibility.Accessible>("getAccessibleSummary", "()Ljavax/accessibility/Accessible;"); } set { IExecuteWithSignature("setAccessibleSummary", "(Ljavax/accessibility/Accessible;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getSelectedAccessibleColumns()"/> 
        /// </summary>
        public int[] SelectedAccessibleColumns
        {
            get { return IExecuteWithSignatureArray<int>("getSelectedAccessibleColumns", "()[I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getSelectedAccessibleRows()"/> 
        /// </summary>
        public int[] SelectedAccessibleRows
        {
            get { return IExecuteWithSignatureArray<int>("getSelectedAccessibleRows", "()[I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#isAccessibleColumnSelected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAccessibleColumnSelected(int arg0)
        {
            return IExecuteWithSignature<bool>("isAccessibleColumnSelected", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#isAccessibleRowSelected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAccessibleRowSelected(int arg0)
        {
            return IExecuteWithSignature<bool>("isAccessibleRowSelected", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#isAccessibleSelected(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAccessibleSelected(int arg0, int arg1)
        {
            return IExecute<bool>("isAccessibleSelected", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleColumnExtentAt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAccessibleColumnExtentAt(int arg0, int arg1)
        {
            return IExecute<int>("getAccessibleColumnExtentAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleRowExtentAt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAccessibleRowExtentAt(int arg0, int arg1)
        {
            return IExecute<int>("getAccessibleRowExtentAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleAt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Accessibility.Accessible"/></returns>
        public Javax.Accessibility.Accessible GetAccessibleAt(int arg0, int arg1)
        {
            return IExecute<Javax.Accessibility.Accessible>("getAccessibleAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleColumnDescription(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Accessibility.Accessible"/></returns>
        public Javax.Accessibility.Accessible GetAccessibleColumnDescription(int arg0)
        {
            return IExecuteWithSignature<Javax.Accessibility.Accessible>("getAccessibleColumnDescription", "(I)Ljavax/accessibility/Accessible;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleRowDescription(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Accessibility.Accessible"/></returns>
        public Javax.Accessibility.Accessible GetAccessibleRowDescription(int arg0)
        {
            return IExecuteWithSignature<Javax.Accessibility.Accessible>("getAccessibleRowDescription", "(I)Ljavax/accessibility/Accessible;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleColumnDescription(int,javax.accessibility.Accessible)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Accessibility.Accessible"/></param>
        public void SetAccessibleColumnDescription(int arg0, Javax.Accessibility.Accessible arg1)
        {
            IExecute("setAccessibleColumnDescription", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleRowDescription(int,javax.accessibility.Accessible)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Accessibility.Accessible"/></param>
        public void SetAccessibleRowDescription(int arg0, Javax.Accessibility.Accessible arg1)
        {
            IExecute("setAccessibleRowDescription", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}