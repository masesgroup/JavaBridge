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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs
{
    #region VolatileImage
    public partial class VolatileImage
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.VolatileImage"/> to <see cref="Java.Awt.Transparency"/>
        /// </summary>
        public static implicit operator Java.Awt.Transparency(Java.Awt.ImageNs.VolatileImage t) => t.Cast<Java.Awt.Transparency>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/VolatileImage.html#IMAGE_INCOMPATIBLE"/>
        /// </summary>
        public static int IMAGE_INCOMPATIBLE { get { if (!_IMAGE_INCOMPATIBLEReady) { _IMAGE_INCOMPATIBLEContent = SGetField<int>(LocalBridgeClazz, "IMAGE_INCOMPATIBLE"); _IMAGE_INCOMPATIBLEReady = true; } return _IMAGE_INCOMPATIBLEContent; } }
        private static int _IMAGE_INCOMPATIBLEContent = default;
        private static bool _IMAGE_INCOMPATIBLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/VolatileImage.html#IMAGE_OK"/>
        /// </summary>
        public static int IMAGE_OK { get { if (!_IMAGE_OKReady) { _IMAGE_OKContent = SGetField<int>(LocalBridgeClazz, "IMAGE_OK"); _IMAGE_OKReady = true; } return _IMAGE_OKContent; } }
        private static int _IMAGE_OKContent = default;
        private static bool _IMAGE_OKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/VolatileImage.html#IMAGE_RESTORED"/>
        /// </summary>
        public static int IMAGE_RESTORED { get { if (!_IMAGE_RESTOREDReady) { _IMAGE_RESTOREDContent = SGetField<int>(LocalBridgeClazz, "IMAGE_RESTORED"); _IMAGE_RESTOREDReady = true; } return _IMAGE_RESTOREDContent; } }
        private static int _IMAGE_RESTOREDContent = default;
        private static bool _IMAGE_RESTOREDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/VolatileImage.html#getCapabilities()"/> 
        /// </summary>
        public Java.Awt.ImageCapabilities Capabilities
        {
            get { return IExecuteWithSignature<Java.Awt.ImageCapabilities>("getCapabilities", "()Ljava/awt/ImageCapabilities;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/VolatileImage.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecuteWithSignature<int>("getHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/VolatileImage.html#getSnapshot()"/> 
        /// </summary>
        public Java.Awt.ImageNs.BufferedImage Snapshot
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>("getSnapshot", "()Ljava/awt/image/BufferedImage;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/VolatileImage.html#getTransparency()"/> 
        /// </summary>
        public int Transparency
        {
            get { return IExecuteWithSignature<int>("getTransparency", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/VolatileImage.html#getWidth()"/> 
        /// </summary>
        public int Width
        {
            get { return IExecuteWithSignature<int>("getWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/VolatileImage.html#contentsLost()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ContentsLost()
        {
            return IExecuteWithSignature<bool>("contentsLost", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/VolatileImage.html#validate(java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        /// <returns><see cref="int"/></returns>
        public int Validate(Java.Awt.GraphicsConfiguration arg0)
        {
            return IExecuteWithSignature<int>("validate", "(Ljava/awt/GraphicsConfiguration;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/VolatileImage.html#createGraphics()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.Graphics2D"/></returns>
        public Java.Awt.Graphics2D CreateGraphics()
        {
            return IExecuteWithSignature<Java.Awt.Graphics2D>("createGraphics", "()Ljava/awt/Graphics2D;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}