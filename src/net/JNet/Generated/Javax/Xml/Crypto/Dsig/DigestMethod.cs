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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Crypto.Dsig
{
    #region IDigestMethod
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDigestMethod
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#getParameterSpec()"/> 
        /// </summary>
        Java.Security.Spec.AlgorithmParameterSpec ParameterSpec { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DigestMethod
    public partial class DigestMethod : Javax.Xml.Crypto.Dsig.IDigestMethod
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.DigestMethod"/> to <see cref="Javax.Xml.Crypto.XMLStructure"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.XMLStructure(Javax.Xml.Crypto.Dsig.DigestMethod t) => t.Cast<Javax.Xml.Crypto.XMLStructure>();
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.DigestMethod"/> to <see cref="Javax.Xml.Crypto.AlgorithmMethod"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.AlgorithmMethod(Javax.Xml.Crypto.Dsig.DigestMethod t) => t.Cast<Javax.Xml.Crypto.AlgorithmMethod>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#RIPEMD160"/>
        /// </summary>
        public static Java.Lang.String RIPEMD160 { get { if (!_RIPEMD160Ready) { _RIPEMD160Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "RIPEMD160"); _RIPEMD160Ready = true; } return _RIPEMD160Content; } }
        private static Java.Lang.String _RIPEMD160Content = default;
        private static bool _RIPEMD160Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA1"/>
        /// </summary>
        public static Java.Lang.String SHA1 { get { if (!_SHA1Ready) { _SHA1Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHA1"); _SHA1Ready = true; } return _SHA1Content; } }
        private static Java.Lang.String _SHA1Content = default;
        private static bool _SHA1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA224"/>
        /// </summary>
        public static Java.Lang.String SHA224 { get { if (!_SHA224Ready) { _SHA224Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHA224"); _SHA224Ready = true; } return _SHA224Content; } }
        private static Java.Lang.String _SHA224Content = default;
        private static bool _SHA224Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA256"/>
        /// </summary>
        public static Java.Lang.String SHA256 { get { if (!_SHA256Ready) { _SHA256Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHA256"); _SHA256Ready = true; } return _SHA256Content; } }
        private static Java.Lang.String _SHA256Content = default;
        private static bool _SHA256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA3_224"/>
        /// </summary>
        public static Java.Lang.String SHA3_224 { get { if (!_SHA3_224Ready) { _SHA3_224Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHA3_224"); _SHA3_224Ready = true; } return _SHA3_224Content; } }
        private static Java.Lang.String _SHA3_224Content = default;
        private static bool _SHA3_224Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA3_256"/>
        /// </summary>
        public static Java.Lang.String SHA3_256 { get { if (!_SHA3_256Ready) { _SHA3_256Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHA3_256"); _SHA3_256Ready = true; } return _SHA3_256Content; } }
        private static Java.Lang.String _SHA3_256Content = default;
        private static bool _SHA3_256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA3_384"/>
        /// </summary>
        public static Java.Lang.String SHA3_384 { get { if (!_SHA3_384Ready) { _SHA3_384Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHA3_384"); _SHA3_384Ready = true; } return _SHA3_384Content; } }
        private static Java.Lang.String _SHA3_384Content = default;
        private static bool _SHA3_384Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA3_512"/>
        /// </summary>
        public static Java.Lang.String SHA3_512 { get { if (!_SHA3_512Ready) { _SHA3_512Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHA3_512"); _SHA3_512Ready = true; } return _SHA3_512Content; } }
        private static Java.Lang.String _SHA3_512Content = default;
        private static bool _SHA3_512Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA384"/>
        /// </summary>
        public static Java.Lang.String SHA384 { get { if (!_SHA384Ready) { _SHA384Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHA384"); _SHA384Ready = true; } return _SHA384Content; } }
        private static Java.Lang.String _SHA384Content = default;
        private static bool _SHA384Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA512"/>
        /// </summary>
        public static Java.Lang.String SHA512 { get { if (!_SHA512Ready) { _SHA512Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHA512"); _SHA512Ready = true; } return _SHA512Content; } }
        private static Java.Lang.String _SHA512Content = default;
        private static bool _SHA512Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#getParameterSpec()"/> 
        /// </summary>
        public Java.Security.Spec.AlgorithmParameterSpec ParameterSpec
        {
            get { return IExecute<Java.Security.Spec.AlgorithmParameterSpec>("getParameterSpec"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}