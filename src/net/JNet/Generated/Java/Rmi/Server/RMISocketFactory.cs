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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Rmi.Server
{
    #region RMISocketFactory
    public partial class RMISocketFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Rmi.Server.RMISocketFactory"/> to <see cref="Java.Rmi.Server.RMIClientSocketFactory"/>
        /// </summary>
        public static implicit operator Java.Rmi.Server.RMIClientSocketFactory(Java.Rmi.Server.RMISocketFactory t) => t.Cast<Java.Rmi.Server.RMIClientSocketFactory>();
        /// <summary>
        /// Converter from <see cref="Java.Rmi.Server.RMISocketFactory"/> to <see cref="Java.Rmi.Server.RMIServerSocketFactory"/>
        /// </summary>
        public static implicit operator Java.Rmi.Server.RMIServerSocketFactory(Java.Rmi.Server.RMISocketFactory t) => t.Cast<Java.Rmi.Server.RMIServerSocketFactory>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMISocketFactory.html#getDefaultSocketFactory()"/> 
        /// </summary>
        public static Java.Rmi.Server.RMISocketFactory DefaultSocketFactory
        {
            get { return SExecuteWithSignature<Java.Rmi.Server.RMISocketFactory>(LocalBridgeClazz, "getDefaultSocketFactory", "()Ljava/rmi/server/RMISocketFactory;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMISocketFactory.html#getFailureHandler()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMISocketFactory.html#setFailureHandler(java.rmi.server.RMIFailureHandler)"/>
        /// </summary>
        public static Java.Rmi.Server.RMIFailureHandler FailureHandler
        {
            get { return SExecuteWithSignature<Java.Rmi.Server.RMIFailureHandler>(LocalBridgeClazz, "getFailureHandler", "()Ljava/rmi/server/RMIFailureHandler;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setFailureHandler", "(Ljava/rmi/server/RMIFailureHandler;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMISocketFactory.html#getSocketFactory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMISocketFactory.html#setSocketFactory(java.rmi.server.RMISocketFactory)"/>
        /// </summary>
        public static Java.Rmi.Server.RMISocketFactory SocketFactory
        {
            get { return SExecuteWithSignature<Java.Rmi.Server.RMISocketFactory>(LocalBridgeClazz, "getSocketFactory", "()Ljava/rmi/server/RMISocketFactory;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setSocketFactory", "(Ljava/rmi/server/RMISocketFactory;)V", value); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMISocketFactory.html#createServerSocket(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Net.ServerSocket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.ServerSocket CreateServerSocket(int arg0)
        {
            return IExecuteWithSignature<Java.Net.ServerSocket>("createServerSocket", "(I)Ljava/net/ServerSocket;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMISocketFactory.html#createSocket(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Net.Socket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.Socket CreateSocket(Java.Lang.String arg0, int arg1)
        {
            return IExecute<Java.Net.Socket>("createSocket", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}