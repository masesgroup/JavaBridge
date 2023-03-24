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

namespace Java.Security
{
    #region CodeSource
    public partial class CodeSource
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CodeSource.html#%3Cinit%3E(java.net.URL,java.security.cert.Certificate[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.Certificate"/></param>
        public CodeSource(Java.Net.URL arg0, Java.Security.Cert.Certificate[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CodeSource.html#%3Cinit%3E(java.net.URL,java.security.CodeSigner[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Security.CodeSigner"/></param>
        public CodeSource(Java.Net.URL arg0, Java.Security.CodeSigner[] arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.CodeSource"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Security.CodeSource t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CodeSource.html#getCertificates()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate[] Certificates
        {
            get { return IExecuteArray<Java.Security.Cert.Certificate>("getCertificates"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CodeSource.html#getCodeSigners()"/> 
        /// </summary>
        public Java.Security.CodeSigner[] CodeSigners
        {
            get { return IExecuteArray<Java.Security.CodeSigner>("getCodeSigners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CodeSource.html#getLocation()"/> 
        /// </summary>
        public Java.Net.URL Location
        {
            get { return IExecute<Java.Net.URL>("getLocation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CodeSource.html#implies(java.security.CodeSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.CodeSource"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Implies(Java.Security.CodeSource arg0)
        {
            return IExecute<bool>("implies", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}