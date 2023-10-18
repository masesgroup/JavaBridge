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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream.Events
{
    #region IDTD
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDTD : Javax.Xml.Stream.Events.IXMLEvent
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/DTD.html#getDocumentTypeDeclaration()"/> 
        /// </summary>
        string DocumentTypeDeclaration { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/DTD.html#getEntities()"/> 
        /// </summary>
        Java.Util.List<Javax.Xml.Stream.Events.EntityDeclaration> Entities { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/DTD.html#getNotations()"/> 
        /// </summary>
        Java.Util.List<Javax.Xml.Stream.Events.NotationDeclaration> Notations { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/DTD.html#getProcessedDTD()"/> 
        /// </summary>
        object ProcessedDTD { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DTD
    public partial class DTD : Javax.Xml.Stream.Events.IDTD
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/DTD.html#getDocumentTypeDeclaration()"/> 
        /// </summary>
        public string DocumentTypeDeclaration
        {
            get { return IExecute<string>("getDocumentTypeDeclaration"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/DTD.html#getEntities()"/> 
        /// </summary>
        public Java.Util.List<Javax.Xml.Stream.Events.EntityDeclaration> Entities
        {
            get { return IExecute<Java.Util.List<Javax.Xml.Stream.Events.EntityDeclaration>>("getEntities"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/DTD.html#getNotations()"/> 
        /// </summary>
        public Java.Util.List<Javax.Xml.Stream.Events.NotationDeclaration> Notations
        {
            get { return IExecute<Java.Util.List<Javax.Xml.Stream.Events.NotationDeclaration>>("getNotations"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/DTD.html#getProcessedDTD()"/> 
        /// </summary>
        public object ProcessedDTD
        {
            get { return IExecute("getProcessedDTD"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}