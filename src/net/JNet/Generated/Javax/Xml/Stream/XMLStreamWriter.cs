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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream
{
    #region IXMLStreamWriter
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXMLStreamWriter
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#getNamespaceContext()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#setNamespaceContext(javax.xml.namespace.NamespaceContext)"/>
        /// </summary>
        Javax.Xml.Namespace.NamespaceContext NamespaceContext { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        object GetProperty(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#getPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        Java.Lang.String GetPrefix(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#close()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void Close();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#flush()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void Flush();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#setDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void SetDefaultNamespace(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#setPrefix(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void SetPrefix(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeAttribute(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteAttribute(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeAttribute(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteAttribute(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeAttribute(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteAttribute(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeCData(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteCData(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeCharacters(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteCharacters(char[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeCharacters(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteCharacters(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeComment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteComment(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteDefaultNamespace(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeDTD(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteDTD(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEmptyElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteEmptyElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEmptyElement(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteEmptyElement(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEmptyElement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteEmptyElement(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEndDocument()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteEndDocument();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEndElement()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteEndElement();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEntityRef(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteEntityRef(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeNamespace(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteNamespace(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeProcessingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteProcessingInstruction(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeProcessingInstruction(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteProcessingInstruction(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartDocument()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteStartDocument();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartDocument(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteStartDocument(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartDocument(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteStartDocument(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteStartElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartElement(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteStartElement(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartElement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteStartElement(Java.Lang.String arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XMLStreamWriter
    public partial class XMLStreamWriter : Javax.Xml.Stream.IXMLStreamWriter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#getNamespaceContext()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#setNamespaceContext(javax.xml.namespace.NamespaceContext)"/>
        /// </summary>
        public Javax.Xml.Namespace.NamespaceContext NamespaceContext
        {
            get { return IExecuteWithSignature<Javax.Xml.Namespace.NamespaceContext>("getNamespaceContext", "()Ljavax/xml/namespace/NamespaceContext;"); } set { IExecuteWithSignature("setNamespaceContext", "(Ljavax/xml/namespace/NamespaceContext;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#getPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Java.Lang.String GetPrefix(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getPrefix", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#close()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#flush()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#setDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void SetDefaultNamespace(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setDefaultNamespace", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#setPrefix(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void SetPrefix(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("setPrefix", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeAttribute(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteAttribute(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3)
        {
            IExecute("writeAttribute", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeAttribute(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteAttribute(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("writeAttribute", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeAttribute(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteAttribute(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("writeAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeCData(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteCData(Java.Lang.String arg0)
        {
            IExecuteWithSignature("writeCData", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeCharacters(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteCharacters(char[] arg0, int arg1, int arg2)
        {
            IExecute("writeCharacters", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeCharacters(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteCharacters(Java.Lang.String arg0)
        {
            IExecuteWithSignature("writeCharacters", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeComment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteComment(Java.Lang.String arg0)
        {
            IExecuteWithSignature("writeComment", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteDefaultNamespace(Java.Lang.String arg0)
        {
            IExecuteWithSignature("writeDefaultNamespace", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeDTD(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteDTD(Java.Lang.String arg0)
        {
            IExecuteWithSignature("writeDTD", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEmptyElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteEmptyElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("writeEmptyElement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEmptyElement(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteEmptyElement(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("writeEmptyElement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEmptyElement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteEmptyElement(Java.Lang.String arg0)
        {
            IExecuteWithSignature("writeEmptyElement", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEndDocument()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteEndDocument()
        {
            IExecuteWithSignature("writeEndDocument", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEndElement()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteEndElement()
        {
            IExecuteWithSignature("writeEndElement", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEntityRef(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteEntityRef(Java.Lang.String arg0)
        {
            IExecuteWithSignature("writeEntityRef", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeNamespace(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteNamespace(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("writeNamespace", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeProcessingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteProcessingInstruction(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("writeProcessingInstruction", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeProcessingInstruction(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteProcessingInstruction(Java.Lang.String arg0)
        {
            IExecuteWithSignature("writeProcessingInstruction", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartDocument()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteStartDocument()
        {
            IExecuteWithSignature("writeStartDocument", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartDocument(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteStartDocument(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("writeStartDocument", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartDocument(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteStartDocument(Java.Lang.String arg0)
        {
            IExecuteWithSignature("writeStartDocument", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteStartElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("writeStartElement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartElement(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteStartElement(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("writeStartElement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartElement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteStartElement(Java.Lang.String arg0)
        {
            IExecuteWithSignature("writeStartElement", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}