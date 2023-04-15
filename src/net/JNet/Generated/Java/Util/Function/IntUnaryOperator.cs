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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region IntUnaryOperator
    public partial class IntUnaryOperator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntUnaryOperator.html#identity()"/> 
        /// </summary>
        public static Java.Util.Function.IntUnaryOperator Identity
        {
            get { return SExecute<Java.Util.Function.IntUnaryOperator>(LocalClazz, "identity"); }
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntUnaryOperator.html#applyAsInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ApplyAsInt(int arg0)
        {
            return IExecute<int>("applyAsInt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntUnaryOperator.html#andThen(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        public Java.Util.Function.IntUnaryOperator AndThen(Java.Util.Function.IntUnaryOperator arg0)
        {
            return IExecute<Java.Util.Function.IntUnaryOperator>("andThen", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntUnaryOperator.html#compose(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        public Java.Util.Function.IntUnaryOperator Compose(Java.Util.Function.IntUnaryOperator arg0)
        {
            return IExecute<Java.Util.Function.IntUnaryOperator>("compose", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}