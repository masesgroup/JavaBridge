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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Spec
{
    #region MGF1ParameterSpec
    public partial class MGF1ParameterSpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public MGF1ParameterSpec(string arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Spec.MGF1ParameterSpec"/> to <see cref="Java.Security.Spec.AlgorithmParameterSpec"/>
        /// </summary>
        public static implicit operator Java.Security.Spec.AlgorithmParameterSpec(Java.Security.Spec.MGF1ParameterSpec t) => t.Cast<Java.Security.Spec.AlgorithmParameterSpec>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#SHA1"/>
        /// </summary>
        public static Java.Security.Spec.MGF1ParameterSpec SHA1 => Clazz.GetField<Java.Security.Spec.MGF1ParameterSpec>("SHA1");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#SHA224"/>
        /// </summary>
        public static Java.Security.Spec.MGF1ParameterSpec SHA224 => Clazz.GetField<Java.Security.Spec.MGF1ParameterSpec>("SHA224");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#SHA256"/>
        /// </summary>
        public static Java.Security.Spec.MGF1ParameterSpec SHA256 => Clazz.GetField<Java.Security.Spec.MGF1ParameterSpec>("SHA256");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#SHA384"/>
        /// </summary>
        public static Java.Security.Spec.MGF1ParameterSpec SHA384 => Clazz.GetField<Java.Security.Spec.MGF1ParameterSpec>("SHA384");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#SHA512"/>
        /// </summary>
        public static Java.Security.Spec.MGF1ParameterSpec SHA512 => Clazz.GetField<Java.Security.Spec.MGF1ParameterSpec>("SHA512");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#SHA512_224"/>
        /// </summary>
        public static Java.Security.Spec.MGF1ParameterSpec SHA512_224 => Clazz.GetField<Java.Security.Spec.MGF1ParameterSpec>("SHA512_224");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#SHA512_256"/>
        /// </summary>
        public static Java.Security.Spec.MGF1ParameterSpec SHA512_256 => Clazz.GetField<Java.Security.Spec.MGF1ParameterSpec>("SHA512_256");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#getDigestAlgorithm()"/> 
        /// </summary>
        public string DigestAlgorithm
        {
            get { return IExecute<string>("getDigestAlgorithm"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}