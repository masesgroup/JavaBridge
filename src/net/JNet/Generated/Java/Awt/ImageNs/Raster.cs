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
    #region Raster declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html"/>
    /// </summary>
    public partial class Raster : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Raster>
    {
        const string _bridgeClassName = "java.awt.image.Raster";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Raster() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Raster(params object[] args) : base(args) { }

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

    #region Raster implementation
    public partial class Raster
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createRaster(java.awt.image.SampleModel,java.awt.image.DataBuffer,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.SampleModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        public static Java.Awt.ImageNs.Raster CreateRaster(Java.Awt.ImageNs.SampleModel arg0, Java.Awt.ImageNs.DataBuffer arg1, Java.Awt.Point arg2)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.Raster>(LocalBridgeClazz, "createRaster", "(Ljava/awt/image/SampleModel;Ljava/awt/image/DataBuffer;Ljava/awt/Point;)Ljava/awt/image/Raster;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createBandedRaster(int,int,int,int,int[],int[],java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateBandedRaster(int arg0, int arg1, int arg2, int arg3, int[] arg4, int[] arg5, Java.Awt.Point arg6)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createBandedRaster", "(IIII[I[ILjava/awt/Point;)Ljava/awt/image/WritableRaster;", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createBandedRaster(int,int,int,int,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateBandedRaster(int arg0, int arg1, int arg2, int arg3, Java.Awt.Point arg4)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createBandedRaster", "(IIIILjava/awt/Point;)Ljava/awt/image/WritableRaster;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createBandedRaster(java.awt.image.DataBuffer,int,int,int,int[],int[],java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateBandedRaster(Java.Awt.ImageNs.DataBuffer arg0, int arg1, int arg2, int arg3, int[] arg4, int[] arg5, Java.Awt.Point arg6)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createBandedRaster", "(Ljava/awt/image/DataBuffer;III[I[ILjava/awt/Point;)Ljava/awt/image/WritableRaster;", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createInterleavedRaster(int,int,int,int,int,int[],java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateInterleavedRaster(int arg0, int arg1, int arg2, int arg3, int arg4, int[] arg5, Java.Awt.Point arg6)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createInterleavedRaster", "(IIIII[ILjava/awt/Point;)Ljava/awt/image/WritableRaster;", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createInterleavedRaster(int,int,int,int,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateInterleavedRaster(int arg0, int arg1, int arg2, int arg3, Java.Awt.Point arg4)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createInterleavedRaster", "(IIIILjava/awt/Point;)Ljava/awt/image/WritableRaster;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createInterleavedRaster(java.awt.image.DataBuffer,int,int,int,int,int[],java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateInterleavedRaster(Java.Awt.ImageNs.DataBuffer arg0, int arg1, int arg2, int arg3, int arg4, int[] arg5, Java.Awt.Point arg6)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createInterleavedRaster", "(Ljava/awt/image/DataBuffer;IIII[ILjava/awt/Point;)Ljava/awt/image/WritableRaster;", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createPackedRaster(int,int,int,int,int,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreatePackedRaster(int arg0, int arg1, int arg2, int arg3, int arg4, Java.Awt.Point arg5)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createPackedRaster", "(IIIIILjava/awt/Point;)Ljava/awt/image/WritableRaster;", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createPackedRaster(int,int,int,int[],java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreatePackedRaster(int arg0, int arg1, int arg2, int[] arg3, Java.Awt.Point arg4)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createPackedRaster", "(III[ILjava/awt/Point;)Ljava/awt/image/WritableRaster;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createPackedRaster(java.awt.image.DataBuffer,int,int,int,int[],java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreatePackedRaster(Java.Awt.ImageNs.DataBuffer arg0, int arg1, int arg2, int arg3, int[] arg4, Java.Awt.Point arg5)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createPackedRaster", "(Ljava/awt/image/DataBuffer;III[ILjava/awt/Point;)Ljava/awt/image/WritableRaster;", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createPackedRaster(java.awt.image.DataBuffer,int,int,int,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreatePackedRaster(Java.Awt.ImageNs.DataBuffer arg0, int arg1, int arg2, int arg3, Java.Awt.Point arg4)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createPackedRaster", "(Ljava/awt/image/DataBuffer;IIILjava/awt/Point;)Ljava/awt/image/WritableRaster;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createWritableRaster(java.awt.image.SampleModel,java.awt.image.DataBuffer,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.SampleModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateWritableRaster(Java.Awt.ImageNs.SampleModel arg0, Java.Awt.ImageNs.DataBuffer arg1, Java.Awt.Point arg2)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createWritableRaster", "(Ljava/awt/image/SampleModel;Ljava/awt/image/DataBuffer;Ljava/awt/Point;)Ljava/awt/image/WritableRaster;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createWritableRaster(java.awt.image.SampleModel,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.SampleModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateWritableRaster(Java.Awt.ImageNs.SampleModel arg0, Java.Awt.Point arg1)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createWritableRaster", "(Ljava/awt/image/SampleModel;Ljava/awt/Point;)Ljava/awt/image/WritableRaster;", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getBounds()"/> 
        /// </summary>
        public Java.Awt.Rectangle Bounds
        {
            get { return IExecuteWithSignature<Java.Awt.Rectangle>("getBounds", "()Ljava/awt/Rectangle;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getDataBuffer()"/> 
        /// </summary>
        public Java.Awt.ImageNs.DataBuffer DataBuffer
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.DataBuffer>("getDataBuffer", "()Ljava/awt/image/DataBuffer;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecuteWithSignature<int>("getHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getMinX()"/> 
        /// </summary>
        public int MinX
        {
            get { return IExecuteWithSignature<int>("getMinX", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getMinY()"/> 
        /// </summary>
        public int MinY
        {
            get { return IExecuteWithSignature<int>("getMinY", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getNumBands()"/> 
        /// </summary>
        public int NumBands
        {
            get { return IExecuteWithSignature<int>("getNumBands", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getNumDataElements()"/> 
        /// </summary>
        public int NumDataElements
        {
            get { return IExecuteWithSignature<int>("getNumDataElements", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getParent()"/> 
        /// </summary>
        public Java.Awt.ImageNs.Raster Parent
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.Raster>("getParent", "()Ljava/awt/image/Raster;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSampleModel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.SampleModel SampleModel
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.SampleModel>("getSampleModel", "()Ljava/awt/image/SampleModel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSampleModelTranslateX()"/> 
        /// </summary>
        public int SampleModelTranslateX
        {
            get { return IExecuteWithSignature<int>("getSampleModelTranslateX", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSampleModelTranslateY()"/> 
        /// </summary>
        public int SampleModelTranslateY
        {
            get { return IExecuteWithSignature<int>("getSampleModelTranslateY", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getTransferType()"/> 
        /// </summary>
        public int TransferType
        {
            get { return IExecuteWithSignature<int>("getTransferType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getWidth()"/> 
        /// </summary>
        public int Width
        {
            get { return IExecuteWithSignature<int>("getWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSampleDouble(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public double GetSampleDouble(int arg0, int arg1, int arg2)
        {
            return IExecuteWithSignature<double>("getSampleDouble", "(III)D", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getPixel(int,int,double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double[] GetPixel(int arg0, int arg1, double[] arg2)
        {
            return IExecuteWithSignatureArray<double>("getPixel", "(II[D)[D", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getPixels(int,int,int,int,double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double[] GetPixels(int arg0, int arg1, int arg2, int arg3, double[] arg4)
        {
            return IExecuteWithSignatureArray<double>("getPixels", "(IIII[D)[D", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSamples(int,int,int,int,int,double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double[] GetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, double[] arg5)
        {
            return IExecuteWithSignatureArray<double>("getSamples", "(IIIII[D)[D", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSampleFloat(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetSampleFloat(int arg0, int arg1, int arg2)
        {
            return IExecuteWithSignature<float>("getSampleFloat", "(III)F", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getPixel(int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetPixel(int arg0, int arg1, float[] arg2)
        {
            return IExecuteWithSignatureArray<float>("getPixel", "(II[F)[F", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getPixels(int,int,int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetPixels(int arg0, int arg1, int arg2, int arg3, float[] arg4)
        {
            return IExecuteWithSignatureArray<float>("getPixels", "(IIII[F)[F", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSamples(int,int,int,int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, float[] arg5)
        {
            return IExecuteWithSignatureArray<float>("getSamples", "(IIIII[F)[F", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSample(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSample(int arg0, int arg1, int arg2)
        {
            return IExecuteWithSignature<int>("getSample", "(III)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getPixel(int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetPixel(int arg0, int arg1, int[] arg2)
        {
            return IExecuteWithSignatureArray<int>("getPixel", "(II[I)[I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getPixels(int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetPixels(int arg0, int arg1, int arg2, int arg3, int[] arg4)
        {
            return IExecuteWithSignatureArray<int>("getPixels", "(IIII[I)[I", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSamples(int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, int[] arg5)
        {
            return IExecuteWithSignatureArray<int>("getSamples", "(IIIII[I)[I", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createChild(int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        public Java.Awt.ImageNs.Raster CreateChild(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int[] arg6)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Raster>("createChild", "(IIIIII[I)Ljava/awt/image/Raster;", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createTranslatedChild(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        public Java.Awt.ImageNs.Raster CreateTranslatedChild(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Raster>("createTranslatedChild", "(II)Ljava/awt/image/Raster;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createCompatibleWritableRaster()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CreateCompatibleWritableRaster()
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>("createCompatibleWritableRaster", "()Ljava/awt/image/WritableRaster;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createCompatibleWritableRaster(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CreateCompatibleWritableRaster(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>("createCompatibleWritableRaster", "(IIII)Ljava/awt/image/WritableRaster;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createCompatibleWritableRaster(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CreateCompatibleWritableRaster(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>("createCompatibleWritableRaster", "(II)Ljava/awt/image/WritableRaster;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createCompatibleWritableRaster(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CreateCompatibleWritableRaster(Java.Awt.Rectangle arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>("createCompatibleWritableRaster", "(Ljava/awt/Rectangle;)Ljava/awt/image/WritableRaster;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getDataElements(int,int,int,int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetDataElements(int arg0, int arg1, int arg2, int arg3, object arg4)
        {
            return IExecuteWithSignature("getDataElements", "(IIIILjava/lang/Object;)Ljava/lang/Object;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getDataElements(int,int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetDataElements(int arg0, int arg1, object arg2)
        {
            return IExecuteWithSignature("getDataElements", "(IILjava/lang/Object;)Ljava/lang/Object;", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}