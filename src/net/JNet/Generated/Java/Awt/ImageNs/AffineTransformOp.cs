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

namespace Java.Awt.ImageNs
{
    #region AffineTransformOp declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html"/>
    /// </summary>
    public partial class AffineTransformOp : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AffineTransformOp>
    {
        const string _bridgeClassName = "java.awt.image.AffineTransformOp";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AffineTransformOp() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AffineTransformOp(params object[] args) : base(args) { }

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

    #region AffineTransformOp implementation
    public partial class AffineTransformOp
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#%3Cinit%3E(java.awt.geom.AffineTransform,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public AffineTransformOp(Java.Awt.Geom.AffineTransform arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#%3Cinit%3E(java.awt.geom.AffineTransform,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg1"><see cref="Java.Awt.RenderingHints"/></param>
        public AffineTransformOp(Java.Awt.Geom.AffineTransform arg0, Java.Awt.RenderingHints arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.AffineTransformOp"/> to <see cref="Java.Awt.ImageNs.BufferedImageOp"/>
        /// </summary>
        public static implicit operator Java.Awt.ImageNs.BufferedImageOp(Java.Awt.ImageNs.AffineTransformOp t) => t.Cast<Java.Awt.ImageNs.BufferedImageOp>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.AffineTransformOp"/> to <see cref="Java.Awt.ImageNs.RasterOp"/>
        /// </summary>
        public static implicit operator Java.Awt.ImageNs.RasterOp(Java.Awt.ImageNs.AffineTransformOp t) => t.Cast<Java.Awt.ImageNs.RasterOp>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#TYPE_BICUBIC"/>
        /// </summary>
        public static int TYPE_BICUBIC { get { if (!_TYPE_BICUBICReady) { _TYPE_BICUBICContent = SGetField<int>(LocalBridgeClazz, "TYPE_BICUBIC"); _TYPE_BICUBICReady = true; } return _TYPE_BICUBICContent; } }
        private static int _TYPE_BICUBICContent = default;
        private static bool _TYPE_BICUBICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#TYPE_BILINEAR"/>
        /// </summary>
        public static int TYPE_BILINEAR { get { if (!_TYPE_BILINEARReady) { _TYPE_BILINEARContent = SGetField<int>(LocalBridgeClazz, "TYPE_BILINEAR"); _TYPE_BILINEARReady = true; } return _TYPE_BILINEARContent; } }
        private static int _TYPE_BILINEARContent = default;
        private static bool _TYPE_BILINEARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#TYPE_NEAREST_NEIGHBOR"/>
        /// </summary>
        public static int TYPE_NEAREST_NEIGHBOR { get { if (!_TYPE_NEAREST_NEIGHBORReady) { _TYPE_NEAREST_NEIGHBORContent = SGetField<int>(LocalBridgeClazz, "TYPE_NEAREST_NEIGHBOR"); _TYPE_NEAREST_NEIGHBORReady = true; } return _TYPE_NEAREST_NEIGHBORContent; } }
        private static int _TYPE_NEAREST_NEIGHBORContent = default;
        private static bool _TYPE_NEAREST_NEIGHBORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#getInterpolationType()"/> 
        /// </summary>
        public int InterpolationType
        {
            get { return IExecuteWithSignature<int>("getInterpolationType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#getRenderingHints()"/> 
        /// </summary>
        public Java.Awt.RenderingHints RenderingHints
        {
            get { return IExecuteWithSignature<Java.Awt.RenderingHints>("getRenderingHints", "()Ljava/awt/RenderingHints;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#getTransform()"/> 
        /// </summary>
        public Java.Awt.Geom.AffineTransform Transform
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.AffineTransform>("getTransform", "()Ljava/awt/geom/AffineTransform;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#getPoint2D(java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="Java.Awt.Geom.Point2D"/></returns>
        public Java.Awt.Geom.Point2D GetPoint2D(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1)
        {
            return IExecuteWithSignature<Java.Awt.Geom.Point2D>("getPoint2D", "(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)Ljava/awt/geom/Point2D;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#getBounds2D(java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.BufferedImage arg0)
        {
            return IExecuteWithSignature<Java.Awt.Geom.Rectangle2D>("getBounds2D", "(Ljava/awt/image/BufferedImage;)Ljava/awt/geom/Rectangle2D;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#getBounds2D(java.awt.image.Raster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.Raster arg0)
        {
            return IExecuteWithSignature<Java.Awt.Geom.Rectangle2D>("getBounds2D", "(Ljava/awt/image/Raster;)Ljava/awt/geom/Rectangle2D;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#filter(java.awt.image.BufferedImage,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage Filter(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.BufferedImage arg1)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>("filter", "(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImage;)Ljava/awt/image/BufferedImage;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#filter(java.awt.image.Raster,java.awt.image.WritableRaster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster Filter(Java.Awt.ImageNs.Raster arg0, Java.Awt.ImageNs.WritableRaster arg1)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>("filter", "(Ljava/awt/image/Raster;Ljava/awt/image/WritableRaster;)Ljava/awt/image/WritableRaster;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#createCompatibleDestImage(java.awt.image.BufferedImage,java.awt.image.ColorModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage CreateCompatibleDestImage(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.ColorModel arg1)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>("createCompatibleDestImage", "(Ljava/awt/image/BufferedImage;Ljava/awt/image/ColorModel;)Ljava/awt/image/BufferedImage;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#createCompatibleDestRaster(java.awt.image.Raster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CreateCompatibleDestRaster(Java.Awt.ImageNs.Raster arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>("createCompatibleDestRaster", "(Ljava/awt/image/Raster;)Ljava/awt/image/WritableRaster;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}