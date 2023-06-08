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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream
{
    #region IXMLStreamWriter
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html"/>
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
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        object GetProperty(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#getPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        string GetPrefix(string arg0);
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
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void SetDefaultNamespace(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#setPrefix(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void SetPrefix(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeAttribute(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteAttribute(string arg0, string arg1, string arg2, string arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeAttribute(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteAttribute(string arg0, string arg1, string arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeAttribute(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteAttribute(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeCData(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteCData(string arg0);
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
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteCharacters(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeComment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteComment(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteDefaultNamespace(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeDTD(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteDTD(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEmptyElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteEmptyElement(string arg0, string arg1, string arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEmptyElement(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteEmptyElement(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEmptyElement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteEmptyElement(string arg0);
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
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteEntityRef(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeNamespace(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteNamespace(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeProcessingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteProcessingInstruction(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeProcessingInstruction(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteProcessingInstruction(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartDocument()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteStartDocument();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartDocument(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteStartDocument(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartDocument(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteStartDocument(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteStartElement(string arg0, string arg1, string arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartElement(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteStartElement(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartElement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteStartElement(string arg0);

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
            get { return IExecute<Javax.Xml.Namespace.NamespaceContext>("getNamespaceContext"); } set { IExecute("setNamespaceContext", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#getPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public string GetPrefix(string arg0)
        {
            return IExecute<string>("getPrefix", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#close()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#flush()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Flush()
        {
            IExecute("flush");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#setDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void SetDefaultNamespace(string arg0)
        {
            IExecute("setDefaultNamespace", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#setPrefix(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void SetPrefix(string arg0, string arg1)
        {
            IExecute("setPrefix", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeAttribute(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteAttribute(string arg0, string arg1, string arg2, string arg3)
        {
            IExecute("writeAttribute", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeAttribute(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteAttribute(string arg0, string arg1, string arg2)
        {
            IExecute("writeAttribute", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeAttribute(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteAttribute(string arg0, string arg1)
        {
            IExecute("writeAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeCData(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteCData(string arg0)
        {
            IExecute("writeCData", arg0);
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
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteCharacters(string arg0)
        {
            IExecute("writeCharacters", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeComment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteComment(string arg0)
        {
            IExecute("writeComment", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteDefaultNamespace(string arg0)
        {
            IExecute("writeDefaultNamespace", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeDTD(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteDTD(string arg0)
        {
            IExecute("writeDTD", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEmptyElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteEmptyElement(string arg0, string arg1, string arg2)
        {
            IExecute("writeEmptyElement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEmptyElement(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteEmptyElement(string arg0, string arg1)
        {
            IExecute("writeEmptyElement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEmptyElement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteEmptyElement(string arg0)
        {
            IExecute("writeEmptyElement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEndDocument()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteEndDocument()
        {
            IExecute("writeEndDocument");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEndElement()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteEndElement()
        {
            IExecute("writeEndElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeEntityRef(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteEntityRef(string arg0)
        {
            IExecute("writeEntityRef", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeNamespace(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteNamespace(string arg0, string arg1)
        {
            IExecute("writeNamespace", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeProcessingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteProcessingInstruction(string arg0, string arg1)
        {
            IExecute("writeProcessingInstruction", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeProcessingInstruction(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteProcessingInstruction(string arg0)
        {
            IExecute("writeProcessingInstruction", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartDocument()"/>
        /// </summary>

        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteStartDocument()
        {
            IExecute("writeStartDocument");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartDocument(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteStartDocument(string arg0, string arg1)
        {
            IExecute("writeStartDocument", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartDocument(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteStartDocument(string arg0)
        {
            IExecute("writeStartDocument", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteStartElement(string arg0, string arg1, string arg2)
        {
            IExecute("writeStartElement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartElement(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteStartElement(string arg0, string arg1)
        {
            IExecute("writeStartElement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLStreamWriter.html#writeStartElement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteStartElement(string arg0)
        {
            IExecute("writeStartElement", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}