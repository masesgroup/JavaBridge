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

namespace Java.Util.Concurrent
{
    #region AbstractExecutorService
    public partial class AbstractExecutorService
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/AbstractExecutorService.html#submit(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<T> Submit<T>(Java.Lang.Runnable arg0, T arg1)
        {
            return IExecute<Java.Util.Concurrent.Future<T>>("submit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/AbstractExecutorService.html#submit(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<T> Submit<T>(Java.Util.Concurrent.Callable<T> arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<T>>("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/AbstractExecutorService.html#invokeAll(java.util.Collection,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Util_Concurrent_Callable_T_"><see cref="Java.Util.Concurrent.Callable{T}"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.List<Java.Util.Concurrent.Future<T>> InvokeAll<T, Arg0ExtendsJava_Util_Concurrent_Callable_T_>(Java.Util.Collection<Arg0ExtendsJava_Util_Concurrent_Callable_T_> arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2) where Arg0ExtendsJava_Util_Concurrent_Callable_T_: Java.Util.Concurrent.Callable<T>
        {
            return IExecute<Java.Util.List<Java.Util.Concurrent.Future<T>>>("invokeAll", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/AbstractExecutorService.html#invokeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Util_Concurrent_Callable_T_"><see cref="Java.Util.Concurrent.Callable{T}"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.List<Java.Util.Concurrent.Future<T>> InvokeAll<T, Arg0ExtendsJava_Util_Concurrent_Callable_T_>(Java.Util.Collection<Arg0ExtendsJava_Util_Concurrent_Callable_T_> arg0) where Arg0ExtendsJava_Util_Concurrent_Callable_T_: Java.Util.Concurrent.Callable<T>
        {
            return IExecuteWithSignature<Java.Util.List<Java.Util.Concurrent.Future<T>>>("invokeAll", "(Ljava/util/Collection;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/AbstractExecutorService.html#invokeAny(java.util.Collection,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Util_Concurrent_Callable_T_"><see cref="Java.Util.Concurrent.Callable{T}"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public T InvokeAny<T, Arg0ExtendsJava_Util_Concurrent_Callable_T_>(Java.Util.Collection<Arg0ExtendsJava_Util_Concurrent_Callable_T_> arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2) where Arg0ExtendsJava_Util_Concurrent_Callable_T_: Java.Util.Concurrent.Callable<T>
        {
            return IExecute<T>("invokeAny", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/AbstractExecutorService.html#invokeAny(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Util_Concurrent_Callable_T_"><see cref="Java.Util.Concurrent.Callable{T}"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        public T InvokeAny<T, Arg0ExtendsJava_Util_Concurrent_Callable_T_>(Java.Util.Collection<Arg0ExtendsJava_Util_Concurrent_Callable_T_> arg0) where Arg0ExtendsJava_Util_Concurrent_Callable_T_: Java.Util.Concurrent.Callable<T>
        {
            return IExecuteWithSignature<T>("invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/AbstractExecutorService.html#submit(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<object> Submit(Java.Lang.Runnable arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<object>>("submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}