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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql.Rowset.Serial
{
    #region SerialStruct
    public partial class SerialStruct
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialStruct.html#%3Cinit%3E(java.sql.SQLData,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.SQLData"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        public SerialStruct(Java.Sql.SQLData arg0, Java.Util.Map<string, Java.Lang.Class> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialStruct.html#%3Cinit%3E(java.sql.Struct,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Struct"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        public SerialStruct(Java.Sql.Struct arg0, Java.Util.Map<string, Java.Lang.Class> arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.Serial.SerialStruct"/> to <see cref="Java.Sql.Struct"/>
        /// </summary>
        public static implicit operator Java.Sql.Struct(Javax.Sql.Rowset.Serial.SerialStruct t) => t.Cast<Java.Sql.Struct>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.Serial.SerialStruct"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Sql.Rowset.Serial.SerialStruct t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.Serial.SerialStruct"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Sql.Rowset.Serial.SerialStruct t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialStruct.html#getAttributes()"/> 
        /// </summary>
        public object[] Attributes
        {
            get { return IExecuteArray<object>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialStruct.html#getSQLTypeName()"/> 
        /// </summary>
        public string SQLTypeName
        {
            get { return IExecute<string>("getSQLTypeName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialStruct.html#getAttributes(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        public object[] GetAttributes(Java.Util.Map<string, Java.Lang.Class> arg0)
        {
            return IExecuteArray<object>("getAttributes", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}