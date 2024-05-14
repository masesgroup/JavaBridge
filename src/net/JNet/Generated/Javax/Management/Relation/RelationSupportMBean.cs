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

namespace Javax.Management.Relation
{
    #region IRelationSupportMBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRelationSupportMBean : Javax.Management.Relation.IRelation
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupportMBean.html#isInRelationService()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        Java.Lang.Boolean IsInRelationService();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupportMBean.html#setRelationServiceManagementFlag(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        void SetRelationServiceManagementFlag(Java.Lang.Boolean arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RelationSupportMBean
    public partial class RelationSupportMBean : Javax.Management.Relation.IRelationSupportMBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupportMBean.html#isInRelationService()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public Java.Lang.Boolean IsInRelationService()
        {
            return IExecuteWithSignature<Java.Lang.Boolean>("isInRelationService", "()Ljava/lang/Boolean;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupportMBean.html#setRelationServiceManagementFlag(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetRelationServiceManagementFlag(Java.Lang.Boolean arg0)
        {
            IExecuteWithSignature("setRelationServiceManagementFlag", "(Ljava/lang/Boolean;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}