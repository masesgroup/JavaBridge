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

namespace Javax.Xml.Xpath
{
    #region XPathEvaluationResult declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.html"/>
    /// </summary>
    public partial class XPathEvaluationResult : MASES.JCOBridge.C2JBridge.JVMBridgeBase<XPathEvaluationResult>
    {
        const string _bridgeClassName = "javax.xml.xpath.XPathEvaluationResult";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("XPathEvaluationResult class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XPathEvaluationResult() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("XPathEvaluationResult class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XPathEvaluationResult(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region XPathResultType declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html"/>
        /// </summary>
        public partial class XPathResultType : Java.Lang.Enum<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>
        {
            const string _bridgeClassName = "javax.xml.xpath.XPathEvaluationResult$XPathResultType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public XPathResultType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public XPathResultType(params object[] args) : base(args) { }

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

    
    }
    #endregion

    #region XPathEvaluationResult<T> declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class XPathEvaluationResult<T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<XPathEvaluationResult<T>>
    {
        const string _bridgeClassName = "javax.xml.xpath.XPathEvaluationResult";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("XPathEvaluationResult class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XPathEvaluationResult() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("XPathEvaluationResult class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XPathEvaluationResult(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
    
    }
    #endregion

    #region XPathEvaluationResult implementation
    public partial class XPathEvaluationResult
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.html#type()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType"/></returns>
        public Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType Type()
        {
            return IExecuteWithSignature<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>("type", "()Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.html#value()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Value()
        {
            return IExecuteWithSignature("value", "()Ljava/lang/Object;");
        }

        #endregion

        #region Nested classes
        #region XPathResultType implementation
        public partial class XPathResultType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#ANY"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType ANY { get { if (!_ANYReady) { _ANYContent = SGetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "ANY"); _ANYReady = true; } return _ANYContent; } }
            private static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType _ANYContent = default;
            private static bool _ANYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#BOOLEAN"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType BOOLEAN { get { if (!_BOOLEANReady) { _BOOLEANContent = SGetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "BOOLEAN"); _BOOLEANReady = true; } return _BOOLEANContent; } }
            private static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType _BOOLEANContent = default;
            private static bool _BOOLEANReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#NODE"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType NODE { get { if (!_NODEReady) { _NODEContent = SGetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "NODE"); _NODEReady = true; } return _NODEContent; } }
            private static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType _NODEContent = default;
            private static bool _NODEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#NODESET"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType NODESET { get { if (!_NODESETReady) { _NODESETContent = SGetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "NODESET"); _NODESETReady = true; } return _NODESETContent; } }
            private static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType _NODESETContent = default;
            private static bool _NODESETReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#NUMBER"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType NUMBER { get { if (!_NUMBERReady) { _NUMBERContent = SGetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "NUMBER"); _NUMBERReady = true; } return _NUMBERContent; } }
            private static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType _NUMBERContent = default;
            private static bool _NUMBERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#STRING"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType STRING { get { if (!_STRINGReady) { _STRINGContent = SGetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "STRING"); _STRINGReady = true; } return _STRINGContent; } }
            private static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType _STRINGContent = default;
            private static bool _STRINGReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#getQNameType(java.lang.Class)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            /// <returns><see cref="Javax.Xml.Namespace.QName"/></returns>
            public static Javax.Xml.Namespace.QName GetQNameType(Java.Lang.Class arg0)
            {
                return SExecuteWithSignature<Javax.Xml.Namespace.QName>(LocalBridgeClazz, "getQNameType", "(Ljava/lang/Class;)Ljavax/xml/namespace/QName;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType"/></returns>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#values()"/>
            /// </summary>
            /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType"/></returns>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType[] Values()
            {
                return SExecuteWithSignatureArray<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "values", "()[Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;");
            }

            #endregion

            #region Instance methods

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

    #region IXPathEvaluationResult<T>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXPathEvaluationResult<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.html#type()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType"/></returns>
        Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType Type();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.html#value()"/>
        /// </summary>
        /// <returns><typeparamref name="T"/></returns>
        T Value();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XPathEvaluationResult<T> implementation
    public partial class XPathEvaluationResult<T> : Javax.Xml.Xpath.IXPathEvaluationResult<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Xpath.XPathEvaluationResult{T}"/> to <see cref="Javax.Xml.Xpath.XPathEvaluationResult"/>
        /// </summary>
        public static implicit operator Javax.Xml.Xpath.XPathEvaluationResult(Javax.Xml.Xpath.XPathEvaluationResult<T> t) => t.Cast<Javax.Xml.Xpath.XPathEvaluationResult>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.html#type()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType"/></returns>
        public Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType Type()
        {
            return IExecuteWithSignature<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>("type", "()Ljavax/xml/xpath/XPathEvaluationResult$XPathResultType;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.html#value()"/>
        /// </summary>
        /// <returns><typeparamref name="T"/></returns>
        public T Value()
        {
            return IExecuteWithSignature<T>("value", "()Ljava/lang/Object;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}