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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Text
{
    #region BreakIterator
    public partial class BreakIterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#DONE"/>
        /// </summary>
        public static int DONE { get { return SGetField<int>(LocalBridgeClazz, "DONE"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getAvailableLocales()"/> 
        /// </summary>
        public static Java.Util.Locale[] AvailableLocales
        {
            get { return SExecuteArray<Java.Util.Locale>(LocalBridgeClazz, "getAvailableLocales"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getCharacterInstance()"/> 
        /// </summary>
        public static Java.Text.BreakIterator CharacterInstance
        {
            get { return SExecute<Java.Text.BreakIterator>(LocalBridgeClazz, "getCharacterInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getLineInstance()"/> 
        /// </summary>
        public static Java.Text.BreakIterator LineInstance
        {
            get { return SExecute<Java.Text.BreakIterator>(LocalBridgeClazz, "getLineInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getSentenceInstance()"/> 
        /// </summary>
        public static Java.Text.BreakIterator SentenceInstance
        {
            get { return SExecute<Java.Text.BreakIterator>(LocalBridgeClazz, "getSentenceInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getWordInstance()"/> 
        /// </summary>
        public static Java.Text.BreakIterator WordInstance
        {
            get { return SExecute<Java.Text.BreakIterator>(LocalBridgeClazz, "getWordInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getCharacterInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.BreakIterator"/></returns>
        public static Java.Text.BreakIterator GetCharacterInstance(Java.Util.Locale arg0)
        {
            return SExecute<Java.Text.BreakIterator>(LocalBridgeClazz, "getCharacterInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getLineInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.BreakIterator"/></returns>
        public static Java.Text.BreakIterator GetLineInstance(Java.Util.Locale arg0)
        {
            return SExecute<Java.Text.BreakIterator>(LocalBridgeClazz, "getLineInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getSentenceInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.BreakIterator"/></returns>
        public static Java.Text.BreakIterator GetSentenceInstance(Java.Util.Locale arg0)
        {
            return SExecute<Java.Text.BreakIterator>(LocalBridgeClazz, "getSentenceInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getWordInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.BreakIterator"/></returns>
        public static Java.Text.BreakIterator GetWordInstance(Java.Util.Locale arg0)
        {
            return SExecute<Java.Text.BreakIterator>(LocalBridgeClazz, "getWordInstance", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getText()"/> 
        /// </summary>
        public Java.Text.CharacterIterator Text
        {
            get { return IExecute<Java.Text.CharacterIterator>("getText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#current()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Current()
        {
            return IExecute<int>("current");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#first()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int First()
        {
            return IExecute<int>("first");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#following(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Following(int arg0)
        {
            return IExecute<int>("following", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#last()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Last()
        {
            return IExecute<int>("last");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#next()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Next()
        {
            return IExecute<int>("next");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#next(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Next(int arg0)
        {
            return IExecute<int>("next", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#previous()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Previous()
        {
            return IExecute<int>("previous");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#setText(java.text.CharacterIterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.CharacterIterator"/></param>
        public void SetText(Java.Text.CharacterIterator arg0)
        {
            IExecute("setText", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#isBoundary(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsBoundary(int arg0)
        {
            return IExecute<bool>("isBoundary", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#preceding(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Preceding(int arg0)
        {
            return IExecute<int>("preceding", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#setText(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void SetText(string arg0)
        {
            IExecute("setText", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}