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

namespace Javax.Accessibility
{
    #region AccessibleState definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html"/>
    /// </summary>
    public partial class AccessibleState : Javax.Accessibility.AccessibleBundle
    {
        const string _bridgeClassName = "javax.accessibility.AccessibleState";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AccessibleState() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AccessibleState(params object[] args) : base(args) { }

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

    }
    #endregion

    #region AccessibleState
    public partial class AccessibleState
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#ACTIVE"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState ACTIVE { get { if (!_ACTIVEReady) { _ACTIVEContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "ACTIVE"); _ACTIVEReady = true; } return _ACTIVEContent; } }
        private static Javax.Accessibility.AccessibleState _ACTIVEContent = default;
        private static bool _ACTIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#ARMED"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState ARMED { get { if (!_ARMEDReady) { _ARMEDContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "ARMED"); _ARMEDReady = true; } return _ARMEDContent; } }
        private static Javax.Accessibility.AccessibleState _ARMEDContent = default;
        private static bool _ARMEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#BUSY"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState BUSY { get { if (!_BUSYReady) { _BUSYContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "BUSY"); _BUSYReady = true; } return _BUSYContent; } }
        private static Javax.Accessibility.AccessibleState _BUSYContent = default;
        private static bool _BUSYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#CHECKED"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState CHECKED { get { if (!_CHECKEDReady) { _CHECKEDContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "CHECKED"); _CHECKEDReady = true; } return _CHECKEDContent; } }
        private static Javax.Accessibility.AccessibleState _CHECKEDContent = default;
        private static bool _CHECKEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#COLLAPSED"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState COLLAPSED { get { if (!_COLLAPSEDReady) { _COLLAPSEDContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "COLLAPSED"); _COLLAPSEDReady = true; } return _COLLAPSEDContent; } }
        private static Javax.Accessibility.AccessibleState _COLLAPSEDContent = default;
        private static bool _COLLAPSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#EDITABLE"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState EDITABLE { get { if (!_EDITABLEReady) { _EDITABLEContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "EDITABLE"); _EDITABLEReady = true; } return _EDITABLEContent; } }
        private static Javax.Accessibility.AccessibleState _EDITABLEContent = default;
        private static bool _EDITABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#ENABLED"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState ENABLED { get { if (!_ENABLEDReady) { _ENABLEDContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "ENABLED"); _ENABLEDReady = true; } return _ENABLEDContent; } }
        private static Javax.Accessibility.AccessibleState _ENABLEDContent = default;
        private static bool _ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#EXPANDABLE"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState EXPANDABLE { get { if (!_EXPANDABLEReady) { _EXPANDABLEContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "EXPANDABLE"); _EXPANDABLEReady = true; } return _EXPANDABLEContent; } }
        private static Javax.Accessibility.AccessibleState _EXPANDABLEContent = default;
        private static bool _EXPANDABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#EXPANDED"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState EXPANDED { get { if (!_EXPANDEDReady) { _EXPANDEDContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "EXPANDED"); _EXPANDEDReady = true; } return _EXPANDEDContent; } }
        private static Javax.Accessibility.AccessibleState _EXPANDEDContent = default;
        private static bool _EXPANDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#FOCUSABLE"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState FOCUSABLE { get { if (!_FOCUSABLEReady) { _FOCUSABLEContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "FOCUSABLE"); _FOCUSABLEReady = true; } return _FOCUSABLEContent; } }
        private static Javax.Accessibility.AccessibleState _FOCUSABLEContent = default;
        private static bool _FOCUSABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#FOCUSED"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState FOCUSED { get { if (!_FOCUSEDReady) { _FOCUSEDContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "FOCUSED"); _FOCUSEDReady = true; } return _FOCUSEDContent; } }
        private static Javax.Accessibility.AccessibleState _FOCUSEDContent = default;
        private static bool _FOCUSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#HORIZONTAL"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState HORIZONTAL { get { if (!_HORIZONTALReady) { _HORIZONTALContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "HORIZONTAL"); _HORIZONTALReady = true; } return _HORIZONTALContent; } }
        private static Javax.Accessibility.AccessibleState _HORIZONTALContent = default;
        private static bool _HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#ICONIFIED"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState ICONIFIED { get { if (!_ICONIFIEDReady) { _ICONIFIEDContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "ICONIFIED"); _ICONIFIEDReady = true; } return _ICONIFIEDContent; } }
        private static Javax.Accessibility.AccessibleState _ICONIFIEDContent = default;
        private static bool _ICONIFIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#INDETERMINATE"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState INDETERMINATE { get { if (!_INDETERMINATEReady) { _INDETERMINATEContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "INDETERMINATE"); _INDETERMINATEReady = true; } return _INDETERMINATEContent; } }
        private static Javax.Accessibility.AccessibleState _INDETERMINATEContent = default;
        private static bool _INDETERMINATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#MANAGES_DESCENDANTS"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState MANAGES_DESCENDANTS { get { if (!_MANAGES_DESCENDANTSReady) { _MANAGES_DESCENDANTSContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "MANAGES_DESCENDANTS"); _MANAGES_DESCENDANTSReady = true; } return _MANAGES_DESCENDANTSContent; } }
        private static Javax.Accessibility.AccessibleState _MANAGES_DESCENDANTSContent = default;
        private static bool _MANAGES_DESCENDANTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#MODAL"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState MODAL { get { if (!_MODALReady) { _MODALContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "MODAL"); _MODALReady = true; } return _MODALContent; } }
        private static Javax.Accessibility.AccessibleState _MODALContent = default;
        private static bool _MODALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#MULTI_LINE"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState MULTI_LINE { get { if (!_MULTI_LINEReady) { _MULTI_LINEContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "MULTI_LINE"); _MULTI_LINEReady = true; } return _MULTI_LINEContent; } }
        private static Javax.Accessibility.AccessibleState _MULTI_LINEContent = default;
        private static bool _MULTI_LINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#MULTISELECTABLE"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState MULTISELECTABLE { get { if (!_MULTISELECTABLEReady) { _MULTISELECTABLEContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "MULTISELECTABLE"); _MULTISELECTABLEReady = true; } return _MULTISELECTABLEContent; } }
        private static Javax.Accessibility.AccessibleState _MULTISELECTABLEContent = default;
        private static bool _MULTISELECTABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#OPAQUE"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState OPAQUE { get { if (!_OPAQUEReady) { _OPAQUEContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "OPAQUE"); _OPAQUEReady = true; } return _OPAQUEContent; } }
        private static Javax.Accessibility.AccessibleState _OPAQUEContent = default;
        private static bool _OPAQUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#PRESSED"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState PRESSED { get { if (!_PRESSEDReady) { _PRESSEDContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "PRESSED"); _PRESSEDReady = true; } return _PRESSEDContent; } }
        private static Javax.Accessibility.AccessibleState _PRESSEDContent = default;
        private static bool _PRESSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#RESIZABLE"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState RESIZABLE { get { if (!_RESIZABLEReady) { _RESIZABLEContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "RESIZABLE"); _RESIZABLEReady = true; } return _RESIZABLEContent; } }
        private static Javax.Accessibility.AccessibleState _RESIZABLEContent = default;
        private static bool _RESIZABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#SELECTABLE"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState SELECTABLE { get { if (!_SELECTABLEReady) { _SELECTABLEContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "SELECTABLE"); _SELECTABLEReady = true; } return _SELECTABLEContent; } }
        private static Javax.Accessibility.AccessibleState _SELECTABLEContent = default;
        private static bool _SELECTABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#SELECTED"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState SELECTED { get { if (!_SELECTEDReady) { _SELECTEDContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "SELECTED"); _SELECTEDReady = true; } return _SELECTEDContent; } }
        private static Javax.Accessibility.AccessibleState _SELECTEDContent = default;
        private static bool _SELECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#SHOWING"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState SHOWING { get { if (!_SHOWINGReady) { _SHOWINGContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "SHOWING"); _SHOWINGReady = true; } return _SHOWINGContent; } }
        private static Javax.Accessibility.AccessibleState _SHOWINGContent = default;
        private static bool _SHOWINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#SINGLE_LINE"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState SINGLE_LINE { get { if (!_SINGLE_LINEReady) { _SINGLE_LINEContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "SINGLE_LINE"); _SINGLE_LINEReady = true; } return _SINGLE_LINEContent; } }
        private static Javax.Accessibility.AccessibleState _SINGLE_LINEContent = default;
        private static bool _SINGLE_LINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#TRANSIENT"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState TRANSIENT { get { if (!_TRANSIENTReady) { _TRANSIENTContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "TRANSIENT"); _TRANSIENTReady = true; } return _TRANSIENTContent; } }
        private static Javax.Accessibility.AccessibleState _TRANSIENTContent = default;
        private static bool _TRANSIENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#TRUNCATED"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState TRUNCATED { get { if (!_TRUNCATEDReady) { _TRUNCATEDContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "TRUNCATED"); _TRUNCATEDReady = true; } return _TRUNCATEDContent; } }
        private static Javax.Accessibility.AccessibleState _TRUNCATEDContent = default;
        private static bool _TRUNCATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#VERTICAL"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState VERTICAL { get { if (!_VERTICALReady) { _VERTICALContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "VERTICAL"); _VERTICALReady = true; } return _VERTICALContent; } }
        private static Javax.Accessibility.AccessibleState _VERTICALContent = default;
        private static bool _VERTICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleState.html#VISIBLE"/>
        /// </summary>
        public static Javax.Accessibility.AccessibleState VISIBLE { get { if (!_VISIBLEReady) { _VISIBLEContent = SGetField<Javax.Accessibility.AccessibleState>(LocalBridgeClazz, "VISIBLE"); _VISIBLEReady = true; } return _VISIBLEContent; } }
        private static Javax.Accessibility.AccessibleState _VISIBLEContent = default;
        private static bool _VISIBLEReady = false; // this is used because in case of generics 

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