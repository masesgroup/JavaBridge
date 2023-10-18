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

namespace Java.Util.Prefs
{
    #region IPreferenceChangeListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.prefs.PreferenceChangeListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/PreferenceChangeListener.html"/>
    /// </summary>
    public partial interface IPreferenceChangeListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/PreferenceChangeListener.html#preferenceChange(java.util.prefs.PreferenceChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.PreferenceChangeEvent"/></param>
        void PreferenceChange(Java.Util.Prefs.PreferenceChangeEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PreferenceChangeListener
    public partial class PreferenceChangeListener : Java.Util.Prefs.IPreferenceChangeListener
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
        /// Handlers initializer for <see cref="PreferenceChangeListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("preferenceChange", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Prefs.PreferenceChangeEvent>>>(PreferenceChangeEventHandler)); OnPreferenceChange = PreferenceChange;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/PreferenceChangeListener.html#preferenceChange(java.util.prefs.PreferenceChangeEvent)"/>
        /// </summary>
        public System.Action<Java.Util.Prefs.PreferenceChangeEvent> OnPreferenceChange { get; set; }

        void PreferenceChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Prefs.PreferenceChangeEvent>> data)
        {
            if (OnPreferenceChange != null) OnPreferenceChange.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/PreferenceChangeListener.html#preferenceChange(java.util.prefs.PreferenceChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.PreferenceChangeEvent"/></param>
        public virtual void PreferenceChange(Java.Util.Prefs.PreferenceChangeEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}