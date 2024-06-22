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

namespace Java.Security.Interfaces
{
    #region IDSAParams
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDSAParams
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAParams.html#getG()"/> 
        /// </summary>
        Java.Math.BigInteger G { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAParams.html#getP()"/> 
        /// </summary>
        Java.Math.BigInteger P { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAParams.html#getQ()"/> 
        /// </summary>
        Java.Math.BigInteger Q { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DSAParams
    public partial class DSAParams : Java.Security.Interfaces.IDSAParams
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAParams.html#getG()"/> 
        /// </summary>
        public Java.Math.BigInteger G
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getG", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAParams.html#getP()"/> 
        /// </summary>
        public Java.Math.BigInteger P
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getP", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAParams.html#getQ()"/> 
        /// </summary>
        public Java.Math.BigInteger Q
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getQ", "()Ljava/math/BigInteger;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}