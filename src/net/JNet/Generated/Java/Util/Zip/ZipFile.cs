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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Zip
{
    #region ZipFile
    public partial class ZipFile
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#%3Cinit%3E(java.io.File,int,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ZipFile(Java.Io.File arg0, int arg1, Java.Nio.Charset.Charset arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#%3Cinit%3E(java.io.File,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ZipFile(Java.Io.File arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#%3Cinit%3E(java.io.File,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ZipFile(Java.Io.File arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#%3Cinit%3E(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Util.Zip.ZipException"/>
        /// <exception cref="Java.Io.IOException"/>
        public ZipFile(Java.Io.File arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#%3Cinit%3E(java.lang.String,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ZipFile(string arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ZipFile(string arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Zip.ZipFile"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Util.Zip.ZipFile t) => t.Cast<Java.Io.Closeable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#OPEN_DELETE"/>
        /// </summary>
        public static int OPEN_DELETE => Clazz.GetField<int>("OPEN_DELETE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#OPEN_READ"/>
        /// </summary>
        public static int OPEN_READ => Clazz.GetField<int>("OPEN_READ");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#getComment()"/> 
        /// </summary>
        public string Comment
        {
            get { return IExecute<string>("getComment"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#entries()"/> 
        /// </summary>
        public Java.Util.Enumeration Entries
        {
            get { return IExecute<Java.Util.Enumeration>("entries"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#size()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecute<int>("size"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#stream()"/> 
        /// </summary>
        public Java.Util.Stream.Stream Stream
        {
            get { return IExecute<Java.Util.Stream.Stream>("stream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#getInputStream(java.util.zip.ZipEntry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Zip.ZipEntry"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream GetInputStream(Java.Util.Zip.ZipEntry arg0)
        {
            return IExecute<Java.Io.InputStream>("getInputStream", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#getEntry(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Zip.ZipEntry"/></returns>
        public Java.Util.Zip.ZipEntry GetEntry(string arg0)
        {
            return IExecute<Java.Util.Zip.ZipEntry>("getEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipFile.html#close()"/>
        /// </summary>
        
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecute("close");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}