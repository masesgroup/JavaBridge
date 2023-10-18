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

namespace Java.Util.Concurrent.Atomic
{
    #region AtomicMarkableReference
    public partial class AtomicMarkableReference
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#%3Cinit%3E(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public AtomicMarkableReference(object arg0, bool arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#getReference()"/> 
        /// </summary>
        public object Reference
        {
            get { return IExecute("getReference"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#attemptMark(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AttemptMark(object arg0, bool arg1)
        {
            return IExecute<bool>("attemptMark", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#compareAndSet(java.lang.Object,java.lang.Object,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(object arg0, object arg1, bool arg2, bool arg3)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#isMarked()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMarked()
        {
            return IExecute<bool>("isMarked");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#weakCompareAndSet(java.lang.Object,java.lang.Object,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSet(object arg0, object arg1, bool arg2, bool arg3)
        {
            return IExecute<bool>("weakCompareAndSet", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#get(boolean[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(bool[] arg0)
        {
            return IExecute("get", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#set(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Set(object arg0, bool arg1)
        {
            IExecute("set", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AtomicMarkableReference<V>
    public partial class AtomicMarkableReference<V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#%3Cinit%3E(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public AtomicMarkableReference(V arg0, bool arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.Atomic.AtomicMarkableReference{V}"/> to <see cref="Java.Util.Concurrent.Atomic.AtomicMarkableReference"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Atomic.AtomicMarkableReference(Java.Util.Concurrent.Atomic.AtomicMarkableReference<V> t) => t.Cast<Java.Util.Concurrent.Atomic.AtomicMarkableReference>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#getReference()"/> 
        /// </summary>
        public V Reference
        {
            get { return IExecute<V>("getReference"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#attemptMark(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AttemptMark(V arg0, bool arg1)
        {
            return IExecute<bool>("attemptMark", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#compareAndSet(java.lang.Object,java.lang.Object,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(V arg0, V arg1, bool arg2, bool arg3)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#isMarked()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMarked()
        {
            return IExecute<bool>("isMarked");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#weakCompareAndSet(java.lang.Object,java.lang.Object,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSet(V arg0, V arg1, bool arg2, bool arg3)
        {
            return IExecute<bool>("weakCompareAndSet", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#get(boolean[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V Get(bool[] arg0)
        {
            return IExecute<V>("get", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicMarkableReference.html#set(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Set(V arg0, bool arg1)
        {
            IExecute("set", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}