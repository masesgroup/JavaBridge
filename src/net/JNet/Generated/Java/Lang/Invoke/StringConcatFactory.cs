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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Invoke
{
    #region StringConcatFactory
    public partial class StringConcatFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/StringConcatFactory.html#makeConcat(java.lang.invoke.MethodHandles.Lookup,java.lang.String,java.lang.invoke.MethodType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Invoke.MethodType"/></param>
        /// <returns><see cref="Java.Lang.Invoke.CallSite"/></returns>
        /// <exception cref="Java.Lang.Invoke.StringConcatException"/>
        public static Java.Lang.Invoke.CallSite MakeConcat(Java.Lang.Invoke.MethodHandles.Lookup arg0, Java.Lang.String arg1, Java.Lang.Invoke.MethodType arg2)
        {
            return SExecute<Java.Lang.Invoke.CallSite>(LocalBridgeClazz, "makeConcat", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/StringConcatFactory.html#makeConcatWithConstants(java.lang.invoke.MethodHandles.Lookup,java.lang.String,java.lang.invoke.MethodType,java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Invoke.MethodType"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.Invoke.CallSite"/></returns>
        /// <exception cref="Java.Lang.Invoke.StringConcatException"/>
        public static Java.Lang.Invoke.CallSite MakeConcatWithConstants(Java.Lang.Invoke.MethodHandles.Lookup arg0, Java.Lang.String arg1, Java.Lang.Invoke.MethodType arg2, Java.Lang.String arg3, params object[] arg4)
        {
            if (arg4.Length == 0) return SExecute<Java.Lang.Invoke.CallSite>(LocalBridgeClazz, "makeConcatWithConstants", arg0, arg1, arg2, arg3); else return SExecute<Java.Lang.Invoke.CallSite>(LocalBridgeClazz, "makeConcatWithConstants", arg0, arg1, arg2, arg3, arg4);
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