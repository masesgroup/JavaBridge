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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Openmbean
{
    #region OpenType
    public partial class OpenType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#ALLOWED_CLASSNAMES_LIST"/>
        /// </summary>
        public static Java.Util.List ALLOWED_CLASSNAMES_LIST { get { if (!_ALLOWED_CLASSNAMES_LISTReady) { _ALLOWED_CLASSNAMES_LISTContent = SGetField<Java.Util.List>(LocalBridgeClazz, "ALLOWED_CLASSNAMES_LIST"); _ALLOWED_CLASSNAMES_LISTReady = true; } return _ALLOWED_CLASSNAMES_LISTContent; } }
        private static Java.Util.List _ALLOWED_CLASSNAMES_LISTContent = default;
        private static bool _ALLOWED_CLASSNAMES_LISTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#getClassName()"/> 
        /// </summary>
        public Java.Lang.String ClassName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getClassName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#getDescription()"/> 
        /// </summary>
        public Java.Lang.String Description
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#getTypeName()"/> 
        /// </summary>
        public Java.Lang.String TypeName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTypeName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#isValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsValue(object arg0)
        {
            return IExecuteWithSignature<bool>("isValue", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#isArray()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsArray()
        {
            return IExecuteWithSignature<bool>("isArray", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OpenType<T>
    public partial class OpenType<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Openmbean.OpenType{T}"/> to <see cref="Javax.Management.Openmbean.OpenType"/>
        /// </summary>
        public static implicit operator Javax.Management.Openmbean.OpenType(Javax.Management.Openmbean.OpenType<T> t) => t.Cast<Javax.Management.Openmbean.OpenType>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#ALLOWED_CLASSNAMES_LIST"/>
        /// </summary>
        public static Java.Util.List<Java.Lang.String> ALLOWED_CLASSNAMES_LIST { get { if (!_ALLOWED_CLASSNAMES_LISTReady) { _ALLOWED_CLASSNAMES_LISTContent = SGetField<Java.Util.List<Java.Lang.String>>(LocalBridgeClazz, "ALLOWED_CLASSNAMES_LIST"); _ALLOWED_CLASSNAMES_LISTReady = true; } return _ALLOWED_CLASSNAMES_LISTContent; } }
        private static Java.Util.List<Java.Lang.String> _ALLOWED_CLASSNAMES_LISTContent = default;
        private static bool _ALLOWED_CLASSNAMES_LISTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#getClassName()"/> 
        /// </summary>
        public Java.Lang.String ClassName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getClassName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#getDescription()"/> 
        /// </summary>
        public Java.Lang.String Description
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#getTypeName()"/> 
        /// </summary>
        public Java.Lang.String TypeName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTypeName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#isValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsValue(object arg0)
        {
            return IExecuteWithSignature<bool>("isValue", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenType.html#isArray()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsArray()
        {
            return IExecuteWithSignature<bool>("isArray", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}