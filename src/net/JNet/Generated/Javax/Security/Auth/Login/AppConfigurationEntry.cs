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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Security.Auth.Login
{
    #region AppConfigurationEntry
    public partial class AppConfigurationEntry
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.html#%3Cinit%3E(java.lang.String,javax.security.auth.login.AppConfigurationEntry.LoginModuleControlFlag,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        public AppConfigurationEntry(string arg0, Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag arg1, Java.Util.Map<string, object> arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.html#getControlFlag()"/> 
        /// </summary>
        public Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag ControlFlag
        {
            get { return IExecute<Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag>("getControlFlag"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.html#getLoginModuleName()"/> 
        /// </summary>
        public string LoginModuleName
        {
            get { return IExecute<string>("getLoginModuleName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.html#getOptions()"/> 
        /// </summary>
        public Java.Util.Map<string, object> Options
        {
            get { return IExecute<Java.Util.Map<string, object>>("getOptions"); }
        }

        #endregion

        #region Nested classes
        #region LoginModuleControlFlag
        public partial class LoginModuleControlFlag
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.LoginModuleControlFlag.html#OPTIONAL"/>
            /// </summary>
            public static Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag OPTIONAL { get { return SGetField<Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag>(LocalBridgeClazz, "OPTIONAL"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.LoginModuleControlFlag.html#REQUIRED"/>
            /// </summary>
            public static Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag REQUIRED { get { return SGetField<Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag>(LocalBridgeClazz, "REQUIRED"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.LoginModuleControlFlag.html#REQUISITE"/>
            /// </summary>
            public static Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag REQUISITE { get { return SGetField<Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag>(LocalBridgeClazz, "REQUISITE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.LoginModuleControlFlag.html#SUFFICIENT"/>
            /// </summary>
            public static Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag SUFFICIENT { get { return SGetField<Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag>(LocalBridgeClazz, "SUFFICIENT"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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