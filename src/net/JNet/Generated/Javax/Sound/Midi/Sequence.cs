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

namespace Javax.Sound.Midi
{
    #region Sequence
    public partial class Sequence
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#%3Cinit%3E(float,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        public Sequence(float arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#%3Cinit%3E(float,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        public Sequence(float arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#PPQ"/>
        /// </summary>
        public static float PPQ { get { if (!_PPQReady) { _PPQContent = SGetField<float>(LocalBridgeClazz, "PPQ"); _PPQReady = true; } return _PPQContent; } }
        private static float _PPQContent = default;
        private static bool _PPQReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#SMPTE_24"/>
        /// </summary>
        public static float SMPTE_24 { get { if (!_SMPTE_24Ready) { _SMPTE_24Content = SGetField<float>(LocalBridgeClazz, "SMPTE_24"); _SMPTE_24Ready = true; } return _SMPTE_24Content; } }
        private static float _SMPTE_24Content = default;
        private static bool _SMPTE_24Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#SMPTE_25"/>
        /// </summary>
        public static float SMPTE_25 { get { if (!_SMPTE_25Ready) { _SMPTE_25Content = SGetField<float>(LocalBridgeClazz, "SMPTE_25"); _SMPTE_25Ready = true; } return _SMPTE_25Content; } }
        private static float _SMPTE_25Content = default;
        private static bool _SMPTE_25Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#SMPTE_30"/>
        /// </summary>
        public static float SMPTE_30 { get { if (!_SMPTE_30Ready) { _SMPTE_30Content = SGetField<float>(LocalBridgeClazz, "SMPTE_30"); _SMPTE_30Ready = true; } return _SMPTE_30Content; } }
        private static float _SMPTE_30Content = default;
        private static bool _SMPTE_30Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#SMPTE_30DROP"/>
        /// </summary>
        public static float SMPTE_30DROP { get { if (!_SMPTE_30DROPReady) { _SMPTE_30DROPContent = SGetField<float>(LocalBridgeClazz, "SMPTE_30DROP"); _SMPTE_30DROPReady = true; } return _SMPTE_30DROPContent; } }
        private static float _SMPTE_30DROPContent = default;
        private static bool _SMPTE_30DROPReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#getDivisionType()"/> 
        /// </summary>
        public float DivisionType
        {
            get { return IExecuteWithSignature<float>("getDivisionType", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#getMicrosecondLength()"/> 
        /// </summary>
        public long MicrosecondLength
        {
            get { return IExecuteWithSignature<long>("getMicrosecondLength", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#getPatchList()"/> 
        /// </summary>
        public Javax.Sound.Midi.Patch[] PatchList
        {
            get { return IExecuteWithSignatureArray<Javax.Sound.Midi.Patch>("getPatchList", "()[Ljavax/sound/midi/Patch;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#getResolution()"/> 
        /// </summary>
        public int Resolution
        {
            get { return IExecuteWithSignature<int>("getResolution", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#getTickLength()"/> 
        /// </summary>
        public long TickLength
        {
            get { return IExecuteWithSignature<long>("getTickLength", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#getTracks()"/> 
        /// </summary>
        public Javax.Sound.Midi.Track[] Tracks
        {
            get { return IExecuteWithSignatureArray<Javax.Sound.Midi.Track>("getTracks", "()[Ljavax/sound/midi/Track;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#deleteTrack(javax.sound.midi.Track)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Track"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DeleteTrack(Javax.Sound.Midi.Track arg0)
        {
            return IExecuteWithSignature<bool>("deleteTrack", "(Ljavax/sound/midi/Track;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#createTrack()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sound.Midi.Track"/></returns>
        public Javax.Sound.Midi.Track CreateTrack()
        {
            return IExecuteWithSignature<Javax.Sound.Midi.Track>("createTrack", "()Ljavax/sound/midi/Track;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}