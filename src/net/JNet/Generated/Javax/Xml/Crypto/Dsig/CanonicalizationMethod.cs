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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Crypto.Dsig
{
    #region ICanonicalizationMethod
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
        public static string EXCLUSIVE { get { return SGetField<string>(LocalBridgeClazz, "EXCLUSIVE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#EXCLUSIVE_WITH_COMMENTS"/>
        /// </summary>
        public static string EXCLUSIVE_WITH_COMMENTS { get { return SGetField<string>(LocalBridgeClazz, "EXCLUSIVE_WITH_COMMENTS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#INCLUSIVE"/>
        /// </summary>
        public static string INCLUSIVE { get { return SGetField<string>(LocalBridgeClazz, "INCLUSIVE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#INCLUSIVE_WITH_COMMENTS"/>
        /// </summary>
        public static string INCLUSIVE_WITH_COMMENTS { get { return SGetField<string>(LocalBridgeClazz, "INCLUSIVE_WITH_COMMENTS"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#getParameterSpec()"/> 
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