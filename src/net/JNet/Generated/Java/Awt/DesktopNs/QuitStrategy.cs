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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.DesktopNs
{
    #region QuitStrategy
    public partial class QuitStrategy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/QuitStrategy.html#CLOSE_ALL_WINDOWS"/>
        /// </summary>
        public static Java.Awt.DesktopNs.QuitStrategy CLOSE_ALL_WINDOWS { get { return SGetField<Java.Awt.DesktopNs.QuitStrategy>(LocalBridgeClazz, "CLOSE_ALL_WINDOWS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/QuitStrategy.html#NORMAL_EXIT"/>
        /// </summary>
        public static Java.Awt.DesktopNs.QuitStrategy NORMAL_EXIT { get { return SGetField<Java.Awt.DesktopNs.QuitStrategy>(LocalBridgeClazz, "NORMAL_EXIT"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/QuitStrategy.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Awt.DesktopNs.QuitStrategy"/></returns>
        public static Java.Awt.DesktopNs.QuitStrategy ValueOf(string arg0)
        {
            return SExecute<Java.Awt.DesktopNs.QuitStrategy>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/QuitStrategy.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Awt.DesktopNs.QuitStrategy"/></returns>
        public static Java.Awt.DesktopNs.QuitStrategy[] Values()
        {
            return SExecuteArray<Java.Awt.DesktopNs.QuitStrategy>(LocalBridgeClazz, "values");
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