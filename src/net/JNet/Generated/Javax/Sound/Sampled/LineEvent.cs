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

namespace Javax.Sound.Sampled
{
    #region LineEvent
    public partial class LineEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.html#%3Cinit%3E(javax.sound.sampled.Line,javax.sound.sampled.LineEvent.Type,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.LineEvent.Type"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public LineEvent(Javax.Sound.Sampled.Line arg0, Javax.Sound.Sampled.LineEvent.Type arg1, long arg2)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.html#getFramePosition()"/> 
        /// </summary>
        public long FramePosition
        {
            get { return IExecuteWithSignature<long>("getFramePosition", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.html#getType()"/> 
        /// </summary>
        public Javax.Sound.Sampled.LineEvent.Type GetType
        {
            get { return IExecuteWithSignature<Javax.Sound.Sampled.LineEvent.Type>("getType", "()Ljavax/sound/sampled/LineEvent$Type;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.html#getLine()"/> 
        /// </summary>
        public Javax.Sound.Sampled.Line Line
        {
            get { return IExecuteWithSignature<Javax.Sound.Sampled.Line>("getLine", "()Ljavax/sound/sampled/Line;"); }
        }

        #endregion

        #region Nested classes
        #region Type
        public partial class Type
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.Type.html#CLOSE"/>
            /// </summary>
            public static Javax.Sound.Sampled.LineEvent.Type CLOSE { get { if (!_CLOSEReady) { _CLOSEContent = SGetField<Javax.Sound.Sampled.LineEvent.Type>(LocalBridgeClazz, "CLOSE"); _CLOSEReady = true; } return _CLOSEContent; } }
            private static Javax.Sound.Sampled.LineEvent.Type _CLOSEContent = default;
            private static bool _CLOSEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.Type.html#OPEN"/>
            /// </summary>
            public static Javax.Sound.Sampled.LineEvent.Type OPEN { get { if (!_OPENReady) { _OPENContent = SGetField<Javax.Sound.Sampled.LineEvent.Type>(LocalBridgeClazz, "OPEN"); _OPENReady = true; } return _OPENContent; } }
            private static Javax.Sound.Sampled.LineEvent.Type _OPENContent = default;
            private static bool _OPENReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.Type.html#START"/>
            /// </summary>
            public static Javax.Sound.Sampled.LineEvent.Type START { get { if (!_STARTReady) { _STARTContent = SGetField<Javax.Sound.Sampled.LineEvent.Type>(LocalBridgeClazz, "START"); _STARTReady = true; } return _STARTContent; } }
            private static Javax.Sound.Sampled.LineEvent.Type _STARTContent = default;
            private static bool _STARTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.Type.html#STOP"/>
            /// </summary>
            public static Javax.Sound.Sampled.LineEvent.Type STOP { get { if (!_STOPReady) { _STOPContent = SGetField<Javax.Sound.Sampled.LineEvent.Type>(LocalBridgeClazz, "STOP"); _STOPReady = true; } return _STOPContent; } }
            private static Javax.Sound.Sampled.LineEvent.Type _STOPContent = default;
            private static bool _STOPReady = false; // this is used because in case of generics 

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