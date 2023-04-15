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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Invoke
{
    #region LambdaMetafactory
    public partial class LambdaMetafactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/LambdaMetafactory.html#FLAG_BRIDGES"/>
        /// </summary>
        public static int FLAG_BRIDGES => Clazz.GetField<int>("FLAG_BRIDGES");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/LambdaMetafactory.html#FLAG_MARKERS"/>
        /// </summary>
        public static int FLAG_MARKERS => Clazz.GetField<int>("FLAG_MARKERS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/LambdaMetafactory.html#FLAG_SERIALIZABLE"/>
        /// </summary>
        public static int FLAG_SERIALIZABLE => Clazz.GetField<int>("FLAG_SERIALIZABLE");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/LambdaMetafactory.html#altMetafactory(java.lang.invoke.MethodHandles.Lookup,java.lang.String,java.lang.invoke.MethodType,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Invoke.MethodType"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.Invoke.CallSite"/></returns>
        /// <exception cref="Java.Lang.Invoke.LambdaConversionException"/>
        public static Java.Lang.Invoke.CallSite AltMetafactory(Java.Lang.Invoke.MethodHandles.Lookup arg0, string arg1, Java.Lang.Invoke.MethodType arg2, params object[] arg3)
        {
            if (arg3.Length == 0) return SExecute<Java.Lang.Invoke.CallSite>(LocalClazz, "altMetafactory", arg0, arg1, arg2); else return SExecute<Java.Lang.Invoke.CallSite>(LocalClazz, "altMetafactory", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/LambdaMetafactory.html#metafactory(java.lang.invoke.MethodHandles.Lookup,java.lang.String,java.lang.invoke.MethodType,java.lang.invoke.MethodType,java.lang.invoke.MethodHandle,java.lang.invoke.MethodType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Invoke.MethodType"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Invoke.MethodType"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Invoke.MethodHandle"/></param>
        /// <param name="arg5"><see cref="Java.Lang.Invoke.MethodType"/></param>
        /// <returns><see cref="Java.Lang.Invoke.CallSite"/></returns>
        /// <exception cref="Java.Lang.Invoke.LambdaConversionException"/>
        public static Java.Lang.Invoke.CallSite Metafactory(Java.Lang.Invoke.MethodHandles.Lookup arg0, string arg1, Java.Lang.Invoke.MethodType arg2, Java.Lang.Invoke.MethodType arg3, Java.Lang.Invoke.MethodHandle arg4, Java.Lang.Invoke.MethodType arg5)
        {
            return SExecute<Java.Lang.Invoke.CallSite>(LocalClazz, "metafactory", arg0, arg1, arg2, arg3, arg4, arg5);
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