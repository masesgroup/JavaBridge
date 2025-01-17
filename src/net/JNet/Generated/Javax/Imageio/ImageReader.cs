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

namespace Javax.Imageio
{
    #region ImageReader declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html"/>
    /// </summary>
    public partial class ImageReader : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ImageReader>
    {
        const string _bridgeClassName = "javax.imageio.ImageReader";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ImageReader class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ImageReader() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ImageReader class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ImageReader(params object[] args) : base(args) { }

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

    }
    #endregion

    #region ImageReader implementation
    public partial class ImageReader
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getAvailableLocales()"/> 
        /// </summary>
        public Java.Util.Locale[] AvailableLocales
        {
            get { return IExecuteWithSignatureArray<Java.Util.Locale>("getAvailableLocales", "()[Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getDefaultReadParam()"/> 
        /// </summary>
        public Javax.Imageio.ImageReadParam DefaultReadParam
        {
            get { return IExecuteWithSignature<Javax.Imageio.ImageReadParam>("getDefaultReadParam", "()Ljavax/imageio/ImageReadParam;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getFormatName()"/> 
        /// </summary>
        public Java.Lang.String FormatName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFormatName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getInput()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#setInput(java.lang.Object)"/>
        /// </summary>
        public object Input
        {
            get { return IExecuteWithSignature("getInput", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setInput", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getLocale()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#setLocale(java.util.Locale)"/>
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;"); } set { IExecuteWithSignature("setLocale", "(Ljava/util/Locale;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getMinIndex()"/> 
        /// </summary>
        public int MinIndex
        {
            get { return IExecuteWithSignature<int>("getMinIndex", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getOriginatingProvider()"/> 
        /// </summary>
        public Javax.Imageio.Spi.ImageReaderSpi OriginatingProvider
        {
            get { return IExecuteWithSignature<Javax.Imageio.Spi.ImageReaderSpi>("getOriginatingProvider", "()Ljavax/imageio/spi/ImageReaderSpi;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getStreamMetadata()"/> 
        /// </summary>
        public Javax.Imageio.Metadata.IIOMetadata StreamMetadata
        {
            get { return IExecuteWithSignature<Javax.Imageio.Metadata.IIOMetadata>("getStreamMetadata", "()Ljavax/imageio/metadata/IIOMetadata;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getHeight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetHeight(int arg0)
        {
            return IExecuteWithSignature<int>("getHeight", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getNumImages(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetNumImages(bool arg0)
        {
            return IExecuteWithSignature<int>("getNumImages", "(Z)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetWidth(int arg0)
        {
            return IExecuteWithSignature<int>("getWidth", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#read(int,javax.imageio.ImageReadParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageReadParam"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Awt.ImageNs.BufferedImage Read(int arg0, Javax.Imageio.ImageReadParam arg1)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>("read", "(ILjavax/imageio/ImageReadParam;)Ljava/awt/image/BufferedImage;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getImageTypes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Iterator<Javax.Imageio.ImageTypeSpecifier> GetImageTypes(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Iterator<Javax.Imageio.ImageTypeSpecifier>>("getImageTypes", "(I)Ljava/util/Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getImageMetadata(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadata"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Imageio.Metadata.IIOMetadata GetImageMetadata(int arg0)
        {
            return IExecuteWithSignature<Javax.Imageio.Metadata.IIOMetadata>("getImageMetadata", "(I)Ljavax/imageio/metadata/IIOMetadata;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#canReadRaster()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanReadRaster()
        {
            return IExecuteWithSignature<bool>("canReadRaster", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#hasThumbnails(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool HasThumbnails(int arg0)
        {
            return IExecuteWithSignature<bool>("hasThumbnails", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#isIgnoringMetadata()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsIgnoringMetadata()
        {
            return IExecuteWithSignature<bool>("isIgnoringMetadata", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#isImageTiled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool IsImageTiled(int arg0)
        {
            return IExecuteWithSignature<bool>("isImageTiled", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#isRandomAccessEasy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool IsRandomAccessEasy(int arg0)
        {
            return IExecuteWithSignature<bool>("isRandomAccessEasy", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#isSeekForwardOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSeekForwardOnly()
        {
            return IExecuteWithSignature<bool>("isSeekForwardOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readerSupportsThumbnails()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ReaderSupportsThumbnails()
        {
            return IExecuteWithSignature<bool>("readerSupportsThumbnails", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getAspectRatio(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public float GetAspectRatio(int arg0)
        {
            return IExecuteWithSignature<float>("getAspectRatio", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getNumThumbnails(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetNumThumbnails(int arg0)
        {
            return IExecuteWithSignature<int>("getNumThumbnails", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getThumbnailHeight(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetThumbnailHeight(int arg0, int arg1)
        {
            return IExecuteWithSignature<int>("getThumbnailHeight", "(II)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getThumbnailWidth(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetThumbnailWidth(int arg0, int arg1)
        {
            return IExecuteWithSignature<int>("getThumbnailWidth", "(II)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getTileGridXOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetTileGridXOffset(int arg0)
        {
            return IExecuteWithSignature<int>("getTileGridXOffset", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getTileGridYOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetTileGridYOffset(int arg0)
        {
            return IExecuteWithSignature<int>("getTileGridYOffset", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getTileHeight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetTileHeight(int arg0)
        {
            return IExecuteWithSignature<int>("getTileHeight", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getTileWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetTileWidth(int arg0)
        {
            return IExecuteWithSignature<int>("getTileWidth", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#read(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Awt.ImageNs.BufferedImage Read(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>("read", "(I)Ljava/awt/image/BufferedImage;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readThumbnail(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Awt.ImageNs.BufferedImage ReadThumbnail(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>("readThumbnail", "(II)Ljava/awt/image/BufferedImage;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readTile(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Awt.ImageNs.BufferedImage ReadTile(int arg0, int arg1, int arg2)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>("readTile", "(III)Ljava/awt/image/BufferedImage;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readRaster(int,javax.imageio.ImageReadParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageReadParam"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Awt.ImageNs.Raster ReadRaster(int arg0, Javax.Imageio.ImageReadParam arg1)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Raster>("readRaster", "(ILjavax/imageio/ImageReadParam;)Ljava/awt/image/Raster;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readTileRaster(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Awt.ImageNs.Raster ReadTileRaster(int arg0, int arg1, int arg2)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Raster>("readTileRaster", "(III)Ljava/awt/image/Raster;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readAsRenderedImage(int,javax.imageio.ImageReadParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageReadParam"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Awt.ImageNs.RenderedImage ReadAsRenderedImage(int arg0, Javax.Imageio.ImageReadParam arg1)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.RenderedImage>("readAsRenderedImage", "(ILjavax/imageio/ImageReadParam;)Ljava/awt/image/RenderedImage;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readAll(java.util.Iterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Iterator"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Imageio_ImageReadParam"><see cref="Javax.Imageio.ImageReadParam"/></typeparam>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Iterator<Javax.Imageio.IIOImage> ReadAll<Arg0ExtendsJavax_Imageio_ImageReadParam>(Java.Util.Iterator<Arg0ExtendsJavax_Imageio_ImageReadParam> arg0) where Arg0ExtendsJavax_Imageio_ImageReadParam : Javax.Imageio.ImageReadParam
        {
            return IExecuteWithSignature<Java.Util.Iterator<Javax.Imageio.IIOImage>>("readAll", "(Ljava/util/Iterator;)Ljava/util/Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readAll(int,javax.imageio.ImageReadParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageReadParam"/></param>
        /// <returns><see cref="Javax.Imageio.IIOImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Imageio.IIOImage ReadAll(int arg0, Javax.Imageio.ImageReadParam arg1)
        {
            return IExecuteWithSignature<Javax.Imageio.IIOImage>("readAll", "(ILjavax/imageio/ImageReadParam;)Ljavax/imageio/IIOImage;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getRawImageType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Imageio.ImageTypeSpecifier"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Imageio.ImageTypeSpecifier GetRawImageType(int arg0)
        {
            return IExecuteWithSignature<Javax.Imageio.ImageTypeSpecifier>("getRawImageType", "(I)Ljavax/imageio/ImageTypeSpecifier;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getImageMetadata(int,java.lang.String,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadata"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Imageio.Metadata.IIOMetadata GetImageMetadata(int arg0, Java.Lang.String arg1, Java.Util.Set<Java.Lang.String> arg2)
        {
            return IExecuteWithSignature<Javax.Imageio.Metadata.IIOMetadata>("getImageMetadata", "(ILjava/lang/String;Ljava/util/Set;)Ljavax/imageio/metadata/IIOMetadata;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getStreamMetadata(java.lang.String,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadata"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Imageio.Metadata.IIOMetadata GetStreamMetadata(Java.Lang.String arg0, Java.Util.Set<Java.Lang.String> arg1)
        {
            return IExecuteWithSignature<Javax.Imageio.Metadata.IIOMetadata>("getStreamMetadata", "(Ljava/lang/String;Ljava/util/Set;)Ljavax/imageio/metadata/IIOMetadata;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#abort()"/>
        /// </summary>
        public void Abort()
        {
            IExecuteWithSignature("abort", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#addIIOReadProgressListener(javax.imageio.event.IIOReadProgressListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOReadProgressListener"/></param>
        public void AddIIOReadProgressListener(Javax.Imageio.Event.IIOReadProgressListener arg0)
        {
            IExecuteWithSignature("addIIOReadProgressListener", "(Ljavax/imageio/event/IIOReadProgressListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#addIIOReadUpdateListener(javax.imageio.event.IIOReadUpdateListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOReadUpdateListener"/></param>
        public void AddIIOReadUpdateListener(Javax.Imageio.Event.IIOReadUpdateListener arg0)
        {
            IExecuteWithSignature("addIIOReadUpdateListener", "(Ljavax/imageio/event/IIOReadUpdateListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#addIIOReadWarningListener(javax.imageio.event.IIOReadWarningListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOReadWarningListener"/></param>
        public void AddIIOReadWarningListener(Javax.Imageio.Event.IIOReadWarningListener arg0)
        {
            IExecuteWithSignature("addIIOReadWarningListener", "(Ljavax/imageio/event/IIOReadWarningListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#dispose()"/>
        /// </summary>
        public new void Dispose()
        {
            IExecuteWithSignature("dispose", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#removeAllIIOReadProgressListeners()"/>
        /// </summary>
        public void RemoveAllIIOReadProgressListeners()
        {
            IExecuteWithSignature("removeAllIIOReadProgressListeners", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#removeAllIIOReadUpdateListeners()"/>
        /// </summary>
        public void RemoveAllIIOReadUpdateListeners()
        {
            IExecuteWithSignature("removeAllIIOReadUpdateListeners", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#removeAllIIOReadWarningListeners()"/>
        /// </summary>
        public void RemoveAllIIOReadWarningListeners()
        {
            IExecuteWithSignature("removeAllIIOReadWarningListeners", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#removeIIOReadProgressListener(javax.imageio.event.IIOReadProgressListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOReadProgressListener"/></param>
        public void RemoveIIOReadProgressListener(Javax.Imageio.Event.IIOReadProgressListener arg0)
        {
            IExecuteWithSignature("removeIIOReadProgressListener", "(Ljavax/imageio/event/IIOReadProgressListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#removeIIOReadUpdateListener(javax.imageio.event.IIOReadUpdateListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOReadUpdateListener"/></param>
        public void RemoveIIOReadUpdateListener(Javax.Imageio.Event.IIOReadUpdateListener arg0)
        {
            IExecuteWithSignature("removeIIOReadUpdateListener", "(Ljavax/imageio/event/IIOReadUpdateListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#removeIIOReadWarningListener(javax.imageio.event.IIOReadWarningListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOReadWarningListener"/></param>
        public void RemoveIIOReadWarningListener(Javax.Imageio.Event.IIOReadWarningListener arg0)
        {
            IExecuteWithSignature("removeIIOReadWarningListener", "(Ljavax/imageio/event/IIOReadWarningListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#setInput(java.lang.Object,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void SetInput(object arg0, bool arg1, bool arg2)
        {
            IExecuteWithSignature("setInput", "(Ljava/lang/Object;ZZ)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#setInput(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetInput(object arg0, bool arg1)
        {
            IExecuteWithSignature("setInput", "(Ljava/lang/Object;Z)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}