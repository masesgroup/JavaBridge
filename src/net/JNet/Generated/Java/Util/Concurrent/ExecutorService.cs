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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region ExecutorService declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html"/>
    /// </summary>
    public partial class ExecutorService : Java.Util.Concurrent.Executor
    {
        const string _bridgeClassName = "java.util.concurrent.ExecutorService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ExecutorService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ExecutorService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ExecutorService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ExecutorService(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IExecutorService
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IExecutorService : Java.Util.Concurrent.IExecutor
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#submit(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        Java.Util.Concurrent.Future<T> Submit<T>(Java.Lang.Runnable arg0, T arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#submit(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        Java.Util.Concurrent.Future<T> Submit<T>(Java.Util.Concurrent.Callable<T> arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#invokeAll(java.util.Collection,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Util_Concurrent_Callable_T_"><see cref="Java.Util.Concurrent.Callable{T}"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        Java.Util.List<Java.Util.Concurrent.Future<T>> InvokeAll<T, Arg0ExtendsJava_Util_Concurrent_Callable_T_>(Java.Util.Collection<Arg0ExtendsJava_Util_Concurrent_Callable_T_> arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2) where Arg0ExtendsJava_Util_Concurrent_Callable_T_ : Java.Util.Concurrent.Callable<T>;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#invokeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Util_Concurrent_Callable_T_"><see cref="Java.Util.Concurrent.Callable{T}"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        Java.Util.List<Java.Util.Concurrent.Future<T>> InvokeAll<T, Arg0ExtendsJava_Util_Concurrent_Callable_T_>(Java.Util.Collection<Arg0ExtendsJava_Util_Concurrent_Callable_T_> arg0) where Arg0ExtendsJava_Util_Concurrent_Callable_T_ : Java.Util.Concurrent.Callable<T>;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#invokeAny(java.util.Collection,long,java.util.concurrent.TimeUnit)"/>
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
        T InvokeAny<T, Arg0ExtendsJava_Util_Concurrent_Callable_T_>(Java.Util.Collection<Arg0ExtendsJava_Util_Concurrent_Callable_T_> arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2) where Arg0ExtendsJava_Util_Concurrent_Callable_T_ : Java.Util.Concurrent.Callable<T>;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#invokeAny(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Util_Concurrent_Callable_T_"><see cref="Java.Util.Concurrent.Callable{T}"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        T InvokeAny<T, Arg0ExtendsJava_Util_Concurrent_Callable_T_>(Java.Util.Collection<Arg0ExtendsJava_Util_Concurrent_Callable_T_> arg0) where Arg0ExtendsJava_Util_Concurrent_Callable_T_ : Java.Util.Concurrent.Callable<T>;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#awaitTermination(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        bool AwaitTermination(long arg0, Java.Util.Concurrent.TimeUnit arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#isShutdown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsShutdown();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#isTerminated()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsTerminated();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#submit(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        Java.Util.Concurrent.Future<object> Submit(Java.Lang.Runnable arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#shutdownNow()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        Java.Util.List<Java.Lang.Runnable> ShutdownNow();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#shutdown()"/>
        /// </summary>
        void Shutdown();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ExecutorService implementation
    public partial class ExecutorService : Java.Util.Concurrent.IExecutorService
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#submit(java.lang.Runnable,java.lang.Object)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#submit(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<T> Submit<T>(Java.Util.Concurrent.Callable<T> arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<T>>("submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#invokeAll(java.util.Collection,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Util_Concurrent_Callable_T_"><see cref="Java.Util.Concurrent.Callable{T}"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.List<Java.Util.Concurrent.Future<T>> InvokeAll<T, Arg0ExtendsJava_Util_Concurrent_Callable_T_>(Java.Util.Collection<Arg0ExtendsJava_Util_Concurrent_Callable_T_> arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2) where Arg0ExtendsJava_Util_Concurrent_Callable_T_ : Java.Util.Concurrent.Callable<T>
        {
            return IExecute<Java.Util.List<Java.Util.Concurrent.Future<T>>>("invokeAll", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#invokeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Util_Concurrent_Callable_T_"><see cref="Java.Util.Concurrent.Callable{T}"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.List<Java.Util.Concurrent.Future<T>> InvokeAll<T, Arg0ExtendsJava_Util_Concurrent_Callable_T_>(Java.Util.Collection<Arg0ExtendsJava_Util_Concurrent_Callable_T_> arg0) where Arg0ExtendsJava_Util_Concurrent_Callable_T_ : Java.Util.Concurrent.Callable<T>
        {
            return IExecuteWithSignature<Java.Util.List<Java.Util.Concurrent.Future<T>>>("invokeAll", "(Ljava/util/Collection;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#invokeAny(java.util.Collection,long,java.util.concurrent.TimeUnit)"/>
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
        public T InvokeAny<T, Arg0ExtendsJava_Util_Concurrent_Callable_T_>(Java.Util.Collection<Arg0ExtendsJava_Util_Concurrent_Callable_T_> arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2) where Arg0ExtendsJava_Util_Concurrent_Callable_T_ : Java.Util.Concurrent.Callable<T>
        {
            return IExecute<T>("invokeAny", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#invokeAny(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Util_Concurrent_Callable_T_"><see cref="Java.Util.Concurrent.Callable{T}"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        public T InvokeAny<T, Arg0ExtendsJava_Util_Concurrent_Callable_T_>(Java.Util.Collection<Arg0ExtendsJava_Util_Concurrent_Callable_T_> arg0) where Arg0ExtendsJava_Util_Concurrent_Callable_T_ : Java.Util.Concurrent.Callable<T>
        {
            return IExecuteWithSignature<T>("invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#awaitTermination(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool AwaitTermination(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<bool>("awaitTermination", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#isShutdown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsShutdown()
        {
            return IExecuteWithSignature<bool>("isShutdown", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#isTerminated()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTerminated()
        {
            return IExecuteWithSignature<bool>("isTerminated", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#submit(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<object> Submit(Java.Lang.Runnable arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<object>>("submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#shutdownNow()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.Runnable> ShutdownNow()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.Runnable>>("shutdownNow", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ExecutorService.html#shutdown()"/>
        /// </summary>
        public void Shutdown()
        {
            IExecuteWithSignature("shutdown", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}