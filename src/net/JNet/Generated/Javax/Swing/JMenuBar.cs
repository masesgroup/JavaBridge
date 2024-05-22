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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JMenuBar
    public partial class JMenuBar
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JMenuBar"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JMenuBar t) => t.Cast<Javax.Accessibility.Accessible>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JMenuBar"/> to <see cref="Javax.Swing.MenuElement"/>
        /// </summary>
        public static implicit operator Javax.Swing.MenuElement(Javax.Swing.JMenuBar t) => t.Cast<Javax.Swing.MenuElement>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#getComponent()"/> 
        /// </summary>
        public Java.Awt.Component Component
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getComponent", "()Ljava/awt/Component;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#getHelpMenu()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#setHelpMenu(javax.swing.JMenu)"/>
        /// </summary>
        public Javax.Swing.JMenu HelpMenu
        {
            get { return IExecuteWithSignature<Javax.Swing.JMenu>("getHelpMenu", "()Ljavax/swing/JMenu;"); } set { IExecuteWithSignature("setHelpMenu", "(Ljavax/swing/JMenu;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#getMargin()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#setMargin(java.awt.Insets)"/>
        /// </summary>
        public Java.Awt.Insets Margin
        {
            get { return IExecuteWithSignature<Java.Awt.Insets>("getMargin", "()Ljava/awt/Insets;"); } set { IExecuteWithSignature("setMargin", "(Ljava/awt/Insets;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#getMenuCount()"/> 
        /// </summary>
        public int MenuCount
        {
            get { return IExecuteWithSignature<int>("getMenuCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#getSelectionModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#setSelectionModel(javax.swing.SingleSelectionModel)"/>
        /// </summary>
        public Javax.Swing.SingleSelectionModel SelectionModel
        {
            get { return IExecuteWithSignature<Javax.Swing.SingleSelectionModel>("getSelectionModel", "()Ljavax/swing/SingleSelectionModel;"); } set { IExecuteWithSignature("setSelectionModel", "(Ljavax/swing/SingleSelectionModel;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#getSubElements()"/> 
        /// </summary>
        public Javax.Swing.MenuElement[] SubElements
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.MenuElement>("getSubElements", "()[Ljavax/swing/MenuElement;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#isBorderPainted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBorderPainted()
        {
            return IExecuteWithSignature<bool>("isBorderPainted", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#isSelected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSelected()
        {
            return IExecuteWithSignature<bool>("isSelected", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#getComponentIndex(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetComponentIndex(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<int>("getComponentIndex", "(Ljava/awt/Component;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#add(javax.swing.JMenu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JMenu"/></param>
        /// <returns><see cref="Javax.Swing.JMenu"/></returns>
        public Javax.Swing.JMenu Add(Javax.Swing.JMenu arg0)
        {
            return IExecuteWithSignature<Javax.Swing.JMenu>("add", "(Ljavax/swing/JMenu;)Ljavax/swing/JMenu;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#getMenu(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.JMenu"/></returns>
        public Javax.Swing.JMenu GetMenu(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.JMenu>("getMenu", "(I)Ljavax/swing/JMenu;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#menuSelectionChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void MenuSelectionChanged(bool arg0)
        {
            IExecuteWithSignature("menuSelectionChanged", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#processKeyEvent(java.awt.event.KeyEvent,javax.swing.MenuElement[],javax.swing.MenuSelectionManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.MenuElement"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.MenuSelectionManager"/></param>
        public void ProcessKeyEvent(Java.Awt.EventNs.KeyEvent arg0, Javax.Swing.MenuElement[] arg1, Javax.Swing.MenuSelectionManager arg2)
        {
            IExecute("processKeyEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#processMouseEvent(java.awt.event.MouseEvent,javax.swing.MenuElement[],javax.swing.MenuSelectionManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.MenuElement"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.MenuSelectionManager"/></param>
        public void ProcessMouseEvent(Java.Awt.EventNs.MouseEvent arg0, Javax.Swing.MenuElement[] arg1, Javax.Swing.MenuSelectionManager arg2)
        {
            IExecute("processMouseEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#setBorderPainted(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetBorderPainted(bool arg0)
        {
            IExecuteWithSignature("setBorderPainted", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#setSelected(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void SetSelected(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("setSelected", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuBar.html#setUI(javax.swing.plaf.MenuBarUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.MenuBarUI"/></param>
        public void SetUI(Javax.Swing.Plaf.MenuBarUI arg0)
        {
            IExecuteWithSignature("setUI", "(Ljavax/swing/plaf/MenuBarUI;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}