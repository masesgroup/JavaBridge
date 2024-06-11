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

namespace Java.Nio.File
{
    #region StandardWatchEventKinds
    public partial class StandardWatchEventKinds
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardWatchEventKinds.html#OVERFLOW"/>
        /// </summary>
        public static Java.Nio.File.WatchEvent.Kind OVERFLOW { get { if (!_OVERFLOWReady) { _OVERFLOWContent = SGetField<Java.Nio.File.WatchEvent.Kind>(LocalBridgeClazz, "OVERFLOW"); _OVERFLOWReady = true; } return _OVERFLOWContent; } }
        private static Java.Nio.File.WatchEvent.Kind _OVERFLOWContent = default;
        private static bool _OVERFLOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardWatchEventKinds.html#ENTRY_CREATE"/>
        /// </summary>
        public static Java.Nio.File.WatchEvent.Kind ENTRY_CREATE { get { if (!_ENTRY_CREATEReady) { _ENTRY_CREATEContent = SGetField<Java.Nio.File.WatchEvent.Kind>(LocalBridgeClazz, "ENTRY_CREATE"); _ENTRY_CREATEReady = true; } return _ENTRY_CREATEContent; } }
        private static Java.Nio.File.WatchEvent.Kind _ENTRY_CREATEContent = default;
        private static bool _ENTRY_CREATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardWatchEventKinds.html#ENTRY_DELETE"/>
        /// </summary>
        public static Java.Nio.File.WatchEvent.Kind ENTRY_DELETE { get { if (!_ENTRY_DELETEReady) { _ENTRY_DELETEContent = SGetField<Java.Nio.File.WatchEvent.Kind>(LocalBridgeClazz, "ENTRY_DELETE"); _ENTRY_DELETEReady = true; } return _ENTRY_DELETEContent; } }
        private static Java.Nio.File.WatchEvent.Kind _ENTRY_DELETEContent = default;
        private static bool _ENTRY_DELETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardWatchEventKinds.html#ENTRY_MODIFY"/>
        /// </summary>
        public static Java.Nio.File.WatchEvent.Kind ENTRY_MODIFY { get { if (!_ENTRY_MODIFYReady) { _ENTRY_MODIFYContent = SGetField<Java.Nio.File.WatchEvent.Kind>(LocalBridgeClazz, "ENTRY_MODIFY"); _ENTRY_MODIFYReady = true; } return _ENTRY_MODIFYContent; } }
        private static Java.Nio.File.WatchEvent.Kind _ENTRY_MODIFYContent = default;
        private static bool _ENTRY_MODIFYReady = false; // this is used because in case of generics 

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
}