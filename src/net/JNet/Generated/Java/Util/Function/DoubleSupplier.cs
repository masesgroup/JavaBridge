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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region IDoubleSupplier
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.DoubleSupplier implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleSupplier.html"/>
    /// </summary>
    public partial interface IDoubleSupplier
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleSupplier.html#getAsDouble()"/>
        /// </summary>

        /// <returns><see cref="double"/></returns>
        double GetAsDouble();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DoubleSupplier
    public partial class DoubleSupplier : Java.Util.Function.IDoubleSupplier
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
        /// Handlers initializer for <see cref="DoubleSupplier"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("getAsDouble", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetAsDoubleEventHandler)); OnGetAsDouble = GetAsDouble;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleSupplier.html#getAsDouble()"/>
        /// </summary>
        public System.Func<double> OnGetAsDouble { get; set; }

        void GetAsDoubleEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            if (OnGetAsDouble != null)
            {
                var executionResult = OnGetAsDouble.Invoke();
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleSupplier.html#getAsDouble()"/>
        /// </summary>

        /// <returns><see cref="double"/></returns>
        public virtual double GetAsDouble()
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