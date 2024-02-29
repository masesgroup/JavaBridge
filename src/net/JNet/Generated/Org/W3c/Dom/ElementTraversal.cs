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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom
{
    #region IElementTraversal
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IElementTraversal
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ElementTraversal.html#getChildElementCount()"/> 
        /// </summary>
        int ChildElementCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ElementTraversal.html#getFirstElementChild()"/> 
        /// </summary>
        Org.W3c.Dom.Element FirstElementChild { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ElementTraversal.html#getLastElementChild()"/> 
        /// </summary>
        Org.W3c.Dom.Element LastElementChild { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ElementTraversal.html#getNextElementSibling()"/> 
        /// </summary>
        Org.W3c.Dom.Element NextElementSibling { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ElementTraversal.html#getPreviousElementSibling()"/> 
        /// </summary>
        Org.W3c.Dom.Element PreviousElementSibling { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ElementTraversal
    public partial class ElementTraversal : Org.W3c.Dom.IElementTraversal
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ElementTraversal.html#getChildElementCount()"/> 
        /// </summary>
        public int ChildElementCount
        {
            get { return IExecuteWithSignature<int>("getChildElementCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ElementTraversal.html#getFirstElementChild()"/> 
        /// </summary>
        public Org.W3c.Dom.Element FirstElementChild
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Element>("getFirstElementChild", "()Lorg/w3c/dom/Element;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ElementTraversal.html#getLastElementChild()"/> 
        /// </summary>
        public Org.W3c.Dom.Element LastElementChild
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Element>("getLastElementChild", "()Lorg/w3c/dom/Element;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ElementTraversal.html#getNextElementSibling()"/> 
        /// </summary>
        public Org.W3c.Dom.Element NextElementSibling
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Element>("getNextElementSibling", "()Lorg/w3c/dom/Element;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ElementTraversal.html#getPreviousElementSibling()"/> 
        /// </summary>
        public Org.W3c.Dom.Element PreviousElementSibling
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Element>("getPreviousElementSibling", "()Lorg/w3c/dom/Element;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}