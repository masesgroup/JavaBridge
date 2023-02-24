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

namespace Javax.Swing.Text
{
    #region Caret
    public partial class Caret
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#getBlinkRate()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#setBlinkRate(int)"/>
        /// </summary>
        public int BlinkRate
        {
            get { return IExecute<int>("getBlinkRate"); } set { IExecute("setBlinkRate", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#getDot()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#setDot(int)"/>
        /// </summary>
        public int Dot
        {
            get { return IExecute<int>("getDot"); } set { IExecute("setDot", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#getMagicCaretPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#setMagicCaretPosition(java.awt.Point)"/>
        /// </summary>
        public Java.Awt.Point MagicCaretPosition
        {
            get { return IExecute<Java.Awt.Point>("getMagicCaretPosition"); } set { IExecute("setMagicCaretPosition", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#getMark()"/> 
        /// </summary>
        public int Mark
        {
            get { return IExecute<int>("getMark"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#isSelectionVisible()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsSelectionVisible()
        {
            return IExecute<bool>("isSelectionVisible");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#isVisible()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsVisible()
        {
            return IExecute<bool>("isVisible");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("addChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#deinstall(javax.swing.text.JTextComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        public void Deinstall(Javax.Swing.Text.JTextComponent arg0)
        {
            IExecute("deinstall", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#install(javax.swing.text.JTextComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        public void Install(Javax.Swing.Text.JTextComponent arg0)
        {
            IExecute("install", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#moveDot(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        public void MoveDot(int arg0)
        {
            IExecute("moveDot", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#paint(java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        public void Paint(Java.Awt.Graphics arg0)
        {
            IExecute("paint", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("removeChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#setSelectionVisible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see langword="bool"/></param>
        public void SetSelectionVisible(bool arg0)
        {
            IExecute("setSelectionVisible", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Caret.html#setVisible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see langword="bool"/></param>
        public void SetVisible(bool arg0)
        {
            IExecute("setVisible", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}