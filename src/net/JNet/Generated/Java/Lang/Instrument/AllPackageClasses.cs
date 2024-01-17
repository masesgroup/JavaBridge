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

using MASES.JCOBridge.C2JBridge.JVMInterop;
using System;

namespace Java.Lang.Instrument
{
    #region ClassDefinition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/ClassDefinition.html"/>
    /// </summary>
    public partial class ClassDefinition : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ClassDefinition>
    {
        const string _bridgeClassName = "java.lang.instrument.ClassDefinition";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ClassDefinition() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ClassDefinition(params object[] args) : base(args) { }

        private static readonly IJavaType LocalBridgeClazz = ClazzOf(_bridgeClassName);

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

    #region ClassFileTransformer
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/ClassFileTransformer.html"/>
    /// </summary>
    public partial class ClassFileTransformer : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ClassFileTransformer>
    {
        const string _bridgeClassName = "java.lang.instrument.ClassFileTransformer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [Obsolete("ClassFileTransformer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ClassFileTransformer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [Obsolete("ClassFileTransformer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ClassFileTransformer(params object[] args) : base(args) { }

        private static readonly IJavaType LocalBridgeClazz = ClazzOf(_bridgeClassName);

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IllegalClassFormatException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/IllegalClassFormatException.html"/>
    /// </summary>
    public partial class IllegalClassFormatException : Java.Lang.Exception
    {
        const string _bridgeClassName = "java.lang.instrument.IllegalClassFormatException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region Instrumentation
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html"/>
    /// </summary>
    public partial class Instrumentation : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Instrumentation>
    {
        const string _bridgeClassName = "java.lang.instrument.Instrumentation";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [Obsolete("Instrumentation class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Instrumentation() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [Obsolete("Instrumentation class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Instrumentation(params object[] args) : base(args) { }

        private static readonly IJavaType LocalBridgeClazz = ClazzOf(_bridgeClassName);

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region UnmodifiableClassException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/UnmodifiableClassException.html"/>
    /// </summary>
    public partial class UnmodifiableClassException : Java.Lang.Exception
    {
        const string _bridgeClassName = "java.lang.instrument.UnmodifiableClassException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region UnmodifiableModuleException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/UnmodifiableModuleException.html"/>
    /// </summary>
    public partial class UnmodifiableModuleException : Java.Lang.RuntimeException
    {
        const string _bridgeClassName = "java.lang.instrument.UnmodifiableModuleException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion


}