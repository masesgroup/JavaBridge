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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Sql
{
    #region ClientInfoStatus definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ClientInfoStatus.html"/>
    /// </summary>
    public partial class ClientInfoStatus : Java.Lang.Enum<Java.Sql.ClientInfoStatus>
    {
        const string _bridgeClassName = "java.sql.ClientInfoStatus";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ClientInfoStatus() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ClientInfoStatus(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ClientInfoStatus
    public partial class ClientInfoStatus
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ClientInfoStatus.html#REASON_UNKNOWN"/>
        /// </summary>
        public static Java.Sql.ClientInfoStatus REASON_UNKNOWN { get { if (!_REASON_UNKNOWNReady) { _REASON_UNKNOWNContent = SGetField<Java.Sql.ClientInfoStatus>(LocalBridgeClazz, "REASON_UNKNOWN"); _REASON_UNKNOWNReady = true; } return _REASON_UNKNOWNContent; } }
        private static Java.Sql.ClientInfoStatus _REASON_UNKNOWNContent = default;
        private static bool _REASON_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ClientInfoStatus.html#REASON_UNKNOWN_PROPERTY"/>
        /// </summary>
        public static Java.Sql.ClientInfoStatus REASON_UNKNOWN_PROPERTY { get { if (!_REASON_UNKNOWN_PROPERTYReady) { _REASON_UNKNOWN_PROPERTYContent = SGetField<Java.Sql.ClientInfoStatus>(LocalBridgeClazz, "REASON_UNKNOWN_PROPERTY"); _REASON_UNKNOWN_PROPERTYReady = true; } return _REASON_UNKNOWN_PROPERTYContent; } }
        private static Java.Sql.ClientInfoStatus _REASON_UNKNOWN_PROPERTYContent = default;
        private static bool _REASON_UNKNOWN_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ClientInfoStatus.html#REASON_VALUE_INVALID"/>
        /// </summary>
        public static Java.Sql.ClientInfoStatus REASON_VALUE_INVALID { get { if (!_REASON_VALUE_INVALIDReady) { _REASON_VALUE_INVALIDContent = SGetField<Java.Sql.ClientInfoStatus>(LocalBridgeClazz, "REASON_VALUE_INVALID"); _REASON_VALUE_INVALIDReady = true; } return _REASON_VALUE_INVALIDContent; } }
        private static Java.Sql.ClientInfoStatus _REASON_VALUE_INVALIDContent = default;
        private static bool _REASON_VALUE_INVALIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ClientInfoStatus.html#REASON_VALUE_TRUNCATED"/>
        /// </summary>
        public static Java.Sql.ClientInfoStatus REASON_VALUE_TRUNCATED { get { if (!_REASON_VALUE_TRUNCATEDReady) { _REASON_VALUE_TRUNCATEDContent = SGetField<Java.Sql.ClientInfoStatus>(LocalBridgeClazz, "REASON_VALUE_TRUNCATED"); _REASON_VALUE_TRUNCATEDReady = true; } return _REASON_VALUE_TRUNCATEDContent; } }
        private static Java.Sql.ClientInfoStatus _REASON_VALUE_TRUNCATEDContent = default;
        private static bool _REASON_VALUE_TRUNCATEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ClientInfoStatus.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.ClientInfoStatus"/></returns>
        public static Java.Sql.ClientInfoStatus ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Sql.ClientInfoStatus>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/sql/ClientInfoStatus;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ClientInfoStatus.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.ClientInfoStatus"/></returns>
        public static Java.Sql.ClientInfoStatus[] Values()
        {
            return SExecuteWithSignatureArray<Java.Sql.ClientInfoStatus>(LocalBridgeClazz, "values", "()[Ljava/sql/ClientInfoStatus;");
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