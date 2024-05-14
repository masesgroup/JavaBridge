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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Midi
{
    #region Track
    public partial class Track
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Track.html#add(javax.sound.midi.MidiEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.MidiEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(Javax.Sound.Midi.MidiEvent arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Ljavax/sound/midi/MidiEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Track.html#remove(javax.sound.midi.MidiEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.MidiEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(Javax.Sound.Midi.MidiEvent arg0)
        {
            return IExecuteWithSignature<bool>("remove", "(Ljavax/sound/midi/MidiEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Track.html#size()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Track.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Sound.Midi.MidiEvent"/></returns>
        /// <exception cref="Java.Lang.ArrayIndexOutOfBoundsException"/>
        public Javax.Sound.Midi.MidiEvent Get(int arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Midi.MidiEvent>("get", "(I)Ljavax/sound/midi/MidiEvent;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Track.html#ticks()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Ticks()
        {
            return IExecuteWithSignature<long>("ticks", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}