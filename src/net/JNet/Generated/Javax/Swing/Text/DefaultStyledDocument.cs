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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region DefaultStyledDocument
    public partial class DefaultStyledDocument
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#%3Cinit%3E(javax.swing.text.AbstractDocument.Content,javax.swing.text.StyleContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AbstractDocument.Content"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.StyleContext"/></param>
        public DefaultStyledDocument(Javax.Swing.Text.AbstractDocument.Content arg0, Javax.Swing.Text.StyleContext arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#%3Cinit%3E(javax.swing.text.StyleContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.StyleContext"/></param>
        public DefaultStyledDocument(Javax.Swing.Text.StyleContext arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.DefaultStyledDocument"/> to <see cref="Javax.Swing.Text.StyledDocument"/>
        /// </summary>
        public static implicit operator Javax.Swing.Text.StyledDocument(Javax.Swing.Text.DefaultStyledDocument t) => t.Cast<Javax.Swing.Text.StyledDocument>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#BUFFER_SIZE_DEFAULT"/>
        /// </summary>
        public static int BUFFER_SIZE_DEFAULT { get { if (!_BUFFER_SIZE_DEFAULTReady) { _BUFFER_SIZE_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "BUFFER_SIZE_DEFAULT"); _BUFFER_SIZE_DEFAULTReady = true; } return _BUFFER_SIZE_DEFAULTContent; } }
        private static int _BUFFER_SIZE_DEFAULTContent = default;
        private static bool _BUFFER_SIZE_DEFAULTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#getStyleNames()"/> 
        /// </summary>
        public Java.Util.Enumeration<object> StyleNames
        {
            get { return IExecuteWithSignature<Java.Util.Enumeration<object>>("getStyleNames", "()Ljava/util/Enumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#getBackground(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetBackground(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getBackground", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#getForeground(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetForeground(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getForeground", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#getFont(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font GetFont(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecuteWithSignature<Java.Awt.Font>("getFont", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Font;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#getCharacterElement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Element"/></returns>
        public Javax.Swing.Text.Element GetCharacterElement(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Element>("getCharacterElement", "(I)Ljavax/swing/text/Element;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#addStyle(java.lang.String,javax.swing.text.Style)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Style"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        public Javax.Swing.Text.Style AddStyle(Java.Lang.String arg0, Javax.Swing.Text.Style arg1)
        {
            return IExecute<Javax.Swing.Text.Style>("addStyle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#getLogicalStyle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        public Javax.Swing.Text.Style GetLogicalStyle(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Style>("getLogicalStyle", "(I)Ljavax/swing/text/Style;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#getStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        public Javax.Swing.Text.Style GetStyle(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Style>("getStyle", "(Ljava/lang/String;)Ljavax/swing/text/Style;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#removeElement(javax.swing.text.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        public void RemoveElement(Javax.Swing.Text.Element arg0)
        {
            IExecuteWithSignature("removeElement", "(Ljavax/swing/text/Element;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#removeStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RemoveStyle(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeStyle", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#setCharacterAttributes(int,int,javax.swing.text.AttributeSet,boolean)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#setLogicalStyle(int,javax.swing.text.Style)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Style"/></param>
        public void SetLogicalStyle(int arg0, Javax.Swing.Text.Style arg1)
        {
            IExecute("setLogicalStyle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.html#setParagraphAttributes(int,int,javax.swing.text.AttributeSet,boolean)"/>
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
        #region AttributeUndoableEdit
        public partial class AttributeUndoableEdit
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.AttributeUndoableEdit.html#%3Cinit%3E(javax.swing.text.Element,javax.swing.text.AttributeSet,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            public AttributeUndoableEdit(Javax.Swing.Text.Element arg0, Javax.Swing.Text.AttributeSet arg1, bool arg2)
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

        #region ElementBuffer
        public partial class ElementBuffer
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementBuffer.html#%3Cinit%3E(javax.swing.text.DefaultStyledDocument,javax.swing.text.Element)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.DefaultStyledDocument"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.Element"/></param>
            public ElementBuffer(Javax.Swing.Text.DefaultStyledDocument arg0, Javax.Swing.Text.Element arg1)
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
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementBuffer.html#getRootElement()"/> 
            /// </summary>
            public Javax.Swing.Text.Element RootElement
            {
                get { return IExecuteWithSignature<Javax.Swing.Text.Element>("getRootElement", "()Ljavax/swing/text/Element;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementBuffer.html#clone(javax.swing.text.Element,javax.swing.text.Element)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.Element"/></param>
            /// <returns><see cref="Javax.Swing.Text.Element"/></returns>
            public Javax.Swing.Text.Element Clone(Javax.Swing.Text.Element arg0, Javax.Swing.Text.Element arg1)
            {
                return IExecute<Javax.Swing.Text.Element>("clone", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementBuffer.html#change(int,int,javax.swing.text.AbstractDocument.DefaultDocumentEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Text.AbstractDocument.DefaultDocumentEvent"/></param>
            public void Change(int arg0, int arg1, Javax.Swing.Text.AbstractDocument.DefaultDocumentEvent arg2)
            {
                IExecute("change", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementBuffer.html#insert(int,int,javax.swing.text.DefaultStyledDocument.ElementSpec[],javax.swing.text.AbstractDocument.DefaultDocumentEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Text.DefaultStyledDocument.ElementSpec"/></param>
            /// <param name="arg3"><see cref="Javax.Swing.Text.AbstractDocument.DefaultDocumentEvent"/></param>
            public void Insert(int arg0, int arg1, Javax.Swing.Text.DefaultStyledDocument.ElementSpec[] arg2, Javax.Swing.Text.AbstractDocument.DefaultDocumentEvent arg3)
            {
                IExecute("insert", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementBuffer.html#remove(int,int,javax.swing.text.AbstractDocument.DefaultDocumentEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Text.AbstractDocument.DefaultDocumentEvent"/></param>
            public void Remove(int arg0, int arg1, Javax.Swing.Text.AbstractDocument.DefaultDocumentEvent arg2)
            {
                IExecute("remove", arg0, arg1, arg2);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ElementSpec
        public partial class ElementSpec
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#%3Cinit%3E(javax.swing.text.AttributeSet,short,char[],int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <param name="arg2"><see cref="char"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            public ElementSpec(Javax.Swing.Text.AttributeSet arg0, short arg1, char[] arg2, int arg3, int arg4)
                : base(arg0, arg1, arg2, arg3, arg4)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#%3Cinit%3E(javax.swing.text.AttributeSet,short,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public ElementSpec(Javax.Swing.Text.AttributeSet arg0, short arg1, int arg2)
                : base(arg0, arg1, arg2)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#%3Cinit%3E(javax.swing.text.AttributeSet,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            public ElementSpec(Javax.Swing.Text.AttributeSet arg0, short arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#ContentType"/>
            /// </summary>
            public static short ContentType { get { if (!_ContentTypeReady) { _ContentTypeContent = SGetField<short>(LocalBridgeClazz, "ContentType"); _ContentTypeReady = true; } return _ContentTypeContent; } }
            private static short _ContentTypeContent = default;
            private static bool _ContentTypeReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#EndTagType"/>
            /// </summary>
            public static short EndTagType { get { if (!_EndTagTypeReady) { _EndTagTypeContent = SGetField<short>(LocalBridgeClazz, "EndTagType"); _EndTagTypeReady = true; } return _EndTagTypeContent; } }
            private static short _EndTagTypeContent = default;
            private static bool _EndTagTypeReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#JoinFractureDirection"/>
            /// </summary>
            public static short JoinFractureDirection { get { if (!_JoinFractureDirectionReady) { _JoinFractureDirectionContent = SGetField<short>(LocalBridgeClazz, "JoinFractureDirection"); _JoinFractureDirectionReady = true; } return _JoinFractureDirectionContent; } }
            private static short _JoinFractureDirectionContent = default;
            private static bool _JoinFractureDirectionReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#JoinNextDirection"/>
            /// </summary>
            public static short JoinNextDirection { get { if (!_JoinNextDirectionReady) { _JoinNextDirectionContent = SGetField<short>(LocalBridgeClazz, "JoinNextDirection"); _JoinNextDirectionReady = true; } return _JoinNextDirectionContent; } }
            private static short _JoinNextDirectionContent = default;
            private static bool _JoinNextDirectionReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#JoinPreviousDirection"/>
            /// </summary>
            public static short JoinPreviousDirection { get { if (!_JoinPreviousDirectionReady) { _JoinPreviousDirectionContent = SGetField<short>(LocalBridgeClazz, "JoinPreviousDirection"); _JoinPreviousDirectionReady = true; } return _JoinPreviousDirectionContent; } }
            private static short _JoinPreviousDirectionContent = default;
            private static bool _JoinPreviousDirectionReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#OriginateDirection"/>
            /// </summary>
            public static short OriginateDirection { get { if (!_OriginateDirectionReady) { _OriginateDirectionContent = SGetField<short>(LocalBridgeClazz, "OriginateDirection"); _OriginateDirectionReady = true; } return _OriginateDirectionContent; } }
            private static short _OriginateDirectionContent = default;
            private static bool _OriginateDirectionReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#StartTagType"/>
            /// </summary>
            public static short StartTagType { get { if (!_StartTagTypeReady) { _StartTagTypeContent = SGetField<short>(LocalBridgeClazz, "StartTagType"); _StartTagTypeReady = true; } return _StartTagTypeContent; } }
            private static short _StartTagTypeContent = default;
            private static bool _StartTagTypeReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#getArray()"/> 
            /// </summary>
            public char[] Array
            {
                get { return IExecuteWithSignatureArray<char>("getArray", "()[C"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#getAttributes()"/> 
            /// </summary>
            public Javax.Swing.Text.AttributeSet Attributes
            {
                get { return IExecuteWithSignature<Javax.Swing.Text.AttributeSet>("getAttributes", "()Ljavax/swing/text/AttributeSet;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#getDirection()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#setDirection(short)"/>
            /// </summary>
            public short Direction
            {
                get { return IExecuteWithSignature<short>("getDirection", "()S"); } set { IExecuteWithSignature("setDirection", "(S)V", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#getLength()"/> 
            /// </summary>
            public int Length
            {
                get { return IExecuteWithSignature<int>("getLength", "()I"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#getOffset()"/> 
            /// </summary>
            public int Offset
            {
                get { return IExecuteWithSignature<int>("getOffset", "()I"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#getType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultStyledDocument.ElementSpec.html#setType(short)"/>
            /// </summary>
            public short Type
            {
                get { return IExecuteWithSignature<short>("getType", "()S"); } set { IExecuteWithSignature("setType", "(S)V", value); }
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