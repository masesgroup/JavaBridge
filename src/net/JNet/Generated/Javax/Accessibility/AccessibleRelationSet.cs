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
            return IExecute<bool>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#contains(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(string arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#remove(javax.accessibility.AccessibleRelation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Accessibility.AccessibleRelation"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(Javax.Accessibility.AccessibleRelation arg0)
        {
            return IExecute<bool>("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#size()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Accessibility.AccessibleRelation"/></returns>
        public Javax.Accessibility.AccessibleRelation Get(string arg0)
        {
            return IExecute<Javax.Accessibility.AccessibleRelation>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#toArray()"/>
        /// </summary>

        /// <returns><see cref="Javax.Accessibility.AccessibleRelation"/></returns>
        public Javax.Accessibility.AccessibleRelation[] ToArray()
        {
            return IExecuteArray<Javax.Accessibility.AccessibleRelation>("toArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#addAll(javax.accessibility.AccessibleRelation[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Accessibility.AccessibleRelation"/></param>
        public void AddAll(Javax.Accessibility.AccessibleRelation[] arg0)
        {
            IExecute("addAll", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelationSet.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}