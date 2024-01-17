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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio
{
    #region ImageTypeSpecifier
    public partial class ImageTypeSpecifier
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#%3Cinit%3E(java.awt.image.ColorModel,java.awt.image.SampleModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.SampleModel"/></param>
        public ImageTypeSpecifier(Java.Awt.ImageNs.ColorModel arg0, Java.Awt.ImageNs.SampleModel arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#%3Cinit%3E(java.awt.image.RenderedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        public ImageTypeSpecifier(Java.Awt.ImageNs.RenderedImage arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#createBanded(java.awt.color.ColorSpace,int[],int[],int,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ColorNs.ColorSpace"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Imageio.ImageTypeSpecifier"/></returns>
        public static Javax.Imageio.ImageTypeSpecifier CreateBanded(Java.Awt.ColorNs.ColorSpace arg0, int[] arg1, int[] arg2, int arg3, bool arg4, bool arg5)
        {
            return SExecute<Javax.Imageio.ImageTypeSpecifier>(LocalBridgeClazz, "createBanded", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#createFromBufferedImageType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Imageio.ImageTypeSpecifier"/></returns>
        public static Javax.Imageio.ImageTypeSpecifier CreateFromBufferedImageType(int arg0)
        {
            return SExecute<Javax.Imageio.ImageTypeSpecifier>(LocalBridgeClazz, "createFromBufferedImageType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#createFromRenderedImage(java.awt.image.RenderedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        /// <returns><see cref="Javax.Imageio.ImageTypeSpecifier"/></returns>
        public static Javax.Imageio.ImageTypeSpecifier CreateFromRenderedImage(Java.Awt.ImageNs.RenderedImage arg0)
        {
            return SExecute<Javax.Imageio.ImageTypeSpecifier>(LocalBridgeClazz, "createFromRenderedImage", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#createGrayscale(int,int,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Imageio.ImageTypeSpecifier"/></returns>
        public static Javax.Imageio.ImageTypeSpecifier CreateGrayscale(int arg0, int arg1, bool arg2, bool arg3)
        {
            return SExecute<Javax.Imageio.ImageTypeSpecifier>(LocalBridgeClazz, "createGrayscale", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#createGrayscale(int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Imageio.ImageTypeSpecifier"/></returns>
        public static Javax.Imageio.ImageTypeSpecifier CreateGrayscale(int arg0, int arg1, bool arg2)
        {
            return SExecute<Javax.Imageio.ImageTypeSpecifier>(LocalBridgeClazz, "createGrayscale", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#createIndexed(byte[],byte[],byte[],byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="Javax.Imageio.ImageTypeSpecifier"/></returns>
        public static Javax.Imageio.ImageTypeSpecifier CreateIndexed(byte[] arg0, byte[] arg1, byte[] arg2, byte[] arg3, int arg4, int arg5)
        {
            return SExecute<Javax.Imageio.ImageTypeSpecifier>(LocalBridgeClazz, "createIndexed", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#createInterleaved(java.awt.color.ColorSpace,int[],int,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ColorNs.ColorSpace"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Imageio.ImageTypeSpecifier"/></returns>
        public static Javax.Imageio.ImageTypeSpecifier CreateInterleaved(Java.Awt.ColorNs.ColorSpace arg0, int[] arg1, int arg2, bool arg3, bool arg4)
        {
            return SExecute<Javax.Imageio.ImageTypeSpecifier>(LocalBridgeClazz, "createInterleaved", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#createPacked(java.awt.color.ColorSpace,int,int,int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ColorNs.ColorSpace"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Imageio.ImageTypeSpecifier"/></returns>
        public static Javax.Imageio.ImageTypeSpecifier CreatePacked(Java.Awt.ColorNs.ColorSpace arg0, int arg1, int arg2, int arg3, int arg4, int arg5, bool arg6)
        {
            return SExecute<Javax.Imageio.ImageTypeSpecifier>(LocalBridgeClazz, "createPacked", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#getBufferedImageType()"/> 
        /// </summary>
        public int BufferedImageType
        {
            get { return IExecute<int>("getBufferedImageType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#getColorModel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.ColorModel ColorModel
        {
            get { return IExecute<Java.Awt.ImageNs.ColorModel>("getColorModel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#getNumBands()"/> 
        /// </summary>
        public int NumBands
        {
            get { return IExecute<int>("getNumBands"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#getNumComponents()"/> 
        /// </summary>
        public int NumComponents
        {
            get { return IExecute<int>("getNumComponents"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#getSampleModel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.SampleModel SampleModel
        {
            get { return IExecute<Java.Awt.ImageNs.SampleModel>("getSampleModel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#getBitsPerBand(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetBitsPerBand(int arg0)
        {
            return IExecute<int>("getBitsPerBand", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#createBufferedImage(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage CreateBufferedImage(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("createBufferedImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageTypeSpecifier.html#getSampleModel(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.SampleModel"/></returns>
        public Java.Awt.ImageNs.SampleModel GetSampleModel(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.SampleModel>("getSampleModel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}