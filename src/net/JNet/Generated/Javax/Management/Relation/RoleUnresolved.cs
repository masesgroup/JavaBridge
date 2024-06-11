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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Relation
{
    #region RoleUnresolved
    public partial class RoleUnresolved
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolved.html#%3Cinit%3E(java.lang.String,java.util.List,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public RoleUnresolved(Java.Lang.String arg0, Java.Util.List<Javax.Management.ObjectName> arg1, int arg2)
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
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolved.html#getProblemType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolved.html#setProblemType(int)"/>
        /// </summary>
        public int ProblemType
        {
            get { return IExecuteWithSignature<int>("getProblemType", "()I"); } set { IExecuteWithSignature("setProblemType", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolved.html#getRoleName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolved.html#setRoleName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String RoleName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRoleName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setRoleName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolved.html#getRoleValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolved.html#setRoleValue(java.util.List)"/>
        /// </summary>
        public Java.Util.List<Javax.Management.ObjectName> RoleValue
        {
            get { return IExecuteWithSignature<Java.Util.List<Javax.Management.ObjectName>>("getRoleValue", "()Ljava/util/List;"); } set { IExecuteWithSignature("setRoleValue", "(Ljava/util/List;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}