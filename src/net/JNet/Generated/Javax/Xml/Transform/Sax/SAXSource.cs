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

namespace Javax.Xml.Transform.Sax
{
    #region SAXSource
    public partial class SAXSource
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#%3Cinit%3E(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        public SAXSource(Org.Xml.Sax.InputSource arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#%3Cinit%3E(org.xml.sax.XMLReader,org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.XMLReader"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        public SAXSource(Org.Xml.Sax.XMLReader arg0, Org.Xml.Sax.InputSource arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#FEATURE"/>
        /// </summary>
        public static Java.Lang.String FEATURE { get { if (!_FEATUREReady) { _FEATUREContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE"); _FEATUREReady = true; } return _FEATUREContent; } }
        private static Java.Lang.String _FEATUREContent = default;
        private static bool _FEATUREReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#sourceToInputSource(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Org.Xml.Sax.InputSource"/></returns>
        public static Org.Xml.Sax.InputSource SourceToInputSource(Javax.Xml.Transform.Source arg0)
        {
            return SExecuteWithSignature<Org.Xml.Sax.InputSource>(LocalBridgeClazz, "sourceToInputSource", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/InputSource;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#getInputSource()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#setInputSource(org.xml.sax.InputSource)"/>
        /// </summary>
        public Org.Xml.Sax.InputSource InputSource
        {
            get { return IExecuteWithSignature<Org.Xml.Sax.InputSource>("getInputSource", "()Lorg/xml/sax/InputSource;"); } set { IExecuteWithSignature("setInputSource", "(Lorg/xml/sax/InputSource;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#setSystemId(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String SystemId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSystemId", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setSystemId", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#getXMLReader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#setXMLReader(org.xml.sax.XMLReader)"/>
        /// </summary>
        public Org.Xml.Sax.XMLReader XMLReader
        {
            get { return IExecuteWithSignature<Org.Xml.Sax.XMLReader>("getXMLReader", "()Lorg/xml/sax/XMLReader;"); } set { IExecuteWithSignature("setXMLReader", "(Lorg/xml/sax/XMLReader;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#isEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}