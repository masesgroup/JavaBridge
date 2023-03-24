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

namespace Javax.Xml.Transform.Sax
{
    #region SAXResult
    public partial class SAXResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXResult.html#%3Cinit%3E(org.xml.sax.ContentHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.ContentHandler"/></param>
        public SAXResult(Org.Xml.Sax.ContentHandler arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Transform.Sax.SAXResult"/> to <see cref="Javax.Xml.Transform.Result"/>
        /// </summary>
        public static implicit operator Javax.Xml.Transform.Result(Javax.Xml.Transform.Sax.SAXResult t) => t.Cast<Javax.Xml.Transform.Result>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXResult.html#FEATURE"/>
        /// </summary>
        public static string FEATURE => Clazz.GetField<string>("FEATURE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXResult.html#getHandler()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXResult.html#setHandler(org.xml.sax.ContentHandler)"/>
        /// </summary>
        public Org.Xml.Sax.ContentHandler Handler
        {
            get { return IExecute<Org.Xml.Sax.ContentHandler>("getHandler"); } set { IExecute("setHandler", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXResult.html#getLexicalHandler()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXResult.html#setLexicalHandler(org.xml.sax.ext.LexicalHandler)"/>
        /// </summary>
        public Org.Xml.Sax.Ext.LexicalHandler LexicalHandler
        {
            get { return IExecute<Org.Xml.Sax.Ext.LexicalHandler>("getLexicalHandler"); } set { IExecute("setLexicalHandler", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXResult.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXResult.html#setSystemId(java.lang.String)"/>
        /// </summary>
        public string SystemId
        {
            get { return IExecute<string>("getSystemId"); } set { IExecute("setSystemId", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}