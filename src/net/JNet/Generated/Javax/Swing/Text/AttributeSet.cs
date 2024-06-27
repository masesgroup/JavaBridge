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
    #region IAttributeSet
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAttributeSet
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#getAttributeCount()"/> 
        /// </summary>
        int AttributeCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#getAttributeNames()"/> 
        /// </summary>
        Java.Util.Enumeration<object> AttributeNames { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#getResolveParent()"/> 
        /// </summary>
        Javax.Swing.Text.AttributeSet ResolveParent { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#containsAttribute(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        bool ContainsAttribute(object arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#containsAttributes(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="bool"/></returns>
        bool ContainsAttributes(Javax.Swing.Text.AttributeSet arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#isDefined(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsDefined(object arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#isEqual(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsEqual(Javax.Swing.Text.AttributeSet arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#getAttribute(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        object GetAttribute(object arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#copyAttributes()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.Text.AttributeSet"/></returns>
        Javax.Swing.Text.AttributeSet CopyAttributes();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AttributeSet
    public partial class AttributeSet : Javax.Swing.Text.IAttributeSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#NameAttribute"/>
        /// </summary>
        public static object NameAttribute { get { if (!_NameAttributeReady) { _NameAttributeContent = SGetField(LocalBridgeClazz, "NameAttribute"); _NameAttributeReady = true; } return _NameAttributeContent; } }
        private static object _NameAttributeContent = default;
        private static bool _NameAttributeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#ResolveAttribute"/>
        /// </summary>
        public static object ResolveAttribute { get { if (!_ResolveAttributeReady) { _ResolveAttributeContent = SGetField(LocalBridgeClazz, "ResolveAttribute"); _ResolveAttributeReady = true; } return _ResolveAttributeContent; } }
        private static object _ResolveAttributeContent = default;
        private static bool _ResolveAttributeReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#getAttributeCount()"/> 
        /// </summary>
        public int AttributeCount
        {
            get { return IExecuteWithSignature<int>("getAttributeCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#getAttributeNames()"/> 
        /// </summary>
        public Java.Util.Enumeration<object> AttributeNames
        {
            get { return IExecuteWithSignature<Java.Util.Enumeration<object>>("getAttributeNames", "()Ljava/util/Enumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#getResolveParent()"/> 
        /// </summary>
        public Javax.Swing.Text.AttributeSet ResolveParent
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.AttributeSet>("getResolveParent", "()Ljavax/swing/text/AttributeSet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#containsAttribute(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAttribute(object arg0, object arg1)
        {
            return IExecute<bool>("containsAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#containsAttributes(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAttributes(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecuteWithSignature<bool>("containsAttributes", "(Ljavax/swing/text/AttributeSet;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#isDefined(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDefined(object arg0)
        {
            return IExecuteWithSignature<bool>("isDefined", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#isEqual(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEqual(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecuteWithSignature<bool>("isEqual", "(Ljavax/swing/text/AttributeSet;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#getAttribute(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAttribute(object arg0)
        {
            return IExecuteWithSignature("getAttribute", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AttributeSet.html#copyAttributes()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.Text.AttributeSet"/></returns>
        public Javax.Swing.Text.AttributeSet CopyAttributes()
        {
            return IExecuteWithSignature<Javax.Swing.Text.AttributeSet>("copyAttributes", "()Ljavax/swing/text/AttributeSet;");
        }

        #endregion

        #region Nested classes
        #region CharacterAttribute
        public partial class CharacterAttribute
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ColorAttribute
        public partial class ColorAttribute
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region FontAttribute
        public partial class FontAttribute
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ParagraphAttribute
        public partial class ParagraphAttribute
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