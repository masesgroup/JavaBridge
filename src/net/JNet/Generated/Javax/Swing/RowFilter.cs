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

namespace Javax.Swing
{
    #region RowFilter declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html"/>
    /// </summary>
    public partial class RowFilter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RowFilter>
    {
        const string _bridgeClassName = "javax.swing.RowFilter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("RowFilter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RowFilter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("RowFilter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RowFilter(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        #region ComparisonType declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.ComparisonType.html"/>
        /// </summary>
        public partial class ComparisonType : Java.Lang.Enum<Javax.Swing.RowFilter.ComparisonType>
        {
            const string _bridgeClassName = "javax.swing.RowFilter$ComparisonType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ComparisonType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ComparisonType(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region Entry declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html"/>
        /// </summary>
        public partial class Entry : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Entry>
        {
            const string _bridgeClassName = "javax.swing.RowFilter$Entry";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("Entry class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Entry() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("Entry class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Entry(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region Entry<M, I> declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html"/>
        /// </summary>
        /// <typeparam name="M"></typeparam>
        /// <typeparam name="I"></typeparam>
        public partial class Entry<M, I> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Entry<M, I>>
        {
            const string _bridgeClassName = "javax.swing.RowFilter$Entry";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("Entry class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Entry() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("Entry class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Entry(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region RowFilter<M, I> declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html"/>
    /// </summary>
    /// <typeparam name="M"></typeparam>
    /// <typeparam name="I"></typeparam>
    public partial class RowFilter<M, I> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RowFilter<M, I>>
    {
        const string _bridgeClassName = "javax.swing.RowFilter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("RowFilter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RowFilter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("RowFilter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RowFilter(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region RowFilter implementation
    public partial class RowFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#andFilter(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter AndFilterMethod(Java.Lang.Iterable arg0)
        {
            return SExecuteWithSignature<Javax.Swing.RowFilter>(LocalBridgeClazz, "andFilter", "(Ljava/lang/Iterable;)Ljavax/swing/RowFilter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#dateFilter(javax.swing.RowFilter.ComparisonType,java.util.Date,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter.ComparisonType"/></param>
        /// <param name="arg1"><see cref="Java.Util.Date"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter DateFilterMethod(Javax.Swing.RowFilter.ComparisonType arg0, Java.Util.Date arg1, params int[] arg2)
        {
            if (arg2.Length == 0) return SExecuteWithSignature<Javax.Swing.RowFilter>(LocalBridgeClazz, "dateFilter", "(Ljavax/swing/RowFilter$ComparisonType;Ljava/util/Date;[I)Ljavax/swing/RowFilter;", arg0, arg1); else return SExecuteWithSignature<Javax.Swing.RowFilter>(LocalBridgeClazz, "dateFilter", "(Ljavax/swing/RowFilter$ComparisonType;Ljava/util/Date;[I)Ljavax/swing/RowFilter;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#notFilter(javax.swing.RowFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter NotFilterMethod(Javax.Swing.RowFilter arg0)
        {
            return SExecuteWithSignature<Javax.Swing.RowFilter>(LocalBridgeClazz, "notFilter", "(Ljavax/swing/RowFilter;)Ljavax/swing/RowFilter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#numberFilter(javax.swing.RowFilter.ComparisonType,java.lang.Number,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter.ComparisonType"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Number"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter NumberFilterMethod(Javax.Swing.RowFilter.ComparisonType arg0, Java.Lang.Number arg1, params int[] arg2)
        {
            if (arg2.Length == 0) return SExecuteWithSignature<Javax.Swing.RowFilter>(LocalBridgeClazz, "numberFilter", "(Ljavax/swing/RowFilter$ComparisonType;Ljava/lang/Number;[I)Ljavax/swing/RowFilter;", arg0, arg1); else return SExecuteWithSignature<Javax.Swing.RowFilter>(LocalBridgeClazz, "numberFilter", "(Ljavax/swing/RowFilter$ComparisonType;Ljava/lang/Number;[I)Ljavax/swing/RowFilter;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#orFilter(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter OrFilterMethod(Java.Lang.Iterable arg0)
        {
            return SExecuteWithSignature<Javax.Swing.RowFilter>(LocalBridgeClazz, "orFilter", "(Ljava/lang/Iterable;)Ljavax/swing/RowFilter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#regexFilter(java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter RegexFilterMethod(Java.Lang.String arg0, params int[] arg1)
        {
            if (arg1.Length == 0) return SExecuteWithSignature<Javax.Swing.RowFilter>(LocalBridgeClazz, "regexFilter", "(Ljava/lang/String;[I)Ljavax/swing/RowFilter;", arg0); else return SExecuteWithSignature<Javax.Swing.RowFilter>(LocalBridgeClazz, "regexFilter", "(Ljava/lang/String;[I)Ljavax/swing/RowFilter;", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#include(javax.swing.RowFilter.Entry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter.Entry"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Include(Javax.Swing.RowFilter.Entry arg0)
        {
            return IExecuteWithSignature<bool>("include", "(Ljavax/swing/RowFilter$Entry;)Z", arg0);
        }

        #endregion

        #region Nested classes
        #region ComparisonType implementation
        public partial class ComparisonType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.ComparisonType.html#AFTER"/>
            /// </summary>
            public static Javax.Swing.RowFilter.ComparisonType AFTER { get { if (!_AFTERReady) { _AFTERContent = SGetField<Javax.Swing.RowFilter.ComparisonType>(LocalBridgeClazz, "AFTER"); _AFTERReady = true; } return _AFTERContent; } }
            private static Javax.Swing.RowFilter.ComparisonType _AFTERContent = default;
            private static bool _AFTERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.ComparisonType.html#BEFORE"/>
            /// </summary>
            public static Javax.Swing.RowFilter.ComparisonType BEFORE { get { if (!_BEFOREReady) { _BEFOREContent = SGetField<Javax.Swing.RowFilter.ComparisonType>(LocalBridgeClazz, "BEFORE"); _BEFOREReady = true; } return _BEFOREContent; } }
            private static Javax.Swing.RowFilter.ComparisonType _BEFOREContent = default;
            private static bool _BEFOREReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.ComparisonType.html#EQUAL"/>
            /// </summary>
            public static Javax.Swing.RowFilter.ComparisonType EQUAL { get { if (!_EQUALReady) { _EQUALContent = SGetField<Javax.Swing.RowFilter.ComparisonType>(LocalBridgeClazz, "EQUAL"); _EQUALReady = true; } return _EQUALContent; } }
            private static Javax.Swing.RowFilter.ComparisonType _EQUALContent = default;
            private static bool _EQUALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.ComparisonType.html#NOT_EQUAL"/>
            /// </summary>
            public static Javax.Swing.RowFilter.ComparisonType NOT_EQUAL { get { if (!_NOT_EQUALReady) { _NOT_EQUALContent = SGetField<Javax.Swing.RowFilter.ComparisonType>(LocalBridgeClazz, "NOT_EQUAL"); _NOT_EQUALReady = true; } return _NOT_EQUALContent; } }
            private static Javax.Swing.RowFilter.ComparisonType _NOT_EQUALContent = default;
            private static bool _NOT_EQUALReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.ComparisonType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Javax.Swing.RowFilter.ComparisonType"/></returns>
            public static Javax.Swing.RowFilter.ComparisonType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Javax.Swing.RowFilter.ComparisonType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljavax/swing/RowFilter$ComparisonType;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.ComparisonType.html#values()"/>
            /// </summary>
            /// <returns><see cref="Javax.Swing.RowFilter.ComparisonType"/></returns>
            public static Javax.Swing.RowFilter.ComparisonType[] Values()
            {
                return SExecuteWithSignatureArray<Javax.Swing.RowFilter.ComparisonType>(LocalBridgeClazz, "values", "()[Ljavax/swing/RowFilter$ComparisonType;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Entry implementation
        public partial class Entry
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getIdentifier()"/> 
            /// </summary>
            public object Identifier
            {
                get { return IExecuteWithSignature("getIdentifier", "()Ljava/lang/Object;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getModel()"/> 
            /// </summary>
            public object Model
            {
                get { return IExecuteWithSignature("getModel", "()Ljava/lang/Object;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getValueCount()"/> 
            /// </summary>
            public int ValueCount
            {
                get { return IExecuteWithSignature<int>("getValueCount", "()I"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getValue(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object GetValue(int arg0)
            {
                return IExecuteWithSignature("getValue", "(I)Ljava/lang/Object;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getStringValue(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetStringValue(int arg0)
            {
                return IExecuteWithSignature<Java.Lang.String>("getStringValue", "(I)Ljava/lang/String;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Entry<M, I> implementation
        public partial class Entry<M, I>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.RowFilter.Entry{M, I}"/> to <see cref="Javax.Swing.RowFilter.Entry"/>
            /// </summary>
            public static implicit operator Javax.Swing.RowFilter.Entry(Javax.Swing.RowFilter.Entry<M, I> t) => t.Cast<Javax.Swing.RowFilter.Entry>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getIdentifier()"/> 
            /// </summary>
            public I Identifier
            {
                get { return IExecuteWithSignature<I>("getIdentifier", "()Ljava/lang/Object;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getModel()"/> 
            /// </summary>
            public M Model
            {
                get { return IExecuteWithSignature<M>("getModel", "()Ljava/lang/Object;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getValueCount()"/> 
            /// </summary>
            public int ValueCount
            {
                get { return IExecuteWithSignature<int>("getValueCount", "()I"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getValue(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object GetValue(int arg0)
            {
                return IExecuteWithSignature("getValue", "(I)Ljava/lang/Object;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.Entry.html#getStringValue(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetStringValue(int arg0)
            {
                return IExecuteWithSignature<Java.Lang.String>("getStringValue", "(I)Ljava/lang/String;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RowFilter<M, I> implementation
    public partial class RowFilter<M, I>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.RowFilter{M, I}"/> to <see cref="Javax.Swing.RowFilter"/>
        /// </summary>
        public static implicit operator Javax.Swing.RowFilter(Javax.Swing.RowFilter<M, I> t) => t.Cast<Javax.Swing.RowFilter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#andFilter(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_"><see cref="Javax.Swing.RowFilter{Arg0objectSuperM, Arg0objectSuperI}"/></typeparam>
        /// <typeparam name="Arg0objectSuperM"><typeparamref name="M"/></typeparam>
        /// <typeparam name="Arg0objectSuperI"><typeparamref name="I"/></typeparam>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter<M, I> AndFilterMethod<Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_, Arg0objectSuperM, Arg0objectSuperI>(Java.Lang.Iterable<Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_> arg0) where Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_ : Javax.Swing.RowFilter<Arg0objectSuperM, Arg0objectSuperI> where Arg0objectSuperM : M where Arg0objectSuperI : I
        {
            return SExecuteWithSignature<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "andFilter", "(Ljava/lang/Iterable;)Ljavax/swing/RowFilter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#dateFilter(javax.swing.RowFilter.ComparisonType,java.util.Date,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter.ComparisonType"/></param>
        /// <param name="arg1"><see cref="Java.Util.Date"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter<M, I> DateFilterMethod(Javax.Swing.RowFilter.ComparisonType arg0, Java.Util.Date arg1, params int[] arg2)
        {
            if (arg2.Length == 0) return SExecuteWithSignature<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "dateFilter", "(Ljavax/swing/RowFilter$ComparisonType;Ljava/util/Date;[I)Ljavax/swing/RowFilter;", arg0, arg1); else return SExecuteWithSignature<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "dateFilter", "(Ljavax/swing/RowFilter$ComparisonType;Ljava/util/Date;[I)Ljavax/swing/RowFilter;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#notFilter(javax.swing.RowFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter<M, I> NotFilterMethod(Javax.Swing.RowFilter<M, I> arg0)
        {
            return SExecuteWithSignature<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "notFilter", "(Ljavax/swing/RowFilter;)Ljavax/swing/RowFilter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#numberFilter(javax.swing.RowFilter.ComparisonType,java.lang.Number,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter.ComparisonType"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Number"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter<M, I> NumberFilterMethod(Javax.Swing.RowFilter.ComparisonType arg0, Java.Lang.Number arg1, params int[] arg2)
        {
            if (arg2.Length == 0) return SExecuteWithSignature<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "numberFilter", "(Ljavax/swing/RowFilter$ComparisonType;Ljava/lang/Number;[I)Ljavax/swing/RowFilter;", arg0, arg1); else return SExecuteWithSignature<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "numberFilter", "(Ljavax/swing/RowFilter$ComparisonType;Ljava/lang/Number;[I)Ljavax/swing/RowFilter;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#orFilter(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_"><see cref="Javax.Swing.RowFilter{Arg0objectSuperM, Arg0objectSuperI}"/></typeparam>
        /// <typeparam name="Arg0objectSuperM"><typeparamref name="M"/></typeparam>
        /// <typeparam name="Arg0objectSuperI"><typeparamref name="I"/></typeparam>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter<M, I> OrFilterMethod<Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_, Arg0objectSuperM, Arg0objectSuperI>(Java.Lang.Iterable<Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_> arg0) where Arg0ExtendsJavax_Swing_RowFilter_Arg0objectSuperM_Arg0objectSuperI_ : Javax.Swing.RowFilter<Arg0objectSuperM, Arg0objectSuperI> where Arg0objectSuperM : M where Arg0objectSuperI : I
        {
            return SExecuteWithSignature<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "orFilter", "(Ljava/lang/Iterable;)Ljavax/swing/RowFilter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#regexFilter(java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.RowFilter"/></returns>
        public static Javax.Swing.RowFilter<M, I> RegexFilterMethod(Java.Lang.String arg0, params int[] arg1)
        {
            if (arg1.Length == 0) return SExecuteWithSignature<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "regexFilter", "(Ljava/lang/String;[I)Ljavax/swing/RowFilter;", arg0); else return SExecuteWithSignature<Javax.Swing.RowFilter<M, I>>(LocalBridgeClazz, "regexFilter", "(Ljava/lang/String;[I)Ljavax/swing/RowFilter;", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowFilter.html#include(javax.swing.RowFilter.Entry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.RowFilter.Entry"/></param>
        /// <typeparam name="Arg0ExtendsM"><typeparamref name="M"/></typeparam>
        /// <typeparam name="Arg0ExtendsI"><typeparamref name="I"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool Include<Arg0ExtendsM, Arg0ExtendsI>(Javax.Swing.RowFilter.Entry<Arg0ExtendsM, Arg0ExtendsI> arg0) where Arg0ExtendsM : M where Arg0ExtendsI : I
        {
            return IExecuteWithSignature<bool>("include", "(Ljavax/swing/RowFilter$Entry;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}