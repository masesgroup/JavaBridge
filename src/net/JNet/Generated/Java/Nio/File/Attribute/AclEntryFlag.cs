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

namespace Java.Nio.File.Attribute
{
    #region AclEntryFlag
    public partial class AclEntryFlag
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryFlag.html#DIRECTORY_INHERIT"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryFlag DIRECTORY_INHERIT { get { if (!_DIRECTORY_INHERITReady) { _DIRECTORY_INHERITContent = SGetField<Java.Nio.File.Attribute.AclEntryFlag>(LocalBridgeClazz, "DIRECTORY_INHERIT"); _DIRECTORY_INHERITReady = true; } return _DIRECTORY_INHERITContent; } }
        private static Java.Nio.File.Attribute.AclEntryFlag _DIRECTORY_INHERITContent = default;
        private static bool _DIRECTORY_INHERITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryFlag.html#FILE_INHERIT"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryFlag FILE_INHERIT { get { if (!_FILE_INHERITReady) { _FILE_INHERITContent = SGetField<Java.Nio.File.Attribute.AclEntryFlag>(LocalBridgeClazz, "FILE_INHERIT"); _FILE_INHERITReady = true; } return _FILE_INHERITContent; } }
        private static Java.Nio.File.Attribute.AclEntryFlag _FILE_INHERITContent = default;
        private static bool _FILE_INHERITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryFlag.html#INHERIT_ONLY"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryFlag INHERIT_ONLY { get { if (!_INHERIT_ONLYReady) { _INHERIT_ONLYContent = SGetField<Java.Nio.File.Attribute.AclEntryFlag>(LocalBridgeClazz, "INHERIT_ONLY"); _INHERIT_ONLYReady = true; } return _INHERIT_ONLYContent; } }
        private static Java.Nio.File.Attribute.AclEntryFlag _INHERIT_ONLYContent = default;
        private static bool _INHERIT_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryFlag.html#NO_PROPAGATE_INHERIT"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryFlag NO_PROPAGATE_INHERIT { get { if (!_NO_PROPAGATE_INHERITReady) { _NO_PROPAGATE_INHERITContent = SGetField<Java.Nio.File.Attribute.AclEntryFlag>(LocalBridgeClazz, "NO_PROPAGATE_INHERIT"); _NO_PROPAGATE_INHERITReady = true; } return _NO_PROPAGATE_INHERITContent; } }
        private static Java.Nio.File.Attribute.AclEntryFlag _NO_PROPAGATE_INHERITContent = default;
        private static bool _NO_PROPAGATE_INHERITReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryFlag.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.AclEntryFlag"/></returns>
        public static Java.Nio.File.Attribute.AclEntryFlag ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.Attribute.AclEntryFlag>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/nio/file/attribute/AclEntryFlag;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryFlag.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Attribute.AclEntryFlag"/></returns>
        public static Java.Nio.File.Attribute.AclEntryFlag[] Values()
        {
            return SExecuteWithSignatureArray<Java.Nio.File.Attribute.AclEntryFlag>(LocalBridgeClazz, "values", "()[Ljava/nio/file/attribute/AclEntryFlag;");
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