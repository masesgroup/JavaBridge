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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Directory
{
    #region SearchResult
    public partial class SearchResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchResult.html#%3Cinit%3E(java.lang.String,java.lang.Object,javax.naming.directory.Attributes,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public SearchResult(Java.Lang.String arg0, object arg1, Javax.Naming.Directory.Attributes arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchResult.html#%3Cinit%3E(java.lang.String,java.lang.Object,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.Attributes"/></param>
        public SearchResult(Java.Lang.String arg0, object arg1, Javax.Naming.Directory.Attributes arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchResult.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.Object,javax.naming.directory.Attributes,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        public SearchResult(Java.Lang.String arg0, Java.Lang.String arg1, object arg2, Javax.Naming.Directory.Attributes arg3, bool arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchResult.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.Object,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Directory.Attributes"/></param>
        public SearchResult(Java.Lang.String arg0, Java.Lang.String arg1, object arg2, Javax.Naming.Directory.Attributes arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchResult.html#getAttributes()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchResult.html#setAttributes(javax.naming.directory.Attributes)"/>
        /// </summary>
        public Javax.Naming.Directory.Attributes Attributes
        {
            get { return IExecuteWithSignature<Javax.Naming.Directory.Attributes>("getAttributes", "()Ljavax/naming/directory/Attributes;"); } set { IExecuteWithSignature("setAttributes", "(Ljavax/naming/directory/Attributes;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}