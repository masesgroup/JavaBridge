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
    #region JMenu
    public partial class JMenu
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#%3Cinit%3E(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public JMenu(string arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public JMenu(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#%3Cinit%3E(javax.swing.Action)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Action"/></param>
        public JMenu(Javax.Swing.Action arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getDelay()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#setDelay(int)"/>
        /// </summary>
        public int Delay
        {
            get { return IExecute<int>("getDelay"); } set { IExecute("setDelay", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getItemCount()"/> 
        /// </summary>
        public int ItemCount
        {
            get { return IExecute<int>("getItemCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getMenuComponentCount()"/> 
        /// </summary>
        public int MenuComponentCount
        {
            get { return IExecute<int>("getMenuComponentCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getMenuComponents()"/> 
        /// </summary>
        public Java.Awt.Component[] MenuComponents
        {
            get { return IExecuteArray<Java.Awt.Component>("getMenuComponents"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getMenuListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.MenuListener[] MenuListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.MenuListener>("getMenuListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getPopupMenu()"/> 
        /// </summary>
        public Javax.Swing.JPopupMenu PopupMenu
        {
            get { return IExecute<Javax.Swing.JPopupMenu>("getPopupMenu"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#isMenuComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsMenuComponent(Java.Awt.Component arg0)
        {
            return IExecute<bool>("isMenuComponent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#isPopupMenuVisible()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPopupMenuVisible()
        {
            return IExecute<bool>("isPopupMenuVisible");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#isTearOff()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsTearOff()
        {
            return IExecute<bool>("isTearOff");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#isTopLevelMenu()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsTopLevelMenu()
        {
            return IExecute<bool>("isTopLevelMenu");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getMenuComponent(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetMenuComponent(int arg0)
        {
            return IExecute<Java.Awt.Component>("getMenuComponent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#add(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem Add(string arg0)
        {
            return IExecute<Javax.Swing.JMenuItem>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#add(javax.swing.Action)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Action"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem Add(Javax.Swing.Action arg0)
        {
            return IExecute<Javax.Swing.JMenuItem>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#add(javax.swing.JMenuItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JMenuItem"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem Add(Javax.Swing.JMenuItem arg0)
        {
            return IExecute<Javax.Swing.JMenuItem>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem GetItem(int arg0)
        {
            return IExecute<Javax.Swing.JMenuItem>("getItem", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#insert(javax.swing.Action,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Action"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem Insert(Javax.Swing.Action arg0, int arg1)
        {
            return IExecute<Javax.Swing.JMenuItem>("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#insert(javax.swing.JMenuItem,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JMenuItem"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem Insert(Javax.Swing.JMenuItem arg0, int arg1)
        {
            return IExecute<Javax.Swing.JMenuItem>("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#addMenuListener(javax.swing.event.MenuListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuListener"/></param>
        public void AddMenuListener(Javax.Swing.Event.MenuListener arg0)
        {
            IExecute("addMenuListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#addSeparator()"/>
        /// </summary>
        public void AddSeparator()
        {
            IExecute("addSeparator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#insert(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Insert(string arg0, int arg1)
        {
            IExecute("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#insertSeparator(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void InsertSeparator(int arg0)
        {
            IExecute("insertSeparator", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#remove(javax.swing.JMenuItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JMenuItem"/></param>
        public void Remove(Javax.Swing.JMenuItem arg0)
        {
            IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#removeMenuListener(javax.swing.event.MenuListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuListener"/></param>
        public void RemoveMenuListener(Javax.Swing.Event.MenuListener arg0)
        {
            IExecute("removeMenuListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#setMenuLocation(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetMenuLocation(int arg0, int arg1)
        {
            IExecute("setMenuLocation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#setPopupMenuVisible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPopupMenuVisible(bool arg0)
        {
            IExecute("setPopupMenuVisible", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}