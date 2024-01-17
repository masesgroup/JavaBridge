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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Parsers
{
    #region SAXParserFactory
    public partial class SAXParserFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#newDefaultInstance()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Parsers.SAXParserFactory"/></returns>
        public static Javax.Xml.Parsers.SAXParserFactory NewDefaultInstance()
        {
            return SExecute<Javax.Xml.Parsers.SAXParserFactory>(LocalBridgeClazz, "newDefaultInstance");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#newInstance()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Parsers.SAXParserFactory"/></returns>
        public static Javax.Xml.Parsers.SAXParserFactory NewInstance()
        {
            return SExecute<Javax.Xml.Parsers.SAXParserFactory>(LocalBridgeClazz, "newInstance");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#newInstance(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Parsers.SAXParserFactory"/></returns>
        public static Javax.Xml.Parsers.SAXParserFactory NewInstance(string arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Javax.Xml.Parsers.SAXParserFactory>(LocalBridgeClazz, "newInstance", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#getSchema()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#setSchema(javax.xml.validation.Schema)"/>
        /// </summary>
        public Javax.Xml.Validation.Schema Schema
        {
            get { return IExecute<Javax.Xml.Validation.Schema>("getSchema"); } set { IExecute("setSchema", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public bool GetFeature(string arg0)
        {
            return IExecute<bool>("getFeature", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#newSAXParser()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Parsers.SAXParser"/></returns>
        /// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public Javax.Xml.Parsers.SAXParser NewSAXParser()
        {
            return IExecute<Javax.Xml.Parsers.SAXParser>("newSAXParser");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetFeature(string arg0, bool arg1)
        {
            IExecute("setFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#isNamespaceAware()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsNamespaceAware()
        {
            return IExecute<bool>("isNamespaceAware");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#isValidating()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsValidating()
        {
            return IExecute<bool>("isValidating");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#isXIncludeAware()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsXIncludeAware()
        {
            return IExecute<bool>("isXIncludeAware");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#setNamespaceAware(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetNamespaceAware(bool arg0)
        {
            IExecute("setNamespaceAware", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#setValidating(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetValidating(bool arg0)
        {
            IExecute("setValidating", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#setXIncludeAware(boolean)"/>
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