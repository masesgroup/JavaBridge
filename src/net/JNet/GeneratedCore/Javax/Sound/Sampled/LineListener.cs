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
    #region LineListener definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineListener.html"/>
    /// </summary>
    public partial class LineListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LineListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.sound.sampled.LineListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region LineListenerDirect definition
    /// <summary>
    /// Direct override of <see cref="LineListener"/> or its generic type if there is one
    /// </summary>
    public partial class LineListenerDirect : LineListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.sound.sampled.LineListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
    #endregion

    #region ILineListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.sound.sampled.LineListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineListener.html"/>
    /// </summary>
    public partial interface ILineListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineListener.html#update(javax.sound.sampled.LineEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.LineEvent"/></param>
        void Update(Javax.Sound.Sampled.LineEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LineListener
    public partial class LineListener : Javax.Sound.Sampled.ILineListener
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
        /// Handlers initializer for <see cref="LineListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("update", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Sound.Sampled.LineEvent>>>(UpdateEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineListener.html#update(javax.sound.sampled.LineEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnUpdate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Sound.Sampled.LineEvent> OnUpdate { get; set; } = null;

        void UpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Sound.Sampled.LineEvent>> data)
        {
            var methodToExecute = (OnUpdate != null) ? OnUpdate : Update;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineListener.html#update(javax.sound.sampled.LineEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.LineEvent"/></param>
        public virtual void Update(Javax.Sound.Sampled.LineEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LineListenerDirect
    public partial class LineListenerDirect : Javax.Sound.Sampled.ILineListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineListener.html#update(javax.sound.sampled.LineEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.LineEvent"/></param>
        public override void Update(Javax.Sound.Sampled.LineEvent arg0)
        {
            IExecuteWithSignature("update", "(Ljavax/sound/sampled/LineEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}