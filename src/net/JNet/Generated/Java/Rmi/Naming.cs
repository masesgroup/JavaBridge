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

namespace Java.Rmi
{
    #region Naming
    public partial class Naming
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/Naming.html#list(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public static string[] List(string arg0)
        {
            return SExecuteArray<string>("list", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/Naming.html#lookup(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Rmi.Remote"/></returns>
        /// <exception cref="Java.Rmi.NotBoundException"/>
        /// <exception cref="Java.Net.MalformedURLException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Remote Lookup(string arg0)
        {
            return SExecute<Java.Rmi.Remote>("lookup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/Naming.html#bind(java.lang.String,java.rmi.Remote)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Remote"/></param>
        /// <exception cref="Java.Rmi.AlreadyBoundException"/>
        /// <exception cref="Java.Net.MalformedURLException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static void Bind(string arg0, Java.Rmi.Remote arg1)
        {
            SExecute("bind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/Naming.html#rebind(java.lang.String,java.rmi.Remote)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Remote"/></param>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public static void Rebind(string arg0, Java.Rmi.Remote arg1)
        {
            SExecute("rebind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/Naming.html#unbind(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Rmi.NotBoundException"/>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public static void Unbind(string arg0)
        {
            SExecute("unbind", arg0);
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