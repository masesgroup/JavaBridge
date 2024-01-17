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

namespace Java.Security
{
    #region Security
    public partial class Security
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#getProviders()"/> 
        /// </summary>
        public static Java.Security.Provider[] Providers
        {
            get { return SExecuteArray<Java.Security.Provider>(LocalBridgeClazz, "getProviders"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#addProvider(java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="int"/></returns>
        public static int AddProvider(Java.Security.Provider arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "addProvider", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public static string GetProperty(string arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#getProvider(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public static Java.Security.Provider GetProvider(string arg0)
        {
            return SExecute<Java.Security.Provider>(LocalBridgeClazz, "getProvider", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#getProviders(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public static Java.Security.Provider[] GetProviders(string arg0)
        {
            return SExecuteArray<Java.Security.Provider>(LocalBridgeClazz, "getProviders", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#getProviders(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public static Java.Security.Provider[] GetProviders(Java.Util.Map<string, string> arg0)
        {
            return SExecuteArray<Java.Security.Provider>(LocalBridgeClazz, "getProviders", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#getAlgorithms(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<string> GetAlgorithms(string arg0)
        {
            return SExecute<Java.Util.Set<string>>(LocalBridgeClazz, "getAlgorithms", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#insertProviderAt(java.security.Provider,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Provider"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int InsertProviderAt(Java.Security.Provider arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "insertProviderAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#removeProvider(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public static void RemoveProvider(string arg0)
        {
            SExecute(LocalBridgeClazz, "removeProvider", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#setProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public static void SetProperty(string arg0, string arg1)
        {
            SExecute(LocalBridgeClazz, "setProperty", arg0, arg1);
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