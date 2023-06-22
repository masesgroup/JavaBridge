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
    #region JDialog
    public partial class JDialog
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Dialog,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public JDialog(Java.Awt.Dialog arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Dialog,java.lang.String,boolean,java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        public JDialog(Java.Awt.Dialog arg0, string arg1, bool arg2, Java.Awt.GraphicsConfiguration arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Dialog,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public JDialog(Java.Awt.Dialog arg0, string arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Dialog,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public JDialog(Java.Awt.Dialog arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Dialog)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        public JDialog(Java.Awt.Dialog arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Frame,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public JDialog(Java.Awt.Frame arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Frame,java.lang.String,boolean,java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        public JDialog(Java.Awt.Frame arg0, string arg1, bool arg2, Java.Awt.GraphicsConfiguration arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Frame,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public JDialog(Java.Awt.Frame arg0, string arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Frame,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public JDialog(Java.Awt.Frame arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Frame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        public JDialog(Java.Awt.Frame arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Window,java.awt.Dialog.ModalityType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Dialog.ModalityType"/></param>
        public JDialog(Java.Awt.Window arg0, Java.Awt.Dialog.ModalityType arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Window,java.lang.String,java.awt.Dialog.ModalityType,java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Dialog.ModalityType"/></param>
        /// <param name="arg3"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        public JDialog(Java.Awt.Window arg0, string arg1, Java.Awt.Dialog.ModalityType arg2, Java.Awt.GraphicsConfiguration arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Window,java.lang.String,java.awt.Dialog.ModalityType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Dialog.ModalityType"/></param>
        public JDialog(Java.Awt.Window arg0, string arg1, Java.Awt.Dialog.ModalityType arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Window,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public JDialog(Java.Awt.Window arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#%3Cinit%3E(java.awt.Window)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        public JDialog(Java.Awt.Window arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JDialog"/> to <see cref="Javax.Swing.WindowConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.WindowConstants(Javax.Swing.JDialog t) => t.Cast<Javax.Swing.WindowConstants>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JDialog"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JDialog t) => t.Cast<Javax.Accessibility.Accessible>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JDialog"/> to <see cref="Javax.Swing.RootPaneContainer"/>
        /// </summary>
        public static implicit operator Javax.Swing.RootPaneContainer(Javax.Swing.JDialog t) => t.Cast<Javax.Swing.RootPaneContainer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#isDefaultLookAndFeelDecorated()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public static bool IsDefaultLookAndFeelDecorated()
        {
            return SExecute<bool>(LocalBridgeClazz, "isDefaultLookAndFeelDecorated");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#setDefaultLookAndFeelDecorated(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public static void SetDefaultLookAndFeelDecorated(bool arg0)
        {
            SExecute(LocalBridgeClazz, "setDefaultLookAndFeelDecorated", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#getContentPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#setContentPane(java.awt.Container)"/>
        /// </summary>
        public Java.Awt.Container ContentPane
        {
            get { return IExecute<Java.Awt.Container>("getContentPane"); } set { IExecute("setContentPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#getDefaultCloseOperation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#setDefaultCloseOperation(int)"/>
        /// </summary>
        public int DefaultCloseOperation
        {
            get { return IExecute<int>("getDefaultCloseOperation"); } set { IExecute("setDefaultCloseOperation", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#getGlassPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#setGlassPane(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component GlassPane
        {
            get { return IExecute<Java.Awt.Component>("getGlassPane"); } set { IExecute("setGlassPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#getJMenuBar()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#setJMenuBar(javax.swing.JMenuBar)"/>
        /// </summary>
        public Javax.Swing.JMenuBar JMenuBar
        {
            get { return IExecute<Javax.Swing.JMenuBar>("getJMenuBar"); } set { IExecute("setJMenuBar", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#getLayeredPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#setLayeredPane(javax.swing.JLayeredPane)"/>
        /// </summary>
        public Javax.Swing.JLayeredPane LayeredPane
        {
            get { return IExecute<Javax.Swing.JLayeredPane>("getLayeredPane"); } set { IExecute("setLayeredPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#getRootPane()"/> 
        /// </summary>
        public Javax.Swing.JRootPane RootPane
        {
            get { return IExecute<Javax.Swing.JRootPane>("getRootPane"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#getTransferHandler()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#setTransferHandler(javax.swing.TransferHandler)"/>
        /// </summary>
        public Javax.Swing.TransferHandler TransferHandler
        {
            get { return IExecute<Javax.Swing.TransferHandler>("getTransferHandler"); } set { IExecute("setTransferHandler", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}