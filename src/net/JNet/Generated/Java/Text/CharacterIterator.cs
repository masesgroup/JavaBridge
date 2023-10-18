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
    #region ICharacterIterator
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICharacterIterator : Java.Lang.ICloneable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#getBeginIndex()"/> 
        /// </summary>
        int BeginIndex { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#getEndIndex()"/> 
        /// </summary>
        int EndIndex { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#getIndex()"/> 
        /// </summary>
        int Index { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#current()"/>
        /// </summary>

        /// <returns><see cref="char"/></returns>
        char Current();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#first()"/>
        /// </summary>

        /// <returns><see cref="char"/></returns>
        char First();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#last()"/>
        /// </summary>

        /// <returns><see cref="char"/></returns>
        char Last();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#next()"/>
        /// </summary>

        /// <returns><see cref="char"/></returns>
        char Next();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#previous()"/>
        /// </summary>

        /// <returns><see cref="char"/></returns>
        char Previous();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#setIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        char SetIndex(int arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CharacterIterator
    public partial class CharacterIterator : Java.Text.ICharacterIterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#DONE"/>
        /// </summary>
        public static char DONE { get { return SGetField<char>(LocalBridgeClazz, "DONE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#getBeginIndex()"/> 
        /// </summary>
        public int BeginIndex
        {
            get { return IExecute<int>("getBeginIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#getEndIndex()"/> 
        /// </summary>
        public int EndIndex
        {
            get { return IExecute<int>("getEndIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#getIndex()"/> 
        /// </summary>
        public int Index
        {
            get { return IExecute<int>("getIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#current()"/>
        /// </summary>

        /// <returns><see cref="char"/></returns>
        public char Current()
        {
            return IExecute<char>("current");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#first()"/>
        /// </summary>

        /// <returns><see cref="char"/></returns>
        public char First()
        {
            return IExecute<char>("first");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#last()"/>
        /// </summary>

        /// <returns><see cref="char"/></returns>
        public char Last()
        {
            return IExecute<char>("last");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#next()"/>
        /// </summary>

        /// <returns><see cref="char"/></returns>
        public char Next()
        {
            return IExecute<char>("next");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#previous()"/>
        /// </summary>

        /// <returns><see cref="char"/></returns>
        public char Previous()
        {
            return IExecute<char>("previous");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#setIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char SetIndex(int arg0)
        {
            return IExecute<char>("setIndex", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}