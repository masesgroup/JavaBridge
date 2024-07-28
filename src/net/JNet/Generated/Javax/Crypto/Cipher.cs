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

namespace Javax.Crypto
{
    #region Cipher
    public partial class Cipher
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#DECRYPT_MODE"/>
        /// </summary>
        public static int DECRYPT_MODE { get { if (!_DECRYPT_MODEReady) { _DECRYPT_MODEContent = SGetField<int>(LocalBridgeClazz, "DECRYPT_MODE"); _DECRYPT_MODEReady = true; } return _DECRYPT_MODEContent; } }
        private static int _DECRYPT_MODEContent = default;
        private static bool _DECRYPT_MODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#ENCRYPT_MODE"/>
        /// </summary>
        public static int ENCRYPT_MODE { get { if (!_ENCRYPT_MODEReady) { _ENCRYPT_MODEContent = SGetField<int>(LocalBridgeClazz, "ENCRYPT_MODE"); _ENCRYPT_MODEReady = true; } return _ENCRYPT_MODEContent; } }
        private static int _ENCRYPT_MODEContent = default;
        private static bool _ENCRYPT_MODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#PRIVATE_KEY"/>
        /// </summary>
        public static int PRIVATE_KEY { get { if (!_PRIVATE_KEYReady) { _PRIVATE_KEYContent = SGetField<int>(LocalBridgeClazz, "PRIVATE_KEY"); _PRIVATE_KEYReady = true; } return _PRIVATE_KEYContent; } }
        private static int _PRIVATE_KEYContent = default;
        private static bool _PRIVATE_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#PUBLIC_KEY"/>
        /// </summary>
        public static int PUBLIC_KEY { get { if (!_PUBLIC_KEYReady) { _PUBLIC_KEYContent = SGetField<int>(LocalBridgeClazz, "PUBLIC_KEY"); _PUBLIC_KEYReady = true; } return _PUBLIC_KEYContent; } }
        private static int _PUBLIC_KEYContent = default;
        private static bool _PUBLIC_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#SECRET_KEY"/>
        /// </summary>
        public static int SECRET_KEY { get { if (!_SECRET_KEYReady) { _SECRET_KEYContent = SGetField<int>(LocalBridgeClazz, "SECRET_KEY"); _SECRET_KEYReady = true; } return _SECRET_KEYContent; } }
        private static int _SECRET_KEYContent = default;
        private static bool _SECRET_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#UNWRAP_MODE"/>
        /// </summary>
        public static int UNWRAP_MODE { get { if (!_UNWRAP_MODEReady) { _UNWRAP_MODEContent = SGetField<int>(LocalBridgeClazz, "UNWRAP_MODE"); _UNWRAP_MODEReady = true; } return _UNWRAP_MODEContent; } }
        private static int _UNWRAP_MODEContent = default;
        private static bool _UNWRAP_MODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#WRAP_MODE"/>
        /// </summary>
        public static int WRAP_MODE { get { if (!_WRAP_MODEReady) { _WRAP_MODEContent = SGetField<int>(LocalBridgeClazz, "WRAP_MODE"); _WRAP_MODEReady = true; } return _WRAP_MODEContent; } }
        private static int _WRAP_MODEContent = default;
        private static bool _WRAP_MODEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getMaxAllowedKeyLength(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static int GetMaxAllowedKeyLength(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaxAllowedKeyLength", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getMaxAllowedParameterSpec(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.Spec.AlgorithmParameterSpec GetMaxAllowedParameterSpec(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Security.Spec.AlgorithmParameterSpec>(LocalBridgeClazz, "getMaxAllowedParameterSpec", "(Ljava/lang/String;)Ljava/security/spec/AlgorithmParameterSpec;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Crypto.Cipher"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        /// <exception cref="Javax.Crypto.NoSuchPaddingException"/>
        public static Javax.Crypto.Cipher GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Javax.Crypto.Cipher>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Javax.Crypto.Cipher"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Javax.Crypto.NoSuchPaddingException"/>
        public static Javax.Crypto.Cipher GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecute<Javax.Crypto.Cipher>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Crypto.Cipher"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Javax.Crypto.NoSuchPaddingException"/>
        public static Javax.Crypto.Cipher GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Crypto.Cipher>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/Cipher;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getAlgorithm()"/> 
        /// </summary>
        public Java.Lang.String Algorithm
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getBlockSize()"/> 
        /// </summary>
        public int BlockSize
        {
            get { return IExecuteWithSignature<int>("getBlockSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getExemptionMechanism()"/> 
        /// </summary>
        public Javax.Crypto.ExemptionMechanism ExemptionMechanism
        {
            get { return IExecuteWithSignature<Javax.Crypto.ExemptionMechanism>("getExemptionMechanism", "()Ljavax/crypto/ExemptionMechanism;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getIV()"/> 
        /// </summary>
        public byte[] IV
        {
            get { return IExecuteWithSignatureArray<byte>("getIV", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getParameters()"/> 
        /// </summary>
        public Java.Security.AlgorithmParameters Parameters
        {
            get { return IExecuteWithSignature<Java.Security.AlgorithmParameters>("getParameters", "()Ljava/security/AlgorithmParameters;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#doFinal()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public byte[] DoFinal()
        {
            return IExecuteWithSignatureArray<byte>("doFinal", "()[B");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#doFinal(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public byte[] DoFinal(byte[] arg0, int arg1, int arg2)
        {
            return IExecuteArray<byte>("doFinal", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#doFinal(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public byte[] DoFinal(byte[] arg0)
        {
            return IExecuteWithSignatureArray<byte>("doFinal", "([B)[B", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#update(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Update(byte[] arg0, int arg1, int arg2)
        {
            return IExecuteArray<byte>("update", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#update(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Update(byte[] arg0)
        {
            return IExecuteWithSignatureArray<byte>("update", "([B)[B", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#wrap(java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public byte[] Wrap(Java.Security.Key arg0)
        {
            return IExecuteWithSignatureArray<byte>("wrap", "(Ljava/security/Key;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#doFinal(byte[],int,int,byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public int DoFinal(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4)
        {
            return IExecute<int>("doFinal", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#doFinal(byte[],int,int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public int DoFinal(byte[] arg0, int arg1, int arg2, byte[] arg3)
        {
            return IExecute<int>("doFinal", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#doFinal(byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public int DoFinal(byte[] arg0, int arg1)
        {
            return IExecute<int>("doFinal", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#doFinal(java.nio.ByteBuffer,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public int DoFinal(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<int>("doFinal", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getOutputSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetOutputSize(int arg0)
        {
            return IExecuteWithSignature<int>("getOutputSize", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#update(byte[],int,int,byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        public int Update(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4)
        {
            return IExecute<int>("update", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#update(byte[],int,int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        public int Update(byte[] arg0, int arg1, int arg2, byte[] arg3)
        {
            return IExecute<int>("update", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#update(java.nio.ByteBuffer,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        public int Update(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<int>("update", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#unwrap(byte[],java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Security.Key"/></returns>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public Java.Security.Key Unwrap(byte[] arg0, Java.Lang.String arg1, int arg2)
        {
            return IExecute<Java.Security.Key>("unwrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.cert.Certificate,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <param name="arg2"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void Init(int arg0, Java.Security.Cert.Certificate arg1, Java.Security.SecureRandom arg2)
        {
            IExecute("init", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.cert.Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void Init(int arg0, Java.Security.Cert.Certificate arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.Key,java.security.AlgorithmParameters,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <param name="arg2"><see cref="Java.Security.AlgorithmParameters"/></param>
        /// <param name="arg3"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(int arg0, Java.Security.Key arg1, Java.Security.AlgorithmParameters arg2, Java.Security.SecureRandom arg3)
        {
            IExecute("init", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.Key,java.security.AlgorithmParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <param name="arg2"><see cref="Java.Security.AlgorithmParameters"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(int arg0, Java.Security.Key arg1, Java.Security.AlgorithmParameters arg2)
        {
            IExecute("init", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.Key,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <param name="arg2"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void Init(int arg0, Java.Security.Key arg1, Java.Security.SecureRandom arg2)
        {
            IExecute("init", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.Key,java.security.spec.AlgorithmParameterSpec,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <param name="arg2"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <param name="arg3"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(int arg0, Java.Security.Key arg1, Java.Security.Spec.AlgorithmParameterSpec arg2, Java.Security.SecureRandom arg3)
        {
            IExecute("init", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.Key,java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <param name="arg2"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(int arg0, Java.Security.Key arg1, Java.Security.Spec.AlgorithmParameterSpec arg2)
        {
            IExecute("init", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void Init(int arg0, Java.Security.Key arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#updateAAD(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void UpdateAAD(byte[] arg0, int arg1, int arg2)
        {
            IExecute("updateAAD", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#updateAAD(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void UpdateAAD(byte[] arg0)
        {
            IExecuteWithSignature("updateAAD", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#updateAAD(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public void UpdateAAD(Java.Nio.ByteBuffer arg0)
        {
            IExecuteWithSignature("updateAAD", "(Ljava/nio/ByteBuffer;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}