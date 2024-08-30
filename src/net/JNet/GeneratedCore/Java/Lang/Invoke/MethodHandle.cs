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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Invoke
{
    #region MethodHandle definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html"/>
    /// </summary>
    public partial class MethodHandle : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MethodHandle>
    {
        const string _bridgeClassName = "java.lang.invoke.MethodHandle";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("MethodHandle class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MethodHandle() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("MethodHandle class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MethodHandle(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region MethodHandle
    public partial class MethodHandle
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#isVarargsCollector()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVarargsCollector()
        {
            return IExecuteWithSignature<bool>("isVarargsCollector", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#invoke(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public object Invoke(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature("invoke", "([Ljava/lang/Object;)Ljava/lang/Object;"); else return IExecuteWithSignature("invoke", "([Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#invokeExact(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public object InvokeExact(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature("invokeExact", "([Ljava/lang/Object;)Ljava/lang/Object;"); else return IExecuteWithSignature("invokeExact", "([Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#asCollector(int,java.lang.Class,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle AsCollector(int arg0, Java.Lang.Class arg1, int arg2)
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("asCollector", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#asCollector(java.lang.Class,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle AsCollector(Java.Lang.Class arg0, int arg1)
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("asCollector", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#asFixedArity()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle AsFixedArity()
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodHandle>("asFixedArity", "()Ljava/lang/invoke/MethodHandle;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#asSpreader(int,java.lang.Class,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle AsSpreader(int arg0, Java.Lang.Class arg1, int arg2)
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("asSpreader", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#asSpreader(java.lang.Class,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle AsSpreader(Java.Lang.Class arg0, int arg1)
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("asSpreader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#asType(java.lang.invoke.MethodType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodType"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle AsType(Java.Lang.Invoke.MethodType arg0)
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodHandle>("asType", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#asVarargsCollector(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle AsVarargsCollector(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodHandle>("asVarargsCollector", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#bindTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle BindTo(object arg0)
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodHandle>("bindTo", "(Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#withVarargs(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle WithVarargs(bool arg0)
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodHandle>("withVarargs", "(Z)Ljava/lang/invoke/MethodHandle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#type()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType Type()
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("type", "()Ljava/lang/invoke/MethodType;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#invokeWithArguments(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public object InvokeWithArguments(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature("invokeWithArguments", "([Ljava/lang/Object;)Ljava/lang/Object;"); else return IExecuteWithSignature("invokeWithArguments", "([Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandle.html#invokeWithArguments(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public object InvokeWithArguments(Java.Util.List<object> arg0)
        {
            return IExecuteWithSignature("invokeWithArguments", "(Ljava/util/List;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}