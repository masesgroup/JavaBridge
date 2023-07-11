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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Plugins.Jpeg
{
    #region JPEGQTable
    public partial class JPEGQTable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGQTable.html#%3Cinit%3E(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public JPEGQTable(int[] arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGQTable.html#K1Div2Luminance"/>
        /// </summary>
        public static Javax.Imageio.Plugins.Jpeg.JPEGQTable K1Div2Luminance { get { return SGetField<Javax.Imageio.Plugins.Jpeg.JPEGQTable>(LocalBridgeClazz, "K1Div2Luminance"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGQTable.html#K1Luminance"/>
        /// </summary>
        public static Javax.Imageio.Plugins.Jpeg.JPEGQTable K1Luminance { get { return SGetField<Javax.Imageio.Plugins.Jpeg.JPEGQTable>(LocalBridgeClazz, "K1Luminance"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGQTable.html#K2Chrominance"/>
        /// </summary>
        public static Javax.Imageio.Plugins.Jpeg.JPEGQTable K2Chrominance { get { return SGetField<Javax.Imageio.Plugins.Jpeg.JPEGQTable>(LocalBridgeClazz, "K2Chrominance"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGQTable.html#K2Div2Chrominance"/>
        /// </summary>
        public static Javax.Imageio.Plugins.Jpeg.JPEGQTable K2Div2Chrominance { get { return SGetField<Javax.Imageio.Plugins.Jpeg.JPEGQTable>(LocalBridgeClazz, "K2Div2Chrominance"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGQTable.html#getTable()"/> 
        /// </summary>
        public int[] Table
        {
            get { return IExecuteArray<int>("getTable"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGQTable.html#getScaledInstance(float,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Imageio.Plugins.Jpeg.JPEGQTable"/></returns>
        public Javax.Imageio.Plugins.Jpeg.JPEGQTable GetScaledInstance(float arg0, bool arg1)
        {
            return IExecute<Javax.Imageio.Plugins.Jpeg.JPEGQTable>("getScaledInstance", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}