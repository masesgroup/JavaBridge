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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Sampled
{
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
            AddEventHandler("update", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Sound.Sampled.LineEvent>>>(UpdateEventHandler)); OnUpdate = Update;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineListener.html#update(javax.sound.sampled.LineEvent)"/>
        /// </summary>
        public System.Action<Javax.Sound.Sampled.LineEvent> OnUpdate { get; set; }

        void UpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Sound.Sampled.LineEvent>> data)
        {
            if (OnUpdate != null) OnUpdate.Invoke(data.EventData.TypedEventData);
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
}