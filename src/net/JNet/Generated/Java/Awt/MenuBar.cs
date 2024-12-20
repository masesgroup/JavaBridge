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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region MenuBar declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html"/>
    /// </summary>
    public partial class MenuBar : Java.Awt.MenuComponent
    {
        const string _bridgeClassName = "java.awt.MenuBar";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MenuBar() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MenuBar(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region MenuBar implementation
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
            get { return IExecuteWithSignature<Java.Awt.Menu>("getHelpMenu", "()Ljava/awt/Menu;"); } set { IExecuteWithSignature("setHelpMenu", "(Ljava/awt/Menu;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#getMenuCount()"/> 
        /// </summary>
        public int MenuCount
        {
            get { return IExecuteWithSignature<int>("getMenuCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#add(java.awt.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Menu"/></param>
        /// <returns><see cref="Java.Awt.Menu"/></returns>
        public Java.Awt.Menu Add(Java.Awt.Menu arg0)
        {
            return IExecuteWithSignature<Java.Awt.Menu>("add", "(Ljava/awt/Menu;)Ljava/awt/Menu;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#getMenu(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Menu"/></returns>
        public Java.Awt.Menu GetMenu(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.Menu>("getMenu", "(I)Ljava/awt/Menu;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#getShortcutMenuItem(java.awt.MenuShortcut)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.MenuShortcut"/></param>
        /// <returns><see cref="Java.Awt.MenuItem"/></returns>
        public Java.Awt.MenuItem GetShortcutMenuItem(Java.Awt.MenuShortcut arg0)
        {
            return IExecuteWithSignature<Java.Awt.MenuItem>("getShortcutMenuItem", "(Ljava/awt/MenuShortcut;)Ljava/awt/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#shortcuts()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Java.Awt.MenuShortcut> Shortcuts()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Java.Awt.MenuShortcut>>("shortcuts", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#addNotify()"/>
        /// </summary>
        public void AddNotify()
        {
            IExecuteWithSignature("addNotify", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#deleteShortcut(java.awt.MenuShortcut)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.MenuShortcut"/></param>
        public void DeleteShortcut(Java.Awt.MenuShortcut arg0)
        {
            IExecuteWithSignature("deleteShortcut", "(Ljava/awt/MenuShortcut;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Remove(int arg0)
        {
            IExecuteWithSignature("remove", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuBar.html#remove(java.awt.MenuComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.MenuComponent"/></param>
        public void Remove(Java.Awt.MenuComponent arg0)
        {
            IExecuteWithSignature("remove", "(Ljava/awt/MenuComponent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}