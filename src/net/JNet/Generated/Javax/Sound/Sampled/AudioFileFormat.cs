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

namespace Javax.Sound.Sampled
{
    #region AudioFileFormat
    public partial class AudioFileFormat
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFileFormat.html#%3Cinit%3E(javax.sound.sampled.AudioFileFormat$Type,javax.sound.sampled.AudioFormat,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFileFormat.Type"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        public AudioFileFormat(Javax.Sound.Sampled.AudioFileFormat.Type arg0, Javax.Sound.Sampled.AudioFormat arg1, int arg2)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFileFormat.html#getByteLength()"/> 
        /// </summary>
        public int ByteLength
        {
            get { return IExecute<int>("getByteLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFileFormat.html#getFormat()"/> 
        /// </summary>
        public Javax.Sound.Sampled.AudioFormat Format
        {
            get { return IExecute<Javax.Sound.Sampled.AudioFormat>("getFormat"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFileFormat.html#getFrameLength()"/> 
        /// </summary>
        public int FrameLength
        {
            get { return IExecute<int>("getFrameLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFileFormat.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see langword="object"/></returns>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFileFormat.html#getType()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Sound.Sampled.AudioFileFormat.Type"/></returns>
        public Javax.Sound.Sampled.AudioFileFormat.Type GetType()
        {
            return IExecute<Javax.Sound.Sampled.AudioFileFormat.Type>("getType");
        }
        
        #endregion

        #region Nested classes
        #region Type
        public partial class Type
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFileFormat.Type.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see langword="string"/></param>
            /// <param name="arg1"><see langword="string"/></param>
            public Type(string arg0, string arg1)
                : base(arg0, arg1)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFileFormat.Type.html#AIFC"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFileFormat.Type AIFC => Clazz.GetField<Javax.Sound.Sampled.AudioFileFormat.Type>("AIFC");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFileFormat.Type.html#AIFF"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFileFormat.Type AIFF => Clazz.GetField<Javax.Sound.Sampled.AudioFileFormat.Type>("AIFF");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFileFormat.Type.html#AU"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFileFormat.Type AU => Clazz.GetField<Javax.Sound.Sampled.AudioFileFormat.Type>("AU");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFileFormat.Type.html#SND"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFileFormat.Type SND => Clazz.GetField<Javax.Sound.Sampled.AudioFileFormat.Type>("SND");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFileFormat.Type.html#WAVE"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFileFormat.Type WAVE => Clazz.GetField<Javax.Sound.Sampled.AudioFileFormat.Type>("WAVE");
            
            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFileFormat.Type.html#getExtension()"/> 
            /// </summary>
            public string Extension
            {
                get { return IExecute<string>("getExtension"); }
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}