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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Event
{
    #region IIIOWriteProgressListener
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html"/>
    /// </summary>
    public partial interface IIIOWriteProgressListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        void ImageComplete(Javax.Imageio.ImageWriter arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        void ImageProgress(Javax.Imageio.ImageWriter arg0, float arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageStarted(javax.imageio.ImageWriter,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void ImageStarted(Javax.Imageio.ImageWriter arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        void ThumbnailComplete(Javax.Imageio.ImageWriter arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        void ThumbnailProgress(Javax.Imageio.ImageWriter arg0, float arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailStarted(javax.imageio.ImageWriter,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        void ThumbnailStarted(Javax.Imageio.ImageWriter arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#writeAborted(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        void WriteAborted(Javax.Imageio.ImageWriter arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IIOWriteProgressListener
    public partial class IIOWriteProgressListener : Javax.Imageio.Event.IIIOWriteProgressListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        public virtual void ImageComplete(Javax.Imageio.ImageWriter arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public virtual void ImageProgress(Javax.Imageio.ImageWriter arg0, float arg1)
        {
            
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageStarted(javax.imageio.ImageWriter,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public virtual void ImageStarted(Javax.Imageio.ImageWriter arg0, int arg1)
        {
            
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        public virtual void ThumbnailComplete(Javax.Imageio.ImageWriter arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public virtual void ThumbnailProgress(Javax.Imageio.ImageWriter arg0, float arg1)
        {
            
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailStarted(javax.imageio.ImageWriter,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public virtual void ThumbnailStarted(Javax.Imageio.ImageWriter arg0, int arg1, int arg2)
        {
            
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#writeAborted(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        public virtual void WriteAborted(Javax.Imageio.ImageWriter arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}