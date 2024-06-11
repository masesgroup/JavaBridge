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
    #region IStyledDocument
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IStyledDocument : Javax.Swing.Text.IDocument
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#getBackground(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        Java.Awt.Color GetBackground(Javax.Swing.Text.AttributeSet arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#getForeground(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        Java.Awt.Color GetForeground(Javax.Swing.Text.AttributeSet arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#getFont(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        Java.Awt.Font GetFont(Javax.Swing.Text.AttributeSet arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#getCharacterElement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Element"/></returns>
        Javax.Swing.Text.Element GetCharacterElement(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#getParagraphElement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Element"/></returns>
        Javax.Swing.Text.Element GetParagraphElement(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#addStyle(java.lang.String,javax.swing.text.Style)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Style"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        Javax.Swing.Text.Style AddStyle(Java.Lang.String arg0, Javax.Swing.Text.Style arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#getLogicalStyle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        Javax.Swing.Text.Style GetLogicalStyle(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#getStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        Javax.Swing.Text.Style GetStyle(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#removeStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        void RemoveStyle(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#setCharacterAttributes(int,int,javax.swing.text.AttributeSet,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        void SetCharacterAttributes(int arg0, int arg1, Javax.Swing.Text.AttributeSet arg2, bool arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#setLogicalStyle(int,javax.swing.text.Style)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Style"/></param>
        void SetLogicalStyle(int arg0, Javax.Swing.Text.Style arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#setParagraphAttributes(int,int,javax.swing.text.AttributeSet,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        void SetParagraphAttributes(int arg0, int arg1, Javax.Swing.Text.AttributeSet arg2, bool arg3);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StyledDocument
    public partial class StyledDocument : Javax.Swing.Text.IStyledDocument
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#getBackground(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetBackground(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getBackground", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#getForeground(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetForeground(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getForeground", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#getFont(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font GetFont(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecuteWithSignature<Java.Awt.Font>("getFont", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Font;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#getCharacterElement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Element"/></returns>
        public Javax.Swing.Text.Element GetCharacterElement(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Element>("getCharacterElement", "(I)Ljavax/swing/text/Element;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#getParagraphElement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Element"/></returns>
        public Javax.Swing.Text.Element GetParagraphElement(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Element>("getParagraphElement", "(I)Ljavax/swing/text/Element;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#addStyle(java.lang.String,javax.swing.text.Style)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Style"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        public Javax.Swing.Text.Style AddStyle(Java.Lang.String arg0, Javax.Swing.Text.Style arg1)
        {
            return IExecute<Javax.Swing.Text.Style>("addStyle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#getLogicalStyle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        public Javax.Swing.Text.Style GetLogicalStyle(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Style>("getLogicalStyle", "(I)Ljavax/swing/text/Style;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#getStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        public Javax.Swing.Text.Style GetStyle(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Style>("getStyle", "(Ljava/lang/String;)Ljavax/swing/text/Style;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#removeStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RemoveStyle(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeStyle", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#setCharacterAttributes(int,int,javax.swing.text.AttributeSet,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public void SetCharacterAttributes(int arg0, int arg1, Javax.Swing.Text.AttributeSet arg2, bool arg3)
        {
            IExecute("setCharacterAttributes", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#setLogicalStyle(int,javax.swing.text.Style)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Style"/></param>
        public void SetLogicalStyle(int arg0, Javax.Swing.Text.Style arg1)
        {
            IExecute("setLogicalStyle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyledDocument.html#setParagraphAttributes(int,int,javax.swing.text.AttributeSet,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public void SetParagraphAttributes(int arg0, int arg1, Javax.Swing.Text.AttributeSet arg2, bool arg3)
        {
            IExecute("setParagraphAttributes", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}