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

namespace Javax.Xml.Parsers
{
    #region DocumentBuilderFactory
    public partial class DocumentBuilderFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#newDefaultInstance()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Parsers.DocumentBuilderFactory"/></returns>
        public static Javax.Xml.Parsers.DocumentBuilderFactory NewDefaultInstance()
        {
            return SExecute<Javax.Xml.Parsers.DocumentBuilderFactory>(LocalBridgeClazz, "newDefaultInstance");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#newInstance()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Parsers.DocumentBuilderFactory"/></returns>
        public static Javax.Xml.Parsers.DocumentBuilderFactory NewInstance()
        {
            return SExecute<Javax.Xml.Parsers.DocumentBuilderFactory>(LocalBridgeClazz, "newInstance");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#newInstance(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Parsers.DocumentBuilderFactory"/></returns>
        public static Javax.Xml.Parsers.DocumentBuilderFactory NewInstance(string arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Javax.Xml.Parsers.DocumentBuilderFactory>(LocalBridgeClazz, "newInstance", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#getSchema()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#setSchema(javax.xml.validation.Schema)"/>
        /// </summary>
        public Javax.Xml.Validation.Schema Schema
        {
            get { return IExecute<Javax.Xml.Validation.Schema>("getSchema"); } set { IExecute("setSchema", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
        public bool GetFeature(string arg0)
        {
            return IExecute<bool>("getFeature", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public object GetAttribute(string arg0)
        {
            return IExecute("getAttribute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#newDocumentBuilder()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Parsers.DocumentBuilder"/></returns>
        /// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
        public Javax.Xml.Parsers.DocumentBuilder NewDocumentBuilder()
        {
            return IExecute<Javax.Xml.Parsers.DocumentBuilder>("newDocumentBuilder");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#setAttribute(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetAttribute(string arg0, object arg1)
        {
            IExecute("setAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
        public void SetFeature(string arg0, bool arg1)
        {
            IExecute("setFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#isCoalescing()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCoalescing()
        {
            return IExecute<bool>("isCoalescing");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#isExpandEntityReferences()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsExpandEntityReferences()
        {
            return IExecute<bool>("isExpandEntityReferences");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#isIgnoringComments()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsIgnoringComments()
        {
            return IExecute<bool>("isIgnoringComments");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#isIgnoringElementContentWhitespace()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsIgnoringElementContentWhitespace()
        {
            return IExecute<bool>("isIgnoringElementContentWhitespace");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#isNamespaceAware()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsNamespaceAware()
        {
            return IExecute<bool>("isNamespaceAware");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#isValidating()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsValidating()
        {
            return IExecute<bool>("isValidating");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#isXIncludeAware()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsXIncludeAware()
        {
            return IExecute<bool>("isXIncludeAware");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#setCoalescing(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCoalescing(bool arg0)
        {
            IExecute("setCoalescing", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#setExpandEntityReferences(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetExpandEntityReferences(bool arg0)
        {
            IExecute("setExpandEntityReferences", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#setIgnoringComments(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetIgnoringComments(bool arg0)
        {
            IExecute("setIgnoringComments", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#setIgnoringElementContentWhitespace(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetIgnoringElementContentWhitespace(bool arg0)
        {
            IExecute("setIgnoringElementContentWhitespace", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#setNamespaceAware(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetNamespaceAware(bool arg0)
        {
            IExecute("setNamespaceAware", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#setValidating(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetValidating(bool arg0)
        {
            IExecute("setValidating", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/DocumentBuilderFactory.html#setXIncludeAware(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetXIncludeAware(bool arg0)
        {
            IExecute("setXIncludeAware", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}