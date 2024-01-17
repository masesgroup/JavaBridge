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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File.Attribute
{
    #region IBasicFileAttributeView
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBasicFileAttributeView : Java.Nio.File.Attribute.IFileAttributeView
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributeView.html#name()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        string Name();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributeView.html#readAttributes()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Attribute.BasicFileAttributes"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.File.Attribute.BasicFileAttributes ReadAttributes();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributeView.html#setTimes(java.nio.file.attribute.FileTime,java.nio.file.attribute.FileTime,java.nio.file.attribute.FileTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void SetTimes(Java.Nio.File.Attribute.FileTime arg0, Java.Nio.File.Attribute.FileTime arg1, Java.Nio.File.Attribute.FileTime arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BasicFileAttributeView
    public partial class BasicFileAttributeView : Java.Nio.File.Attribute.IBasicFileAttributeView
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributeView.html#name()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributeView.html#readAttributes()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Attribute.BasicFileAttributes"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.Attribute.BasicFileAttributes ReadAttributes()
        {
            return IExecute<Java.Nio.File.Attribute.BasicFileAttributes>("readAttributes");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributeView.html#setTimes(java.nio.file.attribute.FileTime,java.nio.file.attribute.FileTime,java.nio.file.attribute.FileTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetTimes(Java.Nio.File.Attribute.FileTime arg0, Java.Nio.File.Attribute.FileTime arg1, Java.Nio.File.Attribute.FileTime arg2)
        {
            IExecute("setTimes", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}