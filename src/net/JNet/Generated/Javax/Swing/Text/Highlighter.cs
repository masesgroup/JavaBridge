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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region IHighlighter
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHighlighter
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#getHighlights()"/> 
        /// </summary>
        Javax.Swing.Text.Highlighter.Highlight[] Highlights { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#addHighlight(int,int,javax.swing.text.Highlighter.HighlightPainter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.Highlighter.HighlightPainter"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        object AddHighlight(int arg0, int arg1, Javax.Swing.Text.Highlighter.HighlightPainter arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#changeHighlight(java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        void ChangeHighlight(object arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#deinstall(javax.swing.text.JTextComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        void Deinstall(Javax.Swing.Text.JTextComponent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#install(javax.swing.text.JTextComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        void Install(Javax.Swing.Text.JTextComponent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#paint(java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        void Paint(Java.Awt.Graphics arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#removeAllHighlights()"/>
        /// </summary>
        void RemoveAllHighlights();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#removeHighlight(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        void RemoveHighlight(object arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Highlighter
    public partial class Highlighter : Javax.Swing.Text.IHighlighter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#getHighlights()"/> 
        /// </summary>
        public Javax.Swing.Text.Highlighter.Highlight[] Highlights
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Text.Highlighter.Highlight>("getHighlights", "()[Ljavax/swing/text/Highlighter$Highlight;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#addHighlight(int,int,javax.swing.text.Highlighter.HighlightPainter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.Highlighter.HighlightPainter"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public object AddHighlight(int arg0, int arg1, Javax.Swing.Text.Highlighter.HighlightPainter arg2)
        {
            return IExecute("addHighlight", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#changeHighlight(java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void ChangeHighlight(object arg0, int arg1, int arg2)
        {
            IExecute("changeHighlight", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#deinstall(javax.swing.text.JTextComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        public void Deinstall(Javax.Swing.Text.JTextComponent arg0)
        {
            IExecuteWithSignature("deinstall", "(Ljavax/swing/text/JTextComponent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#install(javax.swing.text.JTextComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        public void Install(Javax.Swing.Text.JTextComponent arg0)
        {
            IExecuteWithSignature("install", "(Ljavax/swing/text/JTextComponent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#paint(java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        public void Paint(Java.Awt.Graphics arg0)
        {
            IExecuteWithSignature("paint", "(Ljava/awt/Graphics;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#removeAllHighlights()"/>
        /// </summary>
        public void RemoveAllHighlights()
        {
            IExecuteWithSignature("removeAllHighlights", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.html#removeHighlight(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void RemoveHighlight(object arg0)
        {
            IExecuteWithSignature("removeHighlight", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Highlight
        public partial class Highlight
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.Highlight.html#getEndOffset()"/> 
            /// </summary>
            public int EndOffset
            {
                get { return IExecuteWithSignature<int>("getEndOffset", "()I"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.Highlight.html#getPainter()"/> 
            /// </summary>
            public Javax.Swing.Text.Highlighter.HighlightPainter Painter
            {
                get { return IExecuteWithSignature<Javax.Swing.Text.Highlighter.HighlightPainter>("getPainter", "()Ljavax/swing/text/Highlighter$HighlightPainter;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.Highlight.html#getStartOffset()"/> 
            /// </summary>
            public int StartOffset
            {
                get { return IExecuteWithSignature<int>("getStartOffset", "()I"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region HighlightPainter
        public partial class HighlightPainter
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Highlighter.HighlightPainter.html#paint(java.awt.Graphics,int,int,java.awt.Shape,javax.swing.text.JTextComponent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="Java.Awt.Shape"/></param>
            /// <param name="arg4"><see cref="Javax.Swing.Text.JTextComponent"/></param>
            public void Paint(Java.Awt.Graphics arg0, int arg1, int arg2, Java.Awt.Shape arg3, Javax.Swing.Text.JTextComponent arg4)
            {
                IExecute("paint", arg0, arg1, arg2, arg3, arg4);
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