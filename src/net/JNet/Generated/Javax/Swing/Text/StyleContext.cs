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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region StyleContext
    public partial class StyleContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.StyleContext"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Text.StyleContext t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#DEFAULT_STYLE"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_STYLE { get { if (!_DEFAULT_STYLEReady) { _DEFAULT_STYLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_STYLE"); _DEFAULT_STYLEReady = true; } return _DEFAULT_STYLEContent; } }
        private static Java.Lang.String _DEFAULT_STYLEContent = default;
        private static bool _DEFAULT_STYLEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#getDefaultStyleContext()"/> 
        /// </summary>
        public static Javax.Swing.Text.StyleContext DefaultStyleContext
        {
            get { return SExecuteWithSignature<Javax.Swing.Text.StyleContext>(LocalBridgeClazz, "getDefaultStyleContext", "()Ljavax/swing/text/StyleContext;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#getStaticAttribute(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public static object GetStaticAttribute(object arg0)
        {
            return SExecuteWithSignature(LocalBridgeClazz, "getStaticAttribute", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#getStaticAttributeKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public static object GetStaticAttributeKey(object arg0)
        {
            return SExecuteWithSignature(LocalBridgeClazz, "getStaticAttributeKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#readAttributeSet(java.io.ObjectInputStream,javax.swing.text.MutableAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectInputStream"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.MutableAttributeSet"/></param>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static void ReadAttributeSet(Java.Io.ObjectInputStream arg0, Javax.Swing.Text.MutableAttributeSet arg1)
        {
            SExecute(LocalBridgeClazz, "readAttributeSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#registerStaticAttributeKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public static void RegisterStaticAttributeKey(object arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "registerStaticAttributeKey", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#writeAttributeSet(java.io.ObjectOutputStream,javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectOutputStream"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void WriteAttributeSet(Java.Io.ObjectOutputStream arg0, Javax.Swing.Text.AttributeSet arg1)
        {
            SExecute(LocalBridgeClazz, "writeAttributeSet", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#getChangeListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ChangeListener[] ChangeListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.ChangeListener>("getChangeListeners", "()[Ljavax/swing/event/ChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#getEmptySet()"/> 
        /// </summary>
        public Javax.Swing.Text.AttributeSet EmptySet
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.AttributeSet>("getEmptySet", "()Ljavax/swing/text/AttributeSet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#getStyleNames()"/> 
        /// </summary>
        public Java.Util.Enumeration<object> StyleNames
        {
            get { return IExecuteWithSignature<Java.Util.Enumeration<object>>("getStyleNames", "()Ljava/util/Enumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#getBackground(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetBackground(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getBackground", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#getForeground(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetForeground(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getForeground", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#getFont(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font GetFont(Java.Lang.String arg0, int arg1, int arg2)
        {
            return IExecute<Java.Awt.Font>("getFont", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#getFont(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font GetFont(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecuteWithSignature<Java.Awt.Font>("getFont", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Font;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#getFontMetrics(java.awt.Font)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Font"/></param>
        /// <returns><see cref="Java.Awt.FontMetrics"/></returns>
        public Java.Awt.FontMetrics GetFontMetrics(Java.Awt.Font arg0)
        {
            return IExecuteWithSignature<Java.Awt.FontMetrics>("getFontMetrics", "(Ljava/awt/Font;)Ljava/awt/FontMetrics;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#addStyle(java.lang.String,javax.swing.text.Style)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Style"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        public Javax.Swing.Text.Style AddStyle(Java.Lang.String arg0, Javax.Swing.Text.Style arg1)
        {
            return IExecute<Javax.Swing.Text.Style>("addStyle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#getStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        public Javax.Swing.Text.Style GetStyle(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Style>("getStyle", "(Ljava/lang/String;)Ljavax/swing/text/Style;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#addAttribute(javax.swing.text.AttributeSet,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="Javax.Swing.Text.AttributeSet"/></returns>
        public Javax.Swing.Text.AttributeSet AddAttribute(Javax.Swing.Text.AttributeSet arg0, object arg1, object arg2)
        {
            return IExecute<Javax.Swing.Text.AttributeSet>("addAttribute", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#addAttributes(javax.swing.text.AttributeSet,javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Javax.Swing.Text.AttributeSet"/></returns>
        public Javax.Swing.Text.AttributeSet AddAttributes(Javax.Swing.Text.AttributeSet arg0, Javax.Swing.Text.AttributeSet arg1)
        {
            return IExecute<Javax.Swing.Text.AttributeSet>("addAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#removeAttribute(javax.swing.text.AttributeSet,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Javax.Swing.Text.AttributeSet"/></returns>
        public Javax.Swing.Text.AttributeSet RemoveAttribute(Javax.Swing.Text.AttributeSet arg0, object arg1)
        {
            return IExecute<Javax.Swing.Text.AttributeSet>("removeAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#removeAttributes(javax.swing.text.AttributeSet,java.util.Enumeration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <param name="arg1"><see cref="Java.Util.Enumeration"/></param>
        /// <returns><see cref="Javax.Swing.Text.AttributeSet"/></returns>
        public Javax.Swing.Text.AttributeSet RemoveAttributes(Javax.Swing.Text.AttributeSet arg0, Java.Util.Enumeration<object> arg1)
        {
            return IExecute<Javax.Swing.Text.AttributeSet>("removeAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#removeAttributes(javax.swing.text.AttributeSet,javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Javax.Swing.Text.AttributeSet"/></returns>
        public Javax.Swing.Text.AttributeSet RemoveAttributes(Javax.Swing.Text.AttributeSet arg0, Javax.Swing.Text.AttributeSet arg1)
        {
            return IExecute<Javax.Swing.Text.AttributeSet>("removeAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("addChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#readAttributes(java.io.ObjectInputStream,javax.swing.text.MutableAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectInputStream"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.MutableAttributeSet"/></param>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadAttributes(Java.Io.ObjectInputStream arg0, Javax.Swing.Text.MutableAttributeSet arg1)
        {
            IExecute("readAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#reclaim(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        public void Reclaim(Javax.Swing.Text.AttributeSet arg0)
        {
            IExecuteWithSignature("reclaim", "(Ljavax/swing/text/AttributeSet;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("removeChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#removeStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RemoveStyle(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeStyle", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.html#writeAttributes(java.io.ObjectOutputStream,javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectOutputStream"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteAttributes(Java.Io.ObjectOutputStream arg0, Javax.Swing.Text.AttributeSet arg1)
        {
            IExecute("writeAttributes", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region NamedStyle
        public partial class NamedStyle
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#%3Cinit%3E(javax.swing.text.StyleContext,java.lang.String,javax.swing.text.Style)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.StyleContext"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Text.Style"/></param>
            public NamedStyle(Javax.Swing.Text.StyleContext arg0, Java.Lang.String arg1, Javax.Swing.Text.Style arg2)
                : base(arg0, arg1, arg2)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#%3Cinit%3E(javax.swing.text.StyleContext,javax.swing.text.Style)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.StyleContext"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.Style"/></param>
            public NamedStyle(Javax.Swing.Text.StyleContext arg0, Javax.Swing.Text.Style arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#%3Cinit%3E(javax.swing.text.StyleContext)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.StyleContext"/></param>
            public NamedStyle(Javax.Swing.Text.StyleContext arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Text.StyleContext.NamedStyle"/> to <see cref="Javax.Swing.Text.Style"/>
            /// </summary>
            public static implicit operator Javax.Swing.Text.Style(Javax.Swing.Text.StyleContext.NamedStyle t) => t.Cast<Javax.Swing.Text.Style>();
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Text.StyleContext.NamedStyle"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Javax.Swing.Text.StyleContext.NamedStyle t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#getAttributeCount()"/> 
            /// </summary>
            public int AttributeCount
            {
                get { return IExecuteWithSignature<int>("getAttributeCount", "()I"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#getAttributeNames()"/> 
            /// </summary>
            public Java.Util.Enumeration<object> AttributeNames
            {
                get { return IExecuteWithSignature<Java.Util.Enumeration<object>>("getAttributeNames", "()Ljava/util/Enumeration;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#getChangeListeners()"/> 
            /// </summary>
            public Javax.Swing.Event.ChangeListener[] ChangeListeners
            {
                get { return IExecuteWithSignatureArray<Javax.Swing.Event.ChangeListener>("getChangeListeners", "()[Ljavax/swing/event/ChangeListener;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#setName(java.lang.String)"/>
            /// </summary>
            public Java.Lang.String Name
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setName", "(Ljava/lang/String;)V", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#getResolveParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#setResolveParent(javax.swing.text.AttributeSet)"/>
            /// </summary>
            public Javax.Swing.Text.AttributeSet ResolveParent
            {
                get { return IExecuteWithSignature<Javax.Swing.Text.AttributeSet>("getResolveParent", "()Ljavax/swing/text/AttributeSet;"); } set { IExecuteWithSignature("setResolveParent", "(Ljavax/swing/text/AttributeSet;)V", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#containsAttribute(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool ContainsAttribute(object arg0, object arg1)
            {
                return IExecute<bool>("containsAttribute", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#containsAttributes(javax.swing.text.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool ContainsAttributes(Javax.Swing.Text.AttributeSet arg0)
            {
                return IExecuteWithSignature<bool>("containsAttributes", "(Ljavax/swing/text/AttributeSet;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#isDefined(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsDefined(object arg0)
            {
                return IExecuteWithSignature<bool>("isDefined", "(Ljava/lang/Object;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#isEqual(javax.swing.text.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsEqual(Javax.Swing.Text.AttributeSet arg0)
            {
                return IExecuteWithSignature<bool>("isEqual", "(Ljavax/swing/text/AttributeSet;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#getAttribute(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object GetAttribute(object arg0)
            {
                return IExecuteWithSignature("getAttribute", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#copyAttributes()"/>
            /// </summary>
            /// <returns><see cref="Javax.Swing.Text.AttributeSet"/></returns>
            public Javax.Swing.Text.AttributeSet CopyAttributes()
            {
                return IExecuteWithSignature<Javax.Swing.Text.AttributeSet>("copyAttributes", "()Ljavax/swing/text/AttributeSet;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#addAttribute(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            public void AddAttribute(object arg0, object arg1)
            {
                IExecute("addAttribute", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#addAttributes(javax.swing.text.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            public void AddAttributes(Javax.Swing.Text.AttributeSet arg0)
            {
                IExecuteWithSignature("addAttributes", "(Ljavax/swing/text/AttributeSet;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#addChangeListener(javax.swing.event.ChangeListener)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
            public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
            {
                IExecuteWithSignature("addChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#removeAttribute(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            public void RemoveAttribute(object arg0)
            {
                IExecuteWithSignature("removeAttribute", "(Ljava/lang/Object;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#removeAttributes(java.util.Enumeration)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Enumeration"/></param>
            public void RemoveAttributes(Java.Util.Enumeration<object> arg0)
            {
                IExecuteWithSignature("removeAttributes", "(Ljava/util/Enumeration;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#removeAttributes(javax.swing.text.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            public void RemoveAttributes(Javax.Swing.Text.AttributeSet arg0)
            {
                IExecuteWithSignature("removeAttributes", "(Ljavax/swing/text/AttributeSet;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.NamedStyle.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
            public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
            {
                IExecuteWithSignature("removeChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SmallAttributeSet
        public partial class SmallAttributeSet
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.SmallAttributeSet.html#%3Cinit%3E(javax.swing.text.StyleContext,javax.swing.text.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.StyleContext"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            public SmallAttributeSet(Javax.Swing.Text.StyleContext arg0, Javax.Swing.Text.AttributeSet arg1)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.SmallAttributeSet.html#getAttributeCount()"/> 
            /// </summary>
            public int AttributeCount
            {
                get { return IExecuteWithSignature<int>("getAttributeCount", "()I"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.SmallAttributeSet.html#getAttributeNames()"/> 
            /// </summary>
            public Java.Util.Enumeration<object> AttributeNames
            {
                get { return IExecuteWithSignature<Java.Util.Enumeration<object>>("getAttributeNames", "()Ljava/util/Enumeration;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.SmallAttributeSet.html#getResolveParent()"/> 
            /// </summary>
            public Javax.Swing.Text.AttributeSet ResolveParent
            {
                get { return IExecuteWithSignature<Javax.Swing.Text.AttributeSet>("getResolveParent", "()Ljavax/swing/text/AttributeSet;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.SmallAttributeSet.html#containsAttribute(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool ContainsAttribute(object arg0, object arg1)
            {
                return IExecute<bool>("containsAttribute", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.SmallAttributeSet.html#containsAttributes(javax.swing.text.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool ContainsAttributes(Javax.Swing.Text.AttributeSet arg0)
            {
                return IExecuteWithSignature<bool>("containsAttributes", "(Ljavax/swing/text/AttributeSet;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.SmallAttributeSet.html#isDefined(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsDefined(object arg0)
            {
                return IExecuteWithSignature<bool>("isDefined", "(Ljava/lang/Object;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.SmallAttributeSet.html#isEqual(javax.swing.text.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsEqual(Javax.Swing.Text.AttributeSet arg0)
            {
                return IExecuteWithSignature<bool>("isEqual", "(Ljavax/swing/text/AttributeSet;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.SmallAttributeSet.html#getAttribute(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object GetAttribute(object arg0)
            {
                return IExecuteWithSignature("getAttribute", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/StyleContext.SmallAttributeSet.html#copyAttributes()"/>
            /// </summary>
            /// <returns><see cref="Javax.Swing.Text.AttributeSet"/></returns>
            public Javax.Swing.Text.AttributeSet CopyAttributes()
            {
                return IExecuteWithSignature<Javax.Swing.Text.AttributeSet>("copyAttributes", "()Ljavax/swing/text/AttributeSet;");
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