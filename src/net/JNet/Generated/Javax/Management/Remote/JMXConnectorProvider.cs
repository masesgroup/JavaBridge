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

namespace Javax.Management.Remote
{
    #region IJMXConnectorProvider
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IJMXConnectorProvider
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorProvider.html#newJMXConnector(javax.management.remote.JMXServiceURL,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.JMXServiceURL"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Javax.Management.Remote.JMXConnector"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Javax.Management.Remote.JMXConnector NewJMXConnector(Javax.Management.Remote.JMXServiceURL arg0, Java.Util.Map<Java.Lang.String, object> arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region JMXConnectorProvider
    public partial class JMXConnectorProvider : Javax.Management.Remote.IJMXConnectorProvider
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorProvider.html#newJMXConnector(javax.management.remote.JMXServiceURL,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.JMXServiceURL"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Javax.Management.Remote.JMXConnector"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.Remote.JMXConnector NewJMXConnector(Javax.Management.Remote.JMXServiceURL arg0, Java.Util.Map<Java.Lang.String, object> arg1)
        {
            return IExecute<Javax.Management.Remote.JMXConnector>("newJMXConnector", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}