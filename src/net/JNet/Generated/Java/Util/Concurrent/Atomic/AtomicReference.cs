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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent.Atomic
{
    #region AtomicReference
    public partial class AtomicReference
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#%3Cinit%3E(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public AtomicReference(object arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getAcquire()"/> 
        /// </summary>
        public object Acquire
        {
            get { return IExecuteWithSignature("getAcquire", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getOpaque()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#setOpaque(java.lang.Object)"/>
        /// </summary>
        public object Opaque
        {
            get { return IExecuteWithSignature("getOpaque", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setOpaque", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getPlain()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#setPlain(java.lang.Object)"/>
        /// </summary>
        public object Plain
        {
            get { return IExecuteWithSignature("getPlain", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setPlain", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#compareAndSet(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(object arg0, object arg1)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#weakCompareAndSetAcquire(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetAcquire(object arg0, object arg1)
        {
            return IExecute<bool>("weakCompareAndSetAcquire", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#weakCompareAndSetPlain(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetPlain(object arg0, object arg1)
        {
            return IExecute<bool>("weakCompareAndSetPlain", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#weakCompareAndSetRelease(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetRelease(object arg0, object arg1)
        {
            return IExecute<bool>("weakCompareAndSetRelease", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#weakCompareAndSetVolatile(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetVolatile(object arg0, object arg1)
        {
            return IExecute<bool>("weakCompareAndSetVolatile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#accumulateAndGet(java.lang.Object,java.util.function.BinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <returns><see cref="object"/></returns>
        public object AccumulateAndGet(object arg0, Java.Util.Function.BinaryOperator arg1)
        {
            return IExecute("accumulateAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#compareAndExchange(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object CompareAndExchange(object arg0, object arg1)
        {
            return IExecute("compareAndExchange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#compareAndExchangeAcquire(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object CompareAndExchangeAcquire(object arg0, object arg1)
        {
            return IExecute("compareAndExchangeAcquire", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#compareAndExchangeRelease(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object CompareAndExchangeRelease(object arg0, object arg1)
        {
            return IExecute("compareAndExchangeRelease", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#get()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Get()
        {
            return IExecuteWithSignature("get", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getAndAccumulate(java.lang.Object,java.util.function.BinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndAccumulate(object arg0, Java.Util.Function.BinaryOperator arg1)
        {
            return IExecute("getAndAccumulate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getAndSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndSet(object arg0)
        {
            return IExecuteWithSignature("getAndSet", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getAndUpdate(java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndUpdate(Java.Util.Function.UnaryOperator arg0)
        {
            return IExecuteWithSignature("getAndUpdate", "(Ljava/util/function/UnaryOperator;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#updateAndGet(java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><see cref="object"/></returns>
        public object UpdateAndGet(Java.Util.Function.UnaryOperator arg0)
        {
            return IExecuteWithSignature("updateAndGet", "(Ljava/util/function/UnaryOperator;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#lazySet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void LazySet(object arg0)
        {
            IExecuteWithSignature("lazySet", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#set(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Set(object arg0)
        {
            IExecuteWithSignature("set", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#setRelease(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetRelease(object arg0)
        {
            IExecuteWithSignature("setRelease", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AtomicReference<V>
    public partial class AtomicReference<V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#%3Cinit%3E(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        public AtomicReference(V arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.Atomic.AtomicReference{V}"/> to <see cref="Java.Util.Concurrent.Atomic.AtomicReference"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Atomic.AtomicReference(Java.Util.Concurrent.Atomic.AtomicReference<V> t) => t.Cast<Java.Util.Concurrent.Atomic.AtomicReference>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getAcquire()"/> 
        /// </summary>
        public V Acquire
        {
            get { return IExecuteWithSignature<V>("getAcquire", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getOpaque()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#setOpaque(java.lang.Object)"/>
        /// </summary>
        public V Opaque
        {
            get { return IExecuteWithSignature<V>("getOpaque", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setOpaque", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getPlain()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#setPlain(java.lang.Object)"/>
        /// </summary>
        public V Plain
        {
            get { return IExecuteWithSignature<V>("getPlain", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setPlain", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#compareAndSet(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(V arg0, V arg1)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#weakCompareAndSetAcquire(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetAcquire(V arg0, V arg1)
        {
            return IExecute<bool>("weakCompareAndSetAcquire", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#weakCompareAndSetPlain(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetPlain(V arg0, V arg1)
        {
            return IExecute<bool>("weakCompareAndSetPlain", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#weakCompareAndSetRelease(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetRelease(V arg0, V arg1)
        {
            return IExecute<bool>("weakCompareAndSetRelease", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#weakCompareAndSetVolatile(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetVolatile(V arg0, V arg1)
        {
            return IExecute<bool>("weakCompareAndSetVolatile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#accumulateAndGet(java.lang.Object,java.util.function.BinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V AccumulateAndGet(V arg0, Java.Util.Function.BinaryOperator<V> arg1)
        {
            return IExecute<V>("accumulateAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#compareAndExchange(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V CompareAndExchange(V arg0, V arg1)
        {
            return IExecute<V>("compareAndExchange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#compareAndExchangeAcquire(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V CompareAndExchangeAcquire(V arg0, V arg1)
        {
            return IExecute<V>("compareAndExchangeAcquire", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#compareAndExchangeRelease(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V CompareAndExchangeRelease(V arg0, V arg1)
        {
            return IExecute<V>("compareAndExchangeRelease", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#get()"/>
        /// </summary>

        /// <returns><typeparamref name="V"/></returns>
        public V Get()
        {
            return IExecuteWithSignature<V>("get", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getAndAccumulate(java.lang.Object,java.util.function.BinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V GetAndAccumulate(V arg0, Java.Util.Function.BinaryOperator<V> arg1)
        {
            return IExecute<V>("getAndAccumulate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getAndSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V GetAndSet(V arg0)
        {
            return IExecuteWithSignature<V>("getAndSet", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getAndUpdate(java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V GetAndUpdate(Java.Util.Function.UnaryOperator<V> arg0)
        {
            return IExecuteWithSignature<V>("getAndUpdate", "(Ljava/util/function/UnaryOperator;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#updateAndGet(java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V UpdateAndGet(Java.Util.Function.UnaryOperator<V> arg0)
        {
            return IExecuteWithSignature<V>("updateAndGet", "(Ljava/util/function/UnaryOperator;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#lazySet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        public void LazySet(V arg0)
        {
            IExecuteWithSignature("lazySet", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#set(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        public void Set(V arg0)
        {
            IExecuteWithSignature("set", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#setRelease(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        public void SetRelease(V arg0)
        {
            IExecuteWithSignature("setRelease", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}