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

namespace Javax.Sound.Sampled
{
    #region IClip
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IClip : Javax.Sound.Sampled.IDataLine
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#getFrameLength()"/> 
        /// </summary>
        int FrameLength { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#getMicrosecondLength()"/> 
        /// </summary>
        long MicrosecondLength { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#loop(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        void Loop(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#open(javax.sound.sampled.AudioFormat,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        void Open(Javax.Sound.Sampled.AudioFormat arg0, byte[] arg1, int arg2, int arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#open(javax.sound.sampled.AudioInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        /// <exception cref="Java.Io.IOException"/>
        void Open(Javax.Sound.Sampled.AudioInputStream arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#setFramePosition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        void SetFramePosition(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#setLoopPoints(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void SetLoopPoints(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#setMicrosecondPosition(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        void SetMicrosecondPosition(long arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Clip
    public partial class Clip : Javax.Sound.Sampled.IClip
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#LOOP_CONTINUOUSLY"/>
        /// </summary>
        public static int LOOP_CONTINUOUSLY { get { if (!_LOOP_CONTINUOUSLYReady) { _LOOP_CONTINUOUSLYContent = SGetField<int>(LocalBridgeClazz, "LOOP_CONTINUOUSLY"); _LOOP_CONTINUOUSLYReady = true; } return _LOOP_CONTINUOUSLYContent; } }
        private static int _LOOP_CONTINUOUSLYContent = default;
        private static bool _LOOP_CONTINUOUSLYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#getFrameLength()"/> 
        /// </summary>
        public int FrameLength
        {
            get { return IExecuteWithSignature<int>("getFrameLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#getMicrosecondLength()"/> 
        /// </summary>
        public long MicrosecondLength
        {
            get { return IExecuteWithSignature<long>("getMicrosecondLength", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#loop(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Loop(int arg0)
        {
            IExecuteWithSignature("loop", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#open(javax.sound.sampled.AudioFormat,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        public void Open(Javax.Sound.Sampled.AudioFormat arg0, byte[] arg1, int arg2, int arg3)
        {
            IExecute("open", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#open(javax.sound.sampled.AudioInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void Open(Javax.Sound.Sampled.AudioInputStream arg0)
        {
            IExecuteWithSignature("open", "(Ljavax/sound/sampled/AudioInputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#setFramePosition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetFramePosition(int arg0)
        {
            IExecuteWithSignature("setFramePosition", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#setLoopPoints(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLoopPoints(int arg0, int arg1)
        {
            IExecute("setLoopPoints", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#setMicrosecondPosition(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetMicrosecondPosition(long arg0)
        {
            IExecuteWithSignature("setMicrosecondPosition", "(J)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}