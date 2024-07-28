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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Security.Sasl
{
    #region Sasl
    public partial class Sasl
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#BOUND_SERVER_NAME"/>
        /// </summary>
        public static Java.Lang.String BOUND_SERVER_NAME { get { if (!_BOUND_SERVER_NAMEReady) { _BOUND_SERVER_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "BOUND_SERVER_NAME"); _BOUND_SERVER_NAMEReady = true; } return _BOUND_SERVER_NAMEContent; } }
        private static Java.Lang.String _BOUND_SERVER_NAMEContent = default;
        private static bool _BOUND_SERVER_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#CREDENTIALS"/>
        /// </summary>
        public static Java.Lang.String CREDENTIALS { get { if (!_CREDENTIALSReady) { _CREDENTIALSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CREDENTIALS"); _CREDENTIALSReady = true; } return _CREDENTIALSContent; } }
        private static Java.Lang.String _CREDENTIALSContent = default;
        private static bool _CREDENTIALSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#MAX_BUFFER"/>
        /// </summary>
        public static Java.Lang.String MAX_BUFFER { get { if (!_MAX_BUFFERReady) { _MAX_BUFFERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MAX_BUFFER"); _MAX_BUFFERReady = true; } return _MAX_BUFFERContent; } }
        private static Java.Lang.String _MAX_BUFFERContent = default;
        private static bool _MAX_BUFFERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#POLICY_FORWARD_SECRECY"/>
        /// </summary>
        public static Java.Lang.String POLICY_FORWARD_SECRECY { get { if (!_POLICY_FORWARD_SECRECYReady) { _POLICY_FORWARD_SECRECYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "POLICY_FORWARD_SECRECY"); _POLICY_FORWARD_SECRECYReady = true; } return _POLICY_FORWARD_SECRECYContent; } }
        private static Java.Lang.String _POLICY_FORWARD_SECRECYContent = default;
        private static bool _POLICY_FORWARD_SECRECYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#POLICY_NOACTIVE"/>
        /// </summary>
        public static Java.Lang.String POLICY_NOACTIVE { get { if (!_POLICY_NOACTIVEReady) { _POLICY_NOACTIVEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "POLICY_NOACTIVE"); _POLICY_NOACTIVEReady = true; } return _POLICY_NOACTIVEContent; } }
        private static Java.Lang.String _POLICY_NOACTIVEContent = default;
        private static bool _POLICY_NOACTIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#POLICY_NOANONYMOUS"/>
        /// </summary>
        public static Java.Lang.String POLICY_NOANONYMOUS { get { if (!_POLICY_NOANONYMOUSReady) { _POLICY_NOANONYMOUSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "POLICY_NOANONYMOUS"); _POLICY_NOANONYMOUSReady = true; } return _POLICY_NOANONYMOUSContent; } }
        private static Java.Lang.String _POLICY_NOANONYMOUSContent = default;
        private static bool _POLICY_NOANONYMOUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#POLICY_NODICTIONARY"/>
        /// </summary>
        public static Java.Lang.String POLICY_NODICTIONARY { get { if (!_POLICY_NODICTIONARYReady) { _POLICY_NODICTIONARYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "POLICY_NODICTIONARY"); _POLICY_NODICTIONARYReady = true; } return _POLICY_NODICTIONARYContent; } }
        private static Java.Lang.String _POLICY_NODICTIONARYContent = default;
        private static bool _POLICY_NODICTIONARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#POLICY_NOPLAINTEXT"/>
        /// </summary>
        public static Java.Lang.String POLICY_NOPLAINTEXT { get { if (!_POLICY_NOPLAINTEXTReady) { _POLICY_NOPLAINTEXTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "POLICY_NOPLAINTEXT"); _POLICY_NOPLAINTEXTReady = true; } return _POLICY_NOPLAINTEXTContent; } }
        private static Java.Lang.String _POLICY_NOPLAINTEXTContent = default;
        private static bool _POLICY_NOPLAINTEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#POLICY_PASS_CREDENTIALS"/>
        /// </summary>
        public static Java.Lang.String POLICY_PASS_CREDENTIALS { get { if (!_POLICY_PASS_CREDENTIALSReady) { _POLICY_PASS_CREDENTIALSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "POLICY_PASS_CREDENTIALS"); _POLICY_PASS_CREDENTIALSReady = true; } return _POLICY_PASS_CREDENTIALSContent; } }
        private static Java.Lang.String _POLICY_PASS_CREDENTIALSContent = default;
        private static bool _POLICY_PASS_CREDENTIALSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#QOP"/>
        /// </summary>
        public static Java.Lang.String QOP { get { if (!_QOPReady) { _QOPContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QOP"); _QOPReady = true; } return _QOPContent; } }
        private static Java.Lang.String _QOPContent = default;
        private static bool _QOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#RAW_SEND_SIZE"/>
        /// </summary>
        public static Java.Lang.String RAW_SEND_SIZE { get { if (!_RAW_SEND_SIZEReady) { _RAW_SEND_SIZEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RAW_SEND_SIZE"); _RAW_SEND_SIZEReady = true; } return _RAW_SEND_SIZEContent; } }
        private static Java.Lang.String _RAW_SEND_SIZEContent = default;
        private static bool _RAW_SEND_SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#REUSE"/>
        /// </summary>
        public static Java.Lang.String REUSE { get { if (!_REUSEReady) { _REUSEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REUSE"); _REUSEReady = true; } return _REUSEContent; } }
        private static Java.Lang.String _REUSEContent = default;
        private static bool _REUSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#SERVER_AUTH"/>
        /// </summary>
        public static Java.Lang.String SERVER_AUTH { get { if (!_SERVER_AUTHReady) { _SERVER_AUTHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVER_AUTH"); _SERVER_AUTHReady = true; } return _SERVER_AUTHContent; } }
        private static Java.Lang.String _SERVER_AUTHContent = default;
        private static bool _SERVER_AUTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#STRENGTH"/>
        /// </summary>
        public static Java.Lang.String STRENGTH { get { if (!_STRENGTHReady) { _STRENGTHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "STRENGTH"); _STRENGTHReady = true; } return _STRENGTHContent; } }
        private static Java.Lang.String _STRENGTHContent = default;
        private static bool _STRENGTHReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#getSaslClientFactories()"/> 
        /// </summary>
        public static Java.Util.Enumeration<Javax.Security.Sasl.SaslClientFactory> SaslClientFactories
        {
            get { return SExecuteWithSignature<Java.Util.Enumeration<Javax.Security.Sasl.SaslClientFactory>>(LocalBridgeClazz, "getSaslClientFactories", "()Ljava/util/Enumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#getSaslServerFactories()"/> 
        /// </summary>
        public static Java.Util.Enumeration<Javax.Security.Sasl.SaslServerFactory> SaslServerFactories
        {
            get { return SExecuteWithSignature<Java.Util.Enumeration<Javax.Security.Sasl.SaslServerFactory>>(LocalBridgeClazz, "getSaslServerFactories", "()Ljava/util/Enumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#createSaslClient(java.lang.String[],java.lang.String,java.lang.String,java.lang.String,java.util.Map,javax.security.auth.callback.CallbackHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Util.Map"/></param>
        /// <param name="arg5"><see cref="Javax.Security.Auth.Callback.CallbackHandler"/></param>
        /// <returns><see cref="Javax.Security.Sasl.SaslClient"/></returns>
        /// <exception cref="Javax.Security.Sasl.SaslException"/>
        public static Javax.Security.Sasl.SaslClient CreateSaslClient(Java.Lang.String[] arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, Java.Util.Map<Java.Lang.String, object> arg4, Javax.Security.Auth.Callback.CallbackHandler arg5)
        {
            return SExecute<Javax.Security.Sasl.SaslClient>(LocalBridgeClazz, "createSaslClient", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/Sasl.html#createSaslServer(java.lang.String,java.lang.String,java.lang.String,java.util.Map,javax.security.auth.callback.CallbackHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Util.Map"/></param>
        /// <param name="arg4"><see cref="Javax.Security.Auth.Callback.CallbackHandler"/></param>
        /// <returns><see cref="Javax.Security.Sasl.SaslServer"/></returns>
        /// <exception cref="Javax.Security.Sasl.SaslException"/>
        public static Javax.Security.Sasl.SaslServer CreateSaslServer(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Util.Map<Java.Lang.String, object> arg3, Javax.Security.Auth.Callback.CallbackHandler arg4)
        {
            return SExecute<Javax.Security.Sasl.SaslServer>(LocalBridgeClazz, "createSaslServer", arg0, arg1, arg2, arg3, arg4);
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