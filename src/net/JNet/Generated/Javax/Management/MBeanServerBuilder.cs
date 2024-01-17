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

namespace Javax.Management
{
    #region MBeanServerBuilder
    public partial class MBeanServerBuilder
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerBuilder.html#newMBeanServer(java.lang.String,javax.management.MBeanServer,javax.management.MBeanServerDelegate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Management.MBeanServer"/></param>
        /// <param name="arg2"><see cref="Javax.Management.MBeanServerDelegate"/></param>
        /// <returns><see cref="Javax.Management.MBeanServer"/></returns>
        public Javax.Management.MBeanServer NewMBeanServer(string arg0, Javax.Management.MBeanServer arg1, Javax.Management.MBeanServerDelegate arg2)
        {
            return IExecute<Javax.Management.MBeanServer>("newMBeanServer", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerBuilder.html#newMBeanServerDelegate()"/>
        /// </summary>

        /// <returns><see cref="Javax.Management.MBeanServerDelegate"/></returns>
        public Javax.Management.MBeanServerDelegate NewMBeanServerDelegate()
        {
            return IExecute<Javax.Management.MBeanServerDelegate>("newMBeanServerDelegate");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}