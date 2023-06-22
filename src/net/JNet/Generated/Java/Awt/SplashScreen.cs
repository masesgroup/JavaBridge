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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region SplashScreen
    public partial class SplashScreen
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SplashScreen.html#getSplashScreen()"/> 
        /// </summary>
        public static Java.Awt.SplashScreen GetSplashScreen
        {
            get { return SExecute<Java.Awt.SplashScreen>(LocalBridgeClazz, "getSplashScreen"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SplashScreen.html#getBounds()"/> 
        /// </summary>
        public Java.Awt.Rectangle Bounds
        {
            get { return IExecute<Java.Awt.Rectangle>("getBounds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SplashScreen.html#getImageURL()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SplashScreen.html#setImageURL(java.net.URL)"/>
        /// </summary>
        public Java.Net.URL ImageURL
        {
            get { return IExecute<Java.Net.URL>("getImageURL"); } set { IExecute("setImageURL", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SplashScreen.html#getSize()"/> 
        /// </summary>
        public Java.Awt.Dimension Size
        {
            get { return IExecute<Java.Awt.Dimension>("getSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SplashScreen.html#isVisible()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsVisible()
        {
            return IExecute<bool>("isVisible");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SplashScreen.html#createGraphics()"/>
        /// </summary>

        /// <returns><see cref="Java.Awt.Graphics2D"/></returns>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public Java.Awt.Graphics2D CreateGraphics()
        {
            return IExecute<Java.Awt.Graphics2D>("createGraphics");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SplashScreen.html#close()"/>
        /// </summary>

        /// <exception cref="Java.Lang.IllegalStateException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SplashScreen.html#update()"/>
        /// </summary>

        /// <exception cref="Java.Lang.IllegalStateException"/>
        public void Update()
        {
            IExecute("update");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}