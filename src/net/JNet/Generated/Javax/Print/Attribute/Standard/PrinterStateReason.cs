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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Attribute.Standard
{
    #region PrinterStateReason
    public partial class PrinterStateReason
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.PrinterStateReason"/> to <see cref="Javax.Print.Attribute.Attribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.Attribute(Javax.Print.Attribute.Standard.PrinterStateReason t) => t.Cast<Javax.Print.Attribute.Attribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#CONNECTING_TO_DEVICE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason CONNECTING_TO_DEVICE { get { if (!_CONNECTING_TO_DEVICEReady) { _CONNECTING_TO_DEVICEContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "CONNECTING_TO_DEVICE"); _CONNECTING_TO_DEVICEReady = true; } return _CONNECTING_TO_DEVICEContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _CONNECTING_TO_DEVICEContent = default;
        private static bool _CONNECTING_TO_DEVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#COVER_OPEN"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason COVER_OPEN { get { if (!_COVER_OPENReady) { _COVER_OPENContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "COVER_OPEN"); _COVER_OPENReady = true; } return _COVER_OPENContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _COVER_OPENContent = default;
        private static bool _COVER_OPENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#DEVELOPER_EMPTY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason DEVELOPER_EMPTY { get { if (!_DEVELOPER_EMPTYReady) { _DEVELOPER_EMPTYContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "DEVELOPER_EMPTY"); _DEVELOPER_EMPTYReady = true; } return _DEVELOPER_EMPTYContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _DEVELOPER_EMPTYContent = default;
        private static bool _DEVELOPER_EMPTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#DEVELOPER_LOW"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason DEVELOPER_LOW { get { if (!_DEVELOPER_LOWReady) { _DEVELOPER_LOWContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "DEVELOPER_LOW"); _DEVELOPER_LOWReady = true; } return _DEVELOPER_LOWContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _DEVELOPER_LOWContent = default;
        private static bool _DEVELOPER_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#DOOR_OPEN"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason DOOR_OPEN { get { if (!_DOOR_OPENReady) { _DOOR_OPENContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "DOOR_OPEN"); _DOOR_OPENReady = true; } return _DOOR_OPENContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _DOOR_OPENContent = default;
        private static bool _DOOR_OPENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#FUSER_OVER_TEMP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason FUSER_OVER_TEMP { get { if (!_FUSER_OVER_TEMPReady) { _FUSER_OVER_TEMPContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "FUSER_OVER_TEMP"); _FUSER_OVER_TEMPReady = true; } return _FUSER_OVER_TEMPContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _FUSER_OVER_TEMPContent = default;
        private static bool _FUSER_OVER_TEMPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#FUSER_UNDER_TEMP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason FUSER_UNDER_TEMP { get { if (!_FUSER_UNDER_TEMPReady) { _FUSER_UNDER_TEMPContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "FUSER_UNDER_TEMP"); _FUSER_UNDER_TEMPReady = true; } return _FUSER_UNDER_TEMPContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _FUSER_UNDER_TEMPContent = default;
        private static bool _FUSER_UNDER_TEMPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#INPUT_TRAY_MISSING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason INPUT_TRAY_MISSING { get { if (!_INPUT_TRAY_MISSINGReady) { _INPUT_TRAY_MISSINGContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "INPUT_TRAY_MISSING"); _INPUT_TRAY_MISSINGReady = true; } return _INPUT_TRAY_MISSINGContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _INPUT_TRAY_MISSINGContent = default;
        private static bool _INPUT_TRAY_MISSINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#INTERLOCK_OPEN"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason INTERLOCK_OPEN { get { if (!_INTERLOCK_OPENReady) { _INTERLOCK_OPENContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "INTERLOCK_OPEN"); _INTERLOCK_OPENReady = true; } return _INTERLOCK_OPENContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _INTERLOCK_OPENContent = default;
        private static bool _INTERLOCK_OPENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#INTERPRETER_RESOURCE_UNAVAILABLE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason INTERPRETER_RESOURCE_UNAVAILABLE { get { if (!_INTERPRETER_RESOURCE_UNAVAILABLEReady) { _INTERPRETER_RESOURCE_UNAVAILABLEContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "INTERPRETER_RESOURCE_UNAVAILABLE"); _INTERPRETER_RESOURCE_UNAVAILABLEReady = true; } return _INTERPRETER_RESOURCE_UNAVAILABLEContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _INTERPRETER_RESOURCE_UNAVAILABLEContent = default;
        private static bool _INTERPRETER_RESOURCE_UNAVAILABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MARKER_SUPPLY_EMPTY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MARKER_SUPPLY_EMPTY { get { if (!_MARKER_SUPPLY_EMPTYReady) { _MARKER_SUPPLY_EMPTYContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MARKER_SUPPLY_EMPTY"); _MARKER_SUPPLY_EMPTYReady = true; } return _MARKER_SUPPLY_EMPTYContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _MARKER_SUPPLY_EMPTYContent = default;
        private static bool _MARKER_SUPPLY_EMPTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MARKER_SUPPLY_LOW"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MARKER_SUPPLY_LOW { get { if (!_MARKER_SUPPLY_LOWReady) { _MARKER_SUPPLY_LOWContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MARKER_SUPPLY_LOW"); _MARKER_SUPPLY_LOWReady = true; } return _MARKER_SUPPLY_LOWContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _MARKER_SUPPLY_LOWContent = default;
        private static bool _MARKER_SUPPLY_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MARKER_WASTE_ALMOST_FULL"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MARKER_WASTE_ALMOST_FULL { get { if (!_MARKER_WASTE_ALMOST_FULLReady) { _MARKER_WASTE_ALMOST_FULLContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MARKER_WASTE_ALMOST_FULL"); _MARKER_WASTE_ALMOST_FULLReady = true; } return _MARKER_WASTE_ALMOST_FULLContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _MARKER_WASTE_ALMOST_FULLContent = default;
        private static bool _MARKER_WASTE_ALMOST_FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MARKER_WASTE_FULL"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MARKER_WASTE_FULL { get { if (!_MARKER_WASTE_FULLReady) { _MARKER_WASTE_FULLContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MARKER_WASTE_FULL"); _MARKER_WASTE_FULLReady = true; } return _MARKER_WASTE_FULLContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _MARKER_WASTE_FULLContent = default;
        private static bool _MARKER_WASTE_FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MEDIA_EMPTY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MEDIA_EMPTY { get { if (!_MEDIA_EMPTYReady) { _MEDIA_EMPTYContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MEDIA_EMPTY"); _MEDIA_EMPTYReady = true; } return _MEDIA_EMPTYContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _MEDIA_EMPTYContent = default;
        private static bool _MEDIA_EMPTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MEDIA_JAM"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MEDIA_JAM { get { if (!_MEDIA_JAMReady) { _MEDIA_JAMContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MEDIA_JAM"); _MEDIA_JAMReady = true; } return _MEDIA_JAMContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _MEDIA_JAMContent = default;
        private static bool _MEDIA_JAMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MEDIA_LOW"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MEDIA_LOW { get { if (!_MEDIA_LOWReady) { _MEDIA_LOWContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MEDIA_LOW"); _MEDIA_LOWReady = true; } return _MEDIA_LOWContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _MEDIA_LOWContent = default;
        private static bool _MEDIA_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MEDIA_NEEDED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MEDIA_NEEDED { get { if (!_MEDIA_NEEDEDReady) { _MEDIA_NEEDEDContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MEDIA_NEEDED"); _MEDIA_NEEDEDReady = true; } return _MEDIA_NEEDEDContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _MEDIA_NEEDEDContent = default;
        private static bool _MEDIA_NEEDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MOVING_TO_PAUSED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MOVING_TO_PAUSED { get { if (!_MOVING_TO_PAUSEDReady) { _MOVING_TO_PAUSEDContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MOVING_TO_PAUSED"); _MOVING_TO_PAUSEDReady = true; } return _MOVING_TO_PAUSEDContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _MOVING_TO_PAUSEDContent = default;
        private static bool _MOVING_TO_PAUSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#OPC_LIFE_OVER"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason OPC_LIFE_OVER { get { if (!_OPC_LIFE_OVERReady) { _OPC_LIFE_OVERContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "OPC_LIFE_OVER"); _OPC_LIFE_OVERReady = true; } return _OPC_LIFE_OVERContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _OPC_LIFE_OVERContent = default;
        private static bool _OPC_LIFE_OVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#OPC_NEAR_EOL"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason OPC_NEAR_EOL { get { if (!_OPC_NEAR_EOLReady) { _OPC_NEAR_EOLContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "OPC_NEAR_EOL"); _OPC_NEAR_EOLReady = true; } return _OPC_NEAR_EOLContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _OPC_NEAR_EOLContent = default;
        private static bool _OPC_NEAR_EOLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#OTHER"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason OTHER { get { if (!_OTHERReady) { _OTHERContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "OTHER"); _OTHERReady = true; } return _OTHERContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _OTHERContent = default;
        private static bool _OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#OUTPUT_AREA_ALMOST_FULL"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason OUTPUT_AREA_ALMOST_FULL { get { if (!_OUTPUT_AREA_ALMOST_FULLReady) { _OUTPUT_AREA_ALMOST_FULLContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "OUTPUT_AREA_ALMOST_FULL"); _OUTPUT_AREA_ALMOST_FULLReady = true; } return _OUTPUT_AREA_ALMOST_FULLContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _OUTPUT_AREA_ALMOST_FULLContent = default;
        private static bool _OUTPUT_AREA_ALMOST_FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#OUTPUT_AREA_FULL"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason OUTPUT_AREA_FULL { get { if (!_OUTPUT_AREA_FULLReady) { _OUTPUT_AREA_FULLContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "OUTPUT_AREA_FULL"); _OUTPUT_AREA_FULLReady = true; } return _OUTPUT_AREA_FULLContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _OUTPUT_AREA_FULLContent = default;
        private static bool _OUTPUT_AREA_FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#OUTPUT_TRAY_MISSING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason OUTPUT_TRAY_MISSING { get { if (!_OUTPUT_TRAY_MISSINGReady) { _OUTPUT_TRAY_MISSINGContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "OUTPUT_TRAY_MISSING"); _OUTPUT_TRAY_MISSINGReady = true; } return _OUTPUT_TRAY_MISSINGContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _OUTPUT_TRAY_MISSINGContent = default;
        private static bool _OUTPUT_TRAY_MISSINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#PAUSED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason PAUSED { get { if (!_PAUSEDReady) { _PAUSEDContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "PAUSED"); _PAUSEDReady = true; } return _PAUSEDContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _PAUSEDContent = default;
        private static bool _PAUSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#SHUTDOWN"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason SHUTDOWN { get { if (!_SHUTDOWNReady) { _SHUTDOWNContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "SHUTDOWN"); _SHUTDOWNReady = true; } return _SHUTDOWNContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _SHUTDOWNContent = default;
        private static bool _SHUTDOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#SPOOL_AREA_FULL"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason SPOOL_AREA_FULL { get { if (!_SPOOL_AREA_FULLReady) { _SPOOL_AREA_FULLContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "SPOOL_AREA_FULL"); _SPOOL_AREA_FULLReady = true; } return _SPOOL_AREA_FULLContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _SPOOL_AREA_FULLContent = default;
        private static bool _SPOOL_AREA_FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#STOPPED_PARTLY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason STOPPED_PARTLY { get { if (!_STOPPED_PARTLYReady) { _STOPPED_PARTLYContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "STOPPED_PARTLY"); _STOPPED_PARTLYReady = true; } return _STOPPED_PARTLYContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _STOPPED_PARTLYContent = default;
        private static bool _STOPPED_PARTLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#STOPPING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason STOPPING { get { if (!_STOPPINGReady) { _STOPPINGContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "STOPPING"); _STOPPINGReady = true; } return _STOPPINGContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _STOPPINGContent = default;
        private static bool _STOPPINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#TIMED_OUT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason TIMED_OUT { get { if (!_TIMED_OUTReady) { _TIMED_OUTContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "TIMED_OUT"); _TIMED_OUTReady = true; } return _TIMED_OUTContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _TIMED_OUTContent = default;
        private static bool _TIMED_OUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#TONER_EMPTY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason TONER_EMPTY { get { if (!_TONER_EMPTYReady) { _TONER_EMPTYContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "TONER_EMPTY"); _TONER_EMPTYReady = true; } return _TONER_EMPTYContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _TONER_EMPTYContent = default;
        private static bool _TONER_EMPTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#TONER_LOW"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason TONER_LOW { get { if (!_TONER_LOWReady) { _TONER_LOWContent = SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "TONER_LOW"); _TONER_LOWReady = true; } return _TONER_LOWContent; } }
        private static Javax.Print.Attribute.Standard.PrinterStateReason _TONER_LOWContent = default;
        private static bool _TONER_LOWReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getCategory", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}