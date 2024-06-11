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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.Charset
{
    #region CoderResult
    public partial class CoderResult
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CoderResult.html#OVERFLOW"/>
        /// </summary>
        public static Java.Nio.Charset.CoderResult OVERFLOW { get { if (!_OVERFLOWReady) { _OVERFLOWContent = SGetField<Java.Nio.Charset.CoderResult>(LocalBridgeClazz, "OVERFLOW"); _OVERFLOWReady = true; } return _OVERFLOWContent; } }
        private static Java.Nio.Charset.CoderResult _OVERFLOWContent = default;
        private static bool _OVERFLOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CoderResult.html#UNDERFLOW"/>
        /// </summary>
        public static Java.Nio.Charset.CoderResult UNDERFLOW { get { if (!_UNDERFLOWReady) { _UNDERFLOWContent = SGetField<Java.Nio.Charset.CoderResult>(LocalBridgeClazz, "UNDERFLOW"); _UNDERFLOWReady = true; } return _UNDERFLOWContent; } }
        private static Java.Nio.Charset.CoderResult _UNDERFLOWContent = default;
        private static bool _UNDERFLOWReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CoderResult.html#malformedForLength(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Charset.CoderResult"/></returns>
        public static Java.Nio.Charset.CoderResult MalformedForLength(int arg0)
        {
            return SExecuteWithSignature<Java.Nio.Charset.CoderResult>(LocalBridgeClazz, "malformedForLength", "(I)Ljava/nio/charset/CoderResult;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CoderResult.html#unmappableForLength(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Charset.CoderResult"/></returns>
        public static Java.Nio.Charset.CoderResult UnmappableForLength(int arg0)
        {
            return SExecuteWithSignature<Java.Nio.Charset.CoderResult>(LocalBridgeClazz, "unmappableForLength", "(I)Ljava/nio/charset/CoderResult;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CoderResult.html#isError()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsError()
        {
            return IExecuteWithSignature<bool>("isError", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CoderResult.html#isMalformed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMalformed()
        {
            return IExecuteWithSignature<bool>("isMalformed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CoderResult.html#isOverflow()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOverflow()
        {
            return IExecuteWithSignature<bool>("isOverflow", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CoderResult.html#isUnderflow()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnderflow()
        {
            return IExecuteWithSignature<bool>("isUnderflow", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CoderResult.html#isUnmappable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnmappable()
        {
            return IExecuteWithSignature<bool>("isUnmappable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CoderResult.html#length()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Length()
        {
            return IExecuteWithSignature<int>("length", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CoderResult.html#throwException()"/>
        /// </summary>
        /// <exception cref="Java.Nio.Charset.CharacterCodingException"/>
        public void ThrowException()
        {
            IExecuteWithSignature("throwException", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}