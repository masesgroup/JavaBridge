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
    #region ColorModel
    public partial class ColorModel
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public ColorModel(int arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getRGBdefault()"/> 
        /// </summary>
        public static Java.Awt.ImageNs.ColorModel RGBdefault
        {
            get { return SExecute<Java.Awt.ImageNs.ColorModel>(LocalBridgeClazz, "getRGBdefault"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getColorSpace()"/> 
        /// </summary>
        public Java.Awt.ColorNs.ColorSpace ColorSpace
        {
            get { return IExecute<Java.Awt.ColorNs.ColorSpace>("getColorSpace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getComponentSize()"/> 
        /// </summary>
        public int[] ComponentSize
        {
            get { return IExecuteArray<int>("getComponentSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getNumColorComponents()"/> 
        /// </summary>
        public int NumColorComponents
        {
            get { return IExecute<int>("getNumColorComponents"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getNumComponents()"/> 
        /// </summary>
        public int NumComponents
        {
            get { return IExecute<int>("getNumComponents"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getPixelSize()"/> 
        /// </summary>
        public int PixelSize
        {
            get { return IExecute<int>("getPixelSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getTransferType()"/> 
        /// </summary>
        public int TransferType
        {
            get { return IExecute<int>("getTransferType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getTransparency()"/> 
        /// </summary>
        public int Transparency
        {
            get { return IExecute<int>("getTransparency"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getAlpha(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAlpha(int arg0)
        {
            return IExecute<int>("getAlpha", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getBlue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetBlue(int arg0)
        {
            return IExecute<int>("getBlue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getGreen(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetGreen(int arg0)
        {
            return IExecute<int>("getGreen", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getRed(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRed(int arg0)
        {
            return IExecute<int>("getRed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#isCompatibleRaster(java.awt.image.Raster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompatibleRaster(Java.Awt.ImageNs.Raster arg0)
        {
            return IExecute<bool>("isCompatibleRaster", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#isCompatibleSampleModel(java.awt.image.SampleModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.SampleModel"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompatibleSampleModel(Java.Awt.ImageNs.SampleModel arg0)
        {
            return IExecute<bool>("isCompatibleSampleModel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#hasAlpha()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasAlpha()
        {
            return IExecute<bool>("hasAlpha");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#isAlphaPremultiplied()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAlphaPremultiplied()
        {
            return IExecute<bool>("isAlphaPremultiplied");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getNormalizedComponents(int[],int,float[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetNormalizedComponents(int[] arg0, int arg1, float[] arg2, int arg3)
        {
            return IExecuteArray<float>("getNormalizedComponents", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getNormalizedComponents(java.lang.Object,float[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetNormalizedComponents(object arg0, float[] arg1, int arg2)
        {
            return IExecuteArray<float>("getNormalizedComponents", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getAlpha(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAlpha(object arg0)
        {
            return IExecute<int>("getAlpha", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getBlue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetBlue(object arg0)
        {
            return IExecute<int>("getBlue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getComponentSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetComponentSize(int arg0)
        {
            return IExecute<int>("getComponentSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getDataElement(float[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetDataElement(float[] arg0, int arg1)
        {
            return IExecute<int>("getDataElement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getDataElement(int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetDataElement(int[] arg0, int arg1)
        {
            return IExecute<int>("getDataElement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getGreen(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetGreen(object arg0)
        {
            return IExecute<int>("getGreen", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getRed(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRed(object arg0)
        {
            return IExecute<int>("getRed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getRGB(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRGB(int arg0)
        {
            return IExecute<int>("getRGB", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getRGB(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRGB(object arg0)
        {
            return IExecute<int>("getRGB", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getComponents(int,int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetComponents(int arg0, int[] arg1, int arg2)
        {
            return IExecuteArray<int>("getComponents", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getComponents(java.lang.Object,int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetComponents(object arg0, int[] arg1, int arg2)
        {
            return IExecuteArray<int>("getComponents", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getUnnormalizedComponents(float[],int,int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetUnnormalizedComponents(float[] arg0, int arg1, int[] arg2, int arg3)
        {
            return IExecuteArray<int>("getUnnormalizedComponents", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#coerceData(java.awt.image.WritableRaster,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.ColorModel"/></returns>
        public Java.Awt.ImageNs.ColorModel CoerceData(Java.Awt.ImageNs.WritableRaster arg0, bool arg1)
        {
            return IExecute<Java.Awt.ImageNs.ColorModel>("coerceData", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#createCompatibleSampleModel(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.SampleModel"/></returns>
        public Java.Awt.ImageNs.SampleModel CreateCompatibleSampleModel(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.SampleModel>("createCompatibleSampleModel", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#createCompatibleWritableRaster(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CreateCompatibleWritableRaster(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("createCompatibleWritableRaster", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getAlphaRaster(java.awt.image.WritableRaster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster GetAlphaRaster(Java.Awt.ImageNs.WritableRaster arg0)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("getAlphaRaster", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getDataElements(float[],int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetDataElements(float[] arg0, int arg1, object arg2)
        {
            return IExecute("getDataElements", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getDataElements(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetDataElements(int arg0, object arg1)
        {
            return IExecute("getDataElements", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ColorModel.html#getDataElements(int[],int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetDataElements(int[] arg0, int arg1, object arg2)
        {
            return IExecute("getDataElements", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}