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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Sql
{
    #region Driver
    public partial class Driver
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Driver.html#jdbcCompliant()"/> 
        /// </summary>
        public bool JdbcCompliant
        {
            get { return IExecute<bool>("jdbcCompliant"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Driver.html#getMajorVersion()"/> 
        /// </summary>
        public int MajorVersion
        {
            get { return IExecute<int>("getMajorVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Driver.html#getMinorVersion()"/> 
        /// </summary>
        public int MinorVersion
        {
            get { return IExecute<int>("getMinorVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Driver.html#getParentLogger()"/> 
        /// </summary>
        public Java.Util.Logging.Logger ParentLogger
        {
            get { return IExecute<Java.Util.Logging.Logger>("getParentLogger"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Driver.html#acceptsURL(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool AcceptsURL(string arg0)
        {
            return IExecute<bool>("acceptsURL", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Driver.html#connect(java.lang.String,java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Properties"/></param>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Connection Connect(string arg0, Java.Util.Properties arg1)
        {
            return IExecute<Java.Sql.Connection>("connect", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Driver.html#getPropertyInfo(java.lang.String,java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Properties"/></param>
        /// <returns><see cref="Java.Sql.DriverPropertyInfo"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.DriverPropertyInfo[] GetPropertyInfo(string arg0, Java.Util.Properties arg1)
        {
            return IExecuteArray<Java.Sql.DriverPropertyInfo>("getPropertyInfo", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}