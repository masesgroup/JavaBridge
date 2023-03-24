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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File.Attribute
{
    #region AclEntryType
    public partial class AclEntryType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryType.html#ALARM"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryType ALARM => Clazz.GetField<Java.Nio.File.Attribute.AclEntryType>("ALARM");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryType.html#ALLOW"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryType ALLOW => Clazz.GetField<Java.Nio.File.Attribute.AclEntryType>("ALLOW");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryType.html#AUDIT"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryType AUDIT => Clazz.GetField<Java.Nio.File.Attribute.AclEntryType>("AUDIT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryType.html#DENY"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryType DENY => Clazz.GetField<Java.Nio.File.Attribute.AclEntryType>("DENY");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryType.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.AclEntryType"/></returns>
        public static Java.Nio.File.Attribute.AclEntryType ValueOf(string arg0)
        {
            return SExecute<Java.Nio.File.Attribute.AclEntryType>("valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryType.html#values()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.File.Attribute.AclEntryType"/></returns>
        public static Java.Nio.File.Attribute.AclEntryType[] Values()
        {
            return SExecuteArray<Java.Nio.File.Attribute.AclEntryType>("values");
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}