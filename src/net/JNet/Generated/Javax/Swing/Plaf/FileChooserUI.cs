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

namespace Javax.Swing.Plaf
{
    #region FileChooserUI declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/FileChooserUI.html"/>
    /// </summary>
    public partial class FileChooserUI : Javax.Swing.Plaf.ComponentUI
    {
        const string _bridgeClassName = "javax.swing.plaf.FileChooserUI";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("FileChooserUI class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FileChooserUI() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("FileChooserUI class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FileChooserUI(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    #region FileChooserUI implementation
    public partial class FileChooserUI
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/FileChooserUI.html#getApproveButtonText(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetApproveButtonText(Javax.Swing.JFileChooser arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getApproveButtonText", "(Ljavax/swing/JFileChooser;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/FileChooserUI.html#getDialogTitle(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDialogTitle(Javax.Swing.JFileChooser arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getDialogTitle", "(Ljavax/swing/JFileChooser;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/FileChooserUI.html#getAcceptAllFileFilter(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        /// <returns><see cref="Javax.Swing.Filechooser.FileFilter"/></returns>
        public Javax.Swing.Filechooser.FileFilter GetAcceptAllFileFilter(Javax.Swing.JFileChooser arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Filechooser.FileFilter>("getAcceptAllFileFilter", "(Ljavax/swing/JFileChooser;)Ljavax/swing/filechooser/FileFilter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/FileChooserUI.html#getFileView(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        /// <returns><see cref="Javax.Swing.Filechooser.FileView"/></returns>
        public Javax.Swing.Filechooser.FileView GetFileView(Javax.Swing.JFileChooser arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Filechooser.FileView>("getFileView", "(Ljavax/swing/JFileChooser;)Ljavax/swing/filechooser/FileView;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/FileChooserUI.html#ensureFileIsVisible(javax.swing.JFileChooser,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        /// <param name="arg1"><see cref="Java.Io.File"/></param>
        public void EnsureFileIsVisible(Javax.Swing.JFileChooser arg0, Java.Io.File arg1)
        {
            IExecuteWithSignature("ensureFileIsVisible", "(Ljavax/swing/JFileChooser;Ljava/io/File;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/FileChooserUI.html#rescanCurrentDirectory(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        public void RescanCurrentDirectory(Javax.Swing.JFileChooser arg0)
        {
            IExecuteWithSignature("rescanCurrentDirectory", "(Ljavax/swing/JFileChooser;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/FileChooserUI.html#getDefaultButton(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        /// <returns><see cref="Javax.Swing.JButton"/></returns>
        public Javax.Swing.JButton GetDefaultButton(Javax.Swing.JFileChooser arg0)
        {
            return IExecuteWithSignature<Javax.Swing.JButton>("getDefaultButton", "(Ljavax/swing/JFileChooser;)Ljavax/swing/JButton;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}