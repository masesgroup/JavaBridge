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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs
{
    #region IWritableRenderedImage
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IWritableRenderedImage : Java.Awt.ImageNs.IRenderedImage
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#getWritableTileIndices()"/> 
        /// </summary>
        Java.Awt.Point[] WritableTileIndices { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#hasTileWriters()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool HasTileWriters();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#isTileWritable(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsTileWritable(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#getWritableTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        Java.Awt.ImageNs.WritableRaster GetWritableTile(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#addTileObserver(java.awt.image.TileObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.TileObserver"/></param>
        void AddTileObserver(Java.Awt.ImageNs.TileObserver arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#releaseWritableTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void ReleaseWritableTile(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#removeTileObserver(java.awt.image.TileObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.TileObserver"/></param>
        void RemoveTileObserver(Java.Awt.ImageNs.TileObserver arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#setData(java.awt.image.Raster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        void SetData(Java.Awt.ImageNs.Raster arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WritableRenderedImage
    public partial class WritableRenderedImage : Java.Awt.ImageNs.IWritableRenderedImage
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#getWritableTileIndices()"/> 
        /// </summary>
        public Java.Awt.Point[] WritableTileIndices
        {
            get { return IExecuteWithSignatureArray<Java.Awt.Point>("getWritableTileIndices", "()[Ljava/awt/Point;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#hasTileWriters()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasTileWriters()
        {
            return IExecuteWithSignature<bool>("hasTileWriters", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#isTileWritable(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsTileWritable(int arg0, int arg1)
        {
            return IExecute<bool>("isTileWritable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#getWritableTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster GetWritableTile(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("getWritableTile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#addTileObserver(java.awt.image.TileObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.TileObserver"/></param>
        public void AddTileObserver(Java.Awt.ImageNs.TileObserver arg0)
        {
            IExecuteWithSignature("addTileObserver", "(Ljava/awt/image/TileObserver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#releaseWritableTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void ReleaseWritableTile(int arg0, int arg1)
        {
            IExecute("releaseWritableTile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#removeTileObserver(java.awt.image.TileObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.TileObserver"/></param>
        public void RemoveTileObserver(Java.Awt.ImageNs.TileObserver arg0)
        {
            IExecuteWithSignature("removeTileObserver", "(Ljava/awt/image/TileObserver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#setData(java.awt.image.Raster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        public void SetData(Java.Awt.ImageNs.Raster arg0)
        {
            IExecuteWithSignature("setData", "(Ljava/awt/image/Raster;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}