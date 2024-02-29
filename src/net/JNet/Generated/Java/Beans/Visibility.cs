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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans
{
    #region IVisibility
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IVisibility
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Visibility.html#avoidingGui()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool AvoidingGui();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Visibility.html#needsGui()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool NeedsGui();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Visibility.html#dontUseGui()"/>
        /// </summary>
        void DontUseGui();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Visibility.html#okToUseGui()"/>
        /// </summary>
        void OkToUseGui();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Visibility
    public partial class Visibility : Java.Beans.IVisibility
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Visibility.html#avoidingGui()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool AvoidingGui()
        {
            return IExecuteWithSignature<bool>("avoidingGui", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Visibility.html#needsGui()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool NeedsGui()
        {
            return IExecuteWithSignature<bool>("needsGui", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Visibility.html#dontUseGui()"/>
        /// </summary>
        public void DontUseGui()
        {
            IExecuteWithSignature("dontUseGui", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Visibility.html#okToUseGui()"/>
        /// </summary>
        public void OkToUseGui()
        {
            IExecuteWithSignature("okToUseGui", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}