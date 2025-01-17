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
    #region LayoutStyle declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.html"/>
    /// </summary>
    public partial class LayoutStyle : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LayoutStyle>
    {
        const string _bridgeClassName = "javax.swing.LayoutStyle";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("LayoutStyle class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public LayoutStyle() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("LayoutStyle class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public LayoutStyle(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region ComponentPlacement declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.ComponentPlacement.html"/>
        /// </summary>
        public partial class ComponentPlacement : Java.Lang.Enum<Javax.Swing.LayoutStyle.ComponentPlacement>
        {
            const string _bridgeClassName = "javax.swing.LayoutStyle$ComponentPlacement";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ComponentPlacement() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ComponentPlacement(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region LayoutStyle implementation
    public partial class LayoutStyle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.html#getInstance()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.html#setInstance(javax.swing.LayoutStyle)"/>
        /// </summary>
        public static Javax.Swing.LayoutStyle Instance
        {
            get { return SExecuteWithSignature<Javax.Swing.LayoutStyle>(LocalBridgeClazz, "getInstance", "()Ljavax/swing/LayoutStyle;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setInstance", "(Ljavax/swing/LayoutStyle;)V", value); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.html#getContainerGap(javax.swing.JComponent,int,java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetContainerGap(Javax.Swing.JComponent arg0, int arg1, Java.Awt.Container arg2)
        {
            return IExecuteWithSignature<int>("getContainerGap", "(Ljavax/swing/JComponent;ILjava/awt/Container;)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.html#getPreferredGap(javax.swing.JComponent,javax.swing.JComponent,javax.swing.LayoutStyle.ComponentPlacement,int,java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.LayoutStyle.ComponentPlacement"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetPreferredGap(Javax.Swing.JComponent arg0, Javax.Swing.JComponent arg1, Javax.Swing.LayoutStyle.ComponentPlacement arg2, int arg3, Java.Awt.Container arg4)
        {
            return IExecuteWithSignature<int>("getPreferredGap", "(Ljavax/swing/JComponent;Ljavax/swing/JComponent;Ljavax/swing/LayoutStyle$ComponentPlacement;ILjava/awt/Container;)I", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes
        #region ComponentPlacement implementation
        public partial class ComponentPlacement
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.ComponentPlacement.html#INDENT"/>
            /// </summary>
            public static Javax.Swing.LayoutStyle.ComponentPlacement INDENT { get { if (!_INDENTReady) { _INDENTContent = SGetField<Javax.Swing.LayoutStyle.ComponentPlacement>(LocalBridgeClazz, "INDENT"); _INDENTReady = true; } return _INDENTContent; } }
            private static Javax.Swing.LayoutStyle.ComponentPlacement _INDENTContent = default;
            private static bool _INDENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.ComponentPlacement.html#RELATED"/>
            /// </summary>
            public static Javax.Swing.LayoutStyle.ComponentPlacement RELATED { get { if (!_RELATEDReady) { _RELATEDContent = SGetField<Javax.Swing.LayoutStyle.ComponentPlacement>(LocalBridgeClazz, "RELATED"); _RELATEDReady = true; } return _RELATEDContent; } }
            private static Javax.Swing.LayoutStyle.ComponentPlacement _RELATEDContent = default;
            private static bool _RELATEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.ComponentPlacement.html#UNRELATED"/>
            /// </summary>
            public static Javax.Swing.LayoutStyle.ComponentPlacement UNRELATED { get { if (!_UNRELATEDReady) { _UNRELATEDContent = SGetField<Javax.Swing.LayoutStyle.ComponentPlacement>(LocalBridgeClazz, "UNRELATED"); _UNRELATEDReady = true; } return _UNRELATEDContent; } }
            private static Javax.Swing.LayoutStyle.ComponentPlacement _UNRELATEDContent = default;
            private static bool _UNRELATEDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.ComponentPlacement.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Javax.Swing.LayoutStyle.ComponentPlacement"/></returns>
            public static Javax.Swing.LayoutStyle.ComponentPlacement ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Javax.Swing.LayoutStyle.ComponentPlacement>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljavax/swing/LayoutStyle$ComponentPlacement;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.ComponentPlacement.html#values()"/>
            /// </summary>
            /// <returns><see cref="Javax.Swing.LayoutStyle.ComponentPlacement"/></returns>
            public static Javax.Swing.LayoutStyle.ComponentPlacement[] Values()
            {
                return SExecuteWithSignatureArray<Javax.Swing.LayoutStyle.ComponentPlacement>(LocalBridgeClazz, "values", "()[Ljavax/swing/LayoutStyle$ComponentPlacement;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}