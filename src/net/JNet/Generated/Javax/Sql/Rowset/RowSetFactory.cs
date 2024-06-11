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

namespace Javax.Sql.Rowset
{
    #region IRowSetFactory
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRowSetFactory
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createCachedRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.CachedRowSet CreateCachedRowSet();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createFilteredRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.FilteredRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.FilteredRowSet CreateFilteredRowSet();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createJdbcRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.JdbcRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.JdbcRowSet CreateJdbcRowSet();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createJoinRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.JoinRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.JoinRowSet CreateJoinRowSet();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createWebRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.WebRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.WebRowSet CreateWebRowSet();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RowSetFactory
    public partial class RowSetFactory : Javax.Sql.Rowset.IRowSetFactory
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createCachedRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.CachedRowSet CreateCachedRowSet()
        {
            return IExecuteWithSignature<Javax.Sql.Rowset.CachedRowSet>("createCachedRowSet", "()Ljavax/sql/rowset/CachedRowSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createFilteredRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.FilteredRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.FilteredRowSet CreateFilteredRowSet()
        {
            return IExecuteWithSignature<Javax.Sql.Rowset.FilteredRowSet>("createFilteredRowSet", "()Ljavax/sql/rowset/FilteredRowSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createJdbcRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.JdbcRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.JdbcRowSet CreateJdbcRowSet()
        {
            return IExecuteWithSignature<Javax.Sql.Rowset.JdbcRowSet>("createJdbcRowSet", "()Ljavax/sql/rowset/JdbcRowSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createJoinRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.JoinRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.JoinRowSet CreateJoinRowSet()
        {
            return IExecuteWithSignature<Javax.Sql.Rowset.JoinRowSet>("createJoinRowSet", "()Ljavax/sql/rowset/JoinRowSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createWebRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.WebRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.WebRowSet CreateWebRowSet()
        {
            return IExecuteWithSignature<Javax.Sql.Rowset.WebRowSet>("createWebRowSet", "()Ljavax/sql/rowset/WebRowSet;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}