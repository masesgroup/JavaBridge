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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream
{
    #region ILocation
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILocation
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/Location.html#getCharacterOffset()"/> 
        /// </summary>
        int CharacterOffset { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/Location.html#getColumnNumber()"/> 
        /// </summary>
        int ColumnNumber { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/Location.html#getLineNumber()"/> 
        /// </summary>
        int LineNumber { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/Location.html#getPublicId()"/> 
        /// </summary>
        Java.Lang.String PublicId { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/Location.html#getSystemId()"/> 
        /// </summary>
        Java.Lang.String SystemId { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Location
    public partial class Location : Javax.Xml.Stream.ILocation
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/Location.html#getCharacterOffset()"/> 
        /// </summary>
        public int CharacterOffset
        {
            get { return IExecuteWithSignature<int>("getCharacterOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/Location.html#getColumnNumber()"/> 
        /// </summary>
        public int ColumnNumber
        {
            get { return IExecuteWithSignature<int>("getColumnNumber", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/Location.html#getLineNumber()"/> 
        /// </summary>
        public int LineNumber
        {
            get { return IExecuteWithSignature<int>("getLineNumber", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/Location.html#getPublicId()"/> 
        /// </summary>
        public Java.Lang.String PublicId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPublicId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/Location.html#getSystemId()"/> 
        /// </summary>
        public Java.Lang.String SystemId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSystemId", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}