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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Attribute
{
    #region HashAttributeSet
    public partial class HashAttributeSet
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#%3Cinit%3E(javax.print.attribute.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.Attribute"/></param>
        public HashAttributeSet(Javax.Print.Attribute.Attribute arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#%3Cinit%3E(javax.print.attribute.Attribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.Attribute"/></param>
        public HashAttributeSet(Javax.Print.Attribute.Attribute[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#%3Cinit%3E(javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        public HashAttributeSet(Javax.Print.Attribute.AttributeSet arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.HashAttributeSet"/> to <see cref="Javax.Print.Attribute.AttributeSet"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.AttributeSet(Javax.Print.Attribute.HashAttributeSet t) => t.Cast<Javax.Print.Attribute.AttributeSet>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.HashAttributeSet"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Print.Attribute.HashAttributeSet t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#add(javax.print.attribute.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.Attribute"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(Javax.Print.Attribute.Attribute arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Ljavax/print/attribute/Attribute;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#addAll(javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll(Javax.Print.Attribute.AttributeSet arg0)
        {
            return IExecuteWithSignature<bool>("addAll", "(Ljavax/print/attribute/AttributeSet;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#containsKey(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<bool>("containsKey", "(Ljava/lang/Class;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#containsValue(javax.print.attribute.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.Attribute"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsValue(Javax.Print.Attribute.Attribute arg0)
        {
            return IExecuteWithSignature<bool>("containsValue", "(Ljavax/print/attribute/Attribute;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#isEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#remove(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<bool>("remove", "(Ljava/lang/Class;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#remove(javax.print.attribute.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.Attribute"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(Javax.Print.Attribute.Attribute arg0)
        {
            return IExecuteWithSignature<bool>("remove", "(Ljavax/print/attribute/Attribute;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#size()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#get(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Javax.Print.Attribute.Attribute"/></returns>
        public Javax.Print.Attribute.Attribute Get(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<Javax.Print.Attribute.Attribute>("get", "(Ljava/lang/Class;)Ljavax/print/attribute/Attribute;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#toArray()"/>
        /// </summary>

        /// <returns><see cref="Javax.Print.Attribute.Attribute"/></returns>
        public Javax.Print.Attribute.Attribute[] ToArray()
        {
            return IExecuteWithSignatureArray<Javax.Print.Attribute.Attribute>("toArray", "()[Ljavax/print/attribute/Attribute;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}