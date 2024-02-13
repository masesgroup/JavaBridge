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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Monitor
{
    #region MonitorNotification
    public partial class MonitorNotification
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorNotification.html#OBSERVED_ATTRIBUTE_ERROR"/>
        /// </summary>
        public static Java.Lang.String OBSERVED_ATTRIBUTE_ERROR { get { if (!_OBSERVED_ATTRIBUTE_ERRORReady) { _OBSERVED_ATTRIBUTE_ERRORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OBSERVED_ATTRIBUTE_ERROR"); _OBSERVED_ATTRIBUTE_ERRORReady = true; } return _OBSERVED_ATTRIBUTE_ERRORContent; } }
        private static Java.Lang.String _OBSERVED_ATTRIBUTE_ERRORContent = default;
        private static bool _OBSERVED_ATTRIBUTE_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorNotification.html#OBSERVED_ATTRIBUTE_TYPE_ERROR"/>
        /// </summary>
        public static Java.Lang.String OBSERVED_ATTRIBUTE_TYPE_ERROR { get { if (!_OBSERVED_ATTRIBUTE_TYPE_ERRORReady) { _OBSERVED_ATTRIBUTE_TYPE_ERRORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OBSERVED_ATTRIBUTE_TYPE_ERROR"); _OBSERVED_ATTRIBUTE_TYPE_ERRORReady = true; } return _OBSERVED_ATTRIBUTE_TYPE_ERRORContent; } }
        private static Java.Lang.String _OBSERVED_ATTRIBUTE_TYPE_ERRORContent = default;
        private static bool _OBSERVED_ATTRIBUTE_TYPE_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorNotification.html#OBSERVED_OBJECT_ERROR"/>
        /// </summary>
        public static Java.Lang.String OBSERVED_OBJECT_ERROR { get { if (!_OBSERVED_OBJECT_ERRORReady) { _OBSERVED_OBJECT_ERRORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OBSERVED_OBJECT_ERROR"); _OBSERVED_OBJECT_ERRORReady = true; } return _OBSERVED_OBJECT_ERRORContent; } }
        private static Java.Lang.String _OBSERVED_OBJECT_ERRORContent = default;
        private static bool _OBSERVED_OBJECT_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorNotification.html#RUNTIME_ERROR"/>
        /// </summary>
        public static Java.Lang.String RUNTIME_ERROR { get { if (!_RUNTIME_ERRORReady) { _RUNTIME_ERRORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RUNTIME_ERROR"); _RUNTIME_ERRORReady = true; } return _RUNTIME_ERRORContent; } }
        private static Java.Lang.String _RUNTIME_ERRORContent = default;
        private static bool _RUNTIME_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorNotification.html#STRING_TO_COMPARE_VALUE_DIFFERED"/>
        /// </summary>
        public static Java.Lang.String STRING_TO_COMPARE_VALUE_DIFFERED { get { if (!_STRING_TO_COMPARE_VALUE_DIFFEREDReady) { _STRING_TO_COMPARE_VALUE_DIFFEREDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "STRING_TO_COMPARE_VALUE_DIFFERED"); _STRING_TO_COMPARE_VALUE_DIFFEREDReady = true; } return _STRING_TO_COMPARE_VALUE_DIFFEREDContent; } }
        private static Java.Lang.String _STRING_TO_COMPARE_VALUE_DIFFEREDContent = default;
        private static bool _STRING_TO_COMPARE_VALUE_DIFFEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorNotification.html#STRING_TO_COMPARE_VALUE_MATCHED"/>
        /// </summary>
        public static Java.Lang.String STRING_TO_COMPARE_VALUE_MATCHED { get { if (!_STRING_TO_COMPARE_VALUE_MATCHEDReady) { _STRING_TO_COMPARE_VALUE_MATCHEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "STRING_TO_COMPARE_VALUE_MATCHED"); _STRING_TO_COMPARE_VALUE_MATCHEDReady = true; } return _STRING_TO_COMPARE_VALUE_MATCHEDContent; } }
        private static Java.Lang.String _STRING_TO_COMPARE_VALUE_MATCHEDContent = default;
        private static bool _STRING_TO_COMPARE_VALUE_MATCHEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorNotification.html#THRESHOLD_ERROR"/>
        /// </summary>
        public static Java.Lang.String THRESHOLD_ERROR { get { if (!_THRESHOLD_ERRORReady) { _THRESHOLD_ERRORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "THRESHOLD_ERROR"); _THRESHOLD_ERRORReady = true; } return _THRESHOLD_ERRORContent; } }
        private static Java.Lang.String _THRESHOLD_ERRORContent = default;
        private static bool _THRESHOLD_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorNotification.html#THRESHOLD_HIGH_VALUE_EXCEEDED"/>
        /// </summary>
        public static Java.Lang.String THRESHOLD_HIGH_VALUE_EXCEEDED { get { if (!_THRESHOLD_HIGH_VALUE_EXCEEDEDReady) { _THRESHOLD_HIGH_VALUE_EXCEEDEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "THRESHOLD_HIGH_VALUE_EXCEEDED"); _THRESHOLD_HIGH_VALUE_EXCEEDEDReady = true; } return _THRESHOLD_HIGH_VALUE_EXCEEDEDContent; } }
        private static Java.Lang.String _THRESHOLD_HIGH_VALUE_EXCEEDEDContent = default;
        private static bool _THRESHOLD_HIGH_VALUE_EXCEEDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorNotification.html#THRESHOLD_LOW_VALUE_EXCEEDED"/>
        /// </summary>
        public static Java.Lang.String THRESHOLD_LOW_VALUE_EXCEEDED { get { if (!_THRESHOLD_LOW_VALUE_EXCEEDEDReady) { _THRESHOLD_LOW_VALUE_EXCEEDEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "THRESHOLD_LOW_VALUE_EXCEEDED"); _THRESHOLD_LOW_VALUE_EXCEEDEDReady = true; } return _THRESHOLD_LOW_VALUE_EXCEEDEDContent; } }
        private static Java.Lang.String _THRESHOLD_LOW_VALUE_EXCEEDEDContent = default;
        private static bool _THRESHOLD_LOW_VALUE_EXCEEDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorNotification.html#THRESHOLD_VALUE_EXCEEDED"/>
        /// </summary>
        public static Java.Lang.String THRESHOLD_VALUE_EXCEEDED { get { if (!_THRESHOLD_VALUE_EXCEEDEDReady) { _THRESHOLD_VALUE_EXCEEDEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "THRESHOLD_VALUE_EXCEEDED"); _THRESHOLD_VALUE_EXCEEDEDReady = true; } return _THRESHOLD_VALUE_EXCEEDEDContent; } }
        private static Java.Lang.String _THRESHOLD_VALUE_EXCEEDEDContent = default;
        private static bool _THRESHOLD_VALUE_EXCEEDEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorNotification.html#getDerivedGauge()"/> 
        /// </summary>
        public object DerivedGauge
        {
            get { return IExecute("getDerivedGauge"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorNotification.html#getObservedAttribute()"/> 
        /// </summary>
        public Java.Lang.String ObservedAttribute
        {
            get { return IExecute<Java.Lang.String>("getObservedAttribute"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorNotification.html#getObservedObject()"/> 
        /// </summary>
        public Javax.Management.ObjectName ObservedObject
        {
            get { return IExecute<Javax.Management.ObjectName>("getObservedObject"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/MonitorNotification.html#getTrigger()"/> 
        /// </summary>
        public object Trigger
        {
            get { return IExecute("getTrigger"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}