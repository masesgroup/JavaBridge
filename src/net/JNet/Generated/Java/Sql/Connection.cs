/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Sql
{
    #region Connection
    public partial class Connection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Sql.Connection"/> to <see cref="Java.Sql.Wrapper"/>
        /// </summary>
        public static implicit operator Java.Sql.Wrapper(Java.Sql.Connection t) => t.Cast<Java.Sql.Wrapper>();
        /// <summary>
        /// Converter from <see cref="Java.Sql.Connection"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Java.Sql.Connection t) => t.Cast<Java.Lang.AutoCloseable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#TRANSACTION_NONE"/>
        /// </summary>
        public static int TRANSACTION_NONE => Clazz.GetField<int>("TRANSACTION_NONE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#TRANSACTION_READ_COMMITTED"/>
        /// </summary>
        public static int TRANSACTION_READ_COMMITTED => Clazz.GetField<int>("TRANSACTION_READ_COMMITTED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#TRANSACTION_READ_UNCOMMITTED"/>
        /// </summary>
        public static int TRANSACTION_READ_UNCOMMITTED => Clazz.GetField<int>("TRANSACTION_READ_UNCOMMITTED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#TRANSACTION_REPEATABLE_READ"/>
        /// </summary>
        public static int TRANSACTION_REPEATABLE_READ => Clazz.GetField<int>("TRANSACTION_REPEATABLE_READ");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#TRANSACTION_SERIALIZABLE"/>
        /// </summary>
        public static int TRANSACTION_SERIALIZABLE => Clazz.GetField<int>("TRANSACTION_SERIALIZABLE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#getAutoCommit()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setAutoCommit(boolean)"/>
        /// </summary>
        public bool AutoCommit
        {
            get { return IExecute<bool>("getAutoCommit"); } set { IExecute("setAutoCommit", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#getCatalog()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setCatalog(java.lang.String)"/>
        /// </summary>
        public string Catalog
        {
            get { return IExecute<string>("getCatalog"); } set { IExecute("setCatalog", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#getClientInfo()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setClientInfo(java.util.Properties)"/>
        /// </summary>
        public Java.Util.Properties ClientInfo
        {
            get { return IExecute<Java.Util.Properties>("getClientInfo"); } set { IExecute("setClientInfo", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#createBlob()"/> 
        /// </summary>
        public Java.Sql.Blob CreateBlob
        {
            get { return IExecute<Java.Sql.Blob>("createBlob"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#createClob()"/> 
        /// </summary>
        public Java.Sql.Clob CreateClob
        {
            get { return IExecute<Java.Sql.Clob>("createClob"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#createNClob()"/> 
        /// </summary>
        public Java.Sql.NClob CreateNClob
        {
            get { return IExecute<Java.Sql.NClob>("createNClob"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#createSQLXML()"/> 
        /// </summary>
        public Java.Sql.SQLXML CreateSQLXML
        {
            get { return IExecute<Java.Sql.SQLXML>("createSQLXML"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#getHoldability()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setHoldability(int)"/>
        /// </summary>
        public int Holdability
        {
            get { return IExecute<int>("getHoldability"); } set { IExecute("setHoldability", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#isClosed()"/> 
        /// </summary>
        public bool IsClosed
        {
            get { return IExecute<bool>("isClosed"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#isReadOnly()"/> 
        /// </summary>
        public bool IsReadOnly
        {
            get { return IExecute<bool>("isReadOnly"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#getMetaData()"/> 
        /// </summary>
        public Java.Sql.DatabaseMetaData MetaData
        {
            get { return IExecute<Java.Sql.DatabaseMetaData>("getMetaData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#getNetworkTimeout()"/> 
        /// </summary>
        public int NetworkTimeout
        {
            get { return IExecute<int>("getNetworkTimeout"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#getSchema()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setSchema(java.lang.String)"/>
        /// </summary>
        public string Schema
        {
            get { return IExecute<string>("getSchema"); } set { IExecute("setSchema", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#getTransactionIsolation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setTransactionIsolation(int)"/>
        /// </summary>
        public int TransactionIsolation
        {
            get { return IExecute<int>("getTransactionIsolation"); } set { IExecute("setTransactionIsolation", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#getTypeMap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setTypeMap(java.util.Map)"/>
        /// </summary>
        public Java.Util.Map TypeMap
        {
            get { return IExecute<Java.Util.Map>("getTypeMap"); } set { IExecute("setTypeMap", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#getWarnings()"/> 
        /// </summary>
        public Java.Sql.SQLWarning Warnings
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getWarnings"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Sql.SQLWarning>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#isValid(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsValid(int arg0)
        {
            return IExecute<bool>("isValid", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#getClientInfo(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public string GetClientInfo(string arg0)
        {
            return IExecute<string>("getClientInfo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#nativeSQL(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public string NativeSQL(string arg0)
        {
            return IExecute<string>("nativeSQL", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#createArrayOf(java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Sql.Array"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Array CreateArrayOf(string arg0, object[] arg1)
        {
            return IExecute<Java.Sql.Array>("createArrayOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#prepareCall(java.lang.String,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Sql.CallableStatement"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.CallableStatement PrepareCall(string arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<Java.Sql.CallableStatement>("prepareCall", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#prepareCall(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Sql.CallableStatement"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.CallableStatement PrepareCall(string arg0, int arg1, int arg2)
        {
            return IExecute<Java.Sql.CallableStatement>("prepareCall", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#prepareCall(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.CallableStatement"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.CallableStatement PrepareCall(string arg0)
        {
            return IExecute<Java.Sql.CallableStatement>("prepareCall", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#prepareStatement(java.lang.String,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Sql.PreparedStatement"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.PreparedStatement PrepareStatement(string arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<Java.Sql.PreparedStatement>("prepareStatement", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#prepareStatement(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Sql.PreparedStatement"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.PreparedStatement PrepareStatement(string arg0, int arg1, int arg2)
        {
            return IExecute<Java.Sql.PreparedStatement>("prepareStatement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#prepareStatement(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Sql.PreparedStatement"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.PreparedStatement PrepareStatement(string arg0, int arg1)
        {
            return IExecute<Java.Sql.PreparedStatement>("prepareStatement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#prepareStatement(java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Sql.PreparedStatement"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.PreparedStatement PrepareStatement(string arg0, int[] arg1)
        {
            return IExecute<Java.Sql.PreparedStatement>("prepareStatement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#prepareStatement(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.PreparedStatement"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.PreparedStatement PrepareStatement(string arg0, string[] arg1)
        {
            return IExecute<Java.Sql.PreparedStatement>("prepareStatement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#prepareStatement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.PreparedStatement"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.PreparedStatement PrepareStatement(string arg0)
        {
            return IExecute<Java.Sql.PreparedStatement>("prepareStatement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setSavepoint()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Sql.Savepoint"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Savepoint SetSavepoint()
        {
            return IExecute<Java.Sql.Savepoint>("setSavepoint");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setSavepoint(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.Savepoint"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Savepoint SetSavepoint(string arg0)
        {
            return IExecute<Java.Sql.Savepoint>("setSavepoint", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#createStatement()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Sql.Statement"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Statement CreateStatement()
        {
            return IExecute<Java.Sql.Statement>("createStatement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#createStatement(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Sql.Statement"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Statement CreateStatement(int arg0, int arg1, int arg2)
        {
            return IExecute<Java.Sql.Statement>("createStatement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#createStatement(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Sql.Statement"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Statement CreateStatement(int arg0, int arg1)
        {
            return IExecute<Java.Sql.Statement>("createStatement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#createStruct(java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Sql.Struct"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Struct CreateStruct(string arg0, object[] arg1)
        {
            return IExecute<Java.Sql.Struct>("createStruct", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#abort(java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Abort(Java.Util.Concurrent.Executor arg0)
        {
            IExecute("abort", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#clearWarnings()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void ClearWarnings()
        {
            IExecute("clearWarnings");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#close()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#commit()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void Commit()
        {
            IExecute("commit");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#releaseSavepoint(java.sql.Savepoint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Savepoint"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void ReleaseSavepoint(Java.Sql.Savepoint arg0)
        {
            IExecute("releaseSavepoint", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#rollback()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void Rollback()
        {
            IExecute("rollback");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#rollback(java.sql.Savepoint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Savepoint"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Rollback(Java.Sql.Savepoint arg0)
        {
            IExecute("rollback", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setClientInfo(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Sql.SQLClientInfoException"/>
        public void SetClientInfo(string arg0, string arg1)
        {
            IExecute("setClientInfo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setNetworkTimeout(java.util.concurrent.Executor,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetNetworkTimeout(Java.Util.Concurrent.Executor arg0, int arg1)
        {
            IExecute("setNetworkTimeout", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setReadOnly(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetReadOnly(bool arg0)
        {
            IExecute("setReadOnly", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setShardingKeyIfValid(java.sql.ShardingKey,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool SetShardingKeyIfValid(Java.Sql.ShardingKey arg0, int arg1)
        {
            return IExecute<bool>("setShardingKeyIfValid", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setShardingKeyIfValid(java.sql.ShardingKey,java.sql.ShardingKey,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <param name="arg1"><see cref="Java.Sql.ShardingKey"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool SetShardingKeyIfValid(Java.Sql.ShardingKey arg0, Java.Sql.ShardingKey arg1, int arg2)
        {
            return IExecute<bool>("setShardingKeyIfValid", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#beginRequest()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void BeginRequest()
        {
            IExecute("beginRequest");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#endRequest()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void EndRequest()
        {
            IExecute("endRequest");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setShardingKey(java.sql.ShardingKey,java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <param name="arg1"><see cref="Java.Sql.ShardingKey"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetShardingKey(Java.Sql.ShardingKey arg0, Java.Sql.ShardingKey arg1)
        {
            IExecute("setShardingKey", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Connection.html#setShardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetShardingKey(Java.Sql.ShardingKey arg0)
        {
            IExecute("setShardingKey", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}