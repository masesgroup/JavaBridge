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

namespace Javax.Sound.Sampled
{
    #region AudioFormat definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html"/>
    /// </summary>
    public partial class AudioFormat : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AudioFormat>
    {
        const string _bridgeClassName = "javax.sound.sampled.AudioFormat";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AudioFormat() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AudioFormat(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region Encoding definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.Encoding.html"/>
        /// </summary>
        public partial class Encoding : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Encoding>
        {
            const string _bridgeClassName = "javax.sound.sampled.AudioFormat$Encoding";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Encoding() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Encoding(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region AudioFormat
    public partial class AudioFormat
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#%3Cinit%3E(float,int,int,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        public AudioFormat(float arg0, int arg1, int arg2, bool arg3, bool arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#%3Cinit%3E(javax.sound.sampled.AudioFormat.Encoding,float,int,int,int,float,boolean,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <param name="arg7"><see cref="Java.Util.Map"/></param>
        public AudioFormat(Javax.Sound.Sampled.AudioFormat.Encoding arg0, float arg1, int arg2, int arg3, int arg4, float arg5, bool arg6, Java.Util.Map<Java.Lang.String, object> arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#%3Cinit%3E(javax.sound.sampled.AudioFormat.Encoding,float,int,int,int,float,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        public AudioFormat(Javax.Sound.Sampled.AudioFormat.Encoding arg0, float arg1, int arg2, int arg3, int arg4, float arg5, bool arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#getChannels()"/> 
        /// </summary>
        public int Channels
        {
            get { return IExecuteWithSignature<int>("getChannels", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#getFrameRate()"/> 
        /// </summary>
        public float FrameRate
        {
            get { return IExecuteWithSignature<float>("getFrameRate", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#getFrameSize()"/> 
        /// </summary>
        public int FrameSize
        {
            get { return IExecuteWithSignature<int>("getFrameSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#getEncoding()"/> 
        /// </summary>
        public Javax.Sound.Sampled.AudioFormat.Encoding GetEncoding
        {
            get { return IExecuteWithSignature<Javax.Sound.Sampled.AudioFormat.Encoding>("getEncoding", "()Ljavax/sound/sampled/AudioFormat$Encoding;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#getSampleRate()"/> 
        /// </summary>
        public float SampleRate
        {
            get { return IExecuteWithSignature<float>("getSampleRate", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#getSampleSizeInBits()"/> 
        /// </summary>
        public int SampleSizeInBits
        {
            get { return IExecuteWithSignature<int>("getSampleSizeInBits", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#isBigEndian()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBigEndian()
        {
            return IExecuteWithSignature<bool>("isBigEndian", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#matches(javax.sound.sampled.AudioFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Matches(Javax.Sound.Sampled.AudioFormat arg0)
        {
            return IExecuteWithSignature<bool>("matches", "(Ljavax/sound/sampled/AudioFormat;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#properties()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> Properties()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("properties", "()Ljava/util/Map;");
        }

        #endregion

        #region Nested classes
        #region Encoding
        public partial class Encoding
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.Encoding.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public Encoding(Java.Lang.String arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.Encoding.html#ALAW"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFormat.Encoding ALAW { get { if (!_ALAWReady) { _ALAWContent = SGetField<Javax.Sound.Sampled.AudioFormat.Encoding>(LocalBridgeClazz, "ALAW"); _ALAWReady = true; } return _ALAWContent; } }
            private static Javax.Sound.Sampled.AudioFormat.Encoding _ALAWContent = default;
            private static bool _ALAWReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.Encoding.html#PCM_FLOAT"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFormat.Encoding PCM_FLOAT { get { if (!_PCM_FLOATReady) { _PCM_FLOATContent = SGetField<Javax.Sound.Sampled.AudioFormat.Encoding>(LocalBridgeClazz, "PCM_FLOAT"); _PCM_FLOATReady = true; } return _PCM_FLOATContent; } }
            private static Javax.Sound.Sampled.AudioFormat.Encoding _PCM_FLOATContent = default;
            private static bool _PCM_FLOATReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.Encoding.html#PCM_SIGNED"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFormat.Encoding PCM_SIGNED { get { if (!_PCM_SIGNEDReady) { _PCM_SIGNEDContent = SGetField<Javax.Sound.Sampled.AudioFormat.Encoding>(LocalBridgeClazz, "PCM_SIGNED"); _PCM_SIGNEDReady = true; } return _PCM_SIGNEDContent; } }
            private static Javax.Sound.Sampled.AudioFormat.Encoding _PCM_SIGNEDContent = default;
            private static bool _PCM_SIGNEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.Encoding.html#PCM_UNSIGNED"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFormat.Encoding PCM_UNSIGNED { get { if (!_PCM_UNSIGNEDReady) { _PCM_UNSIGNEDContent = SGetField<Javax.Sound.Sampled.AudioFormat.Encoding>(LocalBridgeClazz, "PCM_UNSIGNED"); _PCM_UNSIGNEDReady = true; } return _PCM_UNSIGNEDContent; } }
            private static Javax.Sound.Sampled.AudioFormat.Encoding _PCM_UNSIGNEDContent = default;
            private static bool _PCM_UNSIGNEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.Encoding.html#ULAW"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFormat.Encoding ULAW { get { if (!_ULAWReady) { _ULAWContent = SGetField<Javax.Sound.Sampled.AudioFormat.Encoding>(LocalBridgeClazz, "ULAW"); _ULAWReady = true; } return _ULAWContent; } }
            private static Javax.Sound.Sampled.AudioFormat.Encoding _ULAWContent = default;
            private static bool _ULAWReady = false; // this is used because in case of generics 

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