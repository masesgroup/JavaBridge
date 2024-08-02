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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region PriorityQueue
    public partial class PriorityQueue
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PriorityQueue.html#%3Cinit%3E(int,java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Comparator"/></param>
        public PriorityQueue(int arg0, Java.Util.Comparator arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PriorityQueue.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public PriorityQueue(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PriorityQueue.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public PriorityQueue(Java.Util.Collection arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PriorityQueue.html#%3Cinit%3E(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        public PriorityQueue(Java.Util.Comparator arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PriorityQueue.html#%3Cinit%3E(java.util.PriorityQueue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.PriorityQueue"/></param>
        public PriorityQueue(Java.Util.PriorityQueue arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PriorityQueue.html#%3Cinit%3E(java.util.SortedSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.SortedSet"/></param>
        public PriorityQueue(Java.Util.SortedSet arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.PriorityQueue"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.PriorityQueue t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PriorityQueue.html#comparator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Comparator"/></returns>
        public Java.Util.Comparator Comparator()
        {
            return IExecuteWithSignature<Java.Util.Comparator>("comparator", "()Ljava/util/Comparator;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PriorityQueue<E>
    public partial class PriorityQueue<E>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PriorityQueue.html#%3Cinit%3E(int,java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Comparator"/></param>
        public PriorityQueue(int arg0, Java.Util.Comparator<E> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PriorityQueue.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public PriorityQueue(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PriorityQueue.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public PriorityQueue(Java.Util.Collection<E> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PriorityQueue.html#%3Cinit%3E(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        public PriorityQueue(Java.Util.Comparator<E> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PriorityQueue.html#%3Cinit%3E(java.util.PriorityQueue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.PriorityQueue"/></param>
        public PriorityQueue(Java.Util.PriorityQueue<E> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PriorityQueue.html#%3Cinit%3E(java.util.SortedSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.SortedSet"/></param>
        public PriorityQueue(Java.Util.SortedSet<E> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.PriorityQueue{E}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.PriorityQueue<E> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.PriorityQueue{E}"/> to <see cref="Java.Util.PriorityQueue"/>
        /// </summary>
        public static implicit operator Java.Util.PriorityQueue(Java.Util.PriorityQueue<E> t) => t.Cast<Java.Util.PriorityQueue>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PriorityQueue.html#comparator()"/>
        /// </summary>
        /// <typeparam name="ReturnobjectSuperE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="Java.Util.Comparator"/></returns>
        public Java.Util.Comparator<ReturnobjectSuperE> Comparator<ReturnobjectSuperE>() where ReturnobjectSuperE : E
        {
            return IExecuteWithSignature<Java.Util.Comparator<ReturnobjectSuperE>>("comparator", "()Ljava/util/Comparator;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}