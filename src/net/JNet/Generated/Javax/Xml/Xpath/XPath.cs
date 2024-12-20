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
    #region XPath declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html"/>
    /// </summary>
    public partial class XPath : MASES.JCOBridge.C2JBridge.JVMBridgeBase<XPath>
    {
        const string _bridgeClassName = "javax.xml.xpath.XPath";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("XPath class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XPath() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("XPath class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XPath(params object[] args) : base(args) { }

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

    #region IXPath
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXPath
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#getNamespaceContext()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#setNamespaceContext(javax.xml.namespace.NamespaceContext)"/>
        /// </summary>
        Javax.Xml.Namespace.NamespaceContext NamespaceContext { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#getXPathFunctionResolver()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver)"/>
        /// </summary>
        Javax.Xml.Xpath.XPathFunctionResolver XPathFunctionResolver { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#getXPathVariableResolver()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver)"/>
        /// </summary>
        Javax.Xml.Xpath.XPathVariableResolver XPathVariableResolver { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,java.lang.Object,javax.xml.namespace.QName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        object Evaluate(Java.Lang.String arg0, object arg1, Javax.Xml.Namespace.QName arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,org.xml.sax.InputSource,javax.xml.namespace.QName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <param name="arg2"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        object Evaluate(Java.Lang.String arg0, Org.Xml.Sax.InputSource arg1, Javax.Xml.Namespace.QName arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        Java.Lang.String Evaluate(Java.Lang.String arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        Java.Lang.String Evaluate(Java.Lang.String arg0, Org.Xml.Sax.InputSource arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#compile(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathExpression"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        Javax.Xml.Xpath.XPathExpression Compile(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#reset()"/>
        /// </summary>
        void Reset();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,java.lang.Object,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        T EvaluateExpression<T>(Java.Lang.String arg0, object arg1, Java.Lang.Class arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,org.xml.sax.InputSource,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        T EvaluateExpression<T>(Java.Lang.String arg0, Org.Xml.Sax.InputSource arg1, Java.Lang.Class arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        Javax.Xml.Xpath.XPathEvaluationResult<object> EvaluateExpression(Java.Lang.String arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        Javax.Xml.Xpath.XPathEvaluationResult<object> EvaluateExpression(Java.Lang.String arg0, Org.Xml.Sax.InputSource arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XPath implementation
    public partial class XPath : Javax.Xml.Xpath.IXPath
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#getNamespaceContext()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#setNamespaceContext(javax.xml.namespace.NamespaceContext)"/>
        /// </summary>
        public Javax.Xml.Namespace.NamespaceContext NamespaceContext
        {
            get { return IExecuteWithSignature<Javax.Xml.Namespace.NamespaceContext>("getNamespaceContext", "()Ljavax/xml/namespace/NamespaceContext;"); } set { IExecuteWithSignature("setNamespaceContext", "(Ljavax/xml/namespace/NamespaceContext;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#getXPathFunctionResolver()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver)"/>
        /// </summary>
        public Javax.Xml.Xpath.XPathFunctionResolver XPathFunctionResolver
        {
            get { return IExecuteWithSignature<Javax.Xml.Xpath.XPathFunctionResolver>("getXPathFunctionResolver", "()Ljavax/xml/xpath/XPathFunctionResolver;"); } set { IExecuteWithSignature("setXPathFunctionResolver", "(Ljavax/xml/xpath/XPathFunctionResolver;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#getXPathVariableResolver()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver)"/>
        /// </summary>
        public Javax.Xml.Xpath.XPathVariableResolver XPathVariableResolver
        {
            get { return IExecuteWithSignature<Javax.Xml.Xpath.XPathVariableResolver>("getXPathVariableResolver", "()Ljavax/xml/xpath/XPathVariableResolver;"); } set { IExecuteWithSignature("setXPathVariableResolver", "(Ljavax/xml/xpath/XPathVariableResolver;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,java.lang.Object,javax.xml.namespace.QName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public object Evaluate(Java.Lang.String arg0, object arg1, Javax.Xml.Namespace.QName arg2)
        {
            return IExecuteWithSignature("evaluate", "(Ljava/lang/String;Ljava/lang/Object;Ljavax/xml/namespace/QName;)Ljava/lang/Object;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,org.xml.sax.InputSource,javax.xml.namespace.QName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <param name="arg2"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public object Evaluate(Java.Lang.String arg0, Org.Xml.Sax.InputSource arg1, Javax.Xml.Namespace.QName arg2)
        {
            return IExecuteWithSignature("evaluate", "(Ljava/lang/String;Lorg/xml/sax/InputSource;Ljavax/xml/namespace/QName;)Ljava/lang/Object;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public Java.Lang.String Evaluate(Java.Lang.String arg0, object arg1)
        {
            return IExecuteWithSignature<Java.Lang.String>("evaluate", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluate(java.lang.String,org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public Java.Lang.String Evaluate(Java.Lang.String arg0, Org.Xml.Sax.InputSource arg1)
        {
            return IExecuteWithSignature<Java.Lang.String>("evaluate", "(Ljava/lang/String;Lorg/xml/sax/InputSource;)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#compile(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathExpression"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public Javax.Xml.Xpath.XPathExpression Compile(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Xpath.XPathExpression>("compile", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathExpression;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,java.lang.Object,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public T EvaluateExpression<T>(Java.Lang.String arg0, object arg1, Java.Lang.Class arg2)
        {
            return IExecuteWithSignature<T>("evaluateExpression", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,org.xml.sax.InputSource,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public T EvaluateExpression<T>(Java.Lang.String arg0, Org.Xml.Sax.InputSource arg1, Java.Lang.Class arg2)
        {
            return IExecuteWithSignature<T>("evaluateExpression", "(Ljava/lang/String;Lorg/xml/sax/InputSource;Ljava/lang/Class;)Ljava/lang/Object;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public Javax.Xml.Xpath.XPathEvaluationResult<object> EvaluateExpression(Java.Lang.String arg0, object arg1)
        {
            return IExecuteWithSignature<Javax.Xml.Xpath.XPathEvaluationResult<object>>("evaluateExpression", "(Ljava/lang/String;Ljava/lang/Object;)Ljavax/xml/xpath/XPathEvaluationResult;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPath.html#evaluateExpression(java.lang.String,org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathExpressionException"/>
        public Javax.Xml.Xpath.XPathEvaluationResult<object> EvaluateExpression(Java.Lang.String arg0, Org.Xml.Sax.InputSource arg1)
        {
            return IExecuteWithSignature<Javax.Xml.Xpath.XPathEvaluationResult<object>>("evaluateExpression", "(Ljava/lang/String;Lorg/xml/sax/InputSource;)Ljavax/xml/xpath/XPathEvaluationResult;", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}