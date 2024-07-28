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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Cert
{
    #region IPolicyNode
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPolicyNode
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getChildren()"/> 
        /// </summary>
        Java.Util.Iterator Children { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getDepth()"/> 
        /// </summary>
        int Depth { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getExpectedPolicies()"/> 
        /// </summary>
        Java.Util.Set<Java.Lang.String> ExpectedPolicies { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getParent()"/> 
        /// </summary>
        Java.Security.Cert.PolicyNode Parent { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getPolicyQualifiers()"/> 
        /// </summary>
        Java.Util.Set PolicyQualifiers { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getValidPolicy()"/> 
        /// </summary>
        Java.Lang.String ValidPolicy { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#isCritical()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsCritical();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PolicyNode
    public partial class PolicyNode : Java.Security.Cert.IPolicyNode
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getChildren()"/> 
        /// </summary>
        public Java.Util.Iterator Children
        {
            get { return IExecuteWithSignature<Java.Util.Iterator>("getChildren", "()Ljava/util/Iterator;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getDepth()"/> 
        /// </summary>
        public int Depth
        {
            get { return IExecuteWithSignature<int>("getDepth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getExpectedPolicies()"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.String> ExpectedPolicies
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getExpectedPolicies", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getParent()"/> 
        /// </summary>
        public Java.Security.Cert.PolicyNode Parent
        {
            get { return IExecuteWithSignature<Java.Security.Cert.PolicyNode>("getParent", "()Ljava/security/cert/PolicyNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getPolicyQualifiers()"/> 
        /// </summary>
        public Java.Util.Set PolicyQualifiers
        {
            get { return IExecuteWithSignature<Java.Util.Set>("getPolicyQualifiers", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getValidPolicy()"/> 
        /// </summary>
        public Java.Lang.String ValidPolicy
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getValidPolicy", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#isCritical()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCritical()
        {
            return IExecuteWithSignature<bool>("isCritical", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}