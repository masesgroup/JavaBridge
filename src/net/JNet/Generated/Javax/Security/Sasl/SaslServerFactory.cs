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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Security.Sasl
{
    #region SaslServerFactory
    public partial class SaslServerFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServerFactory.html#getMechanismNames(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] GetMechanismNames<Arg0Extendsobject>(Java.Util.Map<string, Arg0Extendsobject> arg0)
        {
            return IExecuteArray<string>("getMechanismNames", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslServerFactory.html#createSaslServer(java.lang.String,java.lang.String,java.lang.String,java.util.Map,javax.security.auth.callback.CallbackHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="Java.Util.Map"/></param>
        /// <param name="arg4"><see cref="Javax.Security.Auth.Callback.CallbackHandler"/></param>
        /// <returns><see cref="Javax.Security.Sasl.SaslServer"/></returns>
        /// <exception cref="Javax.Security.Sasl.SaslException"/>
        public Javax.Security.Sasl.SaslServer CreateSaslServer<Arg3Extendsobject>(string arg0, string arg1, string arg2, Java.Util.Map<string, Arg3Extendsobject> arg3, Javax.Security.Auth.Callback.CallbackHandler arg4)
        {
            return IExecute<Javax.Security.Sasl.SaslServer>("createSaslServer", arg0, arg1, arg2, arg3, arg4);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}