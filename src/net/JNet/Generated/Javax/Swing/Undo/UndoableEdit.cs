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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Undo
{
    #region UndoableEdit
    public partial class UndoableEdit
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#canRedo()"/> 
        /// </summary>
        public bool CanRedo
        {
            get { return IExecute<bool>("canRedo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#canUndo()"/> 
        /// </summary>
        public bool CanUndo
        {
            get { return IExecute<bool>("canUndo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#isSignificant()"/> 
        /// </summary>
        public bool IsSignificant
        {
            get { return IExecute<bool>("isSignificant"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#getPresentationName()"/> 
        /// </summary>
        public string PresentationName
        {
            get { return IExecute<string>("getPresentationName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#getRedoPresentationName()"/> 
        /// </summary>
        public string RedoPresentationName
        {
            get { return IExecute<string>("getRedoPresentationName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#getUndoPresentationName()"/> 
        /// </summary>
        public string UndoPresentationName
        {
            get { return IExecute<string>("getUndoPresentationName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#addEdit(javax.swing.undo.UndoableEdit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Undo.UndoableEdit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddEdit(Javax.Swing.Undo.UndoableEdit arg0)
        {
            return IExecute<bool>("addEdit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#replaceEdit(javax.swing.undo.UndoableEdit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Undo.UndoableEdit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ReplaceEdit(Javax.Swing.Undo.UndoableEdit arg0)
        {
            return IExecute<bool>("replaceEdit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#die()"/>
        /// </summary>
        public void Die()
        {
            IExecute("die");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#redo()"/>
        /// </summary>
        
        /// <exception cref="Javax.Swing.Undo.CannotRedoException"/>
        public void Redo()
        {
            IExecute("redo");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#undo()"/>
        /// </summary>
        
        /// <exception cref="Javax.Swing.Undo.CannotUndoException"/>
        public void Undo()
        {
            IExecute("undo");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}