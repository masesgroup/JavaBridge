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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Sql
{
    #region DriverPropertyInfo
    public partial class DriverPropertyInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverPropertyInfo.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public DriverPropertyInfo(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverPropertyInfo.html#required"/>
        /// </summary>
        public bool required { get { return IGetField<bool>("required"); } set { ISetField("required", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverPropertyInfo.html#description"/>
        /// </summary>
        public Java.Lang.String description { get { return IGetField<Java.Lang.String>("description"); } set { ISetField("description", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverPropertyInfo.html#name"/>
        /// </summary>
        public Java.Lang.String name { get { return IGetField<Java.Lang.String>("name"); } set { ISetField("name", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverPropertyInfo.html#value"/>
        /// </summary>
        public Java.Lang.String value { get { return IGetField<Java.Lang.String>("value"); } set { ISetField("value", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverPropertyInfo.html#choices"/>
        /// </summary>
        public Java.Lang.String[] choices { get { return IGetFieldArray<Java.Lang.String>("choices"); } set { ISetField("choices", value); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}