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

namespace Java.Lang.ModuleNs
{
    #region Configuration definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/Configuration.html"/>
    /// </summary>
    public partial class Configuration : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Configuration>
    {
        const string _bridgeClassName = "java.lang.module.Configuration";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Configuration() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Configuration(params object[] args) : base(args) { }

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

    #region Configuration
    public partial class Configuration
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/Configuration.html#empty()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.ModuleNs.Configuration"/></returns>
        public static Java.Lang.ModuleNs.Configuration Empty()
        {
            return SExecuteWithSignature<Java.Lang.ModuleNs.Configuration>(LocalBridgeClazz, "empty", "()Ljava/lang/module/Configuration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/Configuration.html#resolve(java.lang.module.ModuleFinder,java.util.List,java.lang.module.ModuleFinder,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleFinder"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ModuleNs.ModuleFinder"/></param>
        /// <param name="arg3"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Java.Lang.ModuleNs.Configuration"/></returns>
        public static Java.Lang.ModuleNs.Configuration Resolve(Java.Lang.ModuleNs.ModuleFinder arg0, Java.Util.List<Java.Lang.ModuleNs.Configuration> arg1, Java.Lang.ModuleNs.ModuleFinder arg2, Java.Util.Collection<Java.Lang.String> arg3)
        {
            return SExecute<Java.Lang.ModuleNs.Configuration>(LocalBridgeClazz, "resolve", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/Configuration.html#resolveAndBind(java.lang.module.ModuleFinder,java.util.List,java.lang.module.ModuleFinder,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleFinder"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ModuleNs.ModuleFinder"/></param>
        /// <param name="arg3"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Java.Lang.ModuleNs.Configuration"/></returns>
        public static Java.Lang.ModuleNs.Configuration ResolveAndBind(Java.Lang.ModuleNs.ModuleFinder arg0, Java.Util.List<Java.Lang.ModuleNs.Configuration> arg1, Java.Lang.ModuleNs.ModuleFinder arg2, Java.Util.Collection<Java.Lang.String> arg3)
        {
            return SExecute<Java.Lang.ModuleNs.Configuration>(LocalBridgeClazz, "resolveAndBind", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/Configuration.html#resolve(java.lang.module.ModuleFinder,java.lang.module.ModuleFinder,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleFinder"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ModuleNs.ModuleFinder"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Java.Lang.ModuleNs.Configuration"/></returns>
        public Java.Lang.ModuleNs.Configuration Resolve(Java.Lang.ModuleNs.ModuleFinder arg0, Java.Lang.ModuleNs.ModuleFinder arg1, Java.Util.Collection<Java.Lang.String> arg2)
        {
            return IExecute<Java.Lang.ModuleNs.Configuration>("resolve", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/Configuration.html#resolveAndBind(java.lang.module.ModuleFinder,java.lang.module.ModuleFinder,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleFinder"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ModuleNs.ModuleFinder"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Java.Lang.ModuleNs.Configuration"/></returns>
        public Java.Lang.ModuleNs.Configuration ResolveAndBind(Java.Lang.ModuleNs.ModuleFinder arg0, Java.Lang.ModuleNs.ModuleFinder arg1, Java.Util.Collection<Java.Lang.String> arg2)
        {
            return IExecute<Java.Lang.ModuleNs.Configuration>("resolveAndBind", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/Configuration.html#parents()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.ModuleNs.Configuration> Parents()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.ModuleNs.Configuration>>("parents", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/Configuration.html#findModule(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Lang.ModuleNs.ResolvedModule> FindModule(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Lang.ModuleNs.ResolvedModule>>("findModule", "(Ljava/lang/String;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/Configuration.html#modules()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.ModuleNs.ResolvedModule> Modules()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.ModuleNs.ResolvedModule>>("modules", "()Ljava/util/Set;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}