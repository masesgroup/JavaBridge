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
    #region MenuItem
    public partial class MenuItem
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#%3Cinit%3E(java.lang.String,java.awt.MenuShortcut)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.MenuShortcut"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public MenuItem(string arg0, Java.Awt.MenuShortcut arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public MenuItem(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.MenuItem"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Java.Awt.MenuItem t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#getActionCommand()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#setActionCommand(java.lang.String)"/>
        /// </summary>
        public string ActionCommand
        {
            get { return IExecute<string>("getActionCommand"); } set { IExecute("setActionCommand", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#getActionListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ActionListener[] ActionListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.ActionListener>("getActionListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#getLabel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#setLabel(java.lang.String)"/>
        /// </summary>
        public string Label
        {
            get { return IExecute<string>("getLabel"); } set { IExecute("setLabel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#getShortcut()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#setShortcut(java.awt.MenuShortcut)"/>
        /// </summary>
        public Java.Awt.MenuShortcut Shortcut
        {
            get { return IExecute<Java.Awt.MenuShortcut>("getShortcut"); } set { IExecute("setShortcut", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#isEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecute<bool>("isEnabled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#paramString()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ParamString()
        {
            return IExecute<string>("paramString");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#addActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void AddActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("addActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#removeActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void RemoveActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("removeActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEnabled(bool arg0)
        {
            IExecute("setEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#addNotify()"/>
        /// </summary>
        public void AddNotify()
        {
            IExecute("addNotify");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuItem.html#deleteShortcut()"/>
        /// </summary>
        public void DeleteShortcut()
        {
            IExecute("deleteShortcut");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}