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

namespace Javax.Print.Attribute.Standard
{
    #region SheetCollate definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/SheetCollate.html"/>
    /// </summary>
    public partial class SheetCollate : Javax.Print.Attribute.EnumSyntax
    {
        const string _bridgeClassName = "javax.print.attribute.standard.SheetCollate";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SheetCollate() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SheetCollate(params object[] args) : base(args) { }

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

    #region SheetCollate
    public partial class SheetCollate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.SheetCollate"/> to <see cref="Javax.Print.Attribute.DocAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.DocAttribute(Javax.Print.Attribute.Standard.SheetCollate t) => t.Cast<Javax.Print.Attribute.DocAttribute>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.SheetCollate"/> to <see cref="Javax.Print.Attribute.PrintRequestAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintRequestAttribute(Javax.Print.Attribute.Standard.SheetCollate t) => t.Cast<Javax.Print.Attribute.PrintRequestAttribute>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.SheetCollate"/> to <see cref="Javax.Print.Attribute.PrintJobAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintJobAttribute(Javax.Print.Attribute.Standard.SheetCollate t) => t.Cast<Javax.Print.Attribute.PrintJobAttribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/SheetCollate.html#COLLATED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.SheetCollate COLLATED { get { if (!_COLLATEDReady) { _COLLATEDContent = SGetField<Javax.Print.Attribute.Standard.SheetCollate>(LocalBridgeClazz, "COLLATED"); _COLLATEDReady = true; } return _COLLATEDContent; } }
        private static Javax.Print.Attribute.Standard.SheetCollate _COLLATEDContent = default;
        private static bool _COLLATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/SheetCollate.html#UNCOLLATED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.SheetCollate UNCOLLATED { get { if (!_UNCOLLATEDReady) { _UNCOLLATEDContent = SGetField<Javax.Print.Attribute.Standard.SheetCollate>(LocalBridgeClazz, "UNCOLLATED"); _UNCOLLATEDReady = true; } return _UNCOLLATEDContent; } }
        private static Javax.Print.Attribute.Standard.SheetCollate _UNCOLLATEDContent = default;
        private static bool _UNCOLLATEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/SheetCollate.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getCategory", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/SheetCollate.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}