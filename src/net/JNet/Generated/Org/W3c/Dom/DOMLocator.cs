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

namespace Org.W3c.Dom
{
    #region DOMLocator
    public partial class DOMLocator
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMLocator.html#getByteOffset()"/> 
        /// </summary>
        public int ByteOffset
        {
            get { return IExecute<int>("getByteOffset"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMLocator.html#getColumnNumber()"/> 
        /// </summary>
        public int ColumnNumber
        {
            get { return IExecute<int>("getColumnNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMLocator.html#getLineNumber()"/> 
        /// </summary>
        public int LineNumber
        {
            get { return IExecute<int>("getLineNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMLocator.html#getRelatedNode()"/> 
        /// </summary>
        public Org.W3c.Dom.Node RelatedNode
        {
            get { return IExecute<Org.W3c.Dom.Node>("getRelatedNode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMLocator.html#getUri()"/> 
        /// </summary>
        public string Uri
        {
            get { return IExecute<string>("getUri"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMLocator.html#getUtf16Offset()"/> 
        /// </summary>
        public int Utf16Offset
        {
            get { return IExecute<int>("getUtf16Offset"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}