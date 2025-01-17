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

namespace Javax.Naming.Spi
{
    #region DirStateFactory declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirStateFactory.html"/>
    /// </summary>
    public partial class DirStateFactory : Javax.Naming.Spi.StateFactory
    {
        const string _bridgeClassName = "javax.naming.spi.DirStateFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("DirStateFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DirStateFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("DirStateFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DirStateFactory(params object[] args) : base(args) { }

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
        #region Result declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirStateFactory.Result.html"/>
        /// </summary>
        public partial class Result : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Result>
        {
            const string _bridgeClassName = "javax.naming.spi.DirStateFactory$Result";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Result() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Result(params object[] args) : base(args) { }

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

    #region IDirStateFactory
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDirStateFactory : Javax.Naming.Spi.IStateFactory
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirStateFactory.html#getStateToBind(java.lang.Object,javax.naming.Name,javax.naming.Context,java.util.Hashtable,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Context"/></param>
        /// <param name="arg3"><see cref="Java.Util.Hashtable"/></param>
        /// <param name="arg4"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <returns><see cref="Javax.Naming.Spi.DirStateFactory.Result"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Spi.DirStateFactory.Result GetStateToBind(object arg0, Javax.Naming.Name arg1, Javax.Naming.Context arg2, Java.Util.Hashtable<object, object> arg3, Javax.Naming.Directory.Attributes arg4);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DirStateFactory implementation
    public partial class DirStateFactory : Javax.Naming.Spi.IDirStateFactory
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirStateFactory.html#getStateToBind(java.lang.Object,javax.naming.Name,javax.naming.Context,java.util.Hashtable,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Context"/></param>
        /// <param name="arg3"><see cref="Java.Util.Hashtable"/></param>
        /// <param name="arg4"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <returns><see cref="Javax.Naming.Spi.DirStateFactory.Result"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Spi.DirStateFactory.Result GetStateToBind(object arg0, Javax.Naming.Name arg1, Javax.Naming.Context arg2, Java.Util.Hashtable<object, object> arg3, Javax.Naming.Directory.Attributes arg4)
        {
            return IExecuteWithSignature<Javax.Naming.Spi.DirStateFactory.Result>("getStateToBind", "(Ljava/lang/Object;Ljavax/naming/Name;Ljavax/naming/Context;Ljava/util/Hashtable;Ljavax/naming/directory/Attributes;)Ljavax/naming/spi/DirStateFactory$Result;", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes
        #region Result implementation
        public partial class Result
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirStateFactory.Result.html#%3Cinit%3E(java.lang.Object,javax.naming.directory.Attributes)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <param name="arg1"><see cref="Javax.Naming.Directory.Attributes"/></param>
            public Result(object arg0, Javax.Naming.Directory.Attributes arg1)
                : base(arg0, arg1)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirStateFactory.Result.html#getAttributes()"/> 
            /// </summary>
            public Javax.Naming.Directory.Attributes Attributes
            {
                get { return IExecuteWithSignature<Javax.Naming.Directory.Attributes>("getAttributes", "()Ljavax/naming/directory/Attributes;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirStateFactory.Result.html#getObject()"/> 
            /// </summary>
            public object Object
            {
                get { return IExecuteWithSignature("getObject", "()Ljava/lang/Object;"); }
            }

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