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

namespace Org.Xml.Sax
{
    #region InputSource
    public partial class InputSource
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/InputSource.html#%3Cinit%3E(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        public InputSource(Java.Io.InputStream arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/InputSource.html#%3Cinit%3E(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        public InputSource(Java.Io.Reader arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/InputSource.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public InputSource(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/InputSource.html#getByteStream()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/InputSource.html#setByteStream(java.io.InputStream)"/>
        /// </summary>
        public Java.Io.InputStream ByteStream
        {
            get { return IExecuteWithSignature<Java.Io.InputStream>("getByteStream", "()Ljava/io/InputStream;"); } set { IExecuteWithSignature("setByteStream", "(Ljava/io/InputStream;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/InputSource.html#getCharacterStream()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/InputSource.html#setCharacterStream(java.io.Reader)"/>
        /// </summary>
        public Java.Io.Reader CharacterStream
        {
            get { return IExecuteWithSignature<Java.Io.Reader>("getCharacterStream", "()Ljava/io/Reader;"); } set { IExecuteWithSignature("setCharacterStream", "(Ljava/io/Reader;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/InputSource.html#getEncoding()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/InputSource.html#setEncoding(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Encoding
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getEncoding", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setEncoding", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/InputSource.html#getPublicId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/InputSource.html#setPublicId(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String PublicId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPublicId", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setPublicId", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/InputSource.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/InputSource.html#setSystemId(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String SystemId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSystemId", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setSystemId", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/InputSource.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}