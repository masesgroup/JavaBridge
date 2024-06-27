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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Rmi.Server
{
    #region RMIClassLoader
    public partial class RMIClassLoader
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIClassLoader.html#getDefaultProviderInstance()"/> 
        /// </summary>
        public static Java.Rmi.Server.RMIClassLoaderSpi DefaultProviderInstance
        {
            get { return SExecuteWithSignature<Java.Rmi.Server.RMIClassLoaderSpi>(LocalBridgeClazz, "getDefaultProviderInstance", "()Ljava/rmi/server/RMIClassLoaderSpi;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIClassLoader.html#loadClass(java.lang.String,java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        /// <exception cref="Java.Net.MalformedURLException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public static Java.Lang.Class LoadClass(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.ClassLoader arg2)
        {
            return SExecute<Java.Lang.Class>(LocalBridgeClazz, "loadClass", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIClassLoader.html#loadClass(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        /// <exception cref="Java.Net.MalformedURLException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public static Java.Lang.Class LoadClass(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Lang.Class>(LocalBridgeClazz, "loadClass", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIClassLoader.html#loadClass(java.net.URL,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        /// <exception cref="Java.Net.MalformedURLException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public static Java.Lang.Class LoadClass(Java.Net.URL arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Lang.Class>(LocalBridgeClazz, "loadClass", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIClassLoader.html#loadProxyClass(java.lang.String,java.lang.String[],java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public static Java.Lang.Class LoadProxyClass(Java.Lang.String arg0, Java.Lang.String[] arg1, Java.Lang.ClassLoader arg2)
        {
            return SExecute<Java.Lang.Class>(LocalBridgeClazz, "loadProxyClass", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIClassLoader.html#getClassLoader(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.ClassLoader"/></returns>
        /// <exception cref="Java.Net.MalformedURLException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public static Java.Lang.ClassLoader GetClassLoader(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.ClassLoader>(LocalBridgeClazz, "getClassLoader", "(Ljava/lang/String;)Ljava/lang/ClassLoader;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIClassLoader.html#getClassAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetClassAnnotation(Java.Lang.Class arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getClassAnnotation", "(Ljava/lang/Class;)Ljava/lang/String;", arg0);
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