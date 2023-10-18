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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql
{
    #region IRowSetInternal
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRowSetInternal
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetInternal.html#getConnection()"/> 
        /// </summary>
        Java.Sql.Connection Connection { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetInternal.html#getOriginal()"/> 
        /// </summary>
        Java.Sql.ResultSet Original { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetInternal.html#getOriginalRow()"/> 
        /// </summary>
        Java.Sql.ResultSet OriginalRow { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetInternal.html#getParams()"/> 
        /// </summary>
        object[] Params { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetInternal.html#setMetaData(javax.sql.RowSetMetaData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetMetaData"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void SetMetaData(Javax.Sql.RowSetMetaData arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RowSetInternal
    public partial class RowSetInternal : Javax.Sql.IRowSetInternal
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetInternal.html#getConnection()"/> 
        /// </summary>
        public Java.Sql.Connection Connection
        {
            get { return IExecute<Java.Sql.Connection>("getConnection"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetInternal.html#getOriginal()"/> 
        /// </summary>
        public Java.Sql.ResultSet Original
        {
            get { return IExecute<Java.Sql.ResultSet>("getOriginal"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetInternal.html#getOriginalRow()"/> 
        /// </summary>
        public Java.Sql.ResultSet OriginalRow
        {
            get { return IExecute<Java.Sql.ResultSet>("getOriginalRow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetInternal.html#getParams()"/> 
        /// </summary>
        public object[] Params
        {
            get { return IExecuteArray<object>("getParams"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetInternal.html#setMetaData(javax.sql.RowSetMetaData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetMetaData"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetMetaData(Javax.Sql.RowSetMetaData arg0)
        {
            IExecute("setMetaData", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}