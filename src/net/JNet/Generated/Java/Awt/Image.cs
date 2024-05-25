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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region Image
    public partial class Image
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#SCALE_AREA_AVERAGING"/>
        /// </summary>
        public static int SCALE_AREA_AVERAGING { get { if (!_SCALE_AREA_AVERAGINGReady) { _SCALE_AREA_AVERAGINGContent = SGetField<int>(LocalBridgeClazz, "SCALE_AREA_AVERAGING"); _SCALE_AREA_AVERAGINGReady = true; } return _SCALE_AREA_AVERAGINGContent; } }
        private static int _SCALE_AREA_AVERAGINGContent = default;
        private static bool _SCALE_AREA_AVERAGINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#SCALE_DEFAULT"/>
        /// </summary>
        public static int SCALE_DEFAULT { get { if (!_SCALE_DEFAULTReady) { _SCALE_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "SCALE_DEFAULT"); _SCALE_DEFAULTReady = true; } return _SCALE_DEFAULTContent; } }
        private static int _SCALE_DEFAULTContent = default;
        private static bool _SCALE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#SCALE_FAST"/>
        /// </summary>
        public static int SCALE_FAST { get { if (!_SCALE_FASTReady) { _SCALE_FASTContent = SGetField<int>(LocalBridgeClazz, "SCALE_FAST"); _SCALE_FASTReady = true; } return _SCALE_FASTContent; } }
        private static int _SCALE_FASTContent = default;
        private static bool _SCALE_FASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#SCALE_REPLICATE"/>
        /// </summary>
        public static int SCALE_REPLICATE { get { if (!_SCALE_REPLICATEReady) { _SCALE_REPLICATEContent = SGetField<int>(LocalBridgeClazz, "SCALE_REPLICATE"); _SCALE_REPLICATEReady = true; } return _SCALE_REPLICATEContent; } }
        private static int _SCALE_REPLICATEContent = default;
        private static bool _SCALE_REPLICATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#SCALE_SMOOTH"/>
        /// </summary>
        public static int SCALE_SMOOTH { get { if (!_SCALE_SMOOTHReady) { _SCALE_SMOOTHContent = SGetField<int>(LocalBridgeClazz, "SCALE_SMOOTH"); _SCALE_SMOOTHReady = true; } return _SCALE_SMOOTHContent; } }
        private static int _SCALE_SMOOTHContent = default;
        private static bool _SCALE_SMOOTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#UndefinedProperty"/>
        /// </summary>
        public static object UndefinedProperty { get { if (!_UndefinedPropertyReady) { _UndefinedPropertyContent = SGetField(LocalBridgeClazz, "UndefinedProperty"); _UndefinedPropertyReady = true; } return _UndefinedPropertyContent; } }
        private static object _UndefinedPropertyContent = default;
        private static bool _UndefinedPropertyReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getAccelerationPriority()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#setAccelerationPriority(float)"/>
        /// </summary>
        public float AccelerationPriority
        {
            get { return IExecuteWithSignature<float>("getAccelerationPriority", "()F"); } set { IExecuteWithSignature("setAccelerationPriority", "(F)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getGraphics()"/> 
        /// </summary>
        public Java.Awt.Graphics Graphics
        {
            get { return IExecuteWithSignature<Java.Awt.Graphics>("getGraphics", "()Ljava/awt/Graphics;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getSource()"/> 
        /// </summary>
        public Java.Awt.ImageNs.ImageProducer Source
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.ImageProducer>("getSource", "()Ljava/awt/image/ImageProducer;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getHeight(java.awt.image.ImageObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageObserver"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetHeight(Java.Awt.ImageNs.ImageObserver arg0)
        {
            return IExecuteWithSignature<int>("getHeight", "(Ljava/awt/image/ImageObserver;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getWidth(java.awt.image.ImageObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageObserver"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetWidth(Java.Awt.ImageNs.ImageObserver arg0)
        {
            return IExecuteWithSignature<int>("getWidth", "(Ljava/awt/image/ImageObserver;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getProperty(java.lang.String,java.awt.image.ImageObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.ImageObserver"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(Java.Lang.String arg0, Java.Awt.ImageNs.ImageObserver arg1)
        {
            return IExecute("getProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getScaledInstance(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image GetScaledInstance(int arg0, int arg1, int arg2)
        {
            return IExecute<Java.Awt.Image>("getScaledInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getCapabilities(java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        /// <returns><see cref="Java.Awt.ImageCapabilities"/></returns>
        public Java.Awt.ImageCapabilities GetCapabilities(Java.Awt.GraphicsConfiguration arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageCapabilities>("getCapabilities", "(Ljava/awt/GraphicsConfiguration;)Ljava/awt/ImageCapabilities;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}