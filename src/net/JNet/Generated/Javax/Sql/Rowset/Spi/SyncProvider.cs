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

namespace Javax.Sql.Rowset.Spi
{
    #region SyncProvider declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html"/>
    /// </summary>
    public partial class SyncProvider : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SyncProvider>
    {
        const string _bridgeClassName = "javax.sql.rowset.spi.SyncProvider";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SyncProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SyncProvider() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SyncProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SyncProvider(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    #region SyncProvider implementation
    public partial class SyncProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#DATASOURCE_DB_LOCK"/>
        /// </summary>
        public static int DATASOURCE_DB_LOCK { get { if (!_DATASOURCE_DB_LOCKReady) { _DATASOURCE_DB_LOCKContent = SGetField<int>(LocalBridgeClazz, "DATASOURCE_DB_LOCK"); _DATASOURCE_DB_LOCKReady = true; } return _DATASOURCE_DB_LOCKContent; } }
        private static int _DATASOURCE_DB_LOCKContent = default;
        private static bool _DATASOURCE_DB_LOCKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#DATASOURCE_NO_LOCK"/>
        /// </summary>
        public static int DATASOURCE_NO_LOCK { get { if (!_DATASOURCE_NO_LOCKReady) { _DATASOURCE_NO_LOCKContent = SGetField<int>(LocalBridgeClazz, "DATASOURCE_NO_LOCK"); _DATASOURCE_NO_LOCKReady = true; } return _DATASOURCE_NO_LOCKContent; } }
        private static int _DATASOURCE_NO_LOCKContent = default;
        private static bool _DATASOURCE_NO_LOCKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#DATASOURCE_ROW_LOCK"/>
        /// </summary>
        public static int DATASOURCE_ROW_LOCK { get { if (!_DATASOURCE_ROW_LOCKReady) { _DATASOURCE_ROW_LOCKContent = SGetField<int>(LocalBridgeClazz, "DATASOURCE_ROW_LOCK"); _DATASOURCE_ROW_LOCKReady = true; } return _DATASOURCE_ROW_LOCKContent; } }
        private static int _DATASOURCE_ROW_LOCKContent = default;
        private static bool _DATASOURCE_ROW_LOCKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#DATASOURCE_TABLE_LOCK"/>
        /// </summary>
        public static int DATASOURCE_TABLE_LOCK { get { if (!_DATASOURCE_TABLE_LOCKReady) { _DATASOURCE_TABLE_LOCKContent = SGetField<int>(LocalBridgeClazz, "DATASOURCE_TABLE_LOCK"); _DATASOURCE_TABLE_LOCKReady = true; } return _DATASOURCE_TABLE_LOCKContent; } }
        private static int _DATASOURCE_TABLE_LOCKContent = default;
        private static bool _DATASOURCE_TABLE_LOCKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#GRADE_CHECK_ALL_AT_COMMIT"/>
        /// </summary>
        public static int GRADE_CHECK_ALL_AT_COMMIT { get { if (!_GRADE_CHECK_ALL_AT_COMMITReady) { _GRADE_CHECK_ALL_AT_COMMITContent = SGetField<int>(LocalBridgeClazz, "GRADE_CHECK_ALL_AT_COMMIT"); _GRADE_CHECK_ALL_AT_COMMITReady = true; } return _GRADE_CHECK_ALL_AT_COMMITContent; } }
        private static int _GRADE_CHECK_ALL_AT_COMMITContent = default;
        private static bool _GRADE_CHECK_ALL_AT_COMMITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#GRADE_CHECK_MODIFIED_AT_COMMIT"/>
        /// </summary>
        public static int GRADE_CHECK_MODIFIED_AT_COMMIT { get { if (!_GRADE_CHECK_MODIFIED_AT_COMMITReady) { _GRADE_CHECK_MODIFIED_AT_COMMITContent = SGetField<int>(LocalBridgeClazz, "GRADE_CHECK_MODIFIED_AT_COMMIT"); _GRADE_CHECK_MODIFIED_AT_COMMITReady = true; } return _GRADE_CHECK_MODIFIED_AT_COMMITContent; } }
        private static int _GRADE_CHECK_MODIFIED_AT_COMMITContent = default;
        private static bool _GRADE_CHECK_MODIFIED_AT_COMMITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#GRADE_LOCK_WHEN_LOADED"/>
        /// </summary>
        public static int GRADE_LOCK_WHEN_LOADED { get { if (!_GRADE_LOCK_WHEN_LOADEDReady) { _GRADE_LOCK_WHEN_LOADEDContent = SGetField<int>(LocalBridgeClazz, "GRADE_LOCK_WHEN_LOADED"); _GRADE_LOCK_WHEN_LOADEDReady = true; } return _GRADE_LOCK_WHEN_LOADEDContent; } }
        private static int _GRADE_LOCK_WHEN_LOADEDContent = default;
        private static bool _GRADE_LOCK_WHEN_LOADEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#GRADE_LOCK_WHEN_MODIFIED"/>
        /// </summary>
        public static int GRADE_LOCK_WHEN_MODIFIED { get { if (!_GRADE_LOCK_WHEN_MODIFIEDReady) { _GRADE_LOCK_WHEN_MODIFIEDContent = SGetField<int>(LocalBridgeClazz, "GRADE_LOCK_WHEN_MODIFIED"); _GRADE_LOCK_WHEN_MODIFIEDReady = true; } return _GRADE_LOCK_WHEN_MODIFIEDContent; } }
        private static int _GRADE_LOCK_WHEN_MODIFIEDContent = default;
        private static bool _GRADE_LOCK_WHEN_MODIFIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#GRADE_NONE"/>
        /// </summary>
        public static int GRADE_NONE { get { if (!_GRADE_NONEReady) { _GRADE_NONEContent = SGetField<int>(LocalBridgeClazz, "GRADE_NONE"); _GRADE_NONEReady = true; } return _GRADE_NONEContent; } }
        private static int _GRADE_NONEContent = default;
        private static bool _GRADE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#NONUPDATABLE_VIEW_SYNC"/>
        /// </summary>
        public static int NONUPDATABLE_VIEW_SYNC { get { if (!_NONUPDATABLE_VIEW_SYNCReady) { _NONUPDATABLE_VIEW_SYNCContent = SGetField<int>(LocalBridgeClazz, "NONUPDATABLE_VIEW_SYNC"); _NONUPDATABLE_VIEW_SYNCReady = true; } return _NONUPDATABLE_VIEW_SYNCContent; } }
        private static int _NONUPDATABLE_VIEW_SYNCContent = default;
        private static bool _NONUPDATABLE_VIEW_SYNCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#UPDATABLE_VIEW_SYNC"/>
        /// </summary>
        public static int UPDATABLE_VIEW_SYNC { get { if (!_UPDATABLE_VIEW_SYNCReady) { _UPDATABLE_VIEW_SYNCContent = SGetField<int>(LocalBridgeClazz, "UPDATABLE_VIEW_SYNC"); _UPDATABLE_VIEW_SYNCReady = true; } return _UPDATABLE_VIEW_SYNCContent; } }
        private static int _UPDATABLE_VIEW_SYNCContent = default;
        private static bool _UPDATABLE_VIEW_SYNCReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#getDataSourceLock()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#setDataSourceLock(int)"/>
        /// </summary>
        public int DataSourceLock
        {
            get { return IExecuteWithSignature<int>("getDataSourceLock", "()I"); } set { IExecuteWithSignature("setDataSourceLock", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#getProviderGrade()"/> 
        /// </summary>
        public int ProviderGrade
        {
            get { return IExecuteWithSignature<int>("getProviderGrade", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#getProviderID()"/> 
        /// </summary>
        public Java.Lang.String ProviderID
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getProviderID", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#getRowSetReader()"/> 
        /// </summary>
        public Javax.Sql.RowSetReader RowSetReader
        {
            get { return IExecuteWithSignature<Javax.Sql.RowSetReader>("getRowSetReader", "()Ljavax/sql/RowSetReader;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#getRowSetWriter()"/> 
        /// </summary>
        public Javax.Sql.RowSetWriter RowSetWriter
        {
            get { return IExecuteWithSignature<Javax.Sql.RowSetWriter>("getRowSetWriter", "()Ljavax/sql/RowSetWriter;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#getVendor()"/> 
        /// </summary>
        public Java.Lang.String Vendor
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVendor", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#getVersion()"/> 
        /// </summary>
        public Java.Lang.String Version
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVersion", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#supportsUpdatableView()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int SupportsUpdatableView()
        {
            return IExecuteWithSignature<int>("supportsUpdatableView", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}