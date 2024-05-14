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

namespace Java.Awt.DesktopNs
{
    #region IAppHiddenListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.desktop.AppHiddenListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppHiddenListener.html"/>
    /// </summary>
    public partial interface IAppHiddenListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppHiddenListener.html#appHidden(java.awt.desktop.AppHiddenEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AppHiddenEvent"/></param>
        void AppHidden(Java.Awt.DesktopNs.AppHiddenEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppHiddenListener.html#appUnhidden(java.awt.desktop.AppHiddenEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AppHiddenEvent"/></param>
        void AppUnhidden(Java.Awt.DesktopNs.AppHiddenEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AppHiddenListener
    public partial class AppHiddenListener : Java.Awt.DesktopNs.IAppHiddenListener
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
        /// Handlers initializer for <see cref="AppHiddenListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("appHidden", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.AppHiddenEvent>>>(AppHiddenEventHandler));
            AddEventHandler("appUnhidden", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.AppHiddenEvent>>>(AppUnhiddenEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppHiddenListener.html#appHidden(java.awt.desktop.AppHiddenEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAppHidden"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.DesktopNs.AppHiddenEvent> OnAppHidden { get; set; } = null;

        void AppHiddenEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.AppHiddenEvent>> data)
        {
            var methodToExecute = (OnAppHidden != null) ? OnAppHidden : AppHidden;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppHiddenListener.html#appHidden(java.awt.desktop.AppHiddenEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AppHiddenEvent"/></param>
        public virtual void AppHidden(Java.Awt.DesktopNs.AppHiddenEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppHiddenListener.html#appUnhidden(java.awt.desktop.AppHiddenEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAppUnhidden"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.DesktopNs.AppHiddenEvent> OnAppUnhidden { get; set; } = null;

        void AppUnhiddenEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.AppHiddenEvent>> data)
        {
            var methodToExecute = (OnAppUnhidden != null) ? OnAppUnhidden : AppUnhidden;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppHiddenListener.html#appUnhidden(java.awt.desktop.AppHiddenEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AppHiddenEvent"/></param>
        public virtual void AppUnhidden(Java.Awt.DesktopNs.AppHiddenEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}