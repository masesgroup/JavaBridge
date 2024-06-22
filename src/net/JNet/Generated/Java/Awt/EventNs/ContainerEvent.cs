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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region ContainerEvent
    public partial class ContainerEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerEvent.html#%3Cinit%3E(java.awt.Component,int,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        public ContainerEvent(Java.Awt.Component arg0, int arg1, Java.Awt.Component arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerEvent.html#COMPONENT_ADDED"/>
        /// </summary>
        public static int COMPONENT_ADDED { get { if (!_COMPONENT_ADDEDReady) { _COMPONENT_ADDEDContent = SGetField<int>(LocalBridgeClazz, "COMPONENT_ADDED"); _COMPONENT_ADDEDReady = true; } return _COMPONENT_ADDEDContent; } }
        private static int _COMPONENT_ADDEDContent = default;
        private static bool _COMPONENT_ADDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerEvent.html#COMPONENT_REMOVED"/>
        /// </summary>
        public static int COMPONENT_REMOVED { get { if (!_COMPONENT_REMOVEDReady) { _COMPONENT_REMOVEDContent = SGetField<int>(LocalBridgeClazz, "COMPONENT_REMOVED"); _COMPONENT_REMOVEDReady = true; } return _COMPONENT_REMOVEDContent; } }
        private static int _COMPONENT_REMOVEDContent = default;
        private static bool _COMPONENT_REMOVEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerEvent.html#CONTAINER_FIRST"/>
        /// </summary>
        public static int CONTAINER_FIRST { get { if (!_CONTAINER_FIRSTReady) { _CONTAINER_FIRSTContent = SGetField<int>(LocalBridgeClazz, "CONTAINER_FIRST"); _CONTAINER_FIRSTReady = true; } return _CONTAINER_FIRSTContent; } }
        private static int _CONTAINER_FIRSTContent = default;
        private static bool _CONTAINER_FIRSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerEvent.html#CONTAINER_LAST"/>
        /// </summary>
        public static int CONTAINER_LAST { get { if (!_CONTAINER_LASTReady) { _CONTAINER_LASTContent = SGetField<int>(LocalBridgeClazz, "CONTAINER_LAST"); _CONTAINER_LASTReady = true; } return _CONTAINER_LASTContent; } }
        private static int _CONTAINER_LASTContent = default;
        private static bool _CONTAINER_LASTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerEvent.html#getChild()"/> 
        /// </summary>
        public Java.Awt.Component Child
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getChild", "()Ljava/awt/Component;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerEvent.html#getContainer()"/> 
        /// </summary>
        public Java.Awt.Container Container
        {
            get { return IExecuteWithSignature<Java.Awt.Container>("getContainer", "()Ljava/awt/Container;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}