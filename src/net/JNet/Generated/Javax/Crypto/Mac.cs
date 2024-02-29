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

namespace Javax.Crypto
{
    #region Mac
    public partial class Mac
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Crypto.Mac"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Javax.Crypto.Mac GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Javax.Crypto.Mac>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Javax.Crypto.Mac"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Crypto.Mac GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecute<Javax.Crypto.Mac>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Crypto.Mac"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Crypto.Mac GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Crypto.Mac>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/Mac;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#getAlgorithm()"/> 
        /// </summary>
        public Java.Lang.String Algorithm
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#getMacLength()"/> 
        /// </summary>
        public int MacLength
        {
            get { return IExecuteWithSignature<int>("getMacLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#doFinal()"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public byte[] DoFinal()
        {
            return IExecuteWithSignatureArray<byte>("doFinal", "()[B");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#doFinal(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public byte[] DoFinal(byte[] arg0)
        {
            return IExecuteWithSignatureArray<byte>("doFinal", "([B)[B", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#doFinal(byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public void DoFinal(byte[] arg0, int arg1)
        {
            IExecute("doFinal", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#init(java.security.Key,java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(Java.Security.Key arg0, Java.Security.Spec.AlgorithmParameterSpec arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#init(java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void Init(Java.Security.Key arg0)
        {
            IExecuteWithSignature("init", "(Ljava/security/Key;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#update(byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public void Update(byte arg0)
        {
            IExecuteWithSignature("update", "(B)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#update(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public void Update(byte[] arg0, int arg1, int arg2)
        {
            IExecute("update", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#update(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public void Update(byte[] arg0)
        {
            IExecuteWithSignature("update", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Mac.html#update(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public void Update(Java.Nio.ByteBuffer arg0)
        {
            IExecuteWithSignature("update", "(Ljava/nio/ByteBuffer;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}