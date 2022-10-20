﻿/*
*  Copyright 2022 MASES s.r.l.
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

using MASES.JCOBridge.C2JBridge;
using MASES.JNet;

namespace Java.Lang.Reflect
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/reflect/Modifier.html"/>
    /// </summary>
    public class Modifier : JVMBridgeBase<Modifier>
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.reflect.Modifier";
        /// <summary>
        /// The <see cref="int"/> value representing the abstract modifier.
        /// </summary>
        public static int ABSTRACT = Clazz.GetField<int>("ABSTRACT");
        /// <summary>
        /// The <see cref="int"/> value representing the final modifier.
        /// </summary>
        public static int FINAL = Clazz.GetField<int>("FINAL");
        /// <summary>
        /// The <see cref="int"/> value representing the interface modifier.
        /// </summary>
        public static int INTERFACE = Clazz.GetField<int>("INTERFACE");
        /// <summary>
        /// The <see cref="int"/> value representing the native modifier.
        /// </summary>
        public static int NATIVE = Clazz.GetField<int>("NATIVE");
        /// <summary>
        /// The <see cref="int"/> value representing the private modifier.
        /// </summary>
        public static int PRIVATE = Clazz.GetField<int>("PRIVATE");
        /// <summary>
        /// The <see cref="int"/> value representing the protected modifier.
        /// </summary>
        public static int PROTECTED = Clazz.GetField<int>("PROTECTED");
        /// <summary>
        /// The <see cref="int"/> value representing the public modifier.
        /// </summary>
        public static int PUBLIC = Clazz.GetField<int>("PUBLIC");
        /// <summary>
        /// The <see cref="int"/> value representing the static modifier.
        /// </summary>
        public static int STATIC = Clazz.GetField<int>("STATIC");
        /// <summary>
        /// The <see cref="int"/> value representing the strictfp modifier.
        /// </summary>
        public static int STRICT = Clazz.GetField<int>("STRICT");
        /// <summary>
        /// The <see cref="int"/> value representing the synchronized modifier.
        /// </summary>
        public static int SYNCHRONIZED = Clazz.GetField<int>("SYNCHRONIZED");
        /// <summary>
        /// The <see cref="int"/> value representing the transient modifier.
        /// </summary>
        public static int TRANSIENT = Clazz.GetField<int>("TRANSIENT");
        /// <summary>
        /// The <see cref="int"/> value representing the volatile modifier.
        /// </summary>
        public static int VOLATILE = Clazz.GetField<int>("VOLATILE");
        /// <summary>
        /// Return an <see cref="int"/> value OR-ing together the source language modifiers that can be applied to a class.
        /// </summary>
        public static int ClassModifiers => SExecute<int>("classModifiers");
        /// <summary>
        /// Return an <see cref="int"/> value OR-ing together the source language modifiers that can be applied to a constructor.
        /// </summary>
        public static int ConstructorModifiers => SExecute<int>("constructorModifiers");
        /// <summary>
        /// Return an <see cref="int"/> value OR-ing together the source language modifiers that can be applied to a field.
        /// </summary>
        public static int FieldModifiers => SExecute<int>("fieldModifiers");
        /// <summary>
        /// Return an <see cref="int"/> value OR-ing together the source language modifiers that can be applied to an interface.
        /// </summary>
        public static int InterfaceModifiers => SExecute<int>("interfaceModifiers");
        /// <summary>
        /// Return an <see cref="int"/> value OR-ing together the source language modifiers that can be applied to a method.
        /// </summary>
        public static int MethodModifiers => SExecute<int>("methodModifiers");
        /// <summary>
        /// Return an <see cref="int"/> value OR-ing together the source language modifiers that can be applied to a parameter.
        /// </summary>
        public static int ParameterModifiers => SExecute<int>("parameterModifiers");
        /// <summary>
        /// Return <see langword="true"/> if the integer argument includes the abstract modifier, <see langword="false"/> otherwise.
        /// </summary>
        public new static bool IsAbstract(int mod) => SExecute<bool>("isAbstract", mod);
        /// <summary>
        /// Return <see langword="true"/> if the integer argument includes the final modifier, <see langword="false"/> otherwise.
        /// </summary>
        public static bool IsFinal(int mod) => SExecute<bool>("isFinal", mod);
        /// <summary>
        /// Return <see langword="true"/> if the integer argument includes the interface modifier, <see langword="false"/> otherwise.
        /// </summary>
        public new static bool IsInterface(int mod) => SExecute<bool>("isInterface", mod);
        /// <summary>
        /// Return <see langword="true"/> if the integer argument includes the native modifier, <see langword="false"/> otherwise.
        /// </summary>
        public static bool IsNative(int mod) => SExecute<bool>("isNative", mod);
        /// <summary>
        /// Return <see langword="true"/> if the integer argument includes the private modifier, <see langword="false"/> otherwise.
        /// </summary>
        public static bool IsPrivate(int mod) => SExecute<bool>("isPrivate", mod);
        /// <summary>
        /// Return <see langword="true"/> if the integer argument includes the protected modifier, <see langword="false"/> otherwise.
        /// </summary>
        public static bool IsProtected(int mod) => SExecute<bool>("isProtected", mod);
        /// <summary>
        /// Return <see langword="true"/> if the integer argument includes the public modifier, <see langword="false"/> otherwise.
        /// </summary>
        public static bool IsPublic(int mod) => SExecute<bool>("isPublic", mod);
        /// <summary>
        /// Return <see langword="true"/> if the integer argument includes the static modifier, <see langword="false"/> otherwise.
        /// </summary>
        public new static bool IsStatic(int mod) => SExecute<bool>("isStatic", mod);
        /// <summary>
        /// Return <see langword="true"/> if the integer argument includes the strictfp modifier, <see langword="false"/> otherwise.
        /// </summary>
        public static bool IsStrict(int mod) => SExecute<bool>("isStrict", mod);
        /// <summary>
        /// Return <see langword="true"/> if the integer argument includes the synchronized modifier, <see langword="false"/> otherwise.
        /// </summary>
        public static bool IsSynchronized(int mod) => SExecute<bool>("isSynchronized", mod);
        /// <summary>
        /// Return <see langword="true"/> if the integer argument includes the transient modifier, <see langword="false"/> otherwise.
        /// </summary>
        public static bool IsTransient(int mod) => SExecute<bool>("isTransient", mod);
        /// <summary>
        /// Return <see langword="true"/> if the integer argument includes the volatile modifier, <see langword="false"/> otherwise.
        /// </summary>
        public static bool IsVolatile(int mod) => SExecute<bool>("isVolatile", mod);
    }
}