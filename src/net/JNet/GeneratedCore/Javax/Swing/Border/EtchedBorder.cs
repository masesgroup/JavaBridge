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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Border
{
    #region EtchedBorder definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html"/>
    /// </summary>
    public partial class EtchedBorder : Javax.Swing.Border.AbstractBorder
    {
        const string _bridgeClassName = "javax.swing.border.EtchedBorder";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EtchedBorder() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public EtchedBorder(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region EtchedBorder
    public partial class EtchedBorder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#%3Cinit%3E(int,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        public EtchedBorder(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public EtchedBorder(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#%3Cinit%3E(java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        public EtchedBorder(Java.Awt.Color arg0, Java.Awt.Color arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#LOWERED"/>
        /// </summary>
        public static int LOWERED { get { if (!_LOWEREDReady) { _LOWEREDContent = SGetField<int>(LocalBridgeClazz, "LOWERED"); _LOWEREDReady = true; } return _LOWEREDContent; } }
        private static int _LOWEREDContent = default;
        private static bool _LOWEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#RAISED"/>
        /// </summary>
        public static int RAISED { get { if (!_RAISEDReady) { _RAISEDContent = SGetField<int>(LocalBridgeClazz, "RAISED"); _RAISEDReady = true; } return _RAISEDContent; } }
        private static int _RAISEDContent = default;
        private static bool _RAISEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#getEtchType()"/> 
        /// </summary>
        public int EtchType
        {
            get { return IExecuteWithSignature<int>("getEtchType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#getHighlightColor()"/> 
        /// </summary>
        public Java.Awt.Color HighlightColor
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getHighlightColor", "()Ljava/awt/Color;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#getShadowColor()"/> 
        /// </summary>
        public Java.Awt.Color ShadowColor
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getShadowColor", "()Ljava/awt/Color;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#getHighlightColor(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetHighlightColor(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getHighlightColor", "(Ljava/awt/Component;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/EtchedBorder.html#getShadowColor(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetShadowColor(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getShadowColor", "(Ljava/awt/Component;)Ljava/awt/Color;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}