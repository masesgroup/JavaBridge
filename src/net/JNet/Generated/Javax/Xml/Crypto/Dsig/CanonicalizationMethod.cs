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
    #region ICanonicalizationMethod
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICanonicalizationMethod : Javax.Xml.Crypto.Dsig.ITransform
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#getParameterSpec()"/> 
        /// </summary>
        Java.Security.Spec.AlgorithmParameterSpec ParameterSpec { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CanonicalizationMethod
    public partial class CanonicalizationMethod : Javax.Xml.Crypto.Dsig.ICanonicalizationMethod
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#EXCLUSIVE"/>
        /// </summary>
        public static Java.Lang.String EXCLUSIVE { get { if (!_EXCLUSIVEReady) { _EXCLUSIVEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXCLUSIVE"); _EXCLUSIVEReady = true; } return _EXCLUSIVEContent; } }
        private static Java.Lang.String _EXCLUSIVEContent = default;
        private static bool _EXCLUSIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#EXCLUSIVE_WITH_COMMENTS"/>
        /// </summary>
        public static Java.Lang.String EXCLUSIVE_WITH_COMMENTS { get { if (!_EXCLUSIVE_WITH_COMMENTSReady) { _EXCLUSIVE_WITH_COMMENTSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXCLUSIVE_WITH_COMMENTS"); _EXCLUSIVE_WITH_COMMENTSReady = true; } return _EXCLUSIVE_WITH_COMMENTSContent; } }
        private static Java.Lang.String _EXCLUSIVE_WITH_COMMENTSContent = default;
        private static bool _EXCLUSIVE_WITH_COMMENTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#INCLUSIVE"/>
        /// </summary>
        public static Java.Lang.String INCLUSIVE { get { if (!_INCLUSIVEReady) { _INCLUSIVEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INCLUSIVE"); _INCLUSIVEReady = true; } return _INCLUSIVEContent; } }
        private static Java.Lang.String _INCLUSIVEContent = default;
        private static bool _INCLUSIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#INCLUSIVE_WITH_COMMENTS"/>
        /// </summary>
        public static Java.Lang.String INCLUSIVE_WITH_COMMENTS { get { if (!_INCLUSIVE_WITH_COMMENTSReady) { _INCLUSIVE_WITH_COMMENTSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INCLUSIVE_WITH_COMMENTS"); _INCLUSIVE_WITH_COMMENTSReady = true; } return _INCLUSIVE_WITH_COMMENTSContent; } }
        private static Java.Lang.String _INCLUSIVE_WITH_COMMENTSContent = default;
        private static bool _INCLUSIVE_WITH_COMMENTSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#getParameterSpec()"/> 
        /// </summary>
        public Java.Security.Spec.AlgorithmParameterSpec ParameterSpec
        {
            get { return IExecuteWithSignature<Java.Security.Spec.AlgorithmParameterSpec>("getParameterSpec", "()Ljava/security/spec/AlgorithmParameterSpec;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}