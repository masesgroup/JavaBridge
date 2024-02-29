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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Plugins.Jpeg
{
    #region JPEGHuffmanTable
    public partial class JPEGHuffmanTable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGHuffmanTable.html#%3Cinit%3E(short[],short[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        public JPEGHuffmanTable(short[] arg0, short[] arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGHuffmanTable.html#StdACChrominance"/>
        /// </summary>
        public static Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable StdACChrominance { get { if (!_StdACChrominanceReady) { _StdACChrominanceContent = SGetField<Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable>(LocalBridgeClazz, "StdACChrominance"); _StdACChrominanceReady = true; } return _StdACChrominanceContent; } }
        private static Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable _StdACChrominanceContent = default;
        private static bool _StdACChrominanceReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGHuffmanTable.html#StdACLuminance"/>
        /// </summary>
        public static Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable StdACLuminance { get { if (!_StdACLuminanceReady) { _StdACLuminanceContent = SGetField<Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable>(LocalBridgeClazz, "StdACLuminance"); _StdACLuminanceReady = true; } return _StdACLuminanceContent; } }
        private static Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable _StdACLuminanceContent = default;
        private static bool _StdACLuminanceReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGHuffmanTable.html#StdDCChrominance"/>
        /// </summary>
        public static Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable StdDCChrominance { get { if (!_StdDCChrominanceReady) { _StdDCChrominanceContent = SGetField<Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable>(LocalBridgeClazz, "StdDCChrominance"); _StdDCChrominanceReady = true; } return _StdDCChrominanceContent; } }
        private static Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable _StdDCChrominanceContent = default;
        private static bool _StdDCChrominanceReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGHuffmanTable.html#StdDCLuminance"/>
        /// </summary>
        public static Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable StdDCLuminance { get { if (!_StdDCLuminanceReady) { _StdDCLuminanceContent = SGetField<Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable>(LocalBridgeClazz, "StdDCLuminance"); _StdDCLuminanceReady = true; } return _StdDCLuminanceContent; } }
        private static Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable _StdDCLuminanceContent = default;
        private static bool _StdDCLuminanceReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGHuffmanTable.html#getLengths()"/> 
        /// </summary>
        public short[] Lengths
        {
            get { return IExecuteWithSignatureArray<short>("getLengths", "()[S"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGHuffmanTable.html#getValues()"/> 
        /// </summary>
        public short[] Values
        {
            get { return IExecuteWithSignatureArray<short>("getValues", "()[S"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}