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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Text
{
    #region CharacterIterator
    public partial class CharacterIterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Text.CharacterIterator"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Text.CharacterIterator t) => t.Cast<Java.Lang.Cloneable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#DONE"/>
        /// </summary>
        public static char DONE => Clazz.GetField<char>("DONE");
        
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
        
        /// <returns><see langword="char"/></returns>
        public char Current()
        {
            return IExecute<char>("current");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#first()"/>
        /// </summary>
        
        /// <returns><see langword="char"/></returns>
        public char First()
        {
            return IExecute<char>("first");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#last()"/>
        /// </summary>
        
        /// <returns><see langword="char"/></returns>
        public char Last()
        {
            return IExecute<char>("last");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#next()"/>
        /// </summary>
        
        /// <returns><see langword="char"/></returns>
        public char Next()
        {
            return IExecute<char>("next");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#previous()"/>
        /// </summary>
        
        /// <returns><see langword="char"/></returns>
        public char Previous()
        {
            return IExecute<char>("previous");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#setIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="char"/></returns>
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