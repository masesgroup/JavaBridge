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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Crypto.Dsig.Keyinfo
{
    #region IKeyInfo
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IKeyInfo : Javax.Xml.Crypto.IXMLStructure
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfo.html#getContent()"/> 
        /// </summary>
        Java.Util.List<Javax.Xml.Crypto.XMLStructure> Content { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfo.html#getId()"/> 
        /// </summary>
        Java.Lang.String Id { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfo.html#marshal(javax.xml.crypto.XMLStructure,javax.xml.crypto.XMLCryptoContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.XMLStructure"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.XMLCryptoContext"/></param>
        /// <exception cref="Javax.Xml.Crypto.MarshalException"/>
        void Marshal(Javax.Xml.Crypto.XMLStructure arg0, Javax.Xml.Crypto.XMLCryptoContext arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KeyInfo
    public partial class KeyInfo : Javax.Xml.Crypto.Dsig.Keyinfo.IKeyInfo
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfo.html#getContent()"/> 
        /// </summary>
        public Java.Util.List<Javax.Xml.Crypto.XMLStructure> Content
        {
            get { return IExecuteWithSignature<Java.Util.List<Javax.Xml.Crypto.XMLStructure>>("getContent", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfo.html#getId()"/> 
        /// </summary>
        public Java.Lang.String Id
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfo.html#marshal(javax.xml.crypto.XMLStructure,javax.xml.crypto.XMLCryptoContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.XMLStructure"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.XMLCryptoContext"/></param>
        /// <exception cref="Javax.Xml.Crypto.MarshalException"/>
        public void Marshal(Javax.Xml.Crypto.XMLStructure arg0, Javax.Xml.Crypto.XMLCryptoContext arg1)
        {
            IExecute("marshal", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}