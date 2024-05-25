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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Bootstrap
{
    #region DOMImplementationRegistry
    public partial class DOMImplementationRegistry
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/bootstrap/DOMImplementationRegistry.html#PROPERTY"/>
        /// </summary>
        public static Java.Lang.String PROPERTY { get { if (!_PROPERTYReady) { _PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PROPERTY"); _PROPERTYReady = true; } return _PROPERTYContent; } }
        private static Java.Lang.String _PROPERTYContent = default;
        private static bool _PROPERTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/bootstrap/DOMImplementationRegistry.html#newInstance()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Bootstrap.DOMImplementationRegistry"/></returns>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Java.Lang.InstantiationException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        /// <exception cref="Java.Lang.ClassCastException"/>
        public static Org.W3c.Dom.Bootstrap.DOMImplementationRegistry NewInstance()
        {
            return SExecuteWithSignature<Org.W3c.Dom.Bootstrap.DOMImplementationRegistry>(LocalBridgeClazz, "newInstance", "()Lorg/w3c/dom/bootstrap/DOMImplementationRegistry;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/bootstrap/DOMImplementationRegistry.html#getDOMImplementation(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.DOMImplementation"/></returns>
        public Org.W3c.Dom.DOMImplementation GetDOMImplementation(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.DOMImplementation>("getDOMImplementation", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementation;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/bootstrap/DOMImplementationRegistry.html#getDOMImplementationList(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.DOMImplementationList"/></returns>
        public Org.W3c.Dom.DOMImplementationList GetDOMImplementationList(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.DOMImplementationList>("getDOMImplementationList", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementationList;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/bootstrap/DOMImplementationRegistry.html#addSource(org.w3c.dom.DOMImplementationSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.DOMImplementationSource"/></param>
        public void AddSource(Org.W3c.Dom.DOMImplementationSource arg0)
        {
            IExecuteWithSignature("addSource", "(Lorg/w3c/dom/DOMImplementationSource;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}