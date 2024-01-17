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

namespace Javax.Xml.Crypto.Dsig
{
    #region ISignatureProperties
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISignatureProperties : Javax.Xml.Crypto.IXMLStructure
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureProperties.html#getId()"/> 
        /// </summary>
        string Id { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureProperties.html#getProperties()"/> 
        /// </summary>
        Java.Util.List<Javax.Xml.Crypto.Dsig.SignatureProperty> Properties { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SignatureProperties
    public partial class SignatureProperties : Javax.Xml.Crypto.Dsig.ISignatureProperties
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureProperties.html#TYPE"/>
        /// </summary>
        public static string TYPE { get { return SGetField<string>(LocalBridgeClazz, "TYPE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureProperties.html#getId()"/> 
        /// </summary>
        public string Id
        {
            get { return IExecute<string>("getId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureProperties.html#getProperties()"/> 
        /// </summary>
        public Java.Util.List<Javax.Xml.Crypto.Dsig.SignatureProperty> Properties
        {
            get { return IExecute<Java.Util.List<Javax.Xml.Crypto.Dsig.SignatureProperty>>("getProperties"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}