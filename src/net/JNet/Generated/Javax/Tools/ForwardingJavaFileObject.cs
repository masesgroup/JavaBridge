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

namespace Javax.Tools
{
    #region ForwardingJavaFileObject declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileObject.html"/>
    /// </summary>
    public partial class ForwardingJavaFileObject : Javax.Tools.ForwardingFileObject
    {
        const string _bridgeClassName = "javax.tools.ForwardingJavaFileObject";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ForwardingJavaFileObject() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ForwardingJavaFileObject(params object[] args) : base(args) { }

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

    #region ForwardingJavaFileObject<F> declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileObject.html"/>
    /// </summary>
    /// <typeparam name="F"><see cref="Javax.Tools.IJavaFileObject"/></typeparam>
    public partial class ForwardingJavaFileObject<F> : Javax.Tools.ForwardingFileObject<F> where F : Javax.Tools.IJavaFileObject, new()
    {
        const string _bridgeClassName = "javax.tools.ForwardingJavaFileObject";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ForwardingJavaFileObject() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ForwardingJavaFileObject(params object[] args) : base(args) { }

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

    #region ForwardingJavaFileObject implementation
    public partial class ForwardingJavaFileObject
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Tools.ForwardingJavaFileObject"/> to <see cref="Javax.Tools.JavaFileObject"/>
        /// </summary>
        public static implicit operator Javax.Tools.JavaFileObject(Javax.Tools.ForwardingJavaFileObject t) => t.Cast<Javax.Tools.JavaFileObject>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileObject.html#getAccessLevel()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Modifier AccessLevel
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Element.Modifier>("getAccessLevel", "()Ljavax/lang/model/element/Modifier;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileObject.html#getKind()"/> 
        /// </summary>
        public Javax.Tools.JavaFileObject.Kind Kind
        {
            get { return IExecuteWithSignature<Javax.Tools.JavaFileObject.Kind>("getKind", "()Ljavax/tools/JavaFileObject$Kind;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileObject.html#getNestingKind()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.NestingKind NestingKind
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Element.NestingKind>("getNestingKind", "()Ljavax/lang/model/element/NestingKind;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileObject.html#isNameCompatible(java.lang.String,javax.tools.JavaFileObject.Kind)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNameCompatible(Java.Lang.String arg0, Javax.Tools.JavaFileObject.Kind arg1)
        {
            return IExecuteWithSignature<bool>("isNameCompatible", "(Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Z", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ForwardingJavaFileObject<F> implementation
    public partial class ForwardingJavaFileObject<F>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Tools.ForwardingJavaFileObject{F}"/> to <see cref="Javax.Tools.JavaFileObject"/>
        /// </summary>
        public static implicit operator Javax.Tools.JavaFileObject(Javax.Tools.ForwardingJavaFileObject<F> t) => t.Cast<Javax.Tools.JavaFileObject>();
        /// <summary>
        /// Converter from <see cref="Javax.Tools.ForwardingJavaFileObject{F}"/> to <see cref="Javax.Tools.ForwardingJavaFileObject"/>
        /// </summary>
        public static implicit operator Javax.Tools.ForwardingJavaFileObject(Javax.Tools.ForwardingJavaFileObject<F> t) => t.Cast<Javax.Tools.ForwardingJavaFileObject>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileObject.html#getAccessLevel()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Modifier AccessLevel
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Element.Modifier>("getAccessLevel", "()Ljavax/lang/model/element/Modifier;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileObject.html#getKind()"/> 
        /// </summary>
        public Javax.Tools.JavaFileObject.Kind Kind
        {
            get { return IExecuteWithSignature<Javax.Tools.JavaFileObject.Kind>("getKind", "()Ljavax/tools/JavaFileObject$Kind;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileObject.html#getNestingKind()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.NestingKind NestingKind
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Element.NestingKind>("getNestingKind", "()Ljavax/lang/model/element/NestingKind;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileObject.html#isNameCompatible(java.lang.String,javax.tools.JavaFileObject.Kind)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNameCompatible(Java.Lang.String arg0, Javax.Tools.JavaFileObject.Kind arg1)
        {
            return IExecuteWithSignature<bool>("isNameCompatible", "(Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Z", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}