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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Zip
{
    #region ZipEntry
    public partial class ZipEntry
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public ZipEntry(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#%3Cinit%3E(java.util.zip.ZipEntry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Zip.ZipEntry"/></param>
        public ZipEntry(Java.Util.Zip.ZipEntry arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Zip.ZipEntry"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Zip.ZipEntry t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#DEFLATED"/>
        /// </summary>
        public static int DEFLATED { get { if (!_DEFLATEDReady) { _DEFLATEDContent = SGetField<int>(LocalBridgeClazz, "DEFLATED"); _DEFLATEDReady = true; } return _DEFLATEDContent; } }
        private static int _DEFLATEDContent = default;
        private static bool _DEFLATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#STORED"/>
        /// </summary>
        public static int STORED { get { if (!_STOREDReady) { _STOREDContent = SGetField<int>(LocalBridgeClazz, "STORED"); _STOREDReady = true; } return _STOREDContent; } }
        private static int _STOREDContent = default;
        private static bool _STOREDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getComment()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setComment(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Comment
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getComment", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setComment", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getCompressedSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setCompressedSize(long)"/>
        /// </summary>
        public long CompressedSize
        {
            get { return IExecuteWithSignature<long>("getCompressedSize", "()J"); } set { IExecuteWithSignature("setCompressedSize", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getCrc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setCrc(long)"/>
        /// </summary>
        public long Crc
        {
            get { return IExecuteWithSignature<long>("getCrc", "()J"); } set { IExecuteWithSignature("setCrc", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getCreationTime()"/> 
        /// </summary>
        public Java.Nio.File.Attribute.FileTime CreationTime
        {
            get { return IExecuteWithSignature<Java.Nio.File.Attribute.FileTime>("getCreationTime", "()Ljava/nio/file/attribute/FileTime;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getExtra()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setExtra(byte[])"/>
        /// </summary>
        public byte[] Extra
        {
            get { return IExecuteWithSignatureArray<byte>("getExtra", "()[B"); } set { IExecuteWithSignature("setExtra", "([B)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getLastAccessTime()"/> 
        /// </summary>
        public Java.Nio.File.Attribute.FileTime LastAccessTime
        {
            get { return IExecuteWithSignature<Java.Nio.File.Attribute.FileTime>("getLastAccessTime", "()Ljava/nio/file/attribute/FileTime;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getLastModifiedTime()"/> 
        /// </summary>
        public Java.Nio.File.Attribute.FileTime LastModifiedTime
        {
            get { return IExecuteWithSignature<Java.Nio.File.Attribute.FileTime>("getLastModifiedTime", "()Ljava/nio/file/attribute/FileTime;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getMethod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setMethod(int)"/>
        /// </summary>
        public int Method
        {
            get { return IExecuteWithSignature<int>("getMethod", "()I"); } set { IExecuteWithSignature("setMethod", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setSize(long)"/>
        /// </summary>
        public long Size
        {
            get { return IExecuteWithSignature<long>("getSize", "()J"); } set { IExecuteWithSignature("setSize", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getTime()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setTime(long)"/>
        /// </summary>
        public long Time
        {
            get { return IExecuteWithSignature<long>("getTime", "()J"); } set { IExecuteWithSignature("setTime", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getTimeLocal()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setTimeLocal(java.time.LocalDateTime)"/>
        /// </summary>
        public Java.Time.LocalDateTime TimeLocal
        {
            get { return IExecuteWithSignature<Java.Time.LocalDateTime>("getTimeLocal", "()Ljava/time/LocalDateTime;"); } set { IExecuteWithSignature("setTimeLocal", "(Ljava/time/LocalDateTime;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#isDirectory()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDirectory()
        {
            return IExecuteWithSignature<bool>("isDirectory", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setCreationTime(java.nio.file.attribute.FileTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <returns><see cref="Java.Util.Zip.ZipEntry"/></returns>
        public Java.Util.Zip.ZipEntry SetCreationTime(Java.Nio.File.Attribute.FileTime arg0)
        {
            return IExecuteWithSignature<Java.Util.Zip.ZipEntry>("setCreationTime", "(Ljava/nio/file/attribute/FileTime;)Ljava/util/zip/ZipEntry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setLastAccessTime(java.nio.file.attribute.FileTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <returns><see cref="Java.Util.Zip.ZipEntry"/></returns>
        public Java.Util.Zip.ZipEntry SetLastAccessTime(Java.Nio.File.Attribute.FileTime arg0)
        {
            return IExecuteWithSignature<Java.Util.Zip.ZipEntry>("setLastAccessTime", "(Ljava/nio/file/attribute/FileTime;)Ljava/util/zip/ZipEntry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setLastModifiedTime(java.nio.file.attribute.FileTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <returns><see cref="Java.Util.Zip.ZipEntry"/></returns>
        public Java.Util.Zip.ZipEntry SetLastModifiedTime(Java.Nio.File.Attribute.FileTime arg0)
        {
            return IExecuteWithSignature<Java.Util.Zip.ZipEntry>("setLastModifiedTime", "(Ljava/nio/file/attribute/FileTime;)Ljava/util/zip/ZipEntry;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}