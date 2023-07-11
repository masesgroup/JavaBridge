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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region IIntBinaryOperator
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.IntBinaryOperator implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntBinaryOperator.html"/>
    /// </summary>
    public partial interface IIntBinaryOperator
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntBinaryOperator.html#applyAsInt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        int ApplyAsInt(int arg0, int arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IntBinaryOperator
    public partial class IntBinaryOperator : Java.Util.Function.IIntBinaryOperator
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
        /// Handlers initializer for <see cref="IntBinaryOperator"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsInt", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(ApplyAsIntEventHandler)); OnApplyAsInt = ApplyAsInt;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntBinaryOperator.html#applyAsInt(int,int)"/>
        /// </summary>
        public System.Func<int, int, int> OnApplyAsInt { get; set; }

        void ApplyAsIntEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            if (OnApplyAsInt != null)
            {
                var executionResult = OnApplyAsInt.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntBinaryOperator.html#applyAsInt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int ApplyAsInt(int arg0, int arg1)
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