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

namespace Java.Util.Function
{
    #region IDoubleToIntFunction
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.DoubleToIntFunction implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleToIntFunction.html"/>
    /// </summary>
    public partial interface IDoubleToIntFunction
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleToIntFunction.html#applyAsInt(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        int ApplyAsInt(double arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DoubleToIntFunction
    public partial class DoubleToIntFunction : Java.Util.Function.IDoubleToIntFunction
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
        /// Handlers initializer for <see cref="DoubleToIntFunction"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsInt", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<double>>>(ApplyAsIntEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleToIntFunction.html#applyAsInt(double)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsInt"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<double, int> OnApplyAsInt { get; set; } = null;

        void ApplyAsIntEventHandler(object sender, CLRListenerEventArgs<CLREventData<double>> data)
        {
            var methodToExecute = (OnApplyAsInt != null) ? OnApplyAsInt : ApplyAsInt;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleToIntFunction.html#applyAsInt(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int ApplyAsInt(double arg0)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DoubleToIntFunctionDirect
    public partial class DoubleToIntFunctionDirect : Java.Util.Function.IDoubleToIntFunction
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleToIntFunction.html#applyAsInt(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        public override int ApplyAsInt(double arg0)
        {
            return IExecuteWithSignature<int>("applyAsInt", "(D)I", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}