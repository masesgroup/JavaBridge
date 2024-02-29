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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Smartcardio
{
    #region TerminalFactory
    public partial class TerminalFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/TerminalFactory.html#getDefault()"/> 
        /// </summary>
        public static Javax.Smartcardio.TerminalFactory Default
        {
            get { return SExecuteWithSignature<Javax.Smartcardio.TerminalFactory>(LocalBridgeClazz, "getDefault", "()Ljavax/smartcardio/TerminalFactory;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/TerminalFactory.html#getDefaultType()"/> 
        /// </summary>
        public static Java.Lang.String DefaultType
        {
            get { return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getDefaultType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/TerminalFactory.html#getInstance(java.lang.String,java.lang.Object,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Smartcardio.TerminalFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Javax.Smartcardio.TerminalFactory GetInstance(Java.Lang.String arg0, object arg1, Java.Lang.String arg2)
        {
            return SExecute<Javax.Smartcardio.TerminalFactory>(LocalBridgeClazz, "getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/TerminalFactory.html#getInstance(java.lang.String,java.lang.Object,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Javax.Smartcardio.TerminalFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Smartcardio.TerminalFactory GetInstance(Java.Lang.String arg0, object arg1, Java.Security.Provider arg2)
        {
            return SExecute<Javax.Smartcardio.TerminalFactory>(LocalBridgeClazz, "getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/TerminalFactory.html#getInstance(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Javax.Smartcardio.TerminalFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Smartcardio.TerminalFactory GetInstance(Java.Lang.String arg0, object arg1)
        {
            return SExecute<Javax.Smartcardio.TerminalFactory>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/TerminalFactory.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/TerminalFactory.html#getType()"/> 
        /// </summary>
        public Java.Lang.String Type
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/TerminalFactory.html#terminals()"/>
        /// </summary>

        /// <returns><see cref="Javax.Smartcardio.CardTerminals"/></returns>
        public Javax.Smartcardio.CardTerminals Terminals()
        {
            return IExecuteWithSignature<Javax.Smartcardio.CardTerminals>("terminals", "()Ljavax/smartcardio/CardTerminals;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}