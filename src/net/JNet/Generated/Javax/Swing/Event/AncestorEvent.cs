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

namespace Javax.Swing.Event
{
    #region AncestorEvent
    public partial class AncestorEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorEvent.html#%3Cinit%3E(javax.swing.JComponent,int,java.awt.Container,java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Container"/></param>
        public AncestorEvent(Javax.Swing.JComponent arg0, int arg1, Java.Awt.Container arg2, Java.Awt.Container arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorEvent.html#ANCESTOR_ADDED"/>
        /// </summary>
        public static int ANCESTOR_ADDED { get { if (!_ANCESTOR_ADDEDReady) { _ANCESTOR_ADDEDContent = SGetField<int>(LocalBridgeClazz, "ANCESTOR_ADDED"); _ANCESTOR_ADDEDReady = true; } return _ANCESTOR_ADDEDContent; } }
        private static int _ANCESTOR_ADDEDContent = default;
        private static bool _ANCESTOR_ADDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorEvent.html#ANCESTOR_MOVED"/>
        /// </summary>
        public static int ANCESTOR_MOVED { get { if (!_ANCESTOR_MOVEDReady) { _ANCESTOR_MOVEDContent = SGetField<int>(LocalBridgeClazz, "ANCESTOR_MOVED"); _ANCESTOR_MOVEDReady = true; } return _ANCESTOR_MOVEDContent; } }
        private static int _ANCESTOR_MOVEDContent = default;
        private static bool _ANCESTOR_MOVEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorEvent.html#ANCESTOR_REMOVED"/>
        /// </summary>
        public static int ANCESTOR_REMOVED { get { if (!_ANCESTOR_REMOVEDReady) { _ANCESTOR_REMOVEDContent = SGetField<int>(LocalBridgeClazz, "ANCESTOR_REMOVED"); _ANCESTOR_REMOVEDReady = true; } return _ANCESTOR_REMOVEDContent; } }
        private static int _ANCESTOR_REMOVEDContent = default;
        private static bool _ANCESTOR_REMOVEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorEvent.html#getAncestor()"/> 
        /// </summary>
        public Java.Awt.Container Ancestor
        {
            get { return IExecuteWithSignature<Java.Awt.Container>("getAncestor", "()Ljava/awt/Container;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorEvent.html#getAncestorParent()"/> 
        /// </summary>
        public Java.Awt.Container AncestorParent
        {
            get { return IExecuteWithSignature<Java.Awt.Container>("getAncestorParent", "()Ljava/awt/Container;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorEvent.html#getComponent()"/> 
        /// </summary>
        public Javax.Swing.JComponent Component
        {
            get { return IExecuteWithSignature<Javax.Swing.JComponent>("getComponent", "()Ljavax/swing/JComponent;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}