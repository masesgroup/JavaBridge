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

namespace Java.Awt
{
    #region GridLayout
    public partial class GridLayout
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#%3Cinit%3E(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public GridLayout(int arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public GridLayout(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.GridLayout"/> to <see cref="Java.Awt.LayoutManager"/>
        /// </summary>
        public static implicit operator Java.Awt.LayoutManager(Java.Awt.GridLayout t) => t.Cast<Java.Awt.LayoutManager>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.GridLayout"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.GridLayout t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#getColumns()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#setColumns(int)"/>
        /// </summary>
        public int Columns
        {
            get { return IExecute<int>("getColumns"); } set { IExecute("setColumns", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#getHgap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#setHgap(int)"/>
        /// </summary>
        public int Hgap
        {
            get { return IExecute<int>("getHgap"); } set { IExecute("setHgap", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#getRows()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#setRows(int)"/>
        /// </summary>
        public int Rows
        {
            get { return IExecute<int>("getRows"); } set { IExecute("setRows", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#getVgap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#setVgap(int)"/>
        /// </summary>
        public int Vgap
        {
            get { return IExecute<int>("getVgap"); } set { IExecute("setVgap", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#minimumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Dimension>("minimumLayoutSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#preferredLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Dimension>("preferredLayoutSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#addLayoutComponent(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void AddLayoutComponent(string arg0, Java.Awt.Component arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#layoutContainer(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void LayoutContainer(Java.Awt.Container arg0)
        {
            IExecute("layoutContainer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridLayout.html#removeLayoutComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void RemoveLayoutComponent(Java.Awt.Component arg0)
        {
            IExecute("removeLayoutComponent", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}