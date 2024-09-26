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
    #region GSSManager declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html"/>
    /// </summary>
    public partial class GSSManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<GSSManager>
    {
        const string _bridgeClassName = "org.ietf.jgss.GSSManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("GSSManager class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public GSSManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("GSSManager class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public GSSManager(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region GSSManager implementation
    public partial class GSSManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#getInstance()"/> 
        /// </summary>
        public static Org.Ietf.Jgss.GSSManager Instance
        {
            get { return SExecuteWithSignature<Org.Ietf.Jgss.GSSManager>(LocalBridgeClazz, "getInstance", "()Lorg/ietf/jgss/GSSManager;"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#getMechs()"/> 
        /// </summary>
        public Org.Ietf.Jgss.Oid[] Mechs
        {
            get { return IExecuteWithSignatureArray<Org.Ietf.Jgss.Oid>("getMechs", "()[Lorg/ietf/jgss/Oid;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#createContext(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.GSSContext"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public Org.Ietf.Jgss.GSSContext CreateContext(byte[] arg0)
        {
            return IExecuteWithSignature<Org.Ietf.Jgss.GSSContext>("createContext", "([B)Lorg/ietf/jgss/GSSContext;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#createContext(org.ietf.jgss.GSSCredential)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.GSSCredential"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.GSSContext"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public Org.Ietf.Jgss.GSSContext CreateContext(Org.Ietf.Jgss.GSSCredential arg0)
        {
            return IExecuteWithSignature<Org.Ietf.Jgss.GSSContext>("createContext", "(Lorg/ietf/jgss/GSSCredential;)Lorg/ietf/jgss/GSSContext;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#createContext(org.ietf.jgss.GSSName,org.ietf.jgss.Oid,org.ietf.jgss.GSSCredential,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.GSSName"/></param>
        /// <param name="arg1"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <param name="arg2"><see cref="Org.Ietf.Jgss.GSSCredential"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.GSSContext"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public Org.Ietf.Jgss.GSSContext CreateContext(Org.Ietf.Jgss.GSSName arg0, Org.Ietf.Jgss.Oid arg1, Org.Ietf.Jgss.GSSCredential arg2, int arg3)
        {
            return IExecuteWithSignature<Org.Ietf.Jgss.GSSContext>("createContext", "(Lorg/ietf/jgss/GSSName;Lorg/ietf/jgss/Oid;Lorg/ietf/jgss/GSSCredential;I)Lorg/ietf/jgss/GSSContext;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#createCredential(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.GSSCredential"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public Org.Ietf.Jgss.GSSCredential CreateCredential(int arg0)
        {
            return IExecuteWithSignature<Org.Ietf.Jgss.GSSCredential>("createCredential", "(I)Lorg/ietf/jgss/GSSCredential;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#createCredential(org.ietf.jgss.GSSName,int,org.ietf.jgss.Oid,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.GSSName"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.GSSCredential"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public Org.Ietf.Jgss.GSSCredential CreateCredential(Org.Ietf.Jgss.GSSName arg0, int arg1, Org.Ietf.Jgss.Oid arg2, int arg3)
        {
            return IExecuteWithSignature<Org.Ietf.Jgss.GSSCredential>("createCredential", "(Lorg/ietf/jgss/GSSName;ILorg/ietf/jgss/Oid;I)Lorg/ietf/jgss/GSSCredential;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#createCredential(org.ietf.jgss.GSSName,int,org.ietf.jgss.Oid[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.GSSName"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.GSSCredential"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public Org.Ietf.Jgss.GSSCredential CreateCredential(Org.Ietf.Jgss.GSSName arg0, int arg1, Org.Ietf.Jgss.Oid[] arg2, int arg3)
        {
            return IExecuteWithSignature<Org.Ietf.Jgss.GSSCredential>("createCredential", "(Lorg/ietf/jgss/GSSName;I[Lorg/ietf/jgss/Oid;I)Lorg/ietf/jgss/GSSCredential;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#createName(byte[],org.ietf.jgss.Oid,org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <param name="arg2"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.GSSName"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public Org.Ietf.Jgss.GSSName CreateName(byte[] arg0, Org.Ietf.Jgss.Oid arg1, Org.Ietf.Jgss.Oid arg2)
        {
            return IExecuteWithSignature<Org.Ietf.Jgss.GSSName>("createName", "([BLorg/ietf/jgss/Oid;Lorg/ietf/jgss/Oid;)Lorg/ietf/jgss/GSSName;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#createName(byte[],org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.GSSName"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public Org.Ietf.Jgss.GSSName CreateName(byte[] arg0, Org.Ietf.Jgss.Oid arg1)
        {
            return IExecuteWithSignature<Org.Ietf.Jgss.GSSName>("createName", "([BLorg/ietf/jgss/Oid;)Lorg/ietf/jgss/GSSName;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#createName(java.lang.String,org.ietf.jgss.Oid,org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <param name="arg2"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.GSSName"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public Org.Ietf.Jgss.GSSName CreateName(Java.Lang.String arg0, Org.Ietf.Jgss.Oid arg1, Org.Ietf.Jgss.Oid arg2)
        {
            return IExecuteWithSignature<Org.Ietf.Jgss.GSSName>("createName", "(Ljava/lang/String;Lorg/ietf/jgss/Oid;Lorg/ietf/jgss/Oid;)Lorg/ietf/jgss/GSSName;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#createName(java.lang.String,org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.GSSName"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public Org.Ietf.Jgss.GSSName CreateName(Java.Lang.String arg0, Org.Ietf.Jgss.Oid arg1)
        {
            return IExecuteWithSignature<Org.Ietf.Jgss.GSSName>("createName", "(Ljava/lang/String;Lorg/ietf/jgss/Oid;)Lorg/ietf/jgss/GSSName;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#getMechsForName(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.Oid"/></returns>
        public Org.Ietf.Jgss.Oid[] GetMechsForName(Org.Ietf.Jgss.Oid arg0)
        {
            return IExecuteWithSignatureArray<Org.Ietf.Jgss.Oid>("getMechsForName", "(Lorg/ietf/jgss/Oid;)[Lorg/ietf/jgss/Oid;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#getNamesForMech(org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <returns><see cref="Org.Ietf.Jgss.Oid"/></returns>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public Org.Ietf.Jgss.Oid[] GetNamesForMech(Org.Ietf.Jgss.Oid arg0)
        {
            return IExecuteWithSignatureArray<Org.Ietf.Jgss.Oid>("getNamesForMech", "(Lorg/ietf/jgss/Oid;)[Lorg/ietf/jgss/Oid;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#addProviderAtEnd(java.security.Provider,org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Provider"/></param>
        /// <param name="arg1"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void AddProviderAtEnd(Java.Security.Provider arg0, Org.Ietf.Jgss.Oid arg1)
        {
            IExecuteWithSignature("addProviderAtEnd", "(Ljava/security/Provider;Lorg/ietf/jgss/Oid;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#addProviderAtFront(java.security.Provider,org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Provider"/></param>
        /// <param name="arg1"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void AddProviderAtFront(Java.Security.Provider arg0, Org.Ietf.Jgss.Oid arg1)
        {
            IExecuteWithSignature("addProviderAtFront", "(Ljava/security/Provider;Lorg/ietf/jgss/Oid;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}