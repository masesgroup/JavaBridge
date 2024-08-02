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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom
{
    #region IDOMError
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDOMError
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#getLocation()"/> 
        /// </summary>
        Org.W3c.Dom.DOMLocator Location { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#getMessage()"/> 
        /// </summary>
        Java.Lang.String Message { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#getRelatedData()"/> 
        /// </summary>
        object RelatedData { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#getRelatedException()"/> 
        /// </summary>
        object RelatedException { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#getSeverity()"/> 
        /// </summary>
        short Severity { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#getType()"/> 
        /// </summary>
        Java.Lang.String Type { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DOMError
    public partial class DOMError : Org.W3c.Dom.IDOMError
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#SEVERITY_ERROR"/>
        /// </summary>
        public static short SEVERITY_ERROR { get { if (!_SEVERITY_ERRORReady) { _SEVERITY_ERRORContent = SGetField<short>(LocalBridgeClazz, "SEVERITY_ERROR"); _SEVERITY_ERRORReady = true; } return _SEVERITY_ERRORContent; } }
        private static short _SEVERITY_ERRORContent = default;
        private static bool _SEVERITY_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#SEVERITY_FATAL_ERROR"/>
        /// </summary>
        public static short SEVERITY_FATAL_ERROR { get { if (!_SEVERITY_FATAL_ERRORReady) { _SEVERITY_FATAL_ERRORContent = SGetField<short>(LocalBridgeClazz, "SEVERITY_FATAL_ERROR"); _SEVERITY_FATAL_ERRORReady = true; } return _SEVERITY_FATAL_ERRORContent; } }
        private static short _SEVERITY_FATAL_ERRORContent = default;
        private static bool _SEVERITY_FATAL_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#SEVERITY_WARNING"/>
        /// </summary>
        public static short SEVERITY_WARNING { get { if (!_SEVERITY_WARNINGReady) { _SEVERITY_WARNINGContent = SGetField<short>(LocalBridgeClazz, "SEVERITY_WARNING"); _SEVERITY_WARNINGReady = true; } return _SEVERITY_WARNINGContent; } }
        private static short _SEVERITY_WARNINGContent = default;
        private static bool _SEVERITY_WARNINGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#getLocation()"/> 
        /// </summary>
        public Org.W3c.Dom.DOMLocator Location
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.DOMLocator>("getLocation", "()Lorg/w3c/dom/DOMLocator;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#getMessage()"/> 
        /// </summary>
        public Java.Lang.String Message
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMessage", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#getRelatedData()"/> 
        /// </summary>
        public object RelatedData
        {
            get { return IExecuteWithSignature("getRelatedData", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#getRelatedException()"/> 
        /// </summary>
        public object RelatedException
        {
            get { return IExecuteWithSignature("getRelatedException", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#getSeverity()"/> 
        /// </summary>
        public short Severity
        {
            get { return IExecuteWithSignature<short>("getSeverity", "()S"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DOMError.html#getType()"/> 
        /// </summary>
        public Java.Lang.String Type
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getType", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}