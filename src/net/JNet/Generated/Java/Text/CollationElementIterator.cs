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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Text
{
    #region CollationElementIterator
    public partial class CollationElementIterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CollationElementIterator.html#NULLORDER"/>
        /// </summary>
        public static int NULLORDER { get { if (!_NULLORDERReady) { _NULLORDERContent = SGetField<int>(LocalBridgeClazz, "NULLORDER"); _NULLORDERReady = true; } return _NULLORDERContent; } }
        private static int _NULLORDERContent = default;
        private static bool _NULLORDERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CollationElementIterator.html#primaryOrder(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int PrimaryOrder(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "primaryOrder", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CollationElementIterator.html#secondaryOrder(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="short"/></returns>
        public static short SecondaryOrder(int arg0)
        {
            return SExecuteWithSignature<short>(LocalBridgeClazz, "secondaryOrder", "(I)S", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CollationElementIterator.html#tertiaryOrder(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="short"/></returns>
        public static short TertiaryOrder(int arg0)
        {
            return SExecuteWithSignature<short>(LocalBridgeClazz, "tertiaryOrder", "(I)S", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CollationElementIterator.html#getOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CollationElementIterator.html#setOffset(int)"/>
        /// </summary>
        public int Offset
        {
            get { return IExecuteWithSignature<int>("getOffset", "()I"); } set { IExecuteWithSignature("setOffset", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CollationElementIterator.html#getMaxExpansion(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetMaxExpansion(int arg0)
        {
            return IExecuteWithSignature<int>("getMaxExpansion", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CollationElementIterator.html#next()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Next()
        {
            return IExecuteWithSignature<int>("next", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CollationElementIterator.html#previous()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Previous()
        {
            return IExecuteWithSignature<int>("previous", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CollationElementIterator.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CollationElementIterator.html#setText(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetText(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setText", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CollationElementIterator.html#setText(java.text.CharacterIterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.CharacterIterator"/></param>
        public void SetText(Java.Text.CharacterIterator arg0)
        {
            IExecuteWithSignature("setText", "(Ljava/text/CharacterIterator;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}