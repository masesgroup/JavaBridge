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

namespace Java.Rmi.Activation
{
    #region IActivationSystem
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IActivationSystem : Java.Rmi.IRemote
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#getActivationDesc(java.rmi.activation.ActivationID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationDesc"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownObjectException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        Java.Rmi.Activation.ActivationDesc GetActivationDesc(Java.Rmi.Activation.ActivationID arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#setActivationDesc(java.rmi.activation.ActivationID,java.rmi.activation.ActivationDesc)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Activation.ActivationDesc"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationDesc"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownObjectException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownGroupException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        Java.Rmi.Activation.ActivationDesc SetActivationDesc(Java.Rmi.Activation.ActivationID arg0, Java.Rmi.Activation.ActivationDesc arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#getActivationGroupDesc(java.rmi.activation.ActivationGroupID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationGroupID"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationGroupDesc"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownGroupException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        Java.Rmi.Activation.ActivationGroupDesc GetActivationGroupDesc(Java.Rmi.Activation.ActivationGroupID arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#setActivationGroupDesc(java.rmi.activation.ActivationGroupID,java.rmi.activation.ActivationGroupDesc)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationGroupID"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Activation.ActivationGroupDesc"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationGroupDesc"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownGroupException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        Java.Rmi.Activation.ActivationGroupDesc SetActivationGroupDesc(Java.Rmi.Activation.ActivationGroupID arg0, Java.Rmi.Activation.ActivationGroupDesc arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#registerGroup(java.rmi.activation.ActivationGroupDesc)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationGroupDesc"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationGroupID"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        Java.Rmi.Activation.ActivationGroupID RegisterGroup(Java.Rmi.Activation.ActivationGroupDesc arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#registerObject(java.rmi.activation.ActivationDesc)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationDesc"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationID"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownGroupException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        Java.Rmi.Activation.ActivationID RegisterObject(Java.Rmi.Activation.ActivationDesc arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#activeGroup(java.rmi.activation.ActivationGroupID,java.rmi.activation.ActivationInstantiator,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationGroupID"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Activation.ActivationInstantiator"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationMonitor"/></returns>
        /// <exception cref="Java.Rmi.Activation.UnknownGroupException"/>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        Java.Rmi.Activation.ActivationMonitor ActiveGroup(Java.Rmi.Activation.ActivationGroupID arg0, Java.Rmi.Activation.ActivationInstantiator arg1, long arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#shutdown()"/>
        /// </summary>
        /// <exception cref="Java.Rmi.RemoteException"/>
        void Shutdown();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#unregisterGroup(java.rmi.activation.ActivationGroupID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationGroupID"/></param>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownGroupException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        void UnregisterGroup(Java.Rmi.Activation.ActivationGroupID arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#unregisterObject(java.rmi.activation.ActivationID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownObjectException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        void UnregisterObject(Java.Rmi.Activation.ActivationID arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ActivationSystem
    public partial class ActivationSystem : Java.Rmi.Activation.IActivationSystem
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#SYSTEM_PORT"/>
        /// </summary>
        public static int SYSTEM_PORT { get { if (!_SYSTEM_PORTReady) { _SYSTEM_PORTContent = SGetField<int>(LocalBridgeClazz, "SYSTEM_PORT"); _SYSTEM_PORTReady = true; } return _SYSTEM_PORTContent; } }
        private static int _SYSTEM_PORTContent = default;
        private static bool _SYSTEM_PORTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#getActivationDesc(java.rmi.activation.ActivationID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationDesc"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownObjectException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public Java.Rmi.Activation.ActivationDesc GetActivationDesc(Java.Rmi.Activation.ActivationID arg0)
        {
            return IExecute<Java.Rmi.Activation.ActivationDesc>("getActivationDesc", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#setActivationDesc(java.rmi.activation.ActivationID,java.rmi.activation.ActivationDesc)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Activation.ActivationDesc"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationDesc"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownObjectException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownGroupException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public Java.Rmi.Activation.ActivationDesc SetActivationDesc(Java.Rmi.Activation.ActivationID arg0, Java.Rmi.Activation.ActivationDesc arg1)
        {
            return IExecute<Java.Rmi.Activation.ActivationDesc>("setActivationDesc", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#getActivationGroupDesc(java.rmi.activation.ActivationGroupID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationGroupID"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationGroupDesc"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownGroupException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public Java.Rmi.Activation.ActivationGroupDesc GetActivationGroupDesc(Java.Rmi.Activation.ActivationGroupID arg0)
        {
            return IExecute<Java.Rmi.Activation.ActivationGroupDesc>("getActivationGroupDesc", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#setActivationGroupDesc(java.rmi.activation.ActivationGroupID,java.rmi.activation.ActivationGroupDesc)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationGroupID"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Activation.ActivationGroupDesc"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationGroupDesc"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownGroupException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public Java.Rmi.Activation.ActivationGroupDesc SetActivationGroupDesc(Java.Rmi.Activation.ActivationGroupID arg0, Java.Rmi.Activation.ActivationGroupDesc arg1)
        {
            return IExecute<Java.Rmi.Activation.ActivationGroupDesc>("setActivationGroupDesc", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#registerGroup(java.rmi.activation.ActivationGroupDesc)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationGroupDesc"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationGroupID"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public Java.Rmi.Activation.ActivationGroupID RegisterGroup(Java.Rmi.Activation.ActivationGroupDesc arg0)
        {
            return IExecute<Java.Rmi.Activation.ActivationGroupID>("registerGroup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#registerObject(java.rmi.activation.ActivationDesc)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationDesc"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationID"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownGroupException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public Java.Rmi.Activation.ActivationID RegisterObject(Java.Rmi.Activation.ActivationDesc arg0)
        {
            return IExecute<Java.Rmi.Activation.ActivationID>("registerObject", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#activeGroup(java.rmi.activation.ActivationGroupID,java.rmi.activation.ActivationInstantiator,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationGroupID"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Activation.ActivationInstantiator"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationMonitor"/></returns>
        /// <exception cref="Java.Rmi.Activation.UnknownGroupException"/>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public Java.Rmi.Activation.ActivationMonitor ActiveGroup(Java.Rmi.Activation.ActivationGroupID arg0, Java.Rmi.Activation.ActivationInstantiator arg1, long arg2)
        {
            return IExecute<Java.Rmi.Activation.ActivationMonitor>("activeGroup", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#shutdown()"/>
        /// </summary>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public void Shutdown()
        {
            IExecute("shutdown");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#unregisterGroup(java.rmi.activation.ActivationGroupID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationGroupID"/></param>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownGroupException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public void UnregisterGroup(Java.Rmi.Activation.ActivationGroupID arg0)
        {
            IExecute("unregisterGroup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationSystem.html#unregisterObject(java.rmi.activation.ActivationID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.Activation.UnknownObjectException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public void UnregisterObject(Java.Rmi.Activation.ActivationID arg0)
        {
            IExecute("unregisterObject", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}