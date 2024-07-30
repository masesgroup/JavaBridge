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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region GraphicsDevice
    public partial class GraphicsDevice
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#TYPE_IMAGE_BUFFER"/>
        /// </summary>
        public static int TYPE_IMAGE_BUFFER { get { if (!_TYPE_IMAGE_BUFFERReady) { _TYPE_IMAGE_BUFFERContent = SGetField<int>(LocalBridgeClazz, "TYPE_IMAGE_BUFFER"); _TYPE_IMAGE_BUFFERReady = true; } return _TYPE_IMAGE_BUFFERContent; } }
        private static int _TYPE_IMAGE_BUFFERContent = default;
        private static bool _TYPE_IMAGE_BUFFERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#TYPE_PRINTER"/>
        /// </summary>
        public static int TYPE_PRINTER { get { if (!_TYPE_PRINTERReady) { _TYPE_PRINTERContent = SGetField<int>(LocalBridgeClazz, "TYPE_PRINTER"); _TYPE_PRINTERReady = true; } return _TYPE_PRINTERContent; } }
        private static int _TYPE_PRINTERContent = default;
        private static bool _TYPE_PRINTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#TYPE_RASTER_SCREEN"/>
        /// </summary>
        public static int TYPE_RASTER_SCREEN { get { if (!_TYPE_RASTER_SCREENReady) { _TYPE_RASTER_SCREENContent = SGetField<int>(LocalBridgeClazz, "TYPE_RASTER_SCREEN"); _TYPE_RASTER_SCREENReady = true; } return _TYPE_RASTER_SCREENContent; } }
        private static int _TYPE_RASTER_SCREENContent = default;
        private static bool _TYPE_RASTER_SCREENReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getAvailableAcceleratedMemory()"/> 
        /// </summary>
        public int AvailableAcceleratedMemory
        {
            get { return IExecuteWithSignature<int>("getAvailableAcceleratedMemory", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getConfigurations()"/> 
        /// </summary>
        public Java.Awt.GraphicsConfiguration[] Configurations
        {
            get { return IExecuteWithSignatureArray<Java.Awt.GraphicsConfiguration>("getConfigurations", "()[Ljava/awt/GraphicsConfiguration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getDefaultConfiguration()"/> 
        /// </summary>
        public Java.Awt.GraphicsConfiguration DefaultConfiguration
        {
            get { return IExecuteWithSignature<Java.Awt.GraphicsConfiguration>("getDefaultConfiguration", "()Ljava/awt/GraphicsConfiguration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getDisplayMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#setDisplayMode(java.awt.DisplayMode)"/>
        /// </summary>
        public Java.Awt.DisplayMode DisplayMode
        {
            get { return IExecuteWithSignature<Java.Awt.DisplayMode>("getDisplayMode", "()Ljava/awt/DisplayMode;"); } set { IExecuteWithSignature("setDisplayMode", "(Ljava/awt/DisplayMode;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getDisplayModes()"/> 
        /// </summary>
        public Java.Awt.DisplayMode[] DisplayModes
        {
            get { return IExecuteWithSignatureArray<Java.Awt.DisplayMode>("getDisplayModes", "()[Ljava/awt/DisplayMode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getFullScreenWindow()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#setFullScreenWindow(java.awt.Window)"/>
        /// </summary>
        public Java.Awt.Window FullScreenWindow
        {
            get { return IExecuteWithSignature<Java.Awt.Window>("getFullScreenWindow", "()Ljava/awt/Window;"); } set { IExecuteWithSignature("setFullScreenWindow", "(Ljava/awt/Window;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getIDstring()"/> 
        /// </summary>
        public Java.Lang.String IDstring
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getIDstring", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#isDisplayChangeSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDisplayChangeSupported()
        {
            return IExecuteWithSignature<bool>("isDisplayChangeSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#isFullScreenSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFullScreenSupported()
        {
            return IExecuteWithSignature<bool>("isFullScreenSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#isWindowTranslucencySupported(java.awt.GraphicsDevice.WindowTranslucency)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsDevice.WindowTranslucency"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsWindowTranslucencySupported(Java.Awt.GraphicsDevice.WindowTranslucency arg0)
        {
            return IExecuteWithSignature<bool>("isWindowTranslucencySupported", "(Ljava/awt/GraphicsDevice$WindowTranslucency;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getBestConfiguration(java.awt.GraphicsConfigTemplate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsConfigTemplate"/></param>
        /// <returns><see cref="Java.Awt.GraphicsConfiguration"/></returns>
        public Java.Awt.GraphicsConfiguration GetBestConfiguration(Java.Awt.GraphicsConfigTemplate arg0)
        {
            return IExecuteWithSignature<Java.Awt.GraphicsConfiguration>("getBestConfiguration", "(Ljava/awt/GraphicsConfigTemplate;)Ljava/awt/GraphicsConfiguration;", arg0);
        }

        #endregion

        #region Nested classes
        #region WindowTranslucency
        public partial class WindowTranslucency
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.WindowTranslucency.html#PERPIXEL_TRANSLUCENT"/>
            /// </summary>
            public static Java.Awt.GraphicsDevice.WindowTranslucency PERPIXEL_TRANSLUCENT { get { if (!_PERPIXEL_TRANSLUCENTReady) { _PERPIXEL_TRANSLUCENTContent = SGetField<Java.Awt.GraphicsDevice.WindowTranslucency>(LocalBridgeClazz, "PERPIXEL_TRANSLUCENT"); _PERPIXEL_TRANSLUCENTReady = true; } return _PERPIXEL_TRANSLUCENTContent; } }
            private static Java.Awt.GraphicsDevice.WindowTranslucency _PERPIXEL_TRANSLUCENTContent = default;
            private static bool _PERPIXEL_TRANSLUCENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.WindowTranslucency.html#PERPIXEL_TRANSPARENT"/>
            /// </summary>
            public static Java.Awt.GraphicsDevice.WindowTranslucency PERPIXEL_TRANSPARENT { get { if (!_PERPIXEL_TRANSPARENTReady) { _PERPIXEL_TRANSPARENTContent = SGetField<Java.Awt.GraphicsDevice.WindowTranslucency>(LocalBridgeClazz, "PERPIXEL_TRANSPARENT"); _PERPIXEL_TRANSPARENTReady = true; } return _PERPIXEL_TRANSPARENTContent; } }
            private static Java.Awt.GraphicsDevice.WindowTranslucency _PERPIXEL_TRANSPARENTContent = default;
            private static bool _PERPIXEL_TRANSPARENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.WindowTranslucency.html#TRANSLUCENT"/>
            /// </summary>
            public static Java.Awt.GraphicsDevice.WindowTranslucency TRANSLUCENT { get { if (!_TRANSLUCENTReady) { _TRANSLUCENTContent = SGetField<Java.Awt.GraphicsDevice.WindowTranslucency>(LocalBridgeClazz, "TRANSLUCENT"); _TRANSLUCENTReady = true; } return _TRANSLUCENTContent; } }
            private static Java.Awt.GraphicsDevice.WindowTranslucency _TRANSLUCENTContent = default;
            private static bool _TRANSLUCENTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.WindowTranslucency.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Awt.GraphicsDevice.WindowTranslucency"/></returns>
            public static Java.Awt.GraphicsDevice.WindowTranslucency ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Awt.GraphicsDevice.WindowTranslucency>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/awt/GraphicsDevice$WindowTranslucency;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.WindowTranslucency.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Awt.GraphicsDevice.WindowTranslucency"/></returns>
            public static Java.Awt.GraphicsDevice.WindowTranslucency[] Values()
            {
                return SExecuteWithSignatureArray<Java.Awt.GraphicsDevice.WindowTranslucency>(LocalBridgeClazz, "values", "()[Ljava/awt/GraphicsDevice$WindowTranslucency;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}