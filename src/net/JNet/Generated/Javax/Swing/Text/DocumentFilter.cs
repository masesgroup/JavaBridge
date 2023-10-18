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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region DocumentFilter
    public partial class DocumentFilter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.html#insertString(javax.swing.text.DocumentFilter.FilterBypass,int,java.lang.String,javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.DocumentFilter.FilterBypass"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void InsertString(Javax.Swing.Text.DocumentFilter.FilterBypass arg0, int arg1, string arg2, Javax.Swing.Text.AttributeSet arg3)
        {
            IExecute("insertString", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.html#remove(javax.swing.text.DocumentFilter.FilterBypass,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.DocumentFilter.FilterBypass"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Remove(Javax.Swing.Text.DocumentFilter.FilterBypass arg0, int arg1, int arg2)
        {
            IExecute("remove", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.html#replace(javax.swing.text.DocumentFilter.FilterBypass,int,int,java.lang.String,javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.DocumentFilter.FilterBypass"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Replace(Javax.Swing.Text.DocumentFilter.FilterBypass arg0, int arg1, int arg2, string arg3, Javax.Swing.Text.AttributeSet arg4)
        {
            IExecute("replace", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes
        #region FilterBypass
        public partial class FilterBypass
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.FilterBypass.html#getDocument()"/> 
            /// </summary>
            public Javax.Swing.Text.Document Document
            {
                get { return IExecute<Javax.Swing.Text.Document>("getDocument"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.FilterBypass.html#insertString(int,java.lang.String,javax.swing.text.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            /// <exception cref="Javax.Swing.Text.BadLocationException"/>
            public void InsertString(int arg0, string arg1, Javax.Swing.Text.AttributeSet arg2)
            {
                IExecute("insertString", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.FilterBypass.html#remove(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <exception cref="Javax.Swing.Text.BadLocationException"/>
            public void Remove(int arg0, int arg1)
            {
                IExecute("remove", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.FilterBypass.html#replace(int,int,java.lang.String,javax.swing.text.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="string"/></param>
            /// <param name="arg3"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            /// <exception cref="Javax.Swing.Text.BadLocationException"/>
            public void Replace(int arg0, int arg1, string arg2, Javax.Swing.Text.AttributeSet arg3)
            {
                IExecute("replace", arg0, arg1, arg2, arg3);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}