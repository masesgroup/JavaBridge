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

namespace Javax.Swing
{
    #region FocusManager
    public partial class FocusManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/FocusManager.html#FOCUS_MANAGER_CLASS_PROPERTY"/>
        /// </summary>
        public static string FOCUS_MANAGER_CLASS_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "FOCUS_MANAGER_CLASS_PROPERTY"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/FocusManager.html#getCurrentManager()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/FocusManager.html#setCurrentManager(javax.swing.FocusManager)"/>
        /// </summary>
        public static Javax.Swing.FocusManager CurrentManager
        {
            get { return SExecute<Javax.Swing.FocusManager>(LocalBridgeClazz, "getCurrentManager"); } set { SExecute(LocalBridgeClazz, "setCurrentManager", value); }
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