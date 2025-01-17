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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region BoundedRangeModel declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html"/>
    /// </summary>
    public partial class BoundedRangeModel : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BoundedRangeModel>
    {
        const string _bridgeClassName = "javax.swing.BoundedRangeModel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("BoundedRangeModel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BoundedRangeModel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("BoundedRangeModel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BoundedRangeModel(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IBoundedRangeModel
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBoundedRangeModel
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#getExtent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#setExtent(int)"/>
        /// </summary>
        int Extent { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#getMaximum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#setMaximum(int)"/>
        /// </summary>
        int Maximum { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#getMinimum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#setMinimum(int)"/>
        /// </summary>
        int Minimum { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#setValue(int)"/>
        /// </summary>
        int Value { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#getValueIsAdjusting()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#setValueIsAdjusting(boolean)"/>
        /// </summary>
        bool ValueIsAdjusting { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        void AddChangeListener(Javax.Swing.Event.ChangeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#setRangeProperties(int,int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        void SetRangeProperties(int arg0, int arg1, int arg2, int arg3, bool arg4);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BoundedRangeModel implementation
    public partial class BoundedRangeModel : Javax.Swing.IBoundedRangeModel
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#getExtent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#setExtent(int)"/>
        /// </summary>
        public int Extent
        {
            get { return IExecuteWithSignature<int>("getExtent", "()I"); } set { IExecuteWithSignature("setExtent", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#getMaximum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#setMaximum(int)"/>
        /// </summary>
        public int Maximum
        {
            get { return IExecuteWithSignature<int>("getMaximum", "()I"); } set { IExecuteWithSignature("setMaximum", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#getMinimum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#setMinimum(int)"/>
        /// </summary>
        public int Minimum
        {
            get { return IExecuteWithSignature<int>("getMinimum", "()I"); } set { IExecuteWithSignature("setMinimum", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#setValue(int)"/>
        /// </summary>
        public int Value
        {
            get { return IExecuteWithSignature<int>("getValue", "()I"); } set { IExecuteWithSignature("setValue", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#getValueIsAdjusting()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#setValueIsAdjusting(boolean)"/>
        /// </summary>
        public bool ValueIsAdjusting
        {
            get { return IExecuteWithSignature<bool>("getValueIsAdjusting", "()Z"); } set { IExecuteWithSignature("setValueIsAdjusting", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("addChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("removeChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoundedRangeModel.html#setRangeProperties(int,int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        public void SetRangeProperties(int arg0, int arg1, int arg2, int arg3, bool arg4)
        {
            IExecuteWithSignature("setRangeProperties", "(IIIIZ)V", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}