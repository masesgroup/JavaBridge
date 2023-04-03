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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs
{
    #region BufferedImage
    public partial class BufferedImage
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#%3Cinit%3E(int,int,int,java.awt.image.IndexColorModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.IndexColorModel"/></param>
        public BufferedImage(int arg0, int arg1, int arg2, Java.Awt.ImageNs.IndexColorModel arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public BufferedImage(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#%3Cinit%3E(java.awt.image.ColorModel,java.awt.image.WritableRaster,boolean,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Java.Util.Hashtable"/></param>
        public BufferedImage(Java.Awt.ImageNs.ColorModel arg0, Java.Awt.ImageNs.WritableRaster arg1, bool arg2, Java.Util.Hashtable arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.BufferedImage"/> to <see cref="Java.Awt.ImageNs.WritableRenderedImage"/>
        /// </summary>
        public static implicit operator Java.Awt.ImageNs.WritableRenderedImage(Java.Awt.ImageNs.BufferedImage t) => t.Cast<Java.Awt.ImageNs.WritableRenderedImage>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.BufferedImage"/> to <see cref="Java.Awt.Transparency"/>
        /// </summary>
        public static implicit operator Java.Awt.Transparency(Java.Awt.ImageNs.BufferedImage t) => t.Cast<Java.Awt.Transparency>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_3BYTE_BGR"/>
        /// </summary>
        public static int TYPE_3BYTE_BGR => Clazz.GetField<int>("TYPE_3BYTE_BGR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_4BYTE_ABGR"/>
        /// </summary>
        public static int TYPE_4BYTE_ABGR => Clazz.GetField<int>("TYPE_4BYTE_ABGR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_4BYTE_ABGR_PRE"/>
        /// </summary>
        public static int TYPE_4BYTE_ABGR_PRE => Clazz.GetField<int>("TYPE_4BYTE_ABGR_PRE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_BYTE_BINARY"/>
        /// </summary>
        public static int TYPE_BYTE_BINARY => Clazz.GetField<int>("TYPE_BYTE_BINARY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_BYTE_GRAY"/>
        /// </summary>
        public static int TYPE_BYTE_GRAY => Clazz.GetField<int>("TYPE_BYTE_GRAY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_BYTE_INDEXED"/>
        /// </summary>
        public static int TYPE_BYTE_INDEXED => Clazz.GetField<int>("TYPE_BYTE_INDEXED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_CUSTOM"/>
        /// </summary>
        public static int TYPE_CUSTOM => Clazz.GetField<int>("TYPE_CUSTOM");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_INT_ARGB"/>
        /// </summary>
        public static int TYPE_INT_ARGB => Clazz.GetField<int>("TYPE_INT_ARGB");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_INT_ARGB_PRE"/>
        /// </summary>
        public static int TYPE_INT_ARGB_PRE => Clazz.GetField<int>("TYPE_INT_ARGB_PRE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_INT_BGR"/>
        /// </summary>
        public static int TYPE_INT_BGR => Clazz.GetField<int>("TYPE_INT_BGR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_INT_RGB"/>
        /// </summary>
        public static int TYPE_INT_RGB => Clazz.GetField<int>("TYPE_INT_RGB");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_USHORT_555_RGB"/>
        /// </summary>
        public static int TYPE_USHORT_555_RGB => Clazz.GetField<int>("TYPE_USHORT_555_RGB");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_USHORT_565_RGB"/>
        /// </summary>
        public static int TYPE_USHORT_565_RGB => Clazz.GetField<int>("TYPE_USHORT_565_RGB");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_USHORT_GRAY"/>
        /// </summary>
        public static int TYPE_USHORT_GRAY => Clazz.GetField<int>("TYPE_USHORT_GRAY");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getAlphaRaster()"/> 
        /// </summary>
        public Java.Awt.ImageNs.WritableRaster AlphaRaster
        {
            get { return IExecute<Java.Awt.ImageNs.WritableRaster>("getAlphaRaster"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getColorModel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.ColorModel ColorModel
        {
            get { return IExecute<Java.Awt.ImageNs.ColorModel>("getColorModel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#createGraphics()"/> 
        /// </summary>
        public Java.Awt.Graphics2D CreateGraphics
        {
            get { return IExecute<Java.Awt.Graphics2D>("createGraphics"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getData()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#setData(java.awt.image.Raster)"/>
        /// </summary>
        public Java.Awt.ImageNs.Raster Data
        {
            get { return IExecute<Java.Awt.ImageNs.Raster>("getData"); } set { IExecute("setData", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#hasTileWriters()"/> 
        /// </summary>
        public bool HasTileWriters
        {
            get { return IExecute<bool>("hasTileWriters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecute<int>("getHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#isAlphaPremultiplied()"/> 
        /// </summary>
        public bool IsAlphaPremultiplied
        {
            get { return IExecute<bool>("isAlphaPremultiplied"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getMinTileX()"/> 
        /// </summary>
        public int MinTileX
        {
            get { return IExecute<int>("getMinTileX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getMinTileY()"/> 
        /// </summary>
        public int MinTileY
        {
            get { return IExecute<int>("getMinTileY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getMinX()"/> 
        /// </summary>
        public int MinX
        {
            get { return IExecute<int>("getMinX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getMinY()"/> 
        /// </summary>
        public int MinY
        {
            get { return IExecute<int>("getMinY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getNumXTiles()"/> 
        /// </summary>
        public int NumXTiles
        {
            get { return IExecute<int>("getNumXTiles"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getNumYTiles()"/> 
        /// </summary>
        public int NumYTiles
        {
            get { return IExecute<int>("getNumYTiles"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getPropertyNames()"/> 
        /// </summary>
        public string[] PropertyNames
        {
            get { return IExecuteArray<string>("getPropertyNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getRaster()"/> 
        /// </summary>
        public Java.Awt.ImageNs.WritableRaster Raster
        {
            get { return IExecute<Java.Awt.ImageNs.WritableRaster>("getRaster"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getSampleModel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.SampleModel SampleModel
        {
            get { return IExecute<Java.Awt.ImageNs.SampleModel>("getSampleModel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getSources()"/> 
        /// </summary>
        public Java.Util.Vector Sources
        {
            get { return IExecute<Java.Util.Vector>("getSources"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getTileGridXOffset()"/> 
        /// </summary>
        public int TileGridXOffset
        {
            get { return IExecute<int>("getTileGridXOffset"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getTileGridYOffset()"/> 
        /// </summary>
        public int TileGridYOffset
        {
            get { return IExecute<int>("getTileGridYOffset"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getTileHeight()"/> 
        /// </summary>
        public int TileHeight
        {
            get { return IExecute<int>("getTileHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getTileWidth()"/> 
        /// </summary>
        public int TileWidth
        {
            get { return IExecute<int>("getTileWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getTransparency()"/> 
        /// </summary>
        public int Transparency
        {
            get { return IExecute<int>("getTransparency"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecute<int>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getWidth()"/> 
        /// </summary>
        public int Width
        {
            get { return IExecute<int>("getWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getWritableTileIndices()"/> 
        /// </summary>
        public Java.Awt.Point[] WritableTileIndices
        {
            get { return IExecuteArray<Java.Awt.Point>("getWritableTileIndices"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#isTileWritable(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsTileWritable(int arg0, int arg1)
        {
            return IExecute<bool>("isTileWritable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getRGB(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRGB(int arg0, int arg1)
        {
            return IExecute<int>("getRGB", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getRGB(int,int,int,int,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetRGB(int arg0, int arg1, int arg2, int arg3, int[] arg4, int arg5, int arg6)
        {
            return IExecuteArray<int>("getRGB", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getSubimage(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage GetSubimage(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("getSubimage", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getData(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        public Java.Awt.ImageNs.Raster GetData(Java.Awt.Rectangle arg0)
        {
            return IExecute<Java.Awt.ImageNs.Raster>("getData", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        public Java.Awt.ImageNs.Raster GetTile(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.Raster>("getTile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#copyData(java.awt.image.WritableRaster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CopyData(Java.Awt.ImageNs.WritableRaster arg0)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("copyData", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getWritableTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster GetWritableTile(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("getWritableTile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#addTileObserver(java.awt.image.TileObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.TileObserver"/></param>
        public void AddTileObserver(Java.Awt.ImageNs.TileObserver arg0)
        {
            IExecute("addTileObserver", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#coerceData(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void CoerceData(bool arg0)
        {
            IExecute("coerceData", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#releaseWritableTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void ReleaseWritableTile(int arg0, int arg1)
        {
            IExecute("releaseWritableTile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#removeTileObserver(java.awt.image.TileObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.TileObserver"/></param>
        public void RemoveTileObserver(Java.Awt.ImageNs.TileObserver arg0)
        {
            IExecute("removeTileObserver", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#setRGB(int,int,int,int,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        public void SetRGB(int arg0, int arg1, int arg2, int arg3, int[] arg4, int arg5, int arg6)
        {
            IExecute("setRGB", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#setRGB(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetRGB(int arg0, int arg1, int arg2)
        {
            IExecute("setRGB", arg0, arg1, arg2);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}