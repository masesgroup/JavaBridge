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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region MenuBar
    public partial class MenuBar
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.MenuBar"/> to <see cref="Java.Awt.MenuContainer"/>
        /// </summary>
        public static implicit operator Java.Awt.MenuContainer(Java.Awt.MenuBar t) => t.Cast<Java.Awt.MenuContainer>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.MenuBar"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Java.Awt.MenuBar t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#getHelpMenu()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#setHelpMenu(java.awt.Menu)"/>
        /// </summary>
        public Java.Awt.Menu HelpMenu
        {
            get { return IExecute<Java.Awt.Menu>("getHelpMenu"); } set { IExecute("setHelpMenu", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#getMenuCount()"/> 
        /// </summary>
        public int MenuCount
        {
            get { return IExecute<int>("getMenuCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#add(java.awt.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Menu"/></param>
        /// <returns><see cref="Java.Awt.Menu"/></returns>
        public Java.Awt.Menu Add(Java.Awt.Menu arg0)
        {
            return IExecute<Java.Awt.Menu>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#getMenu(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Menu"/></returns>
        public Java.Awt.Menu GetMenu(int arg0)
        {
            return IExecute<Java.Awt.Menu>("getMenu", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#getShortcutMenuItem(java.awt.MenuShortcut)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.MenuShortcut"/></param>
        /// <returns><see cref="Java.Awt.MenuItem"/></returns>
        public Java.Awt.MenuItem GetShortcutMenuItem(Java.Awt.MenuShortcut arg0)
        {
            return IExecute<Java.Awt.MenuItem>("getShortcutMenuItem", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#shortcuts()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration Shortcuts()
        {
            return IExecute<Java.Util.Enumeration>("shortcuts");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#addNotify()"/>
        /// </summary>
        public void AddNotify()
        {
            IExecute("addNotify");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#deleteShortcut(java.awt.MenuShortcut)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.MenuShortcut"/></param>
        public void DeleteShortcut(Java.Awt.MenuShortcut arg0)
        {
            IExecute("deleteShortcut", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Remove(int arg0)
        {
            IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#remove(java.awt.MenuComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.MenuComponent"/></param>
        public void Remove(Java.Awt.MenuComponent arg0)
        {
            IExecute("remove", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}