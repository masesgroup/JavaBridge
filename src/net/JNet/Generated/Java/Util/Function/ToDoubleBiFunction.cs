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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region ToDoubleBiFunction
    public partial class ToDoubleBiFunction
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
        /// Handlers initializer for <see cref="ToDoubleBiFunction"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsDouble", new System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(ApplyAsDoubleEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ToDoubleBiFunction.html#applyAsDouble(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsDouble"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<object, object, double> OnApplyAsDouble { get; set; } = null;

        void ApplyAsDoubleEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            var methodToExecute = (OnApplyAsDouble != null) ? OnApplyAsDouble : ApplyAsDouble;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ToDoubleBiFunction.html#applyAsDouble(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="double"/></returns>
        public virtual double ApplyAsDouble(object arg0, object arg1)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IToDoubleBiFunction<T, U>
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.ToDoubleBiFunction implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ToDoubleBiFunction.html"/>
    /// </summary>
    public partial interface IToDoubleBiFunction<T, U>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ToDoubleBiFunction.html#applyAsDouble(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <returns><see cref="double"/></returns>
        double ApplyAsDouble(T arg0, U arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ToDoubleBiFunction<T, U>
    public partial class ToDoubleBiFunction<T, U> : Java.Util.Function.IToDoubleBiFunction<T, U>
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
        /// Handlers initializer for <see cref="ToDoubleBiFunction"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsDouble", new System.EventHandler<CLRListenerEventArgs<CLREventData<T>>>(ApplyAsDoubleEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ToDoubleBiFunction.html#applyAsDouble(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsDouble"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<T, U, double> OnApplyAsDouble { get; set; } = null;

        void ApplyAsDoubleEventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            var methodToExecute = (OnApplyAsDouble != null) ? OnApplyAsDouble : ApplyAsDouble;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<U>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ToDoubleBiFunction.html#applyAsDouble(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <returns><see cref="double"/></returns>
        public virtual double ApplyAsDouble(T arg0, U arg1)
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