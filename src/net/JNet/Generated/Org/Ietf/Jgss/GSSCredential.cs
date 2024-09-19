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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Ietf.Jgss
{
    #region GSSCredential declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html"/>
    /// </summary>
    public partial class GSSCredential : Java.Lang.Cloneable
    {
        const string _bridgeClassName = "org.ietf.jgss.GSSCredential";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("GSSCredential class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public GSSCredential() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("GSSCredential class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public GSSCredential(params object[] args) : base(args) { }

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

    #region IGSSCredential
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IGSSCredential : Java.Lang.ICloneable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getMechs()"/> 
        /// </summary>
        Org.Ietf.Jgss.Oid[] Mechs { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getName()"/> 
        /// </summary>
        Org.Ietf.Jgss.GSSName Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getRemainingLifetime()"/> 
        /// </summary>
        int RemainingLifetime { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getUsage()"/> 
        /// </summary>
        int Usage { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getRemainingAcceptLifetime(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        int GetRemainingAcceptLifetime(Org.Ietf.Jgss.Oid arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getRemainingInitLifetime(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        int GetRemainingInitLifetime(Org.Ietf.Jgss.Oid arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getUsage(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        int GetUsage(Org.Ietf.Jgss.Oid arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getName(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.GSSName"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        Org.Ietf.Jgss.GSSName GetName(Org.Ietf.Jgss.Oid arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#add(org.ietf.jgss.GSSName,int,int,org.ietf.jgss.Oid,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.GSSName"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        void Add(Org.Ietf.Jgss.GSSName arg0, int arg1, int arg2, Org.Ietf.Jgss.Oid arg3, int arg4);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#dispose()"/>
        /// </summary>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        void Dispose();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region GSSCredential implementation
    public partial class GSSCredential : Org.Ietf.Jgss.IGSSCredential
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#ACCEPT_ONLY"/>
        /// </summary>
        public static int ACCEPT_ONLY { get { if (!_ACCEPT_ONLYReady) { _ACCEPT_ONLYContent = SGetField<int>(LocalBridgeClazz, "ACCEPT_ONLY"); _ACCEPT_ONLYReady = true; } return _ACCEPT_ONLYContent; } }
        private static int _ACCEPT_ONLYContent = default;
        private static bool _ACCEPT_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#DEFAULT_LIFETIME"/>
        /// </summary>
        public static int DEFAULT_LIFETIME { get { if (!_DEFAULT_LIFETIMEReady) { _DEFAULT_LIFETIMEContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_LIFETIME"); _DEFAULT_LIFETIMEReady = true; } return _DEFAULT_LIFETIMEContent; } }
        private static int _DEFAULT_LIFETIMEContent = default;
        private static bool _DEFAULT_LIFETIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#INDEFINITE_LIFETIME"/>
        /// </summary>
        public static int INDEFINITE_LIFETIME { get { if (!_INDEFINITE_LIFETIMEReady) { _INDEFINITE_LIFETIMEContent = SGetField<int>(LocalBridgeClazz, "INDEFINITE_LIFETIME"); _INDEFINITE_LIFETIMEReady = true; } return _INDEFINITE_LIFETIMEContent; } }
        private static int _INDEFINITE_LIFETIMEContent = default;
        private static bool _INDEFINITE_LIFETIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#INITIATE_AND_ACCEPT"/>
        /// </summary>
        public static int INITIATE_AND_ACCEPT { get { if (!_INITIATE_AND_ACCEPTReady) { _INITIATE_AND_ACCEPTContent = SGetField<int>(LocalBridgeClazz, "INITIATE_AND_ACCEPT"); _INITIATE_AND_ACCEPTReady = true; } return _INITIATE_AND_ACCEPTContent; } }
        private static int _INITIATE_AND_ACCEPTContent = default;
        private static bool _INITIATE_AND_ACCEPTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#INITIATE_ONLY"/>
        /// </summary>
        public static int INITIATE_ONLY { get { if (!_INITIATE_ONLYReady) { _INITIATE_ONLYContent = SGetField<int>(LocalBridgeClazz, "INITIATE_ONLY"); _INITIATE_ONLYReady = true; } return _INITIATE_ONLYContent; } }
        private static int _INITIATE_ONLYContent = default;
        private static bool _INITIATE_ONLYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getMechs()"/> 
        /// </summary>
        public Org.Ietf.Jgss.Oid[] Mechs
        {
            get { return IExecuteWithSignatureArray<Org.Ietf.Jgss.Oid>("getMechs", "()[Lorg/ietf/jgss/Oid;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getName()"/> 
        /// </summary>
        public Org.Ietf.Jgss.GSSName Name
        {
            get { return IExecuteWithSignature<Org.Ietf.Jgss.GSSName>("getName", "()Lorg/ietf/jgss/GSSName;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getRemainingLifetime()"/> 
        /// </summary>
        public int RemainingLifetime
        {
            get { return IExecuteWithSignature<int>("getRemainingLifetime", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getUsage()"/> 
        /// </summary>
        public int Usage
        {
            get { return IExecuteWithSignature<int>("getUsage", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getRemainingAcceptLifetime(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public int GetRemainingAcceptLifetime(Org.Ietf.Jgss.Oid arg0)
        {
            return IExecuteWithSignature<int>("getRemainingAcceptLifetime", "(Lorg/ietf/jgss/Oid;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getRemainingInitLifetime(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public int GetRemainingInitLifetime(Org.Ietf.Jgss.Oid arg0)
        {
            return IExecuteWithSignature<int>("getRemainingInitLifetime", "(Lorg/ietf/jgss/Oid;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getUsage(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public int GetUsage(Org.Ietf.Jgss.Oid arg0)
        {
            return IExecuteWithSignature<int>("getUsage", "(Lorg/ietf/jgss/Oid;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#getName(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.GSSName"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public Org.Ietf.Jgss.GSSName GetName(Org.Ietf.Jgss.Oid arg0)
        {
            return IExecuteWithSignature<Org.Ietf.Jgss.GSSName>("getName", "(Lorg/ietf/jgss/Oid;)Lorg/ietf/jgss/GSSName;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#add(org.ietf.jgss.GSSName,int,int,org.ietf.jgss.Oid,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.GSSName"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void Add(Org.Ietf.Jgss.GSSName arg0, int arg1, int arg2, Org.Ietf.Jgss.Oid arg3, int arg4)
        {
            IExecute("add", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSCredential.html#dispose()"/>
        /// </summary>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public new void Dispose()
        {
            IExecuteWithSignature("dispose", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}