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

namespace Javax.Xml.Stream.Events
{
    #region INamespace
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface INamespace : Javax.Xml.Stream.Events.IAttribute
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Namespace.html#getNamespaceURI()"/> 
        /// </summary>
        Java.Lang.String NamespaceURI { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Namespace.html#getPrefix()"/> 
        /// </summary>
        Java.Lang.String Prefix { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Namespace.html#isDefaultNamespaceDeclaration()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsDefaultNamespaceDeclaration();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Namespace
    public partial class Namespace : Javax.Xml.Stream.Events.INamespace
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Namespace.html#getNamespaceURI()"/> 
        /// </summary>
        public Java.Lang.String NamespaceURI
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNamespaceURI", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Namespace.html#getPrefix()"/> 
        /// </summary>
        public Java.Lang.String Prefix
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPrefix", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Namespace.html#isDefaultNamespaceDeclaration()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDefaultNamespaceDeclaration()
        {
            return IExecuteWithSignature<bool>("isDefaultNamespaceDeclaration", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}