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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security
{
    #region SecureRandom
    public partial class SecureRandom
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#%3Cinit%3E(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public SecureRandom(byte[] arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#getInstanceStrong()"/> 
        /// </summary>
        public static Java.Security.SecureRandom InstanceStrong
        {
            get { return SExecuteWithSignature<Java.Security.SecureRandom>(LocalBridgeClazz, "getInstanceStrong", "()Ljava/security/SecureRandom;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#getSeed(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public static byte[] GetSeed(int arg0)
        {
            return SExecuteWithSignatureArray<byte>(LocalBridgeClazz, "getSeed", "(I)[B", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.SecureRandom"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Java.Security.SecureRandom GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Security.SecureRandom>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Java.Security.SecureRandom"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.SecureRandom GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecute<Java.Security.SecureRandom>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#getInstance(java.lang.String,java.security.SecureRandomParameters,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.SecureRandomParameters"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.SecureRandom"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Java.Security.SecureRandom GetInstance(Java.Lang.String arg0, Java.Security.SecureRandomParameters arg1, Java.Lang.String arg2)
        {
            return SExecute<Java.Security.SecureRandom>(LocalBridgeClazz, "getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#getInstance(java.lang.String,java.security.SecureRandomParameters,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.SecureRandomParameters"/></param>
        /// <param name="arg2"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Java.Security.SecureRandom"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.SecureRandom GetInstance(Java.Lang.String arg0, Java.Security.SecureRandomParameters arg1, Java.Security.Provider arg2)
        {
            return SExecute<Java.Security.SecureRandom>(LocalBridgeClazz, "getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#getInstance(java.lang.String,java.security.SecureRandomParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.SecureRandomParameters"/></param>
        /// <returns><see cref="Java.Security.SecureRandom"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.SecureRandom GetInstance(Java.Lang.String arg0, Java.Security.SecureRandomParameters arg1)
        {
            return SExecute<Java.Security.SecureRandom>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.SecureRandom"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.SecureRandom GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Security.SecureRandom>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljava/security/SecureRandom;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#getAlgorithm()"/> 
        /// </summary>
        public Java.Lang.String Algorithm
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#getParameters()"/> 
        /// </summary>
        public Java.Security.SecureRandomParameters Parameters
        {
            get { return IExecuteWithSignature<Java.Security.SecureRandomParameters>("getParameters", "()Ljava/security/SecureRandomParameters;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#generateSeed(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GenerateSeed(int arg0)
        {
            return IExecuteWithSignatureArray<byte>("generateSeed", "(I)[B", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#nextBytes(byte[],java.security.SecureRandomParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Java.Security.SecureRandomParameters"/></param>
        public void NextBytes(byte[] arg0, Java.Security.SecureRandomParameters arg1)
        {
            IExecute("nextBytes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#reseed()"/>
        /// </summary>
        public void Reseed()
        {
            IExecuteWithSignature("reseed", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#reseed(java.security.SecureRandomParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.SecureRandomParameters"/></param>
        public void Reseed(Java.Security.SecureRandomParameters arg0)
        {
            IExecuteWithSignature("reseed", "(Ljava/security/SecureRandomParameters;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/SecureRandom.html#setSeed(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void SetSeed(byte[] arg0)
        {
            IExecuteWithSignature("setSeed", "([B)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}