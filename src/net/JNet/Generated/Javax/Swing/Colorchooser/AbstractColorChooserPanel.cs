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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Colorchooser
{
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
        public static string TRANSPARENCY_ENABLED_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "TRANSPARENCY_ENABLED_PROPERTY"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#getColorSelectionModel()"/> 
        /// </summary>
        public Javax.Swing.Colorchooser.ColorSelectionModel ColorSelectionModel
        {
            get { return IExecute<Javax.Swing.Colorchooser.ColorSelectionModel>("getColorSelectionModel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#getDisplayedMnemonicIndex()"/> 
        /// </summary>
        public int DisplayedMnemonicIndex
        {
            get { return IExecute<int>("getDisplayedMnemonicIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#getDisplayName()"/> 
        /// </summary>
        public string DisplayName
        {
            get { return IExecute<string>("getDisplayName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#getLargeDisplayIcon()"/> 
        /// </summary>
        public Javax.Swing.Icon LargeDisplayIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getLargeDisplayIcon"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#getMnemonic()"/> 
        /// </summary>
        public int Mnemonic
        {
            get { return IExecute<int>("getMnemonic"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#getSmallDisplayIcon()"/> 
        /// </summary>
        public Javax.Swing.Icon SmallDisplayIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getSmallDisplayIcon"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#updateChooser()"/>
        /// </summary>
        public void UpdateChooser()
        {
            IExecute("updateChooser");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#isColorTransparencySelectionEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsColorTransparencySelectionEnabled()
        {
            return IExecute<bool>("isColorTransparencySelectionEnabled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#installChooserPanel(javax.swing.JColorChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JColorChooser"/></param>
        public void InstallChooserPanel(Javax.Swing.JColorChooser arg0)
        {
            IExecute("installChooserPanel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#setColorTransparencySelectionEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetColorTransparencySelectionEnabled(bool arg0)
        {
            IExecute("setColorTransparencySelectionEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/colorchooser/AbstractColorChooserPanel.html#uninstallChooserPanel(javax.swing.JColorChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JColorChooser"/></param>
        public void UninstallChooserPanel(Javax.Swing.JColorChooser arg0)
        {
            IExecute("uninstallChooserPanel", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}