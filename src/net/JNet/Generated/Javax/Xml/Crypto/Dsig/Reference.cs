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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Crypto.Dsig
{
    #region Reference declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Reference.html"/>
    /// </summary>
    public partial class Reference : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Reference>
    {
        const string _bridgeClassName = "javax.xml.crypto.dsig.Reference";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Reference class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Reference() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Reference class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Reference(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

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

    #region Reference implementation
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