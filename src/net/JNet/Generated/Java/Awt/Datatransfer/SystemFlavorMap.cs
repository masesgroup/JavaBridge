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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Datatransfer
{
    #region SystemFlavorMap declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html"/>
    /// </summary>
    public partial class SystemFlavorMap : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SystemFlavorMap>
    {
        const string _bridgeClassName = "java.awt.datatransfer.SystemFlavorMap";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SystemFlavorMap() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SystemFlavorMap(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region SystemFlavorMap implementation
    public partial class SystemFlavorMap
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Datatransfer.SystemFlavorMap"/> to <see cref="Java.Awt.Datatransfer.FlavorMap"/>
        /// </summary>
        public static implicit operator Java.Awt.Datatransfer.FlavorMap(Java.Awt.Datatransfer.SystemFlavorMap t) => t.Cast<Java.Awt.Datatransfer.FlavorMap>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Datatransfer.SystemFlavorMap"/> to <see cref="Java.Awt.Datatransfer.FlavorTable"/>
        /// </summary>
        public static implicit operator Java.Awt.Datatransfer.FlavorTable(Java.Awt.Datatransfer.SystemFlavorMap t) => t.Cast<Java.Awt.Datatransfer.FlavorTable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#getDefaultFlavorMap()"/> 
        /// </summary>
        public static Java.Awt.Datatransfer.FlavorMap DefaultFlavorMap
        {
            get { return SExecuteWithSignature<Java.Awt.Datatransfer.FlavorMap>(LocalBridgeClazz, "getDefaultFlavorMap", "()Ljava/awt/datatransfer/FlavorMap;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#isJavaMIMEType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsJavaMIMEType(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isJavaMIMEType", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#decodeDataFlavor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Awt.Datatransfer.DataFlavor"/></returns>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public static Java.Awt.Datatransfer.DataFlavor DecodeDataFlavor(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Awt.Datatransfer.DataFlavor>(LocalBridgeClazz, "decodeDataFlavor", "(Ljava/lang/String;)Ljava/awt/datatransfer/DataFlavor;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#decodeJavaMIMEType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String DecodeJavaMIMEType(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "decodeJavaMIMEType", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#encodeDataFlavor(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String EncodeDataFlavor(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "encodeDataFlavor", "(Ljava/awt/datatransfer/DataFlavor;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#encodeJavaMIMEType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String EncodeJavaMIMEType(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "encodeJavaMIMEType", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#getFlavorsForNative(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Awt.Datatransfer.DataFlavor> GetFlavorsForNative(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Java.Awt.Datatransfer.DataFlavor>>("getFlavorsForNative", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#getNativesForFlavor(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> GetNativesForFlavor(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getNativesForFlavor", "(Ljava/awt/datatransfer/DataFlavor;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#getNativesForFlavors(java.awt.datatransfer.DataFlavor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Awt.Datatransfer.DataFlavor, Java.Lang.String> GetNativesForFlavors(Java.Awt.Datatransfer.DataFlavor[] arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Awt.Datatransfer.DataFlavor, Java.Lang.String>>("getNativesForFlavors", "([Ljava/awt/datatransfer/DataFlavor;)Ljava/util/Map;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#getFlavorsForNatives(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Awt.Datatransfer.DataFlavor> GetFlavorsForNatives(Java.Lang.String[] arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Awt.Datatransfer.DataFlavor>>("getFlavorsForNatives", "([Ljava/lang/String;)Ljava/util/Map;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#addFlavorForUnencodedNative(java.lang.String,java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        public void AddFlavorForUnencodedNative(Java.Lang.String arg0, Java.Awt.Datatransfer.DataFlavor arg1)
        {
            IExecuteWithSignature("addFlavorForUnencodedNative", "(Ljava/lang/String;Ljava/awt/datatransfer/DataFlavor;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#addUnencodedNativeForFlavor(java.awt.datatransfer.DataFlavor,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void AddUnencodedNativeForFlavor(Java.Awt.Datatransfer.DataFlavor arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("addUnencodedNativeForFlavor", "(Ljava/awt/datatransfer/DataFlavor;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#setFlavorsForNative(java.lang.String,java.awt.datatransfer.DataFlavor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        public void SetFlavorsForNative(Java.Lang.String arg0, Java.Awt.Datatransfer.DataFlavor[] arg1)
        {
            IExecuteWithSignature("setFlavorsForNative", "(Ljava/lang/String;[Ljava/awt/datatransfer/DataFlavor;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#setNativesForFlavor(java.awt.datatransfer.DataFlavor,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetNativesForFlavor(Java.Awt.Datatransfer.DataFlavor arg0, Java.Lang.String[] arg1)
        {
            IExecuteWithSignature("setNativesForFlavor", "(Ljava/awt/datatransfer/DataFlavor;[Ljava/lang/String;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}