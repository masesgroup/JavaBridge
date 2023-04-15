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

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Metadata
{
    #region IIOMetadataNode
    public partial class IIOMetadataNode
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public IIOMetadataNode(string arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Imageio.Metadata.IIOMetadataNode"/> to <see cref="Org.W3c.Dom.Element"/>
        /// </summary>
        public static implicit operator Org.W3c.Dom.Element(Javax.Imageio.Metadata.IIOMetadataNode t) => t.Cast<Org.W3c.Dom.Element>();
        /// <summary>
        /// Converter from <see cref="Javax.Imageio.Metadata.IIOMetadataNode"/> to <see cref="Org.W3c.Dom.NodeList"/>
        /// </summary>
        public static implicit operator Org.W3c.Dom.NodeList(Javax.Imageio.Metadata.IIOMetadataNode t) => t.Cast<Org.W3c.Dom.NodeList>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getAttributes()"/> 
        /// </summary>
        public Org.W3c.Dom.NamedNodeMap Attributes
        {
            get { return IExecute<Org.W3c.Dom.NamedNodeMap>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getBaseURI()"/> 
        /// </summary>
        public string BaseURI
        {
            get { return IExecute<string>("getBaseURI"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getChildNodes()"/> 
        /// </summary>
        public Org.W3c.Dom.NodeList ChildNodes
        {
            get { return IExecute<Org.W3c.Dom.NodeList>("getChildNodes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getFirstChild()"/> 
        /// </summary>
        public Org.W3c.Dom.Node FirstChild
        {
            get { return IExecute<Org.W3c.Dom.Node>("getFirstChild"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#hasAttributes()"/> 
        /// </summary>
        public bool HasAttributes
        {
            get { return IExecute<bool>("hasAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#hasChildNodes()"/> 
        /// </summary>
        public bool HasChildNodes
        {
            get { return IExecute<bool>("hasChildNodes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getLastChild()"/> 
        /// </summary>
        public Org.W3c.Dom.Node LastChild
        {
            get { return IExecute<Org.W3c.Dom.Node>("getLastChild"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getLength()"/> 
        /// </summary>
        public int Length
        {
            get { return IExecute<int>("getLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getLocalName()"/> 
        /// </summary>
        public string LocalName
        {
            get { return IExecute<string>("getLocalName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getNamespaceURI()"/> 
        /// </summary>
        public string NamespaceURI
        {
            get { return IExecute<string>("getNamespaceURI"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getNextSibling()"/> 
        /// </summary>
        public Org.W3c.Dom.Node NextSibling
        {
            get { return IExecute<Org.W3c.Dom.Node>("getNextSibling"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getNodeName()"/> 
        /// </summary>
        public string NodeName
        {
            get { return IExecute<string>("getNodeName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getNodeType()"/> 
        /// </summary>
        public short NodeType
        {
            get { return IExecute<short>("getNodeType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getNodeValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setNodeValue(java.lang.String)"/>
        /// </summary>
        public string NodeValue
        {
            get { return IExecute<string>("getNodeValue"); } set { IExecute("setNodeValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getOwnerDocument()"/> 
        /// </summary>
        public Org.W3c.Dom.Document OwnerDocument
        {
            get { return IExecute<Org.W3c.Dom.Document>("getOwnerDocument"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getParentNode()"/> 
        /// </summary>
        public Org.W3c.Dom.Node ParentNode
        {
            get { return IExecute<Org.W3c.Dom.Node>("getParentNode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getPrefix()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setPrefix(java.lang.String)"/>
        /// </summary>
        public string Prefix
        {
            get { return IExecute<string>("getPrefix"); } set { IExecute("setPrefix", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getPreviousSibling()"/> 
        /// </summary>
        public Org.W3c.Dom.Node PreviousSibling
        {
            get { return IExecute<Org.W3c.Dom.Node>("getPreviousSibling"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getSchemaTypeInfo()"/> 
        /// </summary>
        public Org.W3c.Dom.TypeInfo SchemaTypeInfo
        {
            get { return IExecute<Org.W3c.Dom.TypeInfo>("getSchemaTypeInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getTagName()"/> 
        /// </summary>
        public string TagName
        {
            get { return IExecute<string>("getTagName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getTextContent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setTextContent(java.lang.String)"/>
        /// </summary>
        public string TextContent
        {
            get { return IExecute<string>("getTextContent"); } set { IExecute("setTextContent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getUserObject()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setUserObject(java.lang.Object)"/>
        /// </summary>
        public object UserObject
        {
            get { return IExecute("getUserObject"); } set { IExecute("setUserObject", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#hasAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasAttribute(string arg0)
        {
            return IExecute<bool>("hasAttribute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#hasAttributeNS(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasAttributeNS(string arg0, string arg1)
        {
            return IExecute<bool>("hasAttributeNS", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#isDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public bool IsDefaultNamespace(string arg0)
        {
            return IExecute<bool>("isDefaultNamespace", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#isEqualNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public bool IsEqualNode(Org.W3c.Dom.Node arg0)
        {
            return IExecute<bool>("isEqualNode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#isSameNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public bool IsSameNode(Org.W3c.Dom.Node arg0)
        {
            return IExecute<bool>("isSameNode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#isSupported(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(string arg0, string arg1)
        {
            return IExecute<bool>("isSupported", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getFeature(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public object GetFeature(string arg0, string arg1)
        {
            return IExecute("getFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getUserData(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public object GetUserData(string arg0)
        {
            return IExecute("getUserData", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setUserData(java.lang.String,java.lang.Object,org.w3c.dom.UserDataHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Org.W3c.Dom.UserDataHandler"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public object SetUserData(string arg0, object arg1, Org.W3c.Dom.UserDataHandler arg2)
        {
            return IExecute("setUserData", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttribute(string arg0)
        {
            return IExecute<string>("getAttribute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getAttributeNS(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeNS(string arg0, string arg1)
        {
            return IExecute<string>("getAttributeNS", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#lookupNamespaceURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public string LookupNamespaceURI(string arg0)
        {
            return IExecute<string>("lookupNamespaceURI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#lookupPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public string LookupPrefix(string arg0)
        {
            return IExecute<string>("lookupPrefix", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getAttributeNode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.W3c.Dom.Attr"/></returns>
        public Org.W3c.Dom.Attr GetAttributeNode(string arg0)
        {
            return IExecute<Org.W3c.Dom.Attr>("getAttributeNode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getAttributeNodeNS(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Org.W3c.Dom.Attr"/></returns>
        public Org.W3c.Dom.Attr GetAttributeNodeNS(string arg0, string arg1)
        {
            return IExecute<Org.W3c.Dom.Attr>("getAttributeNodeNS", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#removeAttributeNode(org.w3c.dom.Attr)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Attr"/></param>
        /// <returns><see cref="Org.W3c.Dom.Attr"/></returns>
        public Org.W3c.Dom.Attr RemoveAttributeNode(Org.W3c.Dom.Attr arg0)
        {
            return IExecute<Org.W3c.Dom.Attr>("removeAttributeNode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setAttributeNode(org.w3c.dom.Attr)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Attr"/></param>
        /// <returns><see cref="Org.W3c.Dom.Attr"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Attr SetAttributeNode(Org.W3c.Dom.Attr arg0)
        {
            return IExecute<Org.W3c.Dom.Attr>("setAttributeNode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setAttributeNodeNS(org.w3c.dom.Attr)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Attr"/></param>
        /// <returns><see cref="Org.W3c.Dom.Attr"/></returns>
        public Org.W3c.Dom.Attr SetAttributeNodeNS(Org.W3c.Dom.Attr arg0)
        {
            return IExecute<Org.W3c.Dom.Attr>("setAttributeNodeNS", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#appendChild(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node AppendChild(Org.W3c.Dom.Node arg0)
        {
            return IExecute<Org.W3c.Dom.Node>("appendChild", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#cloneNode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node CloneNode(bool arg0)
        {
            return IExecute<Org.W3c.Dom.Node>("cloneNode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#insertBefore(org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node InsertBefore(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1)
        {
            return IExecute<Org.W3c.Dom.Node>("insertBefore", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#item(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node Item(int arg0)
        {
            return IExecute<Org.W3c.Dom.Node>("item", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#removeChild(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node RemoveChild(Org.W3c.Dom.Node arg0)
        {
            return IExecute<Org.W3c.Dom.Node>("removeChild", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#replaceChild(org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node ReplaceChild(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1)
        {
            return IExecute<Org.W3c.Dom.Node>("replaceChild", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getElementsByTagName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.W3c.Dom.NodeList"/></returns>
        public Org.W3c.Dom.NodeList GetElementsByTagName(string arg0)
        {
            return IExecute<Org.W3c.Dom.NodeList>("getElementsByTagName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getElementsByTagNameNS(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Org.W3c.Dom.NodeList"/></returns>
        public Org.W3c.Dom.NodeList GetElementsByTagNameNS(string arg0, string arg1)
        {
            return IExecute<Org.W3c.Dom.NodeList>("getElementsByTagNameNS", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#compareDocumentPosition(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public short CompareDocumentPosition(Org.W3c.Dom.Node arg0)
        {
            return IExecute<short>("compareDocumentPosition", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#normalize()"/>
        /// </summary>
        public void Normalize()
        {
            IExecute("normalize");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#removeAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void RemoveAttribute(string arg0)
        {
            IExecute("removeAttribute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#removeAttributeNS(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public void RemoveAttributeNS(string arg0, string arg1)
        {
            IExecute("removeAttributeNS", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setAttribute(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public void SetAttribute(string arg0, string arg1)
        {
            IExecute("setAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setAttributeNS(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        public void SetAttributeNS(string arg0, string arg1, string arg2)
        {
            IExecute("setAttributeNS", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setIdAttribute(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetIdAttribute(string arg0, bool arg1)
        {
            IExecute("setIdAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setIdAttributeNode(org.w3c.dom.Attr,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Attr"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetIdAttributeNode(Org.W3c.Dom.Attr arg0, bool arg1)
        {
            IExecute("setIdAttributeNode", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setIdAttributeNS(java.lang.String,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetIdAttributeNS(string arg0, string arg1, bool arg2)
        {
            IExecute("setIdAttributeNS", arg0, arg1, arg2);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}