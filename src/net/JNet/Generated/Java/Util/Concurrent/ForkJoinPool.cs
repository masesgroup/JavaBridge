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
    #region ForkJoinPool declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html"/>
    /// </summary>
    public partial class ForkJoinPool : Java.Util.Concurrent.AbstractExecutorService
    {
        const string _bridgeClassName = "java.util.concurrent.ForkJoinPool";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ForkJoinPool() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ForkJoinPool(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region ForkJoinWorkerThreadFactory declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.ForkJoinWorkerThreadFactory.html"/>
        /// </summary>
        public partial class ForkJoinWorkerThreadFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ForkJoinWorkerThreadFactory>
        {
            const string _bridgeClassName = "java.util.concurrent.ForkJoinPool$ForkJoinWorkerThreadFactory";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("ForkJoinWorkerThreadFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public ForkJoinWorkerThreadFactory() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("ForkJoinWorkerThreadFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public ForkJoinWorkerThreadFactory(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region ManagedBlocker declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.ManagedBlocker.html"/>
        /// </summary>
        public partial class ManagedBlocker : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ManagedBlocker>
        {
            const string _bridgeClassName = "java.util.concurrent.ForkJoinPool$ManagedBlocker";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("ManagedBlocker class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public ManagedBlocker() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("ManagedBlocker class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public ManagedBlocker(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region ForkJoinPool implementation
    public partial class ForkJoinPool
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public ForkJoinPool(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#defaultForkJoinWorkerThreadFactory"/>
        /// </summary>
        public static Java.Util.Concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory defaultForkJoinWorkerThreadFactory { get { if (!_defaultForkJoinWorkerThreadFactoryReady) { _defaultForkJoinWorkerThreadFactoryContent = SGetField<Java.Util.Concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory>(LocalBridgeClazz, "defaultForkJoinWorkerThreadFactory"); _defaultForkJoinWorkerThreadFactoryReady = true; } return _defaultForkJoinWorkerThreadFactoryContent; } }
        private static Java.Util.Concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory _defaultForkJoinWorkerThreadFactoryContent = default;
        private static bool _defaultForkJoinWorkerThreadFactoryReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#getCommonPoolParallelism()"/> 
        /// </summary>
        public static int CommonPoolParallelism
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getCommonPoolParallelism", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#commonPool()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinPool"/></returns>
        public static Java.Util.Concurrent.ForkJoinPool CommonPool()
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ForkJoinPool>(LocalBridgeClazz, "commonPool", "()Ljava/util/concurrent/ForkJoinPool;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#managedBlock(java.util.concurrent.ForkJoinPool.ManagedBlocker)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ForkJoinPool.ManagedBlocker"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public static void ManagedBlock(Java.Util.Concurrent.ForkJoinPool.ManagedBlocker arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "managedBlock", "(Ljava/util/concurrent/ForkJoinPool$ManagedBlocker;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#getActiveThreadCount()"/> 
        /// </summary>
        public int ActiveThreadCount
        {
            get { return IExecuteWithSignature<int>("getActiveThreadCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#getAsyncMode()"/> 
        /// </summary>
        public bool AsyncMode
        {
            get { return IExecuteWithSignature<bool>("getAsyncMode", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#getFactory()"/> 
        /// </summary>
        public Java.Util.Concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory Factory
        {
            get { return IExecuteWithSignature<Java.Util.Concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory>("getFactory", "()Ljava/util/concurrent/ForkJoinPool$ForkJoinWorkerThreadFactory;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#getParallelism()"/> 
        /// </summary>
        public int Parallelism
        {
            get { return IExecuteWithSignature<int>("getParallelism", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#getPoolSize()"/> 
        /// </summary>
        public int PoolSize
        {
            get { return IExecuteWithSignature<int>("getPoolSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#getQueuedSubmissionCount()"/> 
        /// </summary>
        public int QueuedSubmissionCount
        {
            get { return IExecuteWithSignature<int>("getQueuedSubmissionCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#getQueuedTaskCount()"/> 
        /// </summary>
        public long QueuedTaskCount
        {
            get { return IExecuteWithSignature<long>("getQueuedTaskCount", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#getRunningThreadCount()"/> 
        /// </summary>
        public int RunningThreadCount
        {
            get { return IExecuteWithSignature<int>("getRunningThreadCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#getStealCount()"/> 
        /// </summary>
        public long StealCount
        {
            get { return IExecuteWithSignature<long>("getStealCount", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#submit(java.util.concurrent.ForkJoinTask)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public Java.Util.Concurrent.ForkJoinTask<T> Submit<T>(Java.Util.Concurrent.ForkJoinTask<T> arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.ForkJoinTask<T>>("submit", "(Ljava/util/concurrent/ForkJoinTask;)Ljava/util/concurrent/ForkJoinTask;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#invoke(java.util.concurrent.ForkJoinTask)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T Invoke<T>(Java.Util.Concurrent.ForkJoinTask<T> arg0)
        {
            return IExecuteWithSignature<T>("invoke", "(Ljava/util/concurrent/ForkJoinTask;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#awaitQuiescence(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AwaitQuiescence(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<bool>("awaitQuiescence", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#hasQueuedSubmissions()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasQueuedSubmissions()
        {
            return IExecuteWithSignature<bool>("hasQueuedSubmissions", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#isQuiescent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsQuiescent()
        {
            return IExecuteWithSignature<bool>("isQuiescent", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#isTerminating()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTerminating()
        {
            return IExecuteWithSignature<bool>("isTerminating", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#execute(java.util.concurrent.ForkJoinTask)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        public void Execute(Java.Util.Concurrent.ForkJoinTask<object> arg0)
        {
            IExecuteWithSignature("execute", "(Ljava/util/concurrent/ForkJoinTask;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region ForkJoinWorkerThreadFactory implementation
        public partial class ForkJoinWorkerThreadFactory
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.ForkJoinWorkerThreadFactory.html#newThread(java.util.concurrent.ForkJoinPool)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Concurrent.ForkJoinPool"/></param>
            /// <returns><see cref="Java.Util.Concurrent.ForkJoinWorkerThread"/></returns>
            public Java.Util.Concurrent.ForkJoinWorkerThread NewThread(Java.Util.Concurrent.ForkJoinPool arg0)
            {
                return IExecuteWithSignature<Java.Util.Concurrent.ForkJoinWorkerThread>("newThread", "(Ljava/util/concurrent/ForkJoinPool;)Ljava/util/concurrent/ForkJoinWorkerThread;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ManagedBlocker implementation
        public partial class ManagedBlocker
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.ManagedBlocker.html#block()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public bool Block()
            {
                return IExecuteWithSignature<bool>("block", "()Z");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.ManagedBlocker.html#isReleasable()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsReleasable()
            {
                return IExecuteWithSignature<bool>("isReleasable", "()Z");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}