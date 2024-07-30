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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Xml.Sax
{
    #region IErrorHandler
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IErrorHandler
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ErrorHandler.html#error(org.xml.sax.SAXParseException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.SAXParseException"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        void Error(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ErrorHandler.html#fatalError(org.xml.sax.SAXParseException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.SAXParseException"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        void FatalError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ErrorHandler.html#warning(org.xml.sax.SAXParseException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.SAXParseException"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        void Warning(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ErrorHandler
    public partial class ErrorHandler : Org.Xml.Sax.IErrorHandler
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ErrorHandler.html#error(org.xml.sax.SAXParseException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.SAXParseException"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void Error(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("error", "(Lorg/xml/sax/SAXParseException;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ErrorHandler.html#fatalError(org.xml.sax.SAXParseException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.SAXParseException"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void FatalError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("fatalError", "(Lorg/xml/sax/SAXParseException;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ErrorHandler.html#warning(org.xml.sax.SAXParseException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.SAXParseException"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void Warning(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("warning", "(Lorg/xml/sax/SAXParseException;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}