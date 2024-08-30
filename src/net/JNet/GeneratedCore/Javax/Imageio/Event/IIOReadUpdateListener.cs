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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Event
{
    #region IIOReadUpdateListener definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html"/>
    /// </summary>
    public partial class IIOReadUpdateListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IIOReadUpdateListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.imageio.event.IIOReadUpdateListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region IIOReadUpdateListenerDirect definition
    /// <summary>
    /// Direct override of <see cref="IIOReadUpdateListener"/> or its generic type if there is one
    /// </summary>
    public partial class IIOReadUpdateListenerDirect : IIOReadUpdateListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.imageio.event.IIOReadUpdateListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
    #endregion

    #region IIIOReadUpdateListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.imageio.event.IIOReadUpdateListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html"/>
    /// </summary>
    public partial interface IIIOReadUpdateListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#imageUpdate(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        void ImageUpdate(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int[] arg8);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#passComplete(javax.imageio.ImageReader,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        void PassComplete(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#passStarted(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        void PassStarted(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int[] arg9);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailPassComplete(javax.imageio.ImageReader,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        void ThumbnailPassComplete(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailPassStarted(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        void ThumbnailPassStarted(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int[] arg9);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailUpdate(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        void ThumbnailUpdate(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int[] arg8);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IIOReadUpdateListener
    public partial class IIOReadUpdateListener : Javax.Imageio.Event.IIIOReadUpdateListener
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
        /// Handlers initializer for <see cref="IIOReadUpdateListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("imageUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>>>(ImageUpdateEventHandler));
            AddEventHandler("passComplete", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>>>(PassCompleteEventHandler));
            AddEventHandler("passStarted", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>>>(PassStartedEventHandler));
            AddEventHandler("thumbnailPassComplete", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>>>(ThumbnailPassCompleteEventHandler));
            AddEventHandler("thumbnailPassStarted", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>>>(ThumbnailPassStartedEventHandler));
            AddEventHandler("thumbnailUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>>>(ThumbnailUpdateEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#imageUpdate(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <remarks>If <see cref="OnImageUpdate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageReader, Java.Awt.ImageNs.BufferedImage, int, int, int, int, int, int, int[]> OnImageUpdate { get; set; } = null;

        void ImageUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>> data)
        {
            var methodToExecute = (OnImageUpdate != null) ? OnImageUpdate : ImageUpdate;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Awt.ImageNs.BufferedImage>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<int>(3), data.EventData.GetAt<int>(4), data.EventData.GetAt<int>(5), data.EventData.GetAt<int>(6), data.EventData.GetAt<int[]>(7));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#imageUpdate(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        public virtual void ImageUpdate(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int[] arg8)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#passComplete(javax.imageio.ImageReader,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPassComplete"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageReader, Java.Awt.ImageNs.BufferedImage> OnPassComplete { get; set; } = null;

        void PassCompleteEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>> data)
        {
            var methodToExecute = (OnPassComplete != null) ? OnPassComplete : PassComplete;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Awt.ImageNs.BufferedImage>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#passComplete(javax.imageio.ImageReader,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        public virtual void PassComplete(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#passStarted(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <remarks>If <see cref="OnPassStarted"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageReader, Java.Awt.ImageNs.BufferedImage, int, int, int, int, int, int, int, int[]> OnPassStarted { get; set; } = null;

        void PassStartedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>> data)
        {
            var methodToExecute = (OnPassStarted != null) ? OnPassStarted : PassStarted;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Awt.ImageNs.BufferedImage>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<int>(3), data.EventData.GetAt<int>(4), data.EventData.GetAt<int>(5), data.EventData.GetAt<int>(6), data.EventData.GetAt<int>(7), data.EventData.GetAt<int[]>(8));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#passStarted(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        public virtual void PassStarted(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int[] arg9)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailPassComplete(javax.imageio.ImageReader,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <remarks>If <see cref="OnThumbnailPassComplete"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageReader, Java.Awt.ImageNs.BufferedImage> OnThumbnailPassComplete { get; set; } = null;

        void ThumbnailPassCompleteEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>> data)
        {
            var methodToExecute = (OnThumbnailPassComplete != null) ? OnThumbnailPassComplete : ThumbnailPassComplete;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Awt.ImageNs.BufferedImage>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailPassComplete(javax.imageio.ImageReader,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        public virtual void ThumbnailPassComplete(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailPassStarted(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <remarks>If <see cref="OnThumbnailPassStarted"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageReader, Java.Awt.ImageNs.BufferedImage, int, int, int, int, int, int, int, int[]> OnThumbnailPassStarted { get; set; } = null;

        void ThumbnailPassStartedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>> data)
        {
            var methodToExecute = (OnThumbnailPassStarted != null) ? OnThumbnailPassStarted : ThumbnailPassStarted;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Awt.ImageNs.BufferedImage>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<int>(3), data.EventData.GetAt<int>(4), data.EventData.GetAt<int>(5), data.EventData.GetAt<int>(6), data.EventData.GetAt<int>(7), data.EventData.GetAt<int[]>(8));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailPassStarted(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        public virtual void ThumbnailPassStarted(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int[] arg9)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailUpdate(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <remarks>If <see cref="OnThumbnailUpdate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageReader, Java.Awt.ImageNs.BufferedImage, int, int, int, int, int, int, int[]> OnThumbnailUpdate { get; set; } = null;

        void ThumbnailUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>> data)
        {
            var methodToExecute = (OnThumbnailUpdate != null) ? OnThumbnailUpdate : ThumbnailUpdate;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Awt.ImageNs.BufferedImage>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<int>(3), data.EventData.GetAt<int>(4), data.EventData.GetAt<int>(5), data.EventData.GetAt<int>(6), data.EventData.GetAt<int[]>(7));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailUpdate(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        public virtual void ThumbnailUpdate(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int[] arg8)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IIOReadUpdateListenerDirect
    public partial class IIOReadUpdateListenerDirect : Javax.Imageio.Event.IIIOReadUpdateListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#imageUpdate(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        public override void ImageUpdate(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int[] arg8)
        {
            IExecute("imageUpdate", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#passComplete(javax.imageio.ImageReader,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        public override void PassComplete(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1)
        {
            IExecute("passComplete", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#passStarted(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        public override void PassStarted(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int[] arg9)
        {
            IExecute("passStarted", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailPassComplete(javax.imageio.ImageReader,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        public override void ThumbnailPassComplete(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1)
        {
            IExecute("thumbnailPassComplete", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailPassStarted(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        public override void ThumbnailPassStarted(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int[] arg9)
        {
            IExecute("thumbnailPassStarted", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailUpdate(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        public override void ThumbnailUpdate(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int[] arg8)
        {
            IExecute("thumbnailUpdate", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}