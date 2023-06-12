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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Math
{
    #region RoundingMode
    public partial class RoundingMode
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#CEILING"/>
        /// </summary>
        public static Java.Math.RoundingMode CEILING { get { return SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "CEILING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#DOWN"/>
        /// </summary>
        public static Java.Math.RoundingMode DOWN { get { return SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "DOWN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#FLOOR"/>
        /// </summary>
        public static Java.Math.RoundingMode FLOOR { get { return SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "FLOOR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#HALF_DOWN"/>
        /// </summary>
        public static Java.Math.RoundingMode HALF_DOWN { get { return SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "HALF_DOWN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#HALF_EVEN"/>
        /// </summary>
        public static Java.Math.RoundingMode HALF_EVEN { get { return SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "HALF_EVEN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#HALF_UP"/>
        /// </summary>
        public static Java.Math.RoundingMode HALF_UP { get { return SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "HALF_UP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#UNNECESSARY"/>
        /// </summary>
        public static Java.Math.RoundingMode UNNECESSARY { get { return SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "UNNECESSARY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#UP"/>
        /// </summary>
        public static Java.Math.RoundingMode UP { get { return SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "UP"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#valueOf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.RoundingMode"/></returns>
        public static Java.Math.RoundingMode ValueOf(int arg0)
        {
            return SExecute<Java.Math.RoundingMode>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Math.RoundingMode"/></returns>
        public static Java.Math.RoundingMode ValueOf(string arg0)
        {
            return SExecute<Java.Math.RoundingMode>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Math.RoundingMode"/></returns>
        public static Java.Math.RoundingMode[] Values()
        {
            return SExecuteArray<Java.Math.RoundingMode>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}