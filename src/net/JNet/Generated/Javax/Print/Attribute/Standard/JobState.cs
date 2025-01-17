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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Attribute.Standard
{
    #region JobState declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html"/>
    /// </summary>
    public partial class JobState : Javax.Print.Attribute.EnumSyntax
    {
        const string _bridgeClassName = "javax.print.attribute.standard.JobState";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JobState() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JobState(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region JobState implementation
    public partial class JobState
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.JobState"/> to <see cref="Javax.Print.Attribute.PrintJobAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintJobAttribute(Javax.Print.Attribute.Standard.JobState t) => t.Cast<Javax.Print.Attribute.PrintJobAttribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#ABORTED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState ABORTED { get { if (!_ABORTEDReady) { _ABORTEDContent = SGetField<Javax.Print.Attribute.Standard.JobState>(LocalBridgeClazz, "ABORTED"); _ABORTEDReady = true; } return _ABORTEDContent; } }
        private static Javax.Print.Attribute.Standard.JobState _ABORTEDContent = default;
        private static bool _ABORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#CANCELED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState CANCELED { get { if (!_CANCELEDReady) { _CANCELEDContent = SGetField<Javax.Print.Attribute.Standard.JobState>(LocalBridgeClazz, "CANCELED"); _CANCELEDReady = true; } return _CANCELEDContent; } }
        private static Javax.Print.Attribute.Standard.JobState _CANCELEDContent = default;
        private static bool _CANCELEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#COMPLETED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState COMPLETED { get { if (!_COMPLETEDReady) { _COMPLETEDContent = SGetField<Javax.Print.Attribute.Standard.JobState>(LocalBridgeClazz, "COMPLETED"); _COMPLETEDReady = true; } return _COMPLETEDContent; } }
        private static Javax.Print.Attribute.Standard.JobState _COMPLETEDContent = default;
        private static bool _COMPLETEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#PENDING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState PENDING { get { if (!_PENDINGReady) { _PENDINGContent = SGetField<Javax.Print.Attribute.Standard.JobState>(LocalBridgeClazz, "PENDING"); _PENDINGReady = true; } return _PENDINGContent; } }
        private static Javax.Print.Attribute.Standard.JobState _PENDINGContent = default;
        private static bool _PENDINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#PENDING_HELD"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState PENDING_HELD { get { if (!_PENDING_HELDReady) { _PENDING_HELDContent = SGetField<Javax.Print.Attribute.Standard.JobState>(LocalBridgeClazz, "PENDING_HELD"); _PENDING_HELDReady = true; } return _PENDING_HELDContent; } }
        private static Javax.Print.Attribute.Standard.JobState _PENDING_HELDContent = default;
        private static bool _PENDING_HELDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#PROCESSING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState PROCESSING { get { if (!_PROCESSINGReady) { _PROCESSINGContent = SGetField<Javax.Print.Attribute.Standard.JobState>(LocalBridgeClazz, "PROCESSING"); _PROCESSINGReady = true; } return _PROCESSINGContent; } }
        private static Javax.Print.Attribute.Standard.JobState _PROCESSINGContent = default;
        private static bool _PROCESSINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#PROCESSING_STOPPED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState PROCESSING_STOPPED { get { if (!_PROCESSING_STOPPEDReady) { _PROCESSING_STOPPEDContent = SGetField<Javax.Print.Attribute.Standard.JobState>(LocalBridgeClazz, "PROCESSING_STOPPED"); _PROCESSING_STOPPEDReady = true; } return _PROCESSING_STOPPEDContent; } }
        private static Javax.Print.Attribute.Standard.JobState _PROCESSING_STOPPEDContent = default;
        private static bool _PROCESSING_STOPPEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#UNKNOWN"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Javax.Print.Attribute.Standard.JobState>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static Javax.Print.Attribute.Standard.JobState _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getCategory", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#getName()"/> 
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