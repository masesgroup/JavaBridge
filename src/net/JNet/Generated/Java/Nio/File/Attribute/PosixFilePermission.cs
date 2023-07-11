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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File.Attribute
{
    #region PosixFilePermission
    public partial class PosixFilePermission
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFilePermission.html#GROUP_EXECUTE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission GROUP_EXECUTE { get { return SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "GROUP_EXECUTE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFilePermission.html#GROUP_READ"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission GROUP_READ { get { return SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "GROUP_READ"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFilePermission.html#GROUP_WRITE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission GROUP_WRITE { get { return SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "GROUP_WRITE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFilePermission.html#OTHERS_EXECUTE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission OTHERS_EXECUTE { get { return SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "OTHERS_EXECUTE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFilePermission.html#OTHERS_READ"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission OTHERS_READ { get { return SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "OTHERS_READ"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFilePermission.html#OTHERS_WRITE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission OTHERS_WRITE { get { return SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "OTHERS_WRITE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFilePermission.html#OWNER_EXECUTE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission OWNER_EXECUTE { get { return SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "OWNER_EXECUTE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFilePermission.html#OWNER_READ"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission OWNER_READ { get { return SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "OWNER_READ"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFilePermission.html#OWNER_WRITE"/>
        /// </summary>
        public static Java.Nio.File.Attribute.PosixFilePermission OWNER_WRITE { get { return SGetField<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "OWNER_WRITE"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFilePermission.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.PosixFilePermission"/></returns>
        public static Java.Nio.File.Attribute.PosixFilePermission ValueOf(string arg0)
        {
            return SExecute<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFilePermission.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Attribute.PosixFilePermission"/></returns>
        public static Java.Nio.File.Attribute.PosixFilePermission[] Values()
        {
            return SExecuteArray<Java.Nio.File.Attribute.PosixFilePermission>(LocalBridgeClazz, "values");
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