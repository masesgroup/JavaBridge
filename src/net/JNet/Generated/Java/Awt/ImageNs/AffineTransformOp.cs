/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs
{
    #region AffineTransformOp
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
        public static int TYPE_BICUBIC => Clazz.GetField<int>("TYPE_BICUBIC");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#TYPE_BILINEAR"/>
        /// </summary>
        public static int TYPE_BILINEAR => Clazz.GetField<int>("TYPE_BILINEAR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#TYPE_NEAREST_NEIGHBOR"/>
        /// </summary>
        public static int TYPE_NEAREST_NEIGHBOR => Clazz.GetField<int>("TYPE_NEAREST_NEIGHBOR");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#getInterpolationType()"/> 
        /// </summary>
        public int InterpolationType
        {
            get { return IExecute<int>("getInterpolationType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#getRenderingHints()"/> 
        /// </summary>
        public Java.Awt.RenderingHints RenderingHints
        {
            get { return IExecute<Java.Awt.RenderingHints>("getRenderingHints"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#getTransform()"/> 
        /// </summary>
        public Java.Awt.Geom.AffineTransform Transform
        {
            get { return IExecute<Java.Awt.Geom.AffineTransform>("getTransform"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#getPoint2D(java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="Java.Awt.Geom.Point2D"/></returns>
        public Java.Awt.Geom.Point2D GetPoint2D(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1)
        {
            return IExecute<Java.Awt.Geom.Point2D>("getPoint2D", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#getBounds2D(java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.BufferedImage arg0)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getBounds2D", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#getBounds2D(java.awt.image.Raster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.Raster arg0)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getBounds2D", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#filter(java.awt.image.BufferedImage,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage Filter(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.BufferedImage arg1)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("filter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#filter(java.awt.image.Raster,java.awt.image.WritableRaster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster Filter(Java.Awt.ImageNs.Raster arg0, Java.Awt.ImageNs.WritableRaster arg1)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("filter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#createCompatibleDestImage(java.awt.image.BufferedImage,java.awt.image.ColorModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage CreateCompatibleDestImage(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.ColorModel arg1)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("createCompatibleDestImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/AffineTransformOp.html#createCompatibleDestRaster(java.awt.image.Raster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CreateCompatibleDestRaster(Java.Awt.ImageNs.Raster arg0)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("createCompatibleDestRaster", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}