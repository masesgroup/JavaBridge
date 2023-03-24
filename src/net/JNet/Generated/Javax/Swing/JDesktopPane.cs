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

namespace Javax.Swing
{
    #region JDesktopPane
    public partial class JDesktopPane
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JDesktopPane"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JDesktopPane t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#LIVE_DRAG_MODE"/>
        /// </summary>
        public static int LIVE_DRAG_MODE => Clazz.GetField<int>("LIVE_DRAG_MODE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#OUTLINE_DRAG_MODE"/>
        /// </summary>
        public static int OUTLINE_DRAG_MODE => Clazz.GetField<int>("OUTLINE_DRAG_MODE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#getAllFrames()"/> 
        /// </summary>
        public Javax.Swing.JInternalFrame[] AllFrames
        {
            get { return IExecuteArray<Javax.Swing.JInternalFrame>("getAllFrames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#getDesktopManager()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#setDesktopManager(javax.swing.DesktopManager)"/>
        /// </summary>
        public Javax.Swing.DesktopManager DesktopManager
        {
            get { return IExecute<Javax.Swing.DesktopManager>("getDesktopManager"); } set { IExecute("setDesktopManager", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#getDragMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#setDragMode(int)"/>
        /// </summary>
        public int DragMode
        {
            get { return IExecute<int>("getDragMode"); } set { IExecute("setDragMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#getSelectedFrame()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#setSelectedFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        public Javax.Swing.JInternalFrame SelectedFrame
        {
            get { return IExecute<Javax.Swing.JInternalFrame>("getSelectedFrame"); } set { IExecute("setSelectedFrame", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#selectFrame(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Swing.JInternalFrame"/></returns>
        public Javax.Swing.JInternalFrame SelectFrame(bool arg0)
        {
            return IExecute<Javax.Swing.JInternalFrame>("selectFrame", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#getAllFramesInLayer(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.JInternalFrame"/></returns>
        public Javax.Swing.JInternalFrame[] GetAllFramesInLayer(int arg0)
        {
            return IExecuteArray<Javax.Swing.JInternalFrame>("getAllFramesInLayer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#setUI(javax.swing.plaf.DesktopPaneUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.DesktopPaneUI"/></param>
        public void SetUI(Javax.Swing.Plaf.DesktopPaneUI arg0)
        {
            IExecute("setUI", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}