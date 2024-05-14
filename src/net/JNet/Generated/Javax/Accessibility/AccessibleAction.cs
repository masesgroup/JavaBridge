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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Accessibility
{
    #region IAccessibleAction
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
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
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String GetAccessibleActionDescription(int arg0);

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
        public static Java.Lang.String CLICK { get { if (!_CLICKReady) { _CLICKContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CLICK"); _CLICKReady = true; } return _CLICKContent; } }
        private static Java.Lang.String _CLICKContent = default;
        private static bool _CLICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#DECREMENT"/>
        /// </summary>
        public static Java.Lang.String DECREMENT { get { if (!_DECREMENTReady) { _DECREMENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DECREMENT"); _DECREMENTReady = true; } return _DECREMENTContent; } }
        private static Java.Lang.String _DECREMENTContent = default;
        private static bool _DECREMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#INCREMENT"/>
        /// </summary>
        public static Java.Lang.String INCREMENT { get { if (!_INCREMENTReady) { _INCREMENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INCREMENT"); _INCREMENTReady = true; } return _INCREMENTContent; } }
        private static Java.Lang.String _INCREMENTContent = default;
        private static bool _INCREMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#TOGGLE_EXPAND"/>
        /// </summary>
        public static Java.Lang.String TOGGLE_EXPAND { get { if (!_TOGGLE_EXPANDReady) { _TOGGLE_EXPANDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOGGLE_EXPAND"); _TOGGLE_EXPANDReady = true; } return _TOGGLE_EXPANDContent; } }
        private static Java.Lang.String _TOGGLE_EXPANDContent = default;
        private static bool _TOGGLE_EXPANDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#TOGGLE_POPUP"/>
        /// </summary>
        public static Java.Lang.String TOGGLE_POPUP { get { if (!_TOGGLE_POPUPReady) { _TOGGLE_POPUPContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOGGLE_POPUP"); _TOGGLE_POPUPReady = true; } return _TOGGLE_POPUPContent; } }
        private static Java.Lang.String _TOGGLE_POPUPContent = default;
        private static bool _TOGGLE_POPUPReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#getAccessibleActionCount()"/> 
        /// </summary>
        public int AccessibleActionCount
        {
            get { return IExecuteWithSignature<int>("getAccessibleActionCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#doAccessibleAction(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DoAccessibleAction(int arg0)
        {
            return IExecuteWithSignature<bool>("doAccessibleAction", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#getAccessibleActionDescription(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAccessibleActionDescription(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAccessibleActionDescription", "(I)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}