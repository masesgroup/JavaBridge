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

using MASES.JCOBridge.C2JBridge.JVMInterop;

namespace Java.Util.Stream
{
    #region BaseStream
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html"/>
    /// </summary>
    public partial class BaseStream : Java.Lang.AutoCloseable
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BaseStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BaseStream(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("java.util.stream.BaseStream");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.stream.BaseStream";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region BaseStream<T, S>
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html"/>
    /// </summary>
    public partial class BaseStream<T, S> : Java.Lang.AutoCloseable where S: Java.Util.Stream.BaseStream<T, S>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BaseStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BaseStream(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("java.util.stream.BaseStream");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.stream.BaseStream";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region Collector
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html"/>
    /// </summary>
    public partial class Collector : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Collector>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Collector() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Collector(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("java.util.stream.Collector");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.stream.Collector";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class
        #region Characteristics
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.Characteristics.html"/>
        /// </summary>
        public partial class Characteristics : Java.Lang.Enum
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Characteristics() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Characteristics(params object[] args) : base(args) { }

            private static IJavaType LocalClazz = ClazzOf("java.util.stream.Collector$Characteristics");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
            /// </summary>
            public override string ClassName => "java.util.stream.Collector$Characteristics";
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
            /// </summary>
            public override bool IsAbstract => false;         
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
            /// </summary>
            public override bool IsCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
            /// </summary>
            public override bool IsInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
            /// </summary>
            public override bool IsStatic => true;

            // TODO: complete the class
        }
        #endregion


    }
    #endregion

    #region Collector<T, A, R>
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html"/>
    /// </summary>
    public partial class Collector<T, A, R> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Collector<T, A, R>>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Collector() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Collector(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("java.util.stream.Collector");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.stream.Collector";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region Collectors
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collectors.html"/>
    /// </summary>
    public partial class Collectors : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Collectors>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Collectors() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Collectors(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("java.util.stream.Collectors");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.stream.Collectors";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region DoubleStream
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html"/>
    /// </summary>
    public partial class DoubleStream : Java.Util.Stream.BaseStream
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DoubleStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DoubleStream(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("java.util.stream.DoubleStream");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.stream.DoubleStream";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class
        #region Builder
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
#warning Remember to build the body class for event listener
        }
        #endregion


    }
    #endregion

    #region IntStream
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html"/>
    /// </summary>
    public partial class IntStream : Java.Util.Stream.BaseStream
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IntStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public IntStream(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("java.util.stream.IntStream");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.stream.IntStream";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class
        #region Builder
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
#warning Remember to build the body class for event listener
        }
        #endregion


    }
    #endregion

    #region LongStream
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.html"/>
    /// </summary>
    public partial class LongStream : Java.Util.Stream.BaseStream
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LongStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LongStream(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("java.util.stream.LongStream");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.stream.LongStream";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class
        #region Builder
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/LongStream.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
#warning Remember to build the body class for event listener
        }
        #endregion


    }
    #endregion

    #region Stream
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Stream.html"/>
    /// </summary>
    public partial class Stream : Java.Util.Stream.BaseStream
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Stream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Stream(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("java.util.stream.Stream");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.stream.Stream";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class
        #region Builder
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Stream.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
#warning Remember to build the body class for event listener
        }
        #endregion

        #region Builder<T>
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Stream.Builder.html"/>
        /// </summary>
        public partial class Builder<T> : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
#warning Remember to build the body class for event listener
        }
        #endregion


    }
    #endregion

    #region Stream<T>
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Stream.html"/>
    /// </summary>
    public partial class Stream<T> : Java.Util.Stream.BaseStream<T, Java.Util.Stream.Stream<T>>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Stream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Stream(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("java.util.stream.Stream");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.stream.Stream";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region StreamSupport
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html"/>
    /// </summary>
    public partial class StreamSupport : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StreamSupport>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StreamSupport() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StreamSupport(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("java.util.stream.StreamSupport");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.stream.StreamSupport";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion


}