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

namespace Java.Awt.DesktopNs
{
    #region UserSessionEvent
    public partial class UserSessionEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.html#%3Cinit%3E(java.awt.desktop.UserSessionEvent.Reason)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.UserSessionEvent.Reason"/></param>
        public UserSessionEvent(Java.Awt.DesktopNs.UserSessionEvent.Reason arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.html#getReason()"/> 
        /// </summary>
        public Java.Awt.DesktopNs.UserSessionEvent.Reason GetReason
        {
            get { return IExecuteWithSignature<Java.Awt.DesktopNs.UserSessionEvent.Reason>("getReason", "()Ljava/awt/desktop/UserSessionEvent$Reason;"); }
        }

        #endregion

        #region Nested classes
        #region Reason
        public partial class Reason
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.Reason.html#CONSOLE"/>
            /// </summary>
            public static Java.Awt.DesktopNs.UserSessionEvent.Reason CONSOLE { get { if (!_CONSOLEReady) { _CONSOLEContent = SGetField<Java.Awt.DesktopNs.UserSessionEvent.Reason>(LocalBridgeClazz, "CONSOLE"); _CONSOLEReady = true; } return _CONSOLEContent; } }
            private static Java.Awt.DesktopNs.UserSessionEvent.Reason _CONSOLEContent = default;
            private static bool _CONSOLEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.Reason.html#LOCK"/>
            /// </summary>
            public static Java.Awt.DesktopNs.UserSessionEvent.Reason LOCK { get { if (!_LOCKReady) { _LOCKContent = SGetField<Java.Awt.DesktopNs.UserSessionEvent.Reason>(LocalBridgeClazz, "LOCK"); _LOCKReady = true; } return _LOCKContent; } }
            private static Java.Awt.DesktopNs.UserSessionEvent.Reason _LOCKContent = default;
            private static bool _LOCKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.Reason.html#REMOTE"/>
            /// </summary>
            public static Java.Awt.DesktopNs.UserSessionEvent.Reason REMOTE { get { if (!_REMOTEReady) { _REMOTEContent = SGetField<Java.Awt.DesktopNs.UserSessionEvent.Reason>(LocalBridgeClazz, "REMOTE"); _REMOTEReady = true; } return _REMOTEContent; } }
            private static Java.Awt.DesktopNs.UserSessionEvent.Reason _REMOTEContent = default;
            private static bool _REMOTEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.Reason.html#UNSPECIFIED"/>
            /// </summary>
            public static Java.Awt.DesktopNs.UserSessionEvent.Reason UNSPECIFIED { get { if (!_UNSPECIFIEDReady) { _UNSPECIFIEDContent = SGetField<Java.Awt.DesktopNs.UserSessionEvent.Reason>(LocalBridgeClazz, "UNSPECIFIED"); _UNSPECIFIEDReady = true; } return _UNSPECIFIEDContent; } }
            private static Java.Awt.DesktopNs.UserSessionEvent.Reason _UNSPECIFIEDContent = default;
            private static bool _UNSPECIFIEDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.Reason.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Awt.DesktopNs.UserSessionEvent.Reason"/></returns>
            public static Java.Awt.DesktopNs.UserSessionEvent.Reason ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Awt.DesktopNs.UserSessionEvent.Reason>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/awt/desktop/UserSessionEvent$Reason;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.Reason.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Awt.DesktopNs.UserSessionEvent.Reason"/></returns>
            public static Java.Awt.DesktopNs.UserSessionEvent.Reason[] Values()
            {
                return SExecuteWithSignatureArray<Java.Awt.DesktopNs.UserSessionEvent.Reason>(LocalBridgeClazz, "values", "()[Ljava/awt/desktop/UserSessionEvent$Reason;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}