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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql
{
    #region IConnectionPoolDataSource
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html"/>
    /// </summary>
    public partial interface IConnectionPoolDataSource : Javax.Sql.ICommonDataSource
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#createPooledConnectionBuilder()"/> 
        /// </summary>
        Javax.Sql.PooledConnectionBuilder CreatePooledConnectionBuilder { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getLoginTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#setLoginTimeout(int)"/>
        /// </summary>
        int LoginTimeout { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getLogWriter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#setLogWriter(java.io.PrintWriter)"/>
        /// </summary>
        Java.Io.PrintWriter LogWriter { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getPooledConnection()"/> 
        /// </summary>
        Javax.Sql.PooledConnection PooledConnection { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getPooledConnection(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Sql.PooledConnection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.PooledConnection GetPooledConnection(string arg0, string arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConnectionPoolDataSource
    public partial class ConnectionPoolDataSource : Javax.Sql.IConnectionPoolDataSource
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#createPooledConnectionBuilder()"/> 
        /// </summary>
        public Javax.Sql.PooledConnectionBuilder CreatePooledConnectionBuilder
        {
            get { return IExecute<Javax.Sql.PooledConnectionBuilder>("createPooledConnectionBuilder"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getLoginTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#setLoginTimeout(int)"/>
        /// </summary>
        public int LoginTimeout
        {
            get { return IExecute<int>("getLoginTimeout"); } set { IExecute("setLoginTimeout", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getLogWriter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#setLogWriter(java.io.PrintWriter)"/>
        /// </summary>
        public Java.Io.PrintWriter LogWriter
        {
            get { return IExecute<Java.Io.PrintWriter>("getLogWriter"); } set { IExecute("setLogWriter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getPooledConnection()"/> 
        /// </summary>
        public Javax.Sql.PooledConnection PooledConnection
        {
            get { return IExecute<Javax.Sql.PooledConnection>("getPooledConnection"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getPooledConnection(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Sql.PooledConnection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.PooledConnection GetPooledConnection(string arg0, string arg1)
        {
            return IExecute<Javax.Sql.PooledConnection>("getPooledConnection", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}