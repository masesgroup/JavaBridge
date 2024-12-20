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
    #region SpinnerDateModel declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html"/>
    /// </summary>
    public partial class SpinnerDateModel : Javax.Swing.AbstractSpinnerModel
    {
        const string _bridgeClassName = "javax.swing.SpinnerDateModel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SpinnerDateModel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SpinnerDateModel(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region SpinnerDateModel implementation
    public partial class SpinnerDateModel
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#%3Cinit%3E(java.util.Date,java.lang.Comparable,java.lang.Comparable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Comparable"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Comparable"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public SpinnerDateModel(Java.Util.Date arg0, Java.Lang.Comparable<Java.Util.Date> arg1, Java.Lang.Comparable<Java.Util.Date> arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#getCalendarField()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#setCalendarField(int)"/>
        /// </summary>
        public int CalendarField
        {
            get { return IExecuteWithSignature<int>("getCalendarField", "()I"); } set { IExecuteWithSignature("setCalendarField", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#getDate()"/> 
        /// </summary>
        public Java.Util.Date Date
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getDate", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#getEnd()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#setEnd(java.lang.Comparable)"/>
        /// </summary>
        public Java.Lang.Comparable<Java.Util.Date> End
        {
            get { return IExecuteWithSignature<Java.Lang.Comparable<Java.Util.Date>>("getEnd", "()Ljava/lang/Comparable;"); } set { IExecuteWithSignature("setEnd", "(Ljava/lang/Comparable;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#getStart()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerDateModel.html#setStart(java.lang.Comparable)"/>
        /// </summary>
        public Java.Lang.Comparable<Java.Util.Date> Start
        {
            get { return IExecuteWithSignature<Java.Lang.Comparable<Java.Util.Date>>("getStart", "()Ljava/lang/Comparable;"); } set { IExecuteWithSignature("setStart", "(Ljava/lang/Comparable;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}