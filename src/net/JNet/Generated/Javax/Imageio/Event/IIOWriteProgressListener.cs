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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Event
{
    #region IIIOWriteProgressListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.imageio.event.IIOWriteProgressListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html"/>
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
        /// Handlers initializer for <see cref="IIOWriteProgressListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("imageComplete", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>>>(ImageCompleteEventHandler));
            AddEventHandler("imageProgress", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>>>(ImageProgressEventHandler));
            AddEventHandler("imageStarted", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>>>(ImageStartedEventHandler));
            AddEventHandler("thumbnailComplete", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>>>(ThumbnailCompleteEventHandler));
            AddEventHandler("thumbnailProgress", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>>>(ThumbnailProgressEventHandler));
            AddEventHandler("thumbnailStarted", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>>>(ThumbnailStartedEventHandler));
            AddEventHandler("writeAborted", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>>>(WriteAbortedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <remarks>If <see cref="OnImageComplete"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter> OnImageComplete { get; set; } = null;

        void ImageCompleteEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>> data)
        {
            var methodToExecute = (OnImageComplete != null) ? OnImageComplete : ImageComplete;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        public virtual void ImageComplete(Javax.Imageio.ImageWriter arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <remarks>If <see cref="OnImageProgress"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter, float> OnImageProgress { get; set; } = null;

        void ImageProgressEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>> data)
        {
            var methodToExecute = (OnImageProgress != null) ? OnImageProgress : ImageProgress;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<float>(0));
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
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageStarted(javax.imageio.ImageWriter,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnImageStarted"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter, int> OnImageStarted { get; set; } = null;

        void ImageStartedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>> data)
        {
            var methodToExecute = (OnImageStarted != null) ? OnImageStarted : ImageStarted;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
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
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <remarks>If <see cref="OnThumbnailComplete"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter> OnThumbnailComplete { get; set; } = null;

        void ThumbnailCompleteEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>> data)
        {
            var methodToExecute = (OnThumbnailComplete != null) ? OnThumbnailComplete : ThumbnailComplete;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        public virtual void ThumbnailComplete(Javax.Imageio.ImageWriter arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <remarks>If <see cref="OnThumbnailProgress"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter, float> OnThumbnailProgress { get; set; } = null;

        void ThumbnailProgressEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>> data)
        {
            var methodToExecute = (OnThumbnailProgress != null) ? OnThumbnailProgress : ThumbnailProgress;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<float>(0));
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
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailStarted(javax.imageio.ImageWriter,int,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnThumbnailStarted"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter, int, int> OnThumbnailStarted { get; set; } = null;

        void ThumbnailStartedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>> data)
        {
            var methodToExecute = (OnThumbnailStarted != null) ? OnThumbnailStarted : ThumbnailStarted;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1));
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
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#writeAborted(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWriteAborted"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter> OnWriteAborted { get; set; } = null;

        void WriteAbortedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>> data)
        {
            var methodToExecute = (OnWriteAborted != null) ? OnWriteAborted : WriteAborted;
            methodToExecute.Invoke(data.EventData.TypedEventData);
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

    #region IIOWriteProgressListenerDirect
    public partial class IIOWriteProgressListenerDirect : Javax.Imageio.Event.IIIOWriteProgressListener
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
        public override void ImageComplete(Javax.Imageio.ImageWriter arg0)
        {
            IExecuteWithSignature("imageComplete", "(Ljavax/imageio/ImageWriter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public override void ImageProgress(Javax.Imageio.ImageWriter arg0, float arg1)
        {
            IExecute("imageProgress", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageStarted(javax.imageio.ImageWriter,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public override void ImageStarted(Javax.Imageio.ImageWriter arg0, int arg1)
        {
            IExecute("imageStarted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        public override void ThumbnailComplete(Javax.Imageio.ImageWriter arg0)
        {
            IExecuteWithSignature("thumbnailComplete", "(Ljavax/imageio/ImageWriter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public override void ThumbnailProgress(Javax.Imageio.ImageWriter arg0, float arg1)
        {
            IExecute("thumbnailProgress", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailStarted(javax.imageio.ImageWriter,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public override void ThumbnailStarted(Javax.Imageio.ImageWriter arg0, int arg1, int arg2)
        {
            IExecute("thumbnailStarted", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#writeAborted(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        public override void WriteAborted(Javax.Imageio.ImageWriter arg0)
        {
            IExecuteWithSignature("writeAborted", "(Ljavax/imageio/ImageWriter;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}