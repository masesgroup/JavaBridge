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

namespace Javax.Sound.Sampled.Spi
{
    #region AudioFileReader
    public partial class AudioFileReader
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileReader.html#getAudioFileFormat(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Sampled.AudioFileFormat GetAudioFileFormat(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Sampled.AudioFileFormat>("getAudioFileFormat", "(Ljava/io/File;)Ljavax/sound/sampled/AudioFileFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileReader.html#getAudioFileFormat(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Sampled.AudioFileFormat GetAudioFileFormat(Java.Io.InputStream arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Sampled.AudioFileFormat>("getAudioFileFormat", "(Ljava/io/InputStream;)Ljavax/sound/sampled/AudioFileFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileReader.html#getAudioFileFormat(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Sampled.AudioFileFormat GetAudioFileFormat(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Sampled.AudioFileFormat>("getAudioFileFormat", "(Ljava/net/URL;)Ljavax/sound/sampled/AudioFileFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileReader.html#getAudioInputStream(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioInputStream"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Sampled.AudioInputStream GetAudioInputStream(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Sampled.AudioInputStream>("getAudioInputStream", "(Ljava/io/File;)Ljavax/sound/sampled/AudioInputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileReader.html#getAudioInputStream(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioInputStream"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Sampled.AudioInputStream GetAudioInputStream(Java.Io.InputStream arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Sampled.AudioInputStream>("getAudioInputStream", "(Ljava/io/InputStream;)Ljavax/sound/sampled/AudioInputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileReader.html#getAudioInputStream(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioInputStream"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Sampled.AudioInputStream GetAudioInputStream(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Sampled.AudioInputStream>("getAudioInputStream", "(Ljava/net/URL;)Ljavax/sound/sampled/AudioInputStream;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}