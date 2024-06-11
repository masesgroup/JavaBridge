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

namespace Javax.Xml.Crypto.Dsig
{
    #region IXMLSignature
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXMLSignature : Javax.Xml.Crypto.IXMLStructure
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#getSignatureValue()"/> 
        /// </summary>
        Javax.Xml.Crypto.Dsig.XMLSignature.SignatureValue GetSignatureValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#getId()"/> 
        /// </summary>
        Java.Lang.String Id { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#getKeyInfo()"/> 
        /// </summary>
        Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo KeyInfo { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#getKeySelectorResult()"/> 
        /// </summary>
        Javax.Xml.Crypto.KeySelectorResult KeySelectorResult { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#getObjects()"/> 
        /// </summary>
        Java.Util.List<Javax.Xml.Crypto.Dsig.XMLObject> Objects { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#getSignedInfo()"/> 
        /// </summary>
        Javax.Xml.Crypto.Dsig.SignedInfo SignedInfo { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#validate(javax.xml.crypto.dsig.XMLValidateContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Dsig.XMLValidateContext"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Xml.Crypto.Dsig.XMLSignatureException"/>
        bool Validate(Javax.Xml.Crypto.Dsig.XMLValidateContext arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#sign(javax.xml.crypto.dsig.XMLSignContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Dsig.XMLSignContext"/></param>
        /// <exception cref="Javax.Xml.Crypto.MarshalException"/>
        /// <exception cref="Javax.Xml.Crypto.Dsig.XMLSignatureException"/>
        void Sign(Javax.Xml.Crypto.Dsig.XMLSignContext arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XMLSignature
    public partial class XMLSignature : Javax.Xml.Crypto.Dsig.IXMLSignature
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#XMLNS"/>
        /// </summary>
        public static Java.Lang.String XMLNS { get { if (!_XMLNSReady) { _XMLNSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "XMLNS"); _XMLNSReady = true; } return _XMLNSContent; } }
        private static Java.Lang.String _XMLNSContent = default;
        private static bool _XMLNSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#getSignatureValue()"/> 
        /// </summary>
        public Javax.Xml.Crypto.Dsig.XMLSignature.SignatureValue GetSignatureValue
        {
            get { return IExecuteWithSignature<Javax.Xml.Crypto.Dsig.XMLSignature.SignatureValue>("getSignatureValue", "()Ljavax/xml/crypto/dsig/XMLSignature$SignatureValue;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#getId()"/> 
        /// </summary>
        public Java.Lang.String Id
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#getKeyInfo()"/> 
        /// </summary>
        public Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo KeyInfo
        {
            get { return IExecuteWithSignature<Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo>("getKeyInfo", "()Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#getKeySelectorResult()"/> 
        /// </summary>
        public Javax.Xml.Crypto.KeySelectorResult KeySelectorResult
        {
            get { return IExecuteWithSignature<Javax.Xml.Crypto.KeySelectorResult>("getKeySelectorResult", "()Ljavax/xml/crypto/KeySelectorResult;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#getObjects()"/> 
        /// </summary>
        public Java.Util.List<Javax.Xml.Crypto.Dsig.XMLObject> Objects
        {
            get { return IExecuteWithSignature<Java.Util.List<Javax.Xml.Crypto.Dsig.XMLObject>>("getObjects", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#getSignedInfo()"/> 
        /// </summary>
        public Javax.Xml.Crypto.Dsig.SignedInfo SignedInfo
        {
            get { return IExecuteWithSignature<Javax.Xml.Crypto.Dsig.SignedInfo>("getSignedInfo", "()Ljavax/xml/crypto/dsig/SignedInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#validate(javax.xml.crypto.dsig.XMLValidateContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Dsig.XMLValidateContext"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Xml.Crypto.Dsig.XMLSignatureException"/>
        public bool Validate(Javax.Xml.Crypto.Dsig.XMLValidateContext arg0)
        {
            return IExecuteWithSignature<bool>("validate", "(Ljavax/xml/crypto/dsig/XMLValidateContext;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.html#sign(javax.xml.crypto.dsig.XMLSignContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Dsig.XMLSignContext"/></param>
        /// <exception cref="Javax.Xml.Crypto.MarshalException"/>
        /// <exception cref="Javax.Xml.Crypto.Dsig.XMLSignatureException"/>
        public void Sign(Javax.Xml.Crypto.Dsig.XMLSignContext arg0)
        {
            IExecuteWithSignature("sign", "(Ljavax/xml/crypto/dsig/XMLSignContext;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region SignatureValue
        public partial class SignatureValue
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.SignatureValue.html#getId()"/> 
            /// </summary>
            public Java.Lang.String Id
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.SignatureValue.html#getValue()"/> 
            /// </summary>
            public byte[] Value
            {
                get { return IExecuteWithSignatureArray<byte>("getValue", "()[B"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignature.SignatureValue.html#validate(javax.xml.crypto.dsig.XMLValidateContext)"/>
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}