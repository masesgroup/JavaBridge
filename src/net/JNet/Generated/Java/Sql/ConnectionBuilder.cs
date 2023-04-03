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
    #region ConnectionBuilder
    public partial class ConnectionBuilder
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#build()"/> 
        /// </summary>
        public Java.Sql.Connection Build
        {
            get { return IExecute<Java.Sql.Connection>("build"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#password(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.ConnectionBuilder"/></returns>
        public Java.Sql.ConnectionBuilder Password(string arg0)
        {
            return IExecute<Java.Sql.ConnectionBuilder>("password", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#shardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <returns><see cref="Java.Sql.ConnectionBuilder"/></returns>
        public Java.Sql.ConnectionBuilder ShardingKey(Java.Sql.ShardingKey arg0)
        {
            return IExecute<Java.Sql.ConnectionBuilder>("shardingKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#superShardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <returns><see cref="Java.Sql.ConnectionBuilder"/></returns>
        public Java.Sql.ConnectionBuilder SuperShardingKey(Java.Sql.ShardingKey arg0)
        {
            return IExecute<Java.Sql.ConnectionBuilder>("superShardingKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#user(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.ConnectionBuilder"/></returns>
        public Java.Sql.ConnectionBuilder User(string arg0)
        {
            return IExecute<Java.Sql.ConnectionBuilder>("user", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}