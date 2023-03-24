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

namespace Javax.Xml.Catalog
{
    #region CatalogFeatures
    public partial class CatalogFeatures
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.html#defaults()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Xml.Catalog.CatalogFeatures"/></returns>
        public static Javax.Xml.Catalog.CatalogFeatures Defaults()
        {
            return SExecute<Javax.Xml.Catalog.CatalogFeatures>("defaults");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.html#builder()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Xml.Catalog.CatalogFeatures.Builder"/></returns>
        public static Javax.Xml.Catalog.CatalogFeatures.Builder BuilderMethod()
        {
            return SExecute<Javax.Xml.Catalog.CatalogFeatures.Builder>("builder");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.html#get(javax.xml.catalog.CatalogFeatures$Feature)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Catalog.CatalogFeatures.Feature"/></param>
        /// <returns><see cref="string"/></returns>
        public string Get(Javax.Xml.Catalog.CatalogFeatures.Feature arg0)
        {
            return IExecute<string>("get", arg0);
        }
        
        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Builder.html#build()"/>
            /// </summary>
            
            /// <returns><see cref="Javax.Xml.Catalog.CatalogFeatures"/></returns>
            public Javax.Xml.Catalog.CatalogFeatures Build()
            {
                return IExecute<Javax.Xml.Catalog.CatalogFeatures>("build");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Builder.html#with(javax.xml.catalog.CatalogFeatures$Feature,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Xml.Catalog.CatalogFeatures.Feature"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <returns><see cref="Javax.Xml.Catalog.CatalogFeatures.Builder"/></returns>
            public Javax.Xml.Catalog.CatalogFeatures.Builder With(Javax.Xml.Catalog.CatalogFeatures.Feature arg0, string arg1)
            {
                return IExecute<Javax.Xml.Catalog.CatalogFeatures.Builder>("with", arg0, arg1);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Feature
        public partial class Feature
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#DEFER"/>
            /// </summary>
            public static Javax.Xml.Catalog.CatalogFeatures.Feature DEFER => Clazz.GetField<Javax.Xml.Catalog.CatalogFeatures.Feature>("DEFER");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#FILES"/>
            /// </summary>
            public static Javax.Xml.Catalog.CatalogFeatures.Feature FILES => Clazz.GetField<Javax.Xml.Catalog.CatalogFeatures.Feature>("FILES");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#PREFER"/>
            /// </summary>
            public static Javax.Xml.Catalog.CatalogFeatures.Feature PREFER => Clazz.GetField<Javax.Xml.Catalog.CatalogFeatures.Feature>("PREFER");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#RESOLVE"/>
            /// </summary>
            public static Javax.Xml.Catalog.CatalogFeatures.Feature RESOLVE => Clazz.GetField<Javax.Xml.Catalog.CatalogFeatures.Feature>("RESOLVE");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Xml.Catalog.CatalogFeatures.Feature"/></returns>
            public static Javax.Xml.Catalog.CatalogFeatures.Feature ValueOf(string arg0)
            {
                return SExecute<Javax.Xml.Catalog.CatalogFeatures.Feature>("valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#values()"/>
            /// </summary>
            
            /// <returns><see cref="Javax.Xml.Catalog.CatalogFeatures.Feature"/></returns>
            public static Javax.Xml.Catalog.CatalogFeatures.Feature[] Values()
            {
                return SExecuteArray<Javax.Xml.Catalog.CatalogFeatures.Feature>("values");
            }
            
            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#getPropertyName()"/> 
            /// </summary>
            public string PropertyName
            {
                get { return IExecute<string>("getPropertyName"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#defaultValue()"/>
            /// </summary>
            
            /// <returns><see cref="string"/></returns>
            public string DefaultValue()
            {
                return IExecute<string>("defaultValue");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}