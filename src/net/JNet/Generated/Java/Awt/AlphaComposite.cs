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
    #region AlphaComposite declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html"/>
    /// </summary>
    public partial class AlphaComposite : Java.Awt.Composite
    {
        const string _bridgeClassName = "java.awt.AlphaComposite";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AlphaComposite() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AlphaComposite(params object[] args) : base(args) { }

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

    #region AlphaComposite implementation
    public partial class AlphaComposite
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#CLEAR"/>
        /// </summary>
        public static int CLEAR { get { if (!_CLEARReady) { _CLEARContent = SGetField<int>(LocalBridgeClazz, "CLEAR"); _CLEARReady = true; } return _CLEARContent; } }
        private static int _CLEARContent = default;
        private static bool _CLEARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DST"/>
        /// </summary>
        public static int DST { get { if (!_DSTReady) { _DSTContent = SGetField<int>(LocalBridgeClazz, "DST"); _DSTReady = true; } return _DSTContent; } }
        private static int _DSTContent = default;
        private static bool _DSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DST_ATOP"/>
        /// </summary>
        public static int DST_ATOP { get { if (!_DST_ATOPReady) { _DST_ATOPContent = SGetField<int>(LocalBridgeClazz, "DST_ATOP"); _DST_ATOPReady = true; } return _DST_ATOPContent; } }
        private static int _DST_ATOPContent = default;
        private static bool _DST_ATOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DST_IN"/>
        /// </summary>
        public static int DST_IN { get { if (!_DST_INReady) { _DST_INContent = SGetField<int>(LocalBridgeClazz, "DST_IN"); _DST_INReady = true; } return _DST_INContent; } }
        private static int _DST_INContent = default;
        private static bool _DST_INReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DST_OUT"/>
        /// </summary>
        public static int DST_OUT { get { if (!_DST_OUTReady) { _DST_OUTContent = SGetField<int>(LocalBridgeClazz, "DST_OUT"); _DST_OUTReady = true; } return _DST_OUTContent; } }
        private static int _DST_OUTContent = default;
        private static bool _DST_OUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DST_OVER"/>
        /// </summary>
        public static int DST_OVER { get { if (!_DST_OVERReady) { _DST_OVERContent = SGetField<int>(LocalBridgeClazz, "DST_OVER"); _DST_OVERReady = true; } return _DST_OVERContent; } }
        private static int _DST_OVERContent = default;
        private static bool _DST_OVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SRC"/>
        /// </summary>
        public static int SRC { get { if (!_SRCReady) { _SRCContent = SGetField<int>(LocalBridgeClazz, "SRC"); _SRCReady = true; } return _SRCContent; } }
        private static int _SRCContent = default;
        private static bool _SRCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SRC_ATOP"/>
        /// </summary>
        public static int SRC_ATOP { get { if (!_SRC_ATOPReady) { _SRC_ATOPContent = SGetField<int>(LocalBridgeClazz, "SRC_ATOP"); _SRC_ATOPReady = true; } return _SRC_ATOPContent; } }
        private static int _SRC_ATOPContent = default;
        private static bool _SRC_ATOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SRC_IN"/>
        /// </summary>
        public static int SRC_IN { get { if (!_SRC_INReady) { _SRC_INContent = SGetField<int>(LocalBridgeClazz, "SRC_IN"); _SRC_INReady = true; } return _SRC_INContent; } }
        private static int _SRC_INContent = default;
        private static bool _SRC_INReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SRC_OUT"/>
        /// </summary>
        public static int SRC_OUT { get { if (!_SRC_OUTReady) { _SRC_OUTContent = SGetField<int>(LocalBridgeClazz, "SRC_OUT"); _SRC_OUTReady = true; } return _SRC_OUTContent; } }
        private static int _SRC_OUTContent = default;
        private static bool _SRC_OUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SRC_OVER"/>
        /// </summary>
        public static int SRC_OVER { get { if (!_SRC_OVERReady) { _SRC_OVERContent = SGetField<int>(LocalBridgeClazz, "SRC_OVER"); _SRC_OVERReady = true; } return _SRC_OVERContent; } }
        private static int _SRC_OVERContent = default;
        private static bool _SRC_OVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#XOR"/>
        /// </summary>
        public static int XOR { get { if (!_XORReady) { _XORContent = SGetField<int>(LocalBridgeClazz, "XOR"); _XORReady = true; } return _XORContent; } }
        private static int _XORContent = default;
        private static bool _XORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#Clear"/>
        /// </summary>
        public static Java.Awt.AlphaComposite Clear { get { if (!_ClearReady) { _ClearContent = SGetField<Java.Awt.AlphaComposite>(LocalBridgeClazz, "Clear"); _ClearReady = true; } return _ClearContent; } }
        private static Java.Awt.AlphaComposite _ClearContent = default;
        private static bool _ClearReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#Dst"/>
        /// </summary>
        public static Java.Awt.AlphaComposite Dst { get { if (!_DstReady) { _DstContent = SGetField<Java.Awt.AlphaComposite>(LocalBridgeClazz, "Dst"); _DstReady = true; } return _DstContent; } }
        private static Java.Awt.AlphaComposite _DstContent = default;
        private static bool _DstReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DstAtop"/>
        /// </summary>
        public static Java.Awt.AlphaComposite DstAtop { get { if (!_DstAtopReady) { _DstAtopContent = SGetField<Java.Awt.AlphaComposite>(LocalBridgeClazz, "DstAtop"); _DstAtopReady = true; } return _DstAtopContent; } }
        private static Java.Awt.AlphaComposite _DstAtopContent = default;
        private static bool _DstAtopReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DstIn"/>
        /// </summary>
        public static Java.Awt.AlphaComposite DstIn { get { if (!_DstInReady) { _DstInContent = SGetField<Java.Awt.AlphaComposite>(LocalBridgeClazz, "DstIn"); _DstInReady = true; } return _DstInContent; } }
        private static Java.Awt.AlphaComposite _DstInContent = default;
        private static bool _DstInReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DstOut"/>
        /// </summary>
        public static Java.Awt.AlphaComposite DstOut { get { if (!_DstOutReady) { _DstOutContent = SGetField<Java.Awt.AlphaComposite>(LocalBridgeClazz, "DstOut"); _DstOutReady = true; } return _DstOutContent; } }
        private static Java.Awt.AlphaComposite _DstOutContent = default;
        private static bool _DstOutReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DstOver"/>
        /// </summary>
        public static Java.Awt.AlphaComposite DstOver { get { if (!_DstOverReady) { _DstOverContent = SGetField<Java.Awt.AlphaComposite>(LocalBridgeClazz, "DstOver"); _DstOverReady = true; } return _DstOverContent; } }
        private static Java.Awt.AlphaComposite _DstOverContent = default;
        private static bool _DstOverReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#Src"/>
        /// </summary>
        public static Java.Awt.AlphaComposite Src { get { if (!_SrcReady) { _SrcContent = SGetField<Java.Awt.AlphaComposite>(LocalBridgeClazz, "Src"); _SrcReady = true; } return _SrcContent; } }
        private static Java.Awt.AlphaComposite _SrcContent = default;
        private static bool _SrcReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SrcAtop"/>
        /// </summary>
        public static Java.Awt.AlphaComposite SrcAtop { get { if (!_SrcAtopReady) { _SrcAtopContent = SGetField<Java.Awt.AlphaComposite>(LocalBridgeClazz, "SrcAtop"); _SrcAtopReady = true; } return _SrcAtopContent; } }
        private static Java.Awt.AlphaComposite _SrcAtopContent = default;
        private static bool _SrcAtopReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SrcIn"/>
        /// </summary>
        public static Java.Awt.AlphaComposite SrcIn { get { if (!_SrcInReady) { _SrcInContent = SGetField<Java.Awt.AlphaComposite>(LocalBridgeClazz, "SrcIn"); _SrcInReady = true; } return _SrcInContent; } }
        private static Java.Awt.AlphaComposite _SrcInContent = default;
        private static bool _SrcInReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SrcOut"/>
        /// </summary>
        public static Java.Awt.AlphaComposite SrcOut { get { if (!_SrcOutReady) { _SrcOutContent = SGetField<Java.Awt.AlphaComposite>(LocalBridgeClazz, "SrcOut"); _SrcOutReady = true; } return _SrcOutContent; } }
        private static Java.Awt.AlphaComposite _SrcOutContent = default;
        private static bool _SrcOutReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SrcOver"/>
        /// </summary>
        public static Java.Awt.AlphaComposite SrcOver { get { if (!_SrcOverReady) { _SrcOverContent = SGetField<Java.Awt.AlphaComposite>(LocalBridgeClazz, "SrcOver"); _SrcOverReady = true; } return _SrcOverContent; } }
        private static Java.Awt.AlphaComposite _SrcOverContent = default;
        private static bool _SrcOverReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#Xor"/>
        /// </summary>
        public static Java.Awt.AlphaComposite Xor { get { if (!_XorReady) { _XorContent = SGetField<Java.Awt.AlphaComposite>(LocalBridgeClazz, "Xor"); _XorReady = true; } return _XorContent; } }
        private static Java.Awt.AlphaComposite _XorContent = default;
        private static bool _XorReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#getInstance(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.AlphaComposite"/></returns>
        public static Java.Awt.AlphaComposite GetInstance(int arg0, float arg1)
        {
            return SExecuteWithSignature<Java.Awt.AlphaComposite>(LocalBridgeClazz, "getInstance", "(IF)Ljava/awt/AlphaComposite;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#getInstance(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.AlphaComposite"/></returns>
        public static Java.Awt.AlphaComposite GetInstance(int arg0)
        {
            return SExecuteWithSignature<Java.Awt.AlphaComposite>(LocalBridgeClazz, "getInstance", "(I)Ljava/awt/AlphaComposite;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#getAlpha()"/> 
        /// </summary>
        public float Alpha
        {
            get { return IExecuteWithSignature<float>("getAlpha", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#getRule()"/> 
        /// </summary>
        public int Rule
        {
            get { return IExecuteWithSignature<int>("getRule", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#derive(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.AlphaComposite"/></returns>
        public Java.Awt.AlphaComposite Derive(float arg0)
        {
            return IExecuteWithSignature<Java.Awt.AlphaComposite>("derive", "(F)Ljava/awt/AlphaComposite;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#derive(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.AlphaComposite"/></returns>
        public Java.Awt.AlphaComposite Derive(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.AlphaComposite>("derive", "(I)Ljava/awt/AlphaComposite;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#createContext(java.awt.image.ColorModel,java.awt.image.ColorModel,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg2"><see cref="Java.Awt.RenderingHints"/></param>
        /// <returns><see cref="Java.Awt.CompositeContext"/></returns>
        public Java.Awt.CompositeContext CreateContext(Java.Awt.ImageNs.ColorModel arg0, Java.Awt.ImageNs.ColorModel arg1, Java.Awt.RenderingHints arg2)
        {
            return IExecuteWithSignature<Java.Awt.CompositeContext>("createContext", "(Ljava/awt/image/ColorModel;Ljava/awt/image/ColorModel;Ljava/awt/RenderingHints;)Ljava/awt/CompositeContext;", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}