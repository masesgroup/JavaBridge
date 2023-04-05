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

namespace Javax.Transaction.Xa
{
    #region Xid
    public partial class Xid
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#MAXBQUALSIZE"/>
        /// </summary>
        public static int MAXBQUALSIZE => Clazz.GetField<int>("MAXBQUALSIZE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#MAXGTRIDSIZE"/>
        /// </summary>
        public static int MAXGTRIDSIZE => Clazz.GetField<int>("MAXGTRIDSIZE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getBranchQualifier()"/> 
        /// </summary>
        public byte[] BranchQualifier
        {
            get { return IExecuteArray<byte>("getBranchQualifier"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getFormatId()"/> 
        /// </summary>
        public int FormatId
        {
            get { return IExecute<int>("getFormatId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getGlobalTransactionId()"/> 
        /// </summary>
        public byte[] GlobalTransactionId
        {
            get { return IExecuteArray<byte>("getGlobalTransactionId"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}