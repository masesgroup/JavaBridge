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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time.Zone
{
    #region ZoneRulesProvider
    public partial class ZoneRulesProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#getAvailableZoneIds()"/> 
        /// </summary>
        public static Java.Util.Set AvailableZoneIds
        {
            get { return SExecute<Java.Util.Set>("getAvailableZoneIds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#refresh()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public static bool Refresh()
        {
            return SExecute<bool>("refresh");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#getRules(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneRules"/></returns>
        public static Java.Time.Zone.ZoneRules GetRules(string arg0, bool arg1)
        {
            return SExecute<Java.Time.Zone.ZoneRules>("getRules", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#getVersions(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public static Java.Util.NavigableMap GetVersions(string arg0)
        {
            return SExecute<Java.Util.NavigableMap>("getVersions", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#registerProvider(java.time.zone.ZoneRulesProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Zone.ZoneRulesProvider"/></param>
        public static void RegisterProvider(Java.Time.Zone.ZoneRulesProvider arg0)
        {
            SExecute("registerProvider", arg0);
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