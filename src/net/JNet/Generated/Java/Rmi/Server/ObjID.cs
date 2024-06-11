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

namespace Java.Rmi.Server
{
    #region ObjID
    public partial class ObjID
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ObjID.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public ObjID(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ObjID.html#ACTIVATOR_ID"/>
        /// </summary>
        public static int ACTIVATOR_ID { get { if (!_ACTIVATOR_IDReady) { _ACTIVATOR_IDContent = SGetField<int>(LocalBridgeClazz, "ACTIVATOR_ID"); _ACTIVATOR_IDReady = true; } return _ACTIVATOR_IDContent; } }
        private static int _ACTIVATOR_IDContent = default;
        private static bool _ACTIVATOR_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ObjID.html#DGC_ID"/>
        /// </summary>
        public static int DGC_ID { get { if (!_DGC_IDReady) { _DGC_IDContent = SGetField<int>(LocalBridgeClazz, "DGC_ID"); _DGC_IDReady = true; } return _DGC_IDContent; } }
        private static int _DGC_IDContent = default;
        private static bool _DGC_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ObjID.html#REGISTRY_ID"/>
        /// </summary>
        public static int REGISTRY_ID { get { if (!_REGISTRY_IDReady) { _REGISTRY_IDContent = SGetField<int>(LocalBridgeClazz, "REGISTRY_ID"); _REGISTRY_IDReady = true; } return _REGISTRY_IDContent; } }
        private static int _REGISTRY_IDContent = default;
        private static bool _REGISTRY_IDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ObjID.html#read(java.io.ObjectInput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectInput"/></param>
        /// <returns><see cref="Java.Rmi.Server.ObjID"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Rmi.Server.ObjID Read(Java.Io.ObjectInput arg0)
        {
            return SExecuteWithSignature<Java.Rmi.Server.ObjID>(LocalBridgeClazz, "read", "(Ljava/io/ObjectInput;)Ljava/rmi/server/ObjID;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ObjID.html#write(java.io.ObjectOutput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectOutput"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(Java.Io.ObjectOutput arg0)
        {
            IExecuteWithSignature("write", "(Ljava/io/ObjectOutput;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}