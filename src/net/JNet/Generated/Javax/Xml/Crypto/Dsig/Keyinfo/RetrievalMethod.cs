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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Crypto.Dsig.Keyinfo
{
    #region IRetrievalMethod
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRetrievalMethod
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/RetrievalMethod.html#getTransforms()"/> 
        /// </summary>
        Java.Util.List<Javax.Xml.Crypto.Dsig.Transform> Transforms { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/RetrievalMethod.html#getURI()"/> 
        /// </summary>
        string URI { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/RetrievalMethod.html#dereference(javax.xml.crypto.XMLCryptoContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.XMLCryptoContext"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Data"/></returns>
        /// <exception cref="Javax.Xml.Crypto.URIReferenceException"/>
        Javax.Xml.Crypto.Data Dereference(Javax.Xml.Crypto.XMLCryptoContext arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RetrievalMethod
    public partial class RetrievalMethod : Javax.Xml.Crypto.Dsig.Keyinfo.IRetrievalMethod
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.Keyinfo.RetrievalMethod"/> to <see cref="Javax.Xml.Crypto.URIReference"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.URIReference(Javax.Xml.Crypto.Dsig.Keyinfo.RetrievalMethod t) => t.Cast<Javax.Xml.Crypto.URIReference>();
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.Keyinfo.RetrievalMethod"/> to <see cref="Javax.Xml.Crypto.XMLStructure"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.XMLStructure(Javax.Xml.Crypto.Dsig.Keyinfo.RetrievalMethod t) => t.Cast<Javax.Xml.Crypto.XMLStructure>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/RetrievalMethod.html#getTransforms()"/> 
        /// </summary>
        public Java.Util.List<Javax.Xml.Crypto.Dsig.Transform> Transforms
        {
            get { return IExecute<Java.Util.List<Javax.Xml.Crypto.Dsig.Transform>>("getTransforms"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/RetrievalMethod.html#getURI()"/> 
        /// </summary>
        public string URI
        {
            get { return IExecute<string>("getURI"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/RetrievalMethod.html#dereference(javax.xml.crypto.XMLCryptoContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.XMLCryptoContext"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Data"/></returns>
        /// <exception cref="Javax.Xml.Crypto.URIReferenceException"/>
        public Javax.Xml.Crypto.Data Dereference(Javax.Xml.Crypto.XMLCryptoContext arg0)
        {
            return IExecute<Javax.Xml.Crypto.Data>("dereference", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}