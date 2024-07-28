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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region DisplayMode
    public partial class DisplayMode
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/DisplayMode.html#%3Cinit%3E(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public DisplayMode(int arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/DisplayMode.html#BIT_DEPTH_MULTI"/>
        /// </summary>
        public static int BIT_DEPTH_MULTI { get { if (!_BIT_DEPTH_MULTIReady) { _BIT_DEPTH_MULTIContent = SGetField<int>(LocalBridgeClazz, "BIT_DEPTH_MULTI"); _BIT_DEPTH_MULTIReady = true; } return _BIT_DEPTH_MULTIContent; } }
        private static int _BIT_DEPTH_MULTIContent = default;
        private static bool _BIT_DEPTH_MULTIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/DisplayMode.html#REFRESH_RATE_UNKNOWN"/>
        /// </summary>
        public static int REFRESH_RATE_UNKNOWN { get { if (!_REFRESH_RATE_UNKNOWNReady) { _REFRESH_RATE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "REFRESH_RATE_UNKNOWN"); _REFRESH_RATE_UNKNOWNReady = true; } return _REFRESH_RATE_UNKNOWNContent; } }
        private static int _REFRESH_RATE_UNKNOWNContent = default;
        private static bool _REFRESH_RATE_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/DisplayMode.html#getBitDepth()"/> 
        /// </summary>
        public int BitDepth
        {
            get { return IExecuteWithSignature<int>("getBitDepth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/DisplayMode.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecuteWithSignature<int>("getHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/DisplayMode.html#getRefreshRate()"/> 
        /// </summary>
        public int RefreshRate
        {
            get { return IExecuteWithSignature<int>("getRefreshRate", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/DisplayMode.html#getWidth()"/> 
        /// </summary>
        public int Width
        {
            get { return IExecuteWithSignature<int>("getWidth", "()I"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}