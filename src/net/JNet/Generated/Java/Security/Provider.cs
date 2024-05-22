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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security
{
    #region Provider
    public partial class Provider
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.html#getInfo()"/> 
        /// </summary>
        public Java.Lang.String Info
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getInfo", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.html#getServices()"/> 
        /// </summary>
        public Java.Util.Set<Java.Security.Provider.Service> Services
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Security.Provider.Service>>("getServices", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.html#getVersionStr()"/> 
        /// </summary>
        public Java.Lang.String VersionStr
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVersionStr", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.html#isConfigured()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConfigured()
        {
            return IExecuteWithSignature<bool>("isConfigured", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.html#configure(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public Java.Security.Provider Configure(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Security.Provider>("configure", "(Ljava/lang/String;)Ljava/security/Provider;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.html#getService(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Provider.Service"/></returns>
        public Java.Security.Provider.Service GetService(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Security.Provider.Service>("getService", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Service
        public partial class Service
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.Service.html#%3Cinit%3E(java.security.Provider,java.lang.String,java.lang.String,java.lang.String,java.util.List,java.util.Map)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Security.Provider"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <param name="arg3"><see cref="Java.Lang.String"/></param>
            /// <param name="arg4"><see cref="Java.Util.List"/></param>
            /// <param name="arg5"><see cref="Java.Util.Map"/></param>
            public Service(Java.Security.Provider arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, Java.Util.List<Java.Lang.String> arg4, Java.Util.Map<Java.Lang.String, Java.Lang.String> arg5)
                : base(arg0, arg1, arg2, arg3, arg4, arg5)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.Service.html#getAlgorithm()"/> 
            /// </summary>
            public Java.Lang.String Algorithm
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.Service.html#getClassName()"/> 
            /// </summary>
            public Java.Lang.String ClassName
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getClassName", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.Service.html#getProvider()"/> 
            /// </summary>
            public Java.Security.Provider GetProvider
            {
                get { return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.Service.html#getType()"/> 
            /// </summary>
            public Java.Lang.String Type
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getType", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.Service.html#supportsParameter(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool SupportsParameter(object arg0)
            {
                return IExecuteWithSignature<bool>("supportsParameter", "(Ljava/lang/Object;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.Service.html#getAttribute(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetAttribute(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Java.Lang.String>("getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Provider.Service.html#newInstance(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
            public object NewInstance(object arg0)
            {
                return IExecuteWithSignature("newInstance", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}