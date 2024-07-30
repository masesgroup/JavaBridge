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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
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
            get { return SExecuteWithSignatureArray<Java.Security.Provider>(LocalBridgeClazz, "getProviders", "()[Ljava/security/Provider;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#addProvider(java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="int"/></returns>
        public static int AddProvider(Java.Security.Provider arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "addProvider", "(Ljava/security/Provider;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetProperty(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#getProvider(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public static Java.Security.Provider GetProvider(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Security.Provider>(LocalBridgeClazz, "getProvider", "(Ljava/lang/String;)Ljava/security/Provider;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#getProviders(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public static Java.Security.Provider[] GetProviders(Java.Lang.String arg0)
        {
            return SExecuteWithSignatureArray<Java.Security.Provider>(LocalBridgeClazz, "getProviders", "(Ljava/lang/String;)[Ljava/security/Provider;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#getProviders(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public static Java.Security.Provider[] GetProviders(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
        {
            return SExecuteWithSignatureArray<Java.Security.Provider>(LocalBridgeClazz, "getProviders", "(Ljava/util/Map;)[Ljava/security/Provider;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#getAlgorithms(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Java.Lang.String> GetAlgorithms(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Set<Java.Lang.String>>(LocalBridgeClazz, "getAlgorithms", "(Ljava/lang/String;)Ljava/util/Set;", arg0);
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
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void RemoveProvider(Java.Lang.String arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "removeProvider", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/Security.html#setProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public static void SetProperty(Java.Lang.String arg0, Java.Lang.String arg1)
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