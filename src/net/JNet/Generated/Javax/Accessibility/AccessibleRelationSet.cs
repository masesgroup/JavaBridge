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

namespace Javax.Accessibility
{
    #region AccessibleRelationSet
    public partial class AccessibleRelationSet
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#%3Cinit%3E(javax.accessibility.AccessibleRelation[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Accessibility.AccessibleRelation"/></param>
        public AccessibleRelationSet(Javax.Accessibility.AccessibleRelation[] arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#add(javax.accessibility.AccessibleRelation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Accessibility.AccessibleRelation"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(Javax.Accessibility.AccessibleRelation arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Ljavax/accessibility/AccessibleRelation;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#contains(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#remove(javax.accessibility.AccessibleRelation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Accessibility.AccessibleRelation"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(Javax.Accessibility.AccessibleRelation arg0)
        {
            return IExecuteWithSignature<bool>("remove", "(Ljavax/accessibility/AccessibleRelation;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Accessibility.AccessibleRelation"/></returns>
        public Javax.Accessibility.AccessibleRelation Get(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Accessibility.AccessibleRelation>("get", "(Ljava/lang/String;)Ljavax/accessibility/AccessibleRelation;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#toArray()"/>
        /// </summary>
        /// <returns><see cref="Javax.Accessibility.AccessibleRelation"/></returns>
        public Javax.Accessibility.AccessibleRelation[] ToArray()
        {
            return IExecuteWithSignatureArray<Javax.Accessibility.AccessibleRelation>("toArray", "()[Ljavax/accessibility/AccessibleRelation;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#addAll(javax.accessibility.AccessibleRelation[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Accessibility.AccessibleRelation"/></param>
        public void AddAll(Javax.Accessibility.AccessibleRelation[] arg0)
        {
            IExecuteWithSignature("addAll", "([Ljavax/accessibility/AccessibleRelation;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#clear()"/>
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