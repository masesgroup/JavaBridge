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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Xml.Sax.Ext
{
    #region IEntityResolver2
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IEntityResolver2 : Org.Xml.Sax.IEntityResolver
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/EntityResolver2.html#getExternalSubset(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Xml.Sax.InputSource"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        Org.Xml.Sax.InputSource GetExternalSubset(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/EntityResolver2.html#resolveEntity(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Xml.Sax.InputSource"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        Org.Xml.Sax.InputSource ResolveEntity(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EntityResolver2
    public partial class EntityResolver2 : Org.Xml.Sax.Ext.IEntityResolver2
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/EntityResolver2.html#getExternalSubset(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Xml.Sax.InputSource"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Org.Xml.Sax.InputSource GetExternalSubset(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Org.Xml.Sax.InputSource>("getExternalSubset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/EntityResolver2.html#resolveEntity(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Xml.Sax.InputSource"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Org.Xml.Sax.InputSource ResolveEntity(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3)
        {
            return IExecute<Org.Xml.Sax.InputSource>("resolveEntity", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}