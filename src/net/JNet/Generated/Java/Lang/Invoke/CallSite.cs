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

namespace Java.Lang.Invoke
{
    #region CallSite
    public partial class CallSite
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/CallSite.html#getTarget()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/CallSite.html#setTarget(java.lang.invoke.MethodHandle)"/>
        /// </summary>
        public Java.Lang.Invoke.MethodHandle Target
        {
            get { return IExecuteWithSignature<Java.Lang.Invoke.MethodHandle>("getTarget", "()Ljava/lang/invoke/MethodHandle;"); } set { IExecuteWithSignature("setTarget", "(Ljava/lang/invoke/MethodHandle;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/CallSite.html#dynamicInvoker()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle DynamicInvoker()
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodHandle>("dynamicInvoker", "()Ljava/lang/invoke/MethodHandle;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/CallSite.html#type()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType Type()
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("type", "()Ljava/lang/invoke/MethodType;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}