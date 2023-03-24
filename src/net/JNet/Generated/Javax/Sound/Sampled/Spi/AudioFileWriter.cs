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

namespace Javax.Sound.Sampled.Spi
{
    #region AudioFileWriter
    public partial class AudioFileWriter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileWriter.html#getAudioFileTypes()"/> 
        /// </summary>
        public Javax.Sound.Sampled.AudioFileFormat.Type[] AudioFileTypes
        {
            get { return IExecuteArray<Javax.Sound.Sampled.AudioFileFormat.Type>("getAudioFileTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileWriter.html#write(javax.sound.sampled.AudioInputStream,javax.sound.sampled.AudioFileFormat$Type,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFileFormat.Type"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Write(Javax.Sound.Sampled.AudioInputStream arg0, Javax.Sound.Sampled.AudioFileFormat.Type arg1, Java.Io.File arg2)
        {
            return IExecute<int>("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileWriter.html#write(javax.sound.sampled.AudioInputStream,javax.sound.sampled.AudioFileFormat$Type,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFileFormat.Type"/></param>
        /// <param name="arg2"><see cref="Java.Io.OutputStream"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Write(Javax.Sound.Sampled.AudioInputStream arg0, Javax.Sound.Sampled.AudioFileFormat.Type arg1, Java.Io.OutputStream arg2)
        {
            return IExecute<int>("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileWriter.html#getAudioFileTypes(javax.sound.sampled.AudioInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFileFormat.Type"/></returns>
        public Javax.Sound.Sampled.AudioFileFormat.Type[] GetAudioFileTypes(Javax.Sound.Sampled.AudioInputStream arg0)
        {
            return IExecuteArray<Javax.Sound.Sampled.AudioFileFormat.Type>("getAudioFileTypes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileWriter.html#isFileTypeSupported(javax.sound.sampled.AudioFileFormat$Type,javax.sound.sampled.AudioInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFileFormat.Type"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsFileTypeSupported(Javax.Sound.Sampled.AudioFileFormat.Type arg0, Javax.Sound.Sampled.AudioInputStream arg1)
        {
            return IExecute<bool>("isFileTypeSupported", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileWriter.html#isFileTypeSupported(javax.sound.sampled.AudioFileFormat$Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFileFormat.Type"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsFileTypeSupported(Javax.Sound.Sampled.AudioFileFormat.Type arg0)
        {
            return IExecute<bool>("isFileTypeSupported", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}