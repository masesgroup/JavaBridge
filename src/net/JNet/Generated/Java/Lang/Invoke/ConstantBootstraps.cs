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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Invoke
{
    #region ConstantBootstraps declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/ConstantBootstraps.html"/>
    /// </summary>
    public partial class ConstantBootstraps : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConstantBootstraps>
    {
        const string _bridgeClassName = "java.lang.invoke.ConstantBootstraps";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ConstantBootstraps() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ConstantBootstraps(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
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

    #region ConstantBootstraps implementation
    public partial class ConstantBootstraps
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/ConstantBootstraps.html#enumConstant(java.lang.invoke.MethodHandles.Lookup,java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="E"><see cref="Java.Lang.Enum{E}"/></typeparam>
        /// <returns><typeparamref name="E"/></returns>
        public static E EnumConstant<E>(Java.Lang.Invoke.MethodHandles.Lookup arg0, Java.Lang.String arg1, Java.Lang.Class arg2) where E : Java.Lang.Enum<E>
        {
            return SExecute<E>(LocalBridgeClazz, "enumConstant", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/ConstantBootstraps.html#primitiveClass(java.lang.invoke.MethodHandles.Lookup,java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public static Java.Lang.Class PrimitiveClass(Java.Lang.Invoke.MethodHandles.Lookup arg0, Java.Lang.String arg1, Java.Lang.Class arg2)
        {
            return SExecuteWithSignature<Java.Lang.Class>(LocalBridgeClazz, "primitiveClass", "(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Class;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/ConstantBootstraps.html#arrayVarHandle(java.lang.invoke.MethodHandles.Lookup,java.lang.String,java.lang.Class,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.VarHandle"/></returns>
        public static Java.Lang.Invoke.VarHandle ArrayVarHandle(Java.Lang.Invoke.MethodHandles.Lookup arg0, Java.Lang.String arg1, Java.Lang.Class arg2, Java.Lang.Class arg3)
        {
            return SExecuteWithSignature<Java.Lang.Invoke.VarHandle>(LocalBridgeClazz, "arrayVarHandle", "(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/invoke/VarHandle;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/ConstantBootstraps.html#fieldVarHandle(java.lang.invoke.MethodHandles.Lookup,java.lang.String,java.lang.Class,java.lang.Class,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.VarHandle"/></returns>
        public static Java.Lang.Invoke.VarHandle FieldVarHandle(Java.Lang.Invoke.MethodHandles.Lookup arg0, Java.Lang.String arg1, Java.Lang.Class arg2, Java.Lang.Class arg3, Java.Lang.Class arg4)
        {
            return SExecuteWithSignature<Java.Lang.Invoke.VarHandle>(LocalBridgeClazz, "fieldVarHandle", "(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/invoke/VarHandle;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/ConstantBootstraps.html#staticFieldVarHandle(java.lang.invoke.MethodHandles.Lookup,java.lang.String,java.lang.Class,java.lang.Class,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.VarHandle"/></returns>
        public static Java.Lang.Invoke.VarHandle StaticFieldVarHandle(Java.Lang.Invoke.MethodHandles.Lookup arg0, Java.Lang.String arg1, Java.Lang.Class arg2, Java.Lang.Class arg3, Java.Lang.Class arg4)
        {
            return SExecuteWithSignature<Java.Lang.Invoke.VarHandle>(LocalBridgeClazz, "staticFieldVarHandle", "(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/invoke/VarHandle;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/ConstantBootstraps.html#getStaticFinal(java.lang.invoke.MethodHandles.Lookup,java.lang.String,java.lang.Class,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="object"/></returns>
        public static object GetStaticFinal(Java.Lang.Invoke.MethodHandles.Lookup arg0, Java.Lang.String arg1, Java.Lang.Class arg2, Java.Lang.Class arg3)
        {
            return SExecuteWithSignature(LocalBridgeClazz, "getStaticFinal", "(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/Object;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/ConstantBootstraps.html#getStaticFinal(java.lang.invoke.MethodHandles.Lookup,java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="object"/></returns>
        public static object GetStaticFinal(Java.Lang.Invoke.MethodHandles.Lookup arg0, Java.Lang.String arg1, Java.Lang.Class arg2)
        {
            return SExecuteWithSignature(LocalBridgeClazz, "getStaticFinal", "(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/ConstantBootstraps.html#invoke(java.lang.invoke.MethodHandles.Lookup,java.lang.String,java.lang.Class,java.lang.invoke.MethodHandle,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Invoke.MethodHandle"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public static object Invoke(Java.Lang.Invoke.MethodHandles.Lookup arg0, Java.Lang.String arg1, Java.Lang.Class arg2, Java.Lang.Invoke.MethodHandle arg3, params object[] arg4)
        {
            if (arg4.Length == 0) return SExecuteWithSignature(LocalBridgeClazz, "invoke", "(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;[Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1, arg2, arg3); else return SExecuteWithSignature(LocalBridgeClazz, "invoke", "(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;[Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/ConstantBootstraps.html#nullConstant(java.lang.invoke.MethodHandles.Lookup,java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="object"/></returns>
        public static object NullConstant(Java.Lang.Invoke.MethodHandles.Lookup arg0, Java.Lang.String arg1, Java.Lang.Class arg2)
        {
            return SExecuteWithSignature(LocalBridgeClazz, "nullConstant", "(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", arg0, arg1, arg2);
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