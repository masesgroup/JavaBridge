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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JFileChooser
    public partial class JFileChooser
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#%3Cinit%3E(java.io.File,javax.swing.filechooser.FileSystemView)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Filechooser.FileSystemView"/></param>
        public JFileChooser(Java.Io.File arg0, Javax.Swing.Filechooser.FileSystemView arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#%3Cinit%3E(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        public JFileChooser(Java.Io.File arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#%3Cinit%3E(java.lang.String,javax.swing.filechooser.FileSystemView)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Filechooser.FileSystemView"/></param>
        public JFileChooser(string arg0, Javax.Swing.Filechooser.FileSystemView arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public JFileChooser(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#%3Cinit%3E(javax.swing.filechooser.FileSystemView)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Filechooser.FileSystemView"/></param>
        public JFileChooser(Javax.Swing.Filechooser.FileSystemView arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JFileChooser"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JFileChooser t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#APPROVE_OPTION"/>
        /// </summary>
        public static int APPROVE_OPTION { get { return SGetField<int>(LocalBridgeClazz, "APPROVE_OPTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#CANCEL_OPTION"/>
        /// </summary>
        public static int CANCEL_OPTION { get { return SGetField<int>(LocalBridgeClazz, "CANCEL_OPTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#CUSTOM_DIALOG"/>
        /// </summary>
        public static int CUSTOM_DIALOG { get { return SGetField<int>(LocalBridgeClazz, "CUSTOM_DIALOG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#DIRECTORIES_ONLY"/>
        /// </summary>
        public static int DIRECTORIES_ONLY { get { return SGetField<int>(LocalBridgeClazz, "DIRECTORIES_ONLY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#ERROR_OPTION"/>
        /// </summary>
        public static int ERROR_OPTION { get { return SGetField<int>(LocalBridgeClazz, "ERROR_OPTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#FILES_AND_DIRECTORIES"/>
        /// </summary>
        public static int FILES_AND_DIRECTORIES { get { return SGetField<int>(LocalBridgeClazz, "FILES_AND_DIRECTORIES"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#FILES_ONLY"/>
        /// </summary>
        public static int FILES_ONLY { get { return SGetField<int>(LocalBridgeClazz, "FILES_ONLY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#OPEN_DIALOG"/>
        /// </summary>
        public static int OPEN_DIALOG { get { return SGetField<int>(LocalBridgeClazz, "OPEN_DIALOG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#SAVE_DIALOG"/>
        /// </summary>
        public static int SAVE_DIALOG { get { return SGetField<int>(LocalBridgeClazz, "SAVE_DIALOG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#ACCEPT_ALL_FILE_FILTER_USED_CHANGED_PROPERTY"/>
        /// </summary>
        public static string ACCEPT_ALL_FILE_FILTER_USED_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "ACCEPT_ALL_FILE_FILTER_USED_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#ACCESSORY_CHANGED_PROPERTY"/>
        /// </summary>
        public static string ACCESSORY_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "ACCESSORY_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#APPROVE_BUTTON_MNEMONIC_CHANGED_PROPERTY"/>
        /// </summary>
        public static string APPROVE_BUTTON_MNEMONIC_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "APPROVE_BUTTON_MNEMONIC_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#APPROVE_BUTTON_TEXT_CHANGED_PROPERTY"/>
        /// </summary>
        public static string APPROVE_BUTTON_TEXT_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "APPROVE_BUTTON_TEXT_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#APPROVE_BUTTON_TOOL_TIP_TEXT_CHANGED_PROPERTY"/>
        /// </summary>
        public static string APPROVE_BUTTON_TOOL_TIP_TEXT_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "APPROVE_BUTTON_TOOL_TIP_TEXT_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#APPROVE_SELECTION"/>
        /// </summary>
        public static string APPROVE_SELECTION { get { return SGetField<string>(LocalBridgeClazz, "APPROVE_SELECTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#CANCEL_SELECTION"/>
        /// </summary>
        public static string CANCEL_SELECTION { get { return SGetField<string>(LocalBridgeClazz, "CANCEL_SELECTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#CHOOSABLE_FILE_FILTER_CHANGED_PROPERTY"/>
        /// </summary>
        public static string CHOOSABLE_FILE_FILTER_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "CHOOSABLE_FILE_FILTER_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#CONTROL_BUTTONS_ARE_SHOWN_CHANGED_PROPERTY"/>
        /// </summary>
        public static string CONTROL_BUTTONS_ARE_SHOWN_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "CONTROL_BUTTONS_ARE_SHOWN_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#DIALOG_TITLE_CHANGED_PROPERTY"/>
        /// </summary>
        public static string DIALOG_TITLE_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "DIALOG_TITLE_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#DIALOG_TYPE_CHANGED_PROPERTY"/>
        /// </summary>
        public static string DIALOG_TYPE_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "DIALOG_TYPE_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#DIRECTORY_CHANGED_PROPERTY"/>
        /// </summary>
        public static string DIRECTORY_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "DIRECTORY_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#FILE_FILTER_CHANGED_PROPERTY"/>
        /// </summary>
        public static string FILE_FILTER_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "FILE_FILTER_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#FILE_HIDING_CHANGED_PROPERTY"/>
        /// </summary>
        public static string FILE_HIDING_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "FILE_HIDING_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#FILE_SELECTION_MODE_CHANGED_PROPERTY"/>
        /// </summary>
        public static string FILE_SELECTION_MODE_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "FILE_SELECTION_MODE_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#FILE_SYSTEM_VIEW_CHANGED_PROPERTY"/>
        /// </summary>
        public static string FILE_SYSTEM_VIEW_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "FILE_SYSTEM_VIEW_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#FILE_VIEW_CHANGED_PROPERTY"/>
        /// </summary>
        public static string FILE_VIEW_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "FILE_VIEW_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#MULTI_SELECTION_ENABLED_CHANGED_PROPERTY"/>
        /// </summary>
        public static string MULTI_SELECTION_ENABLED_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "MULTI_SELECTION_ENABLED_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#SELECTED_FILE_CHANGED_PROPERTY"/>
        /// </summary>
        public static string SELECTED_FILE_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "SELECTED_FILE_CHANGED_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#SELECTED_FILES_CHANGED_PROPERTY"/>
        /// </summary>
        public static string SELECTED_FILES_CHANGED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "SELECTED_FILES_CHANGED_PROPERTY"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getAcceptAllFileFilter()"/> 
        /// </summary>
        public Javax.Swing.Filechooser.FileFilter AcceptAllFileFilter
        {
            get { return IExecute<Javax.Swing.Filechooser.FileFilter>("getAcceptAllFileFilter"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getAccessory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setAccessory(javax.swing.JComponent)"/>
        /// </summary>
        public Javax.Swing.JComponent Accessory
        {
            get { return IExecute<Javax.Swing.JComponent>("getAccessory"); } set { IExecute("setAccessory", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getActionListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ActionListener[] ActionListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.ActionListener>("getActionListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getApproveButtonMnemonic()"/> 
        /// </summary>
        public int ApproveButtonMnemonic
        {
            get { return IExecute<int>("getApproveButtonMnemonic"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getApproveButtonText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setApproveButtonText(java.lang.String)"/>
        /// </summary>
        public string ApproveButtonText
        {
            get { return IExecute<string>("getApproveButtonText"); } set { IExecute("setApproveButtonText", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getApproveButtonToolTipText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setApproveButtonToolTipText(java.lang.String)"/>
        /// </summary>
        public string ApproveButtonToolTipText
        {
            get { return IExecute<string>("getApproveButtonToolTipText"); } set { IExecute("setApproveButtonToolTipText", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getChoosableFileFilters()"/> 
        /// </summary>
        public Javax.Swing.Filechooser.FileFilter[] ChoosableFileFilters
        {
            get { return IExecuteArray<Javax.Swing.Filechooser.FileFilter>("getChoosableFileFilters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getControlButtonsAreShown()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setControlButtonsAreShown(boolean)"/>
        /// </summary>
        public bool ControlButtonsAreShown
        {
            get { return IExecute<bool>("getControlButtonsAreShown"); } set { IExecute("setControlButtonsAreShown", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getCurrentDirectory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setCurrentDirectory(java.io.File)"/>
        /// </summary>
        public Java.Io.File CurrentDirectory
        {
            get { return IExecute<Java.Io.File>("getCurrentDirectory"); } set { IExecute("setCurrentDirectory", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getDialogTitle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setDialogTitle(java.lang.String)"/>
        /// </summary>
        public string DialogTitle
        {
            get { return IExecute<string>("getDialogTitle"); } set { IExecute("setDialogTitle", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getDialogType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setDialogType(int)"/>
        /// </summary>
        public int DialogType
        {
            get { return IExecute<int>("getDialogType"); } set { IExecute("setDialogType", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getDragEnabled()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setDragEnabled(boolean)"/>
        /// </summary>
        public bool DragEnabled
        {
            get { return IExecute<bool>("getDragEnabled"); } set { IExecute("setDragEnabled", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getFileFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setFileFilter(javax.swing.filechooser.FileFilter)"/>
        /// </summary>
        public Javax.Swing.Filechooser.FileFilter FileFilter
        {
            get { return IExecute<Javax.Swing.Filechooser.FileFilter>("getFileFilter"); } set { IExecute("setFileFilter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getFileSelectionMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setFileSelectionMode(int)"/>
        /// </summary>
        public int FileSelectionMode
        {
            get { return IExecute<int>("getFileSelectionMode"); } set { IExecute("setFileSelectionMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getFileSystemView()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setFileSystemView(javax.swing.filechooser.FileSystemView)"/>
        /// </summary>
        public Javax.Swing.Filechooser.FileSystemView FileSystemView
        {
            get { return IExecute<Javax.Swing.Filechooser.FileSystemView>("getFileSystemView"); } set { IExecute("setFileSystemView", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getFileView()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setFileView(javax.swing.filechooser.FileView)"/>
        /// </summary>
        public Javax.Swing.Filechooser.FileView FileView
        {
            get { return IExecute<Javax.Swing.Filechooser.FileView>("getFileView"); } set { IExecute("setFileView", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getSelectedFile()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setSelectedFile(java.io.File)"/>
        /// </summary>
        public Java.Io.File SelectedFile
        {
            get { return IExecute<Java.Io.File>("getSelectedFile"); } set { IExecute("setSelectedFile", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getSelectedFiles()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setSelectedFiles(java.io.File[])"/>
        /// </summary>
        public Java.Io.File[] SelectedFiles
        {
            get { return IExecuteArray<Java.Io.File>("getSelectedFiles"); } set { IExecute("setSelectedFiles", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#accept(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Accept(Java.Io.File arg0)
        {
            return IExecute<bool>("accept", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#isAcceptAllFileFilterUsed()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAcceptAllFileFilterUsed()
        {
            return IExecute<bool>("isAcceptAllFileFilterUsed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#isDirectorySelectionEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDirectorySelectionEnabled()
        {
            return IExecute<bool>("isDirectorySelectionEnabled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#isFileHidingEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFileHidingEnabled()
        {
            return IExecute<bool>("isFileHidingEnabled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#isFileSelectionEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFileSelectionEnabled()
        {
            return IExecute<bool>("isFileSelectionEnabled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#isMultiSelectionEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMultiSelectionEnabled()
        {
            return IExecute<bool>("isMultiSelectionEnabled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#isTraversable(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsTraversable(Java.Io.File arg0)
        {
            return IExecute<bool>("isTraversable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#removeChoosableFileFilter(javax.swing.filechooser.FileFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Filechooser.FileFilter"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveChoosableFileFilter(Javax.Swing.Filechooser.FileFilter arg0)
        {
            return IExecute<bool>("removeChoosableFileFilter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#showDialog(java.awt.Component,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public int ShowDialog(Java.Awt.Component arg0, string arg1)
        {
            return IExecute<int>("showDialog", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#showOpenDialog(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public int ShowOpenDialog(Java.Awt.Component arg0)
        {
            return IExecute<int>("showOpenDialog", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#showSaveDialog(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public int ShowSaveDialog(Java.Awt.Component arg0)
        {
            return IExecute<int>("showSaveDialog", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getDescription(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDescription(Java.Io.File arg0)
        {
            return IExecute<string>("getDescription", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getName(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetName(Java.Io.File arg0)
        {
            return IExecute<string>("getName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getTypeDescription(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetTypeDescription(Java.Io.File arg0)
        {
            return IExecute<string>("getTypeDescription", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#getIcon(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public Javax.Swing.Icon GetIcon(Java.Io.File arg0)
        {
            return IExecute<Javax.Swing.Icon>("getIcon", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#addActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void AddActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("addActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#addChoosableFileFilter(javax.swing.filechooser.FileFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Filechooser.FileFilter"/></param>
        public void AddChoosableFileFilter(Javax.Swing.Filechooser.FileFilter arg0)
        {
            IExecute("addChoosableFileFilter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#approveSelection()"/>
        /// </summary>
        public void ApproveSelection()
        {
            IExecute("approveSelection");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#cancelSelection()"/>
        /// </summary>
        public void CancelSelection()
        {
            IExecute("cancelSelection");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#changeToParentDirectory()"/>
        /// </summary>
        public void ChangeToParentDirectory()
        {
            IExecute("changeToParentDirectory");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#ensureFileIsVisible(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        public void EnsureFileIsVisible(Java.Io.File arg0)
        {
            IExecute("ensureFileIsVisible", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#removeActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void RemoveActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("removeActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#rescanCurrentDirectory()"/>
        /// </summary>
        public void RescanCurrentDirectory()
        {
            IExecute("rescanCurrentDirectory");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#resetChoosableFileFilters()"/>
        /// </summary>
        public void ResetChoosableFileFilters()
        {
            IExecute("resetChoosableFileFilters");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setAcceptAllFileFilterUsed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAcceptAllFileFilterUsed(bool arg0)
        {
            IExecute("setAcceptAllFileFilterUsed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setApproveButtonMnemonic(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void SetApproveButtonMnemonic(char arg0)
        {
            IExecute("setApproveButtonMnemonic", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setApproveButtonMnemonic(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetApproveButtonMnemonic(int arg0)
        {
            IExecute("setApproveButtonMnemonic", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setFileHidingEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFileHidingEnabled(bool arg0)
        {
            IExecute("setFileHidingEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFileChooser.html#setMultiSelectionEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetMultiSelectionEnabled(bool arg0)
        {
            IExecute("setMultiSelectionEnabled", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}