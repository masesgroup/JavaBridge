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

namespace Javax.Swing
{
    #region IRootPaneContainer
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRootPaneContainer
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RootPaneContainer.html#getContentPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RootPaneContainer.html#setContentPane(java.awt.Container)"/>
        /// </summary>
        Java.Awt.Container ContentPane { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RootPaneContainer.html#getGlassPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RootPaneContainer.html#setGlassPane(java.awt.Component)"/>
        /// </summary>
        Java.Awt.Component GlassPane { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RootPaneContainer.html#getLayeredPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RootPaneContainer.html#setLayeredPane(javax.swing.JLayeredPane)"/>
        /// </summary>
        Javax.Swing.JLayeredPane LayeredPane { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RootPaneContainer.html#getRootPane()"/> 
        /// </summary>
        Javax.Swing.JRootPane RootPane { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RootPaneContainer
    public partial class RootPaneContainer : Javax.Swing.IRootPaneContainer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RootPaneContainer.html#getContentPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RootPaneContainer.html#setContentPane(java.awt.Container)"/>
        /// </summary>
        public Java.Awt.Container ContentPane
        {
            get { return IExecute<Java.Awt.Container>("getContentPane"); } set { IExecute("setContentPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RootPaneContainer.html#getGlassPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RootPaneContainer.html#setGlassPane(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component GlassPane
        {
            get { return IExecute<Java.Awt.Component>("getGlassPane"); } set { IExecute("setGlassPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RootPaneContainer.html#getLayeredPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RootPaneContainer.html#setLayeredPane(javax.swing.JLayeredPane)"/>
        /// </summary>
        public Javax.Swing.JLayeredPane LayeredPane
        {
            get { return IExecute<Javax.Swing.JLayeredPane>("getLayeredPane"); } set { IExecute("setLayeredPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RootPaneContainer.html#getRootPane()"/> 
        /// </summary>
        public Javax.Swing.JRootPane RootPane
        {
            get { return IExecute<Javax.Swing.JRootPane>("getRootPane"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}