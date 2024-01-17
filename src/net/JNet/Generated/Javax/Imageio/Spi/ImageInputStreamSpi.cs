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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Spi
{
    #region ImageInputStreamSpi
    public partial class ImageInputStreamSpi
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageInputStreamSpi.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        public ImageInputStreamSpi(string arg0, string arg1, Java.Lang.Class arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageInputStreamSpi.html#getInputClass()"/> 
        /// </summary>
        public Java.Lang.Class InputClass
        {
            get { return IExecute<Java.Lang.Class>("getInputClass"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageInputStreamSpi.html#createInputStreamInstance(java.lang.Object,boolean,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Imageio.Stream.ImageInputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Imageio.Stream.ImageInputStream CreateInputStreamInstance(object arg0, bool arg1, Java.Io.File arg2)
        {
            return IExecute<Javax.Imageio.Stream.ImageInputStream>("createInputStreamInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageInputStreamSpi.html#canUseCacheFile()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool CanUseCacheFile()
        {
            return IExecute<bool>("canUseCacheFile");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageInputStreamSpi.html#needsCacheFile()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool NeedsCacheFile()
        {
            return IExecute<bool>("needsCacheFile");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageInputStreamSpi.html#createInputStreamInstance(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Imageio.Stream.ImageInputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Imageio.Stream.ImageInputStream CreateInputStreamInstance(object arg0)
        {
            return IExecute<Javax.Imageio.Stream.ImageInputStream>("createInputStreamInstance", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}