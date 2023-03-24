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
    #region TransformerHandler
    public partial class TransformerHandler
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Transform.Sax.TransformerHandler"/> to <see cref="Org.Xml.Sax.ContentHandler"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.ContentHandler(Javax.Xml.Transform.Sax.TransformerHandler t) => t.Cast<Org.Xml.Sax.ContentHandler>();
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Transform.Sax.TransformerHandler"/> to <see cref="Org.Xml.Sax.Ext.LexicalHandler"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.Ext.LexicalHandler(Javax.Xml.Transform.Sax.TransformerHandler t) => t.Cast<Org.Xml.Sax.Ext.LexicalHandler>();
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Transform.Sax.TransformerHandler"/> to <see cref="Org.Xml.Sax.DTDHandler"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.DTDHandler(Javax.Xml.Transform.Sax.TransformerHandler t) => t.Cast<Org.Xml.Sax.DTDHandler>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/TransformerHandler.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/TransformerHandler.html#setSystemId(java.lang.String)"/>
        /// </summary>
        public string SystemId
        {
            get { return IExecute<string>("getSystemId"); } set { IExecute("setSystemId", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/TransformerHandler.html#getTransformer()"/> 
        /// </summary>
        public Javax.Xml.Transform.Transformer Transformer
        {
            get { return IExecute<Javax.Xml.Transform.Transformer>("getTransformer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/TransformerHandler.html#setResult(javax.xml.transform.Result)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Result"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetResult(Javax.Xml.Transform.Result arg0)
        {
            IExecute("setResult", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}