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

namespace Javax.Print.Attribute.Standard
{
    #region Sides declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Sides.html"/>
    /// </summary>
    public partial class Sides : Javax.Print.Attribute.EnumSyntax
    {
        const string _bridgeClassName = "javax.print.attribute.standard.Sides";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Sides() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Sides(params object[] args) : base(args) { }

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

    #region Sides implementation
    public partial class Sides
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.Sides"/> to <see cref="Javax.Print.Attribute.DocAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.DocAttribute(Javax.Print.Attribute.Standard.Sides t) => t.Cast<Javax.Print.Attribute.DocAttribute>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.Sides"/> to <see cref="Javax.Print.Attribute.PrintRequestAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintRequestAttribute(Javax.Print.Attribute.Standard.Sides t) => t.Cast<Javax.Print.Attribute.PrintRequestAttribute>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.Sides"/> to <see cref="Javax.Print.Attribute.PrintJobAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintJobAttribute(Javax.Print.Attribute.Standard.Sides t) => t.Cast<Javax.Print.Attribute.PrintJobAttribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Sides.html#DUPLEX"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Sides DUPLEX { get { if (!_DUPLEXReady) { _DUPLEXContent = SGetField<Javax.Print.Attribute.Standard.Sides>(LocalBridgeClazz, "DUPLEX"); _DUPLEXReady = true; } return _DUPLEXContent; } }
        private static Javax.Print.Attribute.Standard.Sides _DUPLEXContent = default;
        private static bool _DUPLEXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Sides.html#ONE_SIDED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Sides ONE_SIDED { get { if (!_ONE_SIDEDReady) { _ONE_SIDEDContent = SGetField<Javax.Print.Attribute.Standard.Sides>(LocalBridgeClazz, "ONE_SIDED"); _ONE_SIDEDReady = true; } return _ONE_SIDEDContent; } }
        private static Javax.Print.Attribute.Standard.Sides _ONE_SIDEDContent = default;
        private static bool _ONE_SIDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Sides.html#TUMBLE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Sides TUMBLE { get { if (!_TUMBLEReady) { _TUMBLEContent = SGetField<Javax.Print.Attribute.Standard.Sides>(LocalBridgeClazz, "TUMBLE"); _TUMBLEReady = true; } return _TUMBLEContent; } }
        private static Javax.Print.Attribute.Standard.Sides _TUMBLEContent = default;
        private static bool _TUMBLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Sides.html#TWO_SIDED_LONG_EDGE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Sides TWO_SIDED_LONG_EDGE { get { if (!_TWO_SIDED_LONG_EDGEReady) { _TWO_SIDED_LONG_EDGEContent = SGetField<Javax.Print.Attribute.Standard.Sides>(LocalBridgeClazz, "TWO_SIDED_LONG_EDGE"); _TWO_SIDED_LONG_EDGEReady = true; } return _TWO_SIDED_LONG_EDGEContent; } }
        private static Javax.Print.Attribute.Standard.Sides _TWO_SIDED_LONG_EDGEContent = default;
        private static bool _TWO_SIDED_LONG_EDGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Sides.html#TWO_SIDED_SHORT_EDGE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.Sides TWO_SIDED_SHORT_EDGE { get { if (!_TWO_SIDED_SHORT_EDGEReady) { _TWO_SIDED_SHORT_EDGEContent = SGetField<Javax.Print.Attribute.Standard.Sides>(LocalBridgeClazz, "TWO_SIDED_SHORT_EDGE"); _TWO_SIDED_SHORT_EDGEReady = true; } return _TWO_SIDED_SHORT_EDGEContent; } }
        private static Javax.Print.Attribute.Standard.Sides _TWO_SIDED_SHORT_EDGEContent = default;
        private static bool _TWO_SIDED_SHORT_EDGEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Sides.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getCategory", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/Sides.html#getName()"/> 
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