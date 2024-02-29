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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Rmi.Dgc
{
    #region IDGC
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDGC : Java.Rmi.IRemote
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/dgc/DGC.html#dirty(java.rmi.server.ObjID[],long,java.rmi.dgc.Lease)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Server.ObjID"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.Dgc.Lease"/></param>
        /// <returns><see cref="Java.Rmi.Dgc.Lease"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        Java.Rmi.Dgc.Lease Dirty(Java.Rmi.Server.ObjID[] arg0, long arg1, Java.Rmi.Dgc.Lease arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/dgc/DGC.html#clean(java.rmi.server.ObjID[],long,java.rmi.dgc.VMID,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Server.ObjID"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.Dgc.VMID"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <exception cref="Java.Rmi.RemoteException"/>
        void Clean(Java.Rmi.Server.ObjID[] arg0, long arg1, Java.Rmi.Dgc.VMID arg2, bool arg3);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DGC
    public partial class DGC : Java.Rmi.Dgc.IDGC
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/dgc/DGC.html#dirty(java.rmi.server.ObjID[],long,java.rmi.dgc.Lease)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Server.ObjID"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.Dgc.Lease"/></param>
        /// <returns><see cref="Java.Rmi.Dgc.Lease"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public Java.Rmi.Dgc.Lease Dirty(Java.Rmi.Server.ObjID[] arg0, long arg1, Java.Rmi.Dgc.Lease arg2)
        {
            return IExecute<Java.Rmi.Dgc.Lease>("dirty", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/dgc/DGC.html#clean(java.rmi.server.ObjID[],long,java.rmi.dgc.VMID,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Server.ObjID"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.Dgc.VMID"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public void Clean(Java.Rmi.Server.ObjID[] arg0, long arg1, Java.Rmi.Dgc.VMID arg2, bool arg3)
        {
            IExecute("clean", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}