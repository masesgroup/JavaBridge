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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text.Html
{
    #region CSS
    public partial class CSS
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.Html.CSS"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Text.Html.CSS t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.html#getAllAttributeKeys()"/> 
        /// </summary>
        public static Javax.Swing.Text.Html.CSS.Attribute[] AllAttributeKeys
        {
            get { return SExecuteArray<Javax.Swing.Text.Html.CSS.Attribute>(LocalClazz, "getAllAttributeKeys"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.CSS.Attribute"/></returns>
        public static Javax.Swing.Text.Html.CSS.Attribute GetAttribute(string arg0)
        {
            return SExecute<Javax.Swing.Text.Html.CSS.Attribute>(LocalClazz, "getAttribute", arg0);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Attribute
        public partial class Attribute
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BACKGROUND"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BACKGROUND => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BACKGROUND");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BACKGROUND_ATTACHMENT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BACKGROUND_ATTACHMENT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BACKGROUND_ATTACHMENT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BACKGROUND_COLOR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BACKGROUND_COLOR => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BACKGROUND_COLOR");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BACKGROUND_IMAGE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BACKGROUND_IMAGE => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BACKGROUND_IMAGE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BACKGROUND_POSITION"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BACKGROUND_POSITION => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BACKGROUND_POSITION");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BACKGROUND_REPEAT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BACKGROUND_REPEAT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BACKGROUND_REPEAT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_BOTTOM"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_BOTTOM => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_BOTTOM");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_BOTTOM_COLOR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_BOTTOM_COLOR => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_BOTTOM_COLOR");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_BOTTOM_STYLE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_BOTTOM_STYLE => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_BOTTOM_STYLE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_BOTTOM_WIDTH"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_BOTTOM_WIDTH => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_BOTTOM_WIDTH");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_COLOR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_COLOR => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_COLOR");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_LEFT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_LEFT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_LEFT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_LEFT_COLOR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_LEFT_COLOR => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_LEFT_COLOR");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_LEFT_STYLE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_LEFT_STYLE => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_LEFT_STYLE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_LEFT_WIDTH"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_LEFT_WIDTH => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_LEFT_WIDTH");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_RIGHT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_RIGHT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_RIGHT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_RIGHT_COLOR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_RIGHT_COLOR => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_RIGHT_COLOR");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_RIGHT_STYLE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_RIGHT_STYLE => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_RIGHT_STYLE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_RIGHT_WIDTH"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_RIGHT_WIDTH => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_RIGHT_WIDTH");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_STYLE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_STYLE => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_STYLE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_TOP"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_TOP => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_TOP");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_TOP_COLOR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_TOP_COLOR => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_TOP_COLOR");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_TOP_STYLE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_TOP_STYLE => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_TOP_STYLE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_TOP_WIDTH"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_TOP_WIDTH => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_TOP_WIDTH");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_WIDTH"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_WIDTH => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("BORDER_WIDTH");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#CLEAR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute CLEAR => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("CLEAR");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#COLOR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute COLOR => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("COLOR");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#DISPLAY"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute DISPLAY => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("DISPLAY");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#FLOAT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute FLOAT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("FLOAT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#FONT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute FONT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("FONT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#FONT_FAMILY"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute FONT_FAMILY => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("FONT_FAMILY");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#FONT_SIZE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute FONT_SIZE => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("FONT_SIZE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#FONT_STYLE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute FONT_STYLE => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("FONT_STYLE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#FONT_VARIANT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute FONT_VARIANT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("FONT_VARIANT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#FONT_WEIGHT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute FONT_WEIGHT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("FONT_WEIGHT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#HEIGHT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute HEIGHT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("HEIGHT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#LETTER_SPACING"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute LETTER_SPACING => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("LETTER_SPACING");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#LINE_HEIGHT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute LINE_HEIGHT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("LINE_HEIGHT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#LIST_STYLE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute LIST_STYLE => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("LIST_STYLE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#LIST_STYLE_IMAGE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute LIST_STYLE_IMAGE => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("LIST_STYLE_IMAGE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#LIST_STYLE_POSITION"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute LIST_STYLE_POSITION => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("LIST_STYLE_POSITION");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#LIST_STYLE_TYPE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute LIST_STYLE_TYPE => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("LIST_STYLE_TYPE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#MARGIN"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute MARGIN => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("MARGIN");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#MARGIN_BOTTOM"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute MARGIN_BOTTOM => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("MARGIN_BOTTOM");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#MARGIN_LEFT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute MARGIN_LEFT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("MARGIN_LEFT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#MARGIN_RIGHT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute MARGIN_RIGHT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("MARGIN_RIGHT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#MARGIN_TOP"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute MARGIN_TOP => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("MARGIN_TOP");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#PADDING"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute PADDING => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("PADDING");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#PADDING_BOTTOM"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute PADDING_BOTTOM => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("PADDING_BOTTOM");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#PADDING_LEFT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute PADDING_LEFT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("PADDING_LEFT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#PADDING_RIGHT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute PADDING_RIGHT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("PADDING_RIGHT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#PADDING_TOP"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute PADDING_TOP => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("PADDING_TOP");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#TEXT_ALIGN"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute TEXT_ALIGN => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("TEXT_ALIGN");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#TEXT_DECORATION"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute TEXT_DECORATION => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("TEXT_DECORATION");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#TEXT_INDENT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute TEXT_INDENT => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("TEXT_INDENT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#TEXT_TRANSFORM"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute TEXT_TRANSFORM => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("TEXT_TRANSFORM");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#VERTICAL_ALIGN"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute VERTICAL_ALIGN => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("VERTICAL_ALIGN");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#WHITE_SPACE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute WHITE_SPACE => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("WHITE_SPACE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#WIDTH"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute WIDTH => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("WIDTH");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#WORD_SPACING"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute WORD_SPACING => Clazz.GetField<Javax.Swing.Text.Html.CSS.Attribute>("WORD_SPACING");
            
            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#getDefaultValue()"/> 
            /// </summary>
            public string DefaultValue
            {
                get { return IExecute<string>("getDefaultValue"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#isInherited()"/> 
            /// </summary>
            public bool IsInherited
            {
                get { return IExecute<bool>("isInherited"); }
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}