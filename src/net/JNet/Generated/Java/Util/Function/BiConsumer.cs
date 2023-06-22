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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region BiConsumer
    public partial class BiConsumer
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
        /// Handlers initializer for <see cref="BiConsumer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("accept", new System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(AcceptEventHandler)); OnAccept = Accept;
            AddEventHandler("andThen", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.BiConsumer>>>(AndThenEventHandler)); OnAndThen = AndThen;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiConsumer.html#accept(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        public System.Action<object, object> OnAccept { get; set; }

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            if (OnAccept != null) OnAccept.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiConsumer.html#accept(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public virtual void Accept(object arg0, object arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiConsumer.html#andThen(java.util.function.BiConsumer)"/>
        /// </summary>
        public System.Func<Java.Util.Function.BiConsumer, Java.Util.Function.BiConsumer> OnAndThen { get; set; }

        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.BiConsumer>> data)
        {
            if (OnAndThen != null)
            {
                var executionResult = OnAndThen.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiConsumer.html#andThen(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.BiConsumer"/></returns>
        public virtual Java.Util.Function.BiConsumer AndThen(Java.Util.Function.BiConsumer arg0)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IBiConsumer<T, U>
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.BiConsumer implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiConsumer.html"/>
    /// </summary>
    public partial interface IBiConsumer<T, U>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiConsumer.html#accept(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        void Accept(T arg0, U arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiConsumer.html#andThen(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"></typeparam>
        /// <returns><see cref="Java.Util.Function.BiConsumer"/></returns>
        Java.Util.Function.BiConsumer<T, U> AndThen<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiConsumer<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT: T;

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BiConsumer<T, U>
    public partial class BiConsumer<T, U> : Java.Util.Function.IBiConsumer<T, U>
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
        /// Handlers initializer for <see cref="BiConsumer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("accept", new System.EventHandler<CLRListenerEventArgs<CLREventData<T>>>(AcceptEventHandler)); OnAccept = Accept;
            AddEventHandler("andThen", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.BiConsumer<Arg0objectSuperT, Arg0objectSuperU>>>>(AndThen<Arg0objectSuperT, Arg0objectSuperU>EventHandler)); OnAndThen<Arg0objectSuperT, Arg0objectSuperU> = AndThen<Arg0objectSuperT, Arg0objectSuperU>;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiConsumer.html#accept(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        public System.Action<T, U> OnAccept { get; set; }

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            if (OnAccept != null) OnAccept.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<U>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiConsumer.html#accept(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        public virtual void Accept(T arg0, U arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiConsumer.html#andThen(java.util.function.BiConsumer)"/>
        /// </summary>
        public System.Func<Java.Util.Function.BiConsumer<Arg0objectSuperT, Arg0objectSuperU>, Java.Util.Function.BiConsumer<T, U>> OnAndThen<Arg0objectSuperT, Arg0objectSuperU> { get; set; }

        void AndThen<Arg0objectSuperT, Arg0objectSuperU>EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.BiConsumer<Arg0objectSuperT, Arg0objectSuperU>>> data)
        {
            if (OnAndThen<Arg0objectSuperT, Arg0objectSuperU> != null)
            {
                var executionResult = OnAndThen<Arg0objectSuperT, Arg0objectSuperU>.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiConsumer.html#andThen(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"></typeparam>
        /// <returns><see cref="Java.Util.Function.BiConsumer"/></returns>
        public virtual Java.Util.Function.BiConsumer<T, U> AndThen<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiConsumer<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT: T
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}