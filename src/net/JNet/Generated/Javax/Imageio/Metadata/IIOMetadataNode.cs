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

namespace Javax.Imageio.Metadata
{
    #region IIOMetadataNode declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html"/>
    /// </summary>
    public partial class IIOMetadataNode : MASES.JCOBridge.C2JBridge.JVMBridgeBase<IIOMetadataNode>
    {
        const string _bridgeClassName = "javax.imageio.metadata.IIOMetadataNode";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IIOMetadataNode() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public IIOMetadataNode(params object[] args) : base(args) { }

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
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IIOMetadataNode implementation
    public partial class IIOMetadataNode
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public IIOMetadataNode(Java.Lang.String arg0)
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
            get { return IExecuteWithSignature<Org.W3c.Dom.NamedNodeMap>("getAttributes", "()Lorg/w3c/dom/NamedNodeMap;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getBaseURI()"/> 
        /// </summary>
        public Java.Lang.String BaseURI
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getBaseURI", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getChildNodes()"/> 
        /// </summary>
        public Org.W3c.Dom.NodeList ChildNodes
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.NodeList>("getChildNodes", "()Lorg/w3c/dom/NodeList;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getFirstChild()"/> 
        /// </summary>
        public Org.W3c.Dom.Node FirstChild
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getFirstChild", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getLastChild()"/> 
        /// </summary>
        public Org.W3c.Dom.Node LastChild
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getLastChild", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getLength()"/> 
        /// </summary>
        public int Length
        {
            get { return IExecuteWithSignature<int>("getLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getLocalName()"/> 
        /// </summary>
        public Java.Lang.String LocalName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLocalName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getNamespaceURI()"/> 
        /// </summary>
        public Java.Lang.String NamespaceURI
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNamespaceURI", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getNextSibling()"/> 
        /// </summary>
        public Org.W3c.Dom.Node NextSibling
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getNextSibling", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getNodeName()"/> 
        /// </summary>
        public Java.Lang.String NodeName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNodeName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getNodeType()"/> 
        /// </summary>
        public short NodeType
        {
            get { return IExecuteWithSignature<short>("getNodeType", "()S"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getNodeValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setNodeValue(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String NodeValue
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNodeValue", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setNodeValue", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getOwnerDocument()"/> 
        /// </summary>
        public Org.W3c.Dom.Document OwnerDocument
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Document>("getOwnerDocument", "()Lorg/w3c/dom/Document;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getParentNode()"/> 
        /// </summary>
        public Org.W3c.Dom.Node ParentNode
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getParentNode", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getPrefix()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setPrefix(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Prefix
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPrefix", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setPrefix", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getPreviousSibling()"/> 
        /// </summary>
        public Org.W3c.Dom.Node PreviousSibling
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getPreviousSibling", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getSchemaTypeInfo()"/> 
        /// </summary>
        public Org.W3c.Dom.TypeInfo SchemaTypeInfo
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.TypeInfo>("getSchemaTypeInfo", "()Lorg/w3c/dom/TypeInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getTagName()"/> 
        /// </summary>
        public Java.Lang.String TagName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTagName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getTextContent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setTextContent(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String TextContent
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTextContent", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setTextContent", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getUserObject()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setUserObject(java.lang.Object)"/>
        /// </summary>
        public object UserObject
        {
            get { return IExecuteWithSignature("getUserObject", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setUserObject", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#hasAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasAttribute(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("hasAttribute", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#hasAttributeNS(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasAttributeNS(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<bool>("hasAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#hasAttributes()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasAttributes()
        {
            return IExecuteWithSignature<bool>("hasAttributes", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#hasChildNodes()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasChildNodes()
        {
            return IExecuteWithSignature<bool>("hasChildNodes", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#isDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public bool IsDefaultNamespace(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isDefaultNamespace", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#isEqualNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public bool IsEqualNode(Org.W3c.Dom.Node arg0)
        {
            return IExecuteWithSignature<bool>("isEqualNode", "(Lorg/w3c/dom/Node;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#isSameNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public bool IsSameNode(Org.W3c.Dom.Node arg0)
        {
            return IExecuteWithSignature<bool>("isSameNode", "(Lorg/w3c/dom/Node;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#isSupported(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getFeature(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public object GetFeature(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature("getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getUserData(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public object GetUserData(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getUserData", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setUserData(java.lang.String,java.lang.Object,org.w3c.dom.UserDataHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Org.W3c.Dom.UserDataHandler"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public object SetUserData(Java.Lang.String arg0, object arg1, Org.W3c.Dom.UserDataHandler arg2)
        {
            return IExecuteWithSignature("setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttribute(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getAttributeNS(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeNS(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#lookupNamespaceURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Java.Lang.String LookupNamespaceURI(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#lookupPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Java.Lang.String LookupPrefix(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getAttributeNode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Attr"/></returns>
        public Org.W3c.Dom.Attr GetAttributeNode(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Attr>("getAttributeNode", "(Ljava/lang/String;)Lorg/w3c/dom/Attr;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getAttributeNodeNS(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Attr"/></returns>
        public Org.W3c.Dom.Attr GetAttributeNodeNS(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Attr>("getAttributeNodeNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Attr;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#removeAttributeNode(org.w3c.dom.Attr)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Attr"/></param>
        /// <returns><see cref="Org.W3c.Dom.Attr"/></returns>
        public Org.W3c.Dom.Attr RemoveAttributeNode(Org.W3c.Dom.Attr arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Attr>("removeAttributeNode", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setAttributeNode(org.w3c.dom.Attr)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Attr"/></param>
        /// <returns><see cref="Org.W3c.Dom.Attr"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Attr SetAttributeNode(Org.W3c.Dom.Attr arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Attr>("setAttributeNode", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setAttributeNodeNS(org.w3c.dom.Attr)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Attr"/></param>
        /// <returns><see cref="Org.W3c.Dom.Attr"/></returns>
        public Org.W3c.Dom.Attr SetAttributeNodeNS(Org.W3c.Dom.Attr arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Attr>("setAttributeNodeNS", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#appendChild(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node AppendChild(Org.W3c.Dom.Node arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#cloneNode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node CloneNode(bool arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("cloneNode", "(Z)Lorg/w3c/dom/Node;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#insertBefore(org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node InsertBefore(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#item(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node Item(int arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("item", "(I)Lorg/w3c/dom/Node;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#removeChild(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node RemoveChild(Org.W3c.Dom.Node arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#replaceChild(org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node ReplaceChild(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getElementsByTagName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.NodeList"/></returns>
        public Org.W3c.Dom.NodeList GetElementsByTagName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.NodeList>("getElementsByTagName", "(Ljava/lang/String;)Lorg/w3c/dom/NodeList;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#getElementsByTagNameNS(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.NodeList"/></returns>
        public Org.W3c.Dom.NodeList GetElementsByTagNameNS(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Org.W3c.Dom.NodeList>("getElementsByTagNameNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/NodeList;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#compareDocumentPosition(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public short CompareDocumentPosition(Org.W3c.Dom.Node arg0)
        {
            return IExecuteWithSignature<short>("compareDocumentPosition", "(Lorg/w3c/dom/Node;)S", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#normalize()"/>
        /// </summary>
        public void Normalize()
        {
            IExecuteWithSignature("normalize", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#removeAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RemoveAttribute(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeAttribute", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#removeAttributeNS(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void RemoveAttributeNS(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("removeAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setAttribute(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetAttribute(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setAttributeNS(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public void SetAttributeNS(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecuteWithSignature("setAttributeNS", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setIdAttribute(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetIdAttribute(Java.Lang.String arg0, bool arg1)
        {
            IExecuteWithSignature("setIdAttribute", "(Ljava/lang/String;Z)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setIdAttributeNode(org.w3c.dom.Attr,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Attr"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetIdAttributeNode(Org.W3c.Dom.Attr arg0, bool arg1)
        {
            IExecuteWithSignature("setIdAttributeNode", "(Lorg/w3c/dom/Attr;Z)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataNode.html#setIdAttributeNS(java.lang.String,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetIdAttributeNS(Java.Lang.String arg0, Java.Lang.String arg1, bool arg2)
        {
            IExecuteWithSignature("setIdAttributeNS", "(Ljava/lang/String;Ljava/lang/String;Z)V", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}