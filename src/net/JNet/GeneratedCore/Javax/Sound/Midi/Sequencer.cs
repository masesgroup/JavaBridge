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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Midi
{
    #region ISequencer
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISequencer : Javax.Sound.Midi.IMidiDevice
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getLoopCount()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setLoopCount(int)"/>
        /// </summary>
        int LoopCount { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getLoopEndPoint()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setLoopEndPoint(long)"/>
        /// </summary>
        long LoopEndPoint { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getLoopStartPoint()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setLoopStartPoint(long)"/>
        /// </summary>
        long LoopStartPoint { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getMasterSyncMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setMasterSyncMode(javax.sound.midi.Sequencer.SyncMode)"/>
        /// </summary>
        Javax.Sound.Midi.Sequencer.SyncMode MasterSyncMode { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getMasterSyncModes()"/> 
        /// </summary>
        Javax.Sound.Midi.Sequencer.SyncMode[] MasterSyncModes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getMicrosecondLength()"/> 
        /// </summary>
        long MicrosecondLength { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getMicrosecondPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setMicrosecondPosition(long)"/>
        /// </summary>
        long MicrosecondPosition { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getSequence()"/> 
        /// </summary>
        Javax.Sound.Midi.Sequence Sequence { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getSlaveSyncMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setSlaveSyncMode(javax.sound.midi.Sequencer.SyncMode)"/>
        /// </summary>
        Javax.Sound.Midi.Sequencer.SyncMode SlaveSyncMode { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getSlaveSyncModes()"/> 
        /// </summary>
        Javax.Sound.Midi.Sequencer.SyncMode[] SlaveSyncModes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getTempoFactor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setTempoFactor(float)"/>
        /// </summary>
        float TempoFactor { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getTempoInBPM()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setTempoInBPM(float)"/>
        /// </summary>
        float TempoInBPM { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getTempoInMPQ()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setTempoInMPQ(float)"/>
        /// </summary>
        float TempoInMPQ { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getTickLength()"/> 
        /// </summary>
        long TickLength { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getTickPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setTickPosition(long)"/>
        /// </summary>
        long TickPosition { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#addMetaEventListener(javax.sound.midi.MetaEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.MetaEventListener"/></param>
        /// <returns><see cref="bool"/></returns>
        bool AddMetaEventListener(Javax.Sound.Midi.MetaEventListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getTrackMute(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool GetTrackMute(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getTrackSolo(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool GetTrackSolo(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#isRecording()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsRecording();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#isRunning()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsRunning();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#addControllerEventListener(javax.sound.midi.ControllerEventListener,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.ControllerEventListener"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        int[] AddControllerEventListener(Javax.Sound.Midi.ControllerEventListener arg0, int[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#removeControllerEventListener(javax.sound.midi.ControllerEventListener,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.ControllerEventListener"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        int[] RemoveControllerEventListener(Javax.Sound.Midi.ControllerEventListener arg0, int[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#recordDisable(javax.sound.midi.Track)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Track"/></param>
        void RecordDisable(Javax.Sound.Midi.Track arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#recordEnable(javax.sound.midi.Track,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Track"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void RecordEnable(Javax.Sound.Midi.Track arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#removeMetaEventListener(javax.sound.midi.MetaEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.MetaEventListener"/></param>
        void RemoveMetaEventListener(Javax.Sound.Midi.MetaEventListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setSequence(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        void SetSequence(Java.Io.InputStream arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setSequence(javax.sound.midi.Sequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Sequence"/></param>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        void SetSequence(Javax.Sound.Midi.Sequence arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setTrackMute(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        void SetTrackMute(int arg0, bool arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setTrackSolo(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        void SetTrackSolo(int arg0, bool arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#start()"/>
        /// </summary>
        void Start();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#startRecording()"/>
        /// </summary>
        void StartRecording();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#stop()"/>
        /// </summary>
        void Stop();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#stopRecording()"/>
        /// </summary>
        void StopRecording();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Sequencer
    public partial class Sequencer : Javax.Sound.Midi.ISequencer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#LOOP_CONTINUOUSLY"/>
        /// </summary>
        public static int LOOP_CONTINUOUSLY { get { if (!_LOOP_CONTINUOUSLYReady) { _LOOP_CONTINUOUSLYContent = SGetField<int>(LocalBridgeClazz, "LOOP_CONTINUOUSLY"); _LOOP_CONTINUOUSLYReady = true; } return _LOOP_CONTINUOUSLYContent; } }
        private static int _LOOP_CONTINUOUSLYContent = default;
        private static bool _LOOP_CONTINUOUSLYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getLoopCount()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setLoopCount(int)"/>
        /// </summary>
        public int LoopCount
        {
            get { return IExecuteWithSignature<int>("getLoopCount", "()I"); } set { IExecuteWithSignature("setLoopCount", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getLoopEndPoint()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setLoopEndPoint(long)"/>
        /// </summary>
        public long LoopEndPoint
        {
            get { return IExecuteWithSignature<long>("getLoopEndPoint", "()J"); } set { IExecuteWithSignature("setLoopEndPoint", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getLoopStartPoint()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setLoopStartPoint(long)"/>
        /// </summary>
        public long LoopStartPoint
        {
            get { return IExecuteWithSignature<long>("getLoopStartPoint", "()J"); } set { IExecuteWithSignature("setLoopStartPoint", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getMasterSyncMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setMasterSyncMode(javax.sound.midi.Sequencer.SyncMode)"/>
        /// </summary>
        public Javax.Sound.Midi.Sequencer.SyncMode MasterSyncMode
        {
            get { return IExecuteWithSignature<Javax.Sound.Midi.Sequencer.SyncMode>("getMasterSyncMode", "()Ljavax/sound/midi/Sequencer$SyncMode;"); } set { IExecuteWithSignature("setMasterSyncMode", "(Ljavax/sound/midi/Sequencer$SyncMode;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getMasterSyncModes()"/> 
        /// </summary>
        public Javax.Sound.Midi.Sequencer.SyncMode[] MasterSyncModes
        {
            get { return IExecuteWithSignatureArray<Javax.Sound.Midi.Sequencer.SyncMode>("getMasterSyncModes", "()[Ljavax/sound/midi/Sequencer$SyncMode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getMicrosecondLength()"/> 
        /// </summary>
        public long MicrosecondLength
        {
            get { return IExecuteWithSignature<long>("getMicrosecondLength", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getMicrosecondPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setMicrosecondPosition(long)"/>
        /// </summary>
        public long MicrosecondPosition
        {
            get { return IExecuteWithSignature<long>("getMicrosecondPosition", "()J"); } set { IExecuteWithSignature("setMicrosecondPosition", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getSequence()"/> 
        /// </summary>
        public Javax.Sound.Midi.Sequence Sequence
        {
            get { return IExecuteWithSignature<Javax.Sound.Midi.Sequence>("getSequence", "()Ljavax/sound/midi/Sequence;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getSlaveSyncMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setSlaveSyncMode(javax.sound.midi.Sequencer.SyncMode)"/>
        /// </summary>
        public Javax.Sound.Midi.Sequencer.SyncMode SlaveSyncMode
        {
            get { return IExecuteWithSignature<Javax.Sound.Midi.Sequencer.SyncMode>("getSlaveSyncMode", "()Ljavax/sound/midi/Sequencer$SyncMode;"); } set { IExecuteWithSignature("setSlaveSyncMode", "(Ljavax/sound/midi/Sequencer$SyncMode;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getSlaveSyncModes()"/> 
        /// </summary>
        public Javax.Sound.Midi.Sequencer.SyncMode[] SlaveSyncModes
        {
            get { return IExecuteWithSignatureArray<Javax.Sound.Midi.Sequencer.SyncMode>("getSlaveSyncModes", "()[Ljavax/sound/midi/Sequencer$SyncMode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getTempoFactor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setTempoFactor(float)"/>
        /// </summary>
        public float TempoFactor
        {
            get { return IExecuteWithSignature<float>("getTempoFactor", "()F"); } set { IExecuteWithSignature("setTempoFactor", "(F)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getTempoInBPM()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setTempoInBPM(float)"/>
        /// </summary>
        public float TempoInBPM
        {
            get { return IExecuteWithSignature<float>("getTempoInBPM", "()F"); } set { IExecuteWithSignature("setTempoInBPM", "(F)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getTempoInMPQ()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setTempoInMPQ(float)"/>
        /// </summary>
        public float TempoInMPQ
        {
            get { return IExecuteWithSignature<float>("getTempoInMPQ", "()F"); } set { IExecuteWithSignature("setTempoInMPQ", "(F)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getTickLength()"/> 
        /// </summary>
        public long TickLength
        {
            get { return IExecuteWithSignature<long>("getTickLength", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getTickPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setTickPosition(long)"/>
        /// </summary>
        public long TickPosition
        {
            get { return IExecuteWithSignature<long>("getTickPosition", "()J"); } set { IExecuteWithSignature("setTickPosition", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#addMetaEventListener(javax.sound.midi.MetaEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.MetaEventListener"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddMetaEventListener(Javax.Sound.Midi.MetaEventListener arg0)
        {
            return IExecuteWithSignature<bool>("addMetaEventListener", "(Ljavax/sound/midi/MetaEventListener;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getTrackMute(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetTrackMute(int arg0)
        {
            return IExecuteWithSignature<bool>("getTrackMute", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#getTrackSolo(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetTrackSolo(int arg0)
        {
            return IExecuteWithSignature<bool>("getTrackSolo", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#isRecording()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRecording()
        {
            return IExecuteWithSignature<bool>("isRecording", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#isRunning()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRunning()
        {
            return IExecuteWithSignature<bool>("isRunning", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#addControllerEventListener(javax.sound.midi.ControllerEventListener,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.ControllerEventListener"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] AddControllerEventListener(Javax.Sound.Midi.ControllerEventListener arg0, int[] arg1)
        {
            return IExecuteArray<int>("addControllerEventListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#removeControllerEventListener(javax.sound.midi.ControllerEventListener,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.ControllerEventListener"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] RemoveControllerEventListener(Javax.Sound.Midi.ControllerEventListener arg0, int[] arg1)
        {
            return IExecuteArray<int>("removeControllerEventListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#recordDisable(javax.sound.midi.Track)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Track"/></param>
        public void RecordDisable(Javax.Sound.Midi.Track arg0)
        {
            IExecuteWithSignature("recordDisable", "(Ljavax/sound/midi/Track;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#recordEnable(javax.sound.midi.Track,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Track"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RecordEnable(Javax.Sound.Midi.Track arg0, int arg1)
        {
            IExecute("recordEnable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#removeMetaEventListener(javax.sound.midi.MetaEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.MetaEventListener"/></param>
        public void RemoveMetaEventListener(Javax.Sound.Midi.MetaEventListener arg0)
        {
            IExecuteWithSignature("removeMetaEventListener", "(Ljavax/sound/midi/MetaEventListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setSequence(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        public void SetSequence(Java.Io.InputStream arg0)
        {
            IExecuteWithSignature("setSequence", "(Ljava/io/InputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setSequence(javax.sound.midi.Sequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Sequence"/></param>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        public void SetSequence(Javax.Sound.Midi.Sequence arg0)
        {
            IExecuteWithSignature("setSequence", "(Ljavax/sound/midi/Sequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setTrackMute(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetTrackMute(int arg0, bool arg1)
        {
            IExecute("setTrackMute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#setTrackSolo(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetTrackSolo(int arg0, bool arg1)
        {
            IExecute("setTrackSolo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#startRecording()"/>
        /// </summary>
        public void StartRecording()
        {
            IExecuteWithSignature("startRecording", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#stop()"/>
        /// </summary>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.html#stopRecording()"/>
        /// </summary>
        public void StopRecording()
        {
            IExecuteWithSignature("stopRecording", "()V");
        }

        #endregion

        #region Nested classes
        #region SyncMode
        public partial class SyncMode
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.SyncMode.html#INTERNAL_CLOCK"/>
            /// </summary>
            public static Javax.Sound.Midi.Sequencer.SyncMode INTERNAL_CLOCK { get { if (!_INTERNAL_CLOCKReady) { _INTERNAL_CLOCKContent = SGetField<Javax.Sound.Midi.Sequencer.SyncMode>(LocalBridgeClazz, "INTERNAL_CLOCK"); _INTERNAL_CLOCKReady = true; } return _INTERNAL_CLOCKContent; } }
            private static Javax.Sound.Midi.Sequencer.SyncMode _INTERNAL_CLOCKContent = default;
            private static bool _INTERNAL_CLOCKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.SyncMode.html#MIDI_SYNC"/>
            /// </summary>
            public static Javax.Sound.Midi.Sequencer.SyncMode MIDI_SYNC { get { if (!_MIDI_SYNCReady) { _MIDI_SYNCContent = SGetField<Javax.Sound.Midi.Sequencer.SyncMode>(LocalBridgeClazz, "MIDI_SYNC"); _MIDI_SYNCReady = true; } return _MIDI_SYNCContent; } }
            private static Javax.Sound.Midi.Sequencer.SyncMode _MIDI_SYNCContent = default;
            private static bool _MIDI_SYNCReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.SyncMode.html#MIDI_TIME_CODE"/>
            /// </summary>
            public static Javax.Sound.Midi.Sequencer.SyncMode MIDI_TIME_CODE { get { if (!_MIDI_TIME_CODEReady) { _MIDI_TIME_CODEContent = SGetField<Javax.Sound.Midi.Sequencer.SyncMode>(LocalBridgeClazz, "MIDI_TIME_CODE"); _MIDI_TIME_CODEReady = true; } return _MIDI_TIME_CODEContent; } }
            private static Javax.Sound.Midi.Sequencer.SyncMode _MIDI_TIME_CODEContent = default;
            private static bool _MIDI_TIME_CODEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequencer.SyncMode.html#NO_SYNC"/>
            /// </summary>
            public static Javax.Sound.Midi.Sequencer.SyncMode NO_SYNC { get { if (!_NO_SYNCReady) { _NO_SYNCContent = SGetField<Javax.Sound.Midi.Sequencer.SyncMode>(LocalBridgeClazz, "NO_SYNC"); _NO_SYNCReady = true; } return _NO_SYNCContent; } }
            private static Javax.Sound.Midi.Sequencer.SyncMode _NO_SYNCContent = default;
            private static bool _NO_SYNCReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}