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

namespace Javax.Xml.Crypto
{
    #region NodeSetData
    public partial class NodeSetData
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.NodeSetData"/> to <see cref="Javax.Xml.Crypto.Data"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.Data(Javax.Xml.Crypto.NodeSetData t) => t.Cast<Javax.Xml.Crypto.Data>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/NodeSetData.html#iterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecute<Java.Util.Iterator>("iterator");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region INodeSetData<T>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface INodeSetData<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/NodeSetData.html#iterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        Java.Util.Iterator<T> Iterator();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NodeSetData<T>
    public partial class NodeSetData<T> : Javax.Xml.Crypto.INodeSetData<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.NodeSetData{T}"/> to <see cref="Javax.Xml.Crypto.Data"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.Data(Javax.Xml.Crypto.NodeSetData<T> t) => t.Cast<Javax.Xml.Crypto.Data>();
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.NodeSetData{T}"/> to <see cref="Javax.Xml.Crypto.NodeSetData"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.NodeSetData(Javax.Xml.Crypto.NodeSetData<T> t) => t.Cast<Javax.Xml.Crypto.NodeSetData>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/NodeSetData.html#iterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<T> Iterator()
        {
            return IExecute<Java.Util.Iterator<T>>("iterator");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}