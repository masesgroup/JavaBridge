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

namespace Javax.Management
{
    #region AttributeValueExp
    public partial class AttributeValueExp
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeValueExp.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public AttributeValueExp(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeValueExp.html#getAttributeName()"/> 
        /// </summary>
        public Java.Lang.String AttributeName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAttributeName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeValueExp.html#apply(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Javax.Management.ValueExp"/></returns>
        /// <exception cref="Javax.Management.BadStringOperationException"/>
        /// <exception cref="Javax.Management.BadBinaryOpValueExpException"/>
        /// <exception cref="Javax.Management.BadAttributeValueExpException"/>
        /// <exception cref="Javax.Management.InvalidApplicationException"/>
        public Javax.Management.ValueExp Apply(Javax.Management.ObjectName arg0)
        {
            return IExecuteWithSignature<Javax.Management.ValueExp>("apply", "(Ljavax/management/ObjectName;)Ljavax/management/ValueExp;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}