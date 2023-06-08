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

namespace Java.Awt.ImageNs
{
    #region IImageConsumer
    public partial interface IImageConsumer
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#imageComplete(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        void ImageComplete(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#setColorModel(java.awt.image.ColorModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        void SetColorModel(Java.Awt.ImageNs.ColorModel arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#setDimensions(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void SetDimensions(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#setHints(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        void SetHints(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#setPixels(int,int,int,int,java.awt.image.ColorModel,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg5"><see cref="byte"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        void SetPixels(int arg0, int arg1, int arg2, int arg3, Java.Awt.ImageNs.ColorModel arg4, byte[] arg5, int arg6, int arg7);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#setPixels(int,int,int,int,java.awt.image.ColorModel,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        void SetPixels(int arg0, int arg1, int arg2, int arg3, Java.Awt.ImageNs.ColorModel arg4, int[] arg5, int arg6, int arg7);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#setProperties(java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Hashtable"/></param>
        void SetProperties(Java.Util.Hashtable<object, object> arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ImageConsumer
    public partial class ImageConsumer : Java.Awt.ImageNs.IImageConsumer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#COMPLETESCANLINES"/>
        /// </summary>
        public static int COMPLETESCANLINES { get { return SGetField<int>(LocalBridgeClazz, "COMPLETESCANLINES"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#IMAGEABORTED"/>
        /// </summary>
        public static int IMAGEABORTED { get { return SGetField<int>(LocalBridgeClazz, "IMAGEABORTED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#IMAGEERROR"/>
        /// </summary>
        public static int IMAGEERROR { get { return SGetField<int>(LocalBridgeClazz, "IMAGEERROR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#RANDOMPIXELORDER"/>
        /// </summary>
        public static int RANDOMPIXELORDER { get { return SGetField<int>(LocalBridgeClazz, "RANDOMPIXELORDER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#SINGLEFRAME"/>
        /// </summary>
        public static int SINGLEFRAME { get { return SGetField<int>(LocalBridgeClazz, "SINGLEFRAME"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#SINGLEFRAMEDONE"/>
        /// </summary>
        public static int SINGLEFRAMEDONE { get { return SGetField<int>(LocalBridgeClazz, "SINGLEFRAMEDONE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#SINGLEPASS"/>
        /// </summary>
        public static int SINGLEPASS { get { return SGetField<int>(LocalBridgeClazz, "SINGLEPASS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#STATICIMAGEDONE"/>
        /// </summary>
        public static int STATICIMAGEDONE { get { return SGetField<int>(LocalBridgeClazz, "STATICIMAGEDONE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#TOPDOWNLEFTRIGHT"/>
        /// </summary>
        public static int TOPDOWNLEFTRIGHT { get { return SGetField<int>(LocalBridgeClazz, "TOPDOWNLEFTRIGHT"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#imageComplete(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void ImageComplete(int arg0)
        {
            IExecute("imageComplete", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#setColorModel(java.awt.image.ColorModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        public void SetColorModel(Java.Awt.ImageNs.ColorModel arg0)
        {
            IExecute("setColorModel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#setDimensions(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetDimensions(int arg0, int arg1)
        {
            IExecute("setDimensions", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#setHints(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetHints(int arg0)
        {
            IExecute("setHints", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#setPixels(int,int,int,int,java.awt.image.ColorModel,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg5"><see cref="byte"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public void SetPixels(int arg0, int arg1, int arg2, int arg3, Java.Awt.ImageNs.ColorModel arg4, byte[] arg5, int arg6, int arg7)
        {
            IExecute("setPixels", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#setPixels(int,int,int,int,java.awt.image.ColorModel,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public void SetPixels(int arg0, int arg1, int arg2, int arg3, Java.Awt.ImageNs.ColorModel arg4, int[] arg5, int arg6, int arg7)
        {
            IExecute("setPixels", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageConsumer.html#setProperties(java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Hashtable"/></param>
        public void SetProperties(Java.Util.Hashtable<object, object> arg0)
        {
            IExecute("setProperties", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}