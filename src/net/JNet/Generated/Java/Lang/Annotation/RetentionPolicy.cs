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

namespace Java.Lang.Annotation
{
    #region RetentionPolicy
    public partial class RetentionPolicy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/annotation/RetentionPolicy.html#CLASS"/>
        /// </summary>
        public static Java.Lang.Annotation.RetentionPolicy CLASS => Clazz.GetField<Java.Lang.Annotation.RetentionPolicy>("CLASS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/annotation/RetentionPolicy.html#RUNTIME"/>
        /// </summary>
        public static Java.Lang.Annotation.RetentionPolicy RUNTIME => Clazz.GetField<Java.Lang.Annotation.RetentionPolicy>("RUNTIME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/annotation/RetentionPolicy.html#SOURCE"/>
        /// </summary>
        public static Java.Lang.Annotation.RetentionPolicy SOURCE => Clazz.GetField<Java.Lang.Annotation.RetentionPolicy>("SOURCE");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/annotation/RetentionPolicy.html#values()"/> 
        /// </summary>
        public static Java.Lang.Annotation.RetentionPolicy[] Values
        {
            get { return SExecuteArray<Java.Lang.Annotation.RetentionPolicy>("values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/annotation/RetentionPolicy.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Annotation.RetentionPolicy"/></returns>
        public static Java.Lang.Annotation.RetentionPolicy ValueOf(string arg0)
        {
            return SExecute<Java.Lang.Annotation.RetentionPolicy>("valueOf", arg0);
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