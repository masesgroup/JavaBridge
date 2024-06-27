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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Sql
{
    #region JDBCType
    public partial class JDBCType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Sql.JDBCType"/> to <see cref="Java.Sql.SQLType"/>
        /// </summary>
        public static implicit operator Java.Sql.SQLType(Java.Sql.JDBCType t) => t.Cast<Java.Sql.SQLType>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#ARRAY"/>
        /// </summary>
        public static Java.Sql.JDBCType ARRAY { get { if (!_ARRAYReady) { _ARRAYContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "ARRAY"); _ARRAYReady = true; } return _ARRAYContent; } }
        private static Java.Sql.JDBCType _ARRAYContent = default;
        private static bool _ARRAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BIGINT"/>
        /// </summary>
        public static Java.Sql.JDBCType BIGINT { get { if (!_BIGINTReady) { _BIGINTContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "BIGINT"); _BIGINTReady = true; } return _BIGINTContent; } }
        private static Java.Sql.JDBCType _BIGINTContent = default;
        private static bool _BIGINTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BINARY"/>
        /// </summary>
        public static Java.Sql.JDBCType BINARY { get { if (!_BINARYReady) { _BINARYContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "BINARY"); _BINARYReady = true; } return _BINARYContent; } }
        private static Java.Sql.JDBCType _BINARYContent = default;
        private static bool _BINARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BIT"/>
        /// </summary>
        public static Java.Sql.JDBCType BIT { get { if (!_BITReady) { _BITContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "BIT"); _BITReady = true; } return _BITContent; } }
        private static Java.Sql.JDBCType _BITContent = default;
        private static bool _BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BLOB"/>
        /// </summary>
        public static Java.Sql.JDBCType BLOB { get { if (!_BLOBReady) { _BLOBContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "BLOB"); _BLOBReady = true; } return _BLOBContent; } }
        private static Java.Sql.JDBCType _BLOBContent = default;
        private static bool _BLOBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BOOLEAN"/>
        /// </summary>
        public static Java.Sql.JDBCType BOOLEAN { get { if (!_BOOLEANReady) { _BOOLEANContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "BOOLEAN"); _BOOLEANReady = true; } return _BOOLEANContent; } }
        private static Java.Sql.JDBCType _BOOLEANContent = default;
        private static bool _BOOLEANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#CHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType CHAR { get { if (!_CHARReady) { _CHARContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "CHAR"); _CHARReady = true; } return _CHARContent; } }
        private static Java.Sql.JDBCType _CHARContent = default;
        private static bool _CHARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#CLOB"/>
        /// </summary>
        public static Java.Sql.JDBCType CLOB { get { if (!_CLOBReady) { _CLOBContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "CLOB"); _CLOBReady = true; } return _CLOBContent; } }
        private static Java.Sql.JDBCType _CLOBContent = default;
        private static bool _CLOBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DATALINK"/>
        /// </summary>
        public static Java.Sql.JDBCType DATALINK { get { if (!_DATALINKReady) { _DATALINKContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "DATALINK"); _DATALINKReady = true; } return _DATALINKContent; } }
        private static Java.Sql.JDBCType _DATALINKContent = default;
        private static bool _DATALINKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DATE"/>
        /// </summary>
        public static Java.Sql.JDBCType DATE { get { if (!_DATEReady) { _DATEContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "DATE"); _DATEReady = true; } return _DATEContent; } }
        private static Java.Sql.JDBCType _DATEContent = default;
        private static bool _DATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DECIMAL"/>
        /// </summary>
        public static Java.Sql.JDBCType DECIMAL { get { if (!_DECIMALReady) { _DECIMALContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "DECIMAL"); _DECIMALReady = true; } return _DECIMALContent; } }
        private static Java.Sql.JDBCType _DECIMALContent = default;
        private static bool _DECIMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DISTINCT"/>
        /// </summary>
        public static Java.Sql.JDBCType DISTINCT { get { if (!_DISTINCTReady) { _DISTINCTContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "DISTINCT"); _DISTINCTReady = true; } return _DISTINCTContent; } }
        private static Java.Sql.JDBCType _DISTINCTContent = default;
        private static bool _DISTINCTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DOUBLE"/>
        /// </summary>
        public static Java.Sql.JDBCType DOUBLE { get { if (!_DOUBLEReady) { _DOUBLEContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "DOUBLE"); _DOUBLEReady = true; } return _DOUBLEContent; } }
        private static Java.Sql.JDBCType _DOUBLEContent = default;
        private static bool _DOUBLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#FLOAT"/>
        /// </summary>
        public static Java.Sql.JDBCType FLOAT { get { if (!_FLOATReady) { _FLOATContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "FLOAT"); _FLOATReady = true; } return _FLOATContent; } }
        private static Java.Sql.JDBCType _FLOATContent = default;
        private static bool _FLOATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#INTEGER"/>
        /// </summary>
        public static Java.Sql.JDBCType INTEGER { get { if (!_INTEGERReady) { _INTEGERContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "INTEGER"); _INTEGERReady = true; } return _INTEGERContent; } }
        private static Java.Sql.JDBCType _INTEGERContent = default;
        private static bool _INTEGERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#JAVA_OBJECT"/>
        /// </summary>
        public static Java.Sql.JDBCType JAVA_OBJECT { get { if (!_JAVA_OBJECTReady) { _JAVA_OBJECTContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "JAVA_OBJECT"); _JAVA_OBJECTReady = true; } return _JAVA_OBJECTContent; } }
        private static Java.Sql.JDBCType _JAVA_OBJECTContent = default;
        private static bool _JAVA_OBJECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#LONGNVARCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType LONGNVARCHAR { get { if (!_LONGNVARCHARReady) { _LONGNVARCHARContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "LONGNVARCHAR"); _LONGNVARCHARReady = true; } return _LONGNVARCHARContent; } }
        private static Java.Sql.JDBCType _LONGNVARCHARContent = default;
        private static bool _LONGNVARCHARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#LONGVARBINARY"/>
        /// </summary>
        public static Java.Sql.JDBCType LONGVARBINARY { get { if (!_LONGVARBINARYReady) { _LONGVARBINARYContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "LONGVARBINARY"); _LONGVARBINARYReady = true; } return _LONGVARBINARYContent; } }
        private static Java.Sql.JDBCType _LONGVARBINARYContent = default;
        private static bool _LONGVARBINARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#LONGVARCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType LONGVARCHAR { get { if (!_LONGVARCHARReady) { _LONGVARCHARContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "LONGVARCHAR"); _LONGVARCHARReady = true; } return _LONGVARCHARContent; } }
        private static Java.Sql.JDBCType _LONGVARCHARContent = default;
        private static bool _LONGVARCHARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType NCHAR { get { if (!_NCHARReady) { _NCHARContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "NCHAR"); _NCHARReady = true; } return _NCHARContent; } }
        private static Java.Sql.JDBCType _NCHARContent = default;
        private static bool _NCHARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NCLOB"/>
        /// </summary>
        public static Java.Sql.JDBCType NCLOB { get { if (!_NCLOBReady) { _NCLOBContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "NCLOB"); _NCLOBReady = true; } return _NCLOBContent; } }
        private static Java.Sql.JDBCType _NCLOBContent = default;
        private static bool _NCLOBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NULL"/>
        /// </summary>
        public static Java.Sql.JDBCType NULL { get { if (!_NULLReady) { _NULLContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "NULL"); _NULLReady = true; } return _NULLContent; } }
        private static Java.Sql.JDBCType _NULLContent = default;
        private static bool _NULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NUMERIC"/>
        /// </summary>
        public static Java.Sql.JDBCType NUMERIC { get { if (!_NUMERICReady) { _NUMERICContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "NUMERIC"); _NUMERICReady = true; } return _NUMERICContent; } }
        private static Java.Sql.JDBCType _NUMERICContent = default;
        private static bool _NUMERICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NVARCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType NVARCHAR { get { if (!_NVARCHARReady) { _NVARCHARContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "NVARCHAR"); _NVARCHARReady = true; } return _NVARCHARContent; } }
        private static Java.Sql.JDBCType _NVARCHARContent = default;
        private static bool _NVARCHARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#OTHER"/>
        /// </summary>
        public static Java.Sql.JDBCType OTHER { get { if (!_OTHERReady) { _OTHERContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "OTHER"); _OTHERReady = true; } return _OTHERContent; } }
        private static Java.Sql.JDBCType _OTHERContent = default;
        private static bool _OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#REAL"/>
        /// </summary>
        public static Java.Sql.JDBCType REAL { get { if (!_REALReady) { _REALContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "REAL"); _REALReady = true; } return _REALContent; } }
        private static Java.Sql.JDBCType _REALContent = default;
        private static bool _REALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#REF"/>
        /// </summary>
        public static Java.Sql.JDBCType REF { get { if (!_REFReady) { _REFContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "REF"); _REFReady = true; } return _REFContent; } }
        private static Java.Sql.JDBCType _REFContent = default;
        private static bool _REFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#REF_CURSOR"/>
        /// </summary>
        public static Java.Sql.JDBCType REF_CURSOR { get { if (!_REF_CURSORReady) { _REF_CURSORContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "REF_CURSOR"); _REF_CURSORReady = true; } return _REF_CURSORContent; } }
        private static Java.Sql.JDBCType _REF_CURSORContent = default;
        private static bool _REF_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#ROWID"/>
        /// </summary>
        public static Java.Sql.JDBCType ROWID { get { if (!_ROWIDReady) { _ROWIDContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "ROWID"); _ROWIDReady = true; } return _ROWIDContent; } }
        private static Java.Sql.JDBCType _ROWIDContent = default;
        private static bool _ROWIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#SMALLINT"/>
        /// </summary>
        public static Java.Sql.JDBCType SMALLINT { get { if (!_SMALLINTReady) { _SMALLINTContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "SMALLINT"); _SMALLINTReady = true; } return _SMALLINTContent; } }
        private static Java.Sql.JDBCType _SMALLINTContent = default;
        private static bool _SMALLINTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#SQLXML"/>
        /// </summary>
        public static Java.Sql.JDBCType SQLXML { get { if (!_SQLXMLReady) { _SQLXMLContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "SQLXML"); _SQLXMLReady = true; } return _SQLXMLContent; } }
        private static Java.Sql.JDBCType _SQLXMLContent = default;
        private static bool _SQLXMLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#STRUCT"/>
        /// </summary>
        public static Java.Sql.JDBCType STRUCT { get { if (!_STRUCTReady) { _STRUCTContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "STRUCT"); _STRUCTReady = true; } return _STRUCTContent; } }
        private static Java.Sql.JDBCType _STRUCTContent = default;
        private static bool _STRUCTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIME"/>
        /// </summary>
        public static Java.Sql.JDBCType TIME { get { if (!_TIMEReady) { _TIMEContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "TIME"); _TIMEReady = true; } return _TIMEContent; } }
        private static Java.Sql.JDBCType _TIMEContent = default;
        private static bool _TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIME_WITH_TIMEZONE"/>
        /// </summary>
        public static Java.Sql.JDBCType TIME_WITH_TIMEZONE { get { if (!_TIME_WITH_TIMEZONEReady) { _TIME_WITH_TIMEZONEContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "TIME_WITH_TIMEZONE"); _TIME_WITH_TIMEZONEReady = true; } return _TIME_WITH_TIMEZONEContent; } }
        private static Java.Sql.JDBCType _TIME_WITH_TIMEZONEContent = default;
        private static bool _TIME_WITH_TIMEZONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIMESTAMP"/>
        /// </summary>
        public static Java.Sql.JDBCType TIMESTAMP { get { if (!_TIMESTAMPReady) { _TIMESTAMPContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "TIMESTAMP"); _TIMESTAMPReady = true; } return _TIMESTAMPContent; } }
        private static Java.Sql.JDBCType _TIMESTAMPContent = default;
        private static bool _TIMESTAMPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIMESTAMP_WITH_TIMEZONE"/>
        /// </summary>
        public static Java.Sql.JDBCType TIMESTAMP_WITH_TIMEZONE { get { if (!_TIMESTAMP_WITH_TIMEZONEReady) { _TIMESTAMP_WITH_TIMEZONEContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "TIMESTAMP_WITH_TIMEZONE"); _TIMESTAMP_WITH_TIMEZONEReady = true; } return _TIMESTAMP_WITH_TIMEZONEContent; } }
        private static Java.Sql.JDBCType _TIMESTAMP_WITH_TIMEZONEContent = default;
        private static bool _TIMESTAMP_WITH_TIMEZONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TINYINT"/>
        /// </summary>
        public static Java.Sql.JDBCType TINYINT { get { if (!_TINYINTReady) { _TINYINTContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "TINYINT"); _TINYINTReady = true; } return _TINYINTContent; } }
        private static Java.Sql.JDBCType _TINYINTContent = default;
        private static bool _TINYINTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#VARBINARY"/>
        /// </summary>
        public static Java.Sql.JDBCType VARBINARY { get { if (!_VARBINARYReady) { _VARBINARYContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "VARBINARY"); _VARBINARYReady = true; } return _VARBINARYContent; } }
        private static Java.Sql.JDBCType _VARBINARYContent = default;
        private static bool _VARBINARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#VARCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType VARCHAR { get { if (!_VARCHARReady) { _VARCHARContent = SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "VARCHAR"); _VARCHARReady = true; } return _VARCHARContent; } }
        private static Java.Sql.JDBCType _VARCHARContent = default;
        private static bool _VARCHARReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#valueOf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Sql.JDBCType"/></returns>
        public static Java.Sql.JDBCType ValueOf(int arg0)
        {
            return SExecuteWithSignature<Java.Sql.JDBCType>(LocalBridgeClazz, "valueOf", "(I)Ljava/sql/JDBCType;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.JDBCType"/></returns>
        public static Java.Sql.JDBCType ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Sql.JDBCType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/sql/JDBCType;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.JDBCType"/></returns>
        public static Java.Sql.JDBCType[] Values()
        {
            return SExecuteWithSignatureArray<Java.Sql.JDBCType>(LocalBridgeClazz, "values", "()[Ljava/sql/JDBCType;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#getVendor()"/> 
        /// </summary>
        public Java.Lang.String Vendor
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVendor", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#getVendorTypeNumber()"/> 
        /// </summary>
        public Java.Lang.Integer VendorTypeNumber
        {
            get { return IExecuteWithSignature<Java.Lang.Integer>("getVendorTypeNumber", "()Ljava/lang/Integer;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}