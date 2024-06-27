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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Spi
{
    #region ResolveResult
    public partial class ResolveResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/ResolveResult.html#%3Cinit%3E(java.lang.Object,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public ResolveResult(object arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/ResolveResult.html#%3Cinit%3E(java.lang.Object,javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        public ResolveResult(object arg0, Javax.Naming.Name arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/ResolveResult.html#getRemainingName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/ResolveResult.html#setRemainingName(javax.naming.Name)"/>
        /// </summary>
        public Javax.Naming.Name RemainingName
        {
            get { return IExecuteWithSignature<Javax.Naming.Name>("getRemainingName", "()Ljavax/naming/Name;"); } set { IExecuteWithSignature("setRemainingName", "(Ljavax/naming/Name;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/ResolveResult.html#getResolvedObj()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/ResolveResult.html#setResolvedObj(java.lang.Object)"/>
        /// </summary>
        public object ResolvedObj
        {
            get { return IExecuteWithSignature("getResolvedObj", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setResolvedObj", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/ResolveResult.html#appendRemainingComponent(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void AppendRemainingComponent(Java.Lang.String arg0)
        {
            IExecuteWithSignature("appendRemainingComponent", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/ResolveResult.html#appendRemainingName(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        public void AppendRemainingName(Javax.Naming.Name arg0)
        {
            IExecuteWithSignature("appendRemainingName", "(Ljavax/naming/Name;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}