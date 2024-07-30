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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Ietf.Jgss
{
    #region GSSManager
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
            return IExecute<Org.Ietf.Jgss.GSSContext>("createContext", arg0, arg1, arg2, arg3);
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
            return IExecute<Org.Ietf.Jgss.GSSCredential>("createCredential", arg0, arg1, arg2, arg3);
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
            return IExecute<Org.Ietf.Jgss.GSSCredential>("createCredential", arg0, arg1, arg2, arg3);
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
            return IExecute<Org.Ietf.Jgss.GSSName>("createName", arg0, arg1, arg2);
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
            return IExecute<Org.Ietf.Jgss.GSSName>("createName", arg0, arg1);
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
            return IExecute<Org.Ietf.Jgss.GSSName>("createName", arg0, arg1, arg2);
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
            return IExecute<Org.Ietf.Jgss.GSSName>("createName", arg0, arg1);
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
            IExecute("addProviderAtEnd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/GSSManager.html#addProviderAtFront(java.security.Provider,org.ietf.jgss.Oid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Provider"/></param>
        /// <param name="arg1"><see cref="Org.Ietf.Jgss.Oid"/></param>
        /// <exception cref="Org.Ietf.Jgss.GSSException"/>
        public void AddProviderAtFront(Java.Security.Provider arg0, Org.Ietf.Jgss.Oid arg1)
        {
            IExecute("addProviderAtFront", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}