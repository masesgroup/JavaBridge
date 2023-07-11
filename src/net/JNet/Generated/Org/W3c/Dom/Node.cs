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

namespace Org.W3c.Dom
{
    #region INode
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface INode
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getAttributes()"/> 
        /// </summary>
        Org.W3c.Dom.NamedNodeMap Attributes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getBaseURI()"/> 
        /// </summary>
        string BaseURI { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getChildNodes()"/> 
        /// </summary>
        Org.W3c.Dom.NodeList ChildNodes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getFirstChild()"/> 
        /// </summary>
        Org.W3c.Dom.Node FirstChild { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getLastChild()"/> 
        /// </summary>
        Org.W3c.Dom.Node LastChild { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getLocalName()"/> 
        /// </summary>
        string LocalName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getNamespaceURI()"/> 
        /// </summary>
        string NamespaceURI { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getNextSibling()"/> 
        /// </summary>
        Org.W3c.Dom.Node NextSibling { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getNodeName()"/> 
        /// </summary>
        string NodeName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getNodeType()"/> 
        /// </summary>
        short NodeType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getNodeValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#setNodeValue(java.lang.String)"/>
        /// </summary>
        string NodeValue { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getOwnerDocument()"/> 
        /// </summary>
        Org.W3c.Dom.Document OwnerDocument { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getParentNode()"/> 
        /// </summary>
        Org.W3c.Dom.Node ParentNode { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getPrefix()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#setPrefix(java.lang.String)"/>
        /// </summary>
        string Prefix { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getPreviousSibling()"/> 
        /// </summary>
        Org.W3c.Dom.Node PreviousSibling { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getTextContent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#setTextContent(java.lang.String)"/>
        /// </summary>
        string TextContent { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#hasAttributes()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool HasAttributes();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#hasChildNodes()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool HasChildNodes();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#isDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsDefaultNamespace(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#isEqualNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsEqualNode(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#isSameNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsSameNode(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#isSupported(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsSupported(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getFeature(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        object GetFeature(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getUserData(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        object GetUserData(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#setUserData(java.lang.String,java.lang.Object,org.w3c.dom.UserDataHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Org.W3c.Dom.UserDataHandler"/></param>
        /// <returns><see cref="object"/></returns>
        object SetUserData(string arg0, object arg1, Org.W3c.Dom.UserDataHandler arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#lookupNamespaceURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        string LookupNamespaceURI(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#lookupPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        string LookupPrefix(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#appendChild(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Node AppendChild(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#cloneNode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        Org.W3c.Dom.Node CloneNode(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#insertBefore(org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Node InsertBefore(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#removeChild(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Node RemoveChild(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#replaceChild(org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Node ReplaceChild(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#compareDocumentPosition(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        short CompareDocumentPosition(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#normalize()"/>
        /// </summary>
        void Normalize();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Node
    public partial class Node : Org.W3c.Dom.INode
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#ATTRIBUTE_NODE"/>
        /// </summary>
        public static short ATTRIBUTE_NODE { get { return SGetField<short>(LocalBridgeClazz, "ATTRIBUTE_NODE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#CDATA_SECTION_NODE"/>
        /// </summary>
        public static short CDATA_SECTION_NODE { get { return SGetField<short>(LocalBridgeClazz, "CDATA_SECTION_NODE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#COMMENT_NODE"/>
        /// </summary>
        public static short COMMENT_NODE { get { return SGetField<short>(LocalBridgeClazz, "COMMENT_NODE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#DOCUMENT_FRAGMENT_NODE"/>
        /// </summary>
        public static short DOCUMENT_FRAGMENT_NODE { get { return SGetField<short>(LocalBridgeClazz, "DOCUMENT_FRAGMENT_NODE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#DOCUMENT_NODE"/>
        /// </summary>
        public static short DOCUMENT_NODE { get { return SGetField<short>(LocalBridgeClazz, "DOCUMENT_NODE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#DOCUMENT_POSITION_CONTAINED_BY"/>
        /// </summary>
        public static short DOCUMENT_POSITION_CONTAINED_BY { get { return SGetField<short>(LocalBridgeClazz, "DOCUMENT_POSITION_CONTAINED_BY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#DOCUMENT_POSITION_CONTAINS"/>
        /// </summary>
        public static short DOCUMENT_POSITION_CONTAINS { get { return SGetField<short>(LocalBridgeClazz, "DOCUMENT_POSITION_CONTAINS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#DOCUMENT_POSITION_DISCONNECTED"/>
        /// </summary>
        public static short DOCUMENT_POSITION_DISCONNECTED { get { return SGetField<short>(LocalBridgeClazz, "DOCUMENT_POSITION_DISCONNECTED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#DOCUMENT_POSITION_FOLLOWING"/>
        /// </summary>
        public static short DOCUMENT_POSITION_FOLLOWING { get { return SGetField<short>(LocalBridgeClazz, "DOCUMENT_POSITION_FOLLOWING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC"/>
        /// </summary>
        public static short DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC { get { return SGetField<short>(LocalBridgeClazz, "DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#DOCUMENT_POSITION_PRECEDING"/>
        /// </summary>
        public static short DOCUMENT_POSITION_PRECEDING { get { return SGetField<short>(LocalBridgeClazz, "DOCUMENT_POSITION_PRECEDING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#DOCUMENT_TYPE_NODE"/>
        /// </summary>
        public static short DOCUMENT_TYPE_NODE { get { return SGetField<short>(LocalBridgeClazz, "DOCUMENT_TYPE_NODE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#ELEMENT_NODE"/>
        /// </summary>
        public static short ELEMENT_NODE { get { return SGetField<short>(LocalBridgeClazz, "ELEMENT_NODE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#ENTITY_NODE"/>
        /// </summary>
        public static short ENTITY_NODE { get { return SGetField<short>(LocalBridgeClazz, "ENTITY_NODE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#ENTITY_REFERENCE_NODE"/>
        /// </summary>
        public static short ENTITY_REFERENCE_NODE { get { return SGetField<short>(LocalBridgeClazz, "ENTITY_REFERENCE_NODE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#NOTATION_NODE"/>
        /// </summary>
        public static short NOTATION_NODE { get { return SGetField<short>(LocalBridgeClazz, "NOTATION_NODE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#PROCESSING_INSTRUCTION_NODE"/>
        /// </summary>
        public static short PROCESSING_INSTRUCTION_NODE { get { return SGetField<short>(LocalBridgeClazz, "PROCESSING_INSTRUCTION_NODE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#TEXT_NODE"/>
        /// </summary>
        public static short TEXT_NODE { get { return SGetField<short>(LocalBridgeClazz, "TEXT_NODE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getAttributes()"/> 
        /// </summary>
        public Org.W3c.Dom.NamedNodeMap Attributes
        {
            get { return IExecute<Org.W3c.Dom.NamedNodeMap>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getBaseURI()"/> 
        /// </summary>
        public string BaseURI
        {
            get { return IExecute<string>("getBaseURI"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getChildNodes()"/> 
        /// </summary>
        public Org.W3c.Dom.NodeList ChildNodes
        {
            get { return IExecute<Org.W3c.Dom.NodeList>("getChildNodes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getFirstChild()"/> 
        /// </summary>
        public Org.W3c.Dom.Node FirstChild
        {
            get { return IExecute<Org.W3c.Dom.Node>("getFirstChild"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getLastChild()"/> 
        /// </summary>
        public Org.W3c.Dom.Node LastChild
        {
            get { return IExecute<Org.W3c.Dom.Node>("getLastChild"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getLocalName()"/> 
        /// </summary>
        public string LocalName
        {
            get { return IExecute<string>("getLocalName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getNamespaceURI()"/> 
        /// </summary>
        public string NamespaceURI
        {
            get { return IExecute<string>("getNamespaceURI"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getNextSibling()"/> 
        /// </summary>
        public Org.W3c.Dom.Node NextSibling
        {
            get { return IExecute<Org.W3c.Dom.Node>("getNextSibling"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getNodeName()"/> 
        /// </summary>
        public string NodeName
        {
            get { return IExecute<string>("getNodeName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getNodeType()"/> 
        /// </summary>
        public short NodeType
        {
            get { return IExecute<short>("getNodeType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getNodeValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#setNodeValue(java.lang.String)"/>
        /// </summary>
        public string NodeValue
        {
            get { return IExecute<string>("getNodeValue"); } set { IExecute("setNodeValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getOwnerDocument()"/> 
        /// </summary>
        public Org.W3c.Dom.Document OwnerDocument
        {
            get { return IExecute<Org.W3c.Dom.Document>("getOwnerDocument"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getParentNode()"/> 
        /// </summary>
        public Org.W3c.Dom.Node ParentNode
        {
            get { return IExecute<Org.W3c.Dom.Node>("getParentNode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getPrefix()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#setPrefix(java.lang.String)"/>
        /// </summary>
        public string Prefix
        {
            get { return IExecute<string>("getPrefix"); } set { IExecute("setPrefix", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getPreviousSibling()"/> 
        /// </summary>
        public Org.W3c.Dom.Node PreviousSibling
        {
            get { return IExecute<Org.W3c.Dom.Node>("getPreviousSibling"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getTextContent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#setTextContent(java.lang.String)"/>
        /// </summary>
        public string TextContent
        {
            get { return IExecute<string>("getTextContent"); } set { IExecute("setTextContent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#hasAttributes()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasAttributes()
        {
            return IExecute<bool>("hasAttributes");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#hasChildNodes()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasChildNodes()
        {
            return IExecute<bool>("hasChildNodes");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#isDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDefaultNamespace(string arg0)
        {
            return IExecute<bool>("isDefaultNamespace", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#isEqualNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEqualNode(Org.W3c.Dom.Node arg0)
        {
            return IExecute<bool>("isEqualNode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#isSameNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSameNode(Org.W3c.Dom.Node arg0)
        {
            return IExecute<bool>("isSameNode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#isSupported(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(string arg0, string arg1)
        {
            return IExecute<bool>("isSupported", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getFeature(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetFeature(string arg0, string arg1)
        {
            return IExecute("getFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#getUserData(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetUserData(string arg0)
        {
            return IExecute("getUserData", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#setUserData(java.lang.String,java.lang.Object,org.w3c.dom.UserDataHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Org.W3c.Dom.UserDataHandler"/></param>
        /// <returns><see cref="object"/></returns>
        public object SetUserData(string arg0, object arg1, Org.W3c.Dom.UserDataHandler arg2)
        {
            return IExecute("setUserData", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#lookupNamespaceURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string LookupNamespaceURI(string arg0)
        {
            return IExecute<string>("lookupNamespaceURI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#lookupPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string LookupPrefix(string arg0)
        {
            return IExecute<string>("lookupPrefix", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#appendChild(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node AppendChild(Org.W3c.Dom.Node arg0)
        {
            return IExecute<Org.W3c.Dom.Node>("appendChild", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#cloneNode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node CloneNode(bool arg0)
        {
            return IExecute<Org.W3c.Dom.Node>("cloneNode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#insertBefore(org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node InsertBefore(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1)
        {
            return IExecute<Org.W3c.Dom.Node>("insertBefore", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#removeChild(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node RemoveChild(Org.W3c.Dom.Node arg0)
        {
            return IExecute<Org.W3c.Dom.Node>("removeChild", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#replaceChild(org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node ReplaceChild(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1)
        {
            return IExecute<Org.W3c.Dom.Node>("replaceChild", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#compareDocumentPosition(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public short CompareDocumentPosition(Org.W3c.Dom.Node arg0)
        {
            return IExecute<short>("compareDocumentPosition", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/Node.html#normalize()"/>
        /// </summary>
        public void Normalize()
        {
            IExecute("normalize");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}