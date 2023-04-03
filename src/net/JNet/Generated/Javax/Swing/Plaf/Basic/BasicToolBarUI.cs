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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Basic
{
    #region BasicToolBarUI
    public partial class BasicToolBarUI
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicToolBarUI"/> to <see cref="Javax.Swing.SwingConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.SwingConstants(Javax.Swing.Plaf.Basic.BasicToolBarUI t) => t.Cast<Javax.Swing.SwingConstants>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicToolBarUI.html#getDockingColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicToolBarUI.html#setDockingColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color DockingColor
        {
            get { return IExecute<Java.Awt.Color>("getDockingColor"); } set { IExecute("setDockingColor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicToolBarUI.html#getFloatingColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicToolBarUI.html#setFloatingColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color FloatingColor
        {
            get { return IExecute<Java.Awt.Color>("getFloatingColor"); } set { IExecute("setFloatingColor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicToolBarUI.html#isFloating()"/> 
        /// </summary>
        public bool IsFloating
        {
            get { return IExecute<bool>("isFloating"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicToolBarUI.html#isRolloverBorders()"/> 
        /// </summary>
        public bool IsRolloverBorders
        {
            get { return IExecute<bool>("isRolloverBorders"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicToolBarUI.html#canDock(java.awt.Component,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanDock(Java.Awt.Component arg0, Java.Awt.Point arg1)
        {
            return IExecute<bool>("canDock", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicToolBarUI.html#setFloating(boolean,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Point"/></param>
        public void SetFloating(bool arg0, Java.Awt.Point arg1)
        {
            IExecute("setFloating", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicToolBarUI.html#setFloatingLocation(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetFloatingLocation(int arg0, int arg1)
        {
            IExecute("setFloatingLocation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicToolBarUI.html#setOrientation(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetOrientation(int arg0)
        {
            IExecute("setOrientation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicToolBarUI.html#setRolloverBorders(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRolloverBorders(bool arg0)
        {
            IExecute("setRolloverBorders", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}