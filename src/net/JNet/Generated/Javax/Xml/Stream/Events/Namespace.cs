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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream.Events
{
    #region Namespace
    public partial class Namespace
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Stream.Events.Namespace"/> to <see cref="Javax.Xml.Stream.Events.Attribute"/>
        /// </summary>
        public static implicit operator Javax.Xml.Stream.Events.Attribute(Javax.Xml.Stream.Events.Namespace t) => t.Cast<Javax.Xml.Stream.Events.Attribute>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Namespace.html#getNamespaceURI()"/> 
        /// </summary>
        public string NamespaceURI
        {
            get { return IExecute<string>("getNamespaceURI"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Namespace.html#getPrefix()"/> 
        /// </summary>
        public string Prefix
        {
            get { return IExecute<string>("getPrefix"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Namespace.html#isDefaultNamespaceDeclaration()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsDefaultNamespaceDeclaration()
        {
            return IExecute<bool>("isDefaultNamespaceDeclaration");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}