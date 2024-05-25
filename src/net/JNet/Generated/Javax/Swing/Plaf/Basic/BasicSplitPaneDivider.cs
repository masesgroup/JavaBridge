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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Basic
{
    #region BasicSplitPaneDivider
    public partial class BasicSplitPaneDivider
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneDivider.html#%3Cinit%3E(javax.swing.plaf.basic.BasicSplitPaneUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneUI"/></param>
        public BasicSplitPaneDivider(Javax.Swing.Plaf.Basic.BasicSplitPaneUI arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneDivider"/> to <see cref="Java.Beans.PropertyChangeListener"/>
        /// </summary>
        public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Plaf.Basic.BasicSplitPaneDivider t) => t.Cast<Java.Beans.PropertyChangeListener>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneDivider.html#getBasicSplitPaneUI()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneDivider.html#setBasicSplitPaneUI(javax.swing.plaf.basic.BasicSplitPaneUI)"/>
        /// </summary>
        public Javax.Swing.Plaf.Basic.BasicSplitPaneUI BasicSplitPaneUI
        {
            get { return IExecuteWithSignature<Javax.Swing.Plaf.Basic.BasicSplitPaneUI>("getBasicSplitPaneUI", "()Ljavax/swing/plaf/basic/BasicSplitPaneUI;"); } set { IExecuteWithSignature("setBasicSplitPaneUI", "(Ljavax/swing/plaf/basic/BasicSplitPaneUI;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneDivider.html#getBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneDivider.html#setBorder(javax.swing.border.Border)"/>
        /// </summary>
        public Javax.Swing.Border.Border Border
        {
            get { return IExecuteWithSignature<Javax.Swing.Border.Border>("getBorder", "()Ljavax/swing/border/Border;"); } set { IExecuteWithSignature("setBorder", "(Ljavax/swing/border/Border;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneDivider.html#getDividerSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneDivider.html#setDividerSize(int)"/>
        /// </summary>
        public int DividerSize
        {
            get { return IExecuteWithSignature<int>("getDividerSize", "()I"); } set { IExecuteWithSignature("setDividerSize", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneDivider.html#isMouseOver()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMouseOver()
        {
            return IExecuteWithSignature<bool>("isMouseOver", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneDivider.html#propertyChange(java.beans.PropertyChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
        public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
        {
            IExecuteWithSignature("propertyChange", "(Ljava/beans/PropertyChangeEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}