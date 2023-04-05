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

namespace Javax.Management.Loading
{
    #region MLetContent
    public partial class MLetContent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetContent.html#%3Cinit%3E(java.net.URL,java.util.Map,java.util.List,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <param name="arg3"><see cref="Java.Util.List"/></param>
        public MLetContent(Java.Net.URL arg0, Java.Util.Map arg1, Java.Util.List arg2, Java.Util.List arg3)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetContent.html#getAttributes()"/> 
        /// </summary>
        public Java.Util.Map<string, string> Attributes
        {
            get { return IExecute<Java.Util.Map<string, string>>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetContent.html#getCode()"/> 
        /// </summary>
        public string Code
        {
            get { return IExecute<string>("getCode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetContent.html#getCodeBase()"/> 
        /// </summary>
        public Java.Net.URL CodeBase
        {
            get { return IExecute<Java.Net.URL>("getCodeBase"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetContent.html#getDocumentBase()"/> 
        /// </summary>
        public Java.Net.URL DocumentBase
        {
            get { return IExecute<Java.Net.URL>("getDocumentBase"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetContent.html#getJarFiles()"/> 
        /// </summary>
        public string JarFiles
        {
            get { return IExecute<string>("getJarFiles"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetContent.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetContent.html#getParameterTypes()"/> 
        /// </summary>
        public Java.Util.List<string> ParameterTypes
        {
            get { return IExecute<Java.Util.List<string>>("getParameterTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetContent.html#getParameterValues()"/> 
        /// </summary>
        public Java.Util.List<string> ParameterValues
        {
            get { return IExecute<Java.Util.List<string>>("getParameterValues"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetContent.html#getSerializedObject()"/> 
        /// </summary>
        public string SerializedObject
        {
            get { return IExecute<string>("getSerializedObject"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetContent.html#getVersion()"/> 
        /// </summary>
        public string Version
        {
            get { return IExecute<string>("getVersion"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}