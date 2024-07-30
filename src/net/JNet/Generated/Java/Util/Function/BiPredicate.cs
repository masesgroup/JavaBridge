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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region BiPredicate
    public partial class BiPredicate
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
        /// Handlers initializer for <see cref="BiPredicate"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("test", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(TestEventHandler));
            AddEventHandler("and", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.BiPredicate>>>(AndEventHandler));
            AddEventHandler("negate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(NegateEventHandler));
            AddEventHandler("or", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.BiPredicate>>>(OrEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTest"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<object, object, bool> OnTest { get; set; } = null;

        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            var methodToExecute = (OnTest != null) ? OnTest : Test;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Test(object arg0, object arg1)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiPredicate AndDefault(Java.Util.Function.BiPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicate>("andDefault", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAnd"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.BiPredicate, Java.Util.Function.BiPredicate> OnAnd { get; set; } = null;

        void AndEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.BiPredicate>> data)
        {
            var methodToExecute = (OnAnd != null) ? OnAnd : And;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiPredicate And(Java.Util.Function.BiPredicate arg0)
        {
            return AndDefault(arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiPredicate NegateDefault()
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicate>("negateDefault", "()Ljava/util/function/BiPredicate;");
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNegate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.BiPredicate> OnNegate { get; set; } = null;

        void NegateEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnNegate != null) ? OnNegate : Negate;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="NegateDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiPredicate Negate()
        {
            return NegateDefault();
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiPredicate OrDefault(Java.Util.Function.BiPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicate>("orDefault", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOr"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.BiPredicate, Java.Util.Function.BiPredicate> OnOr { get; set; } = null;

        void OrEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.BiPredicate>> data)
        {
            var methodToExecute = (OnOr != null) ? OnOr : Or;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OrDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiPredicate Or(Java.Util.Function.BiPredicate arg0)
        {
            return OrDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BiPredicateDirect
    public partial class BiPredicateDirect
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Test(object arg0, object arg1)
        {
            return IExecute<bool>("test", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public override Java.Util.Function.BiPredicate And(Java.Util.Function.BiPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect, Java.Util.Function.BiPredicate>("and", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public override Java.Util.Function.BiPredicate Negate()
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect, Java.Util.Function.BiPredicate>("negate", "()Ljava/util/function/BiPredicate;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public override Java.Util.Function.BiPredicate Or(Java.Util.Function.BiPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect, Java.Util.Function.BiPredicate>("or", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IBiPredicate<T, U>
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.BiPredicate implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html"/>
    /// </summary>
    public partial interface IBiPredicate<T, U>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Test(T arg0, U arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        Java.Util.Function.BiPredicate<T, U> And<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        Java.Util.Function.BiPredicate<T, U> Negate();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        Java.Util.Function.BiPredicate<T, U> Or<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U;

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BiPredicate<T, U>
    public partial class BiPredicate<T, U> : Java.Util.Function.IBiPredicate<T, U>
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
        /// Handlers initializer for <see cref="BiPredicate"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("test", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<T>>>(TestEventHandler));
            AddEventHandler("and", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU>>>>(And<Arg0objectSuperT, Arg0objectSuperU>EventHandler));
            AddEventHandler("negate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(NegateEventHandler));
            AddEventHandler("or", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU>>>>(Or<Arg0objectSuperT, Arg0objectSuperU>EventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTest"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<T, U, bool> OnTest { get; set; } = null;

        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            var methodToExecute = (OnTest != null) ? OnTest : Test;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<U>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Test(T arg0, U arg1)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiPredicate<T, U> And<Arg0objectSuperT, Arg0objectSuperU>Default(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicate<T, U>>("andDefault", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAnd<Arg0objectSuperT, Arg0objectSuperU>"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU>, Java.Util.Function.BiPredicate<T, U>> OnAnd<Arg0objectSuperT, Arg0objectSuperU> { get; set; } = null;

        void And<Arg0objectSuperT, Arg0objectSuperU>EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU>>> data)
        {
            var methodToExecute = (OnAnd<Arg0objectSuperT, Arg0objectSuperU> != null) ? OnAnd<Arg0objectSuperT, Arg0objectSuperU> : And<Arg0objectSuperT, Arg0objectSuperU>;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="And<Arg0objectSuperT, Arg0objectSuperU>Default"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiPredicate<T, U> And<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U
        {
            return And<Arg0objectSuperT, Arg0objectSuperU>Default(arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiPredicate<T, U> NegateDefault()
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicate<T, U>>("negateDefault", "()Ljava/util/function/BiPredicate;");
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNegate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.BiPredicate<T, U>> OnNegate { get; set; } = null;

        void NegateEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnNegate != null) ? OnNegate : Negate;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="NegateDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiPredicate<T, U> Negate()
        {
            return NegateDefault();
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiPredicate<T, U> Or<Arg0objectSuperT, Arg0objectSuperU>Default(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicate<T, U>>("orDefault", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOr<Arg0objectSuperT, Arg0objectSuperU>"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU>, Java.Util.Function.BiPredicate<T, U>> OnOr<Arg0objectSuperT, Arg0objectSuperU> { get; set; } = null;

        void Or<Arg0objectSuperT, Arg0objectSuperU>EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU>>> data)
        {
            var methodToExecute = (OnOr<Arg0objectSuperT, Arg0objectSuperU> != null) ? OnOr<Arg0objectSuperT, Arg0objectSuperU> : Or<Arg0objectSuperT, Arg0objectSuperU>;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="Or<Arg0objectSuperT, Arg0objectSuperU>Default"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiPredicate<T, U> Or<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U
        {
            return Or<Arg0objectSuperT, Arg0objectSuperU>Default(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BiPredicateDirect<T, U>
    public partial class BiPredicateDirect<T, U> : Java.Util.Function.IBiPredicate<T, U>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Test(T arg0, U arg1)
        {
            return IExecute<bool>("test", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public override Java.Util.Function.BiPredicate<T, U> And<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect<T, U>, Java.Util.Function.BiPredicate<T, U>>("and", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public override Java.Util.Function.BiPredicate<T, U> Negate()
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect<T, U>, Java.Util.Function.BiPredicate<T, U>>("negate", "()Ljava/util/function/BiPredicate;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public override Java.Util.Function.BiPredicate<T, U> Or<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect<T, U>, Java.Util.Function.BiPredicate<T, U>>("or", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}