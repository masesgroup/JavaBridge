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

namespace Java.Awt.Im.Spi
{
    #region InputMethod definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html"/>
    /// </summary>
    public partial class InputMethod : MASES.JCOBridge.C2JBridge.JVMBridgeBase<InputMethod>
    {
        const string _bridgeClassName = "java.awt.im.spi.InputMethod";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("InputMethod class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InputMethod() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("InputMethod class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InputMethod(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region IInputMethod
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IInputMethod
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#getControlObject()"/> 
        /// </summary>
        object ControlObject { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#getLocale()"/> 
        /// </summary>
        Java.Util.Locale Locale { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#isCompositionEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsCompositionEnabled();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#setLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="bool"/></returns>
        bool SetLocale(Java.Util.Locale arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#activate()"/>
        /// </summary>
        void Activate();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#deactivate(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void Deactivate(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#dispatchEvent(java.awt.AWTEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.AWTEvent"/></param>
        void DispatchEvent(Java.Awt.AWTEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#dispose()"/>
        /// </summary>
        void Dispose();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#endComposition()"/>
        /// </summary>
        void EndComposition();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#hideWindows()"/>
        /// </summary>
        void HideWindows();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#notifyClientWindowChange(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        void NotifyClientWindowChange(Java.Awt.Rectangle arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#reconvert()"/>
        /// </summary>
        void Reconvert();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#removeNotify()"/>
        /// </summary>
        void RemoveNotify();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#setCharacterSubsets(java.lang.Character.Subset[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Character.Subset"/></param>
        void SetCharacterSubsets(Java.Lang.Character.Subset[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#setCompositionEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetCompositionEnabled(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#setInputMethodContext(java.awt.im.spi.InputMethodContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Im.Spi.InputMethodContext"/></param>
        void SetInputMethodContext(Java.Awt.Im.Spi.InputMethodContext arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region InputMethod
    public partial class InputMethod : Java.Awt.Im.Spi.IInputMethod
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#getControlObject()"/> 
        /// </summary>
        public object ControlObject
        {
            get { return IExecuteWithSignature("getControlObject", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#getLocale()"/> 
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#isCompositionEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompositionEnabled()
        {
            return IExecuteWithSignature<bool>("isCompositionEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#setLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetLocale(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<bool>("setLocale", "(Ljava/util/Locale;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#activate()"/>
        /// </summary>
        public void Activate()
        {
            IExecuteWithSignature("activate", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#deactivate(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void Deactivate(bool arg0)
        {
            IExecuteWithSignature("deactivate", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#dispatchEvent(java.awt.AWTEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.AWTEvent"/></param>
        public void DispatchEvent(Java.Awt.AWTEvent arg0)
        {
            IExecuteWithSignature("dispatchEvent", "(Ljava/awt/AWTEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#dispose()"/>
        /// </summary>
        public new void Dispose()
        {
            IExecuteWithSignature("dispose", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#endComposition()"/>
        /// </summary>
        public void EndComposition()
        {
            IExecuteWithSignature("endComposition", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#hideWindows()"/>
        /// </summary>
        public void HideWindows()
        {
            IExecuteWithSignature("hideWindows", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#notifyClientWindowChange(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        public void NotifyClientWindowChange(Java.Awt.Rectangle arg0)
        {
            IExecuteWithSignature("notifyClientWindowChange", "(Ljava/awt/Rectangle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#reconvert()"/>
        /// </summary>
        public void Reconvert()
        {
            IExecuteWithSignature("reconvert", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#removeNotify()"/>
        /// </summary>
        public void RemoveNotify()
        {
            IExecuteWithSignature("removeNotify", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#setCharacterSubsets(java.lang.Character.Subset[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Character.Subset"/></param>
        public void SetCharacterSubsets(Java.Lang.Character.Subset[] arg0)
        {
            IExecuteWithSignature("setCharacterSubsets", "([Ljava/lang/Character$Subset;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#setCompositionEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCompositionEnabled(bool arg0)
        {
            IExecuteWithSignature("setCompositionEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#setInputMethodContext(java.awt.im.spi.InputMethodContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Im.Spi.InputMethodContext"/></param>
        public void SetInputMethodContext(Java.Awt.Im.Spi.InputMethodContext arg0)
        {
            IExecuteWithSignature("setInputMethodContext", "(Ljava/awt/im/spi/InputMethodContext;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}