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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JInternalFrame
    public partial class JInternalFrame
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#%3Cinit%3E(java.lang.String,boolean,boolean,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        public JInternalFrame(string arg0, bool arg1, bool arg2, bool arg3, bool arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#%3Cinit%3E(java.lang.String,boolean,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public JInternalFrame(string arg0, bool arg1, bool arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#%3Cinit%3E(java.lang.String,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public JInternalFrame(string arg0, bool arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#%3Cinit%3E(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public JInternalFrame(string arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public JInternalFrame(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JInternalFrame"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JInternalFrame t) => t.Cast<Javax.Accessibility.Accessible>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JInternalFrame"/> to <see cref="Javax.Swing.WindowConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.WindowConstants(Javax.Swing.JInternalFrame t) => t.Cast<Javax.Swing.WindowConstants>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JInternalFrame"/> to <see cref="Javax.Swing.RootPaneContainer"/>
        /// </summary>
        public static implicit operator Javax.Swing.RootPaneContainer(Javax.Swing.JInternalFrame t) => t.Cast<Javax.Swing.RootPaneContainer>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#CONTENT_PANE_PROPERTY"/>
        /// </summary>
        public static string CONTENT_PANE_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "CONTENT_PANE_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#FRAME_ICON_PROPERTY"/>
        /// </summary>
        public static string FRAME_ICON_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "FRAME_ICON_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#GLASS_PANE_PROPERTY"/>
        /// </summary>
        public static string GLASS_PANE_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "GLASS_PANE_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#IS_CLOSED_PROPERTY"/>
        /// </summary>
        public static string IS_CLOSED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "IS_CLOSED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#IS_ICON_PROPERTY"/>
        /// </summary>
        public static string IS_ICON_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "IS_ICON_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#IS_MAXIMUM_PROPERTY"/>
        /// </summary>
        public static string IS_MAXIMUM_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "IS_MAXIMUM_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#IS_SELECTED_PROPERTY"/>
        /// </summary>
        public static string IS_SELECTED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "IS_SELECTED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#LAYERED_PANE_PROPERTY"/>
        /// </summary>
        public static string LAYERED_PANE_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "LAYERED_PANE_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#MENU_BAR_PROPERTY"/>
        /// </summary>
        public static string MENU_BAR_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "MENU_BAR_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#ROOT_PANE_PROPERTY"/>
        /// </summary>
        public static string ROOT_PANE_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "ROOT_PANE_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#TITLE_PROPERTY"/>
        /// </summary>
        public static string TITLE_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "TITLE_PROPERTY"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getContentPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setContentPane(java.awt.Container)"/>
        /// </summary>
        public Java.Awt.Container ContentPane
        {
            get { return IExecute<Java.Awt.Container>("getContentPane"); } set { IExecute("setContentPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getDefaultCloseOperation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setDefaultCloseOperation(int)"/>
        /// </summary>
        public int DefaultCloseOperation
        {
            get { return IExecute<int>("getDefaultCloseOperation"); } set { IExecute("setDefaultCloseOperation", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getDesktopIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setDesktopIcon(javax.swing.JInternalFrame.JDesktopIcon)"/>
        /// </summary>
        public Javax.Swing.JInternalFrame.JDesktopIcon DesktopIcon
        {
            get { return IExecute<Javax.Swing.JInternalFrame.JDesktopIcon>("getDesktopIcon"); } set { IExecute("setDesktopIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getDesktopPane()"/> 
        /// </summary>
        public Javax.Swing.JDesktopPane DesktopPane
        {
            get { return IExecute<Javax.Swing.JDesktopPane>("getDesktopPane"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getFocusOwner()"/> 
        /// </summary>
        public Java.Awt.Component FocusOwner
        {
            get { return IExecute<Java.Awt.Component>("getFocusOwner"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getFrameIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setFrameIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon FrameIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getFrameIcon"); } set { IExecute("setFrameIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getGlassPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setGlassPane(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component GlassPane
        {
            get { return IExecute<Java.Awt.Component>("getGlassPane"); } set { IExecute("setGlassPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getInternalFrameListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.InternalFrameListener[] InternalFrameListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.InternalFrameListener>("getInternalFrameListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getJMenuBar()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setJMenuBar(javax.swing.JMenuBar)"/>
        /// </summary>
        public Javax.Swing.JMenuBar JMenuBar
        {
            get { return IExecute<Javax.Swing.JMenuBar>("getJMenuBar"); } set { IExecute("setJMenuBar", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getLastCursor()"/> 
        /// </summary>
        public Java.Awt.Cursor LastCursor
        {
            get { return IExecute<Java.Awt.Cursor>("getLastCursor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getLayer()"/> 
        /// </summary>
        public int Layer
        {
            get { return IExecute<int>("getLayer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getLayeredPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setLayeredPane(javax.swing.JLayeredPane)"/>
        /// </summary>
        public Javax.Swing.JLayeredPane LayeredPane
        {
            get { return IExecute<Javax.Swing.JLayeredPane>("getLayeredPane"); } set { IExecute("setLayeredPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getMostRecentFocusOwner()"/> 
        /// </summary>
        public Java.Awt.Component MostRecentFocusOwner
        {
            get { return IExecute<Java.Awt.Component>("getMostRecentFocusOwner"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getNormalBounds()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setNormalBounds(java.awt.Rectangle)"/>
        /// </summary>
        public Java.Awt.Rectangle NormalBounds
        {
            get { return IExecute<Java.Awt.Rectangle>("getNormalBounds"); } set { IExecute("setNormalBounds", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getTitle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setTitle(java.lang.String)"/>
        /// </summary>
        public string Title
        {
            get { return IExecute<string>("getTitle"); } set { IExecute("setTitle", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#getWarningString()"/> 
        /// </summary>
        public string WarningString
        {
            get { return IExecute<string>("getWarningString"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#isClosable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsClosable()
        {
            return IExecute<bool>("isClosable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#isClosed()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecute<bool>("isClosed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#isIcon()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsIcon()
        {
            return IExecute<bool>("isIcon");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#isIconifiable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsIconifiable()
        {
            return IExecute<bool>("isIconifiable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#isMaximizable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMaximizable()
        {
            return IExecute<bool>("isMaximizable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#isMaximum()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMaximum()
        {
            return IExecute<bool>("isMaximum");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#isResizable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsResizable()
        {
            return IExecute<bool>("isResizable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#isSelected()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSelected()
        {
            return IExecute<bool>("isSelected");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#addInternalFrameListener(javax.swing.event.InternalFrameListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameListener"/></param>
        public void AddInternalFrameListener(Javax.Swing.Event.InternalFrameListener arg0)
        {
            IExecute("addInternalFrameListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#dispose()"/>
        /// </summary>
        public new void Dispose()
        {
            IExecute("dispose");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#doDefaultCloseAction()"/>
        /// </summary>
        public void DoDefaultCloseAction()
        {
            IExecute("doDefaultCloseAction");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#moveToBack()"/>
        /// </summary>
        public void MoveToBack()
        {
            IExecute("moveToBack");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#moveToFront()"/>
        /// </summary>
        public void MoveToFront()
        {
            IExecute("moveToFront");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#pack()"/>
        /// </summary>
        public void Pack()
        {
            IExecute("pack");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#removeInternalFrameListener(javax.swing.event.InternalFrameListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameListener"/></param>
        public void RemoveInternalFrameListener(Javax.Swing.Event.InternalFrameListener arg0)
        {
            IExecute("removeInternalFrameListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#restoreSubcomponentFocus()"/>
        /// </summary>
        public void RestoreSubcomponentFocus()
        {
            IExecute("restoreSubcomponentFocus");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setClosable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetClosable(bool arg0)
        {
            IExecute("setClosable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setClosed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Beans.PropertyVetoException"/>
        public void SetClosed(bool arg0)
        {
            IExecute("setClosed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setIcon(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Beans.PropertyVetoException"/>
        public void SetIcon(bool arg0)
        {
            IExecute("setIcon", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setIconifiable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetIconifiable(bool arg0)
        {
            IExecute("setIconifiable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setLayer(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetLayer(int arg0)
        {
            IExecute("setLayer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setLayer(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetLayer(int? arg0)
        {
            IExecute("setLayer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setMaximizable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetMaximizable(bool arg0)
        {
            IExecute("setMaximizable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setMaximum(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Beans.PropertyVetoException"/>
        public void SetMaximum(bool arg0)
        {
            IExecute("setMaximum", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setResizable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetResizable(bool arg0)
        {
            IExecute("setResizable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setSelected(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Beans.PropertyVetoException"/>
        public void SetSelected(bool arg0)
        {
            IExecute("setSelected", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#setUI(javax.swing.plaf.InternalFrameUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.InternalFrameUI"/></param>
        public void SetUI(Javax.Swing.Plaf.InternalFrameUI arg0)
        {
            IExecute("setUI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#toBack()"/>
        /// </summary>
        public void ToBack()
        {
            IExecute("toBack");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.html#toFront()"/>
        /// </summary>
        public void ToFront()
        {
            IExecute("toFront");
        }

        #endregion

        #region Nested classes
        #region JDesktopIcon
        public partial class JDesktopIcon
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.JDesktopIcon.html#%3Cinit%3E(javax.swing.JInternalFrame)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
            public JDesktopIcon(Javax.Swing.JInternalFrame arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.JInternalFrame.JDesktopIcon"/> to <see cref="Javax.Accessibility.Accessible"/>
            /// </summary>
            public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JInternalFrame.JDesktopIcon t) => t.Cast<Javax.Accessibility.Accessible>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.JDesktopIcon.html#getDesktopPane()"/> 
            /// </summary>
            public Javax.Swing.JDesktopPane DesktopPane
            {
                get { return IExecute<Javax.Swing.JDesktopPane>("getDesktopPane"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.JDesktopIcon.html#getInternalFrame()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.JDesktopIcon.html#setInternalFrame(javax.swing.JInternalFrame)"/>
            /// </summary>
            public Javax.Swing.JInternalFrame InternalFrame
            {
                get { return IExecute<Javax.Swing.JInternalFrame>("getInternalFrame"); } set { IExecute("setInternalFrame", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JInternalFrame.JDesktopIcon.html#setUI(javax.swing.plaf.DesktopIconUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.DesktopIconUI"/></param>
            public void SetUI(Javax.Swing.Plaf.DesktopIconUI arg0)
            {
                IExecute("setUI", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}