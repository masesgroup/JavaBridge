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

namespace Javax.Swing.Border
{
    #region BevelBorder declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html"/>
    /// </summary>
    public partial class BevelBorder : Javax.Swing.Border.AbstractBorder
    {
        const string _bridgeClassName = "javax.swing.border.BevelBorder";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BevelBorder() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BevelBorder(params object[] args) : base(args) { }

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

    #region BevelBorder implementation
    public partial class BevelBorder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#%3Cinit%3E(int,java.awt.Color,java.awt.Color,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Color"/></param>
        public BevelBorder(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2, Java.Awt.Color arg3, Java.Awt.Color arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#%3Cinit%3E(int,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        public BevelBorder(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public BevelBorder(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#LOWERED"/>
        /// </summary>
        public static int LOWERED { get { if (!_LOWEREDReady) { _LOWEREDContent = SGetField<int>(LocalBridgeClazz, "LOWERED"); _LOWEREDReady = true; } return _LOWEREDContent; } }
        private static int _LOWEREDContent = default;
        private static bool _LOWEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#RAISED"/>
        /// </summary>
        public static int RAISED { get { if (!_RAISEDReady) { _RAISEDContent = SGetField<int>(LocalBridgeClazz, "RAISED"); _RAISEDReady = true; } return _RAISEDContent; } }
        private static int _RAISEDContent = default;
        private static bool _RAISEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getBevelType()"/> 
        /// </summary>
        public int BevelType
        {
            get { return IExecuteWithSignature<int>("getBevelType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getHighlightInnerColor()"/> 
        /// </summary>
        public Java.Awt.Color HighlightInnerColor
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getHighlightInnerColor", "()Ljava/awt/Color;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getHighlightOuterColor()"/> 
        /// </summary>
        public Java.Awt.Color HighlightOuterColor
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getHighlightOuterColor", "()Ljava/awt/Color;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getShadowInnerColor()"/> 
        /// </summary>
        public Java.Awt.Color ShadowInnerColor
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getShadowInnerColor", "()Ljava/awt/Color;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getShadowOuterColor()"/> 
        /// </summary>
        public Java.Awt.Color ShadowOuterColor
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getShadowOuterColor", "()Ljava/awt/Color;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getHighlightInnerColor(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetHighlightInnerColor(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getHighlightInnerColor", "(Ljava/awt/Component;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getHighlightOuterColor(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetHighlightOuterColor(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getHighlightOuterColor", "(Ljava/awt/Component;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getShadowInnerColor(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetShadowInnerColor(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getShadowInnerColor", "(Ljava/awt/Component;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getShadowOuterColor(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetShadowOuterColor(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getShadowOuterColor", "(Ljava/awt/Component;)Ljava/awt/Color;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}