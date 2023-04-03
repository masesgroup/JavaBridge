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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Io
{
    #region FileDescriptor
    public partial class FileDescriptor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/FileDescriptor.html#err"/>
        /// </summary>
        public static Java.Io.FileDescriptor err => Clazz.GetField<Java.Io.FileDescriptor>("err");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/FileDescriptor.html#in"/>
        /// </summary>
        public static Java.Io.FileDescriptor inField => Clazz.GetField<Java.Io.FileDescriptor>("in");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/FileDescriptor.html#out"/>
        /// </summary>
        public static Java.Io.FileDescriptor outField => Clazz.GetField<Java.Io.FileDescriptor>("out");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/FileDescriptor.html#valid()"/> 
        /// </summary>
        public bool Valid
        {
            get { return IExecute<bool>("valid"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/FileDescriptor.html#sync()"/>
        /// </summary>
        
        /// <exception cref="Java.Io.SyncFailedException"/>
        public void Sync()
        {
            IExecute("sync");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}