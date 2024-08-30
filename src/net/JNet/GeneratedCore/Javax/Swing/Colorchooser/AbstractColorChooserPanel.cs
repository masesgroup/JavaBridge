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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Colorchooser
{
    #region AbstractColorChooserPanel definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html"/>
    /// </summary>
    public partial class AbstractColorChooserPanel : Javax.Swing.JPanel
    {
        const string _bridgeClassName = "javax.swing.colorchooser.AbstractColorChooserPanel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AbstractColorChooserPanel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractColorChooserPanel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AbstractColorChooserPanel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractColorChooserPanel(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region AbstractColorChooserPanel
    public partial class AbstractColorChooserPanel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#TRANSPARENCY_ENABLED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String TRANSPARENCY_ENABLED_PROPERTY { get { if (!_TRANSPARENCY_ENABLED_PROPERTYReady) { _TRANSPARENCY_ENABLED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TRANSPARENCY_ENABLED_PROPERTY"); _TRANSPARENCY_ENABLED_PROPERTYReady = true; } return _TRANSPARENCY_ENABLED_PROPERTYContent; } }
        private static Java.Lang.String _TRANSPARENCY_ENABLED_PROPERTYContent = default;
        private static bool _TRANSPARENCY_ENABLED_PROPERTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#getColorSelectionModel()"/> 
        /// </summary>
        public Javax.Swing.Colorchooser.ColorSelectionModel ColorSelectionModel
        {
            get { return IExecuteWithSignature<Javax.Swing.Colorchooser.ColorSelectionModel>("getColorSelectionModel", "()Ljavax/swing/colorchooser/ColorSelectionModel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#getDisplayedMnemonicIndex()"/> 
        /// </summary>
        public int DisplayedMnemonicIndex
        {
            get { return IExecuteWithSignature<int>("getDisplayedMnemonicIndex", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#getDisplayName()"/> 
        /// </summary>
        public Java.Lang.String DisplayName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDisplayName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#getLargeDisplayIcon()"/> 
        /// </summary>
        public Javax.Swing.Icon LargeDisplayIcon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getLargeDisplayIcon", "()Ljavax/swing/Icon;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#getMnemonic()"/> 
        /// </summary>
        public int Mnemonic
        {
            get { return IExecuteWithSignature<int>("getMnemonic", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#getSmallDisplayIcon()"/> 
        /// </summary>
        public Javax.Swing.Icon SmallDisplayIcon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getSmallDisplayIcon", "()Ljavax/swing/Icon;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#updateChooser()"/>
        /// </summary>
        public void UpdateChooser()
        {
            IExecuteWithSignature("updateChooser", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#isColorTransparencySelectionEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsColorTransparencySelectionEnabled()
        {
            return IExecuteWithSignature<bool>("isColorTransparencySelectionEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#installChooserPanel(javax.swing.JColorChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JColorChooser"/></param>
        public void InstallChooserPanel(Javax.Swing.JColorChooser arg0)
        {
            IExecuteWithSignature("installChooserPanel", "(Ljavax/swing/JColorChooser;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#setColorTransparencySelectionEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetColorTransparencySelectionEnabled(bool arg0)
        {
            IExecuteWithSignature("setColorTransparencySelectionEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#uninstallChooserPanel(javax.swing.JColorChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JColorChooser"/></param>
        public void UninstallChooserPanel(Javax.Swing.JColorChooser arg0)
        {
            IExecuteWithSignature("uninstallChooserPanel", "(Ljavax/swing/JColorChooser;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}