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

namespace Java.Util.Concurrent
{
    #region ExecutorCompletionService
    public partial class ExecutorCompletionService
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorCompletionService.html#%3Cinit%3E(java.util.concurrent.Executor,java.util.concurrent.BlockingQueue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.BlockingQueue"/></param>
        public ExecutorCompletionService(Java.Util.Concurrent.Executor arg0, Java.Util.Concurrent.BlockingQueue arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorCompletionService.html#%3Cinit%3E(java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        public ExecutorCompletionService(Java.Util.Concurrent.Executor arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorCompletionService.html#poll()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future Poll()
        {
            return IExecute<Java.Util.Concurrent.Future>("poll");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorCompletionService.html#poll(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.Concurrent.Future Poll(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<Java.Util.Concurrent.Future>("poll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorCompletionService.html#submit(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future Submit(Java.Lang.Runnable arg0, object arg1)
        {
            return IExecute<Java.Util.Concurrent.Future>("submit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorCompletionService.html#submit(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future Submit(Java.Util.Concurrent.Callable arg0)
        {
            return IExecute<Java.Util.Concurrent.Future>("submit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorCompletionService.html#take()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.Concurrent.Future Take()
        {
            return IExecute<Java.Util.Concurrent.Future>("take");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ExecutorCompletionService<V>
    public partial class ExecutorCompletionService<V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorCompletionService.html#%3Cinit%3E(java.util.concurrent.Executor,java.util.concurrent.BlockingQueue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.BlockingQueue"/></param>
        public ExecutorCompletionService(Java.Util.Concurrent.Executor arg0, Java.Util.Concurrent.BlockingQueue<Java.Util.Concurrent.Future<V>> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorCompletionService.html#%3Cinit%3E(java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        public ExecutorCompletionService(Java.Util.Concurrent.Executor arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ExecutorCompletionService{V}"/> to <see cref="Java.Util.Concurrent.ExecutorCompletionService"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ExecutorCompletionService(Java.Util.Concurrent.ExecutorCompletionService<V> t) => t.Cast<Java.Util.Concurrent.ExecutorCompletionService>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorCompletionService.html#poll()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<V> Poll()
        {
            return IExecute<Java.Util.Concurrent.Future<V>>("poll");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorCompletionService.html#poll(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.Concurrent.Future<V> Poll(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<Java.Util.Concurrent.Future<V>>("poll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorCompletionService.html#submit(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<V> Submit(Java.Lang.Runnable arg0, V arg1)
        {
            return IExecute<Java.Util.Concurrent.Future<V>>("submit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorCompletionService.html#submit(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<V> Submit(Java.Util.Concurrent.Callable<V> arg0)
        {
            return IExecute<Java.Util.Concurrent.Future<V>>("submit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorCompletionService.html#take()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.Concurrent.Future<V> Take()
        {
            return IExecute<Java.Util.Concurrent.Future<V>>("take");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}