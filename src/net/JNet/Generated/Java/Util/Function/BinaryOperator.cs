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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region BinaryOperator declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BinaryOperator.html"/>
    /// </summary>
    public partial class BinaryOperator : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BinaryOperator() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.util.function.BinaryOperator";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region BinaryOperatorDirect declaration
    /// <summary>
    /// Direct override of <see cref="BinaryOperator"/> or its generic type if there is one
    /// </summary>
    public partial class BinaryOperatorDirect : BinaryOperator
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.util.function.BinaryOperator";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
    }
    #endregion

    #region BinaryOperator<T> declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BinaryOperator.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class BinaryOperator<T> : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BinaryOperator() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.util.function.BinaryOperator";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class
    
    }
    #endregion

    #region BinaryOperatorDirect<T> declaration
    /// <summary>
    /// Direct override of <see cref="BinaryOperator"/> or its generic type if there is one
    /// </summary>
    public partial class BinaryOperatorDirect<T> : BinaryOperator<T>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.util.function.BinaryOperator";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
    }
    #endregion

    #region BinaryOperator implementation
    public partial class BinaryOperator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BinaryOperator.html#maxBy(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        /// <returns><see cref="Java.Util.Function.BinaryOperator"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static Java.Util.Function.BinaryOperator MaxBy(Java.Util.Comparator arg0)
        {
            return SExecuteWithSignature<Java.Util.Function.BinaryOperator>(LocalBridgeClazz, "maxBy", "(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BinaryOperator.html#minBy(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        /// <returns><see cref="Java.Util.Function.BinaryOperator"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static Java.Util.Function.BinaryOperator MinBy(Java.Util.Comparator arg0)
        {
            return SExecuteWithSignature<Java.Util.Function.BinaryOperator>(LocalBridgeClazz, "minBy", "(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="BinaryOperator"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("apply", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ApplyEventHandler));
            AddEventHandler("andThen", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AndThenEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#apply(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApply"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<object, object, object> OnApply { get; set; } = null;

        bool hasOverrideApply = true;
        void ApplyEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideApply = true;
            var methodToExecute = (OnApply != null) ? OnApply : Apply;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<object>(0), data.EventData.GetAt<object>(1));
            data.EventData.TypedEventData.SetReturnData(hasOverrideApply, executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#apply(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public virtual object Apply(object arg0, object arg1)
        {
            hasOverrideApply = false; return default;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Function.BiFunction"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiFunction AndThenDefault(Java.Util.Function.Function arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.BiFunction>("andThenDefault", "(Ljava/util/function/Function;)Ljava/util/function/BiFunction;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.Function, Java.Util.Function.BiFunction> OnAndThen { get; set; } = null;

        bool hasOverrideAndThen = true;
        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAndThen = true;
            var methodToExecute = (OnAndThen != null) ? OnAndThen : AndThen;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.Function>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideAndThen, executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Function.BiFunction"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThenDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiFunction AndThen(Java.Util.Function.Function arg0)
        {
            hasOverrideAndThen = false; return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BinaryOperatorDirect implementation
    public partial class BinaryOperatorDirect
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#apply(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public override object Apply(object arg0, object arg1)
        {
            return IExecuteWithSignature("apply", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Function.BiFunction"/></returns>
        public override Java.Util.Function.BiFunction AndThen(Java.Util.Function.Function arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.BiFunctionDirect, Java.Util.Function.BiFunction>("andThen", "(Ljava/util/function/Function;)Ljava/util/function/BiFunction;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IBinaryOperator<T>
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.BinaryOperator implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BinaryOperator.html"/>
    /// </summary>
    public partial interface IBinaryOperator<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#apply(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        R Apply<R, U>(T arg0, U arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0objectSuperR"><typeparamref name="R"/></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="Arg0ExtendsV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiFunction"/></returns>
        Java.Util.Function.BiFunction<T, U, V> AndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>(Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV> arg0) where Arg0objectSuperR : R where Arg0ExtendsV : V;

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BinaryOperator<T> implementation
    public partial class BinaryOperator<T> : Java.Util.Function.IBinaryOperator<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BinaryOperator.html#maxBy(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BinaryOperator"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static Java.Util.Function.BinaryOperator<T> MaxBy<Arg0objectSuperT>(Java.Util.Comparator<Arg0objectSuperT> arg0) where Arg0objectSuperT : T
        {
            return SExecuteWithSignature<Java.Util.Function.BinaryOperator<T>>(LocalBridgeClazz, "maxBy", "(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BinaryOperator.html#minBy(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BinaryOperator"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static Java.Util.Function.BinaryOperator<T> MinBy<Arg0objectSuperT>(Java.Util.Comparator<Arg0objectSuperT> arg0) where Arg0objectSuperT : T
        {
            return SExecuteWithSignature<Java.Util.Function.BinaryOperator<T>>(LocalBridgeClazz, "minBy", "(Ljava/util/Comparator;)Ljava/util/function/BinaryOperator;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="BinaryOperator"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("apply", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(Apply<R, U>EventHandler));
            AddEventHandler("andThen", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>EventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#apply(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApply<R, U>"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<T, U, R> OnApply<R, U> { get; set; } = null;

        bool hasOverrideApply<R, U> = true;
        void Apply<R, U>EventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideApply<R, U> = true;
            var methodToExecute = (OnApply<R, U> != null) ? OnApply<R, U> : Apply<R, U>;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<T>(0), data.EventData.GetAt<U>(1));
            data.EventData.TypedEventData.SetReturnData(hasOverrideApply<R, U>, executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#apply(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public virtual R Apply<R, U>(T arg0, U arg1)
        {
            hasOverrideApply<R, U> = false; return default;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0objectSuperR"><typeparamref name="R"/></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="Arg0ExtendsV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiFunction"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiFunction<T, U, V> AndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>Default(Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV> arg0) where Arg0objectSuperR : R where Arg0ExtendsV : V
        {
            return IExecuteWithSignature<Java.Util.Function.BiFunction<T, U, V>>("andThenDefault", "(Ljava/util/function/Function;)Ljava/util/function/BiFunction;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV>, Java.Util.Function.BiFunction<T, U, V>> OnAndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV> { get; set; } = null;

        bool hasOverrideAndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV> = true;
        void AndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>EventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV> = true;
            var methodToExecute = (OnAndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV> != null) ? OnAndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV> : AndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV>>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideAndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>, executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0objectSuperR"><typeparamref name="R"/></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="Arg0ExtendsV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiFunction"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>Default"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiFunction<T, U, V> AndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>(Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV> arg0) where Arg0objectSuperR : R where Arg0ExtendsV : V
        {
            hasOverrideAndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV> = false; return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BinaryOperatorDirect<T> implementation
    public partial class BinaryOperatorDirect<T> : Java.Util.Function.IBinaryOperator<T>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#apply(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public override R Apply<R, U>(T arg0, U arg1)
        {
            return IExecuteWithSignature<R>("apply", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0objectSuperR"><typeparamref name="R"/></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="Arg0ExtendsV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiFunction"/></returns>
        public override Java.Util.Function.BiFunction<T, U, V> AndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>(Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV> arg0) where Arg0objectSuperR : R where Arg0ExtendsV : V
        {
            return IExecuteWithSignature<Java.Util.Function.BiFunctionDirect<T, U, V>, Java.Util.Function.BiFunction<T, U, V>>("andThen", "(Ljava/util/function/Function;)Ljava/util/function/BiFunction;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}