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

namespace Javax.Swing
{
    #region JScrollPane
    public partial class JScrollPane
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public JScrollPane(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#%3Cinit%3E(java.awt.Component,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public JScrollPane(Java.Awt.Component arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#%3Cinit%3E(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public JScrollPane(Java.Awt.Component arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JScrollPane"/> to <see cref="Javax.Swing.ScrollPaneConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.ScrollPaneConstants(Javax.Swing.JScrollPane t) => t.Cast<Javax.Swing.ScrollPaneConstants>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JScrollPane"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JScrollPane t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getColumnHeader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setColumnHeader(javax.swing.JViewport)"/>
        /// </summary>
        public Javax.Swing.JViewport ColumnHeader
        {
            get { return IExecute<Javax.Swing.JViewport>("getColumnHeader"); } set { IExecute("setColumnHeader", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#createHorizontalScrollBar()"/> 
        /// </summary>
        public Javax.Swing.JScrollBar CreateHorizontalScrollBar
        {
            get { return IExecute<Javax.Swing.JScrollBar>("createHorizontalScrollBar"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#createVerticalScrollBar()"/> 
        /// </summary>
        public Javax.Swing.JScrollBar CreateVerticalScrollBar
        {
            get { return IExecute<Javax.Swing.JScrollBar>("createVerticalScrollBar"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getHorizontalScrollBar()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setHorizontalScrollBar(javax.swing.JScrollBar)"/>
        /// </summary>
        public Javax.Swing.JScrollBar HorizontalScrollBar
        {
            get { return IExecute<Javax.Swing.JScrollBar>("getHorizontalScrollBar"); } set { IExecute("setHorizontalScrollBar", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getHorizontalScrollBarPolicy()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setHorizontalScrollBarPolicy(int)"/>
        /// </summary>
        public int HorizontalScrollBarPolicy
        {
            get { return IExecute<int>("getHorizontalScrollBarPolicy"); } set { IExecute("setHorizontalScrollBarPolicy", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#isWheelScrollingEnabled()"/> 
        /// </summary>
        public bool IsWheelScrollingEnabled
        {
            get { return IExecute<bool>("isWheelScrollingEnabled"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getRowHeader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setRowHeader(javax.swing.JViewport)"/>
        /// </summary>
        public Javax.Swing.JViewport RowHeader
        {
            get { return IExecute<Javax.Swing.JViewport>("getRowHeader"); } set { IExecute("setRowHeader", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getVerticalScrollBar()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setVerticalScrollBar(javax.swing.JScrollBar)"/>
        /// </summary>
        public Javax.Swing.JScrollBar VerticalScrollBar
        {
            get { return IExecute<Javax.Swing.JScrollBar>("getVerticalScrollBar"); } set { IExecute("setVerticalScrollBar", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getVerticalScrollBarPolicy()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setVerticalScrollBarPolicy(int)"/>
        /// </summary>
        public int VerticalScrollBarPolicy
        {
            get { return IExecute<int>("getVerticalScrollBarPolicy"); } set { IExecute("setVerticalScrollBarPolicy", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getViewport()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setViewport(javax.swing.JViewport)"/>
        /// </summary>
        public Javax.Swing.JViewport Viewport
        {
            get { return IExecute<Javax.Swing.JViewport>("getViewport"); } set { IExecute("setViewport", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getViewportBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setViewportBorder(javax.swing.border.Border)"/>
        /// </summary>
        public Javax.Swing.Border.Border ViewportBorder
        {
            get { return IExecute<Javax.Swing.Border.Border>("getViewportBorder"); } set { IExecute("setViewportBorder", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getViewportBorderBounds()"/> 
        /// </summary>
        public Java.Awt.Rectangle ViewportBorderBounds
        {
            get { return IExecute<Java.Awt.Rectangle>("getViewportBorderBounds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getCorner(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetCorner(string arg0)
        {
            return IExecute<Java.Awt.Component>("getCorner", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setColumnHeaderView(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void SetColumnHeaderView(Java.Awt.Component arg0)
        {
            IExecute("setColumnHeaderView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setCorner(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void SetCorner(string arg0, Java.Awt.Component arg1)
        {
            IExecute("setCorner", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setRowHeaderView(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void SetRowHeaderView(Java.Awt.Component arg0)
        {
            IExecute("setRowHeaderView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setUI(javax.swing.plaf.ScrollPaneUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.ScrollPaneUI"/></param>
        public void SetUI(Javax.Swing.Plaf.ScrollPaneUI arg0)
        {
            IExecute("setUI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setViewportView(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void SetViewportView(Java.Awt.Component arg0)
        {
            IExecute("setViewportView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setWheelScrollingEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetWheelScrollingEnabled(bool arg0)
        {
            IExecute("setWheelScrollingEnabled", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}