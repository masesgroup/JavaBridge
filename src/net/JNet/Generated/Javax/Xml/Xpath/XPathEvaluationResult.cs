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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Xpath
{
    #region XPathEvaluationResult
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
            return IExecute<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>("type");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.html#value()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Value()
        {
            return IExecute("value");
        }

        #endregion

        #region Nested classes
        #region XPathResultType
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
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType ANY { get { return SGetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "ANY"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#BOOLEAN"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType BOOLEAN { get { return SGetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "BOOLEAN"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#NODE"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType NODE { get { return SGetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "NODE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#NODESET"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType NODESET { get { return SGetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "NODESET"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#NUMBER"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType NUMBER { get { return SGetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "NUMBER"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#STRING"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType STRING { get { return SGetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "STRING"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#getQNameType(java.lang.Class)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            /// <returns><see cref="Javax.Xml.Namespace.QName"/></returns>
            public static Javax.Xml.Namespace.QName GetQNameType(Java.Lang.Class arg0)
            {
                return SExecute<Javax.Xml.Namespace.QName>(LocalBridgeClazz, "getQNameType", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType"/></returns>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType ValueOf(string arg0)
            {
                return SExecute<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#values()"/>
            /// </summary>

            /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType"/></returns>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType[] Values()
            {
                return SExecuteArray<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>(LocalBridgeClazz, "values");
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

    #region XPathEvaluationResult<T>
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
            return IExecute<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>("type");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.html#value()"/>
        /// </summary>

        /// <returns><typeparamref name="T"/></returns>
        public T Value()
        {
            return IExecute<T>("value");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}