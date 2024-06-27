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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Midi
{
    #region MidiSystem
    public partial class MidiSystem
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getMidiDeviceInfo()"/> 
        /// </summary>
        public static Javax.Sound.Midi.MidiDevice.Info[] MidiDeviceInfo
        {
            get { return SExecuteWithSignatureArray<Javax.Sound.Midi.MidiDevice.Info>(LocalBridgeClazz, "getMidiDeviceInfo", "()[Ljavax/sound/midi/MidiDevice$Info;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getMidiFileTypes()"/> 
        /// </summary>
        public static int[] MidiFileTypes
        {
            get { return SExecuteWithSignatureArray<int>(LocalBridgeClazz, "getMidiFileTypes", "()[I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getReceiver()"/> 
        /// </summary>
        public static Javax.Sound.Midi.Receiver Receiver
        {
            get { return SExecuteWithSignature<Javax.Sound.Midi.Receiver>(LocalBridgeClazz, "getReceiver", "()Ljavax/sound/midi/Receiver;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getSequencer()"/> 
        /// </summary>
        public static Javax.Sound.Midi.Sequencer Sequencer
        {
            get { return SExecuteWithSignature<Javax.Sound.Midi.Sequencer>(LocalBridgeClazz, "getSequencer", "()Ljavax/sound/midi/Sequencer;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getSynthesizer()"/> 
        /// </summary>
        public static Javax.Sound.Midi.Synthesizer Synthesizer
        {
            get { return SExecuteWithSignature<Javax.Sound.Midi.Synthesizer>(LocalBridgeClazz, "getSynthesizer", "()Ljavax/sound/midi/Synthesizer;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getTransmitter()"/> 
        /// </summary>
        public static Javax.Sound.Midi.Transmitter Transmitter
        {
            get { return SExecuteWithSignature<Javax.Sound.Midi.Transmitter>(LocalBridgeClazz, "getTransmitter", "()Ljavax/sound/midi/Transmitter;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#isFileTypeSupported(int,javax.sound.midi.Sequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Midi.Sequence"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsFileTypeSupported(int arg0, Javax.Sound.Midi.Sequence arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isFileTypeSupported", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#isFileTypeSupported(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsFileTypeSupported(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isFileTypeSupported", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#write(javax.sound.midi.Sequence,int,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Sequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static int Write(Javax.Sound.Midi.Sequence arg0, int arg1, Java.Io.File arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#write(javax.sound.midi.Sequence,int,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Sequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Io.OutputStream"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static int Write(Javax.Sound.Midi.Sequence arg0, int arg1, Java.Io.OutputStream arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getMidiFileTypes(javax.sound.midi.Sequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Sequence"/></param>
        /// <returns><see cref="int"/></returns>
        public static int[] GetMidiFileTypes(Javax.Sound.Midi.Sequence arg0)
        {
            return SExecuteWithSignatureArray<int>(LocalBridgeClazz, "getMidiFileTypes", "(Ljavax/sound/midi/Sequence;)[I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getMidiDevice(javax.sound.midi.MidiDevice.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.MidiDevice.Info"/></param>
        /// <returns><see cref="Javax.Sound.Midi.MidiDevice"/></returns>
        /// <exception cref="Javax.Sound.Midi.MidiUnavailableException"/>
        public static Javax.Sound.Midi.MidiDevice GetMidiDevice(Javax.Sound.Midi.MidiDevice.Info arg0)
        {
            return SExecuteWithSignature<Javax.Sound.Midi.MidiDevice>(LocalBridgeClazz, "getMidiDevice", "(Ljavax/sound/midi/MidiDevice$Info;)Ljavax/sound/midi/MidiDevice;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getMidiFileFormat(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Sound.Midi.MidiFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Midi.MidiFileFormat GetMidiFileFormat(Java.Io.File arg0)
        {
            return SExecuteWithSignature<Javax.Sound.Midi.MidiFileFormat>(LocalBridgeClazz, "getMidiFileFormat", "(Ljava/io/File;)Ljavax/sound/midi/MidiFileFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getMidiFileFormat(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Sound.Midi.MidiFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Midi.MidiFileFormat GetMidiFileFormat(Java.Io.InputStream arg0)
        {
            return SExecuteWithSignature<Javax.Sound.Midi.MidiFileFormat>(LocalBridgeClazz, "getMidiFileFormat", "(Ljava/io/InputStream;)Ljavax/sound/midi/MidiFileFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getMidiFileFormat(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Javax.Sound.Midi.MidiFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Midi.MidiFileFormat GetMidiFileFormat(Java.Net.URL arg0)
        {
            return SExecuteWithSignature<Javax.Sound.Midi.MidiFileFormat>(LocalBridgeClazz, "getMidiFileFormat", "(Ljava/net/URL;)Ljavax/sound/midi/MidiFileFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getSequence(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Sound.Midi.Sequence"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Midi.Sequence GetSequence(Java.Io.File arg0)
        {
            return SExecuteWithSignature<Javax.Sound.Midi.Sequence>(LocalBridgeClazz, "getSequence", "(Ljava/io/File;)Ljavax/sound/midi/Sequence;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getSequence(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Sound.Midi.Sequence"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Midi.Sequence GetSequence(Java.Io.InputStream arg0)
        {
            return SExecuteWithSignature<Javax.Sound.Midi.Sequence>(LocalBridgeClazz, "getSequence", "(Ljava/io/InputStream;)Ljavax/sound/midi/Sequence;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getSequence(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Javax.Sound.Midi.Sequence"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Midi.Sequence GetSequence(Java.Net.URL arg0)
        {
            return SExecuteWithSignature<Javax.Sound.Midi.Sequence>(LocalBridgeClazz, "getSequence", "(Ljava/net/URL;)Ljavax/sound/midi/Sequence;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getSequencer(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Sound.Midi.Sequencer"/></returns>
        /// <exception cref="Javax.Sound.Midi.MidiUnavailableException"/>
        public static Javax.Sound.Midi.Sequencer GetSequencer(bool arg0)
        {
            return SExecuteWithSignature<Javax.Sound.Midi.Sequencer>(LocalBridgeClazz, "getSequencer", "(Z)Ljavax/sound/midi/Sequencer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getSoundbank(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Sound.Midi.Soundbank"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Midi.Soundbank GetSoundbank(Java.Io.File arg0)
        {
            return SExecuteWithSignature<Javax.Sound.Midi.Soundbank>(LocalBridgeClazz, "getSoundbank", "(Ljava/io/File;)Ljavax/sound/midi/Soundbank;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getSoundbank(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Sound.Midi.Soundbank"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Midi.Soundbank GetSoundbank(Java.Io.InputStream arg0)
        {
            return SExecuteWithSignature<Javax.Sound.Midi.Soundbank>(LocalBridgeClazz, "getSoundbank", "(Ljava/io/InputStream;)Ljavax/sound/midi/Soundbank;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiSystem.html#getSoundbank(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Javax.Sound.Midi.Soundbank"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Midi.Soundbank GetSoundbank(Java.Net.URL arg0)
        {
            return SExecuteWithSignature<Javax.Sound.Midi.Soundbank>(LocalBridgeClazz, "getSoundbank", "(Ljava/net/URL;)Ljavax/sound/midi/Soundbank;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}