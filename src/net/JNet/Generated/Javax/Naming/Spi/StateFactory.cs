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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Spi
{
    #region IStateFactory
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IStateFactory
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/StateFactory.html#getStateToBind(java.lang.Object,javax.naming.Name,javax.naming.Context,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Context"/></param>
        /// <param name="arg3"><see cref="Java.Util.Hashtable"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        object GetStateToBind(object arg0, Javax.Naming.Name arg1, Javax.Naming.Context arg2, Java.Util.Hashtable<object, object> arg3);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StateFactory
    public partial class StateFactory : Javax.Naming.Spi.IStateFactory
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/StateFactory.html#getStateToBind(java.lang.Object,javax.naming.Name,javax.naming.Context,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Context"/></param>
        /// <param name="arg3"><see cref="Java.Util.Hashtable"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object GetStateToBind(object arg0, Javax.Naming.Name arg1, Javax.Naming.Context arg2, Java.Util.Hashtable<object, object> arg3)
        {
            return IExecute("getStateToBind", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}