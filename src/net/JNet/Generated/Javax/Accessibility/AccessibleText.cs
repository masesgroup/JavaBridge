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

namespace Javax.Accessibility
{
    #region AccessibleText
    public partial class AccessibleText
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleText.html#CHARACTER"/>
        /// </summary>
        public static int CHARACTER => Clazz.GetField<int>("CHARACTER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleText.html#SENTENCE"/>
        /// </summary>
        public static int SENTENCE => Clazz.GetField<int>("SENTENCE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleText.html#WORD"/>
        /// </summary>
        public static int WORD => Clazz.GetField<int>("WORD");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleText.html#getCaretPosition()"/> 
        /// </summary>
        public int CaretPosition
        {
            get { return IExecute<int>("getCaretPosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleText.html#getCharCount()"/> 
        /// </summary>
        public int CharCount
        {
            get { return IExecute<int>("getCharCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleText.html#getSelectedText()"/> 
        /// </summary>
        public string SelectedText
        {
            get { return IExecute<string>("getSelectedText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleText.html#getSelectionEnd()"/> 
        /// </summary>
        public int SelectionEnd
        {
            get { return IExecute<int>("getSelectionEnd"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleText.html#getSelectionStart()"/> 
        /// </summary>
        public int SelectionStart
        {
            get { return IExecute<int>("getSelectionStart"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleText.html#getIndexAtPoint(java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetIndexAtPoint(Java.Awt.Point arg0)
        {
            return IExecute<int>("getIndexAtPoint", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleText.html#getCharacterBounds(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public Java.Awt.Rectangle GetCharacterBounds(int arg0)
        {
            return IExecute<Java.Awt.Rectangle>("getCharacterBounds", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleText.html#getAfterIndex(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAfterIndex(int arg0, int arg1)
        {
            return IExecute<string>("getAfterIndex", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleText.html#getAtIndex(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAtIndex(int arg0, int arg1)
        {
            return IExecute<string>("getAtIndex", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleText.html#getBeforeIndex(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetBeforeIndex(int arg0, int arg1)
        {
            return IExecute<string>("getBeforeIndex", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleText.html#getCharacterAttribute(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.AttributeSet"/></returns>
        public Javax.Swing.Text.AttributeSet GetCharacterAttribute(int arg0)
        {
            return IExecute<Javax.Swing.Text.AttributeSet>("getCharacterAttribute", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}