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

namespace Java.Rmi.Dgc
{
    #region Lease
    public partial class Lease
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/dgc/Lease.html#%3Cinit%3E(java.rmi.dgc.VMID,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Dgc.VMID"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public Lease(Java.Rmi.Dgc.VMID arg0, long arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/dgc/Lease.html#getValue()"/> 
        /// </summary>
        public long Value
        {
            get { return IExecuteWithSignature<long>("getValue", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/dgc/Lease.html#getVMID()"/> 
        /// </summary>
        public Java.Rmi.Dgc.VMID VMID
        {
            get { return IExecuteWithSignature<Java.Rmi.Dgc.VMID>("getVMID", "()Ljava/rmi/dgc/VMID;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}