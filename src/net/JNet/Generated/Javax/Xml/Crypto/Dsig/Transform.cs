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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Crypto.Dsig
{
    #region Transform
    public partial class Transform
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.Transform"/> to <see cref="Javax.Xml.Crypto.XMLStructure"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.XMLStructure(Javax.Xml.Crypto.Dsig.Transform t) => t.Cast<Javax.Xml.Crypto.XMLStructure>();
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.Transform"/> to <see cref="Javax.Xml.Crypto.AlgorithmMethod"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.AlgorithmMethod(Javax.Xml.Crypto.Dsig.Transform t) => t.Cast<Javax.Xml.Crypto.AlgorithmMethod>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Transform.html#BASE64"/>
        /// </summary>
        public static string BASE64 => Clazz.GetField<string>("BASE64");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Transform.html#ENVELOPED"/>
        /// </summary>
        public static string ENVELOPED => Clazz.GetField<string>("ENVELOPED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Transform.html#XPATH"/>
        /// </summary>
        public static string XPATH => Clazz.GetField<string>("XPATH");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Transform.html#XPATH2"/>
        /// </summary>
        public static string XPATH2 => Clazz.GetField<string>("XPATH2");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Transform.html#XSLT"/>
        /// </summary>
        public static string XSLT => Clazz.GetField<string>("XSLT");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Transform.html#getParameterSpec()"/> 
        /// </summary>
        public Java.Security.Spec.AlgorithmParameterSpec ParameterSpec
        {
            get { return IExecute<Java.Security.Spec.AlgorithmParameterSpec>("getParameterSpec"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Transform.html#transform(javax.xml.crypto.Data,javax.xml.crypto.XMLCryptoContext,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Data"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.XMLCryptoContext"/></param>
        /// <param name="arg2"><see cref="Java.Io.OutputStream"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Data"/></returns>
        /// <exception cref="Javax.Xml.Crypto.Dsig.TransformException"/>
        public Javax.Xml.Crypto.Data TransformMethod(Javax.Xml.Crypto.Data arg0, Javax.Xml.Crypto.XMLCryptoContext arg1, Java.Io.OutputStream arg2)
        {
            return IExecute<Javax.Xml.Crypto.Data>("transform", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/Transform.html#transform(javax.xml.crypto.Data,javax.xml.crypto.XMLCryptoContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Data"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.XMLCryptoContext"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Data"/></returns>
        /// <exception cref="Javax.Xml.Crypto.Dsig.TransformException"/>
        public Javax.Xml.Crypto.Data TransformMethod(Javax.Xml.Crypto.Data arg0, Javax.Xml.Crypto.XMLCryptoContext arg1)
        {
            return IExecute<Javax.Xml.Crypto.Data>("transform", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}