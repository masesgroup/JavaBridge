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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
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
        public static Java.Awt.DesktopNs.QuitStrategy CLOSE_ALL_WINDOWS { get { if (!_CLOSE_ALL_WINDOWSReady) { _CLOSE_ALL_WINDOWSContent = SGetField<Java.Awt.DesktopNs.QuitStrategy>(LocalBridgeClazz, "CLOSE_ALL_WINDOWS"); _CLOSE_ALL_WINDOWSReady = true; } return _CLOSE_ALL_WINDOWSContent; } }
        private static Java.Awt.DesktopNs.QuitStrategy _CLOSE_ALL_WINDOWSContent = default;
        private static bool _CLOSE_ALL_WINDOWSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/QuitStrategy.html#NORMAL_EXIT"/>
        /// </summary>
        public static Java.Awt.DesktopNs.QuitStrategy NORMAL_EXIT { get { if (!_NORMAL_EXITReady) { _NORMAL_EXITContent = SGetField<Java.Awt.DesktopNs.QuitStrategy>(LocalBridgeClazz, "NORMAL_EXIT"); _NORMAL_EXITReady = true; } return _NORMAL_EXITContent; } }
        private static Java.Awt.DesktopNs.QuitStrategy _NORMAL_EXITContent = default;
        private static bool _NORMAL_EXITReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/QuitStrategy.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Awt.DesktopNs.QuitStrategy"/></returns>
        public static Java.Awt.DesktopNs.QuitStrategy ValueOf(Java.Lang.String arg0)
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