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
    #region ISQLData
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISQLData
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLData.html#getSQLTypeName()"/> 
        /// </summary>
        Java.Lang.String SQLTypeName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLData.html#readSQL(java.sql.SQLInput,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.SQLInput"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void ReadSQL(Java.Sql.SQLInput arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLData.html#writeSQL(java.sql.SQLOutput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.SQLOutput"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void WriteSQL(Java.Sql.SQLOutput arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SQLData
    public partial class SQLData : Java.Sql.ISQLData
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLData.html#getSQLTypeName()"/> 
        /// </summary>
        public Java.Lang.String SQLTypeName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSQLTypeName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLData.html#readSQL(java.sql.SQLInput,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.SQLInput"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void ReadSQL(Java.Sql.SQLInput arg0, Java.Lang.String arg1)
        {
            IExecute("readSQL", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLData.html#writeSQL(java.sql.SQLOutput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.SQLOutput"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteSQL(Java.Sql.SQLOutput arg0)
        {
            IExecuteWithSignature("writeSQL", "(Ljava/sql/SQLOutput;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}