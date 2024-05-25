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

namespace Java.Io
{
    #region IObjectInputFilter
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IObjectInputFilter
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.html#checkInput(java.io.ObjectInputFilter.FilterInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectInputFilter.FilterInfo"/></param>
        /// <returns><see cref="Java.Io.ObjectInputFilter.Status"/></returns>
        Java.Io.ObjectInputFilter.Status CheckInput(Java.Io.ObjectInputFilter.FilterInfo arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ObjectInputFilter
    public partial class ObjectInputFilter : Java.Io.IObjectInputFilter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.html#checkInput(java.io.ObjectInputFilter.FilterInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectInputFilter.FilterInfo"/></param>
        /// <returns><see cref="Java.Io.ObjectInputFilter.Status"/></returns>
        public Java.Io.ObjectInputFilter.Status CheckInput(Java.Io.ObjectInputFilter.FilterInfo arg0)
        {
            return IExecuteWithSignature<Java.Io.ObjectInputFilter.Status>("checkInput", "(Ljava/io/ObjectInputFilter$FilterInfo;)Ljava/io/ObjectInputFilter$Status;", arg0);
        }

        #endregion

        #region Nested classes
        #region Config
        public partial class Config
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Config.html#getSerialFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Config.html#setSerialFilter(java.io.ObjectInputFilter)"/>
            /// </summary>
            public static Java.Io.ObjectInputFilter SerialFilter
            {
                get { return SExecuteWithSignature<Java.Io.ObjectInputFilter>(LocalBridgeClazz, "getSerialFilter", "()Ljava/io/ObjectInputFilter;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setSerialFilter", "(Ljava/io/ObjectInputFilter;)V", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Config.html#createFilter(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Io.ObjectInputFilter"/></returns>
            public static Java.Io.ObjectInputFilter CreateFilter(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Io.ObjectInputFilter>(LocalBridgeClazz, "createFilter", "(Ljava/lang/String;)Ljava/io/ObjectInputFilter;", arg0);
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region FilterInfo
        public partial class FilterInfo
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.FilterInfo.html#serialClass()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Class"/></returns>
            public Java.Lang.Class SerialClass()
            {
                return IExecuteWithSignature<Java.Lang.Class>("serialClass", "()Ljava/lang/Class;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.FilterInfo.html#arrayLength()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long ArrayLength()
            {
                return IExecuteWithSignature<long>("arrayLength", "()J");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.FilterInfo.html#depth()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long Depth()
            {
                return IExecuteWithSignature<long>("depth", "()J");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.FilterInfo.html#references()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long References()
            {
                return IExecuteWithSignature<long>("references", "()J");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.FilterInfo.html#streamBytes()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long StreamBytes()
            {
                return IExecuteWithSignature<long>("streamBytes", "()J");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Status
        public partial class Status
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Status.html#ALLOWED"/>
            /// </summary>
            public static Java.Io.ObjectInputFilter.Status ALLOWED { get { if (!_ALLOWEDReady) { _ALLOWEDContent = SGetField<Java.Io.ObjectInputFilter.Status>(LocalBridgeClazz, "ALLOWED"); _ALLOWEDReady = true; } return _ALLOWEDContent; } }
            private static Java.Io.ObjectInputFilter.Status _ALLOWEDContent = default;
            private static bool _ALLOWEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Status.html#REJECTED"/>
            /// </summary>
            public static Java.Io.ObjectInputFilter.Status REJECTED { get { if (!_REJECTEDReady) { _REJECTEDContent = SGetField<Java.Io.ObjectInputFilter.Status>(LocalBridgeClazz, "REJECTED"); _REJECTEDReady = true; } return _REJECTEDContent; } }
            private static Java.Io.ObjectInputFilter.Status _REJECTEDContent = default;
            private static bool _REJECTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Status.html#UNDECIDED"/>
            /// </summary>
            public static Java.Io.ObjectInputFilter.Status UNDECIDED { get { if (!_UNDECIDEDReady) { _UNDECIDEDContent = SGetField<Java.Io.ObjectInputFilter.Status>(LocalBridgeClazz, "UNDECIDED"); _UNDECIDEDReady = true; } return _UNDECIDEDContent; } }
            private static Java.Io.ObjectInputFilter.Status _UNDECIDEDContent = default;
            private static bool _UNDECIDEDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Status.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Io.ObjectInputFilter.Status"/></returns>
            public static Java.Io.ObjectInputFilter.Status ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Io.ObjectInputFilter.Status>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/io/ObjectInputFilter$Status;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Status.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Io.ObjectInputFilter.Status"/></returns>
            public static Java.Io.ObjectInputFilter.Status[] Values()
            {
                return SExecuteWithSignatureArray<Java.Io.ObjectInputFilter.Status>(LocalBridgeClazz, "values", "()[Ljava/io/ObjectInputFilter$Status;");
            }

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