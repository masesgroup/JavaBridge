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

namespace Java.Util
{
    #region FormattableFlags definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/FormattableFlags.html"/>
    /// </summary>
    public partial class FormattableFlags : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FormattableFlags>
    {
        const string _bridgeClassName = "java.util.FormattableFlags";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FormattableFlags() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public FormattableFlags(params object[] args) : base(args) { }

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

    #region FormattableFlags
    public partial class FormattableFlags
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/FormattableFlags.html#ALTERNATE"/>
        /// </summary>
        public static int ALTERNATE { get { if (!_ALTERNATEReady) { _ALTERNATEContent = SGetField<int>(LocalBridgeClazz, "ALTERNATE"); _ALTERNATEReady = true; } return _ALTERNATEContent; } }
        private static int _ALTERNATEContent = default;
        private static bool _ALTERNATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/FormattableFlags.html#LEFT_JUSTIFY"/>
        /// </summary>
        public static int LEFT_JUSTIFY { get { if (!_LEFT_JUSTIFYReady) { _LEFT_JUSTIFYContent = SGetField<int>(LocalBridgeClazz, "LEFT_JUSTIFY"); _LEFT_JUSTIFYReady = true; } return _LEFT_JUSTIFYContent; } }
        private static int _LEFT_JUSTIFYContent = default;
        private static bool _LEFT_JUSTIFYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/FormattableFlags.html#UPPERCASE"/>
        /// </summary>
        public static int UPPERCASE { get { if (!_UPPERCASEReady) { _UPPERCASEContent = SGetField<int>(LocalBridgeClazz, "UPPERCASE"); _UPPERCASEReady = true; } return _UPPERCASEContent; } }
        private static int _UPPERCASEContent = default;
        private static bool _UPPERCASEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}