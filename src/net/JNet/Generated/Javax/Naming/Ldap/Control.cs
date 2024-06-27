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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Ldap
{
    #region IControl
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IControl : Java.Io.ISerializable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/Control.html#getEncodedValue()"/> 
        /// </summary>
        byte[] EncodedValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/Control.html#getID()"/> 
        /// </summary>
        Java.Lang.String ID { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/Control.html#isCritical()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsCritical();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Control
    public partial class Control : Javax.Naming.Ldap.IControl
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/Control.html#CRITICAL"/>
        /// </summary>
        public static bool CRITICAL { get { if (!_CRITICALReady) { _CRITICALContent = SGetField<bool>(LocalBridgeClazz, "CRITICAL"); _CRITICALReady = true; } return _CRITICALContent; } }
        private static bool _CRITICALContent = default;
        private static bool _CRITICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/Control.html#NONCRITICAL"/>
        /// </summary>
        public static bool NONCRITICAL { get { if (!_NONCRITICALReady) { _NONCRITICALContent = SGetField<bool>(LocalBridgeClazz, "NONCRITICAL"); _NONCRITICALReady = true; } return _NONCRITICALContent; } }
        private static bool _NONCRITICALContent = default;
        private static bool _NONCRITICALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/Control.html#getEncodedValue()"/> 
        /// </summary>
        public byte[] EncodedValue
        {
            get { return IExecuteWithSignatureArray<byte>("getEncodedValue", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/Control.html#getID()"/> 
        /// </summary>
        public Java.Lang.String ID
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getID", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/Control.html#isCritical()"/>
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