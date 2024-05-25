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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region UnaryOperator
    public partial class UnaryOperator
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
        /// Handlers initializer for <see cref="UnaryOperator"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("apply", new System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(ApplyEventHandler));
            AddEventHandler("andThen", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.Function>>>(AndThenEventHandler));
            AddEventHandler("compose", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.Function>>>(ComposeEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#apply(java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApply"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<object, object> OnApply { get; set; } = null;

        void ApplyEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            var methodToExecute = (OnApply != null) ? OnApply : Apply;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#apply(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public virtual object Apply(object arg0)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.Function AndThenDefault(Java.Util.Function.Function arg0)
        {
            return IExecute<Java.Util.Function.Function>("andThenDefault", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.Function, Java.Util.Function.Function> OnAndThen { get; set; } = null;

        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.Function>> data)
        {
            var methodToExecute = (OnAndThen != null) ? OnAndThen : AndThen;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThenDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.Function AndThen(Java.Util.Function.Function arg0)
        {
            return AndThenDefault(arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#compose(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.Function ComposeDefault(Java.Util.Function.Function arg0)
        {
            return IExecute<Java.Util.Function.Function>("composeDefault", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#compose(java.util.function.Function)"/>
        /// </summary>
        /// <remarks>If <see cref="OnCompose"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.Function, Java.Util.Function.Function> OnCompose { get; set; } = null;

        void ComposeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.Function>> data)
        {
            var methodToExecute = (OnCompose != null) ? OnCompose : Compose;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#compose(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ComposeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.Function Compose(Java.Util.Function.Function arg0)
        {
            return ComposeDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UnaryOperatorDirect
    public partial class UnaryOperatorDirect
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#apply(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public override object Apply(object arg0)
        {
            return IExecute("apply", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public override Java.Util.Function.Function AndThen(Java.Util.Function.Function arg0)
        {
            return IExecute<Java.Util.Function.FunctionDirect, Java.Util.Function.Function>("andThen", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#compose(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public override Java.Util.Function.Function Compose(Java.Util.Function.Function arg0)
        {
            return IExecute<Java.Util.Function.FunctionDirect, Java.Util.Function.Function>("compose", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IUnaryOperator<T>
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.UnaryOperator implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/UnaryOperator.html"/>
    /// </summary>
    public partial interface IUnaryOperator<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#apply(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        R Apply<R>(T arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0objectSuperR"><typeparamref name="R"/></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="Arg0ExtendsV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        Java.Util.Function.Function<T, V> AndThen<V, Arg0objectSuperR, R, Arg0ExtendsV>(Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV> arg0) where Arg0objectSuperR: R where Arg0ExtendsV: V;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#compose(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="Arg0objectSuperV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        Java.Util.Function.Function<V, R> Compose<V, R, Arg0objectSuperV, Arg0ExtendsT>(Java.Util.Function.Function<Arg0objectSuperV, Arg0ExtendsT> arg0) where Arg0objectSuperV: V where Arg0ExtendsT: T;

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UnaryOperator<T>
    public partial class UnaryOperator<T> : Java.Util.Function.IUnaryOperator<T>
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
        /// Handlers initializer for <see cref="UnaryOperator"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("apply", new System.EventHandler<CLRListenerEventArgs<CLREventData<T>>>(Apply<R>EventHandler));
            AddEventHandler("andThen", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV>>>>(AndThen<V, Arg0objectSuperR, R, Arg0ExtendsV>EventHandler));
            AddEventHandler("compose", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.Function<Arg0objectSuperV, Arg0ExtendsT>>>>(Compose<V, R, Arg0objectSuperV, Arg0ExtendsT>EventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#apply(java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApply<R>"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<T, R> OnApply<R> { get; set; } = null;

        void Apply<R>EventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            var methodToExecute = (OnApply<R> != null) ? OnApply<R> : Apply<R>;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#apply(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public virtual R Apply<R>(T arg0)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0objectSuperR"><typeparamref name="R"/></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="Arg0ExtendsV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.Function<T, V> AndThen<V, Arg0objectSuperR, R, Arg0ExtendsV>Default(Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV> arg0) where Arg0objectSuperR: R where Arg0ExtendsV: V
        {
            return IExecute<Java.Util.Function.Function<T, V>>("andThenDefault", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen<V, Arg0objectSuperR, R, Arg0ExtendsV>"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV>, Java.Util.Function.Function<T, V>> OnAndThen<V, Arg0objectSuperR, R, Arg0ExtendsV> { get; set; } = null;

        void AndThen<V, Arg0objectSuperR, R, Arg0ExtendsV>EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV>>> data)
        {
            var methodToExecute = (OnAndThen<V, Arg0objectSuperR, R, Arg0ExtendsV> != null) ? OnAndThen<V, Arg0objectSuperR, R, Arg0ExtendsV> : AndThen<V, Arg0objectSuperR, R, Arg0ExtendsV>;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0objectSuperR"><typeparamref name="R"/></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="Arg0ExtendsV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThen<V, Arg0objectSuperR, R, Arg0ExtendsV>Default"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.Function<T, V> AndThen<V, Arg0objectSuperR, R, Arg0ExtendsV>(Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV> arg0) where Arg0objectSuperR: R where Arg0ExtendsV: V
        {
            return AndThen<V, Arg0objectSuperR, R, Arg0ExtendsV>Default(arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#compose(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="Arg0objectSuperV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.Function<V, R> Compose<V, R, Arg0objectSuperV, Arg0ExtendsT>Default(Java.Util.Function.Function<Arg0objectSuperV, Arg0ExtendsT> arg0) where Arg0objectSuperV: V where Arg0ExtendsT: T
        {
            return IExecute<Java.Util.Function.Function<V, R>>("composeDefault", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#compose(java.util.function.Function)"/>
        /// </summary>
        /// <remarks>If <see cref="OnCompose<V, R, Arg0objectSuperV, Arg0ExtendsT>"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.Function<Arg0objectSuperV, Arg0ExtendsT>, Java.Util.Function.Function<V, R>> OnCompose<V, R, Arg0objectSuperV, Arg0ExtendsT> { get; set; } = null;

        void Compose<V, R, Arg0objectSuperV, Arg0ExtendsT>EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.Function<Arg0objectSuperV, Arg0ExtendsT>>> data)
        {
            var methodToExecute = (OnCompose<V, R, Arg0objectSuperV, Arg0ExtendsT> != null) ? OnCompose<V, R, Arg0objectSuperV, Arg0ExtendsT> : Compose<V, R, Arg0objectSuperV, Arg0ExtendsT>;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#compose(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="Arg0objectSuperV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="Compose<V, R, Arg0objectSuperV, Arg0ExtendsT>Default"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.Function<V, R> Compose<V, R, Arg0objectSuperV, Arg0ExtendsT>(Java.Util.Function.Function<Arg0objectSuperV, Arg0ExtendsT> arg0) where Arg0objectSuperV: V where Arg0ExtendsT: T
        {
            return Compose<V, R, Arg0objectSuperV, Arg0ExtendsT>Default(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UnaryOperatorDirect<T>
    public partial class UnaryOperatorDirect<T> : Java.Util.Function.IUnaryOperator<T>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#apply(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public override R Apply<R>(T arg0)
        {
            return IExecute<R>("apply", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0objectSuperR"><typeparamref name="R"/></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="Arg0ExtendsV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public override Java.Util.Function.Function<T, V> AndThen<V, Arg0objectSuperR, R, Arg0ExtendsV>(Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV> arg0) where Arg0objectSuperR: R where Arg0ExtendsV: V
        {
            return IExecute<Java.Util.Function.FunctionDirect<T, V>, Java.Util.Function.Function<T, V>>("andThen", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#compose(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="Arg0objectSuperV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public override Java.Util.Function.Function<V, R> Compose<V, R, Arg0objectSuperV, Arg0ExtendsT>(Java.Util.Function.Function<Arg0objectSuperV, Arg0ExtendsT> arg0) where Arg0objectSuperV: V where Arg0ExtendsT: T
        {
            return IExecute<Java.Util.Function.FunctionDirect<V, R>, Java.Util.Function.Function<V, R>>("compose", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}