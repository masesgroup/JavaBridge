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
    #region IX509Extension
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IX509Extension
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Extension.html#getCriticalExtensionOIDs()"/> 
        /// </summary>
        Java.Util.Set<Java.Lang.String> CriticalExtensionOIDs { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Extension.html#getNonCriticalExtensionOIDs()"/> 
        /// </summary>
        Java.Util.Set<Java.Lang.String> NonCriticalExtensionOIDs { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Extension.html#hasUnsupportedCriticalExtension()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool HasUnsupportedCriticalExtension();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Extension.html#getExtensionValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        byte[] GetExtensionValue(Java.Lang.String arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region X509Extension
    public partial class X509Extension : Java.Security.Cert.IX509Extension
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Extension.html#getCriticalExtensionOIDs()"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.String> CriticalExtensionOIDs
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getCriticalExtensionOIDs", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Extension.html#getNonCriticalExtensionOIDs()"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.String> NonCriticalExtensionOIDs
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getNonCriticalExtensionOIDs", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Extension.html#hasUnsupportedCriticalExtension()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasUnsupportedCriticalExtension()
        {
            return IExecuteWithSignature<bool>("hasUnsupportedCriticalExtension", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Extension.html#getExtensionValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetExtensionValue(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<byte>("getExtensionValue", "(Ljava/lang/String;)[B", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}