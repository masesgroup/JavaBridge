/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.Charset
{
    #region CharsetDecoder
    public partial class CharsetDecoder
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#isAutoDetecting()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAutoDetecting()
        {
            return IExecute<bool>("isAutoDetecting");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#isCharsetDetected()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCharsetDetected()
        {
            return IExecute<bool>("isCharsetDetected");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#averageCharsPerByte()"/>
        /// </summary>

        /// <returns><see cref="float"/></returns>
        public float AverageCharsPerByte()
        {
            return IExecute<float>("averageCharsPerByte");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#maxCharsPerByte()"/>
        /// </summary>

        /// <returns><see cref="float"/></returns>
        public float MaxCharsPerByte()
        {
            return IExecute<float>("maxCharsPerByte");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#replacement()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Replacement()
        {
            return IExecute<string>("replacement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#decode(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        /// <exception cref="Java.Nio.Charset.CharacterCodingException"/>
        public Java.Nio.CharBuffer Decode(Java.Nio.ByteBuffer arg0)
        {
            return IExecute<Java.Nio.CharBuffer>("decode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#charset()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Charset.Charset"/></returns>
        public Java.Nio.Charset.Charset Charset()
        {
            return IExecute<Java.Nio.Charset.Charset>("charset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#onMalformedInput(java.nio.charset.CodingErrorAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Charset.CodingErrorAction"/></param>
        /// <returns><see cref="Java.Nio.Charset.CharsetDecoder"/></returns>
        public Java.Nio.Charset.CharsetDecoder OnMalformedInput(Java.Nio.Charset.CodingErrorAction arg0)
        {
            return IExecute<Java.Nio.Charset.CharsetDecoder>("onMalformedInput", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#onUnmappableCharacter(java.nio.charset.CodingErrorAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Charset.CodingErrorAction"/></param>
        /// <returns><see cref="Java.Nio.Charset.CharsetDecoder"/></returns>
        public Java.Nio.Charset.CharsetDecoder OnUnmappableCharacter(Java.Nio.Charset.CodingErrorAction arg0)
        {
            return IExecute<Java.Nio.Charset.CharsetDecoder>("onUnmappableCharacter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#replaceWith(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Nio.Charset.CharsetDecoder"/></returns>
        public Java.Nio.Charset.CharsetDecoder ReplaceWith(string arg0)
        {
            return IExecute<Java.Nio.Charset.CharsetDecoder>("replaceWith", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#reset()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Charset.CharsetDecoder"/></returns>
        public Java.Nio.Charset.CharsetDecoder Reset()
        {
            return IExecute<Java.Nio.Charset.CharsetDecoder>("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#decode(java.nio.ByteBuffer,java.nio.CharBuffer,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.CharBuffer"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Nio.Charset.CoderResult"/></returns>
        public Java.Nio.Charset.CoderResult Decode(Java.Nio.ByteBuffer arg0, Java.Nio.CharBuffer arg1, bool arg2)
        {
            return IExecute<Java.Nio.Charset.CoderResult>("decode", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#flush(java.nio.CharBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.CharBuffer"/></param>
        /// <returns><see cref="Java.Nio.Charset.CoderResult"/></returns>
        public Java.Nio.Charset.CoderResult Flush(Java.Nio.CharBuffer arg0)
        {
            return IExecute<Java.Nio.Charset.CoderResult>("flush", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#detectedCharset()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Charset.Charset"/></returns>
        public Java.Nio.Charset.Charset DetectedCharset()
        {
            return IExecute<Java.Nio.Charset.Charset>("detectedCharset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#malformedInputAction()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Charset.CodingErrorAction"/></returns>
        public Java.Nio.Charset.CodingErrorAction MalformedInputAction()
        {
            return IExecute<Java.Nio.Charset.CodingErrorAction>("malformedInputAction");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetDecoder.html#unmappableCharacterAction()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Charset.CodingErrorAction"/></returns>
        public Java.Nio.Charset.CodingErrorAction UnmappableCharacterAction()
        {
            return IExecute<Java.Nio.Charset.CodingErrorAction>("unmappableCharacterAction");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}