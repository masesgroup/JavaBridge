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

namespace Javax.Xml.Stream
{
    #region XMLEventReader
    public partial class XMLEventReader
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
        public string ElementText
        {
            get { return IExecute<string>("getElementText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#hasNext()"/> 
        /// </summary>
        public bool HasNext
        {
            get { return IExecute<bool>("hasNext"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#nextEvent()"/> 
        /// </summary>
        public Javax.Xml.Stream.Events.XMLEvent NextEvent
        {
            get { return IExecute<Javax.Xml.Stream.Events.XMLEvent>("nextEvent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#nextTag()"/> 
        /// </summary>
        public Javax.Xml.Stream.Events.XMLEvent NextTag
        {
            get { return IExecute<Javax.Xml.Stream.Events.XMLEvent>("nextTag"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#peek()"/> 
        /// </summary>
        public Javax.Xml.Stream.Events.XMLEvent Peek
        {
            get { return IExecute<Javax.Xml.Stream.Events.XMLEvent>("peek"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLEventReader.html#close()"/>
        /// </summary>
        
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Close()
        {
            IExecute("close");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}