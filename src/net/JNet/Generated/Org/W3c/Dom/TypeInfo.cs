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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom
{
    #region ITypeInfo
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITypeInfo
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#getTypeName()"/> 
        /// </summary>
        Java.Lang.String TypeName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#getTypeNamespace()"/> 
        /// </summary>
        Java.Lang.String TypeNamespace { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#isDerivedFrom(java.lang.String,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsDerivedFrom(Java.Lang.String arg0, Java.Lang.String arg1, int arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TypeInfo
    public partial class TypeInfo : Org.W3c.Dom.ITypeInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#DERIVATION_EXTENSION"/>
        /// </summary>
        public static int DERIVATION_EXTENSION { get { if (!_DERIVATION_EXTENSIONReady) { _DERIVATION_EXTENSIONContent = SGetField<int>(LocalBridgeClazz, "DERIVATION_EXTENSION"); _DERIVATION_EXTENSIONReady = true; } return _DERIVATION_EXTENSIONContent; } }
        private static int _DERIVATION_EXTENSIONContent = default;
        private static bool _DERIVATION_EXTENSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#DERIVATION_LIST"/>
        /// </summary>
        public static int DERIVATION_LIST { get { if (!_DERIVATION_LISTReady) { _DERIVATION_LISTContent = SGetField<int>(LocalBridgeClazz, "DERIVATION_LIST"); _DERIVATION_LISTReady = true; } return _DERIVATION_LISTContent; } }
        private static int _DERIVATION_LISTContent = default;
        private static bool _DERIVATION_LISTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#DERIVATION_RESTRICTION"/>
        /// </summary>
        public static int DERIVATION_RESTRICTION { get { if (!_DERIVATION_RESTRICTIONReady) { _DERIVATION_RESTRICTIONContent = SGetField<int>(LocalBridgeClazz, "DERIVATION_RESTRICTION"); _DERIVATION_RESTRICTIONReady = true; } return _DERIVATION_RESTRICTIONContent; } }
        private static int _DERIVATION_RESTRICTIONContent = default;
        private static bool _DERIVATION_RESTRICTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#DERIVATION_UNION"/>
        /// </summary>
        public static int DERIVATION_UNION { get { if (!_DERIVATION_UNIONReady) { _DERIVATION_UNIONContent = SGetField<int>(LocalBridgeClazz, "DERIVATION_UNION"); _DERIVATION_UNIONReady = true; } return _DERIVATION_UNIONContent; } }
        private static int _DERIVATION_UNIONContent = default;
        private static bool _DERIVATION_UNIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#getTypeName()"/> 
        /// </summary>
        public Java.Lang.String TypeName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTypeName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#getTypeNamespace()"/> 
        /// </summary>
        public Java.Lang.String TypeNamespace
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTypeNamespace", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/TypeInfo.html#isDerivedFrom(java.lang.String,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDerivedFrom(Java.Lang.String arg0, Java.Lang.String arg1, int arg2)
        {
            return IExecute<bool>("isDerivedFrom", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}