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
    #region Bidi
    public partial class Bidi
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#%3Cinit%3E(char[],int,byte[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public Bidi(char[] arg0, int arg1, byte[] arg2, int arg3, int arg4, int arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public Bidi(Java.Lang.String arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#%3Cinit%3E(java.text.AttributedCharacterIterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator"/></param>
        public Bidi(Java.Text.AttributedCharacterIterator arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#DIRECTION_DEFAULT_LEFT_TO_RIGHT"/>
        /// </summary>
        public static int DIRECTION_DEFAULT_LEFT_TO_RIGHT { get { if (!_DIRECTION_DEFAULT_LEFT_TO_RIGHTReady) { _DIRECTION_DEFAULT_LEFT_TO_RIGHTContent = SGetField<int>(LocalBridgeClazz, "DIRECTION_DEFAULT_LEFT_TO_RIGHT"); _DIRECTION_DEFAULT_LEFT_TO_RIGHTReady = true; } return _DIRECTION_DEFAULT_LEFT_TO_RIGHTContent; } }
        private static int _DIRECTION_DEFAULT_LEFT_TO_RIGHTContent = default;
        private static bool _DIRECTION_DEFAULT_LEFT_TO_RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#DIRECTION_DEFAULT_RIGHT_TO_LEFT"/>
        /// </summary>
        public static int DIRECTION_DEFAULT_RIGHT_TO_LEFT { get { if (!_DIRECTION_DEFAULT_RIGHT_TO_LEFTReady) { _DIRECTION_DEFAULT_RIGHT_TO_LEFTContent = SGetField<int>(LocalBridgeClazz, "DIRECTION_DEFAULT_RIGHT_TO_LEFT"); _DIRECTION_DEFAULT_RIGHT_TO_LEFTReady = true; } return _DIRECTION_DEFAULT_RIGHT_TO_LEFTContent; } }
        private static int _DIRECTION_DEFAULT_RIGHT_TO_LEFTContent = default;
        private static bool _DIRECTION_DEFAULT_RIGHT_TO_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#DIRECTION_LEFT_TO_RIGHT"/>
        /// </summary>
        public static int DIRECTION_LEFT_TO_RIGHT { get { if (!_DIRECTION_LEFT_TO_RIGHTReady) { _DIRECTION_LEFT_TO_RIGHTContent = SGetField<int>(LocalBridgeClazz, "DIRECTION_LEFT_TO_RIGHT"); _DIRECTION_LEFT_TO_RIGHTReady = true; } return _DIRECTION_LEFT_TO_RIGHTContent; } }
        private static int _DIRECTION_LEFT_TO_RIGHTContent = default;
        private static bool _DIRECTION_LEFT_TO_RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#DIRECTION_RIGHT_TO_LEFT"/>
        /// </summary>
        public static int DIRECTION_RIGHT_TO_LEFT { get { if (!_DIRECTION_RIGHT_TO_LEFTReady) { _DIRECTION_RIGHT_TO_LEFTContent = SGetField<int>(LocalBridgeClazz, "DIRECTION_RIGHT_TO_LEFT"); _DIRECTION_RIGHT_TO_LEFTReady = true; } return _DIRECTION_RIGHT_TO_LEFTContent; } }
        private static int _DIRECTION_RIGHT_TO_LEFTContent = default;
        private static bool _DIRECTION_RIGHT_TO_LEFTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#requiresBidi(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool RequiresBidi(char[] arg0, int arg1, int arg2)
        {
            return SExecute<bool>(LocalBridgeClazz, "requiresBidi", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#reorderVisually(byte[],int,java.lang.Object[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public static void ReorderVisually(byte[] arg0, int arg1, object[] arg2, int arg3, int arg4)
        {
            SExecute(LocalBridgeClazz, "reorderVisually", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#getBaseLevel()"/> 
        /// </summary>
        public int BaseLevel
        {
            get { return IExecuteWithSignature<int>("getBaseLevel", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#getLength()"/> 
        /// </summary>
        public int Length
        {
            get { return IExecuteWithSignature<int>("getLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#getRunCount()"/> 
        /// </summary>
        public int RunCount
        {
            get { return IExecuteWithSignature<int>("getRunCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#baseIsLeftToRight()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool BaseIsLeftToRight()
        {
            return IExecuteWithSignature<bool>("baseIsLeftToRight", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#isLeftToRight()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLeftToRight()
        {
            return IExecuteWithSignature<bool>("isLeftToRight", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#isMixed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMixed()
        {
            return IExecuteWithSignature<bool>("isMixed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#isRightToLeft()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRightToLeft()
        {
            return IExecuteWithSignature<bool>("isRightToLeft", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#getLevelAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLevelAt(int arg0)
        {
            return IExecuteWithSignature<int>("getLevelAt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#getRunLevel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRunLevel(int arg0)
        {
            return IExecuteWithSignature<int>("getRunLevel", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#getRunLimit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRunLimit(int arg0)
        {
            return IExecuteWithSignature<int>("getRunLimit", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#getRunStart(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRunStart(int arg0)
        {
            return IExecuteWithSignature<int>("getRunStart", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Bidi.html#createLineBidi(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Text.Bidi"/></returns>
        public Java.Text.Bidi CreateLineBidi(int arg0, int arg1)
        {
            return IExecute<Java.Text.Bidi>("createLineBidi", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}