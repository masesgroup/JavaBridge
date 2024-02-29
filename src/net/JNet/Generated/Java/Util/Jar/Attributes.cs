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

namespace Java.Util.Jar
{
    #region Attributes
    public partial class Attributes
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Attributes(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#%3Cinit%3E(java.util.jar.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Jar.Attributes"/></param>
        public Attributes(Java.Util.Jar.Attributes arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Jar.Attributes"/> to <see cref="Java.Util.Map"/>
        /// </summary>
        public static implicit operator Java.Util.Map(Java.Util.Jar.Attributes t) => t.Cast<Java.Util.Map>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Jar.Attributes"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Jar.Attributes t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#containsKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(object arg0)
        {
            return IExecuteWithSignature<bool>("containsKey", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#containsValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsValue(object arg0)
        {
            return IExecuteWithSignature<bool>("containsValue", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#isEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#size()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(object arg0)
        {
            return IExecuteWithSignature("get", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#put(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Put(object arg0, object arg1)
        {
            return IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Remove(object arg0)
        {
            return IExecuteWithSignature("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetValue(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getValue", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#getValue(java.util.jar.Attributes.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Jar.Attributes.Name"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetValue(Java.Util.Jar.Attributes.Name arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getValue", "(Ljava/util/jar/Attributes$Name;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#putValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String PutValue(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("putValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<object> Values()
        {
            return IExecuteWithSignature<Java.Util.Collection<object>>("values", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#keySet()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<object> KeySet()
        {
            return IExecuteWithSignature<Java.Util.Set<object>>("keySet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#entrySet()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Util.Map.Entry<object, object>> EntrySet()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Util.Map.Entry<object, object>>>("entrySet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.html#putAll(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void PutAll(Java.Util.Map<object, object> arg0)
        {
            IExecuteWithSignature("putAll", "(Ljava/util/Map;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Name
        public partial class Name
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public Name(Java.Lang.String arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#CLASS_PATH"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name CLASS_PATH { get { if (!_CLASS_PATHReady) { _CLASS_PATHContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "CLASS_PATH"); _CLASS_PATHReady = true; } return _CLASS_PATHContent; } }
            private static Java.Util.Jar.Attributes.Name _CLASS_PATHContent = default;
            private static bool _CLASS_PATHReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#CONTENT_TYPE"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name CONTENT_TYPE { get { if (!_CONTENT_TYPEReady) { _CONTENT_TYPEContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "CONTENT_TYPE"); _CONTENT_TYPEReady = true; } return _CONTENT_TYPEContent; } }
            private static Java.Util.Jar.Attributes.Name _CONTENT_TYPEContent = default;
            private static bool _CONTENT_TYPEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#EXTENSION_LIST"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name EXTENSION_LIST { get { if (!_EXTENSION_LISTReady) { _EXTENSION_LISTContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "EXTENSION_LIST"); _EXTENSION_LISTReady = true; } return _EXTENSION_LISTContent; } }
            private static Java.Util.Jar.Attributes.Name _EXTENSION_LISTContent = default;
            private static bool _EXTENSION_LISTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#EXTENSION_NAME"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name EXTENSION_NAME { get { if (!_EXTENSION_NAMEReady) { _EXTENSION_NAMEContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "EXTENSION_NAME"); _EXTENSION_NAMEReady = true; } return _EXTENSION_NAMEContent; } }
            private static Java.Util.Jar.Attributes.Name _EXTENSION_NAMEContent = default;
            private static bool _EXTENSION_NAMEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#IMPLEMENTATION_TITLE"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name IMPLEMENTATION_TITLE { get { if (!_IMPLEMENTATION_TITLEReady) { _IMPLEMENTATION_TITLEContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "IMPLEMENTATION_TITLE"); _IMPLEMENTATION_TITLEReady = true; } return _IMPLEMENTATION_TITLEContent; } }
            private static Java.Util.Jar.Attributes.Name _IMPLEMENTATION_TITLEContent = default;
            private static bool _IMPLEMENTATION_TITLEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#IMPLEMENTATION_VENDOR"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name IMPLEMENTATION_VENDOR { get { if (!_IMPLEMENTATION_VENDORReady) { _IMPLEMENTATION_VENDORContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "IMPLEMENTATION_VENDOR"); _IMPLEMENTATION_VENDORReady = true; } return _IMPLEMENTATION_VENDORContent; } }
            private static Java.Util.Jar.Attributes.Name _IMPLEMENTATION_VENDORContent = default;
            private static bool _IMPLEMENTATION_VENDORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#IMPLEMENTATION_VERSION"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name IMPLEMENTATION_VERSION { get { if (!_IMPLEMENTATION_VERSIONReady) { _IMPLEMENTATION_VERSIONContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "IMPLEMENTATION_VERSION"); _IMPLEMENTATION_VERSIONReady = true; } return _IMPLEMENTATION_VERSIONContent; } }
            private static Java.Util.Jar.Attributes.Name _IMPLEMENTATION_VERSIONContent = default;
            private static bool _IMPLEMENTATION_VERSIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#MAIN_CLASS"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name MAIN_CLASS { get { if (!_MAIN_CLASSReady) { _MAIN_CLASSContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "MAIN_CLASS"); _MAIN_CLASSReady = true; } return _MAIN_CLASSContent; } }
            private static Java.Util.Jar.Attributes.Name _MAIN_CLASSContent = default;
            private static bool _MAIN_CLASSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#MANIFEST_VERSION"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name MANIFEST_VERSION { get { if (!_MANIFEST_VERSIONReady) { _MANIFEST_VERSIONContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "MANIFEST_VERSION"); _MANIFEST_VERSIONReady = true; } return _MANIFEST_VERSIONContent; } }
            private static Java.Util.Jar.Attributes.Name _MANIFEST_VERSIONContent = default;
            private static bool _MANIFEST_VERSIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#MULTI_RELEASE"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name MULTI_RELEASE { get { if (!_MULTI_RELEASEReady) { _MULTI_RELEASEContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "MULTI_RELEASE"); _MULTI_RELEASEReady = true; } return _MULTI_RELEASEContent; } }
            private static Java.Util.Jar.Attributes.Name _MULTI_RELEASEContent = default;
            private static bool _MULTI_RELEASEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#SEALED"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name SEALED { get { if (!_SEALEDReady) { _SEALEDContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "SEALED"); _SEALEDReady = true; } return _SEALEDContent; } }
            private static Java.Util.Jar.Attributes.Name _SEALEDContent = default;
            private static bool _SEALEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#SIGNATURE_VERSION"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name SIGNATURE_VERSION { get { if (!_SIGNATURE_VERSIONReady) { _SIGNATURE_VERSIONContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "SIGNATURE_VERSION"); _SIGNATURE_VERSIONReady = true; } return _SIGNATURE_VERSIONContent; } }
            private static Java.Util.Jar.Attributes.Name _SIGNATURE_VERSIONContent = default;
            private static bool _SIGNATURE_VERSIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#SPECIFICATION_TITLE"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name SPECIFICATION_TITLE { get { if (!_SPECIFICATION_TITLEReady) { _SPECIFICATION_TITLEContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "SPECIFICATION_TITLE"); _SPECIFICATION_TITLEReady = true; } return _SPECIFICATION_TITLEContent; } }
            private static Java.Util.Jar.Attributes.Name _SPECIFICATION_TITLEContent = default;
            private static bool _SPECIFICATION_TITLEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#SPECIFICATION_VENDOR"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name SPECIFICATION_VENDOR { get { if (!_SPECIFICATION_VENDORReady) { _SPECIFICATION_VENDORContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "SPECIFICATION_VENDOR"); _SPECIFICATION_VENDORReady = true; } return _SPECIFICATION_VENDORContent; } }
            private static Java.Util.Jar.Attributes.Name _SPECIFICATION_VENDORContent = default;
            private static bool _SPECIFICATION_VENDORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/jar/Attributes.Name.html#SPECIFICATION_VERSION"/>
            /// </summary>
            public static Java.Util.Jar.Attributes.Name SPECIFICATION_VERSION { get { if (!_SPECIFICATION_VERSIONReady) { _SPECIFICATION_VERSIONContent = SGetField<Java.Util.Jar.Attributes.Name>(LocalBridgeClazz, "SPECIFICATION_VERSION"); _SPECIFICATION_VERSIONReady = true; } return _SPECIFICATION_VERSIONContent; } }
            private static Java.Util.Jar.Attributes.Name _SPECIFICATION_VERSIONContent = default;
            private static bool _SPECIFICATION_VERSIONReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}