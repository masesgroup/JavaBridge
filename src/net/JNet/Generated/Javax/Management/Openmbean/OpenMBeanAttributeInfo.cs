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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Openmbean
{
    #region IOpenMBeanAttributeInfo
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IOpenMBeanAttributeInfo : Javax.Management.Openmbean.IOpenMBeanParameterInfo
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfo.html#isIs()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsIs();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfo.html#isReadable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsReadable();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfo.html#isWritable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsWritable();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OpenMBeanAttributeInfo
    public partial class OpenMBeanAttributeInfo : Javax.Management.Openmbean.IOpenMBeanAttributeInfo
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfo.html#isIs()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsIs()
        {
            return IExecuteWithSignature<bool>("isIs", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfo.html#isReadable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReadable()
        {
            return IExecuteWithSignature<bool>("isReadable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfo.html#isWritable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWritable()
        {
            return IExecuteWithSignature<bool>("isWritable", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}