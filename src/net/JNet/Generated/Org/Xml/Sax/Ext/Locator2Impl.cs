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

namespace Org.Xml.Sax.Ext
{
    #region Locator2Impl
    public partial class Locator2Impl
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/Locator2Impl.html#%3Cinit%3E(org.xml.sax.Locator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.Locator"/></param>
        public Locator2Impl(Org.Xml.Sax.Locator arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Xml.Sax.Ext.Locator2Impl"/> to <see cref="Org.Xml.Sax.Ext.Locator2"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.Ext.Locator2(Org.Xml.Sax.Ext.Locator2Impl t) => t.Cast<Org.Xml.Sax.Ext.Locator2>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/Locator2Impl.html#getEncoding()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/Locator2Impl.html#setEncoding(java.lang.String)"/>
        /// </summary>
        public string Encoding
        {
            get { return IExecute<string>("getEncoding"); } set { IExecute("setEncoding", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/Locator2Impl.html#getXMLVersion()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/Locator2Impl.html#setXMLVersion(java.lang.String)"/>
        /// </summary>
        public string XMLVersion
        {
            get { return IExecute<string>("getXMLVersion"); } set { IExecute("setXMLVersion", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}