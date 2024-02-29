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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream.Events
{
    #region IStartDocument
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IStartDocument : Javax.Xml.Stream.Events.IXMLEvent
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartDocument.html#getCharacterEncodingScheme()"/> 
        /// </summary>
        Java.Lang.String CharacterEncodingScheme { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartDocument.html#getSystemId()"/> 
        /// </summary>
        Java.Lang.String SystemId { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartDocument.html#getVersion()"/> 
        /// </summary>
        Java.Lang.String Version { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartDocument.html#encodingSet()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool EncodingSet();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartDocument.html#isStandalone()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsStandalone();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartDocument.html#standaloneSet()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool StandaloneSet();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StartDocument
    public partial class StartDocument : Javax.Xml.Stream.Events.IStartDocument
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartDocument.html#getCharacterEncodingScheme()"/> 
        /// </summary>
        public Java.Lang.String CharacterEncodingScheme
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCharacterEncodingScheme", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartDocument.html#getSystemId()"/> 
        /// </summary>
        public Java.Lang.String SystemId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSystemId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartDocument.html#getVersion()"/> 
        /// </summary>
        public Java.Lang.String Version
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVersion", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartDocument.html#encodingSet()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool EncodingSet()
        {
            return IExecuteWithSignature<bool>("encodingSet", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartDocument.html#isStandalone()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsStandalone()
        {
            return IExecuteWithSignature<bool>("isStandalone", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/StartDocument.html#standaloneSet()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool StandaloneSet()
        {
            return IExecuteWithSignature<bool>("standaloneSet", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}