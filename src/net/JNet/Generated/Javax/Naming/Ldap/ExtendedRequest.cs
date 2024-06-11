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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Ldap
{
    #region IExtendedRequest
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IExtendedRequest : Java.Io.ISerializable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/ExtendedRequest.html#getEncodedValue()"/> 
        /// </summary>
        byte[] EncodedValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/ExtendedRequest.html#getID()"/> 
        /// </summary>
        Java.Lang.String ID { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/ExtendedRequest.html#createExtendedResponse(java.lang.String,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Javax.Naming.Ldap.ExtendedResponse"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Ldap.ExtendedResponse CreateExtendedResponse(Java.Lang.String arg0, byte[] arg1, int arg2, int arg3);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ExtendedRequest
    public partial class ExtendedRequest : Javax.Naming.Ldap.IExtendedRequest
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/ExtendedRequest.html#getEncodedValue()"/> 
        /// </summary>
        public byte[] EncodedValue
        {
            get { return IExecuteWithSignatureArray<byte>("getEncodedValue", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/ExtendedRequest.html#getID()"/> 
        /// </summary>
        public Java.Lang.String ID
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getID", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/ExtendedRequest.html#createExtendedResponse(java.lang.String,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Javax.Naming.Ldap.ExtendedResponse"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Ldap.ExtendedResponse CreateExtendedResponse(Java.Lang.String arg0, byte[] arg1, int arg2, int arg3)
        {
            return IExecute<Javax.Naming.Ldap.ExtendedResponse>("createExtendedResponse", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}