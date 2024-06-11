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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region CompletionService
    public partial class CompletionService
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#poll()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future Poll()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future>("poll", "()Ljava/util/concurrent/Future;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#poll(long,java.util.concurrent.TimeUnit)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#submit(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future Submit(Java.Lang.Runnable arg0, object arg1)
        {
            return IExecute<Java.Util.Concurrent.Future>("submit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#submit(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future Submit(Java.Util.Concurrent.Callable arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future>("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#take()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.Concurrent.Future Take()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future>("take", "()Ljava/util/concurrent/Future;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ICompletionService<V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICompletionService<V>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#poll()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        Java.Util.Concurrent.Future<V> Poll();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#poll(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        Java.Util.Concurrent.Future<V> Poll(long arg0, Java.Util.Concurrent.TimeUnit arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#submit(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        Java.Util.Concurrent.Future<V> Submit(Java.Lang.Runnable arg0, V arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#submit(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        Java.Util.Concurrent.Future<V> Submit(Java.Util.Concurrent.Callable<V> arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#take()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        Java.Util.Concurrent.Future<V> Take();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CompletionService<V>
    public partial class CompletionService<V> : Java.Util.Concurrent.ICompletionService<V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CompletionService{V}"/> to <see cref="Java.Util.Concurrent.CompletionService"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.CompletionService(Java.Util.Concurrent.CompletionService<V> t) => t.Cast<Java.Util.Concurrent.CompletionService>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#poll()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<V> Poll()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<V>>("poll", "()Ljava/util/concurrent/Future;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#poll(long,java.util.concurrent.TimeUnit)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#submit(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<V> Submit(Java.Lang.Runnable arg0, V arg1)
        {
            return IExecute<Java.Util.Concurrent.Future<V>>("submit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#submit(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<V> Submit(Java.Util.Concurrent.Callable<V> arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<V>>("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionService.html#take()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.Concurrent.Future<V> Take()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<V>>("take", "()Ljava/util/concurrent/Future;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}