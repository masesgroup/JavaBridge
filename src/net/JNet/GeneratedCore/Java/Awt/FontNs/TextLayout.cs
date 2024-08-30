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

namespace Java.Awt.FontNs
{
    #region TextLayout definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html"/>
    /// </summary>
    public partial class TextLayout : Java.Lang.Cloneable
    {
        const string _bridgeClassName = "java.awt.font.TextLayout";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TextLayout() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TextLayout(params object[] args) : base(args) { }

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
        #region CaretPolicy definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.CaretPolicy.html"/>
        /// </summary>
        public partial class CaretPolicy : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CaretPolicy>
        {
            const string _bridgeClassName = "java.awt.font.TextLayout$CaretPolicy";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public CaretPolicy() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public CaretPolicy(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region TextLayout
    public partial class TextLayout
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#%3Cinit%3E(java.lang.String,java.awt.Font,java.awt.font.FontRenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Font"/></param>
        /// <param name="arg2"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        public TextLayout(Java.Lang.String arg0, Java.Awt.Font arg1, Java.Awt.FontNs.FontRenderContext arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#%3Cinit%3E(java.lang.String,java.util.Map,java.awt.font.FontRenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        public TextLayout(Java.Lang.String arg0, Java.Util.Map arg1, Java.Awt.FontNs.FontRenderContext arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#%3Cinit%3E(java.text.AttributedCharacterIterator,java.awt.font.FontRenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        public TextLayout(Java.Text.AttributedCharacterIterator arg0, Java.Awt.FontNs.FontRenderContext arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#DEFAULT_CARET_POLICY"/>
        /// </summary>
        public static Java.Awt.FontNs.TextLayout.CaretPolicy DEFAULT_CARET_POLICY { get { if (!_DEFAULT_CARET_POLICYReady) { _DEFAULT_CARET_POLICYContent = SGetField<Java.Awt.FontNs.TextLayout.CaretPolicy>(LocalBridgeClazz, "DEFAULT_CARET_POLICY"); _DEFAULT_CARET_POLICYReady = true; } return _DEFAULT_CARET_POLICYContent; } }
        private static Java.Awt.FontNs.TextLayout.CaretPolicy _DEFAULT_CARET_POLICYContent = default;
        private static bool _DEFAULT_CARET_POLICYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getAdvance()"/> 
        /// </summary>
        public float Advance
        {
            get { return IExecuteWithSignature<float>("getAdvance", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getAscent()"/> 
        /// </summary>
        public float Ascent
        {
            get { return IExecuteWithSignature<float>("getAscent", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getBaseline()"/> 
        /// </summary>
        public byte Baseline
        {
            get { return IExecuteWithSignature<byte>("getBaseline", "()B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getBaselineOffsets()"/> 
        /// </summary>
        public float[] BaselineOffsets
        {
            get { return IExecuteWithSignatureArray<float>("getBaselineOffsets", "()[F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getBounds()"/> 
        /// </summary>
        public Java.Awt.Geom.Rectangle2D Bounds
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.Rectangle2D>("getBounds", "()Ljava/awt/geom/Rectangle2D;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getCharacterCount()"/> 
        /// </summary>
        public int CharacterCount
        {
            get { return IExecuteWithSignature<int>("getCharacterCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getDescent()"/> 
        /// </summary>
        public float Descent
        {
            get { return IExecuteWithSignature<float>("getDescent", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getLayoutPath()"/> 
        /// </summary>
        public Java.Awt.FontNs.LayoutPath LayoutPath
        {
            get { return IExecuteWithSignature<Java.Awt.FontNs.LayoutPath>("getLayoutPath", "()Ljava/awt/font/LayoutPath;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getLeading()"/> 
        /// </summary>
        public float Leading
        {
            get { return IExecuteWithSignature<float>("getLeading", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getVisibleAdvance()"/> 
        /// </summary>
        public float VisibleAdvance
        {
            get { return IExecuteWithSignature<float>("getVisibleAdvance", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#isLeftToRight()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLeftToRight()
        {
            return IExecuteWithSignature<bool>("isLeftToRight", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#isVertical()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVertical()
        {
            return IExecuteWithSignature<bool>("isVertical", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getCharacterLevel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte GetCharacterLevel(int arg0)
        {
            return IExecuteWithSignature<byte>("getCharacterLevel", "(I)B", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getCaretInfo(java.awt.font.TextHitInfo,java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetCaretInfo(Java.Awt.FontNs.TextHitInfo arg0, Java.Awt.Geom.Rectangle2D arg1)
        {
            return IExecuteArray<float>("getCaretInfo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getCaretInfo(java.awt.font.TextHitInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetCaretInfo(Java.Awt.FontNs.TextHitInfo arg0)
        {
            return IExecuteWithSignatureArray<float>("getCaretInfo", "(Ljava/awt/font/TextHitInfo;)[F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getLogicalRangesForVisualSelection(java.awt.font.TextHitInfo,java.awt.font.TextHitInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetLogicalRangesForVisualSelection(Java.Awt.FontNs.TextHitInfo arg0, Java.Awt.FontNs.TextHitInfo arg1)
        {
            return IExecuteArray<int>("getLogicalRangesForVisualSelection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getNextLeftHit(int,java.awt.font.TextLayout.CaretPolicy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontNs.TextLayout.CaretPolicy"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public Java.Awt.FontNs.TextHitInfo GetNextLeftHit(int arg0, Java.Awt.FontNs.TextLayout.CaretPolicy arg1)
        {
            return IExecute<Java.Awt.FontNs.TextHitInfo>("getNextLeftHit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getNextLeftHit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public Java.Awt.FontNs.TextHitInfo GetNextLeftHit(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.FontNs.TextHitInfo>("getNextLeftHit", "(I)Ljava/awt/font/TextHitInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getNextLeftHit(java.awt.font.TextHitInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public Java.Awt.FontNs.TextHitInfo GetNextLeftHit(Java.Awt.FontNs.TextHitInfo arg0)
        {
            return IExecuteWithSignature<Java.Awt.FontNs.TextHitInfo>("getNextLeftHit", "(Ljava/awt/font/TextHitInfo;)Ljava/awt/font/TextHitInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getNextRightHit(int,java.awt.font.TextLayout.CaretPolicy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontNs.TextLayout.CaretPolicy"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public Java.Awt.FontNs.TextHitInfo GetNextRightHit(int arg0, Java.Awt.FontNs.TextLayout.CaretPolicy arg1)
        {
            return IExecute<Java.Awt.FontNs.TextHitInfo>("getNextRightHit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getNextRightHit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public Java.Awt.FontNs.TextHitInfo GetNextRightHit(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.FontNs.TextHitInfo>("getNextRightHit", "(I)Ljava/awt/font/TextHitInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getNextRightHit(java.awt.font.TextHitInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public Java.Awt.FontNs.TextHitInfo GetNextRightHit(Java.Awt.FontNs.TextHitInfo arg0)
        {
            return IExecuteWithSignature<Java.Awt.FontNs.TextHitInfo>("getNextRightHit", "(Ljava/awt/font/TextHitInfo;)Ljava/awt/font/TextHitInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getVisualOtherHit(java.awt.font.TextHitInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public Java.Awt.FontNs.TextHitInfo GetVisualOtherHit(Java.Awt.FontNs.TextHitInfo arg0)
        {
            return IExecuteWithSignature<Java.Awt.FontNs.TextHitInfo>("getVisualOtherHit", "(Ljava/awt/font/TextHitInfo;)Ljava/awt/font/TextHitInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#hitTestChar(float,float,java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public Java.Awt.FontNs.TextHitInfo HitTestChar(float arg0, float arg1, Java.Awt.Geom.Rectangle2D arg2)
        {
            return IExecute<Java.Awt.FontNs.TextHitInfo>("hitTestChar", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#hitTestChar(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public Java.Awt.FontNs.TextHitInfo HitTestChar(float arg0, float arg1)
        {
            return IExecute<Java.Awt.FontNs.TextHitInfo>("hitTestChar", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getJustifiedLayout(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextLayout"/></returns>
        public Java.Awt.FontNs.TextLayout GetJustifiedLayout(float arg0)
        {
            return IExecuteWithSignature<Java.Awt.FontNs.TextLayout>("getJustifiedLayout", "(F)Ljava/awt/font/TextLayout;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getPixelBounds(java.awt.font.FontRenderContext,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public Java.Awt.Rectangle GetPixelBounds(Java.Awt.FontNs.FontRenderContext arg0, float arg1, float arg2)
        {
            return IExecute<Java.Awt.Rectangle>("getPixelBounds", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getBlackBoxBounds(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetBlackBoxBounds(int arg0, int arg1)
        {
            return IExecute<Java.Awt.Shape>("getBlackBoxBounds", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getCaretShape(java.awt.font.TextHitInfo,java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetCaretShape(Java.Awt.FontNs.TextHitInfo arg0, Java.Awt.Geom.Rectangle2D arg1)
        {
            return IExecute<Java.Awt.Shape>("getCaretShape", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getCaretShape(java.awt.font.TextHitInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetCaretShape(Java.Awt.FontNs.TextHitInfo arg0)
        {
            return IExecuteWithSignature<Java.Awt.Shape>("getCaretShape", "(Ljava/awt/font/TextHitInfo;)Ljava/awt/Shape;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getLogicalHighlightShape(int,int,java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetLogicalHighlightShape(int arg0, int arg1, Java.Awt.Geom.Rectangle2D arg2)
        {
            return IExecute<Java.Awt.Shape>("getLogicalHighlightShape", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getLogicalHighlightShape(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetLogicalHighlightShape(int arg0, int arg1)
        {
            return IExecute<Java.Awt.Shape>("getLogicalHighlightShape", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getOutline(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetOutline(Java.Awt.Geom.AffineTransform arg0)
        {
            return IExecuteWithSignature<Java.Awt.Shape>("getOutline", "(Ljava/awt/geom/AffineTransform;)Ljava/awt/Shape;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getVisualHighlightShape(java.awt.font.TextHitInfo,java.awt.font.TextHitInfo,java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetVisualHighlightShape(Java.Awt.FontNs.TextHitInfo arg0, Java.Awt.FontNs.TextHitInfo arg1, Java.Awt.Geom.Rectangle2D arg2)
        {
            return IExecute<Java.Awt.Shape>("getVisualHighlightShape", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getVisualHighlightShape(java.awt.font.TextHitInfo,java.awt.font.TextHitInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetVisualHighlightShape(Java.Awt.FontNs.TextHitInfo arg0, Java.Awt.FontNs.TextHitInfo arg1)
        {
            return IExecute<Java.Awt.Shape>("getVisualHighlightShape", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getCaretShapes(int,java.awt.geom.Rectangle2D,java.awt.font.TextLayout.CaretPolicy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg2"><see cref="Java.Awt.FontNs.TextLayout.CaretPolicy"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape[] GetCaretShapes(int arg0, Java.Awt.Geom.Rectangle2D arg1, Java.Awt.FontNs.TextLayout.CaretPolicy arg2)
        {
            return IExecuteArray<Java.Awt.Shape>("getCaretShapes", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getCaretShapes(int,java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape[] GetCaretShapes(int arg0, Java.Awt.Geom.Rectangle2D arg1)
        {
            return IExecuteArray<Java.Awt.Shape>("getCaretShapes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#getCaretShapes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape[] GetCaretShapes(int arg0)
        {
            return IExecuteWithSignatureArray<Java.Awt.Shape>("getCaretShapes", "(I)[Ljava/awt/Shape;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#draw(java.awt.Graphics2D,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics2D"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void Draw(Java.Awt.Graphics2D arg0, float arg1, float arg2)
        {
            IExecute("draw", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.html#hitToPoint(java.awt.font.TextHitInfo,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        public void HitToPoint(Java.Awt.FontNs.TextHitInfo arg0, Java.Awt.Geom.Point2D arg1)
        {
            IExecute("hitToPoint", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region CaretPolicy
        public partial class CaretPolicy
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextLayout.CaretPolicy.html#getStrongCaret(java.awt.font.TextHitInfo,java.awt.font.TextHitInfo,java.awt.font.TextLayout)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
            /// <param name="arg1"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
            /// <param name="arg2"><see cref="Java.Awt.FontNs.TextLayout"/></param>
            /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
            public Java.Awt.FontNs.TextHitInfo GetStrongCaret(Java.Awt.FontNs.TextHitInfo arg0, Java.Awt.FontNs.TextHitInfo arg1, Java.Awt.FontNs.TextLayout arg2)
            {
                return IExecute<Java.Awt.FontNs.TextHitInfo>("getStrongCaret", arg0, arg1, arg2);
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