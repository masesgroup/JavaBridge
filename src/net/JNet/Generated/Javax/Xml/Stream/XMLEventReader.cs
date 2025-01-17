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

namespace Javax.Xml.Stream
{
    #region XMLEventReader declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html"/>
    /// </summary>
    public partial class XMLEventReader : Java.Util.Iterator<object>
    {
        const string _bridgeClassName = "javax.xml.stream.XMLEventReader";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("XMLEventReader class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XMLEventReader() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("XMLEventReader class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XMLEventReader(params object[] args) : base(args) { }

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

    #region IXMLEventReader
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXMLEventReader
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#getElementText()"/> 
        /// </summary>
        Java.Lang.String ElementText { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#hasNext()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool HasNext();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        object GetProperty(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#nextEvent()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Stream.Events.XMLEvent"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        Javax.Xml.Stream.Events.XMLEvent NextEvent();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#nextTag()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Stream.Events.XMLEvent"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        Javax.Xml.Stream.Events.XMLEvent NextTag();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#peek()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Stream.Events.XMLEvent"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        Javax.Xml.Stream.Events.XMLEvent Peek();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#close()"/>
        /// </summary>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void Close();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XMLEventReader implementation
    public partial class XMLEventReader : Javax.Xml.Stream.IXMLEventReader
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#getElementText()"/> 
        /// </summary>
        public Java.Lang.String ElementText
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getElementText", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#hasNext()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNext()
        {
            return IExecuteWithSignature<bool>("hasNext", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#nextEvent()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Stream.Events.XMLEvent"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.Events.XMLEvent NextEvent()
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.XMLEvent>("nextEvent", "()Ljavax/xml/stream/events/XMLEvent;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#nextTag()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Stream.Events.XMLEvent"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.Events.XMLEvent NextTag()
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.XMLEvent>("nextTag", "()Ljavax/xml/stream/events/XMLEvent;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#peek()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Stream.Events.XMLEvent"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.Events.XMLEvent Peek()
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.XMLEvent>("peek", "()Ljavax/xml/stream/events/XMLEvent;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#close()"/>
        /// </summary>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}