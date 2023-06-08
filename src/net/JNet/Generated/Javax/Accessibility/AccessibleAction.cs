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

namespace Javax.Accessibility
{
    #region IAccessibleAction
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html"/>
    /// </summary>
    public partial interface IAccessibleAction
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#getAccessibleActionCount()"/> 
        /// </summary>
        int AccessibleActionCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#doAccessibleAction(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool DoAccessibleAction(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#getAccessibleActionDescription(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        string GetAccessibleActionDescription(int arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AccessibleAction
    public partial class AccessibleAction : Javax.Accessibility.IAccessibleAction
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#CLICK"/>
        /// </summary>
        public static string CLICK { get { return SGetField<string>(LocalBridgeClazz, "CLICK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#DECREMENT"/>
        /// </summary>
        public static string DECREMENT { get { return SGetField<string>(LocalBridgeClazz, "DECREMENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#INCREMENT"/>
        /// </summary>
        public static string INCREMENT { get { return SGetField<string>(LocalBridgeClazz, "INCREMENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#TOGGLE_EXPAND"/>
        /// </summary>
        public static string TOGGLE_EXPAND { get { return SGetField<string>(LocalBridgeClazz, "TOGGLE_EXPAND"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#TOGGLE_POPUP"/>
        /// </summary>
        public static string TOGGLE_POPUP { get { return SGetField<string>(LocalBridgeClazz, "TOGGLE_POPUP"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#getAccessibleActionCount()"/> 
        /// </summary>
        public int AccessibleActionCount
        {
            get { return IExecute<int>("getAccessibleActionCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#doAccessibleAction(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DoAccessibleAction(int arg0)
        {
            return IExecute<bool>("doAccessibleAction", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#getAccessibleActionDescription(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAccessibleActionDescription(int arg0)
        {
            return IExecute<string>("getAccessibleActionDescription", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}