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

namespace Java.Util
{
    #region OptionalDouble
    public partial class OptionalDouble
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalDouble.html#empty()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.OptionalDouble"/></returns>
        public static Java.Util.OptionalDouble Empty()
        {
            return SExecute<Java.Util.OptionalDouble>(LocalBridgeClazz, "empty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalDouble.html#of(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Util.OptionalDouble"/></returns>
        public static Java.Util.OptionalDouble Of(double arg0)
        {
            return SExecute<Java.Util.OptionalDouble>(LocalBridgeClazz, "of", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalDouble.html#getAsDouble()"/> 
        /// </summary>
        public double AsDouble
        {
            get { return IExecute<double>("getAsDouble"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalDouble.html#orElseThrow(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <typeparam name="Arg0ExtendsX"><typeparamref name="X"/></typeparam>
        /// <typeparam name="X"></typeparam>
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public double OrElseThrow<Arg0ExtendsX, X>(Java.Util.Function.Supplier<Arg0ExtendsX> arg0) where Arg0ExtendsX: X
        {
            return IExecute<double>("orElseThrow", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalDouble.html#isEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalDouble.html#isPresent()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPresent()
        {
            return IExecute<bool>("isPresent");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalDouble.html#orElse(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double OrElse(double arg0)
        {
            return IExecute<double>("orElse", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalDouble.html#orElseGet(java.util.function.DoubleSupplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleSupplier"/></param>
        /// <returns><see cref="double"/></returns>
        public double OrElseGet(Java.Util.Function.DoubleSupplier arg0)
        {
            return IExecute<double>("orElseGet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalDouble.html#orElseThrow()"/>
        /// </summary>

        /// <returns><see cref="double"/></returns>
        public double OrElseThrow()
        {
            return IExecute<double>("orElseThrow");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalDouble.html#stream()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Stream()
        {
            return IExecute<Java.Util.Stream.DoubleStream>("stream");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalDouble.html#ifPresent(java.util.function.DoubleConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleConsumer"/></param>
        public void IfPresent(Java.Util.Function.DoubleConsumer arg0)
        {
            IExecute("ifPresent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalDouble.html#ifPresentOrElse(java.util.function.DoubleConsumer,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleConsumer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        public void IfPresentOrElse(Java.Util.Function.DoubleConsumer arg0, Java.Lang.Runnable arg1)
        {
            IExecute("ifPresentOrElse", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}