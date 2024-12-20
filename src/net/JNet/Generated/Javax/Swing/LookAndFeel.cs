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
    #region LookAndFeel declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html"/>
    /// </summary>
    public partial class LookAndFeel : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LookAndFeel>
    {
        const string _bridgeClassName = "javax.swing.LookAndFeel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("LookAndFeel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public LookAndFeel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("LookAndFeel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public LookAndFeel(params object[] args) : base(args) { }

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

    }
    #endregion

    #region LookAndFeel implementation
    public partial class LookAndFeel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getDesktopPropertyValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public static object GetDesktopPropertyValue(Java.Lang.String arg0, object arg1)
        {
            return SExecuteWithSignature(LocalBridgeClazz, "getDesktopPropertyValue", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#makeIcon(java.lang.Class,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public static object MakeIcon(Java.Lang.Class arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature(LocalBridgeClazz, "makeIcon", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#makeComponentInputMap(javax.swing.JComponent,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Javax.Swing.ComponentInputMap"/></returns>
        public static Javax.Swing.ComponentInputMap MakeComponentInputMap(Javax.Swing.JComponent arg0, object[] arg1)
        {
            return SExecuteWithSignature<Javax.Swing.ComponentInputMap>(LocalBridgeClazz, "makeComponentInputMap", "(Ljavax/swing/JComponent;[Ljava/lang/Object;)Ljavax/swing/ComponentInputMap;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#makeInputMap(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Swing.InputMap"/></returns>
        public static Javax.Swing.InputMap MakeInputMap(object[] arg0)
        {
            return SExecuteWithSignature<Javax.Swing.InputMap>(LocalBridgeClazz, "makeInputMap", "([Ljava/lang/Object;)Ljavax/swing/InputMap;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#makeKeyBindings(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Swing.Text.JTextComponent.KeyBinding"/></returns>
        public static Javax.Swing.Text.JTextComponent.KeyBinding[] MakeKeyBindings(object[] arg0)
        {
            return SExecuteWithSignatureArray<Javax.Swing.Text.JTextComponent.KeyBinding>(LocalBridgeClazz, "makeKeyBindings", "([Ljava/lang/Object;)[Ljavax/swing/text/JTextComponent$KeyBinding;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#installBorder(javax.swing.JComponent,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public static void InstallBorder(Javax.Swing.JComponent arg0, Java.Lang.String arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "installBorder", "(Ljavax/swing/JComponent;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#installColors(javax.swing.JComponent,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public static void InstallColors(Javax.Swing.JComponent arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            SExecuteWithSignature(LocalBridgeClazz, "installColors", "(Ljavax/swing/JComponent;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#installColorsAndFont(javax.swing.JComponent,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        public static void InstallColorsAndFont(Javax.Swing.JComponent arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3)
        {
            SExecuteWithSignature(LocalBridgeClazz, "installColorsAndFont", "(Ljavax/swing/JComponent;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#installProperty(javax.swing.JComponent,java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public static void InstallProperty(Javax.Swing.JComponent arg0, Java.Lang.String arg1, object arg2)
        {
            SExecuteWithSignature(LocalBridgeClazz, "installProperty", "(Ljavax/swing/JComponent;Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#loadKeyBindings(javax.swing.InputMap,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.InputMap"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public static void LoadKeyBindings(Javax.Swing.InputMap arg0, object[] arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "loadKeyBindings", "(Ljavax/swing/InputMap;[Ljava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#uninstallBorder(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        public static void UninstallBorder(Javax.Swing.JComponent arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "uninstallBorder", "(Ljavax/swing/JComponent;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getDefaults()"/> 
        /// </summary>
        public Javax.Swing.UIDefaults Defaults
        {
            get { return IExecuteWithSignature<Javax.Swing.UIDefaults>("getDefaults", "()Ljavax/swing/UIDefaults;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getDescription()"/> 
        /// </summary>
        public Java.Lang.String Description
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getID()"/> 
        /// </summary>
        public Java.Lang.String ID
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getID", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getLayoutStyle()"/> 
        /// </summary>
        public Javax.Swing.LayoutStyle LayoutStyle
        {
            get { return IExecuteWithSignature<Javax.Swing.LayoutStyle>("getLayoutStyle", "()Ljavax/swing/LayoutStyle;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getSupportsWindowDecorations()"/> 
        /// </summary>
        public bool SupportsWindowDecorations
        {
            get { return IExecuteWithSignature<bool>("getSupportsWindowDecorations", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#isNativeLookAndFeel()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNativeLookAndFeel()
        {
            return IExecuteWithSignature<bool>("isNativeLookAndFeel", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#isSupportedLookAndFeel()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupportedLookAndFeel()
        {
            return IExecuteWithSignature<bool>("isSupportedLookAndFeel", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getDisabledIcon(javax.swing.JComponent,javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Icon"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public Javax.Swing.Icon GetDisabledIcon(Javax.Swing.JComponent arg0, Javax.Swing.Icon arg1)
        {
            return IExecuteWithSignature<Javax.Swing.Icon>("getDisabledIcon", "(Ljavax/swing/JComponent;Ljavax/swing/Icon;)Ljavax/swing/Icon;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getDisabledSelectedIcon(javax.swing.JComponent,javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Icon"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public Javax.Swing.Icon GetDisabledSelectedIcon(Javax.Swing.JComponent arg0, Javax.Swing.Icon arg1)
        {
            return IExecuteWithSignature<Javax.Swing.Icon>("getDisabledSelectedIcon", "(Ljavax/swing/JComponent;Ljavax/swing/Icon;)Ljavax/swing/Icon;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#initialize()"/>
        /// </summary>
        public void Initialize()
        {
            IExecuteWithSignature("initialize", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#provideErrorFeedback(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void ProvideErrorFeedback(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("provideErrorFeedback", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#uninitialize()"/>
        /// </summary>
        public void Uninitialize()
        {
            IExecuteWithSignature("uninitialize", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}