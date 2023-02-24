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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region Robot
    public partial class Robot
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#%3Cinit%3E(java.awt.GraphicsDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsDevice"/></param>
        /// <exception cref="Java.Awt.AWTException"/>
        public Robot(Java.Awt.GraphicsDevice arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#getAutoDelay()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#setAutoDelay(int)"/>
        /// </summary>
        public int AutoDelay
        {
            get { return IExecute<int>("getAutoDelay"); } set { IExecute("setAutoDelay", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#isAutoWaitForIdle()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsAutoWaitForIdle()
        {
            return IExecute<bool>("isAutoWaitForIdle");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#getPixelColor(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetPixelColor(int arg0, int arg1)
        {
            return IExecute<Java.Awt.Color>("getPixelColor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#createScreenCapture(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage CreateScreenCapture(Java.Awt.Rectangle arg0)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("createScreenCapture", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#createMultiResolutionScreenCapture(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.MultiResolutionImage"/></returns>
        public Java.Awt.ImageNs.MultiResolutionImage CreateMultiResolutionScreenCapture(Java.Awt.Rectangle arg0)
        {
            return IExecute<Java.Awt.ImageNs.MultiResolutionImage>("createMultiResolutionScreenCapture", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#delay(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        public void Delay(int arg0)
        {
            IExecute("delay", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#keyPress(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        public void KeyPress(int arg0)
        {
            IExecute("keyPress", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#keyRelease(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        public void KeyRelease(int arg0)
        {
            IExecute("keyRelease", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#mouseMove(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        public void MouseMove(int arg0, int arg1)
        {
            IExecute("mouseMove", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#mousePress(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        public void MousePress(int arg0)
        {
            IExecute("mousePress", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#mouseRelease(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        public void MouseRelease(int arg0)
        {
            IExecute("mouseRelease", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#mouseWheel(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        public void MouseWheel(int arg0)
        {
            IExecute("mouseWheel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#setAutoWaitForIdle(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see langword="bool"/></param>
        public void SetAutoWaitForIdle(bool arg0)
        {
            IExecute("setAutoWaitForIdle", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#waitForIdle()"/>
        /// </summary>
        public void WaitForIdle()
        {
            IExecute("waitForIdle");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}