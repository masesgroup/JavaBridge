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

namespace Javax.Management.Relation
{
    #region RoleResult
    public partial class RoleResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleResult.html#%3Cinit%3E(javax.management.relation.RoleList,javax.management.relation.RoleUnresolvedList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Relation.RoleList"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.RoleUnresolvedList"/></param>
        public RoleResult(Javax.Management.Relation.RoleList arg0, Javax.Management.Relation.RoleUnresolvedList arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleResult.html#getRoles()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleResult.html#setRoles(javax.management.relation.RoleList)"/>
        /// </summary>
        public Javax.Management.Relation.RoleList Roles
        {
            get { return IExecuteWithSignature<Javax.Management.Relation.RoleList>("getRoles", "()Ljavax/management/relation/RoleList;"); } set { IExecuteWithSignature("setRoles", "(Ljavax/management/relation/RoleList;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleResult.html#getRolesUnresolved()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleResult.html#setRolesUnresolved(javax.management.relation.RoleUnresolvedList)"/>
        /// </summary>
        public Javax.Management.Relation.RoleUnresolvedList RolesUnresolved
        {
            get { return IExecuteWithSignature<Javax.Management.Relation.RoleUnresolvedList>("getRolesUnresolved", "()Ljavax/management/relation/RoleUnresolvedList;"); } set { IExecuteWithSignature("setRolesUnresolved", "(Ljavax/management/relation/RoleUnresolvedList;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}