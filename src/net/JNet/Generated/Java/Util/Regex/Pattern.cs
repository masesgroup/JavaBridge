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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Regex
{
    #region Pattern
    public partial class Pattern
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#CANON_EQ"/>
        /// </summary>
        public static int CANON_EQ { get { return SGetField<int>(LocalBridgeClazz, "CANON_EQ"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#CASE_INSENSITIVE"/>
        /// </summary>
        public static int CASE_INSENSITIVE { get { return SGetField<int>(LocalBridgeClazz, "CASE_INSENSITIVE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#COMMENTS"/>
        /// </summary>
        public static int COMMENTS { get { return SGetField<int>(LocalBridgeClazz, "COMMENTS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#DOTALL"/>
        /// </summary>
        public static int DOTALL { get { return SGetField<int>(LocalBridgeClazz, "DOTALL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#LITERAL"/>
        /// </summary>
        public static int LITERAL { get { return SGetField<int>(LocalBridgeClazz, "LITERAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#MULTILINE"/>
        /// </summary>
        public static int MULTILINE { get { return SGetField<int>(LocalBridgeClazz, "MULTILINE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#UNICODE_CASE"/>
        /// </summary>
        public static int UNICODE_CASE { get { return SGetField<int>(LocalBridgeClazz, "UNICODE_CASE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#UNICODE_CHARACTER_CLASS"/>
        /// </summary>
        public static int UNICODE_CHARACTER_CLASS { get { return SGetField<int>(LocalBridgeClazz, "UNICODE_CHARACTER_CLASS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#UNIX_LINES"/>
        /// </summary>
        public static int UNIX_LINES { get { return SGetField<int>(LocalBridgeClazz, "UNIX_LINES"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#matches(java.lang.String,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Matches(string arg0, Java.Lang.CharSequence arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "matches", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#quote(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public static string Quote(string arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "quote", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#compile(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Regex.Pattern"/></returns>
        public static Java.Util.Regex.Pattern Compile(string arg0, int arg1)
        {
            return SExecute<Java.Util.Regex.Pattern>(LocalBridgeClazz, "compile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#compile(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Regex.Pattern"/></returns>
        public static Java.Util.Regex.Pattern Compile(string arg0)
        {
            return SExecute<Java.Util.Regex.Pattern>(LocalBridgeClazz, "compile", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#flags()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Flags()
        {
            return IExecute<int>("flags");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#pattern()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string PatternMethod()
        {
            return IExecute<string>("pattern");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#split(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] Split(Java.Lang.CharSequence arg0, int arg1)
        {
            return IExecuteArray<string>("split", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#split(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] Split(Java.Lang.CharSequence arg0)
        {
            return IExecuteArray<string>("split", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#asMatchPredicate()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate<string> AsMatchPredicate()
        {
            return IExecute<Java.Util.Function.Predicate<string>>("asMatchPredicate");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#asPredicate()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate<string> AsPredicate()
        {
            return IExecute<Java.Util.Function.Predicate<string>>("asPredicate");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#matcher(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher Matcher(Java.Lang.CharSequence arg0)
        {
            return IExecute<Java.Util.Regex.Matcher>("matcher", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#splitAsStream(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<string> SplitAsStream(Java.Lang.CharSequence arg0)
        {
            return IExecute<Java.Util.Stream.Stream<string>>("splitAsStream", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}