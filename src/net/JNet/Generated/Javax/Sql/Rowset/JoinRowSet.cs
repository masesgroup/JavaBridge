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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql.Rowset
{
    #region IJoinRowSet
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IJoinRowSet : Javax.Sql.Rowset.IWebRowSet
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getJoinType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#setJoinType(int)"/>
        /// </summary>
        int JoinType { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getRowSetNames()"/> 
        /// </summary>
        string[] RowSetNames { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getRowSets()"/> 
        /// </summary>
        Java.Util.Collection<object> RowSets { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getWhereClause()"/> 
        /// </summary>
        string WhereClause { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsCrossJoin()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool SupportsCrossJoin();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsFullJoin()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool SupportsFullJoin();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsInnerJoin()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool SupportsInnerJoin();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsLeftOuterJoin()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool SupportsLeftOuterJoin();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsRightOuterJoin()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool SupportsRightOuterJoin();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#toCachedRowSet()"/>
        /// </summary>

        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.CachedRowSet ToCachedRowSet();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void AddRowSet(Javax.Sql.RowSet arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void AddRowSet(Javax.Sql.RowSet arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.rowset.Joinable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.Rowset.Joinable"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void AddRowSet(Javax.Sql.Rowset.Joinable arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void AddRowSet(Javax.Sql.RowSet[] arg0, int[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void AddRowSet(Javax.Sql.RowSet[] arg0, string[] arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region JoinRowSet
    public partial class JoinRowSet : Javax.Sql.Rowset.IJoinRowSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#CROSS_JOIN"/>
        /// </summary>
        public static int CROSS_JOIN { get { return SGetField<int>(LocalBridgeClazz, "CROSS_JOIN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#FULL_JOIN"/>
        /// </summary>
        public static int FULL_JOIN { get { return SGetField<int>(LocalBridgeClazz, "FULL_JOIN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#INNER_JOIN"/>
        /// </summary>
        public static int INNER_JOIN { get { return SGetField<int>(LocalBridgeClazz, "INNER_JOIN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#LEFT_OUTER_JOIN"/>
        /// </summary>
        public static int LEFT_OUTER_JOIN { get { return SGetField<int>(LocalBridgeClazz, "LEFT_OUTER_JOIN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#RIGHT_OUTER_JOIN"/>
        /// </summary>
        public static int RIGHT_OUTER_JOIN { get { return SGetField<int>(LocalBridgeClazz, "RIGHT_OUTER_JOIN"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getJoinType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#setJoinType(int)"/>
        /// </summary>
        public int JoinType
        {
            get { return IExecute<int>("getJoinType"); } set { IExecute("setJoinType", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getRowSetNames()"/> 
        /// </summary>
        public string[] RowSetNames
        {
            get { return IExecuteArray<string>("getRowSetNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getRowSets()"/> 
        /// </summary>
        public Java.Util.Collection<object> RowSets
        {
            get { return IExecute<Java.Util.Collection<object>>("getRowSets"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getWhereClause()"/> 
        /// </summary>
        public string WhereClause
        {
            get { return IExecute<string>("getWhereClause"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsCrossJoin()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool SupportsCrossJoin()
        {
            return IExecute<bool>("supportsCrossJoin");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsFullJoin()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool SupportsFullJoin()
        {
            return IExecute<bool>("supportsFullJoin");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsInnerJoin()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool SupportsInnerJoin()
        {
            return IExecute<bool>("supportsInnerJoin");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsLeftOuterJoin()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool SupportsLeftOuterJoin()
        {
            return IExecute<bool>("supportsLeftOuterJoin");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsRightOuterJoin()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool SupportsRightOuterJoin()
        {
            return IExecute<bool>("supportsRightOuterJoin");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#toCachedRowSet()"/>
        /// </summary>

        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.CachedRowSet ToCachedRowSet()
        {
            return IExecute<Javax.Sql.Rowset.CachedRowSet>("toCachedRowSet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void AddRowSet(Javax.Sql.RowSet arg0, int arg1)
        {
            IExecute("addRowSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void AddRowSet(Javax.Sql.RowSet arg0, string arg1)
        {
            IExecute("addRowSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.rowset.Joinable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.Rowset.Joinable"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void AddRowSet(Javax.Sql.Rowset.Joinable arg0)
        {
            IExecute("addRowSet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void AddRowSet(Javax.Sql.RowSet[] arg0, int[] arg1)
        {
            IExecute("addRowSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void AddRowSet(Javax.Sql.RowSet[] arg0, string[] arg1)
        {
            IExecute("addRowSet", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}