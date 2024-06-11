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

namespace Java.Sql
{
    #region IResultSetMetaData
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IResultSetMetaData : Java.Sql.IWrapper
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnCount()"/> 
        /// </summary>
        int ColumnCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isAutoIncrement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool IsAutoIncrement(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isCaseSensitive(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool IsCaseSensitive(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isCurrency(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool IsCurrency(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isDefinitelyWritable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool IsDefinitelyWritable(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isReadOnly(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool IsReadOnly(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isSearchable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool IsSearchable(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isSigned(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool IsSigned(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isWritable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool IsWritable(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnDisplaySize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        int GetColumnDisplaySize(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        int GetColumnType(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getPrecision(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        int GetPrecision(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getScale(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        int GetScale(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isNullable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        int IsNullable(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getCatalogName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Lang.String GetCatalogName(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnClassName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Lang.String GetColumnClassName(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnLabel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Lang.String GetColumnLabel(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Lang.String GetColumnName(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnTypeName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Lang.String GetColumnTypeName(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getSchemaName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Lang.String GetSchemaName(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getTableName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Lang.String GetTableName(int arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ResultSetMetaData
    public partial class ResultSetMetaData : Java.Sql.IResultSetMetaData
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#columnNoNulls"/>
        /// </summary>
        public static int columnNoNulls { get { if (!_columnNoNullsReady) { _columnNoNullsContent = SGetField<int>(LocalBridgeClazz, "columnNoNulls"); _columnNoNullsReady = true; } return _columnNoNullsContent; } }
        private static int _columnNoNullsContent = default;
        private static bool _columnNoNullsReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#columnNullable"/>
        /// </summary>
        public static int columnNullable { get { if (!_columnNullableReady) { _columnNullableContent = SGetField<int>(LocalBridgeClazz, "columnNullable"); _columnNullableReady = true; } return _columnNullableContent; } }
        private static int _columnNullableContent = default;
        private static bool _columnNullableReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#columnNullableUnknown"/>
        /// </summary>
        public static int columnNullableUnknown { get { if (!_columnNullableUnknownReady) { _columnNullableUnknownContent = SGetField<int>(LocalBridgeClazz, "columnNullableUnknown"); _columnNullableUnknownReady = true; } return _columnNullableUnknownContent; } }
        private static int _columnNullableUnknownContent = default;
        private static bool _columnNullableUnknownReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnCount()"/> 
        /// </summary>
        public int ColumnCount
        {
            get { return IExecuteWithSignature<int>("getColumnCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isAutoIncrement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsAutoIncrement(int arg0)
        {
            return IExecuteWithSignature<bool>("isAutoIncrement", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isCaseSensitive(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsCaseSensitive(int arg0)
        {
            return IExecuteWithSignature<bool>("isCaseSensitive", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isCurrency(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsCurrency(int arg0)
        {
            return IExecuteWithSignature<bool>("isCurrency", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isDefinitelyWritable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsDefinitelyWritable(int arg0)
        {
            return IExecuteWithSignature<bool>("isDefinitelyWritable", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isReadOnly(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsReadOnly(int arg0)
        {
            return IExecuteWithSignature<bool>("isReadOnly", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isSearchable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsSearchable(int arg0)
        {
            return IExecuteWithSignature<bool>("isSearchable", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isSigned(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsSigned(int arg0)
        {
            return IExecuteWithSignature<bool>("isSigned", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isWritable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsWritable(int arg0)
        {
            return IExecuteWithSignature<bool>("isWritable", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnDisplaySize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetColumnDisplaySize(int arg0)
        {
            return IExecuteWithSignature<int>("getColumnDisplaySize", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetColumnType(int arg0)
        {
            return IExecuteWithSignature<int>("getColumnType", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getPrecision(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetPrecision(int arg0)
        {
            return IExecuteWithSignature<int>("getPrecision", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getScale(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetScale(int arg0)
        {
            return IExecuteWithSignature<int>("getScale", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isNullable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int IsNullable(int arg0)
        {
            return IExecuteWithSignature<int>("isNullable", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getCatalogName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetCatalogName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getCatalogName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnClassName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetColumnClassName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getColumnClassName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnLabel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetColumnLabel(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getColumnLabel", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetColumnName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getColumnName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnTypeName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetColumnTypeName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getColumnTypeName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getSchemaName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetSchemaName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getSchemaName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getTableName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetTableName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getTableName", "(I)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}