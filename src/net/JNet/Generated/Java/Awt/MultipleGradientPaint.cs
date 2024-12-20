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

namespace Java.Awt
{
    #region MultipleGradientPaint declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.html"/>
    /// </summary>
    public partial class MultipleGradientPaint : Java.Awt.Paint
    {
        const string _bridgeClassName = "java.awt.MultipleGradientPaint";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("MultipleGradientPaint class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MultipleGradientPaint() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("MultipleGradientPaint class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MultipleGradientPaint(params object[] args) : base(args) { }

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
        #region ColorSpaceType declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.ColorSpaceType.html"/>
        /// </summary>
        public partial class ColorSpaceType : Java.Lang.Enum<Java.Awt.MultipleGradientPaint.ColorSpaceType>
        {
            const string _bridgeClassName = "java.awt.MultipleGradientPaint$ColorSpaceType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ColorSpaceType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ColorSpaceType(params object[] args) : base(args) { }

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

        #region CycleMethod declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.CycleMethod.html"/>
        /// </summary>
        public partial class CycleMethod : Java.Lang.Enum<Java.Awt.MultipleGradientPaint.CycleMethod>
        {
            const string _bridgeClassName = "java.awt.MultipleGradientPaint$CycleMethod";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public CycleMethod() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public CycleMethod(params object[] args) : base(args) { }

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

    #region MultipleGradientPaint implementation
    public partial class MultipleGradientPaint
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.html#getColors()"/> 
        /// </summary>
        public Java.Awt.Color[] Colors
        {
            get { return IExecuteWithSignatureArray<Java.Awt.Color>("getColors", "()[Ljava/awt/Color;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.html#getColorSpace()"/> 
        /// </summary>
        public Java.Awt.MultipleGradientPaint.ColorSpaceType ColorSpace
        {
            get { return IExecuteWithSignature<Java.Awt.MultipleGradientPaint.ColorSpaceType>("getColorSpace", "()Ljava/awt/MultipleGradientPaint$ColorSpaceType;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.html#getFractions()"/> 
        /// </summary>
        public float[] Fractions
        {
            get { return IExecuteWithSignatureArray<float>("getFractions", "()[F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.html#getCycleMethod()"/> 
        /// </summary>
        public Java.Awt.MultipleGradientPaint.CycleMethod GetCycleMethod
        {
            get { return IExecuteWithSignature<Java.Awt.MultipleGradientPaint.CycleMethod>("getCycleMethod", "()Ljava/awt/MultipleGradientPaint$CycleMethod;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.html#getTransform()"/> 
        /// </summary>
        public Java.Awt.Geom.AffineTransform Transform
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.AffineTransform>("getTransform", "()Ljava/awt/geom/AffineTransform;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.html#getTransparency()"/> 
        /// </summary>
        public int Transparency
        {
            get { return IExecuteWithSignature<int>("getTransparency", "()I"); }
        }

        #endregion

        #region Nested classes
        #region ColorSpaceType implementation
        public partial class ColorSpaceType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.ColorSpaceType.html#LINEAR_RGB"/>
            /// </summary>
            public static Java.Awt.MultipleGradientPaint.ColorSpaceType LINEAR_RGB { get { if (!_LINEAR_RGBReady) { _LINEAR_RGBContent = SGetField<Java.Awt.MultipleGradientPaint.ColorSpaceType>(LocalBridgeClazz, "LINEAR_RGB"); _LINEAR_RGBReady = true; } return _LINEAR_RGBContent; } }
            private static Java.Awt.MultipleGradientPaint.ColorSpaceType _LINEAR_RGBContent = default;
            private static bool _LINEAR_RGBReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.ColorSpaceType.html#SRGB"/>
            /// </summary>
            public static Java.Awt.MultipleGradientPaint.ColorSpaceType SRGB { get { if (!_SRGBReady) { _SRGBContent = SGetField<Java.Awt.MultipleGradientPaint.ColorSpaceType>(LocalBridgeClazz, "SRGB"); _SRGBReady = true; } return _SRGBContent; } }
            private static Java.Awt.MultipleGradientPaint.ColorSpaceType _SRGBContent = default;
            private static bool _SRGBReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.ColorSpaceType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Awt.MultipleGradientPaint.ColorSpaceType"/></returns>
            public static Java.Awt.MultipleGradientPaint.ColorSpaceType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Awt.MultipleGradientPaint.ColorSpaceType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/awt/MultipleGradientPaint$ColorSpaceType;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.ColorSpaceType.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Awt.MultipleGradientPaint.ColorSpaceType"/></returns>
            public static Java.Awt.MultipleGradientPaint.ColorSpaceType[] Values()
            {
                return SExecuteWithSignatureArray<Java.Awt.MultipleGradientPaint.ColorSpaceType>(LocalBridgeClazz, "values", "()[Ljava/awt/MultipleGradientPaint$ColorSpaceType;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region CycleMethod implementation
        public partial class CycleMethod
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.CycleMethod.html#NO_CYCLE"/>
            /// </summary>
            public static Java.Awt.MultipleGradientPaint.CycleMethod NO_CYCLE { get { if (!_NO_CYCLEReady) { _NO_CYCLEContent = SGetField<Java.Awt.MultipleGradientPaint.CycleMethod>(LocalBridgeClazz, "NO_CYCLE"); _NO_CYCLEReady = true; } return _NO_CYCLEContent; } }
            private static Java.Awt.MultipleGradientPaint.CycleMethod _NO_CYCLEContent = default;
            private static bool _NO_CYCLEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.CycleMethod.html#REFLECT"/>
            /// </summary>
            public static Java.Awt.MultipleGradientPaint.CycleMethod REFLECT { get { if (!_REFLECTReady) { _REFLECTContent = SGetField<Java.Awt.MultipleGradientPaint.CycleMethod>(LocalBridgeClazz, "REFLECT"); _REFLECTReady = true; } return _REFLECTContent; } }
            private static Java.Awt.MultipleGradientPaint.CycleMethod _REFLECTContent = default;
            private static bool _REFLECTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.CycleMethod.html#REPEAT"/>
            /// </summary>
            public static Java.Awt.MultipleGradientPaint.CycleMethod REPEAT { get { if (!_REPEATReady) { _REPEATContent = SGetField<Java.Awt.MultipleGradientPaint.CycleMethod>(LocalBridgeClazz, "REPEAT"); _REPEATReady = true; } return _REPEATContent; } }
            private static Java.Awt.MultipleGradientPaint.CycleMethod _REPEATContent = default;
            private static bool _REPEATReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.CycleMethod.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Awt.MultipleGradientPaint.CycleMethod"/></returns>
            public static Java.Awt.MultipleGradientPaint.CycleMethod ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Awt.MultipleGradientPaint.CycleMethod>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/awt/MultipleGradientPaint$CycleMethod;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.CycleMethod.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Awt.MultipleGradientPaint.CycleMethod"/></returns>
            public static Java.Awt.MultipleGradientPaint.CycleMethod[] Values()
            {
                return SExecuteWithSignatureArray<Java.Awt.MultipleGradientPaint.CycleMethod>(LocalBridgeClazz, "values", "()[Ljava/awt/MultipleGradientPaint$CycleMethod;");
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