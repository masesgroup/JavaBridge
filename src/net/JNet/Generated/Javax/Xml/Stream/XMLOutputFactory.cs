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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream
{
    #region XMLOutputFactory declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html"/>
    /// </summary>
    public partial class XMLOutputFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<XMLOutputFactory>
    {
        const string _bridgeClassName = "javax.xml.stream.XMLOutputFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("XMLOutputFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XMLOutputFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("XMLOutputFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XMLOutputFactory(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region XMLOutputFactory implementation
    public partial class XMLOutputFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#IS_REPAIRING_NAMESPACES"/>
        /// </summary>
        public static Java.Lang.String IS_REPAIRING_NAMESPACES { get { if (!_IS_REPAIRING_NAMESPACESReady) { _IS_REPAIRING_NAMESPACESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "IS_REPAIRING_NAMESPACES"); _IS_REPAIRING_NAMESPACESReady = true; } return _IS_REPAIRING_NAMESPACESContent; } }
        private static Java.Lang.String _IS_REPAIRING_NAMESPACESContent = default;
        private static bool _IS_REPAIRING_NAMESPACESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#newDefaultFactory()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Stream.XMLOutputFactory"/></returns>
        public static Javax.Xml.Stream.XMLOutputFactory NewDefaultFactory()
        {
            return SExecuteWithSignature<Javax.Xml.Stream.XMLOutputFactory>(LocalBridgeClazz, "newDefaultFactory", "()Ljavax/xml/stream/XMLOutputFactory;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#newFactory()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Stream.XMLOutputFactory"/></returns>
        /// <exception cref="Javax.Xml.Stream.FactoryConfigurationError"/>
        public static Javax.Xml.Stream.XMLOutputFactory NewFactory()
        {
            return SExecuteWithSignature<Javax.Xml.Stream.XMLOutputFactory>(LocalBridgeClazz, "newFactory", "()Ljavax/xml/stream/XMLOutputFactory;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#newFactory(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLOutputFactory"/></returns>
        /// <exception cref="Javax.Xml.Stream.FactoryConfigurationError"/>
        public static Javax.Xml.Stream.XMLOutputFactory NewFactory(Java.Lang.String arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Javax.Xml.Stream.XMLOutputFactory>(LocalBridgeClazz, "newFactory", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#newInstance()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Stream.XMLOutputFactory"/></returns>
        /// <exception cref="Javax.Xml.Stream.FactoryConfigurationError"/>
        public static Javax.Xml.Stream.XMLOutputFactory NewInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Stream.XMLOutputFactory>(LocalBridgeClazz, "newInstance", "()Ljavax/xml/stream/XMLOutputFactory;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#isPropertySupported(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPropertySupported(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isPropertySupported", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#createXMLEventWriter(java.io.OutputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventWriter"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventWriter CreateXMLEventWriter(Java.Io.OutputStream arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLEventWriter>("createXMLEventWriter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#createXMLEventWriter(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventWriter"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventWriter CreateXMLEventWriter(Java.Io.OutputStream arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.XMLEventWriter>("createXMLEventWriter", "(Ljava/io/OutputStream;)Ljavax/xml/stream/XMLEventWriter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#createXMLEventWriter(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventWriter"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventWriter CreateXMLEventWriter(Java.Io.Writer arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.XMLEventWriter>("createXMLEventWriter", "(Ljava/io/Writer;)Ljavax/xml/stream/XMLEventWriter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#createXMLEventWriter(javax.xml.transform.Result)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Result"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventWriter"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventWriter CreateXMLEventWriter(Javax.Xml.Transform.Result arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.XMLEventWriter>("createXMLEventWriter", "(Ljavax/xml/transform/Result;)Ljavax/xml/stream/XMLEventWriter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#createXMLStreamWriter(java.io.OutputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamWriter"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamWriter CreateXMLStreamWriter(Java.Io.OutputStream arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamWriter>("createXMLStreamWriter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#createXMLStreamWriter(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamWriter"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamWriter CreateXMLStreamWriter(Java.Io.OutputStream arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.XMLStreamWriter>("createXMLStreamWriter", "(Ljava/io/OutputStream;)Ljavax/xml/stream/XMLStreamWriter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#createXMLStreamWriter(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamWriter"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamWriter CreateXMLStreamWriter(Java.Io.Writer arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.XMLStreamWriter>("createXMLStreamWriter", "(Ljava/io/Writer;)Ljavax/xml/stream/XMLStreamWriter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#createXMLStreamWriter(javax.xml.transform.Result)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Result"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamWriter"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamWriter CreateXMLStreamWriter(Javax.Xml.Transform.Result arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Stream.XMLStreamWriter>("createXMLStreamWriter", "(Ljavax/xml/transform/Result;)Ljavax/xml/stream/XMLStreamWriter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLOutputFactory.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetProperty(Java.Lang.String arg0, object arg1)
        {
            IExecute("setProperty", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}