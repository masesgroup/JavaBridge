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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Accessibility
{
    #region AccessibleTable
    public partial class AccessibleTable
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
            get { return IExecute<Javax.Accessibility.Accessible>("getAccessibleCaption"); } set { IExecute("setAccessibleCaption", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleColumnCount()"/> 
        /// </summary>
        public int AccessibleColumnCount
        {
            get { return IExecute<int>("getAccessibleColumnCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleColumnHeader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleColumnHeader(javax.accessibility.AccessibleTable)"/>
        /// </summary>
        public Javax.Accessibility.AccessibleTable AccessibleColumnHeader
        {
            get { return IExecute<Javax.Accessibility.AccessibleTable>("getAccessibleColumnHeader"); } set { IExecute("setAccessibleColumnHeader", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleRowCount()"/> 
        /// </summary>
        public int AccessibleRowCount
        {
            get { return IExecute<int>("getAccessibleRowCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleRowHeader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleRowHeader(javax.accessibility.AccessibleTable)"/>
        /// </summary>
        public Javax.Accessibility.AccessibleTable AccessibleRowHeader
        {
            get { return IExecute<Javax.Accessibility.AccessibleTable>("getAccessibleRowHeader"); } set { IExecute("setAccessibleRowHeader", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleSummary()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#setAccessibleSummary(javax.accessibility.Accessible)"/>
        /// </summary>
        public Javax.Accessibility.Accessible AccessibleSummary
        {
            get { return IExecute<Javax.Accessibility.Accessible>("getAccessibleSummary"); } set { IExecute("setAccessibleSummary", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getSelectedAccessibleColumns()"/> 
        /// </summary>
        public int[] SelectedAccessibleColumns
        {
            get { return IExecuteArray<int>("getSelectedAccessibleColumns"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getSelectedAccessibleRows()"/> 
        /// </summary>
        public int[] SelectedAccessibleRows
        {
            get { return IExecuteArray<int>("getSelectedAccessibleRows"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#isAccessibleColumnSelected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAccessibleColumnSelected(int arg0)
        {
            return IExecute<bool>("isAccessibleColumnSelected", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#isAccessibleRowSelected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAccessibleRowSelected(int arg0)
        {
            return IExecute<bool>("isAccessibleRowSelected", arg0);
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
            return IExecute<Javax.Accessibility.Accessible>("getAccessibleColumnDescription", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTable.html#getAccessibleRowDescription(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Accessibility.Accessible"/></returns>
        public Javax.Accessibility.Accessible GetAccessibleRowDescription(int arg0)
        {
            return IExecute<Javax.Accessibility.Accessible>("getAccessibleRowDescription", arg0);
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