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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
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
        public Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType Type
        {
            get { return IExecute<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>("type"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.html#value()"/> 
        /// </summary>
        public object Value
        {
            get { return IExecute("value"); }
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
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType ANY => Clazz.GetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>("ANY");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#BOOLEAN"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType BOOLEAN => Clazz.GetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>("BOOLEAN");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#NODE"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType NODE => Clazz.GetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>("NODE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#NODESET"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType NODESET => Clazz.GetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>("NODESET");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#NUMBER"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType NUMBER => Clazz.GetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>("NUMBER");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#STRING"/>
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType STRING => Clazz.GetField<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>("STRING");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#values()"/> 
            /// </summary>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType[] Values
            {
                get { return SExecuteArray<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>("values"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#getQNameType(java.lang.Class)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            /// <returns><see cref="Javax.Xml.Namespace.QName"/></returns>
            public static Javax.Xml.Namespace.QName GetQNameType(Java.Lang.Class arg0)
            {
                return SExecute<Javax.Xml.Namespace.QName>("getQNameType", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.XPathResultType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType"/></returns>
            public static Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType ValueOf(string arg0)
            {
                return SExecute<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>("valueOf", arg0);
            }
            
            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XPathEvaluationResult<T>
    public partial class XPathEvaluationResult<T>
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
        public Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType Type
        {
            get { return IExecute<Javax.Xml.Xpath.XPathEvaluationResult.XPathResultType>("type"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathEvaluationResult.html#value()"/> 
        /// </summary>
        public T Value
        {
            get { return IExecute<T>("value"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}