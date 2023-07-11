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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Transform
{
    #region ITemplates
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITemplates
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/Templates.html#getOutputProperties()"/> 
        /// </summary>
        Java.Util.Properties OutputProperties { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/Templates.html#newTransformer()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Transform.Transformer"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        Javax.Xml.Transform.Transformer NewTransformer();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Templates
    public partial class Templates : Javax.Xml.Transform.ITemplates
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/Templates.html#getOutputProperties()"/> 
        /// </summary>
        public Java.Util.Properties OutputProperties
        {
            get { return IExecute<Java.Util.Properties>("getOutputProperties"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/Templates.html#newTransformer()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Transform.Transformer"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Transformer NewTransformer()
        {
            return IExecute<Javax.Xml.Transform.Transformer>("newTransformer");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}