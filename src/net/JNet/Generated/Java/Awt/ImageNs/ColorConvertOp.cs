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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs
{
    #region ColorConvertOp
    public partial class ColorConvertOp
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorConvertOp.html#%3Cinit%3E(java.awt.color.ColorSpace,java.awt.color.ColorSpace,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ColorNs.ColorSpace"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ColorNs.ColorSpace"/></param>
        /// <param name="arg2"><see cref="Java.Awt.RenderingHints"/></param>
        public ColorConvertOp(Java.Awt.ColorNs.ColorSpace arg0, Java.Awt.ColorNs.ColorSpace arg1, Java.Awt.RenderingHints arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorConvertOp.html#%3Cinit%3E(java.awt.color.ColorSpace,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ColorNs.ColorSpace"/></param>
        /// <param name="arg1"><see cref="Java.Awt.RenderingHints"/></param>
        public ColorConvertOp(Java.Awt.ColorNs.ColorSpace arg0, Java.Awt.RenderingHints arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorConvertOp.html#%3Cinit%3E(java.awt.color.ICC_Profile[],java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ColorNs.ICC_Profile"/></param>
        /// <param name="arg1"><see cref="Java.Awt.RenderingHints"/></param>
        public ColorConvertOp(Java.Awt.ColorNs.ICC_Profile[] arg0, Java.Awt.RenderingHints arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorConvertOp.html#%3Cinit%3E(java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.RenderingHints"/></param>
        public ColorConvertOp(Java.Awt.RenderingHints arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.ColorConvertOp"/> to <see cref="Java.Awt.ImageNs.BufferedImageOp"/>
        /// </summary>
        public static implicit operator Java.Awt.ImageNs.BufferedImageOp(Java.Awt.ImageNs.ColorConvertOp t) => t.Cast<Java.Awt.ImageNs.BufferedImageOp>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.ColorConvertOp"/> to <see cref="Java.Awt.ImageNs.RasterOp"/>
        /// </summary>
        public static implicit operator Java.Awt.ImageNs.RasterOp(Java.Awt.ImageNs.ColorConvertOp t) => t.Cast<Java.Awt.ImageNs.RasterOp>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorConvertOp.html#getICC_Profiles()"/> 
        /// </summary>
        public Java.Awt.ColorNs.ICC_Profile[] ICC_Profiles
        {
            get { return IExecuteArray<Java.Awt.ColorNs.ICC_Profile>("getICC_Profiles"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorConvertOp.html#getRenderingHints()"/> 
        /// </summary>
        public Java.Awt.RenderingHints RenderingHints
        {
            get { return IExecute<Java.Awt.RenderingHints>("getRenderingHints"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorConvertOp.html#getPoint2D(java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="Java.Awt.Geom.Point2D"/></returns>
        public Java.Awt.Geom.Point2D GetPoint2D(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1)
        {
            return IExecute<Java.Awt.Geom.Point2D>("getPoint2D", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorConvertOp.html#getBounds2D(java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.BufferedImage arg0)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getBounds2D", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorConvertOp.html#getBounds2D(java.awt.image.Raster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.Raster arg0)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getBounds2D", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorConvertOp.html#filter(java.awt.image.BufferedImage,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage Filter(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.BufferedImage arg1)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("filter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorConvertOp.html#filter(java.awt.image.Raster,java.awt.image.WritableRaster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster Filter(Java.Awt.ImageNs.Raster arg0, Java.Awt.ImageNs.WritableRaster arg1)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("filter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorConvertOp.html#createCompatibleDestImage(java.awt.image.BufferedImage,java.awt.image.ColorModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage CreateCompatibleDestImage(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.ColorModel arg1)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("createCompatibleDestImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorConvertOp.html#createCompatibleDestRaster(java.awt.image.Raster)"/>
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