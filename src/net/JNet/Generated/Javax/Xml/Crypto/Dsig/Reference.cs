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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Crypto.Dsig
{
    #region IReference
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IReference
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#getCalculatedDigestValue()"/> 
        /// </summary>
        byte[] CalculatedDigestValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#getDereferencedData()"/> 
        /// </summary>
        Javax.Xml.Crypto.Data DereferencedData { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#getDigestInputStream()"/> 
        /// </summary>
        Java.Io.InputStream DigestInputStream { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#getDigestMethod()"/> 
        /// </summary>
        Javax.Xml.Crypto.Dsig.DigestMethod DigestMethod { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#getDigestValue()"/> 
        /// </summary>
        byte[] DigestValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#getId()"/> 
        /// </summary>
        Java.Lang.String Id { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#getTransforms()"/> 
        /// </summary>
        Java.Util.List<Javax.Xml.Crypto.Dsig.Transform> Transforms { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#validate(javax.xml.crypto.dsig.XMLValidateContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Dsig.XMLValidateContext"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Xml.Crypto.Dsig.XMLSignatureException"/>
        bool Validate(Javax.Xml.Crypto.Dsig.XMLValidateContext arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Reference
    public partial class Reference : Javax.Xml.Crypto.Dsig.IReference
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.Reference"/> to <see cref="Javax.Xml.Crypto.URIReference"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.URIReference(Javax.Xml.Crypto.Dsig.Reference t) => t.Cast<Javax.Xml.Crypto.URIReference>();
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.Reference"/> to <see cref="Javax.Xml.Crypto.XMLStructure"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.XMLStructure(Javax.Xml.Crypto.Dsig.Reference t) => t.Cast<Javax.Xml.Crypto.XMLStructure>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#getCalculatedDigestValue()"/> 
        /// </summary>
        public byte[] CalculatedDigestValue
        {
            get { return IExecuteWithSignatureArray<byte>("getCalculatedDigestValue", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#getDereferencedData()"/> 
        /// </summary>
        public Javax.Xml.Crypto.Data DereferencedData
        {
            get { return IExecuteWithSignature<Javax.Xml.Crypto.Data>("getDereferencedData", "()Ljavax/xml/crypto/Data;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#getDigestInputStream()"/> 
        /// </summary>
        public Java.Io.InputStream DigestInputStream
        {
            get { return IExecuteWithSignature<Java.Io.InputStream>("getDigestInputStream", "()Ljava/io/InputStream;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#getDigestMethod()"/> 
        /// </summary>
        public Javax.Xml.Crypto.Dsig.DigestMethod DigestMethod
        {
            get { return IExecuteWithSignature<Javax.Xml.Crypto.Dsig.DigestMethod>("getDigestMethod", "()Ljavax/xml/crypto/dsig/DigestMethod;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#getDigestValue()"/> 
        /// </summary>
        public byte[] DigestValue
        {
            get { return IExecuteWithSignatureArray<byte>("getDigestValue", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#getId()"/> 
        /// </summary>
        public Java.Lang.String Id
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#getTransforms()"/> 
        /// </summary>
        public Java.Util.List<Javax.Xml.Crypto.Dsig.Transform> Transforms
        {
            get { return IExecuteWithSignature<Java.Util.List<Javax.Xml.Crypto.Dsig.Transform>>("getTransforms", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html#validate(javax.xml.crypto.dsig.XMLValidateContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Dsig.XMLValidateContext"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Xml.Crypto.Dsig.XMLSignatureException"/>
        public bool Validate(Javax.Xml.Crypto.Dsig.XMLValidateContext arg0)
        {
            return IExecuteWithSignature<bool>("validate", "(Ljavax/xml/crypto/dsig/XMLValidateContext;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}