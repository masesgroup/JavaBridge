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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Undo
{
    #region UndoableEditSupport
    public partial class UndoableEditSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEditSupport.html#%3Cinit%3E(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public UndoableEditSupport(object arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEditSupport.html#getUndoableEditListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.UndoableEditListener[] UndoableEditListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.UndoableEditListener>("getUndoableEditListeners", "()[Ljavax/swing/event/UndoableEditListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEditSupport.html#getUpdateLevel()"/> 
        /// </summary>
        public int UpdateLevel
        {
            get { return IExecuteWithSignature<int>("getUpdateLevel", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEditSupport.html#addUndoableEditListener(javax.swing.event.UndoableEditListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.UndoableEditListener"/></param>
        public void AddUndoableEditListener(Javax.Swing.Event.UndoableEditListener arg0)
        {
            IExecuteWithSignature("addUndoableEditListener", "(Ljavax/swing/event/UndoableEditListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEditSupport.html#beginUpdate()"/>
        /// </summary>
        public void BeginUpdate()
        {
            IExecuteWithSignature("beginUpdate", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEditSupport.html#endUpdate()"/>
        /// </summary>
        public void EndUpdate()
        {
            IExecuteWithSignature("endUpdate", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEditSupport.html#postEdit(javax.swing.undo.UndoableEdit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Undo.UndoableEdit"/></param>
        public void PostEdit(Javax.Swing.Undo.UndoableEdit arg0)
        {
            IExecuteWithSignature("postEdit", "(Ljavax/swing/undo/UndoableEdit;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEditSupport.html#removeUndoableEditListener(javax.swing.event.UndoableEditListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.UndoableEditListener"/></param>
        public void RemoveUndoableEditListener(Javax.Swing.Event.UndoableEditListener arg0)
        {
            IExecuteWithSignature("removeUndoableEditListener", "(Ljavax/swing/event/UndoableEditListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}