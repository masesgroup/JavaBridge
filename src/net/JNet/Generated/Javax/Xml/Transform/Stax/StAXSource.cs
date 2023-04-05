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

namespace Javax.Xml.Transform.Stax
{
    #region StAXSource
    public partial class StAXSource
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXSource.html#%3Cinit%3E(javax.xml.stream.XMLEventReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLEventReader"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public StAXSource(Javax.Xml.Stream.XMLEventReader arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXSource.html#%3Cinit%3E(javax.xml.stream.XMLStreamReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLStreamReader"/></param>
        public StAXSource(Javax.Xml.Stream.XMLStreamReader arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Transform.Stax.StAXSource"/> to <see cref="Javax.Xml.Transform.Source"/>
        /// </summary>
        public static implicit operator Javax.Xml.Transform.Source(Javax.Xml.Transform.Stax.StAXSource t) => t.Cast<Javax.Xml.Transform.Source>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXSource.html#FEATURE"/>
        /// </summary>
        public static string FEATURE => Clazz.GetField<string>("FEATURE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXSource.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXSource.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXSource.html#setSystemId(java.lang.String)"/>
        /// </summary>
        public string SystemId
        {
            get { return IExecute<string>("getSystemId"); } set { IExecute("setSystemId", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXSource.html#getXMLEventReader()"/> 
        /// </summary>
        public Javax.Xml.Stream.XMLEventReader XMLEventReader
        {
            get { return IExecute<Javax.Xml.Stream.XMLEventReader>("getXMLEventReader"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXSource.html#getXMLStreamReader()"/> 
        /// </summary>
        public Javax.Xml.Stream.XMLStreamReader XMLStreamReader
        {
            get { return IExecute<Javax.Xml.Stream.XMLStreamReader>("getXMLStreamReader"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}