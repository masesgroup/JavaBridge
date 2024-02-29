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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region IDoubleToLongFunction
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.DoubleToLongFunction implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleToLongFunction.html"/>
    /// </summary>
    public partial interface IDoubleToLongFunction
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleToLongFunction.html#applyAsLong(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="long"/></returns>
        long ApplyAsLong(double arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DoubleToLongFunction
    public partial class DoubleToLongFunction : Java.Util.Function.IDoubleToLongFunction
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
        /// Handlers initializer for <see cref="DoubleToLongFunction"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsLong", new System.EventHandler<CLRListenerEventArgs<CLREventData<double>>>(ApplyAsLongEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleToLongFunction.html#applyAsLong(double)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsLong"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<double, long> OnApplyAsLong { get; set; } = null;

        void ApplyAsLongEventHandler(object sender, CLRListenerEventArgs<CLREventData<double>> data)
        {
            var methodToExecute = (OnApplyAsLong != null) ? OnApplyAsLong : ApplyAsLong;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleToLongFunction.html#applyAsLong(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="long"/></returns>
        public virtual long ApplyAsLong(double arg0)
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