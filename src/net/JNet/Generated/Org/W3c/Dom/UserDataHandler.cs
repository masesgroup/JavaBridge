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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom
{
    #region IUserDataHandler
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IUserDataHandler
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/UserDataHandler.html#handle(short,java.lang.String,java.lang.Object,org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg4"><see cref="Org.W3c.Dom.Node"/></param>
        void Handle(short arg0, Java.Lang.String arg1, object arg2, Org.W3c.Dom.Node arg3, Org.W3c.Dom.Node arg4);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UserDataHandler
    public partial class UserDataHandler : Org.W3c.Dom.IUserDataHandler
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/UserDataHandler.html#NODE_ADOPTED"/>
        /// </summary>
        public static short NODE_ADOPTED { get { if (!_NODE_ADOPTEDReady) { _NODE_ADOPTEDContent = SGetField<short>(LocalBridgeClazz, "NODE_ADOPTED"); _NODE_ADOPTEDReady = true; } return _NODE_ADOPTEDContent; } }
        private static short _NODE_ADOPTEDContent = default;
        private static bool _NODE_ADOPTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/UserDataHandler.html#NODE_CLONED"/>
        /// </summary>
        public static short NODE_CLONED { get { if (!_NODE_CLONEDReady) { _NODE_CLONEDContent = SGetField<short>(LocalBridgeClazz, "NODE_CLONED"); _NODE_CLONEDReady = true; } return _NODE_CLONEDContent; } }
        private static short _NODE_CLONEDContent = default;
        private static bool _NODE_CLONEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/UserDataHandler.html#NODE_DELETED"/>
        /// </summary>
        public static short NODE_DELETED { get { if (!_NODE_DELETEDReady) { _NODE_DELETEDContent = SGetField<short>(LocalBridgeClazz, "NODE_DELETED"); _NODE_DELETEDReady = true; } return _NODE_DELETEDContent; } }
        private static short _NODE_DELETEDContent = default;
        private static bool _NODE_DELETEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/UserDataHandler.html#NODE_IMPORTED"/>
        /// </summary>
        public static short NODE_IMPORTED { get { if (!_NODE_IMPORTEDReady) { _NODE_IMPORTEDContent = SGetField<short>(LocalBridgeClazz, "NODE_IMPORTED"); _NODE_IMPORTEDReady = true; } return _NODE_IMPORTEDContent; } }
        private static short _NODE_IMPORTEDContent = default;
        private static bool _NODE_IMPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/UserDataHandler.html#NODE_RENAMED"/>
        /// </summary>
        public static short NODE_RENAMED { get { if (!_NODE_RENAMEDReady) { _NODE_RENAMEDContent = SGetField<short>(LocalBridgeClazz, "NODE_RENAMED"); _NODE_RENAMEDReady = true; } return _NODE_RENAMEDContent; } }
        private static short _NODE_RENAMEDContent = default;
        private static bool _NODE_RENAMEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/UserDataHandler.html#handle(short,java.lang.String,java.lang.Object,org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg4"><see cref="Org.W3c.Dom.Node"/></param>
        public void Handle(short arg0, Java.Lang.String arg1, object arg2, Org.W3c.Dom.Node arg3, Org.W3c.Dom.Node arg4)
        {
            IExecute("handle", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}