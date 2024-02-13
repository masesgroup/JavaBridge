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
    #region XMLSignatureFactory
    public partial class XMLSignatureFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#getInstance()"/> 
        /// </summary>
        public static Javax.Xml.Crypto.Dsig.XMLSignatureFactory Instance
        {
            get { return SExecute<Javax.Xml.Crypto.Dsig.XMLSignatureFactory>(LocalBridgeClazz, "getInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.XMLSignatureFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Javax.Xml.Crypto.Dsig.XMLSignatureFactory GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Javax.Xml.Crypto.Dsig.XMLSignatureFactory>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.XMLSignatureFactory"/></returns>
        public static Javax.Xml.Crypto.Dsig.XMLSignatureFactory GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecute<Javax.Xml.Crypto.Dsig.XMLSignatureFactory>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.XMLSignatureFactory"/></returns>
        public static Javax.Xml.Crypto.Dsig.XMLSignatureFactory GetInstance(Java.Lang.String arg0)
        {
            return SExecute<Javax.Xml.Crypto.Dsig.XMLSignatureFactory>(LocalBridgeClazz, "getInstance", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#getKeyInfoFactory()"/> 
        /// </summary>
        public Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory KeyInfoFactory
        {
            get { return IExecute<Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory>("getKeyInfoFactory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#getMechanismType()"/> 
        /// </summary>
        public Java.Lang.String MechanismType
        {
            get { return IExecute<Java.Lang.String>("getMechanismType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecute<Java.Security.Provider>("getProvider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#getURIDereferencer()"/> 
        /// </summary>
        public Javax.Xml.Crypto.URIDereferencer URIDereferencer
        {
            get { return IExecute<Javax.Xml.Crypto.URIDereferencer>("getURIDereferencer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#isFeatureSupported(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsFeatureSupported(Java.Lang.String arg0)
        {
            return IExecute<bool>("isFeatureSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newCanonicalizationMethod(java.lang.String,javax.xml.crypto.dsig.spec.C14NMethodParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.Dsig.Spec.C14NMethodParameterSpec"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.CanonicalizationMethod"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public Javax.Xml.Crypto.Dsig.CanonicalizationMethod NewCanonicalizationMethod(Java.Lang.String arg0, Javax.Xml.Crypto.Dsig.Spec.C14NMethodParameterSpec arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.CanonicalizationMethod>("newCanonicalizationMethod", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newCanonicalizationMethod(java.lang.String,javax.xml.crypto.XMLStructure)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.XMLStructure"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.CanonicalizationMethod"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public Javax.Xml.Crypto.Dsig.CanonicalizationMethod NewCanonicalizationMethod(Java.Lang.String arg0, Javax.Xml.Crypto.XMLStructure arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.CanonicalizationMethod>("newCanonicalizationMethod", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newDigestMethod(java.lang.String,javax.xml.crypto.dsig.spec.DigestMethodParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.Dsig.Spec.DigestMethodParameterSpec"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.DigestMethod"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public Javax.Xml.Crypto.Dsig.DigestMethod NewDigestMethod(Java.Lang.String arg0, Javax.Xml.Crypto.Dsig.Spec.DigestMethodParameterSpec arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.DigestMethod>("newDigestMethod", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newManifest(java.util.List,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Xml_Crypto_Dsig_Reference"><see cref="Javax.Xml.Crypto.Dsig.Reference"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Manifest"/></returns>
        public Javax.Xml.Crypto.Dsig.Manifest NewManifest<Arg0ExtendsJavax_Xml_Crypto_Dsig_Reference>(Java.Util.List<Arg0ExtendsJavax_Xml_Crypto_Dsig_Reference> arg0, Java.Lang.String arg1) where Arg0ExtendsJavax_Xml_Crypto_Dsig_Reference: Javax.Xml.Crypto.Dsig.Reference
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Manifest>("newManifest", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newManifest(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Xml_Crypto_Dsig_Reference"><see cref="Javax.Xml.Crypto.Dsig.Reference"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Manifest"/></returns>
        public Javax.Xml.Crypto.Dsig.Manifest NewManifest<Arg0ExtendsJavax_Xml_Crypto_Dsig_Reference>(Java.Util.List<Arg0ExtendsJavax_Xml_Crypto_Dsig_Reference> arg0) where Arg0ExtendsJavax_Xml_Crypto_Dsig_Reference: Javax.Xml.Crypto.Dsig.Reference
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Manifest>("newManifest", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newReference(java.lang.String,javax.xml.crypto.dsig.DigestMethod,java.util.List,java.lang.String,java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.Dsig.DigestMethod"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="byte"/></param>
        /// <typeparam name="Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform"><see cref="Javax.Xml.Crypto.Dsig.Transform"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Reference"/></returns>
        public Javax.Xml.Crypto.Dsig.Reference NewReference<Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform>(Java.Lang.String arg0, Javax.Xml.Crypto.Dsig.DigestMethod arg1, Java.Util.List<Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform> arg2, Java.Lang.String arg3, Java.Lang.String arg4, byte[] arg5) where Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform: Javax.Xml.Crypto.Dsig.Transform
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Reference>("newReference", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newReference(java.lang.String,javax.xml.crypto.dsig.DigestMethod,java.util.List,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.Dsig.DigestMethod"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform"><see cref="Javax.Xml.Crypto.Dsig.Transform"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Reference"/></returns>
        public Javax.Xml.Crypto.Dsig.Reference NewReference<Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform>(Java.Lang.String arg0, Javax.Xml.Crypto.Dsig.DigestMethod arg1, Java.Util.List<Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform> arg2, Java.Lang.String arg3, Java.Lang.String arg4) where Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform: Javax.Xml.Crypto.Dsig.Transform
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Reference>("newReference", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newReference(java.lang.String,javax.xml.crypto.dsig.DigestMethod,java.util.List,javax.xml.crypto.Data,java.util.List,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.Dsig.DigestMethod"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <param name="arg3"><see cref="Javax.Xml.Crypto.Data"/></param>
        /// <param name="arg4"><see cref="Java.Util.List"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        /// <param name="arg6"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform"><see cref="Javax.Xml.Crypto.Dsig.Transform"/></typeparam>
        /// <typeparam name="Arg4ExtendsJavax_Xml_Crypto_Dsig_Transform"><see cref="Javax.Xml.Crypto.Dsig.Transform"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Reference"/></returns>
        public Javax.Xml.Crypto.Dsig.Reference NewReference<Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform, Arg4ExtendsJavax_Xml_Crypto_Dsig_Transform>(Java.Lang.String arg0, Javax.Xml.Crypto.Dsig.DigestMethod arg1, Java.Util.List<Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform> arg2, Javax.Xml.Crypto.Data arg3, Java.Util.List<Arg4ExtendsJavax_Xml_Crypto_Dsig_Transform> arg4, Java.Lang.String arg5, Java.Lang.String arg6) where Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform: Javax.Xml.Crypto.Dsig.Transform where Arg4ExtendsJavax_Xml_Crypto_Dsig_Transform: Javax.Xml.Crypto.Dsig.Transform
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Reference>("newReference", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newReference(java.lang.String,javax.xml.crypto.dsig.DigestMethod)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.Dsig.DigestMethod"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Reference"/></returns>
        public Javax.Xml.Crypto.Dsig.Reference NewReference(Java.Lang.String arg0, Javax.Xml.Crypto.Dsig.DigestMethod arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Reference>("newReference", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newSignatureMethod(java.lang.String,javax.xml.crypto.dsig.spec.SignatureMethodParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.Dsig.Spec.SignatureMethodParameterSpec"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.SignatureMethod"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public Javax.Xml.Crypto.Dsig.SignatureMethod NewSignatureMethod(Java.Lang.String arg0, Javax.Xml.Crypto.Dsig.Spec.SignatureMethodParameterSpec arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.SignatureMethod>("newSignatureMethod", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newSignatureProperties(java.util.List,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Xml_Crypto_Dsig_SignatureProperty"><see cref="Javax.Xml.Crypto.Dsig.SignatureProperty"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.SignatureProperties"/></returns>
        public Javax.Xml.Crypto.Dsig.SignatureProperties NewSignatureProperties<Arg0ExtendsJavax_Xml_Crypto_Dsig_SignatureProperty>(Java.Util.List<Arg0ExtendsJavax_Xml_Crypto_Dsig_SignatureProperty> arg0, Java.Lang.String arg1) where Arg0ExtendsJavax_Xml_Crypto_Dsig_SignatureProperty: Javax.Xml.Crypto.Dsig.SignatureProperty
        {
            return IExecute<Javax.Xml.Crypto.Dsig.SignatureProperties>("newSignatureProperties", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newSignatureProperty(java.util.List,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Xml_Crypto_XMLStructure"><see cref="Javax.Xml.Crypto.XMLStructure"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.SignatureProperty"/></returns>
        public Javax.Xml.Crypto.Dsig.SignatureProperty NewSignatureProperty<Arg0ExtendsJavax_Xml_Crypto_XMLStructure>(Java.Util.List<Arg0ExtendsJavax_Xml_Crypto_XMLStructure> arg0, Java.Lang.String arg1, Java.Lang.String arg2) where Arg0ExtendsJavax_Xml_Crypto_XMLStructure: Javax.Xml.Crypto.XMLStructure
        {
            return IExecute<Javax.Xml.Crypto.Dsig.SignatureProperty>("newSignatureProperty", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newSignedInfo(javax.xml.crypto.dsig.CanonicalizationMethod,javax.xml.crypto.dsig.SignatureMethod,java.util.List,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Dsig.CanonicalizationMethod"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.Dsig.SignatureMethod"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="Arg2ExtendsJavax_Xml_Crypto_Dsig_Reference"><see cref="Javax.Xml.Crypto.Dsig.Reference"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.SignedInfo"/></returns>
        public Javax.Xml.Crypto.Dsig.SignedInfo NewSignedInfo<Arg2ExtendsJavax_Xml_Crypto_Dsig_Reference>(Javax.Xml.Crypto.Dsig.CanonicalizationMethod arg0, Javax.Xml.Crypto.Dsig.SignatureMethod arg1, Java.Util.List<Arg2ExtendsJavax_Xml_Crypto_Dsig_Reference> arg2, Java.Lang.String arg3) where Arg2ExtendsJavax_Xml_Crypto_Dsig_Reference: Javax.Xml.Crypto.Dsig.Reference
        {
            return IExecute<Javax.Xml.Crypto.Dsig.SignedInfo>("newSignedInfo", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newSignedInfo(javax.xml.crypto.dsig.CanonicalizationMethod,javax.xml.crypto.dsig.SignatureMethod,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Dsig.CanonicalizationMethod"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.Dsig.SignatureMethod"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <typeparam name="Arg2ExtendsJavax_Xml_Crypto_Dsig_Reference"><see cref="Javax.Xml.Crypto.Dsig.Reference"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.SignedInfo"/></returns>
        public Javax.Xml.Crypto.Dsig.SignedInfo NewSignedInfo<Arg2ExtendsJavax_Xml_Crypto_Dsig_Reference>(Javax.Xml.Crypto.Dsig.CanonicalizationMethod arg0, Javax.Xml.Crypto.Dsig.SignatureMethod arg1, Java.Util.List<Arg2ExtendsJavax_Xml_Crypto_Dsig_Reference> arg2) where Arg2ExtendsJavax_Xml_Crypto_Dsig_Reference: Javax.Xml.Crypto.Dsig.Reference
        {
            return IExecute<Javax.Xml.Crypto.Dsig.SignedInfo>("newSignedInfo", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newTransform(java.lang.String,javax.xml.crypto.dsig.spec.TransformParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.Dsig.Spec.TransformParameterSpec"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Transform"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public Javax.Xml.Crypto.Dsig.Transform NewTransform(Java.Lang.String arg0, Javax.Xml.Crypto.Dsig.Spec.TransformParameterSpec arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Transform>("newTransform", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newTransform(java.lang.String,javax.xml.crypto.XMLStructure)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.XMLStructure"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Transform"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public Javax.Xml.Crypto.Dsig.Transform NewTransform(Java.Lang.String arg0, Javax.Xml.Crypto.XMLStructure arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Transform>("newTransform", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newXMLObject(java.util.List,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Xml_Crypto_XMLStructure"><see cref="Javax.Xml.Crypto.XMLStructure"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.XMLObject"/></returns>
        public Javax.Xml.Crypto.Dsig.XMLObject NewXMLObject<Arg0ExtendsJavax_Xml_Crypto_XMLStructure>(Java.Util.List<Arg0ExtendsJavax_Xml_Crypto_XMLStructure> arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3) where Arg0ExtendsJavax_Xml_Crypto_XMLStructure: Javax.Xml.Crypto.XMLStructure
        {
            return IExecute<Javax.Xml.Crypto.Dsig.XMLObject>("newXMLObject", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newXMLSignature(javax.xml.crypto.dsig.SignedInfo,javax.xml.crypto.dsig.keyinfo.KeyInfo,java.util.List,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Dsig.SignedInfo"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="Arg2ExtendsJavax_Xml_Crypto_Dsig_XMLObject"><see cref="Javax.Xml.Crypto.Dsig.XMLObject"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.XMLSignature"/></returns>
        public Javax.Xml.Crypto.Dsig.XMLSignature NewXMLSignature<Arg2ExtendsJavax_Xml_Crypto_Dsig_XMLObject>(Javax.Xml.Crypto.Dsig.SignedInfo arg0, Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo arg1, Java.Util.List<Arg2ExtendsJavax_Xml_Crypto_Dsig_XMLObject> arg2, Java.Lang.String arg3, Java.Lang.String arg4) where Arg2ExtendsJavax_Xml_Crypto_Dsig_XMLObject: Javax.Xml.Crypto.Dsig.XMLObject
        {
            return IExecute<Javax.Xml.Crypto.Dsig.XMLSignature>("newXMLSignature", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newXMLSignature(javax.xml.crypto.dsig.SignedInfo,javax.xml.crypto.dsig.keyinfo.KeyInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Dsig.SignedInfo"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.XMLSignature"/></returns>
        public Javax.Xml.Crypto.Dsig.XMLSignature NewXMLSignature(Javax.Xml.Crypto.Dsig.SignedInfo arg0, Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.XMLSignature>("newXMLSignature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#unmarshalXMLSignature(javax.xml.crypto.dsig.XMLValidateContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Dsig.XMLValidateContext"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.XMLSignature"/></returns>
        /// <exception cref="Javax.Xml.Crypto.MarshalException"/>
        public Javax.Xml.Crypto.Dsig.XMLSignature UnmarshalXMLSignature(Javax.Xml.Crypto.Dsig.XMLValidateContext arg0)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.XMLSignature>("unmarshalXMLSignature", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#unmarshalXMLSignature(javax.xml.crypto.XMLStructure)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.XMLStructure"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.XMLSignature"/></returns>
        /// <exception cref="Javax.Xml.Crypto.MarshalException"/>
        public Javax.Xml.Crypto.Dsig.XMLSignature UnmarshalXMLSignature(Javax.Xml.Crypto.XMLStructure arg0)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.XMLSignature>("unmarshalXMLSignature", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}