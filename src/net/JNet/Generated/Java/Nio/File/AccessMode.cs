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

namespace Java.Nio.File
{
    #region AccessMode
    public partial class AccessMode
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/AccessMode.html#EXECUTE"/>
        /// </summary>
        public static Java.Nio.File.AccessMode EXECUTE { get { return LocalClazz.GetField<Java.Nio.File.AccessMode>("EXECUTE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/AccessMode.html#READ"/>
        /// </summary>
        public static Java.Nio.File.AccessMode READ { get { return LocalClazz.GetField<Java.Nio.File.AccessMode>("READ"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/AccessMode.html#WRITE"/>
        /// </summary>
        public static Java.Nio.File.AccessMode WRITE { get { return LocalClazz.GetField<Java.Nio.File.AccessMode>("WRITE"); } }
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/AccessMode.html#values()"/> 
        /// </summary>
        public static Java.Nio.File.AccessMode[] Values
        {
            get { return SExecuteArray<Java.Nio.File.AccessMode>(LocalClazz, "values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/AccessMode.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Nio.File.AccessMode"/></returns>
        public static Java.Nio.File.AccessMode ValueOf(string arg0)
        {
            return SExecute<Java.Nio.File.AccessMode>(LocalClazz, "valueOf", arg0);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}