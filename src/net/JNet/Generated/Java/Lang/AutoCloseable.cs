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

namespace Java.Lang
{
    #region IAutoCloseable
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/AutoCloseable.html"/>
    /// </summary>
    public partial interface IAutoCloseable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/AutoCloseable.html#close()"/>
        /// </summary>

        /// <exception cref="Java.Lang.Exception"/>
        void Close();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AutoCloseable
    public partial class AutoCloseable : Java.Lang.IAutoCloseable
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/AutoCloseable.html#close()"/>
        /// </summary>

        /// <exception cref="Java.Lang.Exception"/>
        public void Close()
        {
            IExecute("close");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}