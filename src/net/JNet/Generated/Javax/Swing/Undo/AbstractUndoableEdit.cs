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

namespace Javax.Swing.Undo
{
    #region AbstractUndoableEdit
    public partial class AbstractUndoableEdit
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Undo.AbstractUndoableEdit"/> to <see cref="Javax.Swing.Undo.UndoableEdit"/>
        /// </summary>
        public static implicit operator Javax.Swing.Undo.UndoableEdit(Javax.Swing.Undo.AbstractUndoableEdit t) => t.Cast<Javax.Swing.Undo.UndoableEdit>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Undo.AbstractUndoableEdit"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Undo.AbstractUndoableEdit t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/AbstractUndoableEdit.html#getPresentationName()"/> 
        /// </summary>
        public string PresentationName
        {
            get { return IExecute<string>("getPresentationName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/AbstractUndoableEdit.html#getRedoPresentationName()"/> 
        /// </summary>
        public string RedoPresentationName
        {
            get { return IExecute<string>("getRedoPresentationName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/AbstractUndoableEdit.html#getUndoPresentationName()"/> 
        /// </summary>
        public string UndoPresentationName
        {
            get { return IExecute<string>("getUndoPresentationName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/AbstractUndoableEdit.html#addEdit(javax.swing.undo.UndoableEdit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Undo.UndoableEdit"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool AddEdit(Javax.Swing.Undo.UndoableEdit arg0)
        {
            return IExecute<bool>("addEdit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/AbstractUndoableEdit.html#canRedo()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool CanRedo()
        {
            return IExecute<bool>("canRedo");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/AbstractUndoableEdit.html#canUndo()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool CanUndo()
        {
            return IExecute<bool>("canUndo");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/AbstractUndoableEdit.html#isSignificant()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsSignificant()
        {
            return IExecute<bool>("isSignificant");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/AbstractUndoableEdit.html#replaceEdit(javax.swing.undo.UndoableEdit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Undo.UndoableEdit"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool ReplaceEdit(Javax.Swing.Undo.UndoableEdit arg0)
        {
            return IExecute<bool>("replaceEdit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/AbstractUndoableEdit.html#die()"/>
        /// </summary>
        public void Die()
        {
            IExecute("die");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/AbstractUndoableEdit.html#redo()"/>
        /// </summary>
        
        /// <exception cref="Javax.Swing.Undo.CannotRedoException"/>
        public void Redo()
        {
            IExecute("redo");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/AbstractUndoableEdit.html#undo.AbstractUndoableEdit.undo()"/>
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