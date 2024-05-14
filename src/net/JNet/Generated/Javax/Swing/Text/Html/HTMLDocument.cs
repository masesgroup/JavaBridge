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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text.Html
{
    #region HTMLDocument
    public partial class HTMLDocument
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#%3Cinit%3E(javax.swing.text.AbstractDocument.Content,javax.swing.text.html.StyleSheet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AbstractDocument.Content"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Html.StyleSheet"/></param>
        public HTMLDocument(Javax.Swing.Text.AbstractDocument.Content arg0, Javax.Swing.Text.Html.StyleSheet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#%3Cinit%3E(javax.swing.text.html.StyleSheet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Html.StyleSheet"/></param>
        public HTMLDocument(Javax.Swing.Text.Html.StyleSheet arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#AdditionalComments"/>
        /// </summary>
        public static Java.Lang.String AdditionalComments { get { if (!_AdditionalCommentsReady) { _AdditionalCommentsContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "AdditionalComments"); _AdditionalCommentsReady = true; } return _AdditionalCommentsContent; } }
        private static Java.Lang.String _AdditionalCommentsContent = default;
        private static bool _AdditionalCommentsReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#getBase()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#setBase(java.net.URL)"/>
        /// </summary>
        public Java.Net.URL Base
        {
            get { return IExecuteWithSignature<Java.Net.URL>("getBase", "()Ljava/net/URL;"); } set { IExecuteWithSignature("setBase", "(Ljava/net/URL;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#getParser()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#setParser(javax.swing.text.html.HTMLEditorKit.Parser)"/>
        /// </summary>
        public Javax.Swing.Text.Html.HTMLEditorKit.Parser Parser
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.Html.HTMLEditorKit.Parser>("getParser", "()Ljavax/swing/text/html/HTMLEditorKit$Parser;"); } set { IExecuteWithSignature("setParser", "(Ljavax/swing/text/html/HTMLEditorKit$Parser;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#getPreservesUnknownTags()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#setPreservesUnknownTags(boolean)"/>
        /// </summary>
        public bool PreservesUnknownTags
        {
            get { return IExecuteWithSignature<bool>("getPreservesUnknownTags", "()Z"); } set { IExecuteWithSignature("setPreservesUnknownTags", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#getStyleSheet()"/> 
        /// </summary>
        public Javax.Swing.Text.Html.StyleSheet StyleSheet
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.Html.StyleSheet>("getStyleSheet", "()Ljavax/swing/text/html/StyleSheet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#getTokenThreshold()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#setTokenThreshold(int)"/>
        /// </summary>
        public int TokenThreshold
        {
            get { return IExecuteWithSignature<int>("getTokenThreshold", "()I"); } set { IExecuteWithSignature("setTokenThreshold", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#getElement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.Text.Element"/></returns>
        public Javax.Swing.Text.Element GetElement(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Element>("getElement", "(Ljava/lang/String;)Ljavax/swing/text/Element;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#getElement(javax.swing.text.Element,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="Javax.Swing.Text.Element"/></returns>
        public Javax.Swing.Text.Element GetElement(Javax.Swing.Text.Element arg0, object arg1, object arg2)
        {
            return IExecute<Javax.Swing.Text.Element>("getElement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#getIterator(javax.swing.text.html.HTML.Tag)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.HTMLDocument.Iterator"/></returns>
        public Javax.Swing.Text.Html.HTMLDocument.Iterator GetIterator(Javax.Swing.Text.Html.HTML.Tag arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Html.HTMLDocument.Iterator>("getIterator", "(Ljavax/swing/text/html/HTML$Tag;)Ljavax/swing/text/html/HTMLDocument$Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#getReader(int,int,int,javax.swing.text.html.HTML.Tag)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.HTMLEditorKit.ParserCallback"/></returns>
        public Javax.Swing.Text.Html.HTMLEditorKit.ParserCallback GetReader(int arg0, int arg1, int arg2, Javax.Swing.Text.Html.HTML.Tag arg3)
        {
            return IExecute<Javax.Swing.Text.Html.HTMLEditorKit.ParserCallback>("getReader", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#getReader(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.HTMLEditorKit.ParserCallback"/></returns>
        public Javax.Swing.Text.Html.HTMLEditorKit.ParserCallback GetReader(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Html.HTMLEditorKit.ParserCallback>("getReader", "(I)Ljavax/swing/text/html/HTMLEditorKit$ParserCallback;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#insertAfterEnd(javax.swing.text.Element,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void InsertAfterEnd(Javax.Swing.Text.Element arg0, Java.Lang.String arg1)
        {
            IExecute("insertAfterEnd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#insertAfterStart(javax.swing.text.Element,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void InsertAfterStart(Javax.Swing.Text.Element arg0, Java.Lang.String arg1)
        {
            IExecute("insertAfterStart", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#insertBeforeEnd(javax.swing.text.Element,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void InsertBeforeEnd(Javax.Swing.Text.Element arg0, Java.Lang.String arg1)
        {
            IExecute("insertBeforeEnd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#insertBeforeStart(javax.swing.text.Element,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void InsertBeforeStart(Javax.Swing.Text.Element arg0, Java.Lang.String arg1)
        {
            IExecute("insertBeforeStart", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#processHTMLFrameHyperlinkEvent(javax.swing.text.html.HTMLFrameHyperlinkEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLFrameHyperlinkEvent"/></param>
        public void ProcessHTMLFrameHyperlinkEvent(Javax.Swing.Text.Html.HTMLFrameHyperlinkEvent arg0)
        {
            IExecuteWithSignature("processHTMLFrameHyperlinkEvent", "(Ljavax/swing/text/html/HTMLFrameHyperlinkEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#setInnerHTML(javax.swing.text.Element,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void SetInnerHTML(Javax.Swing.Text.Element arg0, Java.Lang.String arg1)
        {
            IExecute("setInnerHTML", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.html#setOuterHTML(javax.swing.text.Element,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void SetOuterHTML(Javax.Swing.Text.Element arg0, Java.Lang.String arg1)
        {
            IExecute("setOuterHTML", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region BlockElement
        public partial class BlockElement
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.BlockElement.html#%3Cinit%3E(javax.swing.text.html.HTMLDocument,javax.swing.text.Element,javax.swing.text.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.Element"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            public BlockElement(Javax.Swing.Text.Html.HTMLDocument arg0, Javax.Swing.Text.Element arg1, Javax.Swing.Text.AttributeSet arg2)
                : base(arg0, arg1, arg2)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region HTMLReader
        public partial class HTMLReader
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.HTMLReader.html#%3Cinit%3E(javax.swing.text.html.HTMLDocument,int,int,int,javax.swing.text.html.HTML.Tag)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            public HTMLReader(Javax.Swing.Text.Html.HTMLDocument arg0, int arg1, int arg2, int arg3, Javax.Swing.Text.Html.HTML.Tag arg4)
                : base(arg0, arg1, arg2, arg3, arg4)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.HTMLReader.html#%3Cinit%3E(javax.swing.text.html.HTMLDocument,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public HTMLReader(Javax.Swing.Text.Html.HTMLDocument arg0, int arg1)
                : base(arg0, arg1)
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

            #endregion

            #region Nested classes
            #region FormAction
            public partial class FormAction
            {
                #region Constructors
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.HTMLReader.FormAction.html#%3Cinit%3E(javax.swing.text.html.HTMLDocument.HTMLReader)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument.HTMLReader"/></param>
                public FormAction(Javax.Swing.Text.Html.HTMLDocument.HTMLReader arg0)
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

                #endregion

                #region Nested classes

                #endregion

                // TODO: complete the class
            }
            #endregion

            #region CharacterAction
            public partial class CharacterAction
            {
                #region Constructors
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.HTMLReader.CharacterAction.html#%3Cinit%3E(javax.swing.text.html.HTMLDocument.HTMLReader)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument.HTMLReader"/></param>
                public CharacterAction(Javax.Swing.Text.Html.HTMLDocument.HTMLReader arg0)
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

                #endregion

                #region Nested classes

                #endregion

                // TODO: complete the class
            }
            #endregion

            #region PreAction
            public partial class PreAction
            {
                #region Constructors
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.HTMLReader.PreAction.html#%3Cinit%3E(javax.swing.text.html.HTMLDocument.HTMLReader)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument.HTMLReader"/></param>
                public PreAction(Javax.Swing.Text.Html.HTMLDocument.HTMLReader arg0)
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

                #endregion

                #region Nested classes

                #endregion

                // TODO: complete the class
            }
            #endregion

            #region HiddenAction
            public partial class HiddenAction
            {
                #region Constructors
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.HTMLReader.HiddenAction.html#%3Cinit%3E(javax.swing.text.html.HTMLDocument.HTMLReader)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument.HTMLReader"/></param>
                public HiddenAction(Javax.Swing.Text.Html.HTMLDocument.HTMLReader arg0)
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

                #endregion

                #region Nested classes

                #endregion

                // TODO: complete the class
            }
            #endregion

            #region IsindexAction
            public partial class IsindexAction
            {
                #region Constructors
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.HTMLReader.IsindexAction.html#%3Cinit%3E(javax.swing.text.html.HTMLDocument.HTMLReader)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument.HTMLReader"/></param>
                public IsindexAction(Javax.Swing.Text.Html.HTMLDocument.HTMLReader arg0)
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

                #endregion

                #region Nested classes

                #endregion

                // TODO: complete the class
            }
            #endregion

            #region SpecialAction
            public partial class SpecialAction
            {
                #region Constructors
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.HTMLReader.SpecialAction.html#%3Cinit%3E(javax.swing.text.html.HTMLDocument.HTMLReader)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument.HTMLReader"/></param>
                public SpecialAction(Javax.Swing.Text.Html.HTMLDocument.HTMLReader arg0)
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

                #endregion

                #region Nested classes

                #endregion

                // TODO: complete the class
            }
            #endregion

            #region ParagraphAction
            public partial class ParagraphAction
            {
                #region Constructors
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.HTMLReader.ParagraphAction.html#%3Cinit%3E(javax.swing.text.html.HTMLDocument.HTMLReader)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument.HTMLReader"/></param>
                public ParagraphAction(Javax.Swing.Text.Html.HTMLDocument.HTMLReader arg0)
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

                #endregion

                #region Nested classes

                #endregion

                // TODO: complete the class
            }
            #endregion

            #region BlockAction
            public partial class BlockAction
            {
                #region Constructors
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.HTMLReader.BlockAction.html#%3Cinit%3E(javax.swing.text.html.HTMLDocument.HTMLReader)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument.HTMLReader"/></param>
                public BlockAction(Javax.Swing.Text.Html.HTMLDocument.HTMLReader arg0)
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

                #endregion

                #region Nested classes

                #endregion

                // TODO: complete the class
            }
            #endregion

            #region TagAction
            public partial class TagAction
            {
                #region Constructors
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.HTMLReader.TagAction.html#%3Cinit%3E(javax.swing.text.html.HTMLDocument.HTMLReader)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument.HTMLReader"/></param>
                public TagAction(Javax.Swing.Text.Html.HTMLDocument.HTMLReader arg0)
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
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.HTMLReader.TagAction.html#end(javax.swing.text.html.HTML.Tag)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
                public void End(Javax.Swing.Text.Html.HTML.Tag arg0)
                {
                    IExecuteWithSignature("end", "(Ljavax/swing/text/html/HTML$Tag;)V", arg0);
                }
                /// <summary>
                /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.HTMLReader.TagAction.html#start(javax.swing.text.html.HTML.Tag,javax.swing.text.MutableAttributeSet)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
                /// <param name="arg1"><see cref="Javax.Swing.Text.MutableAttributeSet"/></param>
                public void Start(Javax.Swing.Text.Html.HTML.Tag arg0, Javax.Swing.Text.MutableAttributeSet arg1)
                {
                    IExecute("start", arg0, arg1);
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

        #region Iterator
        public partial class Iterator
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.Iterator.html#getAttributes()"/> 
            /// </summary>
            public Javax.Swing.Text.AttributeSet Attributes
            {
                get { return IExecuteWithSignature<Javax.Swing.Text.AttributeSet>("getAttributes", "()Ljavax/swing/text/AttributeSet;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.Iterator.html#getEndOffset()"/> 
            /// </summary>
            public int EndOffset
            {
                get { return IExecuteWithSignature<int>("getEndOffset", "()I"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.Iterator.html#getStartOffset()"/> 
            /// </summary>
            public int StartOffset
            {
                get { return IExecuteWithSignature<int>("getStartOffset", "()I"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.Iterator.html#getTag()"/> 
            /// </summary>
            public Javax.Swing.Text.Html.HTML.Tag Tag
            {
                get { return IExecuteWithSignature<Javax.Swing.Text.Html.HTML.Tag>("getTag", "()Ljavax/swing/text/html/HTML$Tag;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.Iterator.html#isValid()"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool IsValid()
            {
                return IExecuteWithSignature<bool>("isValid", "()Z");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.Iterator.html#next()"/>
            /// </summary>
            public void Next()
            {
                IExecuteWithSignature("next", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region RunElement
        public partial class RunElement
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLDocument.RunElement.html#%3Cinit%3E(javax.swing.text.html.HTMLDocument,javax.swing.text.Element,javax.swing.text.AttributeSet,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.Element"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            public RunElement(Javax.Swing.Text.Html.HTMLDocument arg0, Javax.Swing.Text.Element arg1, Javax.Swing.Text.AttributeSet arg2, int arg3, int arg4)
                : base(arg0, arg1, arg2, arg3, arg4)
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