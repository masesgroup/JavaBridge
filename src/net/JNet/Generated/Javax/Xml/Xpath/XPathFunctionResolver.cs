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

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Xpath
{
    #region IXPathFunctionResolver
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXPathFunctionResolver
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathFunctionResolver.html#resolveFunction(javax.xml.namespace.QName,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathFunction"/></returns>
        Javax.Xml.Xpath.XPathFunction ResolveFunction(Javax.Xml.Namespace.QName arg0, int arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XPathFunctionResolver
    public partial class XPathFunctionResolver : Javax.Xml.Xpath.IXPathFunctionResolver
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathFunctionResolver.html#resolveFunction(javax.xml.namespace.QName,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Namespace.QName"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathFunction"/></returns>
        public Javax.Xml.Xpath.XPathFunction ResolveFunction(Javax.Xml.Namespace.QName arg0, int arg1)
        {
            return IExecute<Javax.Xml.Xpath.XPathFunction>("resolveFunction", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}