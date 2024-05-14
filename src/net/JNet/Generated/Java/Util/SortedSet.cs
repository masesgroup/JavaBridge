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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region SortedSet
    public partial class SortedSet
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#first()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object First()
        {
            return IExecuteWithSignature("first", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#last()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Last()
        {
            return IExecuteWithSignature("last", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#headSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet HeadSet(object arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedSet>("headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#subSet(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet SubSet(object arg0, object arg1)
        {
            return IExecute<Java.Util.SortedSet>("subSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#tailSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet TailSet(object arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedSet>("tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#spliterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public Java.Util.Spliterator Spliterator()
        {
            return IExecuteWithSignature<Java.Util.Spliterator>("spliterator", "()Ljava/util/Spliterator;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ISortedSet<E>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISortedSet<E> : Java.Util.ISet<E>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#first()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E First();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#last()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E Last();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#headSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        Java.Util.SortedSet<E> HeadSet(E arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#subSet(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        Java.Util.SortedSet<E> SubSet(E arg0, E arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#tailSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        Java.Util.SortedSet<E> TailSet(E arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#spliterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        Java.Util.Spliterator<E> Spliterator();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SortedSet<E>
    public partial class SortedSet<E> : Java.Util.ISortedSet<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.SortedSet{E}"/> to <see cref="Java.Util.SortedSet"/>
        /// </summary>
        public static implicit operator Java.Util.SortedSet(Java.Util.SortedSet<E> t) => t.Cast<Java.Util.SortedSet>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#first()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E First()
        {
            return IExecuteWithSignature<E>("first", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#last()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Last()
        {
            return IExecuteWithSignature<E>("last", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#headSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet<E> HeadSet(E arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedSet<E>>("headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#subSet(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet<E> SubSet(E arg0, E arg1)
        {
            return IExecute<Java.Util.SortedSet<E>>("subSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#tailSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet<E> TailSet(E arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedSet<E>>("tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedSet.html#spliterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public Java.Util.Spliterator<E> Spliterator()
        {
            return IExecuteWithSignature<Java.Util.Spliterator<E>>("spliterator", "()Ljava/util/Spliterator;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}